Public Class PSW

    Shared ReadOnly Property Versão() As String
        Get
            With My.Application.Info.Version
                Return .Major & "." & .Minor & "." & .Build & "." & .Revision
            End With
        End Get
    End Property
    Shared ReadOnly Property Título() As String
        Get
            With My.Application.Info
                Return .Title
            End With
        End Get
    End Property

    Sub AbrirArquivo(ByVal nome As String)
        Dim arg() As String = Environment.GetCommandLineArgs
        Try
            If nome = "" Then
                nome = arg(1)
            End If
            Dim d() As Char = IO.File.ReadAllText(nome, System.Text.Encoding.Default)
            FileOpen(1, "temp", 2)
            For i = 0 To UBound(d)
                Print(1, Chr(Asc(d(i)) - 17))
                i = i + 4
            Next i
            FileClose(1)
            Dim e() As String = IO.File.ReadAllLines("temp", System.Text.Encoding.Default)
            For i = 0 To UBound(e)
                If e(i).StartsWith("CR") = False Then
                    IO.File.Delete("temp")
                    MsgBox("Este arquivo está danificado!", 16, "Gerador de Senhas")
                    Exit Sub
                End If
                If e(i).Contains("CD") = True Then
                    Dim s() As String
                    s = e(i).Split("=")
                    txtPsw.Text = s(1)
                    IO.File.Delete("temp")
                    Exit For
                End If
            Next
            IO.File.Delete("temp")
        Catch ex As Exception
        End Try
    End Sub

    Public Shared args As Boolean

    Function Ver(ByVal arg() As String) As Boolean
        ' gen [true=várias | false=uma] [-s="Símb, letras e números" | -l="minúsculas" | -m="maiúsculas" | -n="números"] [caracteres]
        ' Fórmula randômica: Int((%maior - %menor + 1) * Rnd() + %menor))
        If arg(1).ToLower = "-s" Then
            Senha.QuantidadeDeCaracteres = Convert.ToInt16(arg(2))
            For c = 1 To Senha.QuantidadeDeCaracteres
                Console.Write(GerarSequencia(126, 33))
            Next
            'ElseIf Senha.Complexidade = "Somente símbolos" Then
            '    For c = 1 To Int(Senha.QuantidadeDeCaracteres)
            '        txtPsw.Text = GerarSequencia(47, 33)
            '        txtPsw.Text = GerarSequencia(64, 58)
            '        txtPsw.Text = GerarSequencia(96, 91)
            '        txtPsw.Text = GerarSequencia(126, 123)
            '    Next
        ElseIf arg(1).ToLower = "-l" Then
            Senha.QuantidadeDeCaracteres = Convert.ToInt16(arg(2))
            For c = 1 To Senha.QuantidadeDeCaracteres
                Console.Write(GerarSequencia(122, 97))
            Next
        ElseIf arg(1).ToLower = "-m" Then
            Senha.QuantidadeDeCaracteres = Convert.ToInt16(arg(2))
            For c = 1 To Senha.QuantidadeDeCaracteres
                Console.Write(GerarSequencia(90, 65))
            Next
        ElseIf arg(1).ToLower = "-n" Then
            Senha.QuantidadeDeCaracteres = Convert.ToInt16(arg(2))
            For c = 1 To Senha.QuantidadeDeCaracteres
                Console.Write(GerarSequencia(57, 48))
            Next
            Return True
        Else
            Return False
        End If
    End Function

    Class Senha
        Shared Property QuantidadeDeCaracteres() As Int32
            Get
                Return PSW.txtCrc.Value
            End Get
            Set(ByVal value As Int32)
                value = PSW.txtCrc.Value
            End Set
        End Property
        Shared Property Complexidade() As String
            Get
                Return PSW.txtCmp.Text
            End Get
            Set(ByVal value As String)
                value = PSW.txtCmp.Text
            End Set
        End Property
    End Class

    Function GerarSequencia(ByVal últimoCaractere As Integer,
                            ByVal primeiroCaractere As Integer) As String
        Dim ret As String
        For c = 1 To Senha.QuantidadeDeCaracteres
            ret = ret & Chr(Int((últimoCaractere - primeiroCaractere + 1) * Rnd() + primeiroCaractere))
        Next
        Return ret
    End Function

    Private Sub PSW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Ver(Environment.GetCommandLineArgs()) = True Then Exit Sub
        Catch
        End Try
        AbrirArquivo("")
        optUma.Checked = True
    End Sub

    Private Sub cmdCp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCp.Click
        My.Computer.Clipboard.SetText(txtPsw.Text)
    End Sub

    Private Sub cmdGr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGr.Click
        Cursor = Cursors.WaitCursor
        If optUma.Checked = True Then
            txtPsw.Text = ""
            Randomize()
            ' Fórmula randômica: Int((%maior - %menor + 1) * Rnd() + %menor))
            If Senha.Complexidade = "Símbolos, letras e números" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = GerarSequencia(126, 33)
                Next
                'ElseIf Senha.Complexidade = "Somente símbolos" Then
                '    For c = 1 To Int(Senha.QuantidadeDeCaracteres)
                '        txtPsw.Text = GerarSequencia(47, 33)
                '        txtPsw.Text = GerarSequencia(64, 58)
                '        txtPsw.Text = GerarSequencia(96, 91)
                '        txtPsw.Text = GerarSequencia(126, 123)
                '    Next
            ElseIf Senha.Complexidade = "Somente letras minúsculas" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = GerarSequencia(122, 97)
                Next
            ElseIf Senha.Complexidade = "Somente letras maiúsculas" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = GerarSequencia(90, 65)
                Next
            ElseIf Senha.Complexidade = "Somente números" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = GerarSequencia(57, 48)
                Next
            End If
        ElseIf optVr.Checked = True Then
            With impDoc.DefaultPageSettings.Margins
                .Left = 30
                .Right = 30
                .Bottom = 40
                .Top = 40
            End With
            impDoc.DocumentName = "Minhas senhas"
            impPrv.Document = impDoc
            impPrv.ShowDialog()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub optUma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optUma.CheckedChanged
        txtPsw.Enabled = True
        cmdCp.Enabled = True
        mnSv.Enabled = True
        lblInf.Text = "Essa opção gera apenas uma senha por vez."
    End Sub

    Private Sub optVr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optVr.CheckedChanged
        txtPsw.Enabled = False
        cmdCp.Enabled = False
        lblInf.Text = "Essa opção gera várias senhas de uma vez."
    End Sub

    Private Sub impDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles impDoc.PrintPage
        Dim ml, mr, mt, mb, pz As Int32
        With impDoc.DefaultPageSettings.Margins
            ml = .Left
            mr = .Right
            mt = .Top
            mb = .Bottom
        End With
        pz = impDoc.DefaultPageSettings.PaperSize.Height
        Dim f As New Font("Times New Roman", 8, 1, GraphicsUnit.Millimeter)
        e.Graphics.DrawString("GUARDE ESTA FOLHA NUM LUGAR SEGURO", f, Brushes.Black, _
                              ml, mt)
        f = New Font("Arial", 12, 1, 3)
        mt += 60
        e.Graphics.DrawString("USADA", f, Brushes.Black, ml, mt)
        e.Graphics.DrawString("DATA DE USO", f, Brushes.Black, ml + 100, mt)
        mt += 20
        f = New Font("Arial", 12)
        For i = 0 To 44
            txtPsw.Text = ""
            Randomize()
            If Senha.Complexidade = "Símbolos, letras e números" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = txtPsw.Text & Chr(Int((126 - 33 + 1) * Rnd() + 33))
                Next
            ElseIf Senha.Complexidade = "Somente letras minúsculas" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = txtPsw.Text & Chr(Int((122 - 97 + 1) * Rnd() + 97))
                Next
            ElseIf Senha.Complexidade = "Somente letras maiúsculas" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = txtPsw.Text & Chr(Int((90 - 65 + 1) * Rnd() + 65))
                Next
            ElseIf Senha.Complexidade = "Somente números" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = txtPsw.Text & Chr(Int((57 - 48 + 1) * Rnd() + 48))
                Next
            End If
            e.Graphics.DrawString("□", f, Brushes.Black, ml + 20, mt)
            e.Graphics.DrawString(DateAdd(DateInterval.Day, (i + 1) * 30, Today.Date), f, Brushes.Black, ml + 10 + 100, mt)
            e.Graphics.DrawString(txtPsw.Text, f, Brushes.Black, ml + 250, mt)
            txtPsw.Text = ""
            Randomize()
            If Senha.Complexidade = "Símbolos, letras e números" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = txtPsw.Text & Chr(Int((126 - 33 + 1) * Rnd() + 33))
                Next
            ElseIf Senha.Complexidade = "Somente letras minúsculas" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = txtPsw.Text & Chr(Int((122 - 97 + 1) * Rnd() + 97))
                Next
            ElseIf Senha.Complexidade = "Somente letras maiúsculas" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = txtPsw.Text & Chr(Int((90 - 65 + 1) * Rnd() + 65))
                Next
            ElseIf Senha.Complexidade = "Somente números" Then
                For c = 1 To Senha.QuantidadeDeCaracteres
                    txtPsw.Text = txtPsw.Text & Chr(Int((57 - 48 + 1) * Rnd() + 48))
                Next
            End If
            e.Graphics.DrawString(txtPsw.Text, f, Brushes.Black, ml + 500, mt)
            txtPsw.Text = ""
            mt += 20
        Next i
        e.Graphics.DrawString("Criado por SAKCript " & PSW.Versão, f, Brushes.Black, _
                              ml, pz - mb - 20)
    End Sub

    Private Sub mnAb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAb.Click
        dlgAb.ShowDialog()
        AbrirArquivo(dlgAb.FileName)
    End Sub

    Private Sub mnSv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSv.Click
        dlgSv.ShowDialog()
        If optUma.Checked = True Then
            FileOpen(1, dlgSv.FileName, 2)
            For Each c As Char In ("CR Product:" & Título & " Version:" & Versão & _
                                   " Senha criada em [" & Today.Date & "] por " & _
                                    My.User.Name & " CD=" & txtPsw.Text)
                Print(1, Chr(Asc(c) + 17) & Chr(Asc(c) + 34) & Chr(Asc(c) + 51) & _
                      Chr(Asc(c) + 68) & Chr(Asc(c) + 85))
            Next
            FileClose(1)
        ElseIf optVr.Checked = True Then
            FileOpen(1, dlgSv.FileName, 2)
            PrintLine(1, "GUARDE ESTE ARQUIVO NUM LUGAR SEGURO")
            PrintLine(1, "USADA", "DATA DE USO")
            Dim dt As Date
            dt = DateAdd(DateInterval.Day, 1, Today.Date)
            For i = 0 To 47
                txtPsw.Text = ""
                Randomize()
                'Fómula de randomização dos caracteres:
                '----Chr(Int(Maior valor-Menor valor+1)*Rnd()+Menor valor)
                If Senha.Complexidade = "Símbolos, letras e números" Then
                    For c = 1 To Senha.QuantidadeDeCaracteres
                        txtPsw.Text = txtPsw.Text & Chr(Int((126 - 33 + 1) * Rnd() + 33))
                    Next
                ElseIf Senha.Complexidade = "Somente letras minúsculas" Then
                    For c = 1 To Senha.QuantidadeDeCaracteres
                        txtPsw.Text = txtPsw.Text & Chr(Int((122 - 97 + 1) * Rnd() + 97))
                    Next
                ElseIf Senha.Complexidade = "Somente letras maiúsculas" Then
                    For c = 1 To Senha.QuantidadeDeCaracteres
                        txtPsw.Text = txtPsw.Text & Chr(Int((90 - 65 + 1) * Rnd() + 65))
                    Next
                ElseIf Senha.Complexidade = "Somente números" Then
                    For c = 1 To Senha.QuantidadeDeCaracteres
                        txtPsw.Text = txtPsw.Text & Chr(Int((123 - 48 + 1) * Rnd() + 48))
                    Next
                End If
                PrintLine(1, "Não", DateAdd(DateInterval.Day, (i + 1) * 30, dt), txtPsw.Text)
                dt = DateAdd(DateInterval.Day, 30, dt)
            Next i
            PrintLine(1)
            PrintLine(1, "Criado por SAKCript " & PSW.Versão)
            FileClose(1)
        End If
    End Sub

    Private Sub mnImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PRV.ShowDialog()
        PRV.txtPgN.Value = impDoc.PrinterSettings.MinimumPage
        PRV.lblPgT.Text = " / " & impDoc.PrinterSettings.MaximumPage
        PRV.cntPrv.Document = impDoc
    End Sub

    Private Sub mnFc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnFc.Click
        Me.Close()
    End Sub
End Class
