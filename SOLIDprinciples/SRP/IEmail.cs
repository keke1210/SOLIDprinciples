using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.SRP
{
    public interface IEmail
    {
        void SendEmail(string emailContent);
    }
}
