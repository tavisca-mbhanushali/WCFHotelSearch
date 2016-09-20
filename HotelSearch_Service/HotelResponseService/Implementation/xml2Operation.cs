using HotelResponseService.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using XmlToClass;

namespace HotelResponseService.Implementation
{
    public class xml2Operation
    {

        public static Response2 GetHotels2()
        {
            Response2 r2 = new Response2();
            XmlSerializer serializer = new XmlSerializer(typeof(HotelListResponse));

            StreamReader file = new StreamReader(@"C:\Users\mbhanushali\Desktop\HOBMAN_XML\Data\xml2.xml");
            var test2 = (HotelListResponse)serializer.Deserialize(file);
           
            List<SecondResponse> listsecond = new List<SecondResponse>();
            foreach (var x in test2.HotelList.HotelSummary)
            {
                SecondResponse secondresponse = new SecondResponse();
               
                secondresponse.hotelId = x.hotelId.ToString();
                secondresponse.name = x.name;
                secondresponse.location = x.city;
                secondresponse.bestValue = x.lowRate.ToString();
           
                listsecond.Add(secondresponse);

            }



            r2.ListofHotels2 = listsecond;














           // List<HotelListResponse> list2 = new List<HotelListResponse>();
           // foreach (var x in test2.HotelList.HotelSummary)
           // {
           //     HotelListResponse second = new HotelListResponse();
                
                
           //     list2.Add(second);
           // }
           //List<HotelResponse> nmn = 
            
           // foreach(var x in nmn)
            

           //  var c= x.HotelList.HotelSummary[0].address1;


           // }
           // //  r2.ListofHotels2 = list2;
            return r2;
        }



    }
}


//HotelListResponse second = new HotelListResponse();