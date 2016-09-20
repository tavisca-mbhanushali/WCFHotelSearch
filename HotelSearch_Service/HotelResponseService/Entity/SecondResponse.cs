using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelResponseService.Entity
{

    [DataContract]
    public class SecondResponse
    {

       
            [DataMember]
            public string location { get; set; }
            [DataMember]
            public string NumOfRoom { get; set; }
            [DataMember]
            public string RoomTypes { get; set; }
            [DataMember]
            public string bestValue { get; set; }
            [DataMember]
            public string minAverPrice { get; set; }
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public string hotelId { get; set; }




        }

    }
