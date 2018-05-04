using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class StylistSelectionForm : Form
    {

        public List<Stylist> stylists = null;

        public StylistSelectionForm()
        {
            stylists = new List<Stylist>();
            InitializeComponent();
        }

        private void ResetStylistList()
        {

        }

        private void StylistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void editStylistButton_Click(object sender, EventArgs e)
        {
            Stylist stylist = (Stylist)StylistListBox.SelectedItem;
            StylistForm form = new StylistForm(stylist);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                StylistListBox.Items.Clear();
                foreach (Stylist stylistA in stylists)
                {
                    StylistListBox.Items.Add(stylistA);
                }
            }
        }

        private void addNewStylistButton_Click_1(object sender, EventArgs e)
        {
            StylistForm form = new StylistForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                stylists.Add(form.GetStylist());
                StylistListBox.Items.Add(form.GetStylist());
            }
        }
    }

}
