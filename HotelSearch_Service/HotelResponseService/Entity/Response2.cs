using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelResponseService.Entity
{
    public class Response2
    {
        [DataMember]
        public List<SecondResponse> ListofHotels2 = new List<SecondResponse>();


    }
}