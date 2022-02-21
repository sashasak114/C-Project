
/* Student Name: Shyamini Sakhrelia 

 * Student ID: 21235713

 * Date:20/10/2021 

 * Assignment: 2 

 * Assignment: Create a well-designed application for CourseNet Ltd (CNL)    

 * message in a message box 

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

namespace CourseNetApp
{
    public partial class Form1 : Form
    {
        int totalparticipant;
        string workshopName, location;
        int trainingDays;
        decimal registrationFees, accomodationFee;
        //assigning workshop value
        const String WORKSHOPNAME1 = "C# Fundamentals", WORKSHOPNAME2 = "C# Basics For Beginners", WORKSHOPNAME3 = "C# Intermediate",
        WORKSHOPNAME4 = "C# Advanced Topic", WORKSHOPNAME5 = "ASP.NET with C# Part A", WORKSHOPNAME6 = "ASP.NET with C# Part B";
        const int TRAININGDAYS1 = 2, TRAININGDAYS2 = 4, TRAININGDAYS3 = 4, TRAININGDAYS4 = 3, TRAININGDAYS5 = 5, TRAININGDAYS6 = 5;
        const decimal REGISTRATIONFEES1 = 900m, REGISTRATIONFEES2 = 1500m, REGISTRATIONFEES3 = 1800m, REGISTRATIONFEES4 = 2300m,REGISTRATIONFEES5 = 1250m,REGISTRATIONFEES6 = 1250m;
        
        //assigning Location Value
        const String LOACATION1 = "Dublin", LOACATION2 = "Belmullet", LOACATION3 = "Paris", LOACATION4 = "Berlin", LOACATION5 = "Vienna", LOACATION6= "Lisbon", LOACATION7 = "Madrid", LOACATION8 = "Rome", LOACATION9 = "Amsterdam";
        const decimal ACCOMODATIONFEE1 = 99.99m, ACCOMODATIONFEE2 = 219.99m, ACCOMODATIONFEE3 = 149.99m, ACCOMODATIONFEE4 = 179.99m, ACCOMODATIONFEE5 = 149.99m, ACCOMODATIONFEE6 = 89.99m, ACCOMODATIONFEE7 = 229.99m, ACCOMODATIONFEE8 = 124.99m, ACCOMODATIONFEE9 = 199.99m;
        
        //Assigning Value For Additional Facility
        const decimal MasterSuitePrice = 99.99m,JuniorSuitePrice= 59.99m;
        string roomUpgrade1 = "Master Suite", roomUpgrade2 = "Junior Suite",NoUpgrade = "No Room Upgraded";
        const decimal PRINTCERTIFICATE = 39.99m;
        
        //Variable Declaration For Display 
        decimal  individualCost, certificateCost,addRoomUpgrade;
        decimal registrationCost, lodgingCost, addRoomUpgradeCost, participantDiscount;
        bool discountApplied=false;

        //Variable Declaration For Summary
        int totalEnrol = 0,numGroupDiscount;
        decimal totalCost,TotalRegistrationFee,TotalLodgingFee,TotalCertificateFee,TotalRoomUpgrade,addCertificateCost = 0;
        decimal averageRevenue;

        
        public Form1()
        {
            InitializeComponent();
        }
      //Course Net
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Fill Users Details";
            //Display Booking Form
            panelSummary.Visible = false;
            panelDisplay.Visible = false;
            labelPriceJunior.Text = JuniorSuitePrice.ToString();
            labelPriceMaster.Text = MasterSuitePrice.ToString();
            buttonBookings.Enabled = false;
            btnDisplay.BackColor = Color.RoyalBlue;
            btnDisplay.Enabled = true;
            btnSummary.Enabled = false;
            labelDiscountinfo.Visible = true;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear The Value Of User Input
            textboxparticipant.Text = "";
            listBoxWorkshop.ClearSelected();
            listBoxLocation.ClearSelected();
            radiobtnJuniorSuite.Checked = false;
            radiobtnMasterSuite.Checked = false;
            radiobtnNot.Checked = false;
            checkPrintCertificate.Checked = false;


        }
   
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.Text = "Display User Details";
            // Display User Workshop And Receipt Details
            buttonBookings.Enabled = true;
            btnDisplay.Enabled = false;
            btnSummary.Enabled = false;
            btnDisplay.BackColor = Color.DarkSlateBlue;
            buttonBookings.BackColor = Color.RoyalBlue;


            const decimal DISCOUNT = 0.925m;
            decimal discountOffer;
            int WorkshopIndex = 0, LocationIndex = 0;
          
            try
       
            {
                
                totalparticipant = int.Parse(textboxparticipant.Text);
                labeltotalparticipants.Text = totalparticipant.ToString();

                if (listBoxWorkshop.SelectedIndex != -1)
                {

                    if (listBoxLocation.SelectedIndex != -1)
                    {
                        WorkshopIndex = listBoxWorkshop.SelectedIndex;
                        LocationIndex = listBoxLocation.SelectedIndex;
                        
                        // Get the selected workshop
                        switch (WorkshopIndex)
                        {
                            case 0:
                                workshopName = WORKSHOPNAME1;
                                trainingDays = TRAININGDAYS1;
                                registrationFees = REGISTRATIONFEES1;
                                break;
                            case 1:
                                workshopName = WORKSHOPNAME2;
                                trainingDays = TRAININGDAYS2;
                                registrationFees = REGISTRATIONFEES2;
                                break;
                            case 2:
                                workshopName = WORKSHOPNAME3;
                                trainingDays = TRAININGDAYS3;
                                registrationFees = REGISTRATIONFEES3;
                                break;
                            case 3:
                                workshopName = WORKSHOPNAME4;
                                trainingDays = TRAININGDAYS4;
                                registrationFees = REGISTRATIONFEES4;
                                break;
                            case 4:
                                workshopName = WORKSHOPNAME5;
                                trainingDays = TRAININGDAYS5;
                                registrationFees = REGISTRATIONFEES5;
                                break;
                            case 5:
                                workshopName = WORKSHOPNAME6;
                                trainingDays = TRAININGDAYS6;
                                registrationFees = REGISTRATIONFEES6;
                                break;
                        }
                        // Get the selected Location.

                        switch (LocationIndex)
                        {
                            case 0:
                                location = LOACATION1;
                                accomodationFee = ACCOMODATIONFEE1;
                                break;
                            case 1:
                                location = LOACATION2;
                                accomodationFee = ACCOMODATIONFEE2;

                                break;
                            case 2:
                                location = LOACATION3;
                                accomodationFee = ACCOMODATIONFEE3;
                                break;

                            case 3:
                                location = LOACATION4;
                                accomodationFee = ACCOMODATIONFEE4;
                                break;
                            case 4:
                                location = LOACATION5;
                                accomodationFee = ACCOMODATIONFEE5;

                                break;
                            case 5:
                                location = LOACATION6;
                                accomodationFee = ACCOMODATIONFEE6;
                                break;
                            case 6:
                                location = LOACATION7;
                                accomodationFee = ACCOMODATIONFEE7;
                                break;
                            case 7:
                                location = LOACATION8;
                                accomodationFee = ACCOMODATIONFEE8;
                                break;
                            case 8:
                                location = LOACATION9;
                                accomodationFee = ACCOMODATIONFEE9;
                                break;



                        }
                        // Workshop Calculation And Displaying Data

                        labelworshopname.Text = workshopName;
                        labelTrainingDays.Text = trainingDays.ToString();
                        labelDisplayLocation.Text = location;
                        registrationCost = registrationFees * totalparticipant;
                        labelRegistrationCost.Text = registrationCost.ToString("c");

                        lodgingCost = accomodationFee * totalparticipant*trainingDays;
                        labelLodgingCost.Text = lodgingCost.ToString("c");

               
                       

                        //Room Upgrade 

                        if (radiobtnMasterSuite.Checked)
                        {
                            addRoomUpgradeCost =totalparticipant* MasterSuitePrice*trainingDays;
                            labelRoomUpgrade.Text = roomUpgrade1;
                            labelRoomPrice.Text = addRoomUpgradeCost.ToString("c");
                            addRoomUpgrade = addRoomUpgradeCost;

                        }
                        else if (radiobtnJuniorSuite.Checked)
                        {
                            addRoomUpgradeCost=totalparticipant* JuniorSuitePrice*trainingDays;
                            labelRoomUpgrade.Text = roomUpgrade2;
                            labelRoomPrice.Text = addRoomUpgradeCost.ToString("c");
                            addRoomUpgrade = addRoomUpgradeCost;
                        }
                        else 
                        {
                            labelRoomUpgrade.Text = NoUpgrade;
                            labelRoomPrice.Text = null;
                            addRoomUpgrade = 0;
                        }
                        //print Certificate
                        if (checkPrintCertificate.Checked)
                        {
                            certificateCost = totalparticipant * PRINTCERTIFICATE;
                            labelCertificateCost.Text = certificateCost.ToString("c");
                            addCertificateCost = certificateCost;
                        }
                        else
                        {
                            labelCertificateCost.Text = "0";
                            addCertificateCost = 0;
                        }

                        //Calcualating Discount Provided 
                        discountApplied = (totalparticipant >= 4 && (radiobtnMasterSuite.Checked || radiobtnJuniorSuite.Checked));
                        if(discountApplied == true)
                        {
                         
                                numGroupDiscount++;
                                totalCost = (registrationCost + lodgingCost + addRoomUpgradeCost);
                                participantDiscount = (totalCost * DISCOUNT);
                                labelTotalCost.Text = participantDiscount.ToString("c");
                                discountOffer = (totalCost - participantDiscount);
                                labelGroupDiscount.Text = "- " + discountOffer.ToString("c");
                                individualCost = participantDiscount / totalparticipant;
                                labelIndividualCost.Text = individualCost.ToString("c");

                        }
                       //Calculation For People Who Did Not Availed Discount
                        else
                        {
                            totalCost = (registrationCost + lodgingCost +certificateCost+addRoomUpgradeCost);
                            individualCost = totalCost / totalparticipant;
                            labelIndividualCost.Text = individualCost.ToString("c");
                            labelTotalCost.Text = totalCost.ToString("c");
                            labelGroupDiscount.Text = "0";
                        }
   

                        //Display Insert User Booking Form Details

                        panelDisplay.Visible = true;
                        panelSummary.Visible = false;
                        pictureBoxBook.Visible = false;
                        panelLocation.Visible = false;
                        panelWorkshop.Visible = false;
                        groupBoxRoomUpgrade.Visible = false;
                        btnClear.Visible = false;
                        btnExit.Visible = false;
                        textboxparticipant.Visible = false;
                        labelParticipants.Visible = false;
                        checkPrintCertificate.Visible = false;
                        labelDiscountinfo.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Please Select A Location", "Location Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        buttonBookings_Click(sender,e);

                    }

                }
                else
                {
                    MessageBox.Show("Please Select A Worshop", "Workshop Needed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    buttonBookings_Click(sender, e);
                }
            }
            catch 
            {
                //Prompt If User Input Wrong Toal Participant Value And Clear Textbbox//
                DialogResult result1 = MessageBox.Show("Please Enter Numerical Value For No Of Participants", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(result1 == DialogResult.OK)
                {
                    buttonBookings_Click(sender, e);
                }
                textboxparticipant.Clear();
                textboxparticipant.Focus();
            }





        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Do You Want To Confirm Your Booking?" + "\n\n" + "Workshop Name\t" + workshopName.ToString() + "\n\n" + "Training Days\t" + trainingDays.ToString() + "\n\n" + "Location Name\t" + location + "\n\n" + "Total Receipt\t" + labelTotalCost.Text, "Booking Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // Storing Variable Value And Calculating Values For Summary
            if (result2 == DialogResult.Yes)
            {
                totalEnrol += totalparticipant;
                TotalRegistrationFee += registrationCost;
                TotalLodgingFee += lodgingCost;
                TotalRoomUpgrade += addRoomUpgrade;
                TotalCertificateFee += addCertificateCost;
                averageRevenue = (TotalRegistrationFee + TotalLodgingFee + TotalRoomUpgrade + TotalCertificateFee / totalEnrol);
            }
            else if (result2 == DialogResult.No)
            {
                //Redirect User Back To First Booking Form Page 
                buttonBookings_Click(sender, e);
            }

            buttonBookings.Enabled = false;
            buttonBookings.BackColor = Color.DarkSlateBlue;
            btnSummary.Enabled = true;
            btnSummary.BackColor = Color.RoyalBlue;
        }

        private void btnDisplayBack_Click(object sender, EventArgs e)
        {
            //Taking User Back To Main Page From Display
            buttonBookings_Click(sender,e);
        }


        private void buttonBookings_Click(object sender, EventArgs e)
        {
            this.Text = "Fill User Details";
            buttonBookings.Enabled = false;
            btnDisplay.Enabled = true;
            btnSummary.Enabled = false;
            btnDisplay.BackColor = Color.RoyalBlue;
            btnSummary.BackColor = Color.DarkSlateBlue;
            buttonBookings.BackColor = Color.DarkSlateBlue;

            panelSummary.Visible = false;
            panelDisplay.Visible = false;
            pictureBoxBook.Visible = true;
            panelLocation.Visible = true;
            panelWorkshop.Visible = true;
            groupBoxRoomUpgrade.Visible = true;
            btnClear.Visible = true;
            btnExit.Visible = true;
            textboxparticipant.Visible = true;
            labelParticipants.Visible = true;
            checkPrintCertificate.Visible = true;
            labelDiscountinfo.Visible = true;
            btnClear_Click(sender, e);
           
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            this.Text = "Transaction Summary";
            //SummaryForm
            buttonBookings.Enabled = true;
            btnDisplay.Enabled = false;
            btnSummary.Enabled = false;
            btnSummary.BackColor = Color.DarkSlateBlue;
            buttonBookings.BackColor = Color.RoyalBlue;

            //Displaying Total Summary Values //

            labelTotalBooking.Text = totalEnrol.ToString();
            labelTotRegistrationFee.Text = TotalRegistrationFee.ToString("c");
            labelTotLodgingFee.Text = TotalLodgingFee.ToString("c");
            labelTotCertiCost.Text = TotalCertificateFee.ToString("c");
            labelTotRoomUpgrade.Text = TotalRoomUpgrade.ToString("c");
            labelDiscount.Text = numGroupDiscount.ToString("");
            labelAvgRevenue.Text = averageRevenue.ToString("c");

            //visiblity Hide And Show For Summary
            panelSummary.Visible = true;
            panelDisplay.Visible = false;
            pictureBoxBook.Visible = false;
            panelLocation.Visible = false;
            panelWorkshop.Visible = false;
            checkPrintCertificate.Visible = false;
            groupBoxRoomUpgrade.Visible = false;
            btnClear.Visible = false;
            btnExit.Visible = false;
            textboxparticipant.Visible = false;
            labelParticipants.Visible = false;

        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }
      
     }
 }
