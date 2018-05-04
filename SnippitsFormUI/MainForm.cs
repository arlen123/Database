using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    

    public partial class MainForm : Form
    {

        public List<Customer> customers = null;

        public MainForm()
        {
            customers = new List<Customer>();
            InitializeComponent();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            CustomerSelectionForm form = new CustomerSelectionForm();
            form.ShowDialog();
        }

        private void stylistsButton_Click(object sender, EventArgs e)
        {
            StylistSelectionForm form = new StylistSelectionForm();
            form.ShowDialog();
        }
    }

    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string firstname, string surname, string email, string phonenumber)
        {
            FirstName = firstname;
            SurName = surname;
            Email = email;
            PhoneNumber = phonenumber;
        }

        public string Email { get; internal set; }
        public object FirstName { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public string SurName { get; internal set; }
    }

    public class CustomerLoader
    {
        public static List<Customer> LoadFromCSV(string pFilename, out string pError)
        {
            pError = "";

            List<Customer> customers = new List<Customer>();

            StreamReader reader = null;
            try
            {
                reader = new StreamReader(pFilename);            // reader being opened

                while (!reader.EndOfStream)
                {

                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length == 5)
                    {
                        string firstname = values[0];
                        string surname = values[1];
                        string email = values[2];
                        string phonenumber = values[3];
                        try
                        {
                            customers.Add(new Customer(firstname, surname, email, phonenumber));
                        }
                        catch (Exception ex)
                        {
                            pError = ex.Message;
                            return null;
                        }

                    }
                    else
                    {
                        pError = "Incorrect file format " + line;
                        return null;
                    }

                }

            }
            catch                                             //exception caught
            {
                pError = "Unable to open file " + pFilename + ".";
                return null;
            }

            finally                                          //after exception
            {
                if (reader != null)
                {
                    reader.Close();                           //reader is closed
                }
            }
            if (pError == "")
            {
                return customers;
            }
            return null;
        }
    }
}
    }

    public class Stylist
    {
        public string Email { get; internal set; }
        public object FirstName { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public string SurName { get; internal set; }
    }
}
