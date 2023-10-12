<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotes
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
        Me.labLado1 = New System.Windows.Forms.Label()
        Me.labLado2 = New System.Windows.Forms.Label()
        Me.labSuperficie = New System.Windows.Forms.Label()
        Me.txtLado1box = New System.Windows.Forms.TextBox()
        Me.txtLado2box = New System.Windows.Forms.TextBox()
        Me.txtSuperficiebox = New System.Windows.Forms.TextBox()
        Me.btnCalcularLote = New System.Windows.Forms.Button()
        Me.labMtsCuadrados = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labLado1
        '
        Me.labLado1.AutoSize = True
        Me.labLado1.BackColor = System.Drawing.Color.Transparent
        Me.labLado1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labLado1.ForeColor = System.Drawing.Color.White
        Me.labLado1.Location = New System.Drawing.Point(127, 82)
        Me.labLado1.Name = "labLado1"
        Me.labLado1.Size = New System.Drawing.Size(218, 32)
        Me.labLado1.TabIndex = 3
        Me.labLado1.Text = "Ingrese la longitud"
        '
        'labLado2
        '
        Me.labLado2.AutoSize = True
        Me.labLado2.BackColor = System.Drawing.Color.Transparent
        Me.labLado2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labLado2.ForeColor = System.Drawing.Color.White
        Me.labLado2.Location = New System.Drawing.Point(127, 154)
        Me.labLado2.Name = "labLado2"
        Me.labLado2.Size = New System.Drawing.Size(217, 32)
        Me.labLado2.TabIndex = 4
        Me.labLado2.Text = "Ingrese la anchura"
        '
        'labSuperficie
        '
        Me.labSuperficie.AutoSize = True
        Me.labSuperficie.BackColor = System.Drawing.Color.Transparent
        Me.labSuperficie.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labSuperficie.ForeColor = System.Drawing.Color.White
        Me.labSuperficie.Location = New System.Drawing.Point(108, 272)
        Me.labSuperficie.Name = "labSuperficie"
        Me.labSuperficie.Size = New System.Drawing.Size(213, 32)
        Me.labSuperficie.TabIndex = 5
        Me.labSuperficie.Text = "Total de superficie"
        '
        'txtLado1box
        '
        Me.txtLado1box.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtLado1box.Location = New System.Drawing.Point(351, 85)
        Me.txtLado1box.Name = "txtLado1box"
        Me.txtLado1box.Size = New System.Drawing.Size(129, 33)
        Me.txtLado1box.TabIndex = 6
        '
        'txtLado2box
        '
        Me.txtLado2box.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtLado2box.Location = New System.Drawing.Point(351, 155)
        Me.txtLado2box.Name = "txtLado2box"
        Me.txtLado2box.Size = New System.Drawing.Size(129, 33)
        Me.txtLado2box.TabIndex = 7
        '
        'txtSuperficiebox
        '
        Me.txtSuperficiebox.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSuperficiebox.Location = New System.Drawing.Point(351, 275)
        Me.txtSuperficiebox.Name = "txtSuperficiebox"
        Me.txtSuperficiebox.ReadOnly = True
        Me.txtSuperficiebox.Size = New System.Drawing.Size(129, 33)
        Me.txtSuperficiebox.TabIndex = 8
        '
        'btnCalcularLote
        '
        Me.btnCalcularLote.Location = New System.Drawing.Point(368, 221)
        Me.btnCalcularLote.Name = "btnCalcularLote"
        Me.btnCalcularLote.Size = New System.Drawing.Size(93, 23)
        Me.btnCalcularLote.TabIndex = 9
        Me.btnCalcularLote.Text = "Calcular"
        Me.btnCalcularLote.UseVisualStyleBackColor = True
        '
        'labMtsCuadrados
        '
        Me.labMtsCuadrados.AutoSize = True
        Me.labMtsCuadrados.BackColor = System.Drawing.Color.Transparent
        Me.labMtsCuadrados.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.labMtsCuadrados.ForeColor = System.Drawing.Color.White
        Me.labMtsCuadrados.Location = New System.Drawing.Point(504, 272)
        Me.labMtsCuadrados.Name = "labMtsCuadrados"
        Me.labMtsCuadrados.Size = New System.Drawing.Size(207, 32)
        Me.labMtsCuadrados.TabIndex = 10
        Me.labMtsCuadrados.Text = "metros cuadrados"
        '
        'frmLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Parcial.My.Resources.Resources.abstract_blurred_color_gradient_background_free_vector
        Me.ClientSize = New System.Drawing.Size(832, 426)
        Me.Controls.Add(Me.labMtsCuadrados)
        Me.Controls.Add(Me.btnCalcularLote)
        Me.Controls.Add(Me.txtSuperficiebox)
        Me.Controls.Add(Me.txtLado2box)
        Me.Controls.Add(Me.txtLado1box)
        Me.Controls.Add(Me.labSuperficie)
        Me.Controls.Add(Me.labLado2)
        Me.Controls.Add(Me.labLado1)
        Me.Name = "frmLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLotes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labLado1 As Label
    Friend WithEvents labLado2 As Label
    Friend WithEvents labSuperficie As Label
    Friend WithEvents txtLado1box As TextBox
    Friend WithEvents txtLado2box As TextBox
    Friend WithEvents txtSuperficiebox As TextBox
    Friend WithEvents btnCalcularLote As Button
    Friend WithEvents labMtsCuadrados As Label
End Class
