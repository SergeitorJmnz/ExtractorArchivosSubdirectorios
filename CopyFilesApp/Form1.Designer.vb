<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.boxInFolder.SuspendLayout()
        Me.boxOutFolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(423, 134)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(101, 34)
        Me.btnExtract.TabIndex = 0
        Me.btnExtract.Text = "Extraer"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'boxInFolder
        '
        Me.boxInFolder.Controls.Add(Me.btnExamIn)
        Me.boxInFolder.Controls.Add(Me.txtFolderIn)
        Me.boxInFolder.Location = New System.Drawing.Point(3, 5)
        Me.boxInFolder.Name = "boxInFolder"
        Me.boxInFolder.Size = New System.Drawing.Size(521, 56)
        Me.boxInFolder.TabIndex = 1
        Me.boxInFolder.TabStop = False
        Me.boxInFolder.Text = "Carpeta de entrada"
        '
        'btnExamIn
        '
        Me.btnExamIn.Location = New System.Drawing.Point(437, 19)
        Me.btnExamIn.Name = "btnExamIn"
        Me.btnExamIn.Size = New System.Drawing.Size(75, 20)
        Me.btnExamIn.TabIndex = 3
        Me.btnExamIn.Text = "Examinar..."
        Me.btnExamIn.UseVisualStyleBackColor = True
        '
        'txtFolderIn
        '
        Me.txtFolderIn.Location = New System.Drawing.Point(6, 19)
        Me.txtFolderIn.Name = "txtFolderIn"
        Me.txtFolderIn.Size = New System.Drawing.Size(422, 20)
        Me.txtFolderIn.TabIndex = 1
        '
        'boxOutFolder
        '
        Me.boxOutFolder.Controls.Add(Me.btnExamOut)
        Me.boxOutFolder.Controls.Add(Me.txtFolderOut)
        Me.boxOutFolder.Location = New System.Drawing.Point(3, 67)
        Me.boxOutFolder.Name = "boxOutFolder"
        Me.boxOutFolder.Size = New System.Drawing.Size(521, 61)
        Me.boxOutFolder.TabIndex = 2
        Me.boxOutFolder.TabStop = False
        Me.boxOutFolder.Text = "Carpeta de salida"
        '
        'btnExamOut
        '
        Me.btnExamOut.Location = New System.Drawing.Point(437, 19)
        Me.btnExamOut.Name = "btnExamOut"
        Me.btnExamOut.Size = New System.Drawing.Size(75, 20)
        Me.btnExamOut.TabIndex = 4
        Me.btnExamOut.Text = "Examinar..."
        Me.btnExamOut.UseVisualStyleBackColor = True
        '
        'txtFolderOut
        '
        Me.txtFolderOut.Location = New System.Drawing.Point(6, 19)
        Me.txtFolderOut.Name = "txtFolderOut"
        Me.txtFolderOut.Size = New System.Drawing.Size(422, 20)
        Me.txtFolderOut.TabIndex = 2
        '
        'tmrExtractBtn
        '
        '
        'prog_bar
        '
        Me.prog_bar.Location = New System.Drawing.Point(9, 144)
        Me.prog_bar.Name = "prog_bar"
        Me.prog_bar.Size = New System.Drawing.Size(399, 16)
        Me.prog_bar.TabIndex = 3
        Me.prog_bar.Visible = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 172)
        Me.Controls.Add(Me.prog_bar)
        Me.Controls.Add(Me.boxOutFolder)
        Me.Controls.Add(Me.boxInFolder)
        Me.Controls.Add(Me.btnExtract)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.Text = "Extractor de documentos"
        Me.boxInFolder.ResumeLayout(False)
        Me.boxInFolder.PerformLayout()
        Me.boxOutFolder.ResumeLayout(False)
        Me.boxOutFolder.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
