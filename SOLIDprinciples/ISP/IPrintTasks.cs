﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.ISP
{
    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
        bool PrintDuplexContent(string content);
    }
}
