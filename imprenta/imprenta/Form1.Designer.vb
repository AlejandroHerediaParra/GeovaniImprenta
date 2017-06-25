<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Ventas_Btn = New System.Windows.Forms.Button()
        Me.Almacen_Btn = New System.Windows.Forms.Button()
        Me.Produccion_Btn = New System.Windows.Forms.Button()
        Me.Contabilidad_Btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Salir_Btn = New System.Windows.Forms.Button()
        Me.tipoUsuario = New System.Windows.Forms.Label()
        Me.control_de_usuario_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ventas_Btn
        '
        Me.Ventas_Btn.Location = New System.Drawing.Point(12, 41)
        Me.Ventas_Btn.Name = "Ventas_Btn"
        Me.Ventas_Btn.Size = New System.Drawing.Size(169, 112)
        Me.Ventas_Btn.TabIndex = 1
        Me.Ventas_Btn.Text = "VENTAS"
        Me.Ventas_Btn.UseVisualStyleBackColor = True
        '
        'Almacen_Btn
        '
        Me.Almacen_Btn.Location = New System.Drawing.Point(12, 193)
        Me.Almacen_Btn.Name = "Almacen_Btn"
        Me.Almacen_Btn.Size = New System.Drawing.Size(169, 112)
        Me.Almacen_Btn.TabIndex = 2
        Me.Almacen_Btn.Text = "ALMACEN"
        Me.Almacen_Btn.UseVisualStyleBackColor = True
        '
        'Produccion_Btn
        '
        Me.Produccion_Btn.Location = New System.Drawing.Point(204, 193)
        Me.Produccion_Btn.Name = "Produccion_Btn"
        Me.Produccion_Btn.Size = New System.Drawing.Size(169, 112)
        Me.Produccion_Btn.TabIndex = 3
        Me.Produccion_Btn.Text = "PRODUCCION"
        Me.Produccion_Btn.UseVisualStyleBackColor = True
        '
        'Contabilidad_Btn
        '
        Me.Contabilidad_Btn.Location = New System.Drawing.Point(204, 41)
        Me.Contabilidad_Btn.Name = "Contabilidad_Btn"
        Me.Contabilidad_Btn.Size = New System.Drawing.Size(169, 112)
        Me.Contabilidad_Btn.TabIndex = 4
        Me.Contabilidad_Btn.Text = "CONTABILIDAD"
        Me.Contabilidad_Btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.imprenta.My.Resources.Resources.logoinicio
        Me.PictureBox1.Location = New System.Drawing.Point(392, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 272)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Salir_Btn
        '
        Me.Salir_Btn.Location = New System.Drawing.Point(568, 314)
        Me.Salir_Btn.Name = "Salir_Btn"
        Me.Salir_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Salir_Btn.TabIndex = 6
        Me.Salir_Btn.Text = "Salir"
        Me.Salir_Btn.UseVisualStyleBackColor = True
        '
        'tipoUsuario
        '
        Me.tipoUsuario.AutoSize = True
        Me.tipoUsuario.Location = New System.Drawing.Point(596, 19)
        Me.tipoUsuario.Name = "tipoUsuario"
        Me.tipoUsuario.Size = New System.Drawing.Size(0, 13)
        Me.tipoUsuario.TabIndex = 7
        '
        'control_de_usuario_btn
        '
        Me.control_de_usuario_btn.Location = New System.Drawing.Point(13, 314)
        Me.control_de_usuario_btn.Name = "control_de_usuario_btn"
        Me.control_de_usuario_btn.Size = New System.Drawing.Size(168, 23)
        Me.control_de_usuario_btn.TabIndex = 8
        Me.control_de_usuario_btn.Text = "Control de Usuario"
        Me.control_de_usuario_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 349)
        Me.Controls.Add(Me.control_de_usuario_btn)
        Me.Controls.Add(Me.tipoUsuario)
        Me.Controls.Add(Me.Salir_Btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Contabilidad_Btn)
        Me.Controls.Add(Me.Produccion_Btn)
        Me.Controls.Add(Me.Almacen_Btn)
        Me.Controls.Add(Me.Ventas_Btn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCCION"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ventas_Btn As System.Windows.Forms.Button
    Friend WithEvents Almacen_Btn As System.Windows.Forms.Button
    Friend WithEvents Produccion_Btn As System.Windows.Forms.Button
    Friend WithEvents Contabilidad_Btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Salir_Btn As System.Windows.Forms.Button
    Friend WithEvents tipoUsuario As Label
    Friend WithEvents control_de_usuario_btn As Button
End Class
