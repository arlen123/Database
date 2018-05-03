using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class CustomerSelectionForm : Form
    {

        public List<Customer> customers = null;
         
        public CustomerSelectionForm()
        {
            customers = new List<Customer>();
            InitializeComponent();
        }

        private void addNewCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            
        }
         
        private void bookAppointmentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
