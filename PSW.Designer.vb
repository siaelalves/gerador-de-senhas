<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PSW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PSW))
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.lblPsw = New System.Windows.Forms.Label()
        Me.cmdGr = New System.Windows.Forms.Button()
        Me.optVr = New System.Windows.Forms.RadioButton()
        Me.optUma = New System.Windows.Forms.RadioButton()
        Me.impDoc = New System.Drawing.Printing.PrintDocument()
        Me.impPrv = New System.Windows.Forms.PrintPreviewDialog()
        Me.cmdCp = New System.Windows.Forms.Button()
        Me.mn = New System.Windows.Forms.MenuStrip()
        Me.mnArq = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAb = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSv = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnFc = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgSv = New System.Windows.Forms.SaveFileDialog()
        Me.st = New System.Windows.Forms.StatusStrip()
        Me.lblInf = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCrc = New System.Windows.Forms.NumericUpDown()
        Me.lblCrc = New System.Windows.Forms.Label()
        Me.txtCmp = New System.Windows.Forms.ComboBox()
        Me.lblCmp = New System.Windows.Forms.Label()
        Me.dlgImp = New System.Windows.Forms.PrintDialog()
        Me.dlgAb = New System.Windows.Forms.OpenFileDialog()
        Me.dlgMg = New System.Windows.Forms.PageSetupDialog()
        Me.mn.SuspendLayout()
        Me.st.SuspendLayout()
        CType(Me.txtCrc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPsw
        '
        resources.ApplyResources(Me.txtPsw, "txtPsw")
        Me.txtPsw.Name = "txtPsw"
        '
        'lblPsw
        '
        resources.ApplyResources(Me.lblPsw, "lblPsw")
        Me.lblPsw.Name = "lblPsw"
        '
        'cmdGr
        '
        resources.ApplyResources(Me.cmdGr, "cmdGr")
        Me.cmdGr.Name = "cmdGr"
        Me.cmdGr.UseVisualStyleBackColor = True
        '
        'optVr
        '
        resources.ApplyResources(Me.optVr, "optVr")
        Me.optVr.Name = "optVr"
        Me.optVr.TabStop = True
        Me.optVr.UseVisualStyleBackColor = True
        '
        'optUma
        '
        resources.ApplyResources(Me.optUma, "optUma")
        Me.optUma.Name = "optUma"
        Me.optUma.TabStop = True
        Me.optUma.UseVisualStyleBackColor = True
        '
        'impDoc
        '
        '
        'impPrv
        '
        resources.ApplyResources(Me.impPrv, "impPrv")
        Me.impPrv.Name = "impPrv"
        '
        'cmdCp
        '
        resources.ApplyResources(Me.cmdCp, "cmdCp")
        Me.cmdCp.Name = "cmdCp"
        Me.cmdCp.UseVisualStyleBackColor = True
        '
        'mn
        '
        Me.mn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnArq})
        resources.ApplyResources(Me.mn, "mn")
        Me.mn.Name = "mn"
        '
        'mnArq
        '
        Me.mnArq.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAb, Me.mnSv, Me.ToolStripSeparator1, Me.mnFc})
        Me.mnArq.Name = "mnArq"
        resources.ApplyResources(Me.mnArq, "mnArq")
        '
        'mnAb
        '
        Me.mnAb.Name = "mnAb"
        resources.ApplyResources(Me.mnAb, "mnAb")
        '
        'mnSv
        '
        Me.mnSv.Name = "mnSv"
        resources.ApplyResources(Me.mnSv, "mnSv")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'mnFc
        '
        Me.mnFc.Name = "mnFc"
        resources.ApplyResources(Me.mnFc, "mnFc")
        '
        'dlgSv
        '
        Me.dlgSv.DefaultExt = "cd"
        Me.dlgSv.FileName = "My Code.cd"
        resources.ApplyResources(Me.dlgSv, "dlgSv")
        Me.dlgSv.RestoreDirectory = True
        '
        'st
        '
        Me.st.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblInf})
        resources.ApplyResources(Me.st, "st")
        Me.st.Name = "st"
        '
        'lblInf
        '
        Me.lblInf.Name = "lblInf"
        resources.ApplyResources(Me.lblInf, "lblInf")
        '
        'txtCrc
        '
        resources.ApplyResources(Me.txtCrc, "txtCrc")
        Me.txtCrc.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.txtCrc.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtCrc.Name = "txtCrc"
        Me.txtCrc.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'lblCrc
        '
        resources.ApplyResources(Me.lblCrc, "lblCrc")
        Me.lblCrc.Name = "lblCrc"
        '
        'txtCmp
        '
        Me.txtCmp.FormattingEnabled = True
        Me.txtCmp.Items.AddRange(New Object() {resources.GetString("txtCmp.Items"), resources.GetString("txtCmp.Items1"), resources.GetString("txtCmp.Items2"), resources.GetString("txtCmp.Items3"), resources.GetString("txtCmp.Items4")})
        resources.ApplyResources(Me.txtCmp, "txtCmp")
        Me.txtCmp.Name = "txtCmp"
        '
        'lblCmp
        '
        resources.ApplyResources(Me.lblCmp, "lblCmp")
        Me.lblCmp.Name = "lblCmp"
        '
        'dlgImp
        '
        Me.dlgImp.UseEXDialog = True
        '
        'dlgAb
        '
        Me.dlgAb.DefaultExt = "cd"
        Me.dlgAb.FileName = "My Code"
        resources.ApplyResources(Me.dlgAb, "dlgAb")
        Me.dlgAb.RestoreDirectory = True
        '
        'PSW
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblCmp)
        Me.Controls.Add(Me.txtCmp)
        Me.Controls.Add(Me.lblCrc)
        Me.Controls.Add(Me.txtCrc)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.cmdCp)
        Me.Controls.Add(Me.optUma)
        Me.Controls.Add(Me.optVr)
        Me.Controls.Add(Me.cmdGr)
        Me.Controls.Add(Me.lblPsw)
        Me.Controls.Add(Me.txtPsw)
        Me.Controls.Add(Me.mn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.mn
        Me.Name = "PSW"
        Me.mn.ResumeLayout(False)
        Me.mn.PerformLayout()
        Me.st.ResumeLayout(False)
        Me.st.PerformLayout()
        CType(Me.txtCrc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPsw As System.Windows.Forms.TextBox
    Friend WithEvents lblPsw As System.Windows.Forms.Label
    Friend WithEvents cmdGr As System.Windows.Forms.Button
    Friend WithEvents optVr As System.Windows.Forms.RadioButton
    Friend WithEvents optUma As System.Windows.Forms.RadioButton
    Friend WithEvents impDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents impPrv As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cmdCp As System.Windows.Forms.Button
    Friend WithEvents mn As System.Windows.Forms.MenuStrip
    Friend WithEvents mnArq As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnFc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dlgSv As System.Windows.Forms.SaveFileDialog
    Friend WithEvents st As System.Windows.Forms.StatusStrip
    Friend WithEvents lblInf As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCrc As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCrc As System.Windows.Forms.Label
    Friend WithEvents txtCmp As System.Windows.Forms.ComboBox
    Friend WithEvents lblCmp As System.Windows.Forms.Label
    Friend WithEvents dlgImp As System.Windows.Forms.PrintDialog
    Friend WithEvents mnAb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgAb As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgMg As System.Windows.Forms.PageSetupDialog

End Class
