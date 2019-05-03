Public Class frmAttendanceMonitoring

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ImportAttendanceLogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportAttendanceLogsToolStripMenuItem.Click
        importAttendanceLogs.ShowDialog()
    End Sub

    Private Sub DatabaseConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseConnectionToolStripMenuItem.Click
        frmDatabaseSettings.ShowDialog()
    End Sub
End Class
