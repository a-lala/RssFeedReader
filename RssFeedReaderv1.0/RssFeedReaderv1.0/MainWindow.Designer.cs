namespace RssFeedReaderv1._0
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtboxRsslink = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemsNewsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsNewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rsslinksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rsslinkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rsslinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rsslinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rssFeedDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new RssFeedReaderv1._0.DatabaseDataSet();
            this.itemsNewsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsNewsTableAdapter = new RssFeedReaderv1._0.DatabaseDataSetTableAdapters.ItemsNewsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsNewsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsNewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsslinksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsslinkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsslinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsslinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssFeedDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsNewsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxRsslink
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtboxRsslink, 2);
            this.txtboxRsslink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxRsslink.Location = new System.Drawing.Point(5, 2);
            this.txtboxRsslink.Margin = new System.Windows.Forms.Padding(5, 2, 2, 0);
            this.txtboxRsslink.MaximumSize = new System.Drawing.Size(10000, 50);
            this.txtboxRsslink.Name = "txtboxRsslink";
            this.txtboxRsslink.Size = new System.Drawing.Size(949, 20);
            this.txtboxRsslink.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Controls.Add(this.txtboxRsslink, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.444445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(956, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 415);
            this.dataGridView1.TabIndex = 2;
            // 
            // itemsNewsBindingSource1
            // 
            this.itemsNewsBindingSource1.DataMember = "ItemsNews";
            // 
            // itemsNewsBindingSource
            // 
            this.itemsNewsBindingSource.DataMember = "ItemsNews";
            // 
            // rsslinksBindingSource1
            // 
            this.rsslinksBindingSource1.DataMember = "rsslinks";
            // 
            // rsslinkBindingSource1
            // 
            this.rsslinkBindingSource1.DataMember = "rsslink";
            // 
            // rsslinkBindingSource
            // 
            this.rsslinkBindingSource.DataMember = "rsslink";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            // 
            // rsslinksBindingSource
            // 
            this.rsslinksBindingSource.DataMember = "rsslinks";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsNewsBindingSource2
            // 
            this.itemsNewsBindingSource2.DataMember = "ItemsNews";
            this.itemsNewsBindingSource2.DataSource = this.databaseDataSet;
            // 
            // itemsNewsTableAdapter
            // 
            this.itemsNewsTableAdapter.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsNewsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsNewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsslinksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsslinkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsslinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsslinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssFeedDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsNewsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxRsslink;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rssFeedDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource rsslinksBindingSource;
        private System.Windows.Forms.BindingSource rsslinkBindingSource;
        private System.Windows.Forms.BindingSource rsslinkBindingSource1;
        private System.Windows.Forms.BindingSource rsslinksBindingSource1;

        private System.Windows.Forms.BindingSource itemsNewsBindingSource;


        private System.Windows.Forms.BindingSource itemsNewsBindingSource1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource itemsNewsBindingSource2;
        private DatabaseDataSetTableAdapters.ItemsNewsTableAdapter itemsNewsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}

