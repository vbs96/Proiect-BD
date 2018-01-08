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
    public partial class ViewEmailForm : Form
    {
        public ViewEmailForm(string DateTime, string From, string Subject, string Content, 
            string Attachment)
        {
            InitializeComponent();
            textBox1.Text = From;
            textBox2.Text = Subject;
            textBox3.Text = Content;
            textBox4.Text = Attachment;
            textBox5.Text = DateTime;
        }
    }
}
