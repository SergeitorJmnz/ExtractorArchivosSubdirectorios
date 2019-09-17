<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.boxInFolder = New System.Windows.Forms.GroupBox()
        Me.btnExamIn = New System.Windows.Forms.Button()
        Me.txtFolderIn = New System.Windows.Forms.TextBox()
        Me.boxOutFolder = New System.Windows.Forms.GroupBox()
        Me.btnExamOut = New System.Windows.Forms.Button()
        Me.txtFolderOut = New System.Windows.Forms.TextBox()
        Me.tmrExtractBtn = New System.Windows.Forms.Timer(Me.components)
        Me.prog_bar = New System.Windows.Forms.ProgressBar()
        Me.txtLabelExt = New System.Windows.Forms.Label()
        Me.txtLabelDone = New System.Windows.Forms.Label()
        Me.txtLabelBar = New System.Windows.Forms.Label()
        Me.txtLabelFiles = New System.Windows.Forms.Label()
        Me.tmrForm = New System.Windows.Forms.Timer(Me.components)
        Me.boxInFolder.SuspendLayout()
        Me.boxOutFolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(552, 197)
        Me.btnExtract.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(135, 36)
        Me.btnExtract.TabIndex = 0
        Me.btnExtract.Text = "Extraer"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'boxInFolder
        '
        Me.boxInFolder.Controls.Add(Me.btnExamIn)
        Me.boxInFolder.Controls.Add(Me.txtFolderIn)
        Me.boxInFolder.Location = New System.Drawing.Point(4, 6)
        Me.boxInFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.boxInFolder.Name = "boxInFolder"
        Me.boxInFolder.Padding = New System.Windows.Forms.Padding(4)
        Me.boxInFolder.Size = New System.Drawing.Size(695, 69)
        Me.boxInFolder.TabIndex = 1
        Me.boxInFolder.TabStop = False
        Me.boxInFolder.Text = "Carpeta de entrada"
        '
        'btnExamIn
        '
        Me.btnExamIn.Location = New System.Drawing.Point(583, 23)
        Me.btnExamIn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExamIn.Name = "btnExamIn"
        Me.btnExamIn.Size = New System.Drawing.Size(100, 25)
        Me.btnExamIn.TabIndex = 3
        Me.btnExamIn.Text = "Examinar..."
        Me.btnExamIn.UseVisualStyleBackColor = True
        '
        'txtFolderIn
        '
        Me.txtFolderIn.Location = New System.Drawing.Point(8, 23)
        Me.txtFolderIn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFolderIn.Name = "txtFolderIn"
        Me.txtFolderIn.Size = New System.Drawing.Size(561, 22)
        Me.txtFolderIn.TabIndex = 1
        '
        'boxOutFolder
        '
        Me.boxOutFolder.Controls.Add(Me.btnExamOut)
        Me.boxOutFolder.Controls.Add(Me.txtFolderOut)
        Me.boxOutFolder.Location = New System.Drawing.Point(4, 82)
        Me.boxOutFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.boxOutFolder.Name = "boxOutFolder"
        Me.boxOutFolder.Padding = New System.Windows.Forms.Padding(4)
        Me.boxOutFolder.Size = New System.Drawing.Size(695, 75)
        Me.boxOutFolder.TabIndex = 2
        Me.boxOutFolder.TabStop = False
        Me.boxOutFolder.Text = "Carpeta de salida"
        '
        'btnExamOut
        '
        Me.btnExamOut.Location = New System.Drawing.Point(583, 23)
        Me.btnExamOut.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExamOut.Name = "btnExamOut"
        Me.btnExamOut.Size = New System.Drawing.Size(100, 25)
        Me.btnExamOut.TabIndex = 4
        Me.btnExamOut.Text = "Examinar..."
        Me.btnExamOut.UseVisualStyleBackColor = True
        '
        'txtFolderOut
        '
        Me.txtFolderOut.Location = New System.Drawing.Point(8, 23)
        Me.txtFolderOut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFolderOut.Name = "txtFolderOut"
        Me.txtFolderOut.Size = New System.Drawing.Size(561, 22)
        Me.txtFolderOut.TabIndex = 2
        '
        'tmrExtractBtn
        '
        '
        'prog_bar
        '
        Me.prog_bar.Location = New System.Drawing.Point(12, 161)
        Me.prog_bar.Margin = New System.Windows.Forms.Padding(4)
        Me.prog_bar.Name = "prog_bar"
        Me.prog_bar.Size = New System.Drawing.Size(532, 32)
        Me.prog_bar.TabIndex = 3
        Me.prog_bar.Visible = False
        '
        'txtLabelExt
        '
        Me.txtLabelExt.AutoSize = True
        Me.txtLabelExt.Location = New System.Drawing.Point(552, 161)
        Me.txtLabelExt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLabelExt.Name = "txtLabelExt"
        Me.txtLabelExt.Size = New System.Drawing.Size(70, 17)
        Me.txtLabelExt.TabIndex = 4
        Me.txtLabelExt.Text = "Extraídos:"
        Me.txtLabelExt.Visible = False
        '
        'txtLabelDone
        '
        Me.txtLabelDone.AutoSize = True
        Me.txtLabelDone.Location = New System.Drawing.Point(552, 177)
        Me.txtLabelDone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLabelDone.Name = "txtLabelDone"
        Me.txtLabelDone.Size = New System.Drawing.Size(48, 17)
        Me.txtLabelDone.TabIndex = 5
        Me.txtLabelDone.Text = "00000"
        Me.txtLabelDone.Visible = False
        '
        'txtLabelBar
        '
        Me.txtLabelBar.AutoSize = True
        Me.txtLabelBar.Location = New System.Drawing.Point(597, 177)
        Me.txtLabelBar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLabelBar.Name = "txtLabelBar"
        Me.txtLabelBar.Size = New System.Drawing.Size(12, 17)
        Me.txtLabelBar.TabIndex = 6
        Me.txtLabelBar.Text = "/"
        Me.txtLabelBar.Visible = False
        '
        'txtLabelFiles
        '
        Me.txtLabelFiles.AutoSize = True
        Me.txtLabelFiles.Location = New System.Drawing.Point(609, 177)
        Me.txtLabelFiles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLabelFiles.Name = "txtLabelFiles"
        Me.txtLabelFiles.Size = New System.Drawing.Size(48, 17)
        Me.txtLabelFiles.TabIndex = 7
        Me.txtLabelFiles.Text = "00000"
        Me.txtLabelFiles.Visible = False
        '
        'tmrForm
        '
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(703, 241)
        Me.Controls.Add(Me.txtLabelFiles)
        Me.Controls.Add(Me.txtLabelBar)
        Me.Controls.Add(Me.txtLabelDone)
        Me.Controls.Add(Me.txtLabelExt)
        Me.Controls.Add(Me.prog_bar)
        Me.Controls.Add(Me.boxOutFolder)
        Me.Controls.Add(Me.boxInFolder)
        Me.Controls.Add(Me.btnExtract)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.Text = "Extractor de documentos"
        Me.boxInFolder.ResumeLayout(False)
        Me.boxInFolder.PerformLayout()
        Me.boxOutFolder.ResumeLayout(False)
        Me.boxOutFolder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExtract As Button
    Friend WithEvents boxInFolder As GroupBox
    Friend WithEvents btnExamIn As Button
    Friend WithEvents txtFolderIn As TextBox
    Friend WithEvents boxOutFolder As GroupBox
    Friend WithEvents btnExamOut As Button
    Friend WithEvents txtFolderOut As TextBox
    Friend WithEvents tmrExtractBtn As Timer
    Friend WithEvents prog_bar As ProgressBar
    Friend WithEvents txtLabelExt As Label
    Friend WithEvents txtLabelDone As Label
    Friend WithEvents txtLabelBar As Label
    Friend WithEvents txtLabelFiles As Label
    Friend WithEvents tmrForm As Timer
End Class
