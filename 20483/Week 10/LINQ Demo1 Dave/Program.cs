namespace LINQ_Demo1_Dave
{
    internal class Program
    {
        public delegate bool MyDel(int n);

        //can point to any method which takes in 2 ints and returns 2 ints
        public delegate int SumDel(int n1, int n2);
        static void Main(string[] args)
        {
            SumDel sum = (x1, x2) =>
            {
                return x1 + x2;
            };



            var result = CheckNum(40); //normal function call, will return true or false
            MyDel myDel = new MyDel(CheckNum);  //myDel is a "delegate variable"
            var newResult = myDel(50); // calling function via a delegate

            //Anonymous methods--used when you don't want to write additional methods (the bool CheckNum method)
            //Short, small functions--useful when writing queries, calculating average, etc...
            MyDel pointer = delegate (int num) //pointer is pointing to the following logic
            {
                return (num > 500); //will return true, otherwise return false
            };

            //Call the anonymous method later
            var result1 = pointer(50);

            //Omit the delegate keyword itself--SAME AS BLOCK 14-20
            // Uses lambda expression
            //type will be inferred (x)
            // (x) goes to/points to => logic
            MyDel pointer2 = (x) =>
            {
                return (x > 1000);
            };

            //Invoke the logic
            var result2 = pointer2(500);
        }
        static bool CheckNum(int num)
        {
            if (num > 500)
                return true;
            return false;
        }
    }
}
