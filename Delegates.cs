using System;



/*            Notes

Delegates: It is a type safe function pointer, delegates , interface are types.
- A delegate holds the reference of a method and then calls the methood for execution.
- Non Static method is called by instance of the class
- Static method is called by name of the class.
- Method can also be called using a delegate.
- Class and Delegates are reference type, but structure is value type.
- Types are written under a namespace bcz namespace is a logical container of types.
- To call a method using delegates there are 3 steps:
    1. Define a Delegate
    [<modifiers>] delegate void|type <Name>([<Paramater List>]);
    - Return type and parameter list i.e. function signature of simple and a delegate method must be same and name Should be different.
    - delegate keyword and different functionName.
    2. Instantiate the Delegate to call a function.
    3. Now call the delegate by passing required paramater values, so that
        internally the method which is bound with the delegate gets executed.

 */
namespace Delegates_in_Detail
{ 
    //1. Defining the Delegates
    public delegate void AddDelegate(int x , int y);
    public delegate string SayDelegate(string name);
    class Delegates
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            // To call a non-static method we need to create the instance of  the Program class

            Delegates p = new Delegates();
            p.AddNums(100, 45);

            // While static method will be called by Class Name

            string name1 = Delegates.SayHello("Ali");
            Console.WriteLine(name1);

            // Calling a function using delegate by instantiation and target method name is passed as paramater while instantiation.
            // When the method is passed in the paramater its address goes to the delegate.
            AddDelegate ad = new AddDelegate(p.AddNums);   // we are calling a non static function in static so need to call it with object name.
            SayDelegate sd = new SayDelegate(SayHello);

            // Actually calling a delegat function.

            ad(100, 145);  // Also it can be called as
            ad.Invoke(120, 34);
            string name2 = sd("Akbar");
            string name3 = sd.Invoke("Gohar");
            Console.WriteLine(name2);
            Console.WriteLine(name3);

            Console.ReadLine();
        
        }
    }
}
