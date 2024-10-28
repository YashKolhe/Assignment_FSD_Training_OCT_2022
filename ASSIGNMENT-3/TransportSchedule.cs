using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_3_ASSIGNMENT.ASSIGNMENT_3
{
    internal class TransportSchedule
    {
        public string TransportType { get; set; }
        public string Route { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public int SeatsAvailable { get; set; }

        public override string ToString()
        {
            return $"Transport Type: {TransportType}\t Route: {Route}\t Departure Time: {DepartureTime}\t Arrival Time: {ArrivalTime}\n Price: {Price}\t Seats Available: {SeatsAvailable}";
        }
    }
}
