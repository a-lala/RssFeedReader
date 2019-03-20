USE [master]
GO

/****** Object:  Database [dbRss2]    Script Date: 3/19/2019 11:50:24 PM ******/
CREATE DATABASE [dbRss2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbRss2', FILENAME = N'E:\databases\dbRss2.mdf' , SIZE = 14096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbRss2_log', FILENAME = N'E:\databases\dbRss2_log.ldf' , SIZE = 11200KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
