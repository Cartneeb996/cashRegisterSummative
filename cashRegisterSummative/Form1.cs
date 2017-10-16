using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace cashRegisterSummative
{

    public partial class cashTown : Form
    {
        //variable setup

        const double BURGER_COST = 2.49;
        const double FRIES_COST = 1.89;
        const double DRINK_COST = 0.99;
        const double TAX_RATE = 0.13;
        int burgerAmount = 0;
        int friesAmount = 0;
        int drinkAmount = 0;
        double subTotal;
        double taxAmount;
        double grandTotal;
        double amountPaid;
        double change;
        int errorAmount = 0;
        int orderNumber;
        string input = "";
        int dateD;
        int dateM;
        int dateY;
        SoundPlayer registerSound = new SoundPlayer(Properties.Resources.Dot_Matrix_Printer_SoundBible_com_790333844);
        Random randNum = new Random();
        Font receiptFont = new Font("Consolas", 12);
        SolidBrush receiptBrush = new SolidBrush(Color.Black);
        Pen receiptPen = new Pen(Color.Black);

        private void clearAll() // method to clear input and labels
        {
            clearOrderButton.Visible = false;
            tenderedInputBox.Visible = false;
            printReceiptButton.Visible = false;
            tenderedDescLabel.Visible = false;
            changeDescLabel.Visible = false;
            changeLabel.Visible = false;
            subTotalLabel.Visible = false;
            subTotalDescLabel.Visible = false;
            taxDescLabel.Visible = false;
            taxLabel.Visible = false;
            grandTotalDescLabel.Visible = false;
            grandTotalLabel.Visible = false;
        }
        
        public cashTown()
        {
            InitializeComponent();
        }

        private void burgerInputBox_TextChanged(object sender, EventArgs e)
        {
            try // accept a value 
            {
                burgerAmount = Convert.ToInt16(burgerInputBox.Text);
                calculateTotalsButton.Visible = true;
            }
            catch // display error message, and clear inputs
            {               
                burgerInputBox.Text = "";
                clearAll();
                errorLabel.Text = "That is not a proper number!"; 
                return;
            }
            errorLabel.Text = ""; //clear error text
            if (drinkInputBox.Text == "" | friesInputBox.Text == "" | burgerInputBox.Text == "") // if there are any empty values..
            {
                calculateTotalsButton.Visible = false;
            }

        }

        private void friesInputBox_TextChanged(object sender, EventArgs e)
        {
            try // accept a value 
            {
                friesAmount = Convert.ToInt16(friesInputBox.Text);
                calculateTotalsButton.Visible = true;             
            }
            catch // display error message, and remove progress option if input is not a number
            {
                friesInputBox.Text = "";
                clearAll();
                errorLabel.Text = "That is not a proper number!";
                return;
            }

            errorLabel.Text = ""; // clear error text
            if (drinkInputBox.Text == "" | friesInputBox.Text == "" | burgerInputBox.Text == "") // if there are any empty values..
            {
                calculateTotalsButton.Visible = false;
            }

        }

            private void drinkInputBox_TextChanged(object sender, EventArgs e)
        {
            try // accept a value 
            {
                drinkAmount = Convert.ToInt16(drinkInputBox.Text);
                calculateTotalsButton.Visible = true;
            }
            catch // display error message, and remove progress option if input is not a number
            {
                clearAll();
                drinkInputBox.Text = "";
                errorLabel.Text = "That is not a proper number!";
                return;
            }

                errorLabel.Text = ""; //clear error text
            if (drinkInputBox.Text == "" || friesInputBox.Text == "" ||  burgerInputBox.Text == "") // if there are any empty values..
            {
                calculateTotalsButton.Visible = false;
            }

        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {
            if (errorAmount == 0)
            {
                try // accept a value make calculations
                {
                    subTotal = drinkAmount * DRINK_COST + friesAmount * FRIES_COST + burgerAmount * BURGER_COST;
                    taxAmount = subTotal * TAX_RATE;
                    grandTotal = subTotal + taxAmount;
                }
                catch // display error message if input is not a number
                {
                    errorLabel.Text = "Please enter a correct order!";
                    return;
                }

                //clear error text, and display calculated values

                errorLabel.Text = "";
                subTotalLabel.Text = subTotal.ToString("C");
                subTotalDescLabel.Visible = true;
                subTotalLabel.Visible = true;
                Thread.Sleep(500);
                this.Refresh();
                taxLabel.Text = taxAmount.ToString("C");
                taxDescLabel.Visible = true;
                taxLabel.Visible = true;
                Thread.Sleep(500);
                this.Refresh();
                grandTotalLabel.Text = grandTotal.ToString("C");
                grandTotalDescLabel.Visible = true;
                grandTotalLabel.Visible = true;
                Thread.Sleep(500);
                this.Refresh();

                //Enabled next step, lock previous ones

                tenderedInputBox.Visible = true;
                tenderedDescLabel.Visible = true;
                calculateTotalsButton.Visible = false;

                if (drinkAmount == 0 & friesAmount == 0 & burgerAmount == 0) // if the user orders nothing..
                {
                    errorLabel.Text = "You are ordering nothing?! Why are you even here?";
                    tenderedDescLabel.Visible = false;
                    tenderedInputBox.Visible = false;
                    calculateTotalsButton.Visible = false;
                }
            }

        }

        private void tenderedInputBox_TextChanged(object sender, EventArgs e)
        {
            try // accept a value
            {
                amountPaid = Convert.ToDouble(tenderedInputBox.Text); //stores input(payment) into amountPaid variable
            }
            catch // display error message if input is not a number
            {
                errorLabel.Text = "Enter a number!";
                printReceiptButton.Visible = false;
                calculateChangeButton.Visible = false;
                changeLabel.Visible = false;
                changeDescLabel.Visible = false;
                return;
            }

            errorLabel.Text = ""; // clear error text
            calculateChangeButton.Visible = true; //allow the user to calculate change
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            //calculate change

            change = amountPaid - grandTotal;

            if (amountPaid < grandTotal) // if the user is underpaying...
            {
                calculateChangeButton.Visible = false; //.. disable the button
                changeLabel.Text = "$0.00"; //.. set change text to $0
                errorLabel.Text = "Insufficent payment!"; //.. display error
            }
            else // if the user is not underpaying..
            {
                changeLabel.Text = change.ToString("C"); //.. display change
                printReceiptButton.Visible = true; //.. allow the user to print receipt
                errorLabel.Text = ""; //.. clear any possible error text
                changeDescLabel.Visible = true;
                changeLabel.Visible = true;
                calculateChangeButton.Visible = false;
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //setup for the code

            orderNumber = randNum.Next(1, 100000);
            dateD = randNum.Next(01, 30);
            dateM = randNum.Next(1, 12);
            dateY = randNum.Next(2012, 2017);
            Graphics receipt = this.CreateGraphics();

            //make user unable to reprint same receipt, and clears the screen

            clearAll();
            burgerInputBox.Visible = false;
            calculateTotalsButton.Visible = false;
            burgerDescLabel.Visible = false;
            friesInputBox.Visible = false;
            friesDescLabel.Visible = false;
            drinkInputBox.Visible = false;
            drinkDescLabel.Visible = false;
            clearOrderButton.Visible = true;

            //start to print receipt

            receipt.DrawRectangle(receiptPen, 240, 30, 200, 410);
            receipt.DrawString("BankCore", receiptFont, receiptBrush, 245, 35);
            registerSound.PlaySync();
            receipt.DrawString("Order #" + orderNumber, receiptFont, receiptBrush, 245, 55);
            registerSound.PlaySync();
            receipt.DrawString("Date: " + dateD.ToString("00") + "/" + dateM.ToString("00") + "/" + dateY, receiptFont, receiptBrush, 245, 75);
            registerSound.PlaySync();
            receipt.DrawString("", receiptFont, receiptBrush, 245, 95);
            registerSound.PlaySync();
            receipt.DrawString("Burger(s)  x" + burgerAmount + " @ " + BURGER_COST, receiptFont, receiptBrush, 245, 115);
            registerSound.PlaySync();
            receipt.DrawString("Fries      x" + friesAmount + " @ " + FRIES_COST, receiptFont, receiptBrush, 245, 135);
            registerSound.PlaySync();
            receipt.DrawString("Drink(s)   x" + drinkAmount + " @ " + DRINK_COST, receiptFont, receiptBrush, 245, 155);
            registerSound.PlaySync();
            receipt.DrawString("", receiptFont, receiptBrush, 245, 175);
            registerSound.PlaySync();
            receipt.DrawString("SubTotal      " + subTotal.ToString("C"), receiptFont, receiptBrush, 245, 195);
            registerSound.PlaySync();
            receipt.DrawString("Tax            " + taxAmount.ToString("C"), receiptFont, receiptBrush, 245, 215);
            registerSound.PlaySync();
            receipt.DrawString("Total         " + grandTotal.ToString("C"), receiptFont, receiptBrush, 245, 235);
            registerSound.PlaySync();
            receipt.DrawString("", receiptFont, receiptBrush, 245, 255);
            registerSound.PlaySync();
            receipt.DrawString("Tendered      " + amountPaid.ToString("C"), receiptFont, receiptBrush, 245, 275);
            registerSound.PlaySync();
            receipt.DrawString("Change        " + change.ToString("C"), receiptFont, receiptBrush, 245, 295);
            registerSound.PlaySync();
            receipt.DrawString("", receiptFont, receiptBrush, 245, 315);
            registerSound.PlaySync();
            receipt.DrawString("Have a nice day!", receiptFont, receiptBrush, 245, 335);
            registerSound.PlaySync();
        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            //reset all values
            Graphics receipt = this.CreateGraphics();
            receipt.Clear(Color.White);
            drinkInputBox.Text = "0";
            tenderedInputBox.Text = "";
            friesInputBox.Text = "0";
            burgerInputBox.Text = "0";
            taxLabel.Text = "$0.00";
            changeLabel.Text = "$0.00";
            subTotalLabel.Text = "$0.00";
            grandTotalLabel.Text = "$0.00";
            clearAll();
            burgerInputBox.Visible = true;
            burgerDescLabel.Visible = true;
            friesInputBox.Visible = true;
            friesDescLabel.Visible = true;
            drinkInputBox.Visible = true;
            drinkDescLabel.Visible = true;
        }


    }
}
