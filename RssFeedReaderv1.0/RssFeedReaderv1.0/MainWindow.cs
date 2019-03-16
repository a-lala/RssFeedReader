using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Configuration;

namespace RssFeedReaderv1._0
{
    public partial class MainWindow : Form
    {

        //private DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Database.mdf;" +
                    "Integrated Security=True";
        private string ITEMS_NEWS_SELECT = "select title as 'عنوان', content as 'شرح', date as 'تاريخ'  from ItemsNews ORDER BY date Asc";

        public MainWindow()
        {
            InitializeComponent();

            /// for using the db from App_Data folder.....
            string workingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\App_Data\";
            AppDomain.CurrentDomain.SetData("DataDirectory", workingDirectory);

            timer1.Interval = 20000;
            timer1.Tick += new EventHandler(Timer_Tick);

            // Enable timer.  
            timer1.Enabled = true;

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Parallel.ForEach(getRssLinks(),s => 
            {
                getRssFeedFileUrl(s);
            });
        }

        public void getRssFeedFileUrl(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream rssStream = response.GetResponseStream();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rssStream);
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("//rss/channel/item");
            int id = insert_rss_link(url);
            try
            {
                string Itemcontent = null;
                string Itemtitle = null;
                string rsslink = txtboxRsslink.Text;
                for (int i = 0; i < xmlNodeList.Count; i++)
                {
                    Itemtitle = xmlNodeList.Item(i).SelectSingleNode("title").InnerText;
                    Itemcontent = xmlNodeList.Item(i).SelectSingleNode("description").InnerText;

                    //  insert to db
                    insertRssItem(Itemtitle, Itemcontent, id);
                }
            }
            catch (Exception ex)
            {
                Console.Write("ERORR:" + ex.ToString());
            }

        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. 
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                //// Resize the DataGridView columns to fit the newly loaded content.
                //dataGridView1.AutoResizeColumns(
                //    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("failure connection to db.");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData(ITEMS_NEWS_SELECT);
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                getRssFeedFileUrl(txtboxRsslink.Text);

                GetData(dataAdapter.SelectCommand.CommandText);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }




        #region Stored Procedures

        public int insert_rss_link(string rssLink)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
                {
                    using (SqlCommand cmd = new SqlCommand("insertRssLink", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@link", SqlDbType.NVarChar).Value = rssLink;
                        SqlParameter sqp = new SqlParameter("@id", SqlDbType.Int);
                        sqp.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(sqp);
                        con.Open();
                        cmd.ExecuteScalar();
                        return Convert.ToInt32(sqp.Value);
                    }
                }
            }
            catch (Exception)
            {

            }
            return -1;
        }

        public List<string> getRssLinks()
        {
            try
            {


                List<string> columnData = new List<string>();

                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    string query = "SELECT link from links";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                columnData.Add(reader.GetString(0));
                            }
                        }
                    }
                    return columnData;
                }
            }
            catch (Exception)
            {
            }
            return null;
        }

        private void insertRssItem(string title, string content, int rsslink)
        {
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand("insertRssItem", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
                    cmd.Parameters.Add("@content", SqlDbType.NVarChar).Value = content;
                    cmd.Parameters.Add("@link", SqlDbType.Int).Value = rsslink;
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
            }
        }
        #endregion

    }
}
