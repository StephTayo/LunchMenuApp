using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.NET_1
{   
    /* Lab1 Assignment
     * Author: Stephen Omotayo
     * Date: 03-31-2023
     * 
     * 
     */
    
    public partial class frmMain : Form
    {
        decimal Subtotal;
        decimal Tax = 0.05m;
        decimal OrderTotal;

        public frmMain()
        {
            InitializeComponent();
        }
        private void pnlAddOn_Enter(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked)
            {
                pnlAddon.Text = "Add-on items($.75/each";
                checkBox1.Text = "Lettuce, tomato, and onions";
                checkBox2.Text = "Ketchup, mustard and mayonnaise";
                checkBox3.Text = "French fries";

                // check box removal
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;


                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();

            }
            else if (rdoPizza.Checked)
            {
                pnlAddon.Text = "Add-on items($.50/each)";
                checkBox1.Text = "Pepproni";
                checkBox2.Text = "Sausage";
                checkBox3.Text = "Olives";


                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();
            }
            else if (rdoSalad.Checked)
            {
                pnlAddon.Text = "Add-on items($.25/each";
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon bits";
                checkBox3.Text = "Bread sticks";

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();
            }
            txtOrderTotal.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal add = 0m;
            if (checkBox1.Checked)
            {
                add++;
            }
            if (checkBox2.Checked)
            {
                add++;
            }
            if (checkBox3.Checked)
            {
                add++;
            }
            if (rdoHamburger.Checked)
            {
                decimal Hamburger = Convert.ToDecimal(rdoHamburger.Checked);
                Hamburger = 6.95m;

                Subtotal = Hamburger + (add * .75m);
                Tax = Subtotal * 0.05m;
                OrderTotal = Tax + Subtotal;

                txtSubtotal.Text = Subtotal.ToString("c");
                txtTax.Text = Tax.ToString("c");
                txtOrderTotal.Text = OrderTotal.ToString("c");

            }
            else if (rdoPizza.Checked)
            {

                decimal Pizza = Convert.ToDecimal(rdoPizza.Checked);
                Pizza = 5.95m;

                Subtotal = Pizza + (add * .50m);

                Tax = Subtotal * 0.05m;
                OrderTotal = Tax + Subtotal;

                txtSubtotal.Text = Subtotal.ToString("c");
                txtTax.Text = Tax.ToString("c");
                txtOrderTotal.Text = OrderTotal.ToString("c");


            }
            else if (rdoSalad.Checked)
            {

                decimal salad = Convert.ToDecimal(rdoSalad.Checked);
                salad = 4.95m;

                Subtotal = salad + (add * .25m);

                Tax = Subtotal * 0.05m;
                OrderTotal = Tax + Subtotal;

                txtSubtotal.Text = Subtotal.ToString("c");
                txtTax.Text = Tax.ToString("c");
                txtOrderTotal.Text = OrderTotal.ToString("c");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            pnlAddon.Text = "";
            checkBox1.Text = "";
            checkBox2.Text = "";
            checkBox3.Text = "";
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtOrderTotal.Text = "";
            pnlAddon.Focus();
        }

        //This section here is so important to me, because it took me forever to figure it out.
        //Thank you Jolanta for not answering me when I asked for the solution in class.
        //P.S: I delibrately commented out the error to remind myself of how it took me a while to figure it out.
        //Thank you ma'am!
        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            //rdoHamburger.Checked = true;
            {
                pnlAddon.Text = "Add-on items($.75/each";
                checkBox1.Text = "Lettuce, tomato, and onions";
                checkBox2.Text = "Ketchup, mustard and mayonnaise";
                checkBox3.Text = "French fries";
                picBx1.Image = Image.FromFile(@"..\..\Image\Burger.jpg");
                picBx2.Image = Image.FromFile(@"..\..\Image\Lettuce et al.jpg");

                // check box removal
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;


                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();
            }
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            //rdoPizza.Checked = false;
            {
                pnlAddon.Text = "Add-on items($.50/each)";
                checkBox1.Text = "Pepproni";
                checkBox2.Text = "Sausage";
                checkBox3.Text = "Olives";
                picBx1.Image = Image.FromFile(@"..\..\Image\Pizza.jpg");
                picBx2.Image = Image.FromFile(@"..\..\Image\croutons.jpg");


                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();

            }
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            //rdoSalad.Checked = false;
            {
                pnlAddon.Text = "Add-on items($.25/each";
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon bits";
                checkBox3.Text = "Bread sticks";
                picBx1.Image = Image.FromFile(@"..\..\Image\Salad.jpg");
                picBx2.Image = Image.FromFile(@"..\..\Image\olives & sausages.jpg");

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                txtOrderTotal.Clear();
                txtSubtotal.Clear();
                txtTax.Clear();
            }
            txtOrderTotal.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();

        }
    }

}

