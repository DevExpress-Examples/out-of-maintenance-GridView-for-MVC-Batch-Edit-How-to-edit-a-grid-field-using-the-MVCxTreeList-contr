@Imports WebApplication1.Models
@ModelType List(Of License)

@Html.DevExpress().TreeList(Sub(settings)
                                     settings.Name = "TreeList1"
                                     settings.KeyFieldName = "LicenseID"
                                     settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "TreeListPartial"}
                                     settings.CustomActionRouteValues = New With {Key .Controller = "Home", Key .Action = "TreeListCustomPartial"}
                                     settings.Columns.Add("LicenseName", MVCxTreeListColumnType.TextBox)
                                     settings.Columns.Add("LicenseID", MVCxTreeListColumnType.TextBox)
                                     settings.ParentFieldName = "ParentLicenseID"
                                     settings.Width = New Unit(99, UnitType.Percentage)
                                     settings.SettingsSelection.Enabled = True
                                     settings.SettingsSelection.AllowSelectAll = True
                                     settings.ClientSideEvents.EndCallback = "OnTreeListEndCallback"
                                     settings.BeforeGetCallbackResult = Sub(sender, e)
                                                                            Dim tl As MVCxTreeList = TryCast(sender, MVCxTreeList)
                                                                            If ViewBag.Selection IsNot Nothing Then
                                                                                tl.UnselectAll()
                                                                                If ViewBag.Selection <> String.Empty Then
                                                                                    Dim textsString As String = ViewBag.Selection
                                                                                    Dim texts = textsString.Split(","c)
                                                                                    Dim nodesText As New List(Of String)()
                                                                                    Dim nodesValues As New List(Of String)()
                                                                                    For Each textString In texts
                                                                                        tl.FindNodesByFieldValue("LicenseName", textString).ForEach(Sub(node)
                                                                                                                                                        If Not node.Selected Then
                                                                                                                                                            node.Selected = True
                                                                                                                                                            nodesText.Add(node.GetValue("LicenseName").ToString())
                                                                                                                                                            nodesValues.Add(node.GetValue("LicenseID").ToString())
                                                                                                                                                        End If
                                                                                                                                                    End Sub)
                                                                                    Next textString
                                                                                    tl.JSProperties.Add("cp_selectedValues", nodesValues)
                                                                                    tl.JSProperties.Add("cp_selectedTexts", nodesText)
                                                                                End If
                                                                            End If
                                                                        End Sub
                                 End Sub).Bind(Model).GetHtml()
