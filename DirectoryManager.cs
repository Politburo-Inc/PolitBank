using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitBank
{
    internal static class DirectoryManager
    {
        private static string DATAPath = @"../../../DATA";
        private static string XMLPath = @"../../../DATA/XML";
        private static string LOGPath = @"../../../DATA/LOG"; 
        internal static void createDirectories()
        {
            if (!Directory.Exists(DATAPath))
            {
                Console.WriteLine("No DATA Path detected, creating...");
                Directory.CreateDirectory(DATAPath);    
            }
            else
            {
                Console.WriteLine("DATA Path validated!");
            }
            if (!Directory.Exists(XMLPath))
            {
                Console.WriteLine("No XML Path detected, creating...");
                Directory.CreateDirectory(XMLPath);
            }
            else
            {
                Console.WriteLine("XML Path validated!");
            }
            if (!Directory.Exists(LOGPath))
            {
                Console.WriteLine("No LOG Path detected, creating...");
                Directory.CreateDirectory (LOGPath);
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
