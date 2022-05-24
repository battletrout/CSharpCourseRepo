namespace Subscribers
{
    public partial class Subscribers : Form
    {
        public Subscribers()
        {
            InitializeComponent();
        }

        List<Customer> Cust_List = new List<Customer>();
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
            private int num_subs { get; set; }   

            public string[] subscriptions_array = new string[3];
            public string[] shipping_array = new string[3];
            public int[] sub_length = new int[3];

            public decimal[] shipping_cost_array = new decimal[3];
            public decimal[] monthly_cost_array = new decimal[3];
            public decimal discount { get; set; }
            public decimal total_with_tax { get; set; }

            public void add_subscription(string sub_type, string shipping_type, int sub_months)
            {
                subscriptions_array[num_subs] = sub_type;
                shipping_array[num_subs] = shipping_type;
                sub_length[num_subs] = sub_months;

                monthly_cost_array[num_subs] = monthly_cost(sub_type);
                shipping_cost_array[num_subs] = shipping_cost(shipping_type);

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

            public decimal monthly_cost(string subType)
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

            public void calculate_total()
            {
                decimal monthlySubTotal = 0;
                //first calculate the monthly subtotal
                for (int i = 0; i < num_subs; i++)
                {
                    monthlySubTotal += monthly_cost_array[i] + shipping_cost_array[i];
                }
                
                //check for discounts
                switch (monthlySubTotal)
                {
                    case > 150M:
                        this.discount = .10M * monthlySubTotal;
                        break;

                    case > 100M:
                        this.discount = .07M * monthlySubTotal;
                        break;

                    case > 50:
                        this.discount = .05M * monthlySubTotal;
                        break;

                    default:
                        this.discount = 0M;
                        break;
                }
                //apply discount
                monthlySubTotal = monthlySubTotal - this.discount;
                //apply tax
                this.total_with_tax = monthlySubTotal * 1.04M;
                         
            }

        }

        public void write_to_receipt()
        {
            //This list of strings will be added to and subtracted from to populate the rich text box receipt
            //Doing it as a list allows for me to add and remove lines more easily, and sort, etc. if needed 
            List<String> Receipt_Lines = new List<String>();

            //Cycle through each customer and print all their order info
            int custNum = 1;
            foreach (var cust in Cust_List)
            {
                Receipt_Lines.Add(String.Format("Customer {0} Contact Information:", custNum.ToString()));

                Receipt_Lines.Add(String.Format("{0} {1}", cust.first_name, cust.last_name));
                Receipt_Lines.Add(cust.phone);
                Receipt_Lines.Add(cust.email);
                Receipt_Lines.Add(cust.mail_addr);
                Receipt_Lines.Add(" ");
                custNum++;

            }

            Receipt_Lines.Add(String.Format("{0,-21}{1,-17}{2,-17}{3,-17}{4,-17}",
                                    "Item Name",
                                    "| Qty Purchased",
                                    "| Unit Cost",
                                    "| Tax Amount",
                                    "| Line Total"));
            Receipt_Lines.Add(" ");
            double order_total = 0;

            //add each line on the receipt and keep track of the grand total
            foreach (var item in Order_Items)
            {
                Receipt_Lines.Add(String.Format("{0,-23}{1,-17}{2,-17}{3,-17}{4,-17}",
                                    item.item_name, item.item_qty,
                                    item.unit_price.ToString("0.00"),
                                    item.tax_amt.ToString("0.00"),
                                    item.line_total.ToString("0.00")));

                order_total += item.line_total;
            }
            Receipt_Lines.Add(" ");
            Receipt_Lines.Add(String.Format("{0,72}{1,-17}",
                                    "Order Total:  $ ", order_total.ToString("0.00")));




            rtxt_receipt.Text = string.Join("\n", Receipt_Lines);
        }


    }
}