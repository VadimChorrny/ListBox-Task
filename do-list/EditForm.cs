using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_list
{
    public partial class EditForm : Form
    {
        internal Form1 Parent { get; set; }
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(Form1 forms)
        {
            InitializeComponent();
            Parent = forms;
        }

        public void FileWorker()
        {
            string path = @"item.json";
            ListEvents product = new ListEvents()
            { 
                Name = txtEdit.Text,
                Date = dtpTime.Value,
                Priority = e_chHeight.Checked == true ? (e_chHeight.Text) : (e_chMiddle.Checked == true ? e_chMiddle.Text : e_chLow.Text)
            };

            string json = JsonConvert.SerializeObject(product);
            File.WriteAllText(path, json);
            ListEvents p = JsonConvert.DeserializeObject<ListEvents>(json);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListEvents le = new ListEvents()
            {
                Name = txtEdit.Text,
                Date = dtpTime.Value,
                Priority = e_chHeight.Checked == true ? (e_chHeight.Text) : (e_chMiddle.Checked == true ? e_chMiddle.Text : e_chLow.Text)
            };
            Parent.lbEvents.Items.Add(le);
            Parent.lbEvents.Items[Parent.lbEvents.SelectedIndex] = le;
            if (btnSave.DialogResult == DialogResult.OK)
            {
                Parent.lbEvents.Items.RemoveAt(Parent.lbEvents.SelectedIndex);
            }
            FileWorker();
        }
    }
}
