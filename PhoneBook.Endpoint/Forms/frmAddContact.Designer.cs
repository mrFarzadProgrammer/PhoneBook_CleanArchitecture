namespace PhoneBook.Endpoint.Forms
{
    partial class frmAddContact
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
            button2 = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            rtxtDescription = new System.Windows.Forms.RichTextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtCompany = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            نام = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(331, 551);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(137, 23);
            button2.TabIndex = 16;
            button2.Text = "برگشت";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(146, 551);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(128, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "ثبت مخاطب جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            label1.Location = new System.Drawing.Point(187, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(150, 18);
            label1.TabIndex = 15;
            label1.Text = "افزودن مخاطب جدید";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new System.Drawing.Point(146, 368);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new System.Drawing.Size(322, 96);
            rtxtDescription.TabIndex = 14;
            rtxtDescription.Text = "";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(146, 295);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(322, 23);
            txtPhoneNumber.TabIndex = 10;
            // 
            // txtCompany
            // 
            txtCompany.Location = new System.Drawing.Point(146, 225);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new System.Drawing.Size(322, 23);
            txtCompany.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(146, 168);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(322, 23);
            txtLastName.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(146, 101);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(322, 23);
            txtName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(37, 371);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 15);
            label5.TabIndex = 5;
            label5.Text = "توضیحات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 303);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "شماره تلفن";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(37, 233);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "شرکت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 176);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "نام خانوادگی";
            // 
            // نام
            // 
            نام.AutoSize = true;
            نام.Location = new System.Drawing.Point(37, 109);
            نام.Name = "نام";
            نام.Size = new System.Drawing.Size(21, 15);
            نام.TabIndex = 9;
            نام.Text = "نام";
            // 
            // frmAddContact
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(519, 622);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(rtxtDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCompany);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(نام);
            Name = "frmAddContact";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "frmAddContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label نام;
    }
}