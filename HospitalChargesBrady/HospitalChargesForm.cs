using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Hospital Charges
* Author      : Kabrina Brady
* Created     : 9/30/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : This program calculates the total cost of a hospital stay by accepting multiple hospital charges from the user.
*               Input:  Charges (days, medication, surgery, etc.), and button/keyboard clicks
*               Output: Total amount of money owed
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace HospitalChargesBrady
{
    public partial class HospitalChargesForm : Form
    {
        public HospitalChargesForm()
        {
            InitializeComponent();
        }

        private double CalcStayCharges(double daysStayed)
        {
            double COST_PER_DAY = 350; //constant that holds cost per day
            return daysStayed * COST_PER_DAY; //mutliplies days stayed by $350
        }
        
        private double CalcMiscCharges (double meds, double surg, double lab, double rehab)
        {
            return meds + surg + lab + rehab; //adds up all user input except for Days
        }

        private double CalcTotalCharges (double stayCharge, double miscCharge)
        {
            return stayCharge + miscCharge; //adds results from calculations done by CalcStayCharges and CalcMiscCharges
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try //ensures user input is a number
            {
                double totalStayCharges; //variable to hold result from running CalcStayCharges
                double totalCharges; //variable to hold total charges
                double totalMiscCharges; //variable to hold misc charges
                double userInputDays = double.Parse(txtDays.Text); //converts user input to double
                double userInputMeds = double.Parse(txtMeds.Text); //converts user input to double
                double userInputSurg = double.Parse(txtSurg.Text); //converts user input to double
                double userInputLabs = double.Parse(txtLabs.Text); //converts user input to double
                double userInputRehab = double.Parse(txtRehab.Text); //converts user input to double

                totalStayCharges = CalcStayCharges(userInputDays); //calls CalcStayCharges and passes userInputDays (# of days user entered) as argument
                totalMiscCharges = CalcMiscCharges(userInputMeds, userInputSurg, userInputLabs, userInputRehab); //calls CalcMiscCharges and passes user input as arguments
                totalCharges = CalcTotalCharges(totalStayCharges, totalMiscCharges); //calls CalcTotalCharges and passes results from previous calculations as arguments
                lblOutput.Text = totalCharges.ToString("C"); //converts double totalStayCharges to string and displays in label
            }
            catch
            {
                MessageBox.Show("Enter a valid number."); //displays error message
            }
        }
    }
}
