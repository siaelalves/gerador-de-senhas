Public Class PRV

    Private Sub PRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtZZ.Text = 100%
        cntPrv.Zoom = Val(txtZZ.Text)
    End Sub

    Private Sub cmdImp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        PSW.dlgImp.Document = PSW.impDoc
        If PSW.dlgImp.ShowDialog = Windows.Forms.DialogResult.OK Then
            PSW.impDoc.PrinterSettings.PrinterName = PSW.dlgImp.PrinterSettings.PrinterName
            PSW.impDoc.Print()
        End If
    End Sub

    Private Sub cmdFc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFc.Click
        Me.Close()
    End Sub

    Private Sub txtZZ_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZZ.SelectedIndexChanged
        cntPrv.Zoom = Val(txtZZ.Text) / 10
    End Sub
End Class