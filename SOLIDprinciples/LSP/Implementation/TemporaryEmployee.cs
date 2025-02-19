﻿using SOLIDprinciples.LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.LSP.Implementation
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
