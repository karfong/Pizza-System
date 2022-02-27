using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT207N_Week10PizzaSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //when user select pizza size = small
            if (rbSmall.Checked == true)
            {
                //when user choose the crust = normal
                if (rbNormal.Checked == true)
                {
                    //add selected items into list view on second tab page
                    //refers to List View Column  - items
                    ListViewItem item = new ListViewItem("Normal Crust Small Pizza");

                    //add subitems into columns
                    item.SubItems.Add("1");//refers to List View Column  - quantity
                    item.SubItems.Add("4.00");//refers to List View Column  - price

                    //add subitems into the listview
                    listViewOrder.Items.Add(item);

                }
            }

            //Toppings
            if (chkPepperoni.Checked == true)
            {
                ListViewItem item = new ListViewItem("Pepperoni");
                item.SubItems.Add("2");//sample code for week 10 (suppose to get from user input and store in database)
                item.SubItems.Add("1.00");//sample code for week 10 (suppose to get from user input and store in database)
                listViewOrder.Items.Add(item);
            }

            //Drinks
            if (chkCoke.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coke");
                item.SubItems.Add(txtQuantity.Text);
                item.SubItems.Add("1.00");//sample code for week 10 (suppose to get from user input and store in database)
                listViewOrder.Items.Add(item);
            }
            else 
            {
                //clear the text box value
                txtQuantity.Text = "";
            }

            //Calculate total price
            double total = 0;

            //listViewOrder is the container
            //ListViewItem is the list of items listed in listViewOrder
            foreach (ListViewItem item in listViewOrder.Items)
            {
                //item.SubItems[2] refers to price column in listViewOrder
                total = total + Convert.ToDouble(item.SubItems[2].Text);
            }

            //Convert the total to String (txtTotal.Text)
            //F2 = fix to 2 decimal points
            string showTotal = total.ToString("F2");

            //display the total in the textbox
            txtTotal.Text = showTotal;

            //once the confirm order button is clicked, it will proceed to 2nd tab page
            tabControlOrder.SelectTab("tabPageConfirm");
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtTotal.Text;
            txtAmount.Enabled = false;

            tabControlOrder.SelectTab("tabPagePayment");
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when user select cash from drop down list
            if (cbPaymentMethod.Text == "Cash")
            {
                txtCardNo.Enabled = false;
                txtChange.Enabled = true;
            }
            else {
                txtCardNo.Enabled = true;
                txtChange.Enabled = false;
            }
        }

        //validation for quantity - only allow user to key in numbers
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char quantity = e.KeyChar;

            if (!Char.IsDigit(quantity) && quantity != 8 && quantity != 46)
            {
                e.Handled = true;
            }
        }
    }
}
