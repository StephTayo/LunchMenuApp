namespace Assignment.NET_1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.pnlOrderTotal = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.pnlAddon = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMainCourse.SuspendLayout();
            this.pnlOrderTotal.SuspendLayout();
            this.pnlAddon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainCourse
            // 
            this.pnlMainCourse.Controls.Add(this.rdoSalad);
            this.pnlMainCourse.Controls.Add(this.rdoPizza);
            this.pnlMainCourse.Controls.Add(this.rdoHamburger);
            this.pnlMainCourse.Location = new System.Drawing.Point(12, 209);
            this.pnlMainCourse.Name = "pnlMainCourse";
            this.pnlMainCourse.Size = new System.Drawing.Size(192, 99);
            this.pnlMainCourse.TabIndex = 0;
            this.pnlMainCourse.TabStop = false;
            this.pnlMainCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(6, 76);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 3;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(6, 53);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Location = new System.Drawing.Point(6, 30);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // pnlOrderTotal
            // 
            this.pnlOrderTotal.Controls.Add(this.label3);
            this.pnlOrderTotal.Controls.Add(this.label2);
            this.pnlOrderTotal.Controls.Add(this.label1);
            this.pnlOrderTotal.Controls.Add(this.txtOrderTotal);
            this.pnlOrderTotal.Controls.Add(this.txtTax);
            this.pnlOrderTotal.Controls.Add(this.txtSubtotal);
            this.pnlOrderTotal.Location = new System.Drawing.Point(12, 326);
            this.pnlOrderTotal.Name = "pnlOrderTotal";
            this.pnlOrderTotal.Size = new System.Drawing.Size(274, 153);
            this.pnlOrderTotal.TabIndex = 1;
            this.pnlOrderTotal.TabStop = false;
            this.pnlOrderTotal.Text = "Order Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax (5%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BackColor = System.Drawing.Color.LightBlue;
            this.txtOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.ForeColor = System.Drawing.Color.Red;
            this.txtOrderTotal.Location = new System.Drawing.Point(118, 104);
            this.txtOrderTotal.Multiline = true;
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(111, 30);
            this.txtOrderTotal.TabIndex = 2;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.Color.LightBlue;
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(118, 66);
            this.txtTax.Multiline = true;
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(111, 30);
            this.txtTax.TabIndex = 1;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.LightBlue;
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(118, 28);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(111, 30);
            this.txtSubtotal.TabIndex = 0;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlAddon
            // 
            this.pnlAddon.Controls.Add(this.checkBox3);
            this.pnlAddon.Controls.Add(this.checkBox2);
            this.pnlAddon.Controls.Add(this.checkBox1);
            this.pnlAddon.Location = new System.Drawing.Point(229, 209);
            this.pnlAddon.Name = "pnlAddon";
            this.pnlAddon.Size = new System.Drawing.Size(209, 99);
            this.pnlAddon.TabIndex = 2;
            this.pnlAddon.TabStop = false;
            this.pnlAddon.Text = "Add-on items ($.75/each)";
            this.pnlAddon.Enter += new System.EventHandler(this.pnlAddOn_Enter);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(84, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "French Fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 53);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ketchup, mustad, and mayo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Lettuce, tomato, and onions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Linen;
            this.btnPlaceOrder.Location = new System.Drawing.Point(330, 326);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(108, 33);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Linen;
            this.btnReset.Location = new System.Drawing.Point(330, 381);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 33);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Linen;
            this.btnExit.Location = new System.Drawing.Point(330, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(450, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.pnlAddon);
            this.Controls.Add(this.pnlOrderTotal);
            this.Controls.Add(this.pnlMainCourse);
            this.Name = "frmMain";
            this.Text = "Lunch Order";
            this.pnlMainCourse.ResumeLayout(false);
            this.pnlMainCourse.PerformLayout();
            this.pnlOrderTotal.ResumeLayout(false);
            this.pnlOrderTotal.PerformLayout();
            this.pnlAddon.ResumeLayout(false);
            this.pnlAddon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlMainCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.GroupBox pnlOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.GroupBox pnlAddon;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

