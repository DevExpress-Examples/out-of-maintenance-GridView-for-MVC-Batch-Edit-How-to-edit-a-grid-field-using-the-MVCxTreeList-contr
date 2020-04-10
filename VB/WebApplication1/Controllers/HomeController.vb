Imports DevExpress.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports WebApplication1.Models

Namespace WebApplication1.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

        Public Function TreeListPartial() As ActionResult
            Return PartialView("_TreeListPartial", LicensesDataProvider.GetLicenses())
        End Function
        Public Function TreeListCustomPartial(ByVal textsString As String) As ActionResult
            ViewBag.Selection = textsString
            Return PartialView("_TreeListPartial", LicensesDataProvider.GetLicenses())
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView("_GridViewPartial", CustomersDataProvider.GetCustomers())
		End Function
		<HttpPost, ValidateInput(False)> _
		Public Function BatchUpdateRouteValuesPartial(ByVal updateValues As MVCxGridViewBatchUpdateValues(Of Customer, Object)) As ActionResult
			For Each customer In updateValues.Insert
				If updateValues.IsValid(customer) Then
					Try
						CustomersDataProvider.InsertCustomer(customer)
					Catch e As Exception
						updateValues.SetErrorText(customer, e.Message)
					End Try
				End If
			Next customer
			For Each customer In updateValues.Update
				If updateValues.IsValid(customer) Then
					Try
						CustomersDataProvider.UpdateCustomer(customer)
					Catch e As Exception
						updateValues.SetErrorText(customer, e.Message)
					End Try
				End If
			Next customer
			For Each customerID In updateValues.DeleteKeys
				Try
					CustomersDataProvider.DeleteCustomer(New Customer With {.CustomerID = CInt(Fix(customerID))})
				Catch e As Exception
					updateValues.SetErrorText(customerID, e.Message)
				End Try
			Next customerID
			Return GridViewPartial()
		End Function
	End Class
End Namespace