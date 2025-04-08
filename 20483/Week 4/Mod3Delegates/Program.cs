namespace Mod3Delegates
{
    // Delegate is a function pointer which references a method
    // They can point only to accessible methods which have same signatures
    // Greet can point to either SayHello() or SayHi(), all is same-same
    /* Applications:
     * 1. In event driven programs (windows forms...). Event handlers are related to the events via the delegate. ex: Click event --btn_Click
     * 2. Annonymous methods/lambda expressions
     * 3. LINQ : language integrated queries
     * 4. Passing logic to another method, more flexibility, reusable
     * 5. Call back methodin asynchronous prog (done in the background?)
     */
    //WRITING GREET AS A DELEGATE
    delegate void Greet(string name);
    //delegate int PerformCalculations(int x, int y); //PerformCalculations points to different methods
    // delegate int Perform(int x, int y, int z); //Cannot overload delegate, have to change the name of it
    //You can also USE A DELEGATE TO PASS PARAMS
    delegate int PerformCalculations(params int[] values);

    internal class Program
    {
        static void Main(string[] args)
        {
            // direct normal function call by using the function's name itself and passing the data to it
            SayHello("Amy"); //normal function call

            //Whenever I see variable of Greet, it will be associated with a function by passing the name of the method in it (SayHi)
            Greet mygreeting = new Greet(SayHi); //Creating instance of Greet. Greet is pointing to SayHi function
                                                 // ADD another function to the list, mygreeting variables
            mygreeting += SayHello; //We can CREATE a list of functions to invoke one after the other
            mygreeting("dave"); //DELEGATE function call. will invoke SayHi AND SayHello  --->SayHi(dave)---->SayHello(dave)

            mygreeting -= SayHi; //REMOVED SayHi from the function list
            // mygreeting += Add; CANNOT do this, signature doesn't match. NOt same value types (int vs string)
            mygreeting("alex");

            DisplayGreetings(SayHello, "amy");
            DisplayGreetings(SayHi, "Dave");

            Calculate(Add, 34, 45, 45);
            Calculate(Multiply, 45, 56);

            PerformCalculations calculations = new PerformCalculations(Multiply);
            calculations(34, 45);


            Console.ReadKey();
        }

        // #4. application--passing logic to a function
        static int Calculate(PerformCalculations perform, params int[] values) //Calculate takes in a variable of the PerformCalc method
        {
            return perform(values); //via the delegate, we are calling the method
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

        //First variable you're passing is Greet, passing name you want to use in the greeting message
        // 3Feb 1h6m
        //CReating another function that can take in the logic at runtime
        static void DisplayGreetings(Greet greeting, string name) //Can only pass a delegate (variable)--SayHi or SayHello
        {
            greeting(name);
        }

        static int Add(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
                sum += value;
            return sum;
        }

        static void SayHello(string name) //passing name of person
        {
            Console.WriteLine("Hello " + name);
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }

    }
}
