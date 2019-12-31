using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.ISP.SegregrationInterfaces
{
    public interface IFaxContent
    {
        bool FaxContent(string content);
    }
}
