using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_Project
{
    internal class FlightsAddition
    {
        private string FlightName {  get; set; }
        private string Source { get; set;}
        private string Destination { get; set; }
        private DateTime Date { get; set; }
        private int SeatNo { get; set; }

        public FlightsAddition()
        {

        }
        public FlightsAddition(string flightname, string source, string destination, DateTime date, int seatNo)
        {
            FlightName = flightname;
            Source = source;
            Destination = destination;
            Date = date;
            SeatNo = seatNo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
