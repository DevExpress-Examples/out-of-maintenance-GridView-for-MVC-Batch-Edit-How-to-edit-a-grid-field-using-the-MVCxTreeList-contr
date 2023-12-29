# GridView for MVC - Batch Edit - How to edit a grid field using the MVCxTreeList located inside MVCxDropDownEdit

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
