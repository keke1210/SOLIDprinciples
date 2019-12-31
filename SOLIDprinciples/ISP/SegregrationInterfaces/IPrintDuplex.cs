using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.ISP.SegregrationInterfaces
{
    public interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
