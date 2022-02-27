
namespace IT207N_Week10PizzaSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControlOrder = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbBeverages = new System.Windows.Forms.GroupBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.chkCoke = new System.Windows.Forms.CheckBox();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbCheesy = new System.Windows.Forms.RadioButton();
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.tabPageConfirm = new System.Windows.Forms.TabPage();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControlOrder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbBeverages.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbPizzaSize.SuspendLayout();
            this.tabPageConfirm.SuspendLayout();
            this.tabPagePayment.SuspendLayout();
            this.gbPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(371, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(225, 225);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tabControlOrder
            // 
            this.tabControlOrder.Controls.Add(this.tabPage1);
            this.tabControlOrder.Controls.Add(this.tabPageConfirm);
            this.tabControlOrder.Controls.Add(this.tabPagePayment);
            this.tabControlOrder.Location = new System.Drawing.Point(57, 290);
            this.tabControlOrder.Name = "tabControlOrder";
            this.tabControlOrder.SelectedIndex = 0;
            this.tabControlOrder.Size = new System.Drawing.Size(909, 625);
            this.tabControlOrder.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConfirm);
            this.tabPage1.Controls.Add(this.gbBeverages);
            this.tabPage1.Controls.Add(this.gbTopping);
            this.tabPage1.Controls.Add(this.gbCrust);
            this.tabPage1.Controls.Add(this.gbPizzaSize);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Place Your Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(377, 506);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfirm.Size = new System.Drawing.Size(164, 52);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // gbBeverages
            // 
            this.gbBeverages.Controls.Add(this.lblQty);
            this.gbBeverages.Controls.Add(this.txtQuantity);
            this.gbBeverages.Controls.Add(this.chkCoke);
            this.gbBeverages.Location = new System.Drawing.Point(52, 388);
            this.gbBeverages.Name = "gbBeverages";
            this.gbBeverages.Size = new System.Drawing.Size(771, 98);
            this.gbBeverages.TabIndex = 3;
            this.gbBeverages.TabStop = false;
            this.gbBeverages.Text = "Beverages";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(165, 21);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(61, 17);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(157, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // chkCoke
            // 
            this.chkCoke.AutoSize = true;
            this.chkCoke.Location = new System.Drawing.Point(39, 45);
            this.chkCoke.Name = "chkCoke";
            this.chkCoke.Size = new System.Drawing.Size(69, 24);
            this.chkCoke.TabIndex = 0;
            this.chkCoke.Text = "Coke";
            this.chkCoke.UseVisualStyleBackColor = true;
            // 
            // gbTopping
            // 
            this.gbTopping.Controls.Add(this.chkBacon);
            this.gbTopping.Controls.Add(this.chkHam);
            this.gbTopping.Controls.Add(this.chkPepperoni);
            this.gbTopping.Location = new System.Drawing.Point(52, 284);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(771, 77);
            this.gbTopping.TabIndex = 2;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Toppings";
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(546, 38);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(79, 24);
            this.chkBacon.TabIndex = 2;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(319, 38);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(67, 24);
            this.chkHam.TabIndex = 1;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(37, 38);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(106, 24);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbNormal);
            this.gbCrust.Controls.Add(this.rbCheesy);
            this.gbCrust.Location = new System.Drawing.Point(52, 173);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(771, 87);
            this.gbCrust.TabIndex = 1;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(157, 37);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(84, 24);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbCheesy
            // 
            this.rbCheesy.AutoSize = true;
            this.rbCheesy.Location = new System.Drawing.Point(453, 37);
            this.rbCheesy.Name = "rbCheesy";
            this.rbCheesy.Size = new System.Drawing.Size(86, 24);
            this.rbCheesy.TabIndex = 1;
            this.rbCheesy.TabStop = true;
            this.rbCheesy.Text = "Cheesy";
            this.rbCheesy.UseVisualStyleBackColor = true;
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.Controls.Add(this.rbLarge);
            this.gbPizzaSize.Controls.Add(this.rbMedium);
            this.gbPizzaSize.Controls.Add(this.rbSmall);
            this.gbPizzaSize.Location = new System.Drawing.Point(52, 51);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Size = new System.Drawing.Size(771, 88);
            this.gbPizzaSize.TabIndex = 0;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Pizza Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(546, 42);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(156, 24);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large (RM10.00)";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(278, 42);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(163, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium (RM7.00)";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(37, 42);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(146, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small (RM4.00)";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // tabPageConfirm
            // 
            this.tabPageConfirm.Controls.Add(this.btnProceed);
            this.tabPageConfirm.Controls.Add(this.txtTotal);
            this.tabPageConfirm.Controls.Add(this.lblTotal);
            this.tabPageConfirm.Controls.Add(this.listViewOrder);
            this.tabPageConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageConfirm.Location = new System.Drawing.Point(4, 25);
            this.tabPageConfirm.Name = "tabPageConfirm";
            this.tabPageConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfirm.Size = new System.Drawing.Size(901, 596);
            this.tabPageConfirm.TabIndex = 1;
            this.tabPageConfirm.Text = "Confirm Your Order";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(592, 499);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(234, 59);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Proceed to Payment";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(705, 372);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 26);
            this.txtTotal.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(606, 373);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total Price: ";
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(56, 65);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(770, 273);
            this.listViewOrder.TabIndex = 0;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Items";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 150;
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.Controls.Add(this.gbPayment);
            this.tabPagePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePayment.Location = new System.Drawing.Point(4, 25);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Size = new System.Drawing.Size(901, 596);
            this.tabPagePayment.TabIndex = 2;
            this.tabPagePayment.Text = "Make Payment";
            this.tabPagePayment.UseVisualStyleBackColor = true;
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.txtChange);
            this.gbPayment.Controls.Add(this.txtAmount);
            this.gbPayment.Controls.Add(this.txtCardNo);
            this.gbPayment.Controls.Add(this.cbPaymentMethod);
            this.gbPayment.Controls.Add(this.lblChange);
            this.gbPayment.Controls.Add(this.lblAmount);
            this.gbPayment.Controls.Add(this.lblCardNo);
            this.gbPayment.Controls.Add(this.lblMethod);
            this.gbPayment.Location = new System.Drawing.Point(64, 47);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(740, 314);
            this.gbPayment.TabIndex = 0;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment Information";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(68, 109);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(119, 20);
            this.lblCardNo.TabIndex = 1;
            this.lblCardNo.Text = "Card Number: ";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(68, 67);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(144, 20);
            this.lblMethod.TabIndex = 0;
            this.lblMethod.Text = "Payment Method: ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(68, 154);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(76, 20);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount: ";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(68, 198);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(76, 20);
            this.lblChange.TabIndex = 3;
            this.lblChange.Text = "Change: ";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(218, 59);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(183, 28);
            this.cbPaymentMethod.TabIndex = 4;
            this.cbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbPaymentMethod_SelectedIndexChanged);
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(218, 109);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(183, 26);
            this.txtCardNo.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(218, 154);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(183, 26);
            this.txtAmount.TabIndex = 6;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(215, 198);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(186, 26);
            this.txtChange.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 961);
            this.Controls.Add(this.tabControlOrder);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Pizza Ordering System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControlOrder.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbBeverages.ResumeLayout(false);
            this.gbBeverages.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.tabPageConfirm.ResumeLayout(false);
            this.tabPageConfirm.PerformLayout();
            this.tabPagePayment.ResumeLayout(false);
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TabControl tabControlOrder;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.TabPage tabPageConfirm;
        private System.Windows.Forms.TabPage tabPagePayment;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbCheesy;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.GroupBox gbBeverages;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.CheckBox chkCoke;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtCardNo;
    }
}

