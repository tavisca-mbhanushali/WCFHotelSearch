using System;
using HotelResponseService.Implementation;
using System.Threading.Tasks;
using System.Threading;
using HotelResponseService.Entity;

namespace HotelResponseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HotelResponse : IHotelResponse
    {
        public Response GetHotels()
        {
            Response r = new Response();
            
            Thread.Sleep(3000);
            Task<Response> Task1 = new Task<Response>(() => XmlOperation.GetHotels());
            Task1.Start();
            Thread.Sleep(3000);
            Task<Response2> Task2 = new Task<Response2>(() => xml2Operation.GetHotels2());
            Task2.Start();
            var result = Task1.Result;
            if (Task1.IsCompleted && !Task1.IsFaulted)
                r.ListofHotels = result.ListofHotels;          
            var output = Task2.Result;
            if (Task2.IsCompleted && !Task2.IsFaulted)
            r.ListofHotels2 = output.ListofHotels2;
            return r;
        }

        public Response2 GetHotels2()
        {
            Response2 rs = new Response2();
            rs = xml2Operation.GetHotels2();
            return rs;

        }
    }
}
