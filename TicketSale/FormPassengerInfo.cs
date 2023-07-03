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
        public FormPassengerInfo(int _flightId, int _passengerCount, int _passengerCapacity)
        {
            InitializeComponent();
            flightId = _flightId;
            passengerCount = _passengerCount;
            passengerCapacity = _passengerCapacity;
        }

        int flightId = -1, passengerCount = 0, passengerCapacity = 0;
        string query = null;
        SqlProcess sqlProcess= new SqlProcess();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                passengerCapacity = passengerCapacity - passengerCount;
                // seçilen yolcu sayısı kadar yeri uçuş kapasitesinden düşürmek
                //UPDATE Table_Flights SET passengerCapacity = 61 WHERE id = 47;
                query = $"UPDATE Table_Flights SET passengerCapacity = {passengerCapacity} WHERE id = {flightId}";

                if (sqlProcess.UpdateCapacity(query))
                    MessageBox.Show("kapasite güncellendi");
                else
                    MessageBox.Show("kapasite güncellenemedi");
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Load Hatası");
            }
        }
    }
}
