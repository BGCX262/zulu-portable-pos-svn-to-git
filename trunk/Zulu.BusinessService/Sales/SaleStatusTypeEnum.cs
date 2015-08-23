using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zulu.BusinessService.Sales
{
	public enum SaleStatusTypeEnum : int
	{
		/// <summary>
		/// Sale pending
		/// </summary>
		Pending = 1,

		/// <summary>
		/// Sale finished
		/// </summary>
		Finished = 2,
	}
}
