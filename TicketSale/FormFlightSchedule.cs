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
        public FormFlightSchedule(string _departureAirport, string _arrivalAirport)
        {
            InitializeComponent();
            departureAirport = _departureAirport;
            arrivalAirport = _arrivalAirport;
        }
        string departureAirport, arrivalAirport;

        private void FormFlightSchedule_Load(object sender, EventArgs e)
        {
            try 
            {

            } 
            catch 
            { 
                
            }            
        } 
    }
}
