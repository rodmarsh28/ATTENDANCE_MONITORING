Imports System.Data.SqlClient

Public Class Attendance
    Public datefrom As DateTime
    Public dateto As DateTime
    Public departmentID As String
    Public dsx As New Attendace_DS
    Public sunday As Integer
    Public dfrom As DateTime
    Public dto As DateTime
    Public dir As String
    Public rowCount As Integer

    Public biono As Integer
    Public checktime As DateTime
    Public checktype As String

    Sub get_attendance_summary()
        Try
            count_sundays()
            checkConn()
            Dim cmd As New SqlCommand("GET_ATTENDANCE_SUMMARY", conn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = Format(datefrom, "yyyy/MM/dd")
                .Parameters.AddWithValue("@dateto", SqlDbType.VarChar).Value = Format(dateto, "yyyy/MM/dd")
                .Parameters.AddWithValue("@departmentID", SqlDbType.VarChar).Value = departmentID
                .Parameters.AddWithValue("@sundaysCount", SqlDbType.VarChar).Value = sunday
            End With
            Dim da As New SqlDataAdapter(cmd)
            da.SelectCommand = cmd
            da.Fill(dsx, "Attendance_Record_Summary")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Sub get_Breaktime_Late_summary()
        Try
            checkConn()
            Dim cmd As New SqlCommand("GET_BREAKTIME_LATE_SUMMARY", conn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@datefrom", SqlDbType.VarChar).Value = Format(datefrom, "yyyy/MM/dd")
                .Parameters.AddWithValue("@dateto", SqlDbType.VarChar).Value = Format(dateto, "yyyy/MM/dd")
                .Parameters.AddWithValue("@departmentID", SqlDbType.VarChar).Value = departmentID
            End With
            Dim da As New SqlDataAdapter(cmd)
            da.SelectCommand = cmd
            da.Fill(dsx, "Breaktime_Late_Summary")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Sub count_sundays()
        sunday = 0
        Dim totalday As Integer = dateto.Day - datefrom.Day
        Dim i As Integer = 0
        Dim dates As DateTime = datefrom
        While i <= totalday
            i = i + 1
            If dates.DayOfWeek = DayOfWeek.Sunday Then
                sunday = sunday + 1
            End If
            dates = DateAdd(DateInterval.Day, 1, dates)
        End While
    End Sub

    Sub Load_Attendance_logs()
        Dim c As Integer = 0
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                accConnectDatabase()
            End If
            Dim cmd As New SqlCommand("select userinfo.badgenumber,checkinout.checktime,checkinout.checktype from userinfo " & _
                                    "inner join checkinout on checkinout.userid = userinfo.userid " & _
                                    " where format(checkinout.checktime,'yyyy/mm/dd') between '" & Format(dfrom, "yyyy/MM/dd") & "' and '" & Format(dto, "yyyy/MM/dd") & "' " & _
                                    "ORDER BY checkinout.checktime ", conn)

            Dim da As New SqlDataAdapter(cmd)
            da.SelectCommand = cmd
            da.Fill(dsx, "importLogsData")
            rowCount = dsx.Tables("importLogsData").Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Sub importLogs()
        Try
            checkConn()
            Dim cmd As New SqlCommand("importLogs", conn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@biono", SqlDbType.Int).Value = biono
                .Parameters.AddWithValue("@checktime", SqlDbType.VarChar).Value = checktime
                .Parameters.AddWithValue("@checktype", SqlDbType.VarChar).Value = checktype
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
