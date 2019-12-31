﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.OCP
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {}
        public PermanentEmployee(int id, string name) : base(id, name)
        {}


        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
