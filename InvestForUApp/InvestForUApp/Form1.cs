using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace InvestForUApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //variable declaration for investment plan selection
        int Term;
        decimal Intrestrate;
        decimal SelectedBal;
        decimal investmentamt;
        string Username, Email, PhoneNo;
        const int InvestmentPlan = 100000;
        const decimal INTRESTRATE1 = 0.005000m, INTRESTRATE2 = 0.006250m, INTRESTRATE3 = 0.007125m, INTRESTRATE4 = 0.011250m;
        const decimal LARGEINTRATE1 = 0.006000m, LARGEINTRATE2 = 0.007250m, LARGEINTRATE3 = 0.008125m, LARGEINTRATE4 = 0.012500m;
        const int TERM1 = 1, TERM2 = 3, TERM3 = 5, TERM4 = 10;
        decimal balance1, balance2, balance3, balance4, balance5, balance6, balance7, balance8;
        //variable for file
        public const string File_Name ="ClientInformation.txt";
        const string PASSWORD = "ShowMeTheMoney#";
        //width and height display formating
        const int INCREMENT = 4, FORMSTARTWIDTH = 360, FORMSTARTHEIGHT = 580, FORMEXPANDHEIGHT = 670, FORMEXPANDWIDTH = 750;

        Boolean FormWidthExpanded = false, FormHeightExpanded = false;
        //variable for storing index positing for reading in file
        int trials = 4;
        int count = 1;
        const decimal bonus = 25000;
        public const string SEPRATER = "-";
        public const int TNX_NO_INDEX = 1, DATE_INDEX=2,EMAIL_INDEX = 3, NAME_INDEX = 4, PHONE_INDEX = 5, AMOUNT_INDEX = 6,
            INTREST_INDEX = 7, TERM_INDEX=8, RECORDS_PER_LINE = 8;

        //Method to display investmeent plan greater than or less than 100,000 accordingly
        private void ShowInvestmentPlan(decimal InvestmentAmount)
        {
            if (InvestmentAmount <= InvestmentPlan)
            {
                PanelInvest1.Visible = true;
                PanelInvest2.Visible = false;
            }
            else
            {
                PanelInvest2.Visible = true;
                PanelInvest1.Visible = false;
            }
        }
        //Method to calculate intrest balance of user as per Investment amount
        private decimal CalculateIntrest(decimal Investment, decimal AIntrestrate, int ATerm)
        {
            return (Investment) * (decimal)Math.Pow(1 + ((double)(AIntrestrate) / 12), 12 * ATerm);
        }
        //Method for random Transaction Number
        private string UniqueRandom()
        {
            string TrxNo;
            Random TRXnumber = new Random();
           
            bool Unique = false;
            do
            {
                //calling Unique method to check if the random number genrated is unique or not
               Unique = Checkunique(TRXnumber.ToString(),File_Name);
                TrxNo=TRXnumber.Next(0, 99999999).ToString();
            } while (!Unique);
            return TrxNo;
        }
        //Method for unique transaction number checking into file
        private  bool Checkunique(string SearchString, String FileName)
        {
            StreamReader InputFile = File.OpenText(FileName);
            while (!InputFile.EndOfStream)
            {
                if (SearchString.Equals(InputFile.ReadLine()))
                {
                    InputFile.Close();
                    return false;
                }
                for (int i = 0; i < 8 - 1; i++)
                {
                    InputFile.ReadLine();
                }
            }
                InputFile.Close();
                return true;
        }
         private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to search user transaction record as per date,transaction number and email
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //variable to input user value and to check if record found or not
            bool foundrecord = false;
            String ErrorMessage;
            string SearchValue;
            string Name, PhoneNo, Amount, IntAccrued, Term;
            SearchValue = txtSearch.Text;
            string TransactioNo, EmailSearch, DateSearch;
            DateTime dt;
            StreamReader dataStream;
            //clearing listbox displaying user record 
            ListBoxSearchInfo.Items.Clear();

            try
            {
                dataStream = File.OpenText(File_Name);
                if (RdbTnxno.Checked || RdbEmail.Checked || RdbDate.Checked)
                {
                        while (!dataStream.EndOfStream)
                        { //Searching Record for transaction Number Date and Email
                            TransactioNo = dataStream.ReadLine();
                            DateSearch = dataStream.ReadLine();
                            EmailSearch = dataStream.ReadLine();
                        //radio button transaction number
                            if (RdbTnxno.Checked)
                            {
                                foundrecord = TransactioNo.Equals(SearchValue);
                            }
                            //radio button email
                            else if (RdbEmail.Checked)
                            {
                                foundrecord = EmailSearch.StartsWith(SearchValue);

                            }
                            //radio button date
                            else if (RdbDate.Checked)
                            {  //checking if date is valid or not
                                bool isValidDate = DateTime.TryParse(SearchValue, out dt);
                                if (isValidDate)
                                {
                                    foundrecord = DateSearch.StartsWith(SearchValue);
                                }
                            }
                            if (foundrecord)
                            {
                            //if found record adding user details in list box 
                                panelsearchDetails.Visible = true;
                                ListBoxSearchInfo.Visible = true;
                            
                                ListBoxSearchInfo.Items.Add(String.Format("Transaction Number: {0}", TransactioNo));
                                ListBoxSearchInfo.Items.Add(String.Format("Date:\t{0}", DateSearch));
                                ListBoxSearchInfo.Items.Add(String.Format("Email:\t{0}", EmailSearch));
                                Name = dataStream.ReadLine();
                                PhoneNo = dataStream.ReadLine();
                                Amount = dataStream.ReadLine();
                                IntAccrued = dataStream.ReadLine();
                                Term = dataStream.ReadLine();
                                ListBoxSearchInfo.Items.Add(String.Format("Name:\t{0:C}", Name));
                                ListBoxSearchInfo.Items.Add(String.Format("Phone No:\t{0:C}", PhoneNo));
                                ListBoxSearchInfo.Items.Add(String.Format("Amount:\t{0:C}", Amount));
                                ListBoxSearchInfo.Items.Add(String.Format("Intrest Accrued:\t{0:C}", IntAccrued));
                                ListBoxSearchInfo.Items.Add(String.Format("Term:\t{0:C}", Term));

                                ListBoxSearchInfo.Enabled = true;

                            }
                            else
                            { // reading data to the end of file 
                                for (int i = 4; i <= RECORDS_PER_LINE; i++)
                                {
                                    dataStream.ReadLine();
                                }
                            if (new FileInfo(File_Name).Length == 0)
                            {

                                MessageBox.Show("No records found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }

                        }

                        dataStream.Close();
                    }
             

                else
                {

                    MessageBox.Show("Please Select Any of The One Option To Search");
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = string.Format("Error reading record from file" + ex.Message);
            }
       
}


        private void BtnSummary_Click(object sender, EventArgs e)
        {
            //changing color of button
            BtnSummary.BackColor = Color.IndianRed;
            BtnProceed.BackColor = Color.IndianRed;
            BtnClear.BackColor = Color.DarkCyan;
            btnExit.Enabled = true;
            btnExit.BackColor = Color.DarkCyan;
            BtnSummary.Enabled = false;
            BtnClear.Enabled = true;
            BtnProceed.Enabled = false;

            String ErrorMessage = "";
            String TXno,Line;
            StreamReader dataStream;
            decimal TotalPrinciple = 0, TotalIntrest = 0;
            decimal AvgAmountInvested;
            int AvgDuration,TotalTerm = 0; ;
            int recordcount;
            PanelInvestmentInfo.Visible = true;
            PanelUserInfo.Visible = false;
            PanelInvest1.Visible = false;
            PanelInvest2.Visible = false;
            try
            {
                dataStream = File.OpenText(File_Name);
                while (!dataStream.EndOfStream)
                {
                    TXno = dataStream.ReadLine();
                    listboxSummary.Items.Add(TXno);
                    //calculating summary details
                    for(int LinePos=2; LinePos<= RECORDS_PER_LINE;LinePos++)
                    {
                        Line = dataStream.ReadLine();
                        if(LinePos== AMOUNT_INDEX)
                        {
                            TotalPrinciple += decimal.Parse(Line);
                        }
                       else if (LinePos == INTREST_INDEX)
                        {
                            TotalIntrest += decimal.Parse(Line);
                        }
                        else if (LinePos == TERM_INDEX)
                        {
                            TotalTerm += int.Parse(Line);
                        }
                      
                    }
                    recordcount = listboxSummary.Items.Count;
                    AvgAmountInvested = TotalPrinciple / recordcount;
                    AvgDuration = TotalTerm / recordcount;
                    //displaying summary details
                    LblTAmount.Text = TotalPrinciple.ToString("C");
                    LblTInterest.Text = TotalIntrest.ToString("C");
                    LblAvgInvest.Text = AvgAmountInvested.ToString("C");
                    LblAvgDuration.Text = AvgDuration.ToString();
                }
                dataStream.Close();
                
            }
            catch(Exception ex)
            {
                ErrorMessage = string.Format("Error reading record from file" + ex.Message);
            }
        }


        private void Btnback_Click(object sender, EventArgs e)
        {
            Btnback.BackColor = Color.DarkCyan;
            BtnProceed.BackColor = Color.DarkCyan;
            BtnClear.BackColor = Color.IndianRed;

            BtnProceed.Enabled = true;
            ShowInvestmentPlan(investmentamt);
            PanelUserInfo.Visible = false;
         
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //resizing form height and width for back to normal for display page
            BtnClear.BackColor = Color.IndianRed;
            if (!FormWidthExpanded)
            {
                for (int i = FORMEXPANDWIDTH; i > FORMSTARTWIDTH; i -= INCREMENT)
                {
                    this.Size = new Size(i, FORMSTARTHEIGHT);
                    this.Update();
                    System.Threading.Thread.Sleep(1);
                }
                FormWidthExpanded = false;
            }
            if (!FormHeightExpanded)
            {

                for (int i = FORMEXPANDHEIGHT; i > FORMSTARTHEIGHT; i -= INCREMENT)
                {
                    this.Size = new Size(FORMEXPANDWIDTH, i);
                    this.Update();
                    System.Threading.Thread.Sleep(1);
                }
                FormHeightExpanded = false;
            }
            //clearing user input 
            TxtInvestAmount.Text = "";
            listBoxInvest1.ClearSelected();
            listBoxInvest2.ClearSelected();
            TxtUserName.Text = "";
            TxtUserPhno.Text = "";
            TxtUserEmail.Text = "";
            txtSearch.Text = "";
            //form showing investment amount 
            RdbDate.Checked = false;
            RdbEmail.Checked = false;
            RdbTnxno.Checked = false;
            Logo.Visible = false;
            PanelMenu.Visible = false;
            PanelUserInfo.Visible = false;
            PanelInvest1.Visible = false;
            PanelInvest2.Visible = false;
            PanelDisplay.Visible = true;
            PanelSearch.Visible = false;
            panelsearchDetails.Visible = false;
            PanelInvestmentInfo.Visible=false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size(FORMSTARTWIDTH, FORMSTARTHEIGHT);
            PanelLogin.Visible = true;
            PanelLoginInfo.Visible = true;
            PanelDisplay.Visible = false;
            Logo.Visible = false;
            PanelMenu.Visible = false;
            PanelInvest1.Visible = false;
            PanelInvest2.Visible = false;
            PanelInvestmentInfo.Visible = false;
            PanelUserInfo.Visible = false;
            PanelSearch.Visible = false;
            ListBoxSearchInfo.Visible = false;
            panelsearchDetails.Visible = false;

        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //checking user password
            btnExit.Enabled = false;
            if (TxtPassword.Text == PASSWORD)
            {
                PanelDisplay.Visible = true;
                PanelLogin.Visible = false;
                PanelLoginInfo.Visible = false;
            }
            else
            {
                if (count < 4)
                {
                    trials --;
                    MessageBox.Show("Please Enter the correct Password!\nYou have only "+trials+" turns left ","Wrong Password Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtPassword.Clear();
                    TxtPassword.Focus();
                    count++;
                }
                else
                {
                   MessageBox.Show("Invalid Password! Zero Turn Left", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                   this.Close();
                }
            }
        }
        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            BtnProceed.BackColor = Color.DarkCyan;
            BtnSummary.Enabled = true;
            BtnProceed.Enabled = true;
            //changing form size
            try
            {            
                if (!FormWidthExpanded)
                {
                    for (int i = FORMSTARTWIDTH; i < FORMEXPANDWIDTH; i += INCREMENT)
                    {
                        this.Size = new Size(i, FORMSTARTHEIGHT);
                        this.Update();
                        System.Threading.Thread.Sleep(1);
                    }
                    FormWidthExpanded = true;
                    FormHeightExpanded = false;
                }
                listBoxInvest1.Items.Clear();
                listBoxInvest2.Items.Clear();
               
                ShowInvestmentPlan(decimal.Parse(TxtInvestAmount.Text));
                if (decimal.TryParse(TxtInvestAmount.Text, out investmentamt))
                {
                     
                   //storing value of intrest amount calculated
                    balance1 = CalculateIntrest(investmentamt, INTRESTRATE1, TERM1);
                     balance2 = CalculateIntrest(investmentamt, INTRESTRATE2, TERM2);
                     balance3 = CalculateIntrest(investmentamt, INTRESTRATE3, TERM3);
                     balance4 = CalculateIntrest(investmentamt, INTRESTRATE4, TERM4);
                     balance5 = CalculateIntrest(investmentamt, LARGEINTRATE1, TERM1);
                     balance6 = CalculateIntrest(investmentamt, LARGEINTRATE2, TERM2);
                     balance7 = CalculateIntrest(investmentamt, LARGEINTRATE3, TERM3);
                     balance8 = CalculateIntrest(investmentamt, LARGEINTRATE4, TERM4);
                    //adding listnox item
                    listBoxInvest1.Items.Add(String.Format("{0} Year\t\t{1}\t\t{2:C}",TERM1,INTRESTRATE1,balance1));
                    listBoxInvest1.Items.Add(String.Format("{0} Year\t\t{1}\t\t{2:C}", TERM2,INTRESTRATE2,balance2));
                    listBoxInvest1.Items.Add(String.Format("{0} Year\t\t{1}\t\t{2:C}", TERM3,INTRESTRATE3,balance3));
                    listBoxInvest1.Items.Add(String.Format("{0} Year\t\t{1}\t\t{2:C}", TERM4,INTRESTRATE4,balance4));
                    listBoxInvest2.Items.Add(String.Format("{0} Year\t\t{1}\t\t{2:C}", TERM1,LARGEINTRATE1,balance5));
                    listBoxInvest2.Items.Add(String.Format("{0} Year\t\t{1}\t\t{2:C}", TERM2,LARGEINTRATE2,balance6));
                    listBoxInvest2.Items.Add(String.Format("{0} Year\t\t{1}\t\t{2:C}", TERM3,LARGEINTRATE3,balance7));
                    listBoxInvest2.Items.Add(String.Format("{0} Year\t\t{1}\t\t{2:C}", TERM4,LARGEINTRATE4,balance8));
                    
                }
                PanelSearch.Visible = true;
                PanelLogin.Visible = false;
                PanelDisplay.Visible = false;
                PanelUserInfo.Visible = false;
                PanelInvestmentInfo.Visible = false;
                PanelMenu.Visible = true;
                Logo.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please Enter Proper Numerical Value For Investment Amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtInvestAmount.Clear();
                TxtInvestAmount.Focus(); 
            }

        }
            

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            BtnSubmit.BackColor = Color.DarkCyan;
            BtnClear.BackColor = Color.DarkCyan;
            Btnback.BackColor = Color.DarkCyan;
            BtnClear.Enabled = true;
            BtnProceed.BackColor = Color.IndianRed;
            BtnProceed.Enabled = false;
            Btnback.Enabled = true;
            BtnSubmit.Enabled = true;
            int InvestmentIndex = 0, LargeInvestmentIndex = 0;
            if (listBoxInvest1.SelectedIndex != -1 || listBoxInvest2.SelectedIndex != -1)
                {
                    InvestmentIndex = listBoxInvest1.SelectedIndex;
                    LargeInvestmentIndex = listBoxInvest2.SelectedIndex;

                    // Get the selected Investment Intrest
                    switch (InvestmentIndex)
                    {
                        case 0:
                            Term = TERM1;
                            Intrestrate = INTRESTRATE1;
                            SelectedBal = balance1;
                            break;
                        case 1:
                            Term = TERM2;
                            Intrestrate = INTRESTRATE2;
                           SelectedBal = balance2;
                        break;
                        case 2:
                            Term = TERM3;
                            Intrestrate = INTRESTRATE3;
                            SelectedBal = balance3;
                        break;
                        case 3:
                            Term = TERM4;
                            Intrestrate = INTRESTRATE4;
                            SelectedBal = balance4;
                        break;
                    }


                    switch (LargeInvestmentIndex)
                    {
                        case 0:
                            Term = TERM1;
                            Intrestrate = LARGEINTRATE1;
                            SelectedBal = balance5;
                        break;
                        case 1:
                            Term = TERM2;
                            Intrestrate = LARGEINTRATE2;
                            SelectedBal = balance6;
                        break;
                        case 2:
                            Term = TERM3;
                            Intrestrate = LARGEINTRATE3;
                            SelectedBal = balance7;
                        break;
                        case 3:
                            Term = TERM4;
                            Intrestrate = LARGEINTRATE4;
                            SelectedBal = balance8;
                        break;
                    } 
                //changing form height 
                if (!FormHeightExpanded)
                {
                    ShowInvestmentPlan(int.Parse(TxtInvestAmount.Text));
                    for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
                    {
                        this.Size = new Size(FORMEXPANDWIDTH,i);
                        this.Update();
                        System.Threading.Thread.Sleep(1);
                    }
                    FormHeightExpanded = true;
                    FormWidthExpanded = false;
                }
                LblTransactionNo.Text = UniqueRandom();
                DateTime CurrentTime = DateTime.Now;
                LblCurrentDate.Text = CurrentTime.ToString();
                PanelInvest1.Visible = false;
                PanelInvest2.Visible = false;
                PanelUserInfo.Visible = true;
               
                }
                else
                {
                 DialogResult res= MessageBox.Show("please select Investment term and Intrest Rate","Fill Proper Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    BtnProceed.Enabled = true;
                    BtnProceed.BackColor = Color.DarkCyan;
                    BtnClear.BackColor = Color.IndianRed;
                    BtnClear.Enabled = false;
                }
                
                }

         }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Username = TxtUserName.Text;
            PhoneNo = TxtUserPhno.Text;
            Email = TxtUserEmail.Text;
            decimal IntrestAccrued;
            int txno; 
            string cdate;
            txno = int.Parse(LblTransactionNo.Text);
            cdate = LblCurrentDate.Text;
            IntrestAccrued = SelectedBal-investmentamt;
            // conditioon for checking if text box is empty or not
            if (TxtUserName.Text == "" && TxtUserPhno.Text == "" && TxtUserEmail.Text == "")
            {
                 DialogResult res1= MessageBox.Show("Please Enter All The Information", "No User Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res1 == DialogResult.OK)
                {
                   TxtUserName.Focus();
                }
            }
            //expression indicating it should be only number between 0-9 from begining to end 
            else if (!Regex.IsMatch(TxtUserPhno.Text, @"^[0-9]+$"))
            {
                DialogResult res2 = MessageBox.Show("Please Enter Valid Phone Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res2 == DialogResult.OK)
                {
                    TxtUserPhno.Clear();
                    TxtUserPhno.Focus();
                }
            }
            //email must contain @ and .
            else if (!Email.Contains("@") && !Email.Contains(".")&&TxtUserEmail.MaxLength> 6)

            {
                DialogResult res3 = MessageBox.Show("Please Enter Valid Email Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res3 == DialogResult.OK)
                {
                    TxtUserEmail.Clear();
                    TxtUserEmail.Focus();
                }
            } 
            else
            {
                //storing message box result and display accordingly
                DialogResult info;
                string Message1 = string.Format("\tTransaction Deatails\t\nTransaction Number:\t{0}\nCurrent Date:\t{1}\nTerm:\t{2}\nInterest Rate:\t{3:C}\nFinal Balance:\t{4:C}\nBonus:\t{5:C}\n\t--Personal Details--\t\nCustomer Name:\t{6}\nPhone Number:\t{7}\nEmail Address:\t{8}", txno,cdate, Term, Intrestrate.ToString(), SelectedBal.ToString("C"),bonus.ToString("C"), Username, PhoneNo, Email);
                string Message2 = string.Format("\tTransaction Deatails\t\nTransaction Number:\t{0}\nCurrent Date:\t{1}\nTerm:\t{2}\nInterest Rate:\t{3:C}\nFinal Balance:\t{4:C}\n\t--Personal Details--\t\nCustomer Name:\t{5}\nPhone Number:\t{6}\nEmail Address:\t{7}", txno,cdate, Term, Intrestrate.ToString(), SelectedBal.ToString("C"), Username, PhoneNo, Email);
                if (listBoxInvest2.SelectedIndex == 2 || listBoxInvest2.SelectedIndex == 3)
                {
                    //this message box will display bonus
                    info = MessageBox.Show(Message1, "Final Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                  info = MessageBox.Show(Message2, "Final Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                    if (info== DialogResult.Yes)
                {
                    BtnProceed.Enabled = false;
                    BtnClear.Enabled = true;
                    Btnback.Enabled = false;
                    BtnSubmit.Enabled = false;
                    BtnSummary.BackColor = Color.DarkCyan;
                    BtnProceed.BackColor = Color.IndianRed;
                    Btnback.BackColor = Color.IndianRed;
                    BtnSubmit.BackColor = Color.IndianRed;
                    BtnClear.BackColor = Color.DarkCyan;
                    try
                    {
                       
                        //Declare A Stream Writer Variable
                        //opening file and writing into file and then close file
                        StreamWriter OutputFile = File.AppendText(File_Name);
                        OutputFile.WriteLine(txno);
                        OutputFile.WriteLine(cdate);
                        OutputFile.WriteLine(Email);
                        OutputFile.WriteLine(Username);
                        OutputFile.WriteLine(PhoneNo);
                        OutputFile.WriteLine(investmentamt);
                        OutputFile.WriteLine(IntrestAccrued);
                        OutputFile.WriteLine(Term);
                        OutputFile.Close();
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    //clear data if user press NO 
                    BtnClear_Click(sender,e);
                    
                }
            }
        }
    }

 }
