using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "C:\\Users\\yuhu0001.KEYSIGHT\\source\\repos\\TekSight_Thermal_Chamber\\WpfApp1\\log4net.config", Watch = true)]

namespace WpfApp1.AppHelper
{
    public class LogHelper
    {
        public static log4net.ILog GetLogger([CallerFilePath] string filename = "")
        {
            string name = Path.GetFileNameWithoutExtension(filename);
            return log4net.LogManager.GetLogger(name);
        }
    }
}
