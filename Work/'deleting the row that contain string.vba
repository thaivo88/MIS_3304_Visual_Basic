Sub Deletion_Total_Attendance_table()

'deleting the row that contain 'totals'

Dim ws As Worksheet
Dim rng1 As Range
Set ws = Sheets("Raw Data")
Set rng1 = ws.Range(ws.[B2], ws.Cells(Rows.Count, "B").End(xlUp))
Application.ScreenUpdating = False
With ActiveSheet
        .AutoFilterMode = False
        rng1.AutoFilter Field:=1, Criteria1:="Totals"
        rng1.Offset(1, 0).EntireRow.Delete
        .AutoFilterMode = False
    End With
Application.ScreenUpdating = True
End Sub
