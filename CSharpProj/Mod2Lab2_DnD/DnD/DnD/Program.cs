// See https://aka.ms/new-console-template for more information
public class DnD
{
    public static void Main()
    {
        var dnd = new DnD();
        Console.WriteLine("Hello! Thank you for using the DnD Character Creator Tool!\n" +
            "Enter the information as requested for your character and the tool will provide your data back to you at the end.\n\n");

        //newChar is the new character that we will record the
        var newChar = new Character();

        newChar.char_name = dnd.str_input("input Character Name");
        newChar.char_age = dnd.int_input("input Character Age");
        newChar.player_name = dnd.str_input("input Player Name");
        newChar.level = dnd.int_input("input Character Level");
        newChar.char_gender = dnd.str_input("input Character Gender");
        newChar.char_race = dnd.str_input("input Character Race");
        newChar.char_class = dnd.str_input("input Character Class");

        //When we get here, we have entered all the data for the character. 
        //Output to console
        Console.WriteLine(newChar.char_name);
        Console.WriteLine(newChar.char_age);
        Console.WriteLine(newChar.player_name);
        Console.WriteLine(newChar.level);
        Console.WriteLine(newChar.char_gender);
        Console.WriteLine(newChar.char_race);
        Console.WriteLine(newChar.char_class);
    }
    public class Character
    {
        public string char_name { get; set; }
        public int char_age { get; set; }
        public string player_name { get; set; }
        public int level { get; set; }
        public string char_gender { get; set; }
        public string char_race { get; set; }
        public string char_class { get; set; }

    }

public string str_input(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            try
            {
                string readIn = (string)Console.ReadLine();
                return readIn;
            }
            catch
            {
                Console.WriteLine("invalid input");
            }
        }
    }

    public int int_input(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            try
            {
                int readIn = Convert.ToInt32(Console.ReadLine());
                return readIn;
            }
            catch
            {
                Console.WriteLine("invalid input");
            }
        }
    }

}

    //public void write_to_receipt(List<Customer> Cust_List)
    //{
    //    //This list of strings will be added to and subtracted from to populate the rich text box receipt
    //    //Doing it as a list allows for me to add and remove lines more easily, and sort, etc. if needed 
    //    List<String> Receipt_Lines = new List<String>();

    //    //Cycle through each customer and print all their order info
    //    int custNum = 0;
    //    foreach (var cust in Cust_List)
    //    {
    //        Receipt_Lines.Add(String.Format("Subscriptions for customer {0} {1}: \n", cust.first_name, cust.last_name));
    //        Receipt_Lines.Add(" ");
    //        Receipt_Lines.Add(String.Format("{0,-17}{1,-17}{2,-17}{3,-17}{4,-17}",
    //                    "Subscription Type",
    //                    "| Shipping Type",
    //                    "| Monthly cost",
    //                    "| Length (Months)",
    //                    "| Line Total"));

    //        for (int i = 0; i < cust.num_subs; i++)
    //        {
    //            Receipt_Lines.Add(String.Format("{0,-19}{1,-17}{2,-17}{3,-17}{4,-17}",
    //                cust.subscriptions_array[i],
    //                cust.shipping_array[i],
    //                cust.sub_cost_array[i].ToString("0.00"),
    //                cust.sub_length[i],
    //                cust.monthly_cost_array[i].ToString("0.00")));
    //        }
    //        Receipt_Lines.Add(String.Format("Tax-included total of subscriptions for customer {0} {1}: ${2}",
    //            cust.first_name, cust.last_name, cust.total_with_tax.ToString("0.00")));
    //        Receipt_Lines.Add("\n \n");

    //    }

        //Receipt_Lines.Add(" ");
        //Receipt_Lines.Add(String.Format("{0,72}{1,-17}",
        //                        "Order Total:  $ ", order_total.ToString("0.00")));

    //    Console.WriteLine(string.Join("\n", Receipt_Lines));
    //}


//}
