using HotelResponseService.Entity;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HotelResponseService
{
    [DataContract]
    public class Response
    {
       [DataMember]
        public List<FirstResponse> ListofHotels = new List<FirstResponse>();

        [DataMember]
        public List<SecondResponse> ListofHotels2 = new List<SecondResponse>();
    }

}



