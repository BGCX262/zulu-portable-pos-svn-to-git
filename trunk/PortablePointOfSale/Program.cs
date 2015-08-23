using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Configuration;
using PortablePointOfSale;
using PortablePointOfSale.Testing;
using Zulu.BusinessService;
using PortablePointOfSale.Products;
using PortablePointOfSale.Users;
using PortablePointOfSale.Sales;
using ProtablePointOfSale.Main;
using ProtablePointOfSale.ReportForm;


namespace Zulu.PointOfSaleManagement
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
            ZuluConfig.Init();
            IoC.InitializeWith(new DependencyResolverFactory());

            Application.Run(new frmCryReport());
        }
    }
}
