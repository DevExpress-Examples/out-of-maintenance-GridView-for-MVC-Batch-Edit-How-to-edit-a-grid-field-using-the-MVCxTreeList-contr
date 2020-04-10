using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult TreeListPartial() {
            return PartialView("_TreeListPartial", LicensesDataProvider.GetLicenses());
        }
        public ActionResult TreeListCustomPartial(string textsString) {
            ViewBag.Selection = textsString;
            return PartialView("_TreeListPartial", LicensesDataProvider.GetLicenses());
        }

        public ActionResult GridViewPartial() {
            return PartialView("_GridViewPartial", CustomersDataProvider.GetCustomers());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult BatchUpdateRouteValuesPartial(MVCxGridViewBatchUpdateValues<Customer, object> updateValues) {
            foreach (var customer in updateValues.Insert) {
                if (updateValues.IsValid(customer)) {
                    try {
                        CustomersDataProvider.InsertCustomer(customer);
                    }
                    catch (Exception e) {
                        updateValues.SetErrorText(customer, e.Message);
                    }
                }
            }
            foreach (var customer in updateValues.Update) {
                if (updateValues.IsValid(customer)) {
                    try {
                        CustomersDataProvider.UpdateCustomer(customer);
                    }
                    catch (Exception e) {
                        updateValues.SetErrorText(customer, e.Message);
                    }
                }
            }
            foreach (var customerID in updateValues.DeleteKeys) {
                try {
                    CustomersDataProvider.DeleteCustomer(new Customer { CustomerID = (int)customerID });
                }
                catch (Exception e) {
                    updateValues.SetErrorText(customerID, e.Message);
                }
            }
            return GridViewPartial();
        }
    }
}