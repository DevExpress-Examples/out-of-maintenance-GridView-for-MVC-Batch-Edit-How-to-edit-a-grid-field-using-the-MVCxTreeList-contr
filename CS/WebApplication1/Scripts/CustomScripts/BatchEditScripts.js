var templateColumnFieldName = "Licenses";

function OnDropDownEditQueryClose(s, e) {
    TreeList1.GetSelectedNodeValues("LicenseID;LicenseName", OnGetValuesCallbackEnd);
}
function OnConfirmBtnClick(s, e) {
    DropDownEdit1.HideDropDown();
}
var valueString;
var textString;
function OnGetValuesCallbackEnd(values) {
    valueString = null;
    textString = null;
    if (values != null && values.length > 0) {
        valueString = GetTextByArray(values, 0);
        textString = GetTextByArray(values, 1);
    }
    GridView1.batchEditApi.EndEdit();
}
function GetTextByArray(values, dimension) {
    let resString = values[0][dimension];
    values.forEach(function (value, index) {
        if (index == 0) return;
        resString += "," + value[dimension];
    });
    return resString;
}
function OnBatchEditEndEditing(s, e) {
    let editingCell = s.batchEditApi.GetEditCellInfo();
    if (editingCell.column != null && editingCell.column.fieldName == templateColumnFieldName) {
        e.rowValues[editingCell.column.index].value = valueString;
        e.rowValues[editingCell.column.index].text = textString;
    }
}
function OnBatchEditStartEditing(s, e) {    
    if (e.focusedColumn.fieldName != templateColumnFieldName) return;
    textString = e.itemValues[e.focusedColumn.index].text == "&nbsp;" ? "" : e.itemValues[e.focusedColumn.index].text;
    valueString = e.itemValues[e.focusedColumn.index].value;    
    DropDownEdit1.SetValue(textString);
}
function OnTreeListEndCallback(s, e) {
    if (e.command != "CustomCallback") return;
    updateText();
}

function updateText() {
    DropDownEdit1.SetText(TreeList1.cp_selectedTexts);
}
function synchronizeTreeListValues(s, e) {
    var texts = s.GetText();
    TreeList1.PerformCallback({ textsString: texts });
}

