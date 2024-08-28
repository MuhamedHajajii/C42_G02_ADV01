using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // here i can compare the references or the object state
    internal class Employee2
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id => {Id},Name {Name}=> ,Salary => {Salary}";
        }

        public static bool operator ==(Employee2 left,Employee2 right)
        {
            return left.Equals(right) ; 
        }

        public static bool operator !=(Employee2 left, Employee2 right)
        {
            return left.Equals(right);
        }

        public override bool Equals(object? obj)
        {
            Employee2? employee2 = obj as Employee2; // explicit casting unsafe
                                                     // maybe throw excpetion
            return (this.Id == employee2?.Id) && (this.Name == employee2?.Name) && (this.Salary == employee2?.Salary);//object state
        }

        public override int GetHashCode()
        {
            // Id
            // Name
            // Salary
            //return this.Id.GetHashCode()+this?.Name?.GetHashCode() ?? 0+this.Salary.GetHashCode();
            return HashCode.Combine(Id.GetHashCode(), Name?.GetHashCode(), Salary.GetHashCode());
        }

    }
}
