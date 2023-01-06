using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchSEO.DataAccessLayer
{
    /// <summary>
    ///     This class acts as an object to store data which is used to pull data from online rest services
    /// </summary>
    internal class ServiceModule
    {
        /* ====================================== */
        /* ========== Object Variables ========== */
        /* ====================================== */
        /// <summary>
        ///     Stores the service's URL that will be used as a data source
        /// </summary>
        private String DataSourceService { get; set; }

        /// <summary>
        ///     Stores the credential ID that is used to login to the data source
        /// </summary>
        private String CredentialsID { get; set; }

        /// <summary>
        ///     Stores the credential's secret that is to login to the data source
        /// </summary>
        private String CredentialsSecret { get; set; }

        /// <summary>
        ///     Stores whether the module is enabled or not
        /// </summary>
        private Boolean Enabled { get; set; }
    }
}
