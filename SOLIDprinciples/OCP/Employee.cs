using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciples.OCP
{
    public abstract class Employee
    {
        public Employee() { }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public abstract decimal CalculateBonus(decimal salary);
       
    }
}
