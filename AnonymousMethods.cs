using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      **** Notes *** 
       
Anonymous Methods: Apart from bindig the function to a delegate we can bind the un-named code block to the delegate.
- This all can be done by 'delegate' keyword - This is an Anomynous Mehtos.
- This method has no name but only a body defined using 'delegate' keyword and after that we define a parameter.
- Advantage: Less typing work, but is not recommended in large volume of codes.
    - No need to write return type - beacuse delegate already knows the return type.
    - Logic is written where the binding has been performed.

 
 
 
 
 */
namespace Delegates_in_Detail
{
    // Defining a delegate

    public delegate string GreetingsDelegate(string name);
    class AnonymousMethods
    {
        //public static string Greetings(string name)
        //{
        //    return "Hello " + name + " a very good morning!";
        //}
  
        static void Main(string[] args)
        {
            //GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            //string name1 = obj.Invoke("Qadeer");
            //Console.WriteLine(name1);




            // now we can write an anonymous function delegeate, means if we remove tha original function it can still b called here as: 
            // This all can be done by 'delegate' keyword - This is an Anomynous method.


            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello " + name + " a very good morning!";
            };
            string name1 = obj.Invoke("Qadeer");
            Console.WriteLine(name1);

            Console.ReadLine();
        }
    }
}
