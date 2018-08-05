using FlightCodingTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelRepublic
{
    class FlightClassExtended 
    {
        private FlightBuilder fb;

        public FlightClassExtended()
        {
            fb = new FlightBuilder();
        }


        public List<Segment> DepartsBeforeCurrentDate()
        {
            var listOfFlights = fb.GetFlights();
            
            List<Segment> list = new List<Segment>();          

            foreach (Flight f in listOfFlights)
            {


                    f.Segments.Where(r => r.DepartureDate < DateTime.Now)
                

            }



            return list;

        }

        //public Flight ArrivalDateBeforeDepart()
        //{

        //}

        //public Flight SpendTwoHoursGroundTime()
        //{
            
        //}

    }

    class Program
    {


        static void Main(string[] args)
        {

            FlightBuilder fb = new FlightBuilder();

            int count = 1;

            var listOfFlights = fb.GetFlights();
            foreach(Flight f in listOfFlights)
            {
                Console.WriteLine("For Flight indexed" + count);
                foreach(Segment sg in f.Segments)
                {
                    Console.WriteLine("For the segment Arrival date = " + sg.ArrivalDate + " Departure Date " + sg.DepartureDate);

                }

                count = count + 1;
             }

            FlightClassExtended fextnd = new FlightClassExtended();
            fextnd.DepartsBeforeCurrentDate();

            Console.ReadLine();



        }
    }
}
