using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // i only can comapre the object state
    internal struct Employee : IComparable
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public int CompareTo(object? obj)
        {
            // sorting based on salary
            //Employee? PassedEmployee = (Employee?)obj; // UnSafe // maythrow exception
            // Is conditional operator [True , False]
            // this operator will return true in two cases
            // obj is a employee
            // obj is an object from another class but it inherit from employee
            // As Casting Operator

            if(obj is Employee PassedEmployee)
            {
                return this.Salary.CompareTo(PassedEmployee.Salary);
            }
            return 1;

        }

        public readonly override string ToString()
        {
            return $"Id {Id} , name {Name} , salary {Salary}";
        }

        public static bool operator ==(Employee left, Employee right)
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
