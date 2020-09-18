Public Class clsPrintReport
    Protected Friend Sub printRegForm(ByVal container, ByVal playerID)
        Dim report As New crApplicationForm
        Dim viewer As New frmReportViewer

        report = New crApplicationForm

        report.Refresh()
        report.SetParameterValue(0, playerID)
        report.SetDataSource(Container)
        viewer.CrystalReportViewer1.ReportSource = report
        viewer.ShowDialog()
    End Sub

    Protected Friend Sub printBlankRegForm()
        Dim report As New crApplicationFormBlank
        Dim viewer As New frmReportViewer

        report = New crApplicationFormBlank

        report.Refresh()
        'report.SetDataSource(container)
        viewer.CrystalReportViewer1.ReportSource = report
        viewer.ShowDialog()
    End Sub



    Protected Friend Sub printAttendanceByDate(ByVal container, ByVal dt)
        Dim report As New crAttendancebyDate
        Dim viewer As New frmReportViewer

        report = New crAttendancebyDate

        report.Refresh()
        report.SetParameterValue(0, dt)
        report.SetDataSource(container)
        viewer.CrystalReportViewer1.ReportSource = report
        viewer.ShowDialog()
    End Sub

    Protected Friend Sub printSubsUnder14Days(ByVal container)
        Dim report As New crMonthlySubsList
        Dim viewer As New frmReportViewer

        report = New crMonthlySubsList

        report.Refresh()
        report.SetDataSource(container)
        viewer.CrystalReportViewer1.ReportSource = report
        viewer.ShowDialog()
    End Sub

    Protected Friend Sub printAnnualAttendance(ByVal container, ByVal yr)
        Dim report As New crYearlyAttendance
        Dim viewer As New frmReportViewer

        report = New crYearlyAttendance

        report.Refresh()
        report.SetDataSource(container)
        report.SetParameterValue(0, yr)
        viewer.CrystalReportViewer1.ReportSource = report
        viewer.ShowDialog()
    End Sub

    Protected Friend Sub printDailyTransactions(ByVal container, ByVal dateTransac)
        Dim report As New crTransactionDaily
        Dim viewer As New frmReportViewer

        report = New crTransactionDaily

        report.Refresh()
        report.SetDataSource(container)
        report.SetParameterValue(0, dateTransac)
        viewer.CrystalReportViewer1.ReportSource = report
        viewer.ShowDialog()
    End Sub

End Class
