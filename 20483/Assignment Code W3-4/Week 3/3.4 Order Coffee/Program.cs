using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4_Order_Coffee
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Data.Coffee.Add(new Coffee() { CustomerName = "Lou", Drink = DrinkName.Drip, Cup = CupSize.Small, Temp = Temperature.Cold, Bean = BeanType.Arabica, Roast = RoastStrength.Breakfast });
            Data.Coffee.Add(new Coffee() { CustomerName = "Jack", Drink = DrinkName.Espresso, Cup = CupSize.Medium, Temp = Temperature.Hot, Bean = BeanType.Columbian, Roast = RoastStrength.Mild });

            Application.Run(new OrderUp());
        }
    }
}
