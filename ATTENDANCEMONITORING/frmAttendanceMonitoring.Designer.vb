<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendanceMonitoring
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportAttendanceLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentOnDutyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceSummaryOfficeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LateTardenessReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimetablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidayListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.SetupToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1168, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountManagerToolStripMenuItem, Me.ImportAttendanceLogsToolStripMenuItem, Me.ImportDatabaseToolStripMenuItem, Me.ExportDatabaseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AccountManagerToolStripMenuItem
        '
        Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
        Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AccountManagerToolStripMenuItem.Text = "Account Manager"
        '
        'ImportAttendanceLogsToolStripMenuItem
        '
        Me.ImportAttendanceLogsToolStripMenuItem.Name = "ImportAttendanceLogsToolStripMenuItem"
        Me.ImportAttendanceLogsToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ImportAttendanceLogsToolStripMenuItem.Text = "Import Attendance Logs"
        '
        'ImportDatabaseToolStripMenuItem
        '
        Me.ImportDatabaseToolStripMenuItem.Name = "ImportDatabaseToolStripMenuItem"
        Me.ImportDatabaseToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ImportDatabaseToolStripMenuItem.Text = "Import Database"
        '
        'ExportDatabaseToolStripMenuItem
        '
        Me.ExportDatabaseToolStripMenuItem.Name = "ExportDatabaseToolStripMenuItem"
        Me.ExportDatabaseToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ExportDatabaseToolStripMenuItem.Text = "Export Database"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentOnDutyToolStripMenuItem, Me.AttendanceSummaryOfficeToolStripMenuItem, Me.AttendanceSummaryToolStripMenuItem, Me.LateTardenessReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'CurrentOnDutyToolStripMenuItem
        '
        Me.CurrentOnDutyToolStripMenuItem.Name = "CurrentOnDutyToolStripMenuItem"
        Me.CurrentOnDutyToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.CurrentOnDutyToolStripMenuItem.Text = "Current On duty"
        '
        'AttendanceSummaryOfficeToolStripMenuItem
        '
        Me.AttendanceSummaryOfficeToolStripMenuItem.Name = "AttendanceSummaryOfficeToolStripMenuItem"
        Me.AttendanceSummaryOfficeToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.AttendanceSummaryOfficeToolStripMenuItem.Text = "Attendance Summary Office"
        '
        'AttendanceSummaryToolStripMenuItem
        '
        Me.AttendanceSummaryToolStripMenuItem.Name = "AttendanceSummaryToolStripMenuItem"
        Me.AttendanceSummaryToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.AttendanceSummaryToolStripMenuItem.Text = "Attendance Summary Production"
        '
        'LateTardenessReportToolStripMenuItem
        '
        Me.LateTardenessReportToolStripMenuItem.Name = "LateTardenessReportToolStripMenuItem"
        Me.LateTardenessReportToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.LateTardenessReportToolStripMenuItem.Text = "Absent and Tardiness Report"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimetablesToolStripMenuItem, Me.HolidayListToolStripMenuItem, Me.DatabaseConnectionToolStripMenuItem})
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'TimetablesToolStripMenuItem
        '
        Me.TimetablesToolStripMenuItem.Name = "TimetablesToolStripMenuItem"
        Me.TimetablesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TimetablesToolStripMenuItem.Text = "Timetables"
        '
        'HolidayListToolStripMenuItem
        '
        Me.HolidayListToolStripMenuItem.Name = "HolidayListToolStripMenuItem"
        Me.HolidayListToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.HolidayListToolStripMenuItem.Text = "Holiday List"
        '
        'DatabaseConnectionToolStripMenuItem
        '
        Me.DatabaseConnectionToolStripMenuItem.Name = "DatabaseConnectionToolStripMenuItem"
        Me.DatabaseConnectionToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.DatabaseConnectionToolStripMenuItem.Text = "Database Connection"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmAttendanceMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 680)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAttendanceMonitoring"
        Me.Text = "Attendance Monitoring"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportAttendanceLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentOnDutyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceSummaryOfficeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LateTardenessReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimetablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidayListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
