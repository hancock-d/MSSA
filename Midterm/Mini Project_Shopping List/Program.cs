namespace Mini_Project_Shopping_List
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            GroceryData.Groceries.Add(new Grocery("Avocado", 4, StoreName.StoreA));
            GroceryData.Groceries.Add(new Grocery("Eggs", 6, StoreName.StoreA));
            GroceryData.Groceries.Add(new Grocery("Butter", 2, StoreName.StoreA));
            GroceryData.Groceries.Add(new Grocery("Milk", 1, StoreName.StoreA));
            GroceryData.Groceries.Add(new Grocery("Bread", 3, StoreName.StoreA));
            GroceryData.Groceries.Add(new Grocery("Bacon thicc", 10, StoreName.StoreA));

            GroceryData.Groceries.Add(new Grocery("Hot buttered Popcorn", 7, StoreName.StoreB));
            GroceryData.Groceries.Add(new Grocery("Coke 12 pack", 1, StoreName.StoreB));
            GroceryData.Groceries.Add(new Grocery("Salsa", 9, StoreName.StoreB));
            GroceryData.Groceries.Add(new Grocery("Chippies", 5, StoreName.StoreB));
            GroceryData.Groceries.Add(new Grocery("Can of Beans", 8, StoreName.StoreB));

            Application.Run(new DefaultPageForm());
        }
    }
}

/* Next steps:
 * 
 * Remove quantity enum and debug those issues
 * Sort items alphabetically by clicking column
 * Make item quant nullable, so they don't have to input an item
 * Add validation checks
 *  -Item character max?
 *  -Store character max?
 * Access each store list individually
 *  -From default page or full list page? Both?
 * 
 * DataGrids:
 *  -Find a better way to show the background so it's not a white block (think transparency)
 *  -Find a way to manage column widths:
 *      -Checkmark--Set
 *      -Item--Flexible
 *      -#--Set
 * Save the shopping list and stores
 *  -Load upon user login
 *      -Add "login" page
 * Let quantity also be a typable input
 * Full screen mode issues
 * 
 */