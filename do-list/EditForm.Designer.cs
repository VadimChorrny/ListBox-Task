
namespace do_list
{
    partial class EditForm
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
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.e_chHeight = new System.Windows.Forms.CheckBox();
            this.e_chMiddle = new System.Windows.Forms.CheckBox();
            this.e_chLow = new System.Windows.Forms.CheckBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(53, 90);
            this.txtEdit.Multiline = true;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(276, 37);
            this.txtEdit.TabIndex = 0;
            // 
            // e_chHeight
            // 
            this.e_chHeight.AutoSize = true;
            this.e_chHeight.Location = new System.Drawing.Point(53, 187);
            this.e_chHeight.Name = "e_chHeight";
            this.e_chHeight.Size = new System.Drawing.Size(71, 21);
            this.e_chHeight.TabIndex = 1;
            this.e_chHeight.Text = "Height";
            this.e_chHeight.UseVisualStyleBackColor = true;
            // 
            // e_chMiddle
            // 
            this.e_chMiddle.AutoSize = true;
            this.e_chMiddle.Location = new System.Drawing.Point(53, 214);
            this.e_chMiddle.Name = "e_chMiddle";
            this.e_chMiddle.Size = new System.Drawing.Size(71, 21);
            this.e_chMiddle.TabIndex = 2;
            this.e_chMiddle.Text = "Middle";
            this.e_chMiddle.UseVisualStyleBackColor = true;
            // 
            // e_chLow
            // 
            this.e_chLow.AutoSize = true;
            this.e_chLow.Location = new System.Drawing.Point(53, 241);
            this.e_chLow.Name = "e_chLow";
            this.e_chLow.Size = new System.Drawing.Size(55, 21);
            this.e_chLow.TabIndex = 3;
            this.e_chLow.Text = "Low";
            this.e_chLow.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(53, 143);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(276, 22);
            this.dtpTime.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(53, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(276, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.e_chLow);
            this.Controls.Add(this.e_chMiddle);
            this.Controls.Add(this.e_chHeight);
            this.Controls.Add(this.txtEdit);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.DateTimePicker dtpTime;
        protected internal System.Windows.Forms.TextBox txtEdit;
        protected internal System.Windows.Forms.CheckBox e_chHeight;
        protected internal System.Windows.Forms.CheckBox e_chMiddle;
        protected internal System.Windows.Forms.CheckBox e_chLow;
        protected internal System.Windows.Forms.Button btnSave;
    }
}