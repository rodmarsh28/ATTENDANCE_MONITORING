Imports System.IO
Public Class frmReportViewer
    Dim picbyte As Byte()
    Dim dgv As DataGridView
    Dim stream As New MemoryStream()
    '    Private Function ImageToStream(ByVal fileName As String) As Byte()

    'tryagain:
    '        Try
    '            Dim image As New Bitmap(fileName)
    '            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
    '        Catch ex As Exception
    '            GoTo tryagain
    '        End Try

    '        Return stream.ToArray()
    '    End Function
   
   
   
    Sub print_attendance_summary()
        Dim get_attendance As New Attendance
        get_attendance.datefrom = dfrom.Value
        get_attendance.dateto = dto.Value
        get_attendance.departmentID = "1"
        get_attendance.get_attendance_summary()
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New Attendance_Record_Summary
        rptDoc.SetDataSource(get_attendance.dsx)
        rptDoc.SetParameterValue("Preparedby", "Devine")
        CrystalReportViewer1.ReportSource = rptDoc
    End Sub
    Sub print_BreaktimeLate_record_summary()
        Dim get_attendance As New Attendance
        get_attendance.datefrom = dfrom.Value
        get_attendance.dateto = dto.Value
        get_attendance.departmentID = "1"
        get_attendance.get_Breaktime_Late_summary()
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New Breaktime_Record_Summary
        rptDoc.SetDataSource(get_attendance.dsx)
        rptDoc.SetParameterValue("Preparedby", "Devine")
        CrystalReportViewer1.ReportSource = rptDoc
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbGrouping.Text = "" Then
            MsgBox("Please Select Data Grouping", MsgBoxStyle.Critical)
        Else
            If lbltypeOfReport.Text = "Attendance Record Summary" Then
                print_attendance_summary()
            ElseIf lbltypeOfReport.Text = "Breaktime Late Record Summary" Then
                print_BreaktimeLate_record_summary()
            End If

        End If
    End Sub
   

    Private Sub frmReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class