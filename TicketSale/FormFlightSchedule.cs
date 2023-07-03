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
            totalPassenger = adult + youth + child;
        }

        SqlProcess sqlProcess = new SqlProcess();
        string departureAirport = null, arrivalAirport = null, query = null, departureDate = null, arrivalDate = null, flightTime = null;
        string[] flight;
        int adult = 0, youth = 0, child = 0, flightsCount = 0, flightId = -1, totalPassenger = 0, passengerCapacity = 0;
        List<Tuple<int, string, string, DateTime, DateTime, int, double>> flights = new List<Tuple<int, string, string, DateTime, DateTime, int, double>>();
        Panel panel;
        Label labelDepartureTime, labelArrivalTime, labelFlightTime, labelPrice;
        PictureBox pictureBox;
        FormPassengerInfo formPassengerInfo;
        

        private void FormFlightSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT Table_Flights.id, departureAirport.airportName AS departureAirportName, arrivalAirport.airportName AS arrivalAirportName, departureTime, arrivalTime, passengerCapacity, price FROM Table_Flights " +
                    "INNER JOIN Table_Airport AS departureAirport ON Table_Flights.departureId = departureAirport.id " +
                    "INNER JOIN Table_Airport AS arrivalAirport ON Table_Flights.arrivalId = arrivalAirport.id " +
                    $"WHERE departureAirport.airportName = '{departureAirport}' AND arrivalAirport.airportName = '{arrivalAirport}';";

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

                    flight[0] = flight[0].Substring(1); // id
                    flight[1] = flight[1].Trim(); // kalkış havaalanı
                    flight[2] = flight[2].Trim(); // varış havaalanı
                    flight[3] = flight[3].Trim(); // kalkış saati
                    flight[4] = flight[4].Trim(); // iniş saati
                    flight[5] = flight[5].Trim(); // yolcu kapasitesi
                    flight[6] = flight[6].ToString().Substring(0, flight[6].IndexOf(")")).Trim(); // bilet fiyatı

                    if (DateTime.Parse(flight[3]) < DateTime.Parse(flight[4]))
                        flightTime = (DateTime.Parse(flight[4]) - DateTime.Parse(flight[3])).ToString();
                    else
                        flightTime = ((DateTime.Parse("23:59:59") - DateTime.Parse(flight[3]).AddSeconds(-1)) + (DateTime.Parse(flight[4]) - DateTime.Parse("00:00:00"))).ToString();
                    flightTime = flightTime.Substring(0, flightTime.IndexOf(":")).Trim() + "S " + flightTime.Substring(flightTime.IndexOf(":") + 1, 2) + "DK";
                    if (flightTime[0] == '0')
                        flightTime = flightTime.Substring(1);
                    if ((flightTime[4] == '0' && flightTime[5] != 'D') || (flightTime[3] == '0' && flightTime[4] != 'D'))
                        flightTime = flightTime.Substring(0, flightTime.IndexOf("0") - 1) + " " + flightTime.Substring(flightTime.IndexOf('0') + 1);

                    // her uçuşun kapasitesi dictionary'e atanır


                    // label'lara değer atamaları yapılır
                    labelDepartureTime.Text = flight[3].Trim().Substring(flight[3].IndexOf(" ") + 1, 5);
                    labelArrivalTime.Text = flight[4].Trim().Substring(flight[4].IndexOf(" ") + 1, 5);
                    labelFlightTime.Text = "DİREKT, " + flightTime;
                    labelPrice.Text = "₺" + flight[6];

                    // label'ların renkleri düzenlenir
                    labelDepartureTime.ForeColor = SystemColors.ActiveCaption;
                    labelArrivalTime.ForeColor = SystemColors.ActiveCaption;
                    labelPrice.ForeColor = SystemColors.ActiveCaption;
                    labelFlightTime.ForeColor = SystemColors.AppWorkspace;

                    // label'ların fontları düzenlenir
                    labelDepartureTime.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                    labelArrivalTime.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                    labelPrice.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162)));

                    // label'ların konumları düzenlenir
                    labelDepartureTime.Location = new Point(28, 23);
                    labelArrivalTime.Location = new Point(215, 23);
                    labelFlightTime.Location = new Point(33, 66);
                    labelPrice.Location = new Point(354, 38);

                    // label'ların boyutları düzenlenir
                    labelDepartureTime.Size = new Size(71, 29);
                    labelArrivalTime.Size = new Size(71, 29);
                    labelPrice.Size = new Size(109, 33);
                    labelFlightTime.Size = new Size(184, 18);

                    // picturebox'a fotoğraf atanır ve konumu ile boyutu düzenlenir
                    pictureBox.Image = global::TicketSale.Properties.Resources.point_to_point;
                    pictureBox.Location = new Point(110, 27);
                    pictureBox.Size = new Size(99, 22);

                    //tool'ların tıklama olayları eklenir
                    labelArrivalTime.Click += new EventHandler(panel_Click);
                    labelDepartureTime.Click += new EventHandler(panel_Click);
                    labelFlightTime.Click += new EventHandler(panel_Click);
                    labelPrice.Click += new EventHandler(panel_Click);
                    pictureBox.Click += new EventHandler(panel_Click);
                    panel.Click += new EventHandler(panel_Click);

                    // uçuş id'si tool'ların tag değerine atanır hangi uçuşun seçildiği anlaşılır
                    labelArrivalTime.Tag = int.Parse(flight[0]);
                    labelDepartureTime.Tag = int.Parse(flight[0]);
                    labelFlightTime.Tag = int.Parse(flight[0]);
                    labelPrice.Tag = int.Parse(flight[0]);
                    pictureBox.Image.Tag = int.Parse(flight[0]);
                    panel.Tag = int.Parse(flight[0]);

                    // oluşturulan tool'lar flowlayoutpanel'a eklenir
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

        private void panel_Click(object sender, EventArgs e)
        {
            try
            {
                Panel panel = null;
                PictureBox pictureBox = null;
                Label label = null;

                // seçilen uçuşun hangi id
                if (sender.GetType() == typeof(Panel))
                {
                    panel = (Panel)sender;
                    flightId = int.Parse(panel.Tag.ToString());
                }
                else if (sender.GetType() == typeof(Label))
                {
                    label = (Label)sender;
                    flightId = int.Parse(label.Tag.ToString());
                }
                else if (sender.GetType() == typeof(PictureBox))
                {
                    pictureBox = (PictureBox)sender;
                    flightId = int.Parse(pictureBox.Tag.ToString());
                }

                // seçilen uçuşun yolcu kapasitesi alınır
                foreach(var item in flights)
                {
                    if (item.Item1 == flightId)
                        passengerCapacity = item.Item6;
                }

                Hide();
                formPassengerInfo = new FormPassengerInfo(int.Parse(panel.Tag.ToString()), totalPassenger, passengerCapacity);
                formPassengerInfo.ShowDialog();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Bilet Seçme Hatası");
            }
        }
    }
}
