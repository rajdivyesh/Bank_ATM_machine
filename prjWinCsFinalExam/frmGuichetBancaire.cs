using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsFinalExam
{
    public partial class frmGuichetBancaire : Form
    {
        public frmGuichetBancaire()
        {
            InitializeComponent();
        }
        struct AccountInfo
        {
            public string c_num;
            public string name;
            public string c_pin;
            public Single balance;
        }

        AccountInfo[] acc = new AccountInfo[50];
        Int16 nbaccount = 0;
        Int16 active_acc = -1;

        private void frmGuichetBancaire_Load(object sender, EventArgs e)
        {
            this.Height = 210;
            rbtnConsult.Checked = true;
            txtWithdraw.Visible = false;
            txtDeposit.Visible = false;
            lblDepDollar.Visible = false;
            lblWitDollar.Visible = false;

            StreamReader myfile = new StreamReader("Bank.txt");
            Int16 i = 0;
            while (myfile.EndOfStream == false)
            {
                acc[i].c_num = myfile.ReadLine();
                acc[i].name = myfile.ReadLine();
                acc[i].c_pin = myfile.ReadLine();
                acc[i].balance = Convert.ToSingle(myfile.ReadLine());
                i++;
            }
            myfile.Close();
            nbaccount = i;
            nbaccount -= 1;

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            for (Int16 i = 0; i < nbaccount; i++)
            {
                if (txtClientNum.Text == acc[i].c_num)
                {
                    this.Height = 340;
                    lblName.Text = "Bienvenue " + acc[i].name;
                    active_acc = i;
                }
            }
            if (active_acc == -1)
            {
                MessageBox.Show("Number not found");
                txtClientNum.Focus();
            }

        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            if (acc[active_acc].c_pin == txtPin.Text)
            {
                this.Height = 480;
            }
            else
            {
                MessageBox.Show("Incorrect Pin. Please try again");
                txtPin.Focus();
            }
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            if (rbtnConsult.Checked)
            {
                lblAccountDetails.Text = "\n" + acc[active_acc].c_num + "\n" + acc[active_acc].name + "\n" + acc[active_acc].c_pin + "\n" + acc[active_acc].balance.ToString();
                this.Height = 646;
            }
            if (rbtnDeposit.Checked)
            {
                Single x = Convert.ToSingle(txtDeposit.Text);
                if (x < 2 || x > 20000)
                {
                    MessageBox.Show("Please enter amount between $2 - $20,000");
                    txtDeposit.Focus();
                }
                else
                {
                    acc[active_acc].balance += x;
                    lblAccountDetails.Text = "\n" + acc[active_acc].c_num + "\n" + acc[active_acc].name + "\n" + acc[active_acc].c_pin + "\n" + acc[active_acc].balance.ToString();
                    this.Height = 646;
                }
            }
            if (rbtnWithdraw.Checked)
            {
                Single x = Convert.ToSingle(txtWithdraw.Text);
                if ( x > acc[active_acc].balance)
                {
                    MessageBox.Show("Insufficient Balance (Cannot Withdraw)");
                    txtWithdraw.Focus();
                }
                else if (x < 20)
                {
                    MessageBox.Show("Minimum Withdrawl Limit: $20");
                    txtWithdraw.Focus();
                }
                else if (x > 500)
                {
                    MessageBox.Show("Maximum Withdrawl Limit: $500");
                    txtWithdraw.Focus();
                }
                else if ( x % Convert.ToInt16(20) != 0)
                {
                    MessageBox.Show("Please enter amount in multiples of $20.");
                    txtWithdraw.Focus();
                }
                else
                {
                    acc[active_acc].balance -= x ;
                    lblAccountDetails.Text = "\n" + acc[active_acc].c_num + "\n" + acc[active_acc].name + "\n" + acc[active_acc].c_pin + "\n" + acc[active_acc].balance.ToString();
                    this.Height = 646;
                }
            }
            rbtnFinish.Enabled = true;

        }

        private void rbtnDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Visible = false;
            lblWitDollar.Visible = false;
            lblDepDollar.Visible = true;
            txtDeposit.Visible = true;
            txtDeposit.Focus();

        }

        private void rbtnWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = false;
            lblDepDollar.Visible = false;
            txtWithdraw.Visible = true;
            lblWitDollar.Visible = true;
            txtWithdraw.Focus();

        }

        private void rbtnFinish_Click(object sender, EventArgs e)
        {
            StreamWriter myfile = new StreamWriter("Bank.txt");
            Int16 i = 0;
            while (i <= nbaccount)
            {
                myfile.WriteLine(acc[i].c_num);
                myfile.WriteLine(acc[i].name);
                myfile.WriteLine(acc[i].c_pin);
                myfile.WriteLine(acc[i].balance.ToString());
                i++;
            }
            myfile.Close();

            frmGuichetBancaire frm = new frmGuichetBancaire();
            this.Close();

        }

    }
}