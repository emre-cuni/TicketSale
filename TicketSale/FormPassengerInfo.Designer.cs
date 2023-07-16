namespace TicketSale
{
    partial class FormPassengerInfo
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
            this.buttonContinue = new System.Windows.Forms.Button();
            this.groupBoxPassenger = new System.Windows.Forms.GroupBox();
            this.groupBoxPassengerTC = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxPassengerBirthDay = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPassengerSurname = new System.Windows.Forms.GroupBox();
            this.textBoxPassengerSurname = new System.Windows.Forms.TextBox();
            this.groupBoxPassengerName = new System.Windows.Forms.GroupBox();
            this.textBoxPassengerName = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxContact = new System.Windows.Forms.GroupBox();
            this.groupBoxContactPhone = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxContactPhone = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxContactEmail = new System.Windows.Forms.GroupBox();
            this.textBoxContactEmail = new System.Windows.Forms.TextBox();
            this.groupBoxContactSurname = new System.Windows.Forms.GroupBox();
            this.textBoxContactSurname = new System.Windows.Forms.TextBox();
            this.groupBoxContactName = new System.Windows.Forms.GroupBox();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.groupBoxContactToPassenger = new System.Windows.Forms.GroupBox();
            this.comboBoxContacts = new System.Windows.Forms.ComboBox();
            this.groupBoxContinue = new System.Windows.Forms.GroupBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.groupBoxPassenger.SuspendLayout();
            this.groupBoxPassengerTC.SuspendLayout();
            this.groupBoxPassengerBirthDay.SuspendLayout();
            this.groupBoxPassengerSurname.SuspendLayout();
            this.groupBoxPassengerName.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxContact.SuspendLayout();
            this.groupBoxContactPhone.SuspendLayout();
            this.groupBoxContactEmail.SuspendLayout();
            this.groupBoxContactSurname.SuspendLayout();
            this.groupBoxContactName.SuspendLayout();
            this.groupBoxContactToPassenger.SuspendLayout();
            this.groupBoxContinue.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.Red;
            this.buttonContinue.Location = new System.Drawing.Point(393, 28);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(148, 62);
            this.buttonContinue.TabIndex = 0;
            this.buttonContinue.Text = "Devam ->";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // groupBoxPassenger
            // 
            this.groupBoxPassenger.Controls.Add(this.groupBoxPassengerTC);
            this.groupBoxPassenger.Controls.Add(this.groupBoxPassengerBirthDay);
            this.groupBoxPassenger.Controls.Add(this.groupBoxPassengerSurname);
            this.groupBoxPassenger.Controls.Add(this.groupBoxPassengerName);
            this.groupBoxPassenger.Controls.Add(this.groupBoxGender);
            this.groupBoxPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPassenger.ForeColor = System.Drawing.Color.White;
            this.groupBoxPassenger.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPassenger.Name = "groupBoxPassenger";
            this.groupBoxPassenger.Size = new System.Drawing.Size(565, 255);
            this.groupBoxPassenger.TabIndex = 1;
            this.groupBoxPassenger.TabStop = false;
            this.groupBoxPassenger.Text = "Yolcu Bilgileri:";
            // 
            // groupBoxPassengerTC
            // 
            this.groupBoxPassengerTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxPassengerTC.Controls.Add(this.maskedTextBoxTC);
            this.groupBoxPassengerTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPassengerTC.ForeColor = System.Drawing.Color.White;
            this.groupBoxPassengerTC.Location = new System.Drawing.Point(285, 170);
            this.groupBoxPassengerTC.Name = "groupBoxPassengerTC";
            this.groupBoxPassengerTC.Size = new System.Drawing.Size(264, 67);
            this.groupBoxPassengerTC.TabIndex = 6;
            this.groupBoxPassengerTC.TabStop = false;
            this.groupBoxPassengerTC.Text = "TC Kimlik Numarası:";
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.maskedTextBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTC.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxTC.Location = new System.Drawing.Point(7, 24);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.PromptChar = ' ';
            this.maskedTextBoxTC.Size = new System.Drawing.Size(250, 29);
            this.maskedTextBoxTC.TabIndex = 0;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            this.maskedTextBoxTC.Enter += new System.EventHandler(this.textBoxPassenger_Enter);
            this.maskedTextBoxTC.Leave += new System.EventHandler(this.textBoxPassenger_Leave);
            // 
            // groupBoxPassengerBirthDay
            // 
            this.groupBoxPassengerBirthDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxPassengerBirthDay.Controls.Add(this.dateTimePicker1);
            this.groupBoxPassengerBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPassengerBirthDay.ForeColor = System.Drawing.Color.White;
            this.groupBoxPassengerBirthDay.Location = new System.Drawing.Point(15, 170);
            this.groupBoxPassengerBirthDay.Name = "groupBoxPassengerBirthDay";
            this.groupBoxPassengerBirthDay.Size = new System.Drawing.Size(264, 67);
            this.groupBoxPassengerBirthDay.TabIndex = 5;
            this.groupBoxPassengerBirthDay.TabStop = false;
            this.groupBoxPassengerBirthDay.Text = "Doğum Tarihi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBoxPassengerSurname
            // 
            this.groupBoxPassengerSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxPassengerSurname.Controls.Add(this.textBoxPassengerSurname);
            this.groupBoxPassengerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPassengerSurname.ForeColor = System.Drawing.Color.White;
            this.groupBoxPassengerSurname.Location = new System.Drawing.Point(285, 100);
            this.groupBoxPassengerSurname.Name = "groupBoxPassengerSurname";
            this.groupBoxPassengerSurname.Size = new System.Drawing.Size(264, 63);
            this.groupBoxPassengerSurname.TabIndex = 4;
            this.groupBoxPassengerSurname.TabStop = false;
            this.groupBoxPassengerSurname.Text = "Soyad:";
            // 
            // textBoxPassengerSurname
            // 
            this.textBoxPassengerSurname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassengerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassengerSurname.ForeColor = System.Drawing.Color.White;
            this.textBoxPassengerSurname.Location = new System.Drawing.Point(6, 23);
            this.textBoxPassengerSurname.Name = "textBoxPassengerSurname";
            this.textBoxPassengerSurname.Size = new System.Drawing.Size(251, 29);
            this.textBoxPassengerSurname.TabIndex = 1;
            this.textBoxPassengerSurname.Enter += new System.EventHandler(this.textBoxPassenger_Enter);
            this.textBoxPassengerSurname.Leave += new System.EventHandler(this.textBoxPassenger_Leave);
            // 
            // groupBoxPassengerName
            // 
            this.groupBoxPassengerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxPassengerName.Controls.Add(this.textBoxPassengerName);
            this.groupBoxPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPassengerName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxPassengerName.Location = new System.Drawing.Point(15, 100);
            this.groupBoxPassengerName.Name = "groupBoxPassengerName";
            this.groupBoxPassengerName.Size = new System.Drawing.Size(264, 63);
            this.groupBoxPassengerName.TabIndex = 3;
            this.groupBoxPassengerName.TabStop = false;
            this.groupBoxPassengerName.Text = "Ad:";
            // 
            // textBoxPassengerName
            // 
            this.textBoxPassengerName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassengerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassengerName.ForeColor = System.Drawing.Color.White;
            this.textBoxPassengerName.Location = new System.Drawing.Point(7, 23);
            this.textBoxPassengerName.Name = "textBoxPassengerName";
            this.textBoxPassengerName.Size = new System.Drawing.Size(251, 29);
            this.textBoxPassengerName.TabIndex = 0;
            this.textBoxPassengerName.Enter += new System.EventHandler(this.textBoxPassenger_Enter);
            this.textBoxPassengerName.Leave += new System.EventHandler(this.textBoxPassenger_Leave);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxGender.ForeColor = System.Drawing.Color.White;
            this.groupBoxGender.Location = new System.Drawing.Point(15, 31);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(264, 63);
            this.groupBoxGender.TabIndex = 2;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Cinsiyet:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMale.Location = new System.Drawing.Point(6, 23);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(65, 22);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Erkek";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonFemale.Location = new System.Drawing.Point(77, 23);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(63, 22);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Kadın";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // groupBoxContact
            // 
            this.groupBoxContact.Controls.Add(this.groupBoxContactPhone);
            this.groupBoxContact.Controls.Add(this.groupBoxContactEmail);
            this.groupBoxContact.Controls.Add(this.groupBoxContactSurname);
            this.groupBoxContact.Controls.Add(this.groupBoxContactName);
            this.groupBoxContact.Controls.Add(this.groupBoxContactToPassenger);
            this.groupBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxContact.ForeColor = System.Drawing.Color.White;
            this.groupBoxContact.Location = new System.Drawing.Point(12, 291);
            this.groupBoxContact.Name = "groupBoxContact";
            this.groupBoxContact.Size = new System.Drawing.Size(565, 254);
            this.groupBoxContact.TabIndex = 2;
            this.groupBoxContact.TabStop = false;
            this.groupBoxContact.Text = "İrtibat Bilgileri:";
            // 
            // groupBoxContactPhone
            // 
            this.groupBoxContactPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxContactPhone.Controls.Add(this.maskedTextBoxContactPhone);
            this.groupBoxContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxContactPhone.ForeColor = System.Drawing.Color.White;
            this.groupBoxContactPhone.Location = new System.Drawing.Point(285, 181);
            this.groupBoxContactPhone.Name = "groupBoxContactPhone";
            this.groupBoxContactPhone.Size = new System.Drawing.Size(264, 63);
            this.groupBoxContactPhone.TabIndex = 8;
            this.groupBoxContactPhone.TabStop = false;
            this.groupBoxContactPhone.Text = "Telefon:";
            // 
            // maskedTextBoxContactPhone
            // 
            this.maskedTextBoxContactPhone.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.maskedTextBoxContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxContactPhone.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxContactPhone.Location = new System.Drawing.Point(6, 23);
            this.maskedTextBoxContactPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxContactPhone.Name = "maskedTextBoxContactPhone";
            this.maskedTextBoxContactPhone.PromptChar = ' ';
            this.maskedTextBoxContactPhone.Size = new System.Drawing.Size(251, 29);
            this.maskedTextBoxContactPhone.TabIndex = 1;
            // 
            // groupBoxContactEmail
            // 
            this.groupBoxContactEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxContactEmail.Controls.Add(this.textBoxContactEmail);
            this.groupBoxContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxContactEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxContactEmail.Location = new System.Drawing.Point(15, 181);
            this.groupBoxContactEmail.Name = "groupBoxContactEmail";
            this.groupBoxContactEmail.Size = new System.Drawing.Size(264, 63);
            this.groupBoxContactEmail.TabIndex = 7;
            this.groupBoxContactEmail.TabStop = false;
            this.groupBoxContactEmail.Text = "E-Mail:";
            // 
            // textBoxContactEmail
            // 
            this.textBoxContactEmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxContactEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxContactEmail.Location = new System.Drawing.Point(7, 23);
            this.textBoxContactEmail.Name = "textBoxContactEmail";
            this.textBoxContactEmail.Size = new System.Drawing.Size(251, 29);
            this.textBoxContactEmail.TabIndex = 0;
            // 
            // groupBoxContactSurname
            // 
            this.groupBoxContactSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxContactSurname.Controls.Add(this.textBoxContactSurname);
            this.groupBoxContactSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxContactSurname.ForeColor = System.Drawing.Color.White;
            this.groupBoxContactSurname.Location = new System.Drawing.Point(285, 112);
            this.groupBoxContactSurname.Name = "groupBoxContactSurname";
            this.groupBoxContactSurname.Size = new System.Drawing.Size(264, 63);
            this.groupBoxContactSurname.TabIndex = 6;
            this.groupBoxContactSurname.TabStop = false;
            this.groupBoxContactSurname.Text = "Soyad:";
            // 
            // textBoxContactSurname
            // 
            this.textBoxContactSurname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxContactSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxContactSurname.ForeColor = System.Drawing.Color.White;
            this.textBoxContactSurname.Location = new System.Drawing.Point(6, 23);
            this.textBoxContactSurname.Name = "textBoxContactSurname";
            this.textBoxContactSurname.Size = new System.Drawing.Size(251, 29);
            this.textBoxContactSurname.TabIndex = 1;
            // 
            // groupBoxContactName
            // 
            this.groupBoxContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxContactName.Controls.Add(this.textBoxContactName);
            this.groupBoxContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxContactName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxContactName.Location = new System.Drawing.Point(15, 112);
            this.groupBoxContactName.Name = "groupBoxContactName";
            this.groupBoxContactName.Size = new System.Drawing.Size(264, 63);
            this.groupBoxContactName.TabIndex = 5;
            this.groupBoxContactName.TabStop = false;
            this.groupBoxContactName.Text = "Ad:";
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxContactName.ForeColor = System.Drawing.Color.White;
            this.textBoxContactName.Location = new System.Drawing.Point(7, 23);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(251, 29);
            this.textBoxContactName.TabIndex = 0;
            // 
            // groupBoxContactToPassenger
            // 
            this.groupBoxContactToPassenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.groupBoxContactToPassenger.Controls.Add(this.comboBoxContacts);
            this.groupBoxContactToPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxContactToPassenger.ForeColor = System.Drawing.Color.White;
            this.groupBoxContactToPassenger.Location = new System.Drawing.Point(15, 43);
            this.groupBoxContactToPassenger.Name = "groupBoxContactToPassenger";
            this.groupBoxContactToPassenger.Size = new System.Drawing.Size(264, 63);
            this.groupBoxContactToPassenger.TabIndex = 1;
            this.groupBoxContactToPassenger.TabStop = false;
            this.groupBoxContactToPassenger.Text = "İrtibata Geçilecek Yolcu:";
            // 
            // comboBoxContacts
            // 
            this.comboBoxContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxContacts.FormattingEnabled = true;
            this.comboBoxContacts.Location = new System.Drawing.Point(7, 23);
            this.comboBoxContacts.Name = "comboBoxContacts";
            this.comboBoxContacts.Size = new System.Drawing.Size(250, 32);
            this.comboBoxContacts.TabIndex = 0;
            this.comboBoxContacts.SelectedIndexChanged += new System.EventHandler(this.comboBoxContacts_SelectedIndexChanged);
            // 
            // groupBoxContinue
            // 
            this.groupBoxContinue.Controls.Add(this.labelTotalPrice);
            this.groupBoxContinue.Controls.Add(this.buttonContinue);
            this.groupBoxContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxContinue.ForeColor = System.Drawing.Color.White;
            this.groupBoxContinue.Location = new System.Drawing.Point(13, 552);
            this.groupBoxContinue.Name = "groupBoxContinue";
            this.groupBoxContinue.Size = new System.Drawing.Size(564, 114);
            this.groupBoxContinue.TabIndex = 3;
            this.groupBoxContinue.TabStop = false;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalPrice.Location = new System.Drawing.Point(14, 45);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(141, 37);
            this.labelTotalPrice.TabIndex = 0;
            this.labelTotalPrice.Text = "Toplam:";
            // 
            // FormPassengerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(593, 677);
            this.Controls.Add(this.groupBoxContinue);
            this.Controls.Add(this.groupBoxContact);
            this.Controls.Add(this.groupBoxPassenger);
            this.Name = "FormPassengerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPassengerInfo";
            this.Load += new System.EventHandler(this.FormPassengerInfo_Load);
            this.groupBoxPassenger.ResumeLayout(false);
            this.groupBoxPassengerTC.ResumeLayout(false);
            this.groupBoxPassengerTC.PerformLayout();
            this.groupBoxPassengerBirthDay.ResumeLayout(false);
            this.groupBoxPassengerSurname.ResumeLayout(false);
            this.groupBoxPassengerSurname.PerformLayout();
            this.groupBoxPassengerName.ResumeLayout(false);
            this.groupBoxPassengerName.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxContact.ResumeLayout(false);
            this.groupBoxContactPhone.ResumeLayout(false);
            this.groupBoxContactPhone.PerformLayout();
            this.groupBoxContactEmail.ResumeLayout(false);
            this.groupBoxContactEmail.PerformLayout();
            this.groupBoxContactSurname.ResumeLayout(false);
            this.groupBoxContactSurname.PerformLayout();
            this.groupBoxContactName.ResumeLayout(false);
            this.groupBoxContactName.PerformLayout();
            this.groupBoxContactToPassenger.ResumeLayout(false);
            this.groupBoxContinue.ResumeLayout(false);
            this.groupBoxContinue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.GroupBox groupBoxPassenger;
        private System.Windows.Forms.GroupBox groupBoxContact;
        private System.Windows.Forms.GroupBox groupBoxPassengerName;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.GroupBox groupBoxPassengerBirthDay;
        private System.Windows.Forms.GroupBox groupBoxPassengerSurname;
        private System.Windows.Forms.TextBox textBoxPassengerSurname;
        private System.Windows.Forms.TextBox textBoxPassengerName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBoxPassengerTC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.ComboBox comboBoxContacts;
        private System.Windows.Forms.GroupBox groupBoxContactPhone;
        private System.Windows.Forms.GroupBox groupBoxContactEmail;
        private System.Windows.Forms.TextBox textBoxContactEmail;
        private System.Windows.Forms.GroupBox groupBoxContactSurname;
        private System.Windows.Forms.TextBox textBoxContactSurname;
        private System.Windows.Forms.GroupBox groupBoxContactName;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.GroupBox groupBoxContactToPassenger;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxContactPhone;
        private System.Windows.Forms.GroupBox groupBoxContinue;
        private System.Windows.Forms.Label labelTotalPrice;
    }
}