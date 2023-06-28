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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        SqlProcess sql = new SqlProcess();
        string query = null, swap = null, departureAirport = null, arrivalAirport = null, departureDate = null, arrivalDate = null;
        Dictionary<string, Tuple<string, string>> airports = new Dictionary<string, Tuple<string, string>>();
        int adult = 0, youth = 0, child = 0, totalTraveller = 0;
        FormFlightSchedule flightSchedule;

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                //form'u tam ekran yapma
                WindowState = FormWindowState.Maximized;

                //groupbox'ı ekranın ortasına alma
                groupBox.Location = new Point(Width / 3, Height / 4);

                query = "Select * From Table_Airport";
                airports = sql.GetAirports(query); // veri tabanındaki havaalanlarını çeker ve "airports" dictionary'sine atar
                foreach (var item in airports) // combobox'lar doldurulur
                {
                    comboBoxDeparture.Items.Add(item.Key);
                    comboBoxArrival.Items.Add(item.Key);
                }
                // comboboxlara default değer ataması yapılır
                comboBoxDeparture.SelectedIndex = 1;
                comboBoxArrival.SelectedIndex = 2;
                // uçuş tarihleri default olarak bugün verilir
                dateTimePickerDepartureDate.Value = DateTime.Now;
                dateTimePickerArrivalDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "FormMain Load Hatası");
            }
        }

        private void checkBoxOneWay_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxOneWay.Checked) // tek yön seçilirse dönüş tarihi disabled yapılır
                {
                    dateTimePickerArrivalDate.Visible = false;
                    labelArrow.Visible = false;
                    labelArrivalDate.Visible = false;
                }
                else // tek yön seçilmezse dönüş tarihi enabled yapılır
                {
                    dateTimePickerArrivalDate.Visible = true;
                    labelArrow.Visible = true;
                    labelArrivalDate.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Tek Yön Hatası");
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDeparture.SelectedIndex != -1 && comboBoxArrival.SelectedIndex != -1) // hava alanı seçilip seçilmediği kontrol edilir
                {
                    adult = int.Parse(numericUpDownAdult.Value.ToString()); // yetişkin yolcu sayısı alınır
                    youth = int.Parse(numericUpDownYouth.Value.ToString()); // genç yolcu sayısı alınır
                    child = int.Parse(numericUpDownChild.Value.ToString()); // çocuk yolcu sayısı alınır

                    totalTraveller = adult + youth + child;

                    if (totalTraveller > 9) // toplam yolcu sayısı 9'dan fazlaysa uyarı pop-up'ı çıkartılır
                        MessageBox.Show("Toplam Yolcu 9'dan Fazla Olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else //toplam yolcu sayısı 9'a küçük eşitse uçuşlar listelenir
                    {
                        departureAirport = comboBoxDeparture.SelectedItem.ToString();
                        arrivalAirport = comboBoxArrival.SelectedItem.ToString();
                        departureDate = DateTime.Parse(dateTimePickerDepartureDate.Text).ToString("dd/MM/yyyy");
                        arrivalDate = DateTime.Parse(dateTimePickerArrivalDate.Text).ToString("dd/MM/yyyy");

                        flightSchedule = new FormFlightSchedule(departureAirport, arrivalAirport, departureDate, arrivalDate, adult, youth, child);
                        Hide();
                        flightSchedule.ShowDialog();
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Devam Et Hatası");
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e) // kalkış ve varış hava alanları yer değiştirilir
        {
            try
            {
                swap = comboBoxDeparture.SelectedItem.ToString();
                comboBoxDeparture.SelectedItem = comboBoxArrival.SelectedItem;
                comboBoxArrival.SelectedItem = swap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Swap Hatası");
            }
        }
    }
}
