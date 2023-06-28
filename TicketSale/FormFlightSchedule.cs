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
        int adult = 0, youth = 0, child = 0, flightsCount = 0;
        List<Tuple<string, string, DateTime, DateTime, int>> flights = new List<Tuple<string, string, DateTime, DateTime, int>>();
        Panel panel;
        Label labelDepartureTime, labelArrivalTime, labelFlightTime, labelPrice;
        PictureBox pictureBox;


        private void FormFlightSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                //******************************************************* veri tabanından uçuşları çektim düzgün formatta flowlayoutpanel'a ekle*********************************************************************************

                query = "Select departureAirport.airportName As departureAirportName, arrivalAirport.airportName As arrivalAirportName, departureTime, arrivalTime, passengerCapacity, price From Table_Flights " +
                    "Inner Join Table_Airport As departureAirport On Table_Flights.departureId = departureAirport.id " +
                    "Inner Join Table_Airport As arrivalAirport On Table_Flights.arrivalId = arrivalAirport.id " +
                   $"Where departureAirport.airportName = '{departureAirport}' And arrivalAirport.airportName = '{arrivalAirport}';";

                flights = sqlProcess.GetFlights(query);
                foreach (var item in flights)
                {
                    flightsCount++;
                    flight = item.ToString().Split(',');

                    panel = new Panel();
                    labelDepartureTime = new Label();
                    labelArrivalTime = new Label();
                    labelFlightTime = new Label();
                    labelPrice = new Label();
                    pictureBox = new PictureBox();

                    flight[0] = flight[0].Substring(1); // kalkış havaalanı
                    // flight[1] -> varış havaalanı
                    flight[2] = flight[2].Trim(); // kalkış saati
                    flight[3] = flight[3].Trim(); // iniş saati
                    //flight[5] = flight[5].ToString().Trim();

                    labelDepartureTime.Text = flight[2].Trim().Substring(flight[2].IndexOf(" ") + 1, 5);
                    labelArrivalTime.Text = flight[3].Trim().Substring(flight[3].IndexOf(" ") + 1, 5);
                    labelFlightTime.Text = "DİREKT, 0S 55DK";
                    labelPrice.Text = "₺440";//+ flight[5];

                    labelDepartureTime.ForeColor = SystemColors.ActiveCaption;
                    labelArrivalTime.ForeColor = SystemColors.ActiveCaption;
                    labelPrice.ForeColor = SystemColors.ActiveCaption;
                    labelFlightTime.ForeColor = SystemColors.AppWorkspace;

                    labelDepartureTime.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                    labelArrivalTime.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                    labelPrice.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));

                    labelDepartureTime.Location = new Point(28, 23);
                    labelArrivalTime.Location = new Point(215, 23);
                    labelFlightTime.Location = new Point(33, 66);
                    labelPrice.Location = new Point(354, 38);

                    labelDepartureTime.Size = new Size(71, 29);
                    labelArrivalTime.Size = new Size(71, 29);
                    labelPrice.Size = new Size(109, 33);
                    labelFlightTime.Size = new Size(144, 18);

                    pictureBox.Image = global::TicketSale.Properties.Resources.point_to_point;
                    pictureBox.Location = new Point(110, 27);
                    pictureBox.Size = new Size(99, 22);

                    panel.Controls.Add(labelDepartureTime);
                    panel.Controls.Add(labelArrivalTime);
                    panel.Controls.Add(labelFlightTime);
                    panel.Controls.Add(labelPrice);
                    panel.Controls.Add(pictureBox);
                    panel.Size = new Size(480, 116);
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    flowLayoutPanel1.Controls.Add(panel);
                }
                if (flightsCount > 3)
                    Width = flowLayoutPanel1.Width + 30;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Schedule Load Hatası");
            }
        }
    }
}
