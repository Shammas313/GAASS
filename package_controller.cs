using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABCSales.TravelAwayDAL;
using ABCSales.TravelAwayDAL.Models;
using ABCSales.TravelAwayWebApiCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABCSales.TravelAwayWebApiCore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PackageController : Controller
    {
        TravelAwayRepository repos = new TravelAwayDAL.TravelAwayRepository();


        [HttpGet]
        public JsonResult GetPackages()
        {
            List<TravelAwayDAL.Models.Package> OldPackage = new List<TravelAwayDAL.Models.Package>();
            try
            {
                OldPackage = repos.GetPackages();
            }
            catch (Exception)
            {

                OldPackage = null;
            }
            return Json(OldPackage);
        }

        [HttpGet]
        public JsonResult PackageCategory()
        {
            List<TravelAwayDAL.Models.PackageCategory> categoryList = new List<TravelAwayDAL.Models.PackageCategory>();
            try
            {
                categoryList = repos.GetPackageCategories();

            }
            catch (Exception)
            {

                categoryList = null;
            }
            return Json(categoryList);
        }
      [HttpGet]
      public JsonResult GetCostOfBooking(string categoryId,int bookingId)
        {
            int result = 0;
            try
            {
                result = repos.GetCostOfBooking( categoryId,  bookingId);
            }
            catch (Exception)
            {

                result = 0;
            }
            return Json(result);
        }
        [HttpGet]
        public JsonResult GenerateReportByCategory()
        {
            List<TravelAwayDAL.Models.ReportCategory> list = new List<ReportCategory>();

            try
            {
                list = repos.GenerateReportByCategory();
            }
            catch (Exception)
            {

                list = null;
            }
            return Json(list);
        }
        public JsonResult GenerateReportByMonth(int month)
        {
            List<ReportMonth> list = new List<ReportMonth>();
            try
            {
                list = repos.GenerateReportByMonth(month);
            }
            catch (Exception)
            {

                list = null;
            }
            return Json(list);
        }
        public JsonResult GenerateReportByPackageName()
        {
            List<ReportPackageName> list = new List<ReportPackageName>();
            try
            {
                list = repos.GenerateReportByPackageName();

            }
            catch (Exception)
            {

                list = null;
            }
            return Json(list);
        }
        [HttpPost]
        public JsonResult AddAccomodation(Accommodation acc)
        {
            bool status = false;
            TravelAwayDAL.Models.Accomodation newAcc = new TravelAwayDAL.Models.Accomodation();

            try
            {
                newAcc.AccomodationId = acc.AccomodationId;
                newAcc.BookingId = acc.BookingId;
                newAcc.City = acc.City;
                newAcc.EmailId = acc.EmailId;
                newAcc.HotelName = acc.HotelName;
                newAcc.HotelRating = acc.HotelRating;
                newAcc.NoOfRooms = acc.NoOfRooms;
                newAcc.RoomType = acc.RoomType;
                newAcc.EstimatedCost = acc.EstimatedCost;
                status = repos.AddAccomodation(newAcc);
            }
            catch (Exception)
            {

                status = false;
            }

            return Json(status);

        }
        [HttpGet]
        public JsonResult ConfirmPayment(int estimatedCost,int bookingId)
        {
            bool status = false;
            try
            {
                status = repos.ConfirmPayment( estimatedCost, bookingId);
            }
            catch (Exception)
            {

                status = false;
            }
            return Json(status);
        }
        public JsonResult getCostOfAccomodation(string roomType,int numberOfRooms,string hotelName,string hotelRating)
        {
            int result = 0;
            try
            {
                result = repos.getCostOfAccomodation(roomType, numberOfRooms, hotelName,hotelRating);
            }
            catch (Exception)
            {

                result = 0;
            }
            return Json(result);
        }



        [HttpPost]
        public JsonResult AddRating(Rating rating)
        {
            bool status = false;
            try
            {
                status = repos.AddRating(rating);
            }
            catch (Exception)
            {

                status = false;
            }
            return Json(status);
        }
        [HttpGet]
        public JsonResult  GetPackageDetailsByCatgeoryId(string categoryId)
         {
            TravelAwayDAL.Models.PackageCategory pkg=new TravelAwayDAL.Models.PackageCategory();
            TravelAwayWebApiCore.Models.PackageCategory obj = new TravelAwayWebApiCore.Models.PackageCategory();
            try 
              {  
                pkg=repos.GetPackageDetailsByCatgeoryId(categoryId);
                if(pkg!=null)
                {
                    obj.CategoryId = pkg.CategoryId;
                    obj.CategoryName = pkg.CategoryName;
                    obj.Description = pkg.Description;
                    obj.Price = pkg.Price;
                    obj.VisitDays = pkg.VisitDays;

                }
        
               }
           catch (Exception)
           {

               obj=null;
            }
            return Json(obj);
        }

    }
}
