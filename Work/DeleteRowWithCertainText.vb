Sub DeleteRowNoInclude()

'selete the range of the table
'input the text you would like to delete the whole row

Dim xRow As Range
Dim rng As Range
Dim WorkRng As Range
Dim xStr As String
On Error Resume Next
xTitleId = "KutoolsforExcel"
Set WorkRng = Application.Selection
Set WorkRng = Application.InputBox("Range", xTitleId, WorkRng.Address, Type:=8)
xStr = Application.InputBox("Text", xTitleId, "", Type:=2)
Application.ScreenUpdating = False
For i = WorkRng.Rows.Count To 1 Step -1
    Set xRow = WorkRng.Rows(i)
    Set rng = xRow.Find(xStr, LookIn:=xlValues)
    If rng Is Nothing Then
       xRow.Delete
    End If
Next
Application.ScreenUpdating = True
End Sub
