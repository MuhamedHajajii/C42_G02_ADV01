namespace Demo
{
    internal class Program
    {
        static void Main()
        {

            #region Generics EX01
            // --> Generics
            // We were using object instead of generics 

            //int A = 10, B = 20;
            //Console.WriteLine($"(A) => {A}");
            //Console.WriteLine($"(B) => {B}");

            //Helper<int>.Swap(ref A, ref B);

            //Console.WriteLine("======================");

            //Console.WriteLine($"(A) => {A}");
            //Console.WriteLine($"(B) => {B}");

            //Console.WriteLine("======================");

            //double Z = 10.2, Y = 20.6;
            //Console.WriteLine($"(A) => {Z}");
            //Console.WriteLine($"(B) => {Y}");

            //Helper<double>.Swap(ref A, ref B);

            //Console.WriteLine("======================");

            //Console.WriteLine($"(A) => {Z}");
            //Console.WriteLine($"(B) => {Y}");

            //Console.WriteLine("======================");

            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(10, 20);

            //Console.WriteLine("P01=> " + P01);
            //Console.WriteLine("P02=> " + P02);

            //Console.WriteLine("======================");
            //// we write it only for readability
            //// depend on the place you will use it within
            //// if you will use it only inside the function just declare it in the method
            //// in case the generic type delcare on the class you should send the datatype while the calling for the 
            //// class and you can use it with the calss and the struct and the interface
            //Helper<Point>.Swap<Point>(ref P01, ref P02);

            //Console.WriteLine("P01=> " + P01);
            //Console.WriteLine("P02=> " + P02);

            #endregion

            #region Generics EX02

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //int index = Helper.searchArr(numbers, 6);
            //Console.WriteLine("Index => " + index);

            //Employee e01 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Test01",
            //    Salary = 2000
            //};
            //Employee e02 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Test02",
            //    Salary = 5000
            //};
            //Employee e03 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Test02",
            //    Salary = 5000
            //};

            //if (e01 == e02)
            //    Console.WriteLine("Equals");
            //else Console.WriteLine("Not Equal");

            //Console.WriteLine("=====================");

            //if (e01 != e03)
            //    Console.WriteLine("Not Equals");
            //else Console.WriteLine("Equal");

            //if (e01.Equals(e03))
            //    Console.WriteLine("Equals");
            //else Console.WriteLine("Not Equal");

            //Console.WriteLine("=====================");

            //Employee[] employeesArr =
            //{
            //    new Employee() { Id = 1 , Name = "emp01", Salary = 5000},
            //    e01 , e02 ,e03
            //};

            //int result01 = Helper<Employee>.searchArr(employeesArr, e01);
            //int result02 = Helper<Employee>.searchArr(employeesArr, e02);
            //int result03 = Helper<Employee>.searchArr(employeesArr, e03);
            //Console.WriteLine(result01);
            //Console.WriteLine(result02);
            //Console.WriteLine(result03);

            #endregion

            #region Generics EX03

            //Employee2 e01 = new Employee2()
            //{
            //    Id = 1,
            //    Name = "Test01",
            //    Salary = 2000
            //};
            //Employee2 e02 = new Employee2()
            //{
            //    Id = 1,
            //    Name = "Test02",
            //    Salary = 5000
            //};
            //Employee2 e03 = new Employee2()
            //{
            //    Id = 1,
            //    Name = "Test02",
            //    Salary = 5000
            //};

            //// it will comapre the reference with the reference
            //// with the class but with the struct it will comapre the object state {properties}
            //// i don't have identity in the value type

            //if (e02 == e03) // now it can comapre the object state
            //    Console.WriteLine("Yes Equals !!");
            //else Console.WriteLine("They Are Not Equals !!");

            //Console.WriteLine(e02.GetHashCode());
            //Console.WriteLine(e03.GetHashCode());

            //int X = 10;
            //string y = "Haji";
            //Console.WriteLine(X.GetHashCode());
            //Console.WriteLine(y.GetHashCode());

            #endregion

            #region EX04
            //int[] numbers= new int[] { 5, 6, 8, 6, 4, 9, 6, 21, 0 };
            ////int[] resultArr = ;
            //Helper<int>.SortArr(ref numbers);
            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");
            //}

            //Employee[] employees = new Employee[]
            //{
            //    new Employee() {Id = 1 ,Name = "Aliaa" , Salary = 9000},
            //    new Employee() {Id = 2 ,Name = "Hajajii" , Salary = 10000},
            //    new Employee() {Id = 3 ,Name = "Marwan" , Salary = 20000},
            //};

            //Helper<Employee>.SortArr(ref employees);

            //foreach (Employee employee in employees)
            //    {
            //    Console.WriteLine(employee);
            //}

            #endregion


        }
    }
}
