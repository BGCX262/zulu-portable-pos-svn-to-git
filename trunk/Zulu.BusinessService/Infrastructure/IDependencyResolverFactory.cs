using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zulu.BusinessService.Infrastructure
{
    /// <summary>
    /// Dependency resolver factory
    /// </summary>
    public interface IDependencyResolverFactory
    {
        /// <summary>
        /// Create dependency resolver
        /// </summary>
        /// <returns>Dependency resolver</returns>
        IDependencyResolver CreateInstance();
    }
}
