<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.Location = New System.Drawing.Point(366, 195)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(84, 23)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Iniciar Sesion"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(303, 97)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(122, 23)
        Me.txtUser.TabIndex = 6
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(303, 131)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(122, 23)
        Me.txtPsw.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(263, 195)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Linen
        Me.Label1.Location = New System.Drawing.Point(246, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 47)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Bienvenido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.LightYellow
        Me.Label2.Location = New System.Drawing.Point(238, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.LightYellow
        Me.Label3.Location = New System.Drawing.Point(214, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = Global.Parcial.My.Resources.Resources.abstract_blurred_color_gradient_background_free_vector
        Me.ClientSize = New System.Drawing.Size(676, 285)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPsw)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
