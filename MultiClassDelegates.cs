using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


/*                        **** Notes *** 
Multicast delegates: A delegate with holds the reference of more than one function with same signature.
Problem with the multicasr delagate:
    - if both the functions are return type then delegate with override the value when called second method.
 
 
 
 */
namespace Delegates_in_Detail
{
    // A Multicast delegate defination

    public delegate void RectDelegate(double Width, double Height); 

    // Problometic Multicase delegate with returns some value.

    public delegate double ReturnValueMultiCastDelagate(double Width, double Height);


    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of rectangle is: " + Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of rectangle is: " + 2 *(Width+Height));
        }

        public double GetArea1(double Width, Double Height)
        {
            return Width * Height;
        }
        public double GetPerimeter1(double Width, double Height)
        {
            return 2 * (Width + Height);
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.GetArea(3.345, 4.567);
            rect.GetPerimeter(12.34, 45.67);

            // Instatiation of delegate - Just demonstration but no need to create 2 seperate objects, delegate can be bind with related function using a single obj shown below.

            RectDelegate rectArea = new RectDelegate(rect.GetArea);
            RectDelegate rectPeri = new RectDelegate(rect.GetPerimeter);

            rectArea.Invoke(3.4556, 4.567);
            rectPeri.Invoke(45.567, 5.678);

            // We can also bind the methos with its delegate as:

            RectDelegate rectArea1 = rect.GetArea;
            RectDelegate rectPeri1 = rect.GetPerimeter;

            rectArea1(3.456, 5.678);
            rectPeri1(6.789, 45.567);

            // No need to Write multiple instatiation both the methods can be called by on instance of the delegate

            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;
            obj.Invoke(3.45, 5.67);   // Both Area and Paramater will be called at the same time.
            Console.WriteLine();
            // Same delegate obj can be called with someother paramters
            obj(4.567, 67.45);
            obj.Invoke(4.567, 4.5678);
            Console.WriteLine();



            // Demonstration of Multicase delegate which returns some value


            //ReturnValueMultiCastDelagate retDel = new ReturnValueMultiCastDelagate();   // Area value will be calculated here and will be overriden in nect line. both obj will store same value with is not good.
            //double returnArea = retDel.Invoke(rect.GetPerimeter1);
            //double returnPerimeter = retDel.Invoke(rect.GetPerimeter1);


            //Console.WriteLine("Return Area: " + returnArea);
            //Console.WriteLine("Return Perimenter: " + returnPerimeter);





            // Area value will be calculated here and will be overriden in nect line. both obj will store same value with is not good.
            ReturnValueMultiCastDelagate retDel = rect.GetArea1;
            retDel += rect.GetPerimeter1;
        }
    }
}
