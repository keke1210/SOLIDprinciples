using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.ISP.Client
{
    public class HPLaserJet : IPrintTasks
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done");
            return true;

        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }

        public bool PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
