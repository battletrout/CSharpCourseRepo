
namespace Mod1Lab2_JessieComp
{
    partial class ComputerMarkupCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerMarkupCalculator));
            this.btn_calculate = new System.Windows.Forms.Button();
            this.num_merch_cost = new System.Windows.Forms.NumericUpDown();
            this.num_salary = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_rent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_energy = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pct_mkup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_dol_mkup = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_merch_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_energy)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(33, 463);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // num_merch_cost
            // 
            this.num_merch_cost.DecimalPlaces = 2;
            this.num_merch_cost.Location = new System.Drawing.Point(33, 248);
            this.num_merch_cost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.num_merch_cost.Name = "num_merch_cost";
            this.num_merch_cost.Size = new System.Drawing.Size(120, 20);
            this.num_merch_cost.TabIndex = 7;
            this.num_merch_cost.ThousandsSeparator = true;
            // 
            // num_salary
            // 
            this.num_salary.DecimalPlaces = 2;
            this.num_salary.Location = new System.Drawing.Point(33, 308);
            this.num_salary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_salary.Name = "num_salary";
            this.num_salary.Size = new System.Drawing.Size(120, 20);
            this.num_salary.TabIndex = 9;
            this.num_salary.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "2. What is the total annual salary of the employees?";
            // 
            // num_rent
            // 
            this.num_rent.DecimalPlaces = 2;
            this.num_rent.Location = new System.Drawing.Point(33, 367);
            this.num_rent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_rent.Name = "num_rent";
            this.num_rent.Size = new System.Drawing.Size(120, 20);
            this.num_rent.TabIndex = 11;
            this.num_rent.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "3. What is the total annual rent?";
            // 
            // num_energy
            // 
            this.num_energy.DecimalPlaces = 2;
            this.num_energy.Location = new System.Drawing.Point(33, 425);
            this.num_energy.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_energy.Name = "num_energy";
            this.num_energy.Size = new System.Drawing.Size(120, 20);
            this.num_energy.TabIndex = 13;
            this.num_energy.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "4. What is the monthly estimated energy cost?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Your percentage markup on merchandise cost is:";
            // 
            // txt_pct_mkup
            // 
            this.txt_pct_mkup.Location = new System.Drawing.Point(180, 529);
            this.txt_pct_mkup.Name = "txt_pct_mkup";
            this.txt_pct_mkup.ReadOnly = true;
            this.txt_pct_mkup.Size = new System.Drawing.Size(91, 20);
            this.txt_pct_mkup.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(167, 582);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "$";
            // 
            // txt_dol_mkup
            // 
            this.txt_dol_mkup.Location = new System.Drawing.Point(181, 579);
            this.txt_dol_mkup.Name = "txt_dol_mkup";
            this.txt_dol_mkup.ReadOnly = true;
            this.txt_dol_mkup.Size = new System.Drawing.Size(91, 20);
            this.txt_dol_mkup.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 563);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Your per-dollar markup on each computer is:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 195);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1. What is the annual merchandise cost?";
            // 
            // TicketSalesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 660);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_dol_mkup);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_pct_mkup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num_energy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_rent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_merch_cost);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketSalesCalculator";
            this.Text = "Computer Merchandise Markup Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_merch_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_energy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.NumericUpDown num_merch_cost;
        private System.Windows.Forms.NumericUpDown num_salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_rent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_energy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pct_mkup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_dol_mkup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

