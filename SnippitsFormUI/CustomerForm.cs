using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {

            InitializeComponent();
        }

        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
             
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
