using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Products;
using Zulu.BusinessService;
using Zulu.BusinessService.Sales;
using Zulu.BusinessService.Settings;


namespace PortablePointOfSale.Controls
{
    public partial class BaseZuluFormControl : Form
    {
		public IUserService UserService
		{
			get { return IoC.Resolve<IUserService>(); }
		}

		public ISaleService SaleService
		{
			get { return IoC.Resolve<ISaleService>(); }
		}

        public IProductService ProductService
        {
            get { return IoC.Resolve<IProductService>(); }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseZuluFormControl
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.Name = "BaseZuluFormControl";
            this.ResumeLayout(false);
            //var test = ZuluContext.Current.CurrentUser.RestrictedFormControls.ToList();
        }

	
 
    }
}
