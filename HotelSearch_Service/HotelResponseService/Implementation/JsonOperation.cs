using HotelResponseService.Entity;
using Json1ToClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HotelResponseService.Implementation
{
    public class JsonOperation
    {

        public static Response2 GetHotels2()
        {
            Response2 r = new Response2();


            StreamReader r1 = new StreamReader(@"C:\Users\mbhanushali\Desktop\HOBMAN_XML\Data\json1.json");
            string json = r1.ReadToEnd();

            var test2 = JsonConvert.DeserializeObject<Rootobject>(json);

            List<Hotelsummary> list2 = new List<Hotelsummary>();

        
            foreach (var item in test2.HotelListResponse.HotelList.HotelSummary)
            {
                SecondResponse second = new SecondResponse();
                second.hotelId = item.hotelId.ToString();
                second.name = item.name;


                //second.location = item.location;
                //second.minAverPrice = item.minAverPrice.ToString();
                //second.NumOfRoom = item.NumOfRoom.ToString();
                //second.bestValue = item.bestValue.ToString();
                //list.Add(first);

                list2.Add(item);
                //Console.WriteLine(item);
            }

           return r ;
        }

    }
}