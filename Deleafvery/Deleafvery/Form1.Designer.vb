<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RegBtn = New System.Windows.Forms.Button()
        Me.LogBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RegBtn
        '
        Me.RegBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegBtn.Location = New System.Drawing.Point(89, 74)
        Me.RegBtn.Name = "RegBtn"
        Me.RegBtn.Size = New System.Drawing.Size(189, 75)
        Me.RegBtn.TabIndex = 0
        Me.RegBtn.Text = "Registrar"
        Me.RegBtn.UseVisualStyleBackColor = True
        '
        'LogBtn
        '
        Me.LogBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogBtn.Location = New System.Drawing.Point(89, 223)
        Me.LogBtn.Name = "LogBtn"
        Me.LogBtn.Size = New System.Drawing.Size(189, 75)
        Me.LogBtn.TabIndex = 1
        Me.LogBtn.Text = "Iniciar sesion"
        Me.LogBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 386)
        Me.Controls.Add(Me.LogBtn)
        Me.Controls.Add(Me.RegBtn)
        Me.Name = "Form1"
        Me.Text = "Usuario"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegBtn As Button
    Friend WithEvents LogBtn As Button
End Class
