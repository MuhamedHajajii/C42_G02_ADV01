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

            Employee e01 = new Employee()
            {
                Id = 1,
                Name = "Test01",
                Salary = 2000
            };
            Employee e02 = new Employee()
            {
                Id = 1,
                Name = "Test02",
                Salary = 5000
            };
            Employee e03 = new Employee()
            {
                Id = 1,
                Name = "Test02",
                Salary = 5000
            };

            //if (e01 == e02)
            //    Console.WriteLine("Equals");
            //else Console.WriteLine("Not Equal");

            //Console.WriteLine("=====================");

            //if (e01 != e03)
            //    Console.WriteLine("Not Equals");
            //else Console.WriteLine("Equal");

            if (e01.Equals(e03))
                Console.WriteLine("Equals");
            else Console.WriteLine("Not Equal");

            Console.WriteLine("=====================");

            Employee[] employeesArr =
            {
                new Employee() { Id = 1 , Name = "emp01", Salary = 5000},
                e01 , e02 ,e03
            };

            int result01 = Helper<Employee>.searchArr(employeesArr, e01);
            int result02 = Helper<Employee>.searchArr(employeesArr, e02);
            int result03 = Helper<Employee>.searchArr(employeesArr, e03);
            Console.WriteLine(result01);
            Console.WriteLine(result02);
            Console.WriteLine(result03);

            #endregion
        }
    }
}
