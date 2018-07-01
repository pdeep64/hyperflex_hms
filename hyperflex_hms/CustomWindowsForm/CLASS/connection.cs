﻿using CustomWindowsForm.FORMS;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomWindowsForm.CLASS
{
    class CONNECTION
    {
        public static MySqlConnection CON = new MySqlConnection("Server = " + GetServer() + ";userid=hyperfle;password=q8Ys0n3g5K;database=hyperfle_hms;");
        public static string GetServer()
        {
            string serverip = Application.StartupPath + "\\config.ini";
            string ip;
            StreamReader oReader = new StreamReader(serverip);
            ip = null;
            if (File.Exists(serverip))
            {
                ip = oReader.ReadToEnd();
                oReader.Close();
            }
            else
            {
                MSGBOX mdg = new MSGBOX(MessageAlertHeder.Warning(), "invalied ip address",MessageAlertImage.Warning());
                mdg.ShowDialog();
                Application.Exit();
            }
            return ip;
        }
        public static void open_connection()
        {
            if (CON.State == ConnectionState.Closed)
            {
                CON.Open();
            }
            else
            {
                return;
            }
        }
        public static void close_connection()
        {
            if (CON.State == ConnectionState.Open)
            {
                CON.Close();
            }
            else
            {
                return;
            }
        }
    }
}
