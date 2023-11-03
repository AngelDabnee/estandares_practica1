﻿using practica_PDV.FromProductos;
using practica_PDV.FRONT.FromCustomers;
using practica_PDV.FRONT.FromCustomers.FormNewCustomers;
using practica_PDV.FRONT.FromCustomers.FormUpdateCustomers;
using practica_PDV.FRONT.FromInsert;
using practica_PDV.FRONT.FromSuppliers;
using practica_PDV.FRONT.FromUsers;
using practica_PDV.LOGIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_PDV
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSupplier());
        }
    }
}
