namespace cashRegisterSummative
{
    partial class cashTown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashTown));
            this.burgerDescLabel = new System.Windows.Forms.Label();
            this.friesDescLabel = new System.Windows.Forms.Label();
            this.drinkDescLabel = new System.Windows.Forms.Label();
            this.burgerInputBox = new System.Windows.Forms.TextBox();
            this.friesInputBox = new System.Windows.Forms.TextBox();
            this.drinkInputBox = new System.Windows.Forms.TextBox();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.subTotalDescLabel = new System.Windows.Forms.Label();
            this.taxDescLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.grandTotalDescLabel = new System.Windows.Forms.Label();
            this.tenderedDescLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.tenderedInputBox = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeDescLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.clearOrderButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerDescLabel
            // 
            this.burgerDescLabel.AutoSize = true;
            this.burgerDescLabel.Location = new System.Drawing.Point(12, 9);
            this.burgerDescLabel.Name = "burgerDescLabel";
            this.burgerDescLabel.Size = new System.Drawing.Size(95, 13);
            this.burgerDescLabel.TabIndex = 0;
            this.burgerDescLabel.Text = "Number of Burgers";
            // 
            // friesDescLabel
            // 
            this.friesDescLabel.AutoSize = true;
            this.friesDescLabel.Location = new System.Drawing.Point(12, 45);
            this.friesDescLabel.Name = "friesDescLabel";
            this.friesDescLabel.Size = new System.Drawing.Size(81, 13);
            this.friesDescLabel.TabIndex = 1;
            this.friesDescLabel.Text = "Number of Fries";
            // 
            // drinkDescLabel
            // 
            this.drinkDescLabel.AutoSize = true;
            this.drinkDescLabel.Location = new System.Drawing.Point(12, 83);
            this.drinkDescLabel.Name = "drinkDescLabel";
            this.drinkDescLabel.Size = new System.Drawing.Size(89, 13);
            this.drinkDescLabel.TabIndex = 2;
            this.drinkDescLabel.Text = "Number of Drinks";
            // 
            // burgerInputBox
            // 
            this.burgerInputBox.Location = new System.Drawing.Point(117, 6);
            this.burgerInputBox.Name = "burgerInputBox";
            this.burgerInputBox.Size = new System.Drawing.Size(100, 20);
            this.burgerInputBox.TabIndex = 3;
            this.burgerInputBox.Text = "0";
            this.burgerInputBox.TextChanged += new System.EventHandler(this.burgerInputBox_TextChanged);
            // 
            // friesInputBox
            // 
            this.friesInputBox.Location = new System.Drawing.Point(117, 42);
            this.friesInputBox.Name = "friesInputBox";
            this.friesInputBox.Size = new System.Drawing.Size(100, 20);
            this.friesInputBox.TabIndex = 4;
            this.friesInputBox.Text = "0";
            this.friesInputBox.TextChanged += new System.EventHandler(this.friesInputBox_TextChanged);
            // 
            // drinkInputBox
            // 
            this.drinkInputBox.Location = new System.Drawing.Point(117, 83);
            this.drinkInputBox.Name = "drinkInputBox";
            this.drinkInputBox.Size = new System.Drawing.Size(100, 20);
            this.drinkInputBox.TabIndex = 5;
            this.drinkInputBox.Text = "0";
            this.drinkInputBox.TextChanged += new System.EventHandler(this.drinkInputBox_TextChanged);
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateTotalsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateTotalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalsButton.Location = new System.Drawing.Point(15, 121);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(202, 23);
            this.calculateTotalsButton.TabIndex = 6;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = false;
            this.calculateTotalsButton.Click += new System.EventHandler(this.calculateTotalsButton_Click);
            // 
            // subTotalDescLabel
            // 
            this.subTotalDescLabel.AutoSize = true;
            this.subTotalDescLabel.Location = new System.Drawing.Point(12, 166);
            this.subTotalDescLabel.Name = "subTotalDescLabel";
            this.subTotalDescLabel.Size = new System.Drawing.Size(53, 13);
            this.subTotalDescLabel.TabIndex = 7;
            this.subTotalDescLabel.Text = "Sub Total";
            this.subTotalDescLabel.Visible = false;
            // 
            // taxDescLabel
            // 
            this.taxDescLabel.AutoSize = true;
            this.taxDescLabel.Location = new System.Drawing.Point(12, 199);
            this.taxDescLabel.Name = "taxDescLabel";
            this.taxDescLabel.Size = new System.Drawing.Size(25, 13);
            this.taxDescLabel.TabIndex = 8;
            this.taxDescLabel.Text = "Tax";
            this.taxDescLabel.Visible = false;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(182, 199);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(34, 13);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "$0.00";
            this.taxLabel.Visible = false;
            // 
            // grandTotalDescLabel
            // 
            this.grandTotalDescLabel.AutoSize = true;
            this.grandTotalDescLabel.Location = new System.Drawing.Point(12, 230);
            this.grandTotalDescLabel.Name = "grandTotalDescLabel";
            this.grandTotalDescLabel.Size = new System.Drawing.Size(63, 13);
            this.grandTotalDescLabel.TabIndex = 10;
            this.grandTotalDescLabel.Text = "Grand Total";
            this.grandTotalDescLabel.Visible = false;
            // 
            // tenderedDescLabel
            // 
            this.tenderedDescLabel.AutoSize = true;
            this.tenderedDescLabel.Location = new System.Drawing.Point(12, 298);
            this.tenderedDescLabel.Name = "tenderedDescLabel";
            this.tenderedDescLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedDescLabel.TabIndex = 11;
            this.tenderedDescLabel.Text = "Tendered";
            this.tenderedDescLabel.Visible = false;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(182, 166);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(34, 13);
            this.subTotalLabel.TabIndex = 12;
            this.subTotalLabel.Text = "$0.00";
            this.subTotalLabel.Visible = false;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Location = new System.Drawing.Point(182, 230);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(34, 13);
            this.grandTotalLabel.TabIndex = 13;
            this.grandTotalLabel.Text = "$0.00";
            this.grandTotalLabel.Visible = false;
            // 
            // tenderedInputBox
            // 
            this.tenderedInputBox.Location = new System.Drawing.Point(116, 295);
            this.tenderedInputBox.Name = "tenderedInputBox";
            this.tenderedInputBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedInputBox.TabIndex = 14;
            this.tenderedInputBox.Visible = false;
            this.tenderedInputBox.TextChanged += new System.EventHandler(this.tenderedInputBox_TextChanged);
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateChangeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.Location = new System.Drawing.Point(11, 332);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(205, 23);
            this.calculateChangeButton.TabIndex = 15;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Visible = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(182, 378);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(34, 13);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "$0.00";
            this.changeLabel.Visible = false;
            // 
            // changeDescLabel
            // 
            this.changeDescLabel.AutoSize = true;
            this.changeDescLabel.Location = new System.Drawing.Point(12, 378);
            this.changeDescLabel.Name = "changeDescLabel";
            this.changeDescLabel.Size = new System.Drawing.Size(44, 13);
            this.changeDescLabel.TabIndex = 17;
            this.changeDescLabel.Text = "Change";
            this.changeDescLabel.Visible = false;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.printReceiptButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptButton.Location = new System.Drawing.Point(15, 417);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(201, 23);
            this.printReceiptButton.TabIndex = 18;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Visible = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // formNameLabel
            // 
            this.formNameLabel.AutoSize = true;
            this.formNameLabel.BackColor = System.Drawing.Color.White;
            this.formNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formNameLabel.Location = new System.Drawing.Point(270, 6);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(145, 31);
            this.formNameLabel.TabIndex = 19;
            this.formNameLabel.Text = "CashTown";
            // 
            // clearOrderButton
            // 
            this.clearOrderButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearOrderButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearOrderButton.Location = new System.Drawing.Point(253, 417);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(180, 23);
            this.clearOrderButton.TabIndex = 20;
            this.clearOrderButton.Text = "Clear Order";
            this.clearOrderButton.UseVisualStyleBackColor = false;
            this.clearOrderButton.Visible = false;
            this.clearOrderButton.Click += new System.EventHandler(this.clearOrderButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 452);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 21;
            // 
            // cashTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 486);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.clearOrderButton);
            this.Controls.Add(this.formNameLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeDescLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedInputBox);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.tenderedDescLabel);
            this.Controls.Add(this.grandTotalDescLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.taxDescLabel);
            this.Controls.Add(this.subTotalDescLabel);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.drinkInputBox);
            this.Controls.Add(this.friesInputBox);
            this.Controls.Add(this.burgerInputBox);
            this.Controls.Add(this.drinkDescLabel);
            this.Controls.Add(this.friesDescLabel);
            this.Controls.Add(this.burgerDescLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashTown";
            this.Text = "CashTown Corp.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerDescLabel;
        private System.Windows.Forms.Label friesDescLabel;
        private System.Windows.Forms.Label drinkDescLabel;
        private System.Windows.Forms.TextBox burgerInputBox;
        private System.Windows.Forms.TextBox friesInputBox;
        private System.Windows.Forms.TextBox drinkInputBox;
        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.Label subTotalDescLabel;
        private System.Windows.Forms.Label taxDescLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label grandTotalDescLabel;
        private System.Windows.Forms.Label tenderedDescLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.TextBox tenderedInputBox;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeDescLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.Button clearOrderButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

