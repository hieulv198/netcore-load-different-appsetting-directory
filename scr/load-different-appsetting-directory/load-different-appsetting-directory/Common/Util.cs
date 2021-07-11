using System;
using System.Linq;

namespace load_different_appsetting_directory.Common
{
    public class Util
    {
        public static string GetBasePath()
        {
            
            var cmArgs = Environment.GetCommandLineArgs();
            var basePathArg = cmArgs.Select((value, index) => (value, index))
                .FirstOrDefault(i => i.value.Equals("--basePath"));
            
            return cmArgs[basePathArg.index+1];
        }
    }
}
