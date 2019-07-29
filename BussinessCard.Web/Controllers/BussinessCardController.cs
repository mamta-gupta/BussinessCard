using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessCard.Web.Models;

namespace BussinessCard.Web.Controllers
{
    public class BussinessCardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: BussinessCard
        public JsonResult GetContacts(string sort, int page, int rows, string searchString)
        {
            //#2 Setting Paging  
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            var results = new UserContactsViewModel();
            results.ContactDetails.Add(new UserContactViewModel()
            {
                FirstName = "ABC",
                LastName = "XYZ",
                EmailId = "test@gmail.com",
                MobileNumber = "9777723232"
            });

            results.ContactDetails.Add(new UserContactViewModel()
            {
                FirstName = "ABC1",
                LastName = "XYZ1",
                EmailId = "test1@gmail.com",
                MobileNumber = "9777723233"
            });



            //#4 Get Total Row Count  
            int totalRecords = results.ContactDetails.Count;
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            //#5 Setting Sorting  
            if (sort.ToUpper() == "DESC")
            {
                results.ContactDetails = results.ContactDetails.OrderByDescending(s => s.Id).ToList();
                results.ContactDetails = results.ContactDetails.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            }
            else
            {
                results.ContactDetails = results.ContactDetails.OrderBy(s => s.Id).ToList();
                results.ContactDetails = results.ContactDetails.Skip(pageIndex * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
            //#6 Setting Search  
            if (!string.IsNullOrEmpty(searchString))
            {
                results.ContactDetails = results.ContactDetails.Where(m => m.AlternateMobileNumber == searchString).ToList();
            }
            //#7 Sending Json Object to View.  
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = results
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}