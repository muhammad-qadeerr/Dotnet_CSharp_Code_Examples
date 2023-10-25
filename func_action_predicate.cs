using System;


/*              Notes
Generic Delegate: Func, Action and Predicate are predefined Gneric Delegates.
- We are writting the delegates implicitly but there is no need to do it we can use already present Generic Delegates.
    Func: for any value returning methods
    Action: for void type methods
    Predicate: for boolean return type methods.

Func<parameter1Type, parameter2Type, parameter3Type....upto 16, resultType>
Action<inputType, inputType,..... upto 16>
Predicate<onlyOneInputType>

- We can also use Func for bool return type but predicate is predefined for bool return type.
 
 
 
 */
namespace Delegates_in_Detail
{
    // Define delegates for all the methods
    // There is need to define the delegates when using Func, Action, Predicate.

    /*public delegate double DelegateAddNums2(int x, float y, double z);
    public delegate void DelegateAddNums3(int a, double b);
    public delegate bool DelegateCheckLength(string str);*/
    class func_action_predicate
    {

        /*public static double AddNums2(int x, float y, double z)
        {
            return x + y + z;
        }
        public static void AddNums3(int a, double b)
        {
           Console.WriteLine(a + b);
        }
        public static bool CheckLength(string str)
        {
            if(str.Length >= 5)
                return true;
            return false;
        }*/

        // Without Writting this methods we can use Func, Action, Predicate with anonymous functions, or lambda expressions.


        static void Main(string[] args)
        {

           /* DelegateAddNums2 obj1 = new DelegateAddNums2(AddNums2);
            double result = obj1.Invoke(12, 2, 4.5567);
            Console.WriteLine(result);

            DelegateAddNums3 obj2 = new DelegateAddNums3(AddNums3);
            obj2.Invoke(3, 4.55);
              

            DelegateCheckLength obj3 = CheckLength;
            Console.WriteLine(obj3.Invoke("Asghar")); */

            // 

            Console.WriteLine("\n\n *** Implementation using Generic Delegates Func, Action, Predicate *** ");

            /*
            // Func Delegate
            Func<int, float, double, double> addnum2 = AddNums2;
            double sum = addnum2.Invoke(2, 3, 4.5);
            Console.WriteLine(sum);

            // Action Delegate

            Action<int, double> addnum3 = AddNums3;
            addnum3.Invoke(2, 34.5);

            // Predicate Delecate

            Predicate<string> checkLen = CheckLength;
            Console.WriteLine(checkLen.Invoke("hi"));

            // We can also use Func for bool return type but predicate is predefined for bool return type.

            Func<string, bool> checkLen1 = CheckLength;
            Console.WriteLine(checkLen1.Invoke("Programming"));
            */

            // Implementation using Generic delagates and Lambda Expressions


            // Func Delagate
            Func<int, float, double, double> objj = (x, y, z) =>
            {
                return x + y + z;
            };
            Console.WriteLine(objj.Invoke(3, 4, 5.6));

            //Action Delegate
            Action<int, double> objjj = (a, b) =>
            {
                Console.WriteLine(a + b);
            };
            objjj.Invoke(2, 3.4);
            //Predicate Delagate
            Predicate<string> objjjj = (str) =>
            {
                if (str.Length >= 5)
                    return true;
                return false;
            };
            Console.WriteLine(objjjj.Invoke("Dotnet Fundamantals!"));







            


        }
    }
}
