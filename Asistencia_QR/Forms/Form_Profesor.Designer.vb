<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Profesor
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
        Me.lbl_Bienvenida = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pic_profesor = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.comb_materias = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comb_comision = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.pic_profesor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Bienvenida
        '
        Me.lbl_Bienvenida.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Bienvenida.AutoSize = True
        Me.lbl_Bienvenida.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bienvenida.Location = New System.Drawing.Point(89, 40)
        Me.lbl_Bienvenida.Name = "lbl_Bienvenida"
        Me.lbl_Bienvenida.Size = New System.Drawing.Size(61, 18)
        Me.lbl_Bienvenida.TabIndex = 0
        Me.lbl_Bienvenida.Text = "Label1"
        Me.lbl_Bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(365, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pic_profesor
        '
        Me.pic_profesor.Location = New System.Drawing.Point(143, 77)
        Me.pic_profesor.Name = "pic_profesor"
        Me.pic_profesor.Size = New System.Drawing.Size(166, 157)
        Me.pic_profesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_profesor.TabIndex = 7
        Me.pic_profesor.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 24)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'comb_materias
        '
        Me.comb_materias.FormattingEnabled = True
        Me.comb_materias.Location = New System.Drawing.Point(158, 29)
        Me.comb_materias.Name = "comb_materias"
        Me.comb_materias.Size = New System.Drawing.Size(156, 21)
        Me.comb_materias.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Materia :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Comision :"
        '
        'comb_comision
        '
        Me.comb_comision.FormattingEnabled = True
        Me.comb_comision.Location = New System.Drawing.Point(158, 64)
        Me.comb_comision.Name = "comb_comision"
        Me.comb_comision.Size = New System.Drawing.Size(156, 21)
        Me.comb_comision.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tema De Hoy :"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(158, 107)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(174, 21)
        Me.txt_descripcion.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.comb_materias)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.comb_comision)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 158)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Form_Profesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pic_profesor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_Bienvenida)
        Me.Name = "Form_Profesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Clase"
        CType(Me.pic_profesor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Bienvenida As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pic_profesor As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents comb_materias As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents comb_comision As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
