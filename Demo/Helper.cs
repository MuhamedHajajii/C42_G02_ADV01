using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // Concreate Class can Includes static and non static Functions
    // but the static classes only hold static fonctions
    internal class Helper<T>
    {


        //public static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void Swap(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void Swap(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        // if i will use it only inside the function 
        // make declare it in the function scope and there is no necessary to send it while i'm calling the function
        // if i will use it all over the calss declare it in the class scope
        // T Stands for Templete
        public static void Swap(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        //public static int searchArr(int[] array, int value)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (array[i] == value)
        //                return i;
        //        }
        //    }
        //    return -1;
        //}
        public static int searchArr(T[] array, T value)
        {
            if (array is not null && value is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    // can't use the == with all the datatypes 
                    // like if we use the struct or user defind calss 
                    if (value.Equals(array[i]))
                        return i;
                }
            }
            return -1;
        }

    }
}
