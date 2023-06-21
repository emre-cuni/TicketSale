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
        string[] flight;
        int adult = 0, youth = 0, child = 0;
        List<Tuple<string, string, DateTime, DateTime, int>> flights = new List<Tuple<string, string, DateTime, DateTime, int>>();
        Panel panel;
        Button button;

        private void FormFlightSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                //******************************************************* veri tabanından uçuşları çektim düzgün formatta flowlayoutpanel'a ekle*********************************************************************************

                query = "Select departureAirport.airportName As departureAirportName, arrivalAirport.airportName As arrivalAirportName, departureTime, arrivalTime, passengerCapacity From Table_Flights " +
                    "Inner Join Table_Airport As departureAirport On Table_Flights.departureId = departureAirport.id " +
                    "Inner Join Table_Airport As arrivalAirport On Table_Flights.arrivalId = arrivalAirport.id " +
                   $"Where departureAirport.airportName = '{departureAirport}' And arrivalAirport.airportName = '{arrivalAirport}';";

                flights = sqlProcess.GetFlights(query);
                foreach (var item in flights)
                {
                    flight = item.ToString().Split(',');

                    panel = new Panel();
                    button = new Button();
                    flight[0] = flight[0].Substring(1);
                    flight[2] = flight[2].Trim();
                    flight[3] = flight[3].Trim();
                    button.Text = flight[0] + " <=====>" + flight[1] + "\n\n" + flight[2].Trim().Substring(flight[2].IndexOf(" ") + 1, 5) + "<===>" + flight[3].Trim().Substring(flight[3].IndexOf(" ") + 1, 5);
                    button.Size = new Size(600, 120);
                    button.BackColor = Color.Silver;
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
