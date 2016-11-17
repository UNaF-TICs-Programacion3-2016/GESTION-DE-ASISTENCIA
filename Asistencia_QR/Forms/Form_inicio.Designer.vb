<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_inicio))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HORA_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_minuto = New System.Windows.Forms.Label()
        Me.Lbl_segundo = New System.Windows.Forms.Label()
        Me.Punto1 = New System.Windows.Forms.Label()
        Me.punto2 = New System.Windows.Forms.Label()
        Me.QR_Picture = New System.Windows.Forms.PictureBox()
        Me.Cbo_Camaras = New System.Windows.Forms.ComboBox()
        Me.Btn_Iniciar = New System.Windows.Forms.Button()
        Me.Btn_detener = New System.Windows.Forms.Button()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.list_codigos = New System.Windows.Forms.ListBox()
        Me.Pic_perfil = New System.Windows.Forms.PictureBox()
        Me.ASISTENCIA = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_claseNoIniciada = New System.Windows.Forms.Label()
        Me.lbl_clase_Tema = New System.Windows.Forms.Label()
        Me.lbl_clase = New System.Windows.Forms.Label()
        CType(Me.QR_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASISTENCIA.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lbl_hora.Location = New System.Drawing.Point(799, 19)
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
        Me.lbl_minuto.Location = New System.Drawing.Point(856, 19)
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
        Me.Lbl_segundo.Location = New System.Drawing.Point(913, 19)
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
        Me.Punto1.Location = New System.Drawing.Point(841, 19)
        Me.Punto1.Name = "Punto1"
        Me.Punto1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Punto1.Size = New System.Drawing.Size(20, 37)
        Me.Punto1.TabIndex = 5
        Me.Punto1.Text = ":"
        '
        'punto2
        '
        Me.punto2.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.punto2.Location = New System.Drawing.Point(900, 19)
        Me.punto2.Name = "punto2"
        Me.punto2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.punto2.Size = New System.Drawing.Size(18, 37)
        Me.punto2.TabIndex = 6
        Me.punto2.Text = ":"
        '
        'QR_Picture
        '
        Me.QR_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.QR_Picture.ErrorImage = Nothing
        Me.QR_Picture.Location = New System.Drawing.Point(64, 19)
        Me.QR_Picture.Name = "QR_Picture"
        Me.QR_Picture.Size = New System.Drawing.Size(409, 309)
        Me.QR_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QR_Picture.TabIndex = 0
        Me.QR_Picture.TabStop = False
        '
        'Cbo_Camaras
        '
        Me.Cbo_Camaras.FormattingEnabled = True
        Me.Cbo_Camaras.Location = New System.Drawing.Point(594, 47)
        Me.Cbo_Camaras.Name = "Cbo_Camaras"
        Me.Cbo_Camaras.Size = New System.Drawing.Size(183, 22)
        Me.Cbo_Camaras.TabIndex = 3
        '
        'Btn_Iniciar
        '
        Me.Btn_Iniciar.BackColor = System.Drawing.Color.Gainsboro
        Me.Btn_Iniciar.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Iniciar.Location = New System.Drawing.Point(594, 75)
        Me.Btn_Iniciar.Name = "Btn_Iniciar"
        Me.Btn_Iniciar.Size = New System.Drawing.Size(87, 27)
        Me.Btn_Iniciar.TabIndex = 2
        Me.Btn_Iniciar.Text = "INICIAR"
        Me.Btn_Iniciar.UseVisualStyleBackColor = False
        '
        'Btn_detener
        '
        Me.Btn_detener.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btn_detener.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_detener.Location = New System.Drawing.Point(687, 75)
        Me.Btn_detener.Name = "Btn_detener"
        Me.Btn_detener.Size = New System.Drawing.Size(87, 27)
        Me.Btn_detener.TabIndex = 4
        Me.Btn_detener.Text = "DTENER"
        Me.Btn_detener.UseVisualStyleBackColor = False
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
        Me.lbl_nombre.Size = New System.Drawing.Size(15, 23)
        Me.lbl_nombre.TabIndex = 5
        Me.lbl_nombre.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(591, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Camara :"
        '
        'list_codigos
        '
        Me.list_codigos.FormattingEnabled = True
        Me.list_codigos.ItemHeight = 14
        Me.list_codigos.Location = New System.Drawing.Point(594, 108)
        Me.list_codigos.Name = "list_codigos"
        Me.list_codigos.Size = New System.Drawing.Size(183, 200)
        Me.list_codigos.TabIndex = 8
        '
        'Pic_perfil
        '
        Me.Pic_perfil.ErrorImage = CType(resources.GetObject("Pic_perfil.ErrorImage"), System.Drawing.Image)
        Me.Pic_perfil.Location = New System.Drawing.Point(17, 334)
        Me.Pic_perfil.Name = "Pic_perfil"
        Me.Pic_perfil.Size = New System.Drawing.Size(115, 74)
        Me.Pic_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_perfil.TabIndex = 9
        Me.Pic_perfil.TabStop = False
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
        Me.ASISTENCIA.Location = New System.Drawing.Point(22, 170)
        Me.ASISTENCIA.Name = "ASISTENCIA"
        Me.ASISTENCIA.Size = New System.Drawing.Size(961, 421)
        Me.ASISTENCIA.TabIndex = 1
        Me.ASISTENCIA.TabStop = False
        Me.ASISTENCIA.Text = "ASISTENCIA AUTOMATICA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_claseNoIniciada)
        Me.GroupBox1.Controls.Add(Me.lbl_clase_Tema)
        Me.GroupBox1.Controls.Add(Me.lbl_clase)
        Me.GroupBox1.Controls.Add(Me.punto2)
        Me.GroupBox1.Controls.Add(Me.Punto1)
        Me.GroupBox1.Controls.Add(Me.Lbl_segundo)
        Me.GroupBox1.Controls.Add(Me.lbl_minuto)
        Me.GroupBox1.Controls.Add(Me.lbl_hora)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(981, 123)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lbl_claseNoIniciada
        '
        Me.lbl_claseNoIniciada.AutoSize = True
        Me.lbl_claseNoIniciada.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_claseNoIniciada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_claseNoIniciada.Location = New System.Drawing.Point(284, 43)
        Me.lbl_claseNoIniciada.Name = "lbl_claseNoIniciada"
        Me.lbl_claseNoIniciada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_claseNoIniciada.Size = New System.Drawing.Size(255, 37)
        Me.lbl_claseNoIniciada.TabIndex = 9
        Me.lbl_claseNoIniciada.Text = "Clase no Iniciada"
        '
        'lbl_clase_Tema
        '
        Me.lbl_clase_Tema.AutoSize = True
        Me.lbl_clase_Tema.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clase_Tema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_clase_Tema.Location = New System.Drawing.Point(46, 74)
        Me.lbl_clase_Tema.Name = "lbl_clase_Tema"
        Me.lbl_clase_Tema.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_clase_Tema.Size = New System.Drawing.Size(25, 37)
        Me.lbl_clase_Tema.TabIndex = 8
        Me.lbl_clase_Tema.Text = "."
        '
        'lbl_clase
        '
        Me.lbl_clase.AutoSize = True
        Me.lbl_clase.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_clase.Location = New System.Drawing.Point(46, 19)
        Me.lbl_clase.Name = "lbl_clase"
        Me.lbl_clase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_clase.Size = New System.Drawing.Size(25, 37)
        Me.lbl_clase.TabIndex = 7
        Me.lbl_clase.Text = "."
        '
        'Form_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 626)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ASISTENCIA)
        Me.Name = "Form_inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Asistencia Automatico"
        CType(Me.QR_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASISTENCIA.ResumeLayout(False)
        Me.ASISTENCIA.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HORA_TIMER As Timer
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_minuto As Label
    Friend WithEvents Lbl_segundo As Label
    Friend WithEvents Punto1 As Label
    Friend WithEvents punto2 As Label
    Friend WithEvents QR_Picture As PictureBox
    Friend WithEvents Cbo_Camaras As ComboBox
    Friend WithEvents Btn_Iniciar As Button
    Friend WithEvents Btn_detener As Button
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents list_codigos As ListBox
    Friend WithEvents Pic_perfil As PictureBox
    Friend WithEvents ASISTENCIA As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_clase As Label
    Friend WithEvents lbl_clase_Tema As Label
    Friend WithEvents lbl_claseNoIniciada As Label
End Class
