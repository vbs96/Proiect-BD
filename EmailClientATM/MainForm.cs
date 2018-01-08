using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailClientATM
{
    public partial class MainForm : Form
    {
        private string emailUser;
        public MainForm(string email)
        {
            InitializeComponent();
            emailUser = email;
            ControlBox = false;    
        }

        private void InboxButton_Click(object sender, EventArgs e)
        {
            var inboxMainForm = new InboxForm(emailUser); 
            inboxMainForm.ShowDialog();
        }

        private void ImportantButton_Click(object sender, EventArgs e)
        {
            var importantForm = new ImportantForm(emailUser);
            importantForm.ShowDialog();
        }

        private void SpamButton_Click(object sender, EventArgs e)
        {
            var spamForm = new SpamForm(emailUser);
            spamForm.ShowDialog();
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


    }
}
