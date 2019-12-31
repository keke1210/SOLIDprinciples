using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.LSP.Interface
{
    public interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
