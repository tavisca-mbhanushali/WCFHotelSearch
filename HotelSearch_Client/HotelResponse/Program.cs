using HotelResponseClientt.HotelServiceClientReference;

using System;

namespace HotelResponse
{
    class Program
    {
        static void Main(string[] args)
        {

            HotelResponseClientt.HotelServiceClientReference.HotelResponseClient client = new HotelResponseClientt.HotelServiceClientReference.HotelResponseClient();
            Response res = client.GetHotels();
            Response2 res2 = client.GetHotels2();
            var list1 = res.ListofHotels;
            var list2 = res2.ListofHotels2;
            //HotelResponseService.HotelResponseClient client = new HotelResponseService.HotelResponseClient();
            //HotelResponseService.Response res = new HotelResponseService.Response();
            //res= client.GetHotels();

            foreach(var x in list1)
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Hotel Id  = {0}",x.hotelId);
                Console.WriteLine("Hotel name  = {0}", x.name);
                Console.WriteLine("Hotel Location = {0}", x.location);
                Console.WriteLine("No. Of Rooms = {0} ", x.NumOfRoom);
                Console.WriteLine("No. Of RoomTypes = {0} ", x.RoomTypes);
                Console.WriteLine("------------------------------------------------------------------");
           
            }

            Console.ReadKey();

            HotelResponseClientt.HotelServiceClientReference.HotelResponseClient client2 = new HotelResponseClientt.HotelServiceClientReference.HotelResponseClient();
         //   Response res2 = client2.GetHotels2();

            foreach(var y in list2)
            {

                Console.WriteLine("*******************************************************************");
                Console.WriteLine("Hotel Id  = {0}", y.hotelId);
                Console.WriteLine("Hotel name  = {0}", y.name);
                Console.WriteLine("Hotel Location = {0}", y.location);
                Console.WriteLine("No. Of Rooms = {0} ", y.NumOfRoom);
                Console.WriteLine("No. Of RoomTypes = {0} ", y.RoomTypes);
                Console.WriteLine("********************************************************************");
            }

            Console.ReadKey();

        }
    }
}
