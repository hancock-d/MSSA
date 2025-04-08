namespace Mod3Delegatesdemo1
{

    // Delegate is a function pointer which references a method
    // they can point to only accessible methods which have same signatures
    /*Applications:
     * 1. In event driven prog, event handlers are related to the events via the delegate, click--btn_Click
     * 2. anonymous methods/ lambda expressions
     * 3. LINQ :lang integrated querries
     * 4. passing logic to another method, more flexibilty , reusable
     * 5. call back method in asynchronous prog
     * 
     */
    delegate void Greet(string name);
    delegate int PerformCalculations(params int[] values);
   // delegate int Perform(int x, int y, int z);
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // direct normal function call
            SayHello("Amy");

            Greet mygreeting=new Greet(SayHi);

            mygreeting += SayHello;//we can create a list of functions
            mygreeting("deepali"); // delegate ---> SayHi(deepali)---->SayHello

            mygreeting -= SayHi;
           // mygreeting += Add;
            mygreeting("alex");

            DisplayGreetings(SayHello, "Amy");

            DisplayGreetings(SayHi, "deepali");

            Calculate(Add, 34, 45,45);
            Calculate(Multiply, 45, 56);

            PerformCalculations calculations = new PerformCalculations(Multiply);
            calculations(34, 45);

            Console.ReadKey();
        }
        // 4. passing logic to a function
        static int Calculate(PerformCalculations perform, params int[] values)
        {
            return perform(values);// via the del, we are calling the method
        }
        static int Multiply(params int[] values)
        {
            int product = 1;
            foreach (int value in values)
            {
                product *= value;
            }
            return product;
        
        }

        static void DisplayGreetings(Greet greeting, string name)
        {
            greeting(name);
        }

        static int Add(params int[] values)
        {
            int sum = 0;
            foreach(int value in values)
                sum += value;
            return sum;
        }
        static void SayHello(string name)
        {
            Console.WriteLine("Hello "+ name);
        }
        static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
