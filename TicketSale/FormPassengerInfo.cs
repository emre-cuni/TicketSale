using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSale
{
    public partial class FormPassengerInfo : Form
    {
        public FormPassengerInfo(int _flightId, int _passengerCount, int _passengerCapacity, double _price)
        {
            InitializeComponent();
            flightId = _flightId;
            passengerCount = _passengerCount;
            passengerCapacity = _passengerCapacity;
            price = _price;
        }

        int flightId = -1, passengerCount = 0, passengerCapacity = 0;
        double price = 0;
        string query = null;
        SqlProcess sqlProcess = new SqlProcess();
        bool passengerControl = true;

        private void textBoxPassenger_Leave(object sender, EventArgs e) // eklenen yolcuları iletişim için combobox'a ekler
        {
            try
            {
                if (textBoxPassengerName.Text != string.Empty && textBoxPassengerSurname.Text != string.Empty && maskedTextBoxTC.Text != string.Empty && passengerControl)
                {
                    comboBoxContacts.Items.Add(textBoxPassengerName.Text.Trim() + " " + textBoxPassengerSurname.Text.Trim());
                    passengerControl = !passengerControl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "textBoxPassenger Leave Hatası ");
            }
        }

        private void textBoxPassenger_Enter(object sender, EventArgs e)
        {
            try
            {
                if (!passengerControl)
                {
                    textBoxPassengerName.Text = string.Empty;
                    textBoxPassengerSurname.Text = string.Empty;
                    maskedTextBoxTC.Text = string.Empty;
                    passengerControl = !passengerControl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "textBoxPassenger Enter Hatası ");
            }
        }

        private void comboBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxContacts.SelectedIndex != -1)
                {
                    textBoxContactName.Text = comboBoxContacts.SelectedItem.ToString().Substring(0, comboBoxContacts.SelectedItem.ToString().IndexOf(" "));
                    textBoxContactSurname.Text = comboBoxContacts.SelectedItem.ToString().Substring(comboBoxContacts.SelectedItem.ToString().IndexOf(" ") + 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Yolcu Seçme Hatası");
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                FormSeatSelection formSeatSelection = new FormSeatSelection(passengerCount);
                formSeatSelection.ShowDialog();
                if (comboBoxContacts.SelectedIndex != -1 && textBoxContactEmail.Text != string.Empty && maskedTextBoxContactPhone.Text != string.Empty)
                    goto finish;

                /*** Ödeme ekranını ekle ***/

                passengerCapacity -= passengerCount; //!!!

                // seçilen yolcu sayısı kadar yeri uçuş kapasitesinden düşürmek
                query = $"UPDATE Table_Flights SET passengerCapacity = {passengerCapacity} WHERE id = {flightId}";

                if (sqlProcess.UpdateCapacity(query))
                    MessageBox.Show("kapasite güncellendi");
                else
                    MessageBox.Show("kapasite güncellenemedi");
                finish:;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace);
            }
        }

        private void FormPassengerInfo_Load(object sender, EventArgs e)
        {
            try
            {
                labelTotalPrice.Text = "Toplam: " + (price * passengerCount) + "₺";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Load Hatası");
            }
        }
    }
}
