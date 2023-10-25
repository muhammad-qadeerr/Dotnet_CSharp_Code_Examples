using System;


/*                Notes
Lambda Expressions: It is bascically a short hand in for writting anonymous methods.
- But the thing to notice is that we dont need to write return type of function as it is 
  already written in defination of delegate but type of parameter is also written so why do
  we need to specify that??? to get rid of that we modify our anomymous function using lambda expression.
- Also no need to write 'delegate' keyword while defining the anonymous function using lambda expression.
 */
namespace Delegates_in_Detail
{
    // Defining the delegate
    public delegate string GreetingnAgeDelegate(string name, int age);  
    class LambdaExpressionsInDelegates
    {
        public static string Greetings(string name, int age)
        {
            return "Hello my name is " + name + ", i am " + age + " years old.";
        }
        public static void Main(string[] args) 
        {
            // Instatiating the delegate
            //GreetingnAgeDelegate obj = new GreetingnAgeDelegate(Greetings);
            //string intro = obj.Invoke("Ali", 23);
            //Console.WriteLine(intro);


            // We can simply convert the above method into anomymous method, their is no need to define seeprate function, nothing to take care about return type and function name.
            // ANOMYMOUS METHOD.


            /*GreetingnAgeDelegate obj = delegate (string name, int age)
            {
                return "Hello my name is " + name + ", i am " + age + " years old.";
            };
            string intro = obj.Invoke("Ali", 23);
            Console.WriteLine(intro);*/


            // But the thing to notice is that we dont need to write return type of function as it is 
            // already written in defination of delegate but type of parameter is also written so why do
            // we need to specify that??? to get rid of that we modify our anomymous function using lambs expression.


            GreetingnAgeDelegate obj = (name,age) =>
            {
                return "Hello my name is " + name + ", i am " + age + " years old.";
            };
            string intro = obj.Invoke("Ali", 23);
            Console.WriteLine(intro);

            Console.ReadLine();
        
        }
    }
}
