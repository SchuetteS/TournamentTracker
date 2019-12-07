using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database == true)
            {
                // TODO - Create the SQL Connection
            }
            if (textFiles)
            {
                // TODO - Create the Text Connection
            }
        }
    }
}
