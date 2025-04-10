namespace _7._4_Parking_System
{
    public class ParkingSystem
    {
        int big;
        int medium;
        int small;

        public ParkingSystem(int big, int medium, int small)
        {
            this.big = big;
            this.medium = medium;
            this.small = small;
        }

        public bool AddCar(int carSize)
        {
            if (carSize == 1) //if carSize is  big
            {
                if (big > 0) // if big slots > 0
                {
                    big--; //decrease big slots
                    return true; //car can be added
                }
            }
            else if (carSize == 2) //medium cars
            {
                if (medium > 0)
                {
                    medium--;
                    return true;
                }
            }
            else if (carSize == 3) //small car
            {
                if (small > 0)
                {
                    small--;
                    return true;
                }
            }
            return false; //no cars fit any slots
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
                Console.WriteLine("Parking lot size: [1, 1, 0]");
                Console.WriteLine($"Add 1 big car: {parkingSystem.AddCar(1)}"); //true
                Console.WriteLine($"Add 1 medium car: {parkingSystem.AddCar(2)}"); //true
                Console.WriteLine($"Add 1 small car: {parkingSystem.AddCar(3)}"); //false
                Console.WriteLine($"Add 1 more big car: {parkingSystem.AddCar(1)}"); //false

                //ParkingSystem parkingSystem2 = new ParkingSystem(2, 1, 1);
                //Console.WriteLine("Parking lot size: [2, 1, 1]");
                //Console.WriteLine($"Add 1 big car: {parkingSystem2.AddCar(1)}"); //true
                //Console.WriteLine($"Add 1 medium car: {parkingSystem2.AddCar(2)}"); //true
                //Console.WriteLine($"Add 1 small car: {parkingSystem2.AddCar(3)}"); //true
                //Console.WriteLine($"Add 1 more big car: {parkingSystem2.AddCar(1)}"); //true

            }
        }
    }
}
