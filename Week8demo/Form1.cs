

namespace Week8demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            {
                // Variable declarations
                string Fname;
                string Email;
                double fee;
                double membershipfee;
                string addy;
                string Moblie;

                // Get Data from text box;
                Fname = FnametextBox.Text;
                Email = EmailtextBox.Text;
                addy = textBoxaddy.Text;
                Moblie = textBoxMoblie.Text;
                // get Type of membership

                bool ThreeMonth = radioButtonmo3.Checked;
                bool TwelveMonth = radioButtonmo12.Checked;
                bool Bas = radioButtonBas.Checked;
                bool Reg = radioButtonReg.Checked;


                // Duration
                double Fee = MemLogic.Logic(ThreeMonth, TwelveMonth, Bas, Reg);



               
                //Extras fees
                //string extras = Convert.ToString();

                //get extra type 
                bool Twentyfour = radioButtonAccess.Checked;
                bool Personal = radioButtonPT.Checked;
                bool Diet = radioButtonDC.Checked;
                bool ON = radioButtonOFV.Checked;
                //get payment option
                bool db = radioButton4.Checked;
                bool weekly = radioButton3.Checked;
                bool monthly = radioButton1.Checked;


                
                
                


                double fee1 = Extraslogic.extralogic(Twentyfour, Personal, Diet, ON, Fee,ThreeMonth, TwelveMonth);
                double totalFee = Fee + fee1;
                string Membership = Convert.ToString(totalFee);

                double fee2 = Paymenttype.payment(db, totalFee);

                double fee3 = Query.output(weekly, monthly, totalFee, TwelveMonth, ThreeMonth);
                double discount = fee2;
                double week = fee3;

                double fee4 = Monthlyouput.monthlyoutput(monthly, ThreeMonth, TwelveMonth, totalFee);
                double month = fee4;

                string wk = Convert.ToString(week);
                string mn = Convert.ToString(month);


                //membershipfee = fee;


                //string XtraFee = Convert.ToString(fee1);

                MessageBox.Show($"Full name: {Fname}");
                MessageBox.Show($"Email: {Email}");
                MessageBox.Show($"Membership: {Membership} nzd");
                MessageBox.Show($"Monthly: {month} nzd");
                MessageBox.Show($"weekly: {week} nzd");
                PrintInvoice.WriteInvoice(Fname, Email, Membership, wk, mn);
            }
        }
    }
    }
  
