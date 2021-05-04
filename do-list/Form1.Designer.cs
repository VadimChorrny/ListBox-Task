
namespace do_list
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chHeight = new System.Windows.Forms.CheckBox();
            this.chMiddle = new System.Windows.Forms.CheckBox();
            this.chLow = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 16;
            this.lbEvents.Location = new System.Drawing.Point(12, 12);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(479, 388);
            this.lbEvents.TabIndex = 0;
            this.lbEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbEvents_MouseDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(498, 12);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 34);
            this.txtName.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(498, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chLow);
            this.groupBox1.Controls.Add(this.chMiddle);
            this.groupBox1.Controls.Add(this.chHeight);
            this.groupBox1.Location = new System.Drawing.Point(498, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chHeight
            // 
            this.chHeight.AutoSize = true;
            this.chHeight.Location = new System.Drawing.Point(19, 37);
            this.chHeight.Name = "chHeight";
            this.chHeight.Size = new System.Drawing.Size(71, 21);
            this.chHeight.TabIndex = 0;
            this.chHeight.Text = "Height";
            this.chHeight.UseVisualStyleBackColor = true;
            // 
            // chMiddle
            // 
            this.chMiddle.AutoSize = true;
            this.chMiddle.Location = new System.Drawing.Point(19, 64);
            this.chMiddle.Name = "chMiddle";
            this.chMiddle.Size = new System.Drawing.Size(71, 21);
            this.chMiddle.TabIndex = 1;
            this.chMiddle.Text = "Middle";
            this.chMiddle.UseVisualStyleBackColor = true;
            // 
            // chLow
            // 
            this.chLow.AutoSize = true;
            this.chLow.Location = new System.Drawing.Point(19, 91);
            this.chLow.Name = "chLow";
            this.chLow.Size = new System.Drawing.Size(55, 21);
            this.chLow.TabIndex = 2;
            this.chLow.Text = "Low";
            this.chLow.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(498, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 70);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "NEW";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(497, 360);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(228, 40);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(497, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 415);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbEvents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chLow;
        private System.Windows.Forms.CheckBox chMiddle;
        private System.Windows.Forms.CheckBox chHeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox comboBox1;
        protected internal System.Windows.Forms.ListBox lbEvents;
    }
}

