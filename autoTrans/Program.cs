﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoTrans
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Tiket());
            //Application.Run(new LaporanBulanan());
            //Application.Run(new LaporanHarianManajer());
            Application.Run(new LoginForm());
            //Application.Run(new laporanForm());
            //Application.Run(new penambahanMobil());
        }
    }
}
