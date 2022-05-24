using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod1Lab2_JessieComp
{
    public partial class ComputerMarkupCalculator : Form
    {
       
        public ComputerMarkupCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //Define variables
            double cost_merch;
            double cost_salary;
            double cost_rent;
            double cost_energy_yr;
            double total_yr_operating_costs;
            double target_revenue;
            double merch_markup_pct;
            double merch_markup_dol;
            int computers_num = 5200;
            double target_profit_pct = 0.20;


            //make sure both output textboxes are clear in case input fails
            txt_pct_mkup.Text = "";
            txt_dol_mkup.Text = "";

            //Pull user's input into local variables
            cost_merch = (double)num_merch_cost.Value;
            cost_salary = (double)num_salary.Value;
            cost_rent = (double)num_rent.Value;
            cost_energy_yr = ((double)num_energy.Value) * 12; //Since it's given as a monthly amt

            //Calculate total annual operating costs from user input
            total_yr_operating_costs = cost_merch + cost_salary + cost_rent + cost_energy_yr;

            //Calculate the total $ in sales needed to meet operating costs + target profit
            target_revenue = total_yr_operating_costs * (1 + target_profit_pct);

            //The only income is from sales, thus the markup on the merchandise must cover all other operating costs plus profit
            //The merchandise cost is subtracted from target revenue because the question is looking for the "markup" on merchandise
            merch_markup_pct = 100 * (target_revenue - cost_merch) / cost_merch;

            //To calculate the per-dollar markup, we subtract cost_merch from target_revenue again, but divide by the number of computers
            merch_markup_dol = (target_revenue - cost_merch) / computers_num;
       
            //Display markup values in textboxes
            txt_pct_mkup.Text = merch_markup_pct.ToString("0.00");
            txt_dol_mkup.Text = merch_markup_dol.ToString("0.00");

        }
    }
}

