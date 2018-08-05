using SchoolBusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRepositoryLayer
{
    public class GetBusDetails : IGetBusDetails
    {
        public List<BusDetails> getBusDetails()
        {
            List<BusDetails> busList = new List<BusDetails>();

            try
            { 
            
            busList.Add(new BusDetails() { busRegNo = "AS 01 D 7058", busType = "Tempo", busSeats = 12, color = "yellow", chasisDetails = "D180301" });
            busList.Add(new BusDetails() { busRegNo = "AS 01 D 7078", busType = "Tempo", busSeats = 12, color = "yellow", chasisDetails = "D180301" });
            busList.Add(new BusDetails() { busRegNo = "AS 01 D 7784", busType = "Tempo", busSeats = 12, color = "yellow", chasisDetails = "D180301" });
            busList.Add(new BusDetails() { busRegNo = "AS 01 D 7214", busType = "Tempo", busSeats = 12, color = "yellow", chasisDetails = "D180301" });
            busList.Add(new BusDetails() { busRegNo = "AS 01 D 6478", busType = "Tempo", busSeats = 12, color = "yellow", chasisDetails = "D180301" });
            busList.Add(new BusDetails() { busRegNo = "AS 01 D 3145", busType = "Tempo", busSeats = 12, color = "yellow", chasisDetails = "D180301" });
            busList.Add(new BusDetails() { busRegNo = "AS 01 D 8124", busType = "Tempo", busSeats = 12, color = "yellow", chasisDetails = "D180301" });

            
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return busList;

            }




    }
}
