
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.type_of_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type_of_ticket,
            this.ticket_price,
            this.num_sold,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(96, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello! Thank you for using the Ticket Price Calculator!\r\n\r\nFirst, select the type" +
    " of ticket youy would like to purchase";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TicketSalesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TicketSalesCalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_of_ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Label label1;
    }
}

