<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_lector_asistencia
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
        Me.QR_Picture = New System.Windows.Forms.PictureBox()
        Me.ASISTENCIA = New System.Windows.Forms.GroupBox()
        Me.Pic_perfil = New System.Windows.Forms.PictureBox()
        Me.list_codigos = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Btn_detener = New System.Windows.Forms.Button()
        Me.Btn_Iniciar = New System.Windows.Forms.Button()
        Me.Cbo_Camaras = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HORA_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_minuto = New System.Windows.Forms.Label()
        Me.Lbl_segundo = New System.Windows.Forms.Label()
        Me.Punto1 = New System.Windows.Forms.Label()
        Me.punto2 = New System.Windows.Forms.Label()
        CType(Me.QR_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASISTENCIA.SuspendLayout()
        CType(Me.Pic_perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QR_Picture
        '
        Me.QR_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.QR_Picture.ErrorImage = Nothing
        Me.QR_Picture.Location = New System.Drawing.Point(6, 19)
        Me.QR_Picture.Name = "QR_Picture"
        Me.QR_Picture.Size = New System.Drawing.Size(409, 309)
        Me.QR_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QR_Picture.TabIndex = 0
        Me.QR_Picture.TabStop = False
        '
        'ASISTENCIA
        '
        Me.ASISTENCIA.Controls.Add(Me.Pic_perfil)
        Me.ASISTENCIA.Controls.Add(Me.list_codigos)
        Me.ASISTENCIA.Controls.Add(Me.Label2)
        Me.ASISTENCIA.Controls.Add(Me.lbl_nombre)
        Me.ASISTENCIA.Controls.Add(Me.Btn_detener)
        Me.ASISTENCIA.Controls.Add(Me.Btn_Iniciar)
        Me.ASISTENCIA.Controls.Add(Me.Cbo_Camaras)
        Me.ASISTENCIA.Controls.Add(Me.QR_Picture)
        Me.ASISTENCIA.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ASISTENCIA.Location = New System.Drawing.Point(12, 12)
        Me.ASISTENCIA.Name = "ASISTENCIA"
        Me.ASISTENCIA.Size = New System.Drawing.Size(878, 432)
        Me.ASISTENCIA.TabIndex = 1
        Me.ASISTENCIA.TabStop = False
        Me.ASISTENCIA.Text = "ASISTENCIA AUTOMATICA"
        '
        'Pic_perfil
        '
        Me.Pic_perfil.Location = New System.Drawing.Point(17, 334)
        Me.Pic_perfil.Name = "Pic_perfil"
        Me.Pic_perfil.Size = New System.Drawing.Size(115, 74)
        Me.Pic_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_perfil.TabIndex = 9
        Me.Pic_perfil.TabStop = False
        '
        'list_codigos
        '
        Me.list_codigos.FormattingEnabled = True
        Me.list_codigos.ItemHeight = 14
        Me.list_codigos.Location = New System.Drawing.Point(435, 131)
        Me.list_codigos.Name = "list_codigos"
        Me.list_codigos.Size = New System.Drawing.Size(156, 200)
        Me.list_codigos.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(421, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Camara :"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Constantia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Blue
        Me.lbl_nombre.Location = New System.Drawing.Point(161, 363)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(17, 23)
        Me.lbl_nombre.TabIndex = 5
        Me.lbl_nombre.Text = "1"
        '
        'Btn_detener
        '
        Me.Btn_detener.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_detener.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_detener.Location = New System.Drawing.Point(517, 86)
        Me.Btn_detener.Name = "Btn_detener"
        Me.Btn_detener.Size = New System.Drawing.Size(87, 27)
        Me.Btn_detener.TabIndex = 4
        Me.Btn_detener.Text = "DTENER"
        Me.Btn_detener.UseVisualStyleBackColor = False
        '
        'Btn_Iniciar
        '
        Me.Btn_Iniciar.BackColor = System.Drawing.Color.Gainsboro
        Me.Btn_Iniciar.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Iniciar.Location = New System.Drawing.Point(424, 86)
        Me.Btn_Iniciar.Name = "Btn_Iniciar"
        Me.Btn_Iniciar.Size = New System.Drawing.Size(87, 27)
        Me.Btn_Iniciar.TabIndex = 2
        Me.Btn_Iniciar.Text = "INICIAR"
        Me.Btn_Iniciar.UseVisualStyleBackColor = False
        '
        'Cbo_Camaras
        '
        Me.Cbo_Camaras.FormattingEnabled = True
        Me.Cbo_Camaras.Location = New System.Drawing.Point(421, 47)
        Me.Cbo_Camaras.Name = "Cbo_Camaras"
        Me.Cbo_Camaras.Size = New System.Drawing.Size(183, 22)
        Me.Cbo_Camaras.TabIndex = 3
        '
        'Timer1
        '
        '
        'HORA_TIMER
        '
        Me.HORA_TIMER.Interval = 1000
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_hora.Location = New System.Drawing.Point(662, 132)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_hora.Size = New System.Drawing.Size(51, 37)
        Me.lbl_hora.TabIndex = 2
        Me.lbl_hora.Text = "00"
        '
        'lbl_minuto
        '
        Me.lbl_minuto.AutoSize = True
        Me.lbl_minuto.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minuto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_minuto.Location = New System.Drawing.Point(719, 132)
        Me.lbl_minuto.Name = "lbl_minuto"
        Me.lbl_minuto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_minuto.Size = New System.Drawing.Size(51, 37)
        Me.lbl_minuto.TabIndex = 3
        Me.lbl_minuto.Text = "00"
        '
        'Lbl_segundo
        '
        Me.Lbl_segundo.AutoSize = True
        Me.Lbl_segundo.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_segundo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_segundo.Location = New System.Drawing.Point(776, 132)
        Me.Lbl_segundo.Name = "Lbl_segundo"
        Me.Lbl_segundo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_segundo.Size = New System.Drawing.Size(51, 37)
        Me.Lbl_segundo.TabIndex = 4
        Me.Lbl_segundo.Text = "00"
        '
        'Punto1
        '
        Me.Punto1.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Punto1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Punto1.Location = New System.Drawing.Point(702, 132)
        Me.Punto1.Name = "Punto1"
        Me.Punto1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Punto1.Size = New System.Drawing.Size(18, 37)
        Me.Punto1.TabIndex = 5
        Me.Punto1.Text = ":"
        '
        'punto2
        '
        Me.punto2.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.punto2.Location = New System.Drawing.Point(761, 132)
        Me.punto2.Name = "punto2"
        Me.punto2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.punto2.Size = New System.Drawing.Size(18, 37)
        Me.punto2.TabIndex = 6
        Me.punto2.Text = ":"
        '
        'Form_lector_asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 507)
        Me.Controls.Add(Me.punto2)
        Me.Controls.Add(Me.Punto1)
        Me.Controls.Add(Me.Lbl_segundo)
        Me.Controls.Add(Me.lbl_minuto)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.ASISTENCIA)
        Me.Name = "Form_lector_asistencia"
        Me.Text = "Form1"
        CType(Me.QR_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASISTENCIA.ResumeLayout(False)
        Me.ASISTENCIA.PerformLayout()
        CType(Me.Pic_perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QR_Picture As PictureBox
    Friend WithEvents ASISTENCIA As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Btn_detener As Button
    Friend WithEvents Btn_Iniciar As Button
    Friend WithEvents Cbo_Camaras As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents list_codigos As ListBox
    Friend WithEvents HORA_TIMER As Timer
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_minuto As Label
    Friend WithEvents Lbl_segundo As Label
    Friend WithEvents Punto1 As Label
    Friend WithEvents punto2 As Label
    Friend WithEvents Pic_perfil As PictureBox
End Class
