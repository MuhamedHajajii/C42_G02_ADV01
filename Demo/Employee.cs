using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public readonly override string ToString()
        {
            return $"Id {Id} , name {Name} , salary {Salary}";
        }

        public static bool operator ==(Employee left,Employee right)
        {            
            //return (left.Id == right.Id) && (left.Name == right.Name) && (left.Salary == right.Salary);
            return left.Equals(right);
        }
        public static bool operator !=(Employee left, Employee right)
        {
            //return (left.Id != right.Id) || (left.Name != right.Name ) || (left.Salary != right.Salary);
            return !left.Equals(right);
        }

    }
}
