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
        string query = null, swap = null, departureAirport = null, arrivalAirport = null;
        Dictionary<string, Tuple<string, string>> airports = new Dictionary<string, Tuple<string, string>>();
        int adult = 0, youth = 0, child = 0, totalTraveller = 0;
        FormFlightSchedule flightSchedule;

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                query = "Select * From Table_Airport";
                airports = sql.SqlRead(query);
                foreach (var item in airports)
                {
                    comboBoxDeparture.Items.Add(item.Key);
                    comboBoxArrival.Items.Add(item.Key);
                }
                comboBoxDeparture.SelectedIndex = 1;
                comboBoxArrival.SelectedIndex = 2;
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
                if (checkBoxOneWay.Checked)
                {
                    dateTimePickerArrivalDate.Visible = false;
                    labelArrow.Visible = false;
                    labelArrivalDate.Visible = false;
                }
                else
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
                if (comboBoxDeparture.SelectedIndex != -1 && comboBoxArrival.SelectedIndex != -1)
                {
                    adult = int.Parse(numericUpDownAdult.Value.ToString());
                    youth = int.Parse(numericUpDownYouth.Value.ToString());
                    child = int.Parse(numericUpDownChild.Value.ToString());
                    totalTraveller = adult + youth + child;
                    if (totalTraveller > 9)
                        MessageBox.Show("Toplam Yolcu 9'dan Fazla Olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        departureAirport = comboBoxDeparture.SelectedItem.ToString();
                        arrivalAirport = comboBoxArrival.SelectedItem.ToString();
                        flightSchedule = new FormFlightSchedule(departureAirport,arrivalAirport);
                        flightSchedule.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Devam Et Hatası");
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e)
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
