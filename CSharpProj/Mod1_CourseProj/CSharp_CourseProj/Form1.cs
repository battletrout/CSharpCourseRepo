using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProj
{
    public partial class CourseProj : Form
    {
        public class Customer
        {
            public Customer(string cus_first_name, string cus_last_name, string cus_phone, string cus_email, string cus_mail_addr, bool cus_taxed)
            {
                this.first_name = cus_first_name;
                this.last_name = cus_last_name;
                this.phone = cus_phone;
                this.email = cus_email;
                this.mail_addr = cus_mail_addr;
                this.taxed = cus_taxed;
            }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string mail_addr { get; set; }
            public bool taxed { get; set; }

        }

        //Each item that the is added to the order is a Line_Item. We will create a list of these to track the order.
        public class Line_Item
        {
            public Line_Item(string add_item_name, int add_item_qty, double add_unit_price, double add_tax_amt, double add_line_total)
            {
                this.item_name = add_item_name;
                this.item_qty = add_item_qty;
                this.unit_price = add_unit_price;
                this.tax_amt = add_tax_amt;
                this.line_total = add_line_total;
           
            }
            public string item_name { get; set; }
            public int item_qty { get; set; }
            public double unit_price { get; set; }
            public double tax_amt { get; set; }
            public double line_total { get; set; }
        }

        //Create an empty list of Line_Item that will be populated as the user adds items
        List<Line_Item> Order_Items = new List<Line_Item>();
        //We will do the same for customer information in case multiple customers need to be entered.
        List<Customer> Cust_List = new List<Customer>();


        public CourseProj()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

            //populate combobox with ticket types
            cbox_item_name.Items.AddRange(new object[] {
                "stylish umbrella",
                "utilitarian umbrella",
                "artistic umbrella",
                "umbrella hanger",
                "umbrella wax",
                "umbrella warranty"});



            //Initialize the rich text box with column headers and customer info if applicable    
            write_to_receipt();
        }

        //This module takes the list of line items and outputs a formatted receipt in the richtextbox
        


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //Define variables. These will only be used to do initial calcs and transfer input values into a Line_Item.
            string added_item_name;
            int added_item_qty;
            double added_item_unit_cost;
            double added_item_subtotal; //this will be the total for the line without tax
            double added_item_tax_pct = 0; //default to 0, change it if the tax checkbox is checked
            double added_item_tax_amt = 0; //default to 0, change it if the tax checkbox is checked
            double added_item_line_total;

            added_item_name = cbox_item_name.Text;
            added_item_qty = (int)num_item_qty.Value;
            added_item_unit_cost = (double)num_item_cost.Value;
            added_item_subtotal = added_item_qty * added_item_unit_cost;
            
            if (chk_sales_tax.Checked)
            {
                added_item_tax_pct = 0.04;
                added_item_tax_amt = added_item_subtotal * added_item_tax_pct;
            }

            added_item_line_total = added_item_tax_amt + added_item_subtotal;

            //now, take those values and create a new Line_Item entry in the Order_Items list
            //public Line_Item(string add_item_name, int add_item_qty, double add_unit_price,
            //                  double add_tax_amt, double add_line_total)

            Order_Items.Add(new Line_Item(added_item_name,added_item_qty,added_item_unit_cost,added_item_tax_amt,added_item_line_total));

            write_to_receipt();
            

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //To save the customer data, we will add the contents of the Customer Information text boxes.
            //We will put the textbox values directly into the constructor since it's all strings.

            //public Customer(string cus_first_name, string cus_last_name, string cus_phone,
            //                  string cus_email, string cus_mail_addr, bool cus_taxed)
            Cust_List.Add(new Customer(txt_cust_first.Text,txt_cust_last.Text,txt_cust_phone.Text,txt_cust_email.Text,txt_cust_mail_addr.Text,true));
            //btn_save.Enabled = false;
        }

        public void write_to_receipt()
        {
            //This list of strings will be added to and subtracted from to populate the rich text box receipt
            //Doing it as a list allows for me to add and remove lines more easily, and sort, etc. if needed 
            List<String> Receipt_Lines = new List<String>();
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

            //Output customer info if it's been entered (list is empty if not)
            foreach (var cust in Cust_List)
            {
                Receipt_Lines.Add("Customer Contact Information:");

                Receipt_Lines.Add(String.Format("{0} {1}", cust.first_name, cust.last_name));
                Receipt_Lines.Add(cust.phone);
                Receipt_Lines.Add(cust.email);
                Receipt_Lines.Add(cust.mail_addr);

            }


            rtxt_receipt.Text = string.Join("\n", Receipt_Lines);
        }
    }
}


