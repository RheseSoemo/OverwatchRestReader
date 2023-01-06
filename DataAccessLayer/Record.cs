using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchSEO.DataAccessLayer
{
    /// <summary>
    ///     This class acts as an object to store past reports that were generated
    /// </summary>
    internal class Record
    {
        /* ====================================== */
        /* ========== Object Variables ========== */
        /* ====================================== */
        /// <summary>
        ///     Stores the date and time of the records creation
        /// </summary>
        public DateTime Creation { get; set; }

        /// <summary>
        ///     Stores the service module that was used to generate this record
        /// </summary>
        public String ServiceModule { get; set; }
        
        /// <summary>
        ///     Stores the information that was sent to the service module
        /// </summary>
        public String InformationSent { get; set; }
        
        /// <summary>
        ///     Stores the conents reply from the service that were saved
        /// </summary>
        public String RecordContents { get; set; }

    }
}
