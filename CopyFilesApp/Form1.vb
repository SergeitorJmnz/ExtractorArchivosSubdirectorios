Imports System.IO

Public Class mainForm

#Region "Variables globales"

    Dim fbdIn As New FolderBrowserDialog
    Dim fbdOut As New FolderBrowserDialog

    Dim g_count As Integer = 1

#End Region


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnExtract.Enabled = False
        tmrExtractBtn.Start()
    End Sub

#Region "Eventos del formulario"

#Region "Botones"

    Private Sub BtnExamIn_Click(sender As Object, e As EventArgs) Handles btnExamIn.Click

        If fbdIn.ShowDialog = DialogResult.OK Then
            txtFolderIn.Text = fbdIn.SelectedPath
        End If

    End Sub

    Private Sub BtnExamOut_Click(sender As Object, e As EventArgs) Handles btnExamOut.Click

        If fbdOut.ShowDialog = DialogResult.OK Then
            txtFolderOut.Text = fbdOut.SelectedPath
        End If

    End Sub

    Private Sub BtnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click

        Dim files() As String = IO.Directory.GetFiles(txtFolderIn.Text, "*.*", IO.SearchOption.AllDirectories)
        Dim outputFolder As String = String.Empty

        If files.Length > 0 Then

            prog_bar.Minimum = g_count
            prog_bar.Maximum = files.Count

            Try

                prog_bar.Visible = True

                For Each file In files
                    outputFolder = Path.Combine(txtFolderOut.Text, Path.GetFileName(file))

                    If My.Computer.FileSystem.FileExists(file) Then
                        Continue For
                    Else
                        My.Computer.FileSystem.CopyFile(file, outputFolder)
                    End If


                    prog_bar.Value = g_count
                    'prog_bar.Refresh()
                    g_count += 1

                Next

                g_count = 1
                MessageBox.Show("Proceso finalizado con éxito!", "OK", MessageBoxButtons.OK, MessageBoxIcon.None)

            Catch ex As Exception

                MessageBox.Show("Ha ocurrido un error inesperado en el proceso, por favor, ponte en contacto con el servicio técnico.", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        Else

            MessageBox.Show("La carpeta de origen está vacía." & vbNewLine & "Seleccione otra carpeta que no esté vacía e inténtelo de nuevo.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

#End Region

#End Region

    ''' <summary>
    ''' Timer del botón extraer. Lo activa cuando amboz textbox tienen una ruta.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrExtractBtn.Tick

        If (txtFolderIn.TextLength > 0) And (txtFolderOut.TextLength > 0) Then
            btnExtract.Enabled = True
        Else
            btnExtract.Enabled = False
        End If

    End Sub


End Class
