using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.LSP.Interface
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}
