
namespace Mod1Lab1_EventVenue
{
    partial class TicketSalesCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketSalesCalculator));
            this.dataGridView_ticket_calc = new System.Windows.Forms.DataGridView();
            this.type_of_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_ticket_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_ticket_num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket_calc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ticket_num)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ticket_calc
            // 
            this.dataGridView_ticket_calc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ticket_calc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type_of_ticket,
            this.ticket_price,
            this.num_sold,
            this.cost});
            this.dataGridView_ticket_calc.Location = new System.Drawing.Point(16, 288);
            this.dataGridView_ticket_calc.Name = "dataGridView_ticket_calc";
            this.dataGridView_ticket_calc.Size = new System.Drawing.Size(444, 150);
            this.dataGridView_ticket_calc.TabIndex = 0;
            // 
            // type_of_ticket
            // 
            this.type_of_ticket.HeaderText = "Type of Ticket";
            this.type_of_ticket.Name = "type_of_ticket";
            this.type_of_ticket.ReadOnly = true;
            // 
            // ticket_price
            // 
            this.ticket_price.HeaderText = "ticket price";
            this.ticket_price.Name = "ticket_price";
            this.ticket_price.ReadOnly = true;
            // 
            // num_sold
            // 
            this.num_sold.HeaderText = "# of Tickets Sold";
            this.num_sold.Name = "num_sold";
            this.num_sold.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // cbox_ticket_type
            // 
            this.cbox_ticket_type.FormattingEnabled = true;
            this.cbox_ticket_type.Location = new System.Drawing.Point(16, 160);
            this.cbox_ticket_type.Name = "cbox_ticket_type";
            this.cbox_ticket_type.Size = new System.Drawing.Size(121, 21);
            this.cbox_ticket_type.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1. What level of ticket?";
            // 
            // num_ticket_num
            // 
            this.num_ticket_num.Location = new System.Drawing.Point(183, 160);
            this.num_ticket_num.Name = "num_ticket_num";
            this.num_ticket_num.Size = new System.Drawing.Size(120, 20);
            this.num_ticket_num.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2. How many of that type?";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(346, 160);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // TicketSalesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_ticket_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_ticket_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_ticket_calc);
            this.Name = "TicketSalesCalculator";
            this.Text = "Ticket Sales Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket_calc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ticket_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ticket_calc;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_of_ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_ticket_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_ticket_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calculate;
    }
}

