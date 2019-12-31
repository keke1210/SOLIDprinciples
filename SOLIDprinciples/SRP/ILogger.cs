using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.SRP
{
    public interface ILogger
    {
        void LogError(string error);
    }
}
