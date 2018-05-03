using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class CustomerForm : Form
    {
        private Customer m_Customer = null;



        public Customer GetCustomer()
        {
            return m_Customer;
        }
        
  

        public CustomerForm()
        {

            InitializeComponent();
        }

        public CustomerForm(Customer pCustomer):this()
        {
            
            firstNameTextBox.Text = Convert.ToString(pCustomer.FirstName);
            surnameTextBox.Text = Convert.ToString(pCustomer.SurName);
            emailTextBox.Text = Convert.ToString(pCustomer.Email);
            phoneNumberTextBox.Text = Convert.ToString(pCustomer.PhoneNumber);
            phoneNumberTextBox.ReadOnly = true;
            m_Customer = pCustomer;

        } 

        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (m_Customer == null)
            {
                m_Customer = new Customer();
                m_Customer.PhoneNumber = phoneNumberTextBox.Text;
            }
            m_Customer.FirstName = firstNameTextBox.Text;
            m_Customer.SurName = surnameTextBox.Text;
            m_Customer.Email = emailTextBox.Text;
            
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
