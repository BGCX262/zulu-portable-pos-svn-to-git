﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Zulu.BusinessService.Configuration
{
    public partial class ZuluConfig : IConfigurationSectionHandler
    {
        #region Fields
        private static string _connectionString = "";
        private static bool _initialized;
        private static int _cookieExpires = 128;
        private static XmlNode _scheduleTasks;
        #endregion

        #region Methods
        /// <summary>
        /// Creates a configuration section handler.
        /// </summary>
        /// <param name="parent">Parent object.</param>
        /// <param name="configContext">Configuration context object.</param>
        /// <param name="section">Section XML node.</param>
        /// <returns>The created section handler object.</returns>
        public object Create(object parent, object configContext, XmlNode section)
        {
            XmlNode sqlServerNode = section.SelectSingleNode("SqlServer");
            if (sqlServerNode != null)
            {
                XmlAttribute attribute = sqlServerNode.Attributes["ConnectionStringName"];

                if ((attribute != null) && (ConfigurationManager.ConnectionStrings[attribute.Value] != null))
                    _connectionString = ConfigurationManager.ConnectionStrings[attribute.Value].ConnectionString;
            }

            _scheduleTasks = section.SelectSingleNode("ScheduleTasks");

            return null;
        }

        /// <summary>
        /// Initializes the NopConfig object
        /// </summary>
        public static void Init()
        {
            if (!_initialized)
            {
                ConfigurationManager.GetSection("ZuluConfig");
                _initialized = true;
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the connection string that is used to connect to the storage
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        /// <summary>
        /// Gets or sets the expiration date and time for the Cookie in hours
        /// </summary>
        public static int CookieExpires
        {
            get
            {
                return _cookieExpires;
            }
            set
            {
                _cookieExpires = value;
            }
        }

        /// <summary>
        /// Gets or sets a schedule tasks section
        /// </summary>
        public static XmlNode ScheduleTasks
        {
            get
            {
                return _scheduleTasks;
            }
            set
            {
                _scheduleTasks = value;
            }
        }
        #endregion
    }
}
