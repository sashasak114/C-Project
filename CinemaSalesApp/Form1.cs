/*
 * Student Name: Shyamini Sakhrelia
 * Student ID: 21235712
 * Date:27/09/2021
 * Assignment: 1
 * Assignment: Create a well-designed application that allows “Mega Cinema” staff to process its front of house ticket 
sales.  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSalesApp
{
    public partial class Form1 : Form
    {
        //global variable declaration //
        
        string fname;
        decimal recp,nrecp,trecp, avgtransvalue;
        //ticket price//
        const double padult = 7.99;
        const double pchild = 2.99;
        const double pstud = 4.99;
        int adult, child, stud;
        int totalsold, count;
        int newuser= 0, val;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //wellcome screen
            this.Text = "Welcome to Mega Cinema";
            PictureTop.Visible = true;
            Btn_Enter.Visible = true;
            LblName.Visible = false;
            Txtname.Visible = false;
            GroupTickets.Visible = false;
            PanelButton.Visible = false;
            GroupSummary.Visible = false;
            PictureBottom.Visible = false;
            PanelButton.Visible = false;


        }
        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            this.Text = "Purchase Ticket";
           
           //incrementing value for total cashier//
            count += 1;
            //display input ticket data on enter button click//
            Txtname.Focus();
            Btn_Summary.Enabled = false;
            Btn_Calc.Enabled = true;
            Btn_Enter.Visible = false;
            PictureTop.Visible = false;
            LblName.Visible = false;
            Txtname.Visible = false;
            GroupSummary.Visible = false;
            GroupTickets.Visible = true;
            PictureBottom.Visible = true;
            PanelButton.Visible = true;
            LblName.Visible = true;
            Txtname.Visible = true;
            Txtname.Focus();

        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            //storing data of new user for summary data//
            newuser = totalsold;
            nrecp = recp;
            //restating the form for new entries and taking back to welcome screen//
            this.Text = "Welcome to Mega Cinema";
            GroupTickets.Enabled = true;
            LblName.Enabled = true;
            Txtname.Enabled = true;
            PictureTop.Visible = true;
            Btn_Enter.Visible = true;
            LblName.Visible = false;
            Txtname.Visible = false;
            GroupTickets.Visible = false;
            PanelButton.Visible = false;
            GroupSummary.Visible = false;
            PictureBottom.Visible = false;
            PanelButton.Visible = false;
            //clear input textbox for new customer entries//
            Txtname.Text = "";
            Txtadult.Text = "0";
            Txtchild.Text = "0";
            Txtstudent.Text = "0";

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            //exit from the screen//
            this.Close();
        }

        private void Btn_Summary_Click(object sender, EventArgs e)
        {
            

                        this.Text = "All Transaction Summary";
                        Btn_Calc.Enabled = false;
                        // total number of people//
                        stud = int.Parse(Txtstudent.Text);
                        totalsold = adult + child + stud;
                        val = newuser + totalsold;
                        Lbltsold.Text = val.ToString();

                        //calculating total receipt adding new and old user //
                        recp = ((decimal)padult * adult + (decimal)pchild * child + (decimal)pstud * stud) ;
                        trecp = nrecp + recp;
                        //total average transacting value//
                        avgtransvalue = ((decimal)trecp / val);
                        Lbltreceipt.Text = trecp.ToString("C2");
                        Lblavgvalue.Text = avgtransvalue.ToString("C2");
                        Lblctotal.Text = count.ToString();

                        //display summary data//
                        PictureTop.Visible = false;
                        Lblcashname.Visible = false;
                        Lblcname.Visible = false;
                        PictureBottom.Visible = true;
                        GroupTickets.Visible = false;
                        LblName.Visible = false;
                        Txtname.Visible = false;
                        GroupSummary.Visible = true;
                        PanelButton.Visible = true;
                        LblSold.Visible = true;
                        Lbltsold.Visible = true;
                        Lblcashiers.Visible = true;
                        Lblctotal.Visible = true;
                        LblReceipts.Visible = true;
                        Lbltreceipt.Visible = true;
                        LblTransValue.Visible = true;
                        Lblavgvalue.Visible = true;
                  
            }
        

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            //display username by storing value of name textbox into label //
            this.Text = "Transaction Summary";
            Btn_Summary.Enabled = true;
            fname = Txtname.Text;
            Lblcname.Text = fname;
           

            try
            {
                adult = int.Parse(Txtadult.Text);
                totalsold = adult;
              
                try
                {
                    child = int.Parse(Txtchild.Text);
                    totalsold = adult+ child;
                    try
                    {
                        //total ticket sold of current cashier//
                        stud = int.Parse(Txtstudent.Text);
                        totalsold = adult + child + stud;
                        Lbltsold.Text = totalsold.ToString();
                        this.Text = "Transaction Summary";
                        //total receipt//
                        recp = ((decimal)padult * adult + (decimal)pchild * child + (decimal)pstud * stud);
                        Lbltreceipt.Text = recp.ToString("C2");
                        //display total calculation of current user//
                        GroupTickets.Enabled = false;
                        LblName.Enabled = false;
                        Txtname.Enabled = false;
                        GroupSummary.Visible = true;
                        PictureBottom.Visible = true;
                        Lblcashname.Visible = true;
                        Lblcname.Visible = true;
                        PictureTop.Visible = false;
                        Btn_Enter.Visible = false;
                        PanelButton.Visible = true;
                        Lblcashiers.Visible = false;
                        Lblctotal.Visible = false;
                        LblTransValue.Visible = false;
                        Lblavgvalue.Visible = false;

                    }


                    catch
                    { 
                        //clearing textbox value when wrong data input and prompting//
                        
                        MessageBox.Show("Please enter numerical data for number of Student tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);  
                        Txtstudent.Focus();
                        Txtstudent.SelectAll();
                    }
                }
                catch
                {
                    //clearing textbox value when wrong data input and prompting//
                    
                    MessageBox.Show("Please enter numerical data for number of children  tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Txtchild.Focus();
                    Txtchild.SelectAll();
                }
            }

            catch
            {
                //clearing textbox value when wrong data input and prompting//
                MessageBox.Show("Please enter numerical data for number of adult tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Txtadult.Focus();
                Txtadult.SelectAll();

            }
         
        }
    }
}
