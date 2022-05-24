
namespace CourseProj
{
    partial class CourseProj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseProj));
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_item_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_item_qty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.pnl_order = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_sales_tax = new System.Windows.Forms.CheckBox();
            this.num_item_cost = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cust_last = new System.Windows.Forms.TextBox();
            this.txt_cust_mail_addr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cust_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cust_first = new System.Windows.Forms.TextBox();
            this.txt_cust_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxt_receipt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_item_qty)).BeginInit();
            this.pnl_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_item_cost)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 156);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // cbox_item_name
            // 
            this.cbox_item_name.FormattingEnabled = true;
            this.cbox_item_name.Location = new System.Drawing.Point(16, 54);
            this.cbox_item_name.Name = "cbox_item_name";
            this.cbox_item_name.Size = new System.Drawing.Size(121, 21);
            this.cbox_item_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a. Item name";
            // 
            // num_item_qty
            // 
            this.num_item_qty.Location = new System.Drawing.Point(171, 55);
            this.num_item_qty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_item_qty.Name = "num_item_qty";
            this.num_item_qty.Size = new System.Drawing.Size(120, 20);
            this.num_item_qty.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "b. Quantity purchased";
            // 
            // btn_add_item
            // 
            this.btn_add_item.Location = new System.Drawing.Point(577, 55);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(75, 23);
            this.btn_add_item.TabIndex = 6;
            this.btn_add_item.Text = "Add to Order";
            this.btn_add_item.UseVisualStyleBackColor = true;
            this.btn_add_item.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // pnl_order
            // 
            this.pnl_order.Controls.Add(this.label7);
            this.pnl_order.Controls.Add(this.chk_sales_tax);
            this.pnl_order.Controls.Add(this.num_item_cost);
            this.pnl_order.Controls.Add(this.label4);
            this.pnl_order.Controls.Add(this.btn_add_item);
            this.pnl_order.Controls.Add(this.cbox_item_name);
            this.pnl_order.Controls.Add(this.label2);
            this.pnl_order.Controls.Add(this.num_item_qty);
            this.pnl_order.Controls.Add(this.label3);
            this.pnl_order.Location = new System.Drawing.Point(16, 191);
            this.pnl_order.Name = "pnl_order";
            this.pnl_order.Size = new System.Drawing.Size(683, 90);
            this.pnl_order.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Add Item(s) to Sale";
            // 
            // chk_sales_tax
            // 
            this.chk_sales_tax.AutoSize = true;
            this.chk_sales_tax.Checked = true;
            this.chk_sales_tax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_sales_tax.Location = new System.Drawing.Point(467, 58);
            this.chk_sales_tax.Name = "chk_sales_tax";
            this.chk_sales_tax.Size = new System.Drawing.Size(90, 17);
            this.chk_sales_tax.TabIndex = 8;
            this.chk_sales_tax.Text = "4% Sales Tax";
            this.chk_sales_tax.UseVisualStyleBackColor = true;
            // 
            // num_item_cost
            // 
            this.num_item_cost.DecimalPlaces = 2;
            this.num_item_cost.Location = new System.Drawing.Point(330, 55);
            this.num_item_cost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_item_cost.Name = "num_item_cost";
            this.num_item_cost.Size = new System.Drawing.Size(120, 20);
            this.num_item_cost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "c. Cost per item ($)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_cust_last);
            this.panel1.Controls.Add(this.txt_cust_mail_addr);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_cust_phone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_cust_first);
            this.panel1.Controls.Add(this.txt_cust_email);
            this.panel1.Location = new System.Drawing.Point(398, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 181);
            this.panel1.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(195, 154);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mailing Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Last Name";
            // 
            // txt_cust_last
            // 
            this.txt_cust_last.Location = new System.Drawing.Point(154, 40);
            this.txt_cust_last.Name = "txt_cust_last";
            this.txt_cust_last.Size = new System.Drawing.Size(135, 20);
            this.txt_cust_last.TabIndex = 10;
            // 
            // txt_cust_mail_addr
            // 
            this.txt_cust_mail_addr.Location = new System.Drawing.Point(4, 119);
            this.txt_cust_mail_addr.Name = "txt_cust_mail_addr";
            this.txt_cust_mail_addr.Size = new System.Drawing.Size(285, 20);
            this.txt_cust_mail_addr.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Phone Number";
            // 
            // txt_cust_phone
            // 
            this.txt_cust_phone.Location = new System.Drawing.Point(3, 157);
            this.txt_cust_phone.Name = "txt_cust_phone";
            this.txt_cust_phone.Size = new System.Drawing.Size(135, 20);
            this.txt_cust_phone.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email";
            // 
            // txt_cust_first
            // 
            this.txt_cust_first.Location = new System.Drawing.Point(4, 40);
            this.txt_cust_first.Name = "txt_cust_first";
            this.txt_cust_first.Size = new System.Drawing.Size(135, 20);
            this.txt_cust_first.TabIndex = 0;
            // 
            // txt_cust_email
            // 
            this.txt_cust_email.Location = new System.Drawing.Point(4, 80);
            this.txt_cust_email.Name = "txt_cust_email";
            this.txt_cust_email.Size = new System.Drawing.Size(285, 20);
            this.txt_cust_email.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Sale Receipt";
            // 
            // rtxt_receipt
            // 
            this.rtxt_receipt.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_receipt.Location = new System.Drawing.Point(16, 326);
            this.rtxt_receipt.Name = "rtxt_receipt";
            this.rtxt_receipt.Size = new System.Drawing.Size(683, 333);
            this.rtxt_receipt.TabIndex = 11;
            this.rtxt_receipt.Text = "";
            // 
            // CourseProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 663);
            this.Controls.Add(this.rtxt_receipt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_order);
            this.Controls.Add(this.label1);
            this.Name = "CourseProj";
            this.Text = "Sales Receipt Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_item_qty)).EndInit();
            this.pnl_order.ResumeLayout(false);
            this.pnl_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_item_cost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_item_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_item_qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Panel pnl_order;
        private System.Windows.Forms.NumericUpDown num_item_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_sales_tax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cust_last;
        private System.Windows.Forms.TextBox txt_cust_mail_addr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cust_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cust_first;
        private System.Windows.Forms.TextBox txt_cust_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxt_receipt;
    }
}

