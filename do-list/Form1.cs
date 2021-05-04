using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbEvents.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ListEvents le = new ListEvents()
            {
                Name = txtName.Text,
                Date = dateTimePicker1.Value,
                Priority = chHeight.Checked == true ? (chHeight.Text) : (chMiddle.Checked == true ? chMiddle.Text : chLow.Text) 
            }; 
            lbEvents.Items.Add(le);
            comboBox1.Items.Add(lbEvents.Items.Count);
        }

        private void lbEvents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditForm edit = new EditForm(this);
            edit.ShowDialog();

         
        }
    }
}
