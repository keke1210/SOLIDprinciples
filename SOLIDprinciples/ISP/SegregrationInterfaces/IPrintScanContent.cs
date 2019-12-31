using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.ISP.SegregrationInterfaces
{
    public interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }
}
