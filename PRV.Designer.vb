<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRV))
        Me.cntPrv = New System.Windows.Forms.PrintPreviewControl
        Me.lblPg = New System.Windows.Forms.Label
        Me.txtPgN = New System.Windows.Forms.NumericUpDown
        Me.lblPgT = New System.Windows.Forms.Label
        Me.cmdImp = New System.Windows.Forms.Button
        Me.cmdMg = New System.Windows.Forms.Button
        Me.cmdFc = New System.Windows.Forms.Button
        Me.txtZZ = New System.Windows.Forms.ComboBox
        Me.lblZZ = New System.Windows.Forms.Label
        CType(Me.txtPgN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cntPrv
        '
        Me.cntPrv.Location = New System.Drawing.Point(12, 42)
        Me.cntPrv.Name = "cntPrv"
        Me.cntPrv.Size = New System.Drawing.Size(543, 498)
        Me.cntPrv.TabIndex = 0
        '
        'lblPg
        '
        Me.lblPg.AutoSize = True
        Me.lblPg.Location = New System.Drawing.Point(442, 14)
        Me.lblPg.Name = "lblPg"
        Me.lblPg.Size = New System.Drawing.Size(43, 13)
        Me.lblPg.TabIndex = 5
        Me.lblPg.Text = "Página:"
        '
        'txtPgN
        '
        Me.txtPgN.Location = New System.Drawing.Point(491, 12)
        Me.txtPgN.Name = "txtPgN"
        Me.txtPgN.Size = New System.Drawing.Size(37, 20)
        Me.txtPgN.TabIndex = 6
        Me.txtPgN.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblPgT
        '
        Me.lblPgT.AutoSize = True
        Me.lblPgT.Location = New System.Drawing.Point(534, 14)
        Me.lblPgT.Name = "lblPgT"
        Me.lblPgT.Size = New System.Drawing.Size(21, 13)
        Me.lblPgT.TabIndex = 7
        Me.lblPgT.Text = "/ 0"
        '
        'cmdImp
        '
        Me.cmdImp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImp.Location = New System.Drawing.Point(12, 12)
        Me.cmdImp.Name = "cmdImp"
        Me.cmdImp.Size = New System.Drawing.Size(75, 23)
        Me.cmdImp.TabIndex = 9
        Me.cmdImp.Text = "&Imprimir"
        Me.cmdImp.UseVisualStyleBackColor = True
        '
        'cmdMg
        '
        Me.cmdMg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdMg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMg.Location = New System.Drawing.Point(93, 13)
        Me.cmdMg.Name = "cmdMg"
        Me.cmdMg.Size = New System.Drawing.Size(75, 23)
        Me.cmdMg.TabIndex = 10
        Me.cmdMg.Text = "Mar&gem"
        Me.cmdMg.UseVisualStyleBackColor = True
        '
        'cmdFc
        '
        Me.cmdFc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdFc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFc.Location = New System.Drawing.Point(174, 13)
        Me.cmdFc.Name = "cmdFc"
        Me.cmdFc.Size = New System.Drawing.Size(75, 23)
        Me.cmdFc.TabIndex = 11
        Me.cmdFc.Text = "Fe&char"
        Me.cmdFc.UseVisualStyleBackColor = True
        '
        'txtZZ
        '
        Me.txtZZ.FormattingEnabled = True
        Me.txtZZ.Items.AddRange(New Object() {"10%", "20%", "30%", "50%", "70%", "90%", "100%", "150%", "200%", "300%", "500%"})
        Me.txtZZ.Location = New System.Drawing.Point(298, 15)
        Me.txtZZ.Name = "txtZZ"
        Me.txtZZ.Size = New System.Drawing.Size(50, 21)
        Me.txtZZ.TabIndex = 12
        '
        'lblZZ
        '
        Me.lblZZ.AutoSize = True
        Me.lblZZ.Location = New System.Drawing.Point(255, 17)
        Me.lblZZ.Name = "lblZZ"
        Me.lblZZ.Size = New System.Drawing.Size(37, 13)
        Me.lblZZ.TabIndex = 13
        Me.lblZZ.Text = "Zoom:"
        '
        'PRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(566, 552)
        Me.Controls.Add(Me.lblZZ)
        Me.Controls.Add(Me.txtZZ)
        Me.Controls.Add(Me.cmdFc)
        Me.Controls.Add(Me.cmdMg)
        Me.Controls.Add(Me.cmdImp)
        Me.Controls.Add(Me.lblPgT)
        Me.Controls.Add(Me.txtPgN)
        Me.Controls.Add(Me.lblPg)
        Me.Controls.Add(Me.cntPrv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PRV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualização de impressão"
        CType(Me.txtPgN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cntPrv As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents lblPg As System.Windows.Forms.Label
    Friend WithEvents txtPgN As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPgT As System.Windows.Forms.Label
    Friend WithEvents cmdImp As System.Windows.Forms.Button
    Friend WithEvents cmdMg As System.Windows.Forms.Button
    Friend WithEvents cmdFc As System.Windows.Forms.Button
    Friend WithEvents txtZZ As System.Windows.Forms.ComboBox
    Friend WithEvents lblZZ As System.Windows.Forms.Label
End Class
