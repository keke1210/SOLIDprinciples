﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.ISP.Client
{
    public class CannonMG2470 : IPrintTasks
    {
        public bool FaxContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
