﻿using System;
using System.Windows.Forms;

namespace WindowsFormsTrolleybus
{
    public delegate void busDelegate(ITransport bus);
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormBusStation());
        }
    }
}
