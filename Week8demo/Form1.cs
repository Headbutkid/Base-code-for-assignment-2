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

                //membershipfee = fee;

                string Membership = Convert.ToString(Fee);

                MessageBox.Show($"Full name: {Fname}");
                MessageBox.Show($"Email: {Email}");
                MessageBox.Show($"Membership: {Membership} nzd");

                PrintInvoice.WriteInvoice(Fname, Email, Membership);



               
                //Extras fees
                //string extras = Convert.ToString();

                //get extra type 
                bool Twentyfour = radioButtonAccess.Checked;
                bool Personal = radioButtonPT.Checked;
                bool Diet = radioButtonDC.Checked;
                bool ON = radioButtonOFV.Checked;

                double Ex = Extra.extralogic(Fee);
            }
        }
    }
    }
  
