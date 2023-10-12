<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnLotes = New System.Windows.Forms.Button()
        Me.btnCambio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLotes
        '
        Me.btnLotes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLotes.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLotes.Location = New System.Drawing.Point(133, 107)
        Me.btnLotes.Name = "btnLotes"
        Me.btnLotes.Size = New System.Drawing.Size(211, 115)
        Me.btnLotes.TabIndex = 0
        Me.btnLotes.Text = "Calculo de superficie de lotes"
        Me.btnLotes.UseVisualStyleBackColor = True
        '
        'btnCambio
        '
        Me.btnCambio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCambio.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCambio.Location = New System.Drawing.Point(506, 107)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(211, 115)
        Me.btnCambio.TabIndex = 1
        Me.btnCambio.Text = "Casa de cambio"
        Me.btnCambio.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Parcial.My.Resources.Resources.abstract_blurred_color_gradient_background_free_vector
        Me.ClientSize = New System.Drawing.Size(842, 375)
        Me.Controls.Add(Me.btnCambio)
        Me.Controls.Add(Me.btnLotes)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLotes As Button
    Friend WithEvents btnCambio As Button
End Class
