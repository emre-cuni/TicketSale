namespace TicketSale
{
    partial class FormMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxDeparture = new System.Windows.Forms.GroupBox();
            this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
            this.comboBoxArrival = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxOneWay = new System.Windows.Forms.CheckBox();
            this.groupBoxArrival = new System.Windows.Forms.GroupBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.labelArrivalDate = new System.Windows.Forms.Label();
            this.labelDepartureDate = new System.Windows.Forms.Label();
            this.labelArrow = new System.Windows.Forms.Label();
            this.groupBoxPassenger = new System.Windows.Forms.GroupBox();
            this.labelChild = new System.Windows.Forms.Label();
            this.labelYouth = new System.Windows.Forms.Label();
            this.labelAdult = new System.Windows.Forms.Label();
            this.numericUpDownChild = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYouth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAdult = new System.Windows.Forms.NumericUpDown();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.groupBoxDeparture.SuspendLayout();
            this.groupBoxArrival.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxPassenger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDeparture
            // 
            this.groupBoxDeparture.Controls.Add(this.comboBoxDeparture);
            this.groupBoxDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxDeparture.ForeColor = System.Drawing.Color.White;
            this.groupBoxDeparture.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDeparture.Name = "groupBoxDeparture";
            this.groupBoxDeparture.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDeparture.Size = new System.Drawing.Size(257, 73);
            this.groupBoxDeparture.TabIndex = 0;
            this.groupBoxDeparture.TabStop = false;
            this.groupBoxDeparture.Text = "Nereden:";
            // 
            // comboBoxDeparture
            // 
            this.comboBoxDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDeparture.FormattingEnabled = true;
            this.comboBoxDeparture.Location = new System.Drawing.Point(4, 26);
            this.comboBoxDeparture.Name = "comboBoxDeparture";
            this.comboBoxDeparture.Size = new System.Drawing.Size(249, 28);
            this.comboBoxDeparture.TabIndex = 0;
            // 
            // comboBoxArrival
            // 
            this.comboBoxArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxArrival.FormattingEnabled = true;
            this.comboBoxArrival.Location = new System.Drawing.Point(3, 25);
            this.comboBoxArrival.Name = "comboBoxArrival";
            this.comboBoxArrival.Size = new System.Drawing.Size(251, 28);
            this.comboBoxArrival.TabIndex = 1;
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(4, 55);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(176, 29);
            this.dateTimePickerDepartureDate.TabIndex = 2;
            this.dateTimePickerDepartureDate.Value = new System.DateTime(2023, 6, 11, 12, 48, 37, 0);
            // 
            // dateTimePickerArrivalDate
            // 
            this.dateTimePickerArrivalDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerArrivalDate.Location = new System.Drawing.Point(216, 55);
            this.dateTimePickerArrivalDate.Name = "dateTimePickerArrivalDate";
            this.dateTimePickerArrivalDate.Size = new System.Drawing.Size(176, 29);
            this.dateTimePickerArrivalDate.TabIndex = 3;
            this.dateTimePickerArrivalDate.Value = new System.DateTime(2023, 6, 11, 0, 0, 0, 0);
            // 
            // checkBoxOneWay
            // 
            this.checkBoxOneWay.AutoSize = true;
            this.checkBoxOneWay.Location = new System.Drawing.Point(442, 55);
            this.checkBoxOneWay.Name = "checkBoxOneWay";
            this.checkBoxOneWay.Size = new System.Drawing.Size(107, 28);
            this.checkBoxOneWay.TabIndex = 4;
            this.checkBoxOneWay.Text = "Tek Yön";
            this.checkBoxOneWay.UseVisualStyleBackColor = true;
            this.checkBoxOneWay.CheckedChanged += new System.EventHandler(this.checkBoxOneWay_CheckedChanged);
            // 
            // groupBoxArrival
            // 
            this.groupBoxArrival.Controls.Add(this.comboBoxArrival);
            this.groupBoxArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxArrival.ForeColor = System.Drawing.Color.White;
            this.groupBoxArrival.Location = new System.Drawing.Point(326, 13);
            this.groupBoxArrival.Name = "groupBoxArrival";
            this.groupBoxArrival.Size = new System.Drawing.Size(257, 73);
            this.groupBoxArrival.TabIndex = 5;
            this.groupBoxArrival.TabStop = false;
            this.groupBoxArrival.Text = "Nereye:";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.labelArrivalDate);
            this.groupBoxDate.Controls.Add(this.labelDepartureDate);
            this.groupBoxDate.Controls.Add(this.labelArrow);
            this.groupBoxDate.Controls.Add(this.dateTimePickerDepartureDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerArrivalDate);
            this.groupBoxDate.Controls.Add(this.checkBoxOneWay);
            this.groupBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxDate.ForeColor = System.Drawing.Color.White;
            this.groupBoxDate.Location = new System.Drawing.Point(13, 93);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(570, 100);
            this.groupBoxDate.TabIndex = 6;
            this.groupBoxDate.TabStop = false;
            // 
            // labelArrivalDate
            // 
            this.labelArrivalDate.AutoSize = true;
            this.labelArrivalDate.Location = new System.Drawing.Point(216, 26);
            this.labelArrivalDate.Name = "labelArrivalDate";
            this.labelArrivalDate.Size = new System.Drawing.Size(135, 24);
            this.labelArrivalDate.TabIndex = 7;
            this.labelArrivalDate.Text = "Dönüş Tarihi:";
            // 
            // labelDepartureDate
            // 
            this.labelDepartureDate.AutoSize = true;
            this.labelDepartureDate.Location = new System.Drawing.Point(6, 25);
            this.labelDepartureDate.Name = "labelDepartureDate";
            this.labelDepartureDate.Size = new System.Drawing.Size(122, 24);
            this.labelDepartureDate.TabIndex = 6;
            this.labelDepartureDate.Text = "Gidiş Tarihi:";
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Location = new System.Drawing.Point(183, 57);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(30, 24);
            this.labelArrow.TabIndex = 5;
            this.labelArrow.Text = "→";
            // 
            // groupBoxPassenger
            // 
            this.groupBoxPassenger.Controls.Add(this.labelChild);
            this.groupBoxPassenger.Controls.Add(this.labelYouth);
            this.groupBoxPassenger.Controls.Add(this.labelAdult);
            this.groupBoxPassenger.Controls.Add(this.numericUpDownChild);
            this.groupBoxPassenger.Controls.Add(this.numericUpDownYouth);
            this.groupBoxPassenger.Controls.Add(this.numericUpDownAdult);
            this.groupBoxPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPassenger.ForeColor = System.Drawing.Color.White;
            this.groupBoxPassenger.Location = new System.Drawing.Point(13, 200);
            this.groupBoxPassenger.Name = "groupBoxPassenger";
            this.groupBoxPassenger.Size = new System.Drawing.Size(570, 103);
            this.groupBoxPassenger.TabIndex = 7;
            this.groupBoxPassenger.TabStop = false;
            // 
            // labelChild
            // 
            this.labelChild.AutoSize = true;
            this.labelChild.Location = new System.Drawing.Point(438, 25);
            this.labelChild.Name = "labelChild";
            this.labelChild.Size = new System.Drawing.Size(75, 24);
            this.labelChild.TabIndex = 3;
            this.labelChild.Text = "Çocuk:";
            // 
            // labelYouth
            // 
            this.labelYouth.AutoSize = true;
            this.labelYouth.Location = new System.Drawing.Point(220, 25);
            this.labelYouth.Name = "labelYouth";
            this.labelYouth.Size = new System.Drawing.Size(66, 24);
            this.labelYouth.TabIndex = 3;
            this.labelYouth.Text = "Genç:";
            // 
            // labelAdult
            // 
            this.labelAdult.AutoSize = true;
            this.labelAdult.Location = new System.Drawing.Point(6, 25);
            this.labelAdult.Name = "labelAdult";
            this.labelAdult.Size = new System.Drawing.Size(88, 24);
            this.labelAdult.TabIndex = 2;
            this.labelAdult.Text = "Yetişkin:";
            // 
            // numericUpDownChild
            // 
            this.numericUpDownChild.Location = new System.Drawing.Point(442, 58);
            this.numericUpDownChild.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownChild.Name = "numericUpDownChild";
            this.numericUpDownChild.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownChild.TabIndex = 1;
            // 
            // numericUpDownYouth
            // 
            this.numericUpDownYouth.Location = new System.Drawing.Point(224, 58);
            this.numericUpDownYouth.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownYouth.Name = "numericUpDownYouth";
            this.numericUpDownYouth.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownYouth.TabIndex = 1;
            // 
            // numericUpDownAdult
            // 
            this.numericUpDownAdult.Location = new System.Drawing.Point(6, 58);
            this.numericUpDownAdult.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownAdult.Name = "numericUpDownAdult";
            this.numericUpDownAdult.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownAdult.TabIndex = 0;
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonSwap.Image = ((System.Drawing.Image)(resources.GetObject("buttonSwap.Image")));
            this.buttonSwap.Location = new System.Drawing.Point(282, 40);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(38, 38);
            this.buttonSwap.TabIndex = 8;
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonContinue.Location = new System.Drawing.Point(13, 309);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(570, 52);
            this.buttonContinue.TabIndex = 9;
            this.buttonContinue.Text = "Devam Et";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(596, 389);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.groupBoxPassenger);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxArrival);
            this.Controls.Add(this.groupBoxDeparture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxDeparture.ResumeLayout(false);
            this.groupBoxArrival.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.groupBoxPassenger.ResumeLayout(false);
            this.groupBoxPassenger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.ComboBox comboBoxArrival;
        private System.Windows.Forms.ComboBox comboBoxDeparture;
        private System.Windows.Forms.CheckBox checkBoxOneWay;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalDate;
        private System.Windows.Forms.GroupBox groupBoxArrival;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Label labelArrow;
        private System.Windows.Forms.Label labelArrivalDate;
        private System.Windows.Forms.Label labelDepartureDate;
        private System.Windows.Forms.GroupBox groupBoxPassenger;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.NumericUpDown numericUpDownAdult;
        private System.Windows.Forms.Label labelYouth;
        private System.Windows.Forms.Label labelAdult;
        private System.Windows.Forms.NumericUpDown numericUpDownYouth;
        private System.Windows.Forms.Label labelChild;
        private System.Windows.Forms.NumericUpDown numericUpDownChild;
        private System.Windows.Forms.Button buttonContinue;
    }
}

