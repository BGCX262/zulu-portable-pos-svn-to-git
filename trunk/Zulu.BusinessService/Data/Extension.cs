using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;

namespace Zulu.BusinessService.Data
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Determines whether record is attached
        /// </summary>
        /// <param name="context">Context</param>
        /// <param name="entity">Entity</param>
        /// <returns>Result</returns>
        public static bool IsAttached(this ObjectContext context, object entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            ObjectStateEntry entry;
            try
            {
                entry = context.ObjectStateManager.GetObjectStateEntry(entity);
                return (entry.State != EntityState.Detached);
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.ToString());
            }
            return false;
        }


		//public static StaffAttribute FindAttribute(this List<StaffAttribute> source,
		// string key, int staffID)
		//{
		//    foreach (StaffAttribute customerAttribute in source)
		//    {
		//        if (customerAttribute.AttributeName.Equals(key, StringComparison.InvariantCultureIgnoreCase) &&
		//            customerAttribute.StaffID == staffID)
		//            return customerAttribute;
		//    }
		//    return null;
		//}
    }
}
