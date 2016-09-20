using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelResponseService;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetHotelsTest()
        {
            HotelResponse hotelresponse = new HotelResponse();
            var result = hotelresponse.GetHotels();

          var hotelid =result.ListofHotels2[0].hotelId;
            Assert.IsNotNull(hotelid); 
            Assert.IsNotNull(result);
        }
    }
}
