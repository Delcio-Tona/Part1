namespace Part1
{
    internal class Program
    {
        string recipe;
        int numingredient;
        string[] namingredient = new string[20];
        float[] quantity = new float[20];
        float[] unitmeasurement = new float[20];
        int[] step = new int[20];
        float[] convert = new float[20];
        float[] convert1 = new float[20];
        string place_condition;
        string place_condition_convert;
        string condition2;
        string[] description = new string[20];
        string condition3;

        static void Main(string[] args)
        {
            Program Tona = new();

            Tona.Delcio();

        }

        public void Delcio()
        {
            while (true)
            {
                //The user shall be able to enter the details for a single recipe.
                Console.Write("Enter the recipe: "); 
                recipe = Console.ReadLine();
                Console.Write("Enter the number of ingredients: ");
                numingredient = Convert.ToInt32(Console.ReadLine());
                if (numingredient == numingredient)
                {
                    for (int i = 0; i < numingredient; i++)
                    {
                        Console.Write("Enter the name of ingredient: ");
                        namingredient[i] = Console.ReadLine();

                        Console.Write("Enter the quantities: ");
                        quantity[i] = float.Parse(Console.ReadLine());

                        //The user can request that the quantities be reset to the original values.
                        Console.Write("Do you like to reset the quantities? (Yes) or (Not): "); 
                        place_condition = Console.ReadLine();
                        place_condition_convert = place_condition.ToLower();
                        if (place_condition_convert == "yes")
                        {
                            quantity[i] = 0;
                            Console.Write("Enter the quantities: ");
                            quantity[i] = float.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.Write("");
                        }

                        Console.Write("How many tablespoon?: ");
                        unitmeasurement[i] = float.Parse(Console.ReadLine());
                        convert[i] = unitmeasurement[i] / quantity[i];

                        Console.Write("Enter the number of step: ");
                        step[i] = int.Parse(Console.ReadLine());

                        Console.Write("Enter the description of step: ");
                        description[i] = Console.ReadLine();

                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recipe: " + recipe);
                    Console.WriteLine("");
                    Console.WriteLine("Number of ingredients: " + numingredient);
                    Console.WriteLine("");
                    for (int b = 0; b < numingredient; b++)
                    {
                        {
                            //For each ingredient: the name, quantity, and unit of measurement.
                            Console.WriteLine("Ingredients: " + namingredient[b] + ", Quantities: " + quantity[b] + ", Tablespoon: " + convert[b] + " "); 
                        }
                            Console.WriteLine("");

                        for (int j = 0; j < numingredient; j++)
                        {
                            Console.WriteLine("Step " + step[j] + " " + description[j]);
                        }
                        //The system will clean all the data to enter a new recipe.
                        Console.WriteLine("");
                        Console.Write("Do you like to clear all data? (Yes) or (Not): ");
                        condition2 = Console.ReadLine();
                        condition2 = condition2.ToLower();
                        if (condition2 == "yes")
                        {
                            recipe = "";
                            numingredient = 0;
                            namingredient = new String[10];
                            quantity = new float[20];
                            unitmeasurement = new float[20];
                            step = new int[10];
                            convert = new float[20];
                            convert1 = new float[20];
                            description = new string[20];
                            Console.WriteLine("All data has been deleted");
                            Console.WriteLine("");
                            ClearRecipe();
                            break;
                        }
                        else
                        {
                            Console.Write("Do you like to exit the application? (Yes) or (Not): ");
                            condition3 = Console.ReadLine();
                            condition3 = condition3.ToLower();
                            if (condition3 == "yes")
                            {
                                break;
                            }

                        }

                    }
                }

            }
        }

        public void ClearRecipe()
        {

            while (true)
            {
                Console.Write("Enter the recipe: ");
                recipe = Console.ReadLine();
                Console.Write("Enter the number of ingredients: ");
                numingredient = Convert.ToInt32(Console.ReadLine());
                if (numingredient == numingredient)
                {
                    for (int i = 0; i < numingredient; i++)
                    {
                        Console.Write("Enter the name of ingredient: ");
                        namingredient[i] = Console.ReadLine();

                        Console.Write("Enter the quantities: ");
                        quantity[i] = float.Parse(Console.ReadLine());

                        Console.Write("Do you like to reset the quantities? (Yes) or (Not): ");
                        place_condition = Console.ReadLine();
                        place_condition_convert = place_condition.ToLower();
                        if (place_condition_convert == "yes")
                        {
                            quantity[i] = 0;
                            Console.Write("Enter the quantities: ");
                            quantity[i] = float.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.Write("");
                        }

                        Console.Write("How many tablespoon: ");
                        unitmeasurement[i] = float.Parse(Console.ReadLine());
                        convert[i] = unitmeasurement[i] / quantity[i];

                        Console.Write("Enter the number of step: ");
                        step[i] = int.Parse(Console.ReadLine());

                        Console.Write("Enter the description of step: ");
                        description[i] = Console.ReadLine();

                    }
                    Console.WriteLine("");
                    Console.Write("Recipe: " + recipe);
                    Console.WriteLine("");
                    Console.Write("Number of ingredients:" + numingredient);
                    Console.WriteLine("");
                    for (int b = 0; b < numingredient; b++)
                    {

                        Console.WriteLine("Ingredients: " + namingredient[b] + ", Quantities: " + quantity[b] + ", Tablespoon: " + convert[b] + " ");

                    }
                    Console.WriteLine("");

                    for (int j = 0; j < numingredient; j++)
                    {
                        Console.WriteLine("Step " + step[j] + " " + description[j]);
                    }
                    Console.Write("Do you like to clear all data? (Yes) or (Not): ");
                    condition2 = Console.ReadLine();
                    condition2 = condition2.ToLower();
                    if (condition2 == "yes")
                    {                      
                        string recipe = ("");
                        int numingredient = 0;
                        namingredient = new String[20];
                        quantity = new float[20];
                        unitmeasurement = new float[20];
                        step = new int[20];
                        convert = new float[20];
                        convert1 = new float[20];
                        description = new string[20];
                        Console.WriteLine("All data has been deleted");
                        Console.WriteLine("");
                        ClearRecipe();
                        break;
                    }
                    else
                    {
                        Console.Write("Do you like to exit the application? (Yes) or (Not): ");
                        condition3 = Console.ReadLine();
                        condition3 = condition3.ToLower();
                        if (condition3 == "yes")
                        {
                            break;
                        }
                    }
                }
            }
        }
    } 
}

