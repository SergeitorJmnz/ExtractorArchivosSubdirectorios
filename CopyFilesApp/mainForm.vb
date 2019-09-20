Imports System.IO

Public Class mainForm


#Region "Variables globales"

    Dim fbdIn As New FolderBrowserDialog
    Dim fbdOut As New FolderBrowserDialog

    Dim g_count As Integer = 0
    Dim g_extracting As Boolean = False
    Dim g_files As Integer = 0

    Dim g_errorCount As Integer = 0
    Public g_failedFiles() As String
    Public g_failedfile As String

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

        Dim thread As Threading.Thread = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.Extraccion))
        thread.Start()
        tmrForm.Start()

        g_extracting = True

    End Sub

#End Region

#Region "Timers"


    ''' <summary>
    ''' Timer del botón extraer. Lo activa cuando amboz textbox tienen una ruta.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrExtractBtn_Tick(sender As Object, e As EventArgs) Handles tmrExtractBtn.Tick

        If (txtFolderIn.TextLength > 0) And (txtFolderOut.TextLength > 0) And Not g_extracting Then
            btnExtract.Enabled = True
        Else
            btnExtract.Enabled = False
        End If

    End Sub

    ''' <summary>
    ''' Timer del formulario integro
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TmrForm_Tick(sender As Object, e As EventArgs) Handles tmrForm.Tick

        If g_extracting Then

            prog_bar.Maximum = g_files

            prog_bar.Visible = True

            txtLabelBar.Visible = True
            txtLabelDone.Visible = True
            txtLabelExt.Visible = True
            txtLabelFiles.Visible = True
            txtLabelFiles.Text = g_files

            btnExamIn.Enabled = False
            btnExamOut.Enabled = False
            btnExtract.Enabled = False
            txtFolderIn.Enabled = False
            txtFolderOut.Enabled = False

            prog_bar.Value = g_count
            txtLabelDone.Text = g_count

        Else

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

        End If


    End Sub


#End Region


#End Region


#Region "Funciones auxiliares"

    Public Sub Extraccion()

        Dim files() As String = IO.Directory.GetFiles(txtFolderIn.Text, "*.*", IO.SearchOption.AllDirectories)
        Dim outputFolder As String = String.Empty
        Dim repeatedFileName As String = String.Empty

        If files.Length > 0 Then

            g_files = files.Length

            For Each file In files

                Try

                    outputFolder = Path.Combine(txtFolderOut.Text, Path.GetFileName(file))


                    If Path.GetFileName(file).First = "." Then
                        Continue For
                    ElseIf My.Computer.FileSystem.FileExists(outputFolder) Then
                        repeatedFileName = Path.Combine(txtFolderOut.Text, "#" & g_count & "_" & Path.GetFileName(file))

                        My.Computer.FileSystem.CopyFile(file, repeatedFileName)

                    Else
                        My.Computer.FileSystem.CopyFile(file, outputFolder)
                    End If

                    g_count += 1

                Catch ex As Exception

                    ReDim Preserve g_failedFiles(g_errorCount)

                    g_failedFiles(g_errorCount) = ex.Message
                    g_errorCount += 1

                End Try

            Next

            If g_errorCount > 0 Then

                Dim result As Integer = MessageBox.Show("Proceso finalizado con errores." &
                                                        vbNewLine & "Es posible que algunos archivos no se hayan copiado." &
                                                        vbNewLine & "¿Desea ver la lista de errores?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

                If result = DialogResult.Yes Then

                    errorForm.txtBox.Lines = g_failedFiles
                    errorForm.ShowDialog()
                End If

            Else

                MessageBox.Show("¡Proceso finalizado con éxito!", "OK", MessageBoxButtons.OK, MessageBoxIcon.None)

            End If

            g_errorCount = 0


        Else

            MessageBox.Show("La carpeta de origen está vacía." &
                            vbNewLine & "Seleccione otra carpeta que no esté vacía e inténtelo de nuevo.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        g_count = 0
        g_extracting = False

    End Sub


#End Region

End Class
