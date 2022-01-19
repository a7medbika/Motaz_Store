﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motaz_Store
{
    public static class Program
    {
        public static MainForm main;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myDB.OpenConn();
            main = new MainForm();
            Application.Run(main);
            myDB.CloseConn();
        }
    }
}
