<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambio
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
        Me.txtCantDolarbox = New System.Windows.Forms.TextBox()
        Me.btnCalcularDolar = New System.Windows.Forms.Button()
        Me.labcantDolar = New System.Windows.Forms.Label()
        Me.labvalDolar = New System.Windows.Forms.Label()
        Me.txtValDolarbox = New System.Windows.Forms.TextBox()
        Me.txtPesosAPagarbox = New System.Windows.Forms.TextBox()
        Me.labpesosAPagar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCantDolarbox
        '
        Me.txtCantDolarbox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCantDolarbox.Location = New System.Drawing.Point(332, 67)
        Me.txtCantDolarbox.Name = "txtCantDolarbox"
        Me.txtCantDolarbox.Size = New System.Drawing.Size(100, 33)
        Me.txtCantDolarbox.TabIndex = 0
        '
        'btnCalcularDolar
        '
        Me.btnCalcularDolar.Location = New System.Drawing.Point(332, 170)
        Me.btnCalcularDolar.Name = "btnCalcularDolar"
        Me.btnCalcularDolar.Size = New System.Drawing.Size(100, 32)
        Me.btnCalcularDolar.TabIndex = 1
        Me.btnCalcularDolar.Text = "Calcular"
        Me.btnCalcularDolar.UseVisualStyleBackColor = True
        '
        'labcantDolar
        '
        Me.labcantDolar.AutoSize = True
        Me.labcantDolar.BackColor = System.Drawing.Color.Transparent
        Me.labcantDolar.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labcantDolar.Location = New System.Drawing.Point(58, 67)
        Me.labcantDolar.Name = "labcantDolar"
        Me.labcantDolar.Size = New System.Drawing.Size(233, 32)
        Me.labcantDolar.TabIndex = 2
        Me.labcantDolar.Text = "Cantidad de dolares"
        '
        'labvalDolar
        '
        Me.labvalDolar.AutoSize = True
        Me.labvalDolar.BackColor = System.Drawing.Color.Transparent
        Me.labvalDolar.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labvalDolar.Location = New System.Drawing.Point(58, 114)
        Me.labvalDolar.Name = "labvalDolar"
        Me.labvalDolar.Size = New System.Drawing.Size(177, 32)
        Me.labvalDolar.TabIndex = 3
        Me.labvalDolar.Text = "Valor del dolar"
        '
        'txtValDolarbox
        '
        Me.txtValDolarbox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtValDolarbox.Location = New System.Drawing.Point(332, 117)
        Me.txtValDolarbox.Name = "txtValDolarbox"
        Me.txtValDolarbox.Size = New System.Drawing.Size(100, 33)
        Me.txtValDolarbox.TabIndex = 4
        '
        'txtPesosAPagarbox
        '
        Me.txtPesosAPagarbox.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPesosAPagarbox.Location = New System.Drawing.Point(332, 223)
        Me.txtPesosAPagarbox.Name = "txtPesosAPagarbox"
        Me.txtPesosAPagarbox.ReadOnly = True
        Me.txtPesosAPagarbox.Size = New System.Drawing.Size(100, 33)
        Me.txtPesosAPagarbox.TabIndex = 6
        '
        'labpesosAPagar
        '
        Me.labpesosAPagar.AutoSize = True
        Me.labpesosAPagar.BackColor = System.Drawing.Color.Transparent
        Me.labpesosAPagar.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labpesosAPagar.Location = New System.Drawing.Point(58, 220)
        Me.labpesosAPagar.Name = "labpesosAPagar"
        Me.labpesosAPagar.Size = New System.Drawing.Size(166, 32)
        Me.labpesosAPagar.TabIndex = 5
        Me.labpesosAPagar.Text = "Pesos a pagar"
        '
        'frmCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Parcial.My.Resources.Resources.abstract_blurred_color_gradient_background_free_vector
        Me.ClientSize = New System.Drawing.Size(637, 314)
        Me.Controls.Add(Me.txtPesosAPagarbox)
        Me.Controls.Add(Me.labpesosAPagar)
        Me.Controls.Add(Me.txtValDolarbox)
        Me.Controls.Add(Me.labvalDolar)
        Me.Controls.Add(Me.labcantDolar)
        Me.Controls.Add(Me.btnCalcularDolar)
        Me.Controls.Add(Me.txtCantDolarbox)
        Me.Name = "frmCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCambio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCantDolarbox As TextBox
    Friend WithEvents btnCalcularDolar As Button
    Friend WithEvents labcantDolar As Label
    Friend WithEvents labvalDolar As Label
    Friend WithEvents txtValDolarbox As TextBox
    Friend WithEvents txtPesosAPagarbox As TextBox
    Friend WithEvents labpesosAPagar As Label
End Class
