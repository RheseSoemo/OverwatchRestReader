using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchSEO.DataAccessLayer
{
    /// <summary>
    ///     Stores the current state of various settings
    /// </summary>
    internal class Settings
    {
        /// <summary>
        ///     Stores the current list of automations
        /// </summary>
        ArrayList AutomationList = new ArrayList();

        /// <summary>
        ///     Stores the current theme of the application
        /// </summary>
        String CurrentTheme { get; set; }
    }
}
