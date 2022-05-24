// See https://aka.ms/new-console-template for more information
//namespace Subscribers
//{

public class Subscribers
{
    public static void Main()
    {
        var subs = new Subscribers();
        Console.WriteLine("Hello! Thank you for using the Subscription Recorder Tool!\n" +
            "This tool will allow you to enter multiple customers' subscriptions and output the total charge per customer,\n" +
            "with applicable discounts and tax.\n"+
            "Subscriptions are recorded by customer, so you will start by entering the customer's name.\n\n");

        //Lists of the subscription types and shipping types are used to ensure valid user input
        List<string> sub_selections = new List<string>();
        List<string> ship_selections = new List<string>();
        List<string> y_n = new List<string>(); //y or n only

        sub_selections.Add("Ice Cream"); sub_selections.Add("Bacon"); sub_selections.Add("Peanut Butters");
        ship_selections.Add("Regular"); ship_selections.Add("Expedited"); ship_selections.Add("Overnight");
        y_n.Add("y"); y_n.Add("n");

        //We can have multiple customers, so we will make a list of customers
        List<Customer> Cust_List = new List<Customer>();

        //while this is true, user wants to add more customers. loop will continue
        bool moreCustomers = true;
        int cust_num = 0;

        while (moreCustomers)
        {
            //Collect customer info
            string fname;
            string lname;
            int months;
            
            fname = subs.str_input("Input the customer's first name");
            lname = subs.str_input("Input the customer's last name");
            Cust_List.Add(new Customer(fname, lname));

            //Collect subscription info for this customer
            bool moreSubs = true;
            //Loop to add multiple subscription types. Stop when user enters "N" when prompted if they want to add more
            while (moreSubs)
            {
                string sub_type;
                string ship_type;
                int sub_months;
                sub_type = subs.str_input(string.Format("Enter a subscription type for {0} {1}", fname, lname), sub_selections);
                ship_type = subs.str_input("Input the customer's shipping type", ship_selections);
                sub_months = subs.int_input(string.Format("Input the number of months for the {0} subscription",sub_type));
                try
                {
                    Cust_List[cust_num].add_subscription(sub_type, ship_type, sub_months);
                    if (subs.str_input("Add another subscription?", y_n) == "n")
                    {
                        moreSubs = false;
                    }
                }
                catch
                {
                    Console.WriteLine("error adding subscription");
                }
            }
            //Calculate total for this customer
            Cust_List[cust_num].calculate_cust_total();
            
            //Check if we want to add another customer
            if (subs.str_input("Add another customer?", y_n) == "n")
            {
                moreCustomers = false;
            }
            //If we add another customer, increase cust_num by 1
            Console.WriteLine();
            cust_num++;
        }

        //When we get here, we have entered all the customers and subscriptions we want to add. Output data.
        subs.write_to_receipt(Cust_List);
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

    public string str_input(string prompt,List<string> acceptableInput)
    {
        while (true)
        {
            Console.Write(prompt);
            Console.WriteLine(String.Format("-- Expected Input: {0}", string.Join(';', acceptableInput)));
            try
            {
                string readIn = (string)Console.ReadLine();
                foreach (string check in acceptableInput)
                {
                    if (check.ToLower() == readIn.ToLower())
                        return check;
                }
                Console.WriteLine("Unexpected Input");
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

        public class Customer
        {
            public Customer(string cus_first_name, string cus_last_name)
            {
                this.first_name = cus_first_name;
                this.last_name = cus_last_name;

            }
            public string first_name { get; set; }
            public string last_name { get; set; }
            //num_subs increments with each added subscription to add to the arrays
            public int num_subs { get; set; }

            public string[] subscriptions_array = new string[3];
            public string[] shipping_array = new string[3];
            public int[] sub_length = new int[3];

            public decimal[] shipping_cost_array = new decimal[3];
            public decimal[] sub_cost_array = new decimal[3];
            public decimal[] monthly_cost_array = new decimal[3];
            public decimal total_with_tax { get; set; }

            public void add_subscription(string sub_type, string shipping_type, int sub_months)
            {
                subscriptions_array[num_subs] = sub_type;
                shipping_array[num_subs] = shipping_type;
                sub_length[num_subs] = sub_months;

                sub_cost_array[num_subs] = monthly_sub_cost(sub_type);
                shipping_cost_array[num_subs] = shipping_cost(shipping_type);
                monthly_cost_array[num_subs] = calculate_sub_total(num_subs);

                this.num_subs++;
            }

            public decimal shipping_cost(string shippingString)
            {
                switch (shippingString)
                {
                    //Decision statement: what is the shipping cost based off the type of shipping selected
                    case "Regular":
                        return 5.00M;

                    case "Expedited":
                        return 10.00M;

                    case "Overnight":
                        return 30.00M;

                    default:
                        //default to 0
                        return 0M;
                }
            }

            public decimal monthly_sub_cost(string subType)
            {
                //first calculate the total 
                switch (subType)
                {
                    //Decision statement: what is the shipping cost based off the 
                    case "Ice Cream":
                        return 12M;

                    case "Bacon":
                        return 15M;

                    case "Peanut Butters":
                        return 17M;

                    default:
                        //default to 0
                        return 0M;
                }
            }

        public decimal calculate_sub_total(int index)
        {
            decimal SubTotal = 0;
            //first calculate the monthly subtotal

            SubTotal += (this.sub_cost_array[index] + this.shipping_cost_array[index]) * (decimal)this.sub_length[index];
            
            decimal discount;
            //check for discounts
            switch (SubTotal)
            {
                case > 150M:
                    discount = .10M * SubTotal;
                    break;

                case > 100M:
                    discount = .07M * SubTotal;
                    break;

                case > 50M:
                    discount = .05M * SubTotal;
                    break;

                default:
                    discount = 0M;
                    break;
            }
            //apply discount
            SubTotal = SubTotal - discount;
            return SubTotal;

            }

        public void calculate_cust_total()
        {
            decimal subTotal = 0;
            for (int i = 0; i < this.num_subs; i++)
            {
                subTotal += monthly_cost_array[i];
            }
            this.total_with_tax = subTotal * 1.04M;
        }

    }

        public void write_to_receipt(List<Customer> Cust_List)
        {
            //This list of strings will be added to and subtracted from to populate the rich text box receipt
            //Doing it as a list allows for me to add and remove lines more easily, and sort, etc. if needed 
            List<String> Receipt_Lines = new List<String>();

            //Cycle through each customer and print all their order info
            int custNum = 0;
        foreach (var cust in Cust_List)
        {
            Receipt_Lines.Add(String.Format("Subscriptions for customer {0} {1}: \n", cust.first_name, cust.last_name));
            Receipt_Lines.Add(" ");
            Receipt_Lines.Add(String.Format("{0,-17}{1,-17}{2,-17}{3,-17}{4,-17}",
                        "Subscription Type",
                        "| Shipping Type",
                        "| Monthly cost",
                        "| Length (Months)",
                        "| Line Total"));

            for (int i = 0; i < cust.num_subs; i++)
            {
                Receipt_Lines.Add(String.Format("{0,-19}{1,-17}{2,-17}{3,-17}{4,-17}",
                    cust.subscriptions_array[i],
                    cust.shipping_array[i],
                    cust.sub_cost_array[i].ToString("0.00"),
                    cust.sub_length[i],
                    cust.monthly_cost_array[i].ToString("0.00")));
            }
            Receipt_Lines.Add(String.Format("Tax-included total of subscriptions for customer {0} {1}: ${2}", 
                cust.first_name, cust.last_name, cust.total_with_tax.ToString("0.00")));
            Receipt_Lines.Add("\n \n");

        }

        //Receipt_Lines.Add(" ");
        //Receipt_Lines.Add(String.Format("{0,72}{1,-17}",
        //                        "Order Total:  $ ", order_total.ToString("0.00")));

        Console.WriteLine(string.Join("\n", Receipt_Lines));
    }


    }


