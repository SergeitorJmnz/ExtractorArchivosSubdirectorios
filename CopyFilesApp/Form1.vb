Imports System.IO

Public Class mainForm


#Region "Variables globales"

    Dim fbdIn As New FolderBrowserDialog
    Dim fbdOut As New FolderBrowserDialog

    Dim g_count As Integer = 1

#End Region


#Region "Eventos del formulario"


#Region "Carga del formulario"

    ''' <summary>
    ''' Eventos de carga del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnExtract.Enabled = False
        tmrExtractBtn.Start()
    End Sub

#End Region

#Region "Botones"

    ''' <summary>
    ''' Eventos del botón Examinar carpeta de entrada
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnExamIn_Click(sender As Object, e As EventArgs) Handles btnExamIn.Click

        If fbdIn.ShowDialog = DialogResult.OK Then
            txtFolderIn.Text = fbdIn.SelectedPath
        End If

    End Sub

    ''' <summary>
    ''' Eventos del botón Examinar carpeta de salida
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnExamOut_Click(sender As Object, e As EventArgs) Handles btnExamOut.Click

        If fbdOut.ShowDialog = DialogResult.OK Then
            txtFolderOut.Text = fbdOut.SelectedPath
        End If

    End Sub

    ''' <summary>
    ''' Eventos del boton "Extraer"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click

        Dim files() As String = IO.Directory.GetFiles(txtFolderIn.Text, "*.*", IO.SearchOption.AllDirectories)
        Dim outputFolder As String = String.Empty
        Dim repeatedFileName As String = String.Empty

        If files.Length > 0 Then

            prog_bar.Minimum = g_count
            prog_bar.Maximum = files.Count

            Try

                prog_bar.Visible = True
                txtLabelBar.Visible = True
                txtLabelDone.Visible = True
                txtLabelExt.Visible = True
                txtLabelFiles.Visible = True

                btnExamIn.Enabled = False
                btnExamOut.Enabled = False
                btnExtract.Enabled = False
                txtFolderIn.Enabled = False
                txtFolderOut.Enabled = False

                txtLabelFiles.Text = files.Count

                For Each file In files

                    outputFolder = Path.Combine(txtFolderOut.Text, Path.GetFileName(file))

                    If Path.GetFileName(file).First = "." Then
                        Continue For
                    ElseIf My.Computer.FileSystem.FileExists(outputFolder) Then
                        repeatedFileName = Path.Combine(txtFolderOut.Text, "#" & g_count & "_" & Path.GetFileName(file))

                        My.Computer.FileSystem.CopyFile(file, repeatedFileName)
                    Else
                        My.Computer.FileSystem.CopyFile(file, outputFolder)
                    End If

                    prog_bar.Value = g_count
                    txtLabelDone.Text = g_count
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

        prog_bar.Visible = False
        txtLabelBar.Visible = False
        txtLabelDone.Visible = False
        txtLabelExt.Visible = False
        txtLabelFiles.Visible = False

        btnExamIn.Enabled = True
        btnExamOut.Enabled = True
        btnExtract.Enabled = True
        txtFolderIn.Enabled = True
        txtFolderOut.Enabled = True

    End Sub

#End Region

#Region "Timers"

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



#End Region


#End Region


End Class
