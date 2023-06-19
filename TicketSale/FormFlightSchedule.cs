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
    public partial class FormFlightSchedule : Form
    {
        public FormFlightSchedule(string _departureAirport, string _arrivalAirport, string _departureDate, string _arrivalDate, int _adult, int _youth, int _child)
        {
            InitializeComponent();
            departureAirport = _departureAirport;
            arrivalAirport = _arrivalAirport;
            departureDate = _departureDate;
            arrivalDate = _arrivalDate;
            adult = _adult;
            youth = _youth;
            child = _child;
        }

        SqlProcess sqlProcess = new SqlProcess();
        string departureAirport = null, arrivalAirport = null, query = null, departureDate = null, arrivalDate = null;
        int adult = 0, youth = 0, child = 0;
        List<Tuple<string, string, DateTime, DateTime, int>> flights = new List<Tuple<string, string, DateTime, DateTime, int>>();
        Panel panel;
        Button button;

        private void FormFlightSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                query = "Select departureAirport.airportName As departureAirportName, arrivalAirport.airportName As arrivalAirportName, departureTime, arrivalTime, passengerCapacity From Table_Flights Inner Join Table_Airport As departureAirport On Table_Flights.departureId = departureAirport.id Inner Join Table_Airport As arrivalAirport On Table_Flights.arrivalId = arrivalAirport.id Where arrivalAirport.airportName = 'Trabzon Havalimanı';";
                flights = sqlProcess.GetFlights(query);
                foreach (var item in flights)
                {
                    panel = new Panel();
                    button = new Button();
                    button.Text = item.ToString();
                    button.Size = new Size(600, 120);
                    panel.Controls.Add(button);
                    panel.Size = new Size(610, 130);
                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Schedule Load Hatası");
            }
        }
    }
}
