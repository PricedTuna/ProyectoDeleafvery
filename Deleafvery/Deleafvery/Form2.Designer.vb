<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.correoSearch = New System.Windows.Forms.TextBox()
        Me.contraSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogInBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo"
        '
        'correoSearch
        '
        Me.correoSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correoSearch.Location = New System.Drawing.Point(103, 109)
        Me.correoSearch.Name = "correoSearch"
        Me.correoSearch.Size = New System.Drawing.Size(150, 30)
        Me.correoSearch.TabIndex = 1
        '
        'contraSearch
        '
        Me.contraSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contraSearch.Location = New System.Drawing.Point(103, 207)
        Me.contraSearch.Name = "contraSearch"
        Me.contraSearch.Size = New System.Drawing.Size(150, 30)
        Me.contraSearch.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'LogInBtn
        '
        Me.LogInBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInBtn.Location = New System.Drawing.Point(103, 285)
        Me.LogInBtn.Name = "LogInBtn"
        Me.LogInBtn.Size = New System.Drawing.Size(150, 53)
        Me.LogInBtn.TabIndex = 4
        Me.LogInBtn.Text = "Iniciar sesion"
        Me.LogInBtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 421)
        Me.Controls.Add(Me.LogInBtn)
        Me.Controls.Add(Me.contraSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.correoSearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents correoSearch As TextBox
    Friend WithEvents contraSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LogInBtn As Button
End Class
