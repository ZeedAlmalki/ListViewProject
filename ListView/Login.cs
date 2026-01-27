using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        short NumberOfFailed = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "1234" && txtUserName.Text.ToLower() == "admin")
            {
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();

                return;
            } 
            else
            {
                NumberOfFailed++;
                if (!(NumberOfFailed %3 == 0))
                { 
                MessageBox.Show($"Login Failed!{Environment.NewLine}Attempt number {NumberOfFailed}","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                if (NumberOfFailed % 3 == 0)
                { 
                    if (NumberOfFailed >=6)
                    {
                        NotifyOfBan.Icon = SystemIcons.Warning;
                        NotifyOfBan.BalloonTipIcon = ToolTipIcon.Warning;
                        NotifyOfBan.BalloonTipTitle = "BANNED";
                        NotifyOfBan.BalloonTipText = "Your IP Address HAS BEEN BANNED Because Of Your Too Many Attempts";
                        NotifyOfBan.ShowBalloonTip(30000);
                        this.Close();
                        return;
                    }

                    MessageBox.Show("You Have Tried 3 Times In a Row. You Cannot Login For The Next 5 Seconds.","LOCKED",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    resetControls(true);
                }

            }


        }

        short Counter = 0;
        void resetControls(bool Lock)
        {
            if (Lock)
            {
                Counter = 0;
                txtPassword.Clear();
                txtPassword.Enabled = false;
                txtUserName.Clear();
                txtUserName.Enabled = false;
                btnLogin.Enabled = false;
                lblTimer.Visible = true;
                TimerOfLock.Enabled = true;
            }

            if (!Lock)
            {
                Counter = 0;
                txtPassword.Enabled = true;
                txtUserName.Enabled = true;
                btnLogin.Enabled = true;
                lblTimer.Visible = false;
                TimerOfLock.Enabled = false;
                txtUserName.Focus();
            }
        }


        private void TimerOfLock_Tick(object sender, EventArgs e)
        {
            Counter++;
            lblTimer.Text = Counter.ToString();
            
            if (Counter >= 5)
            {
                lblTimer.Text = "0";
                resetControls(false);
                MessageBox.Show("You Can Login Now","UNLOCKED",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
