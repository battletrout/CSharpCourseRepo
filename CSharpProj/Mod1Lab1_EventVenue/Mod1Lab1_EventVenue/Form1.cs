using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod1Lab1_EventVenue
{
    public partial class TicketSalesCalculator : Form
    {
        //Define variables
        //public string TicketType { get; set; }
        //public int TicketCost { get; set; }
        //public int TicketNum { get; set; }
        //public int TicketTotal { get; set; }
        
        public TicketSalesCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        //populate combobox with ticket types
            cbox_ticket_type.Items.AddRange(new object[] {
                "orchestra",
                "floor",
                "tier 1",
                "tier 2",
                "tier 3"});
        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //Define variables
            string TicketType;
            int TicketCost;
            int TicketNum;
            int TicketTotal;

            //make sure the table is clear in case input fails
            dataGridView_ticket_calc.Rows.Clear();

            //Decision statement: how many tickets did the user enter?
            //TicketNum becomes the value in the number box, rounded down to the integer
            TicketNum = (int)Math.Floor(num_ticket_num.Value);

            //TicketType becomes the value in the combobox, lower case to allow for capitalization in input
            TicketType = cbox_ticket_type.Text.ToLower();

            //Default TicketCost is 0; if it is 0 after the switch/case below, it means there is incorrect input.
            TicketCost = 0;
           
            switch (TicketType)
            {
                //Decision statement: what is the cost per ticket based off what the type of ticket is the user entered?
                case "orchestra":
                    TicketCost = 100;
                    break;

                case "floor":
                    TicketCost = 75;
                    break;

                case "tier 1":
                    TicketCost = 50;
                    break;

                case "tier 2":
                    TicketCost = 40;
                    break;

                case "tier 3":
                    TicketCost = 35;
                    break;

                default:
                    //This means there was invalid input in the TypeOfTicket box
                    MessageBox.Show("Error- select a ticket type from the combo box.");
                    break;
                }

                if (TicketCost > 0)
                {
                    TicketTotal = calculate_total_cost(TicketNum, TicketCost);
                    dataGridView_ticket_calc.Rows.Add(TicketType, TicketCost, TicketNum, TicketTotal);
                }

        }

        public int calculate_total_cost(int numTickets, int costPerTicket)
        {
            return (numTickets * costPerTicket);
        }

    }
}
//    public class TicketSale
//    {
//        public string TicketType { get; set; }
//        public int TicketCost { get; set; }
//        public int TicketNum { get; set; }
//        public int TicketTotal { get; set; }

//        public void SetTicketCost(string TypeOfTicket)
//        {
//            switch (TypeOfTicket)
//            {
//                case "Orchestra":
//                    TicketCost = 100;
//                    break;

//                case "floor":
//                    TicketCost = 75;
//                    break;

//                case "tier 1":
//                    TicketCost = 50;
//                    break;

//                case "tier 2":
//                    TicketCost = 40;
//                    break;

//                case "tier 3":
//                    TicketCost = 35;
//                    break;

//                default:
//                    //This means there was invalid input in the TypeOfTicket box
//                    TicketCost = -1;
//                    break;


//            }
//        }

//        public void CalcTicketVal()
//        {


//        }

//    }
//}
