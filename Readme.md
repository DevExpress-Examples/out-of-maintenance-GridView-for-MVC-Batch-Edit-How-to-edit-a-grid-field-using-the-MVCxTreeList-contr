<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/254660929/19.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T879467)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# GridView for MVC - Batch Edit - How to edit a grid field using the MVCxTreeList located inside MVCxDropDownEdit
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/254660929/)**
<!-- run online end -->

This example illustrates how to:
- Replace the default column editor with the MVCxDropDownEdit control and put the MVCxTreeList control into the dropdown window template;
- Implement client-side logic to bind the MVCxDropDownEdit control value depending on selection in the MVCxTreeList control;
- Implement custom batch editing to correlate the value of a grid cell with the value of the template editor correctly;
- Implement server-side logic to select MVCxTreeList nodes depending on the grid field value.


<!-- default file list --> 
*Files to look at*:

* [HomeController.cs](./CS/WebApplication1/Controllers/HomeController.cs)(VB: [HomeController.vb](./VB/WebApplication1/Controllers/HomeController.vb))
* [_GridViewPartial.cshtml](./CS/WebApplication1/Views/Home/_GridViewPartial.cshtml)(VB: [_GridViewPartial.vbhtml](./VB/WebApplication1/Views/Home/_GridViewPartial.vbhtml))
* [_TreeListPartial.cshtml](./CS/WebApplication1/Views/Home/_TreeListPartial.cshtml)(VB: [_TreeListPartial.vbhtml](./VB/WebApplication1/Views/Home/_TreeListPartial.vbhtml))
* [BatchEditScripts.js](./CS/WebApplication1/Scripts/CustomScripts/BatchEditScripts.js)
* [ValueAndDisplayTextHelper.cs](./CS/WebApplication1/Code/ValueAndDisplayTextHelper.cs)(VB: [ValueAndDisplayTextHelper.vb](./VB/WebApplication1/Code/ValueAndDisplayTextHelper.vb))

<!-- default file list end -->
