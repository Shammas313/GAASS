using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABCSales.TravelAwayDAL;
using ABCSales.TravelAwayWebApiCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABCSales.TravelAwayWebApiCore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookingController : Controller
    {
        TravelAwayRepository repos = new TravelAwayDAL.TravelAwayRepository();

        [HttpPost]
        public JsonResult AddBooking(Booking booking)
        {
            int result = 0;
            //Boolean status = false;
            try
            {
                result = repos.AddBookingUsingUSP(booking.EmailId,booking.PackageId, booking.Place, booking.ContactNo,
                    booking.ResidentialAddress, (DateTime)booking.DateOfTravel, booking.Adults, booking.Children,booking.BookingStatus);

            }
            catch (Exception)
            {

                result = -99;
            }
            return Json(result);
        }
       [HttpGet]
       public JsonResult GetBooking(string emailId)
        {
            List<TravelAwayDAL.Models.Booking> booking = new List<TravelAwayDAL.Models.Booking>();
            try
            {
                booking = repos.GetBookings(emailId);
            }
            catch (Exception)
            {

                booking = null;
            }
            return Json(booking);
        }
    }
}
