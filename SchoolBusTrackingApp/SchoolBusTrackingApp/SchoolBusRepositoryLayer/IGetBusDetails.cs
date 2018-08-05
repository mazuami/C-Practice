using SchoolBusModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRepositoryLayer
{
   public interface IGetBusDetails
    {
         List<BusDetails> getBusDetails();
    }
}
