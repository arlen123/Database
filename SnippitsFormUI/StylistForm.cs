using SnippitsBusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class StylistForm : Form
    {
        private Stylist m_Stylist = null;

        public Stylist GetStylist()
        {
            return m_Stylist;
        }

        public StylistForm()
        {
            InitializeComponent();
        }

        public StylistForm(Stylist pStylist):this()
        {

            firstNameTextBox.Text = Convert.ToString(pStylist.FirstName);
            surnameTextBox.Text = Convert.ToString(pStylist.SurName);
            emailTextBox.Text = Convert.ToString(pStylist.Email);
            m_Stylist = pStylist;
        }


        private void transactionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click_1(object sender, EventArgs e)
        {
            if (m_Stylist == null)
            {
                m_Stylist = new Stylist();
            }
            m_Stylist.FirstName = firstNameTextBox.Text;
            m_Stylist.SurName = surnameTextBox.Text;
            m_Stylist.Email = emailTextBox.Text;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
