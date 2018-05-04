using SnippitsBusinessLogic;
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
            string error = "";
            customers = CustomerLoader.LoadFromCSV("Customers.txt", out error);
            if(customers == null)
            {
                MessageBox.Show(error);
            }
            InitializeComponent();

        }


        private void ResetCustomerList()
        {

        }

        private void addNewCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            { 
                customers.Add(form.GetCustomer());
                CustomerListBox.Items.Add(form.GetCustomer());
            }
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        { 
            Customer customer = (Customer)CustomerListBox.SelectedItem;
            CustomerForm form = new CustomerForm(customer);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                CustomerListBox.Items.Clear();
                foreach(Customer customerA in customers)
                {
                    CustomerListBox.Items.Add(customerA);
                }
            }
        }
         
        private void bookAppointmentButton_Click(object sender, EventArgs e)
        {

        }

        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
