using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Sales;
using Zulu.BusinessService.Products;
using Zulu.BusinessService.Settings;

namespace PortablePointOfSale.Controls
{
	public partial class BaseZuluUserControl : UserControl
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
	}
}
