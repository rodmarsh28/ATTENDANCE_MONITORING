Imports System.Data.OleDb

Public Class importAttendanceLogs


   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Microsoft Access Database(*.mdb)|*.mdb"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            txtDir.Text = OpenFileDialog1.FileName
            dir = txtDir.Text
            Dim at As New Attendance
            at.dfrom = dFrom.Value
            at.dto = dTo.Value
            at.Load_Attendance_logs()
            lblCount.Text = Format(at.rowCount, "N0")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to load this database file ?", MsgBoxStyle.YesNo, "Are you sure ?") = MsgBoxResult.Yes Then
            Dim at As Attendance
            For Each row As DataRow In at.dsx.Tables("importLogsData").Rows
                at.biono = row(0)
                at.checktime = row(1)
                at.checktype = row(2)
            Next
        End If
    End Sub
End Class