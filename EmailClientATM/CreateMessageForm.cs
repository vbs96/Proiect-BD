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
    public partial class CreateMessageForm : Form
    {
        public CreateMessageForm()
        {
            InitializeComponent();
        }

        private void CreateMessageForm_Load(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (toTextBox.Text == null)
                MessageBox.Show("Introduce-ti un email destinatie!");
            else
            {
                
            } 
        }
    }
}
