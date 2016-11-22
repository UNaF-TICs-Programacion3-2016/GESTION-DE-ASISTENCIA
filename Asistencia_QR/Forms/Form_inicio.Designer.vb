<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_inicio


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
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pic_perfil = New System.Windows.Forms.PictureBox()
        Me.ASISTENCIA = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_claseNoIniciada = New System.Windows.Forms.Label()
        Me.lbl_clase_Tema = New System.Windows.Forms.Label()
        Me.lbl_clase = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.PBClima = New System.Windows.Forms.PictureBox()
        Me.LabelPrecip = New System.Windows.Forms.Label()
        Me.LabelDia = New System.Windows.Forms.Label()
        Me.LabelViento = New System.Windows.Forms.Label()
        Me.LabelHumedad = New System.Windows.Forms.Label()
        Me.LabelClima = New System.Windows.Forms.Label()
        Me.LabelTemp = New System.Windows.Forms.Label()
        Me.LabelCiudad = New System.Windows.Forms.Label()
        Me.WebBrowserClima = New System.Windows.Forms.WebBrowser()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Timer_Clima = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_nombre_desaparece = New System.Windows.Forms.Timer(Me.components)
        CType(Me.QR_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASISTENCIA.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBClima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.lbl_hora.Location = New System.Drawing.Point(1028, 28)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_hora.Size = New System.Drawing.Size(0, 37)
        Me.lbl_hora.TabIndex = 2
        '
        'lbl_minuto
        '
        Me.lbl_minuto.AutoSize = True
        Me.lbl_minuto.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minuto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_minuto.Location = New System.Drawing.Point(1085, 28)
        Me.lbl_minuto.Name = "lbl_minuto"
        Me.lbl_minuto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_minuto.Size = New System.Drawing.Size(0, 37)
        Me.lbl_minuto.TabIndex = 3
        '
        'Lbl_segundo
        '
        Me.Lbl_segundo.AutoSize = True
        Me.Lbl_segundo.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_segundo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_segundo.Location = New System.Drawing.Point(1142, 28)
        Me.Lbl_segundo.Name = "Lbl_segundo"
        Me.Lbl_segundo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Lbl_segundo.Size = New System.Drawing.Size(0, 37)
        Me.Lbl_segundo.TabIndex = 4
        '
        'Punto1
        '
        Me.Punto1.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Punto1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Punto1.Location = New System.Drawing.Point(1070, 28)
        Me.Punto1.Name = "Punto1"
        Me.Punto1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Punto1.Size = New System.Drawing.Size(20, 37)
        Me.Punto1.TabIndex = 5
        '
        'punto2
        '
        Me.punto2.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.punto2.Location = New System.Drawing.Point(1129, 28)
        Me.punto2.Name = "punto2"
        Me.punto2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.punto2.Size = New System.Drawing.Size(18, 37)
        Me.punto2.TabIndex = 6
        '
        'QR_Picture
        '
        Me.QR_Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.QR_Picture.ErrorImage = Nothing
        Me.QR_Picture.Location = New System.Drawing.Point(111, 19)
        Me.QR_Picture.Name = "QR_Picture"
        Me.QR_Picture.Size = New System.Drawing.Size(409, 309)
        Me.QR_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QR_Picture.TabIndex = 0
        Me.QR_Picture.TabStop = False
        '
        'Cbo_Camaras
        '
        Me.Cbo_Camaras.FormattingEnabled = True
        Me.Cbo_Camaras.Location = New System.Drawing.Point(542, 53)
        Me.Cbo_Camaras.Name = "Cbo_Camaras"
        Me.Cbo_Camaras.Size = New System.Drawing.Size(183, 22)
        Me.Cbo_Camaras.TabIndex = 3
        '
        'Btn_Iniciar
        '
        Me.Btn_Iniciar.BackColor = System.Drawing.Color.Gainsboro
        Me.Btn_Iniciar.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Iniciar.Location = New System.Drawing.Point(638, 81)
        Me.Btn_Iniciar.Name = "Btn_Iniciar"
        Me.Btn_Iniciar.Size = New System.Drawing.Size(87, 27)
        Me.Btn_Iniciar.TabIndex = 2
        Me.Btn_Iniciar.Text = "INICIAR"
        Me.Btn_Iniciar.UseVisualStyleBackColor = False
        '
        'lbl_nombre
        '
        Me.lbl_nombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Constantia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Blue
        Me.lbl_nombre.Location = New System.Drawing.Point(194, 360)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(0, 23)
        Me.lbl_nombre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(539, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Camara :"
        '
        'Pic_perfil
        '
        Me.Pic_perfil.ErrorImage = CType(resources.GetObject("Pic_perfil.ErrorImage"), System.Drawing.Image)
        Me.Pic_perfil.Location = New System.Drawing.Point(46, 334)
        Me.Pic_perfil.Name = "Pic_perfil"
        Me.Pic_perfil.Size = New System.Drawing.Size(115, 74)
        Me.Pic_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_perfil.TabIndex = 9
        Me.Pic_perfil.TabStop = False
        '
        'ASISTENCIA
        '
        Me.ASISTENCIA.Controls.Add(Me.Pic_perfil)
        Me.ASISTENCIA.Controls.Add(Me.Label2)
        Me.ASISTENCIA.Controls.Add(Me.Btn_Iniciar)
        Me.ASISTENCIA.Controls.Add(Me.lbl_nombre)
        Me.ASISTENCIA.Controls.Add(Me.QR_Picture)
        Me.ASISTENCIA.Controls.Add(Me.Cbo_Camaras)
        Me.ASISTENCIA.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ASISTENCIA.Location = New System.Drawing.Point(85, 167)
        Me.ASISTENCIA.Name = "ASISTENCIA"
        Me.ASISTENCIA.Size = New System.Drawing.Size(754, 429)
        Me.ASISTENCIA.TabIndex = 1
        Me.ASISTENCIA.TabStop = False
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
        Me.GroupBox1.Size = New System.Drawing.Size(1247, 123)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lbl_claseNoIniciada
        '
        Me.lbl_claseNoIniciada.AutoSize = True
        Me.lbl_claseNoIniciada.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_claseNoIniciada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_claseNoIniciada.Location = New System.Drawing.Point(338, 47)
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
        Me.lbl_clase_Tema.Location = New System.Drawing.Point(63, 72)
        Me.lbl_clase_Tema.Name = "lbl_clase_Tema"
        Me.lbl_clase_Tema.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_clase_Tema.Size = New System.Drawing.Size(0, 37)
        Me.lbl_clase_Tema.TabIndex = 8
        '
        'lbl_clase
        '
        Me.lbl_clase.AutoSize = True
        Me.lbl_clase.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_clase.Location = New System.Drawing.Point(63, 19)
        Me.lbl_clase.Name = "lbl_clase"
        Me.lbl_clase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_clase.Size = New System.Drawing.Size(0, 37)
        Me.lbl_clase.TabIndex = 7
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label34.Location = New System.Drawing.Point(183, 32)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(14, 13)
        Me.Label34.TabIndex = 17
        Me.Label34.Text = "C"
        '
        'PBClima
        '
        Me.PBClima.BackColor = System.Drawing.Color.Transparent
        Me.PBClima.Location = New System.Drawing.Point(22, 32)
        Me.PBClima.Name = "PBClima"
        Me.PBClima.Size = New System.Drawing.Size(97, 96)
        Me.PBClima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBClima.TabIndex = 15
        Me.PBClima.TabStop = False
        '
        'LabelPrecip
        '
        Me.LabelPrecip.AutoSize = True
        Me.LabelPrecip.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrecip.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.LabelPrecip.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelPrecip.Location = New System.Drawing.Point(271, 58)
        Me.LabelPrecip.Name = "LabelPrecip"
        Me.LabelPrecip.Size = New System.Drawing.Size(101, 20)
        Me.LabelPrecip.TabIndex = 10
        Me.LabelPrecip.Text = "Precipitaciones"
        '
        'LabelDia
        '
        Me.LabelDia.AutoSize = True
        Me.LabelDia.BackColor = System.Drawing.Color.Transparent
        Me.LabelDia.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.LabelDia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelDia.Location = New System.Drawing.Point(271, 32)
        Me.LabelDia.Name = "LabelDia"
        Me.LabelDia.Size = New System.Drawing.Size(28, 20)
        Me.LabelDia.TabIndex = 11
        Me.LabelDia.Text = "Dia"
        '
        'LabelViento
        '
        Me.LabelViento.AutoSize = True
        Me.LabelViento.BackColor = System.Drawing.Color.Transparent
        Me.LabelViento.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.LabelViento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelViento.Location = New System.Drawing.Point(277, 111)
        Me.LabelViento.Name = "LabelViento"
        Me.LabelViento.Size = New System.Drawing.Size(47, 20)
        Me.LabelViento.TabIndex = 12
        Me.LabelViento.Text = "Viento"
        '
        'LabelHumedad
        '
        Me.LabelHumedad.AutoSize = True
        Me.LabelHumedad.BackColor = System.Drawing.Color.Transparent
        Me.LabelHumedad.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.LabelHumedad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelHumedad.Location = New System.Drawing.Point(271, 81)
        Me.LabelHumedad.Name = "LabelHumedad"
        Me.LabelHumedad.Size = New System.Drawing.Size(67, 20)
        Me.LabelHumedad.TabIndex = 13
        Me.LabelHumedad.Text = "Humedad"
        '
        'LabelClima
        '
        Me.LabelClima.BackColor = System.Drawing.Color.Transparent
        Me.LabelClima.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.LabelClima.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelClima.Location = New System.Drawing.Point(137, 111)
        Me.LabelClima.Name = "LabelClima"
        Me.LabelClima.Size = New System.Drawing.Size(146, 44)
        Me.LabelClima.TabIndex = 14
        Me.LabelClima.Text = "Clima"
        '
        'LabelTemp
        '
        Me.LabelTemp.AutoSize = True
        Me.LabelTemp.BackColor = System.Drawing.Color.Transparent
        Me.LabelTemp.Font = New System.Drawing.Font("Arial Narrow", 30.0!)
        Me.LabelTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTemp.Location = New System.Drawing.Point(125, 32)
        Me.LabelTemp.Name = "LabelTemp"
        Me.LabelTemp.Size = New System.Drawing.Size(56, 46)
        Me.LabelTemp.TabIndex = 9
        Me.LabelTemp.Text = "00"
        '
        'LabelCiudad
        '
        Me.LabelCiudad.AutoSize = True
        Me.LabelCiudad.BackColor = System.Drawing.Color.Transparent
        Me.LabelCiudad.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.LabelCiudad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelCiudad.Location = New System.Drawing.Point(137, 78)
        Me.LabelCiudad.Name = "LabelCiudad"
        Me.LabelCiudad.Size = New System.Drawing.Size(60, 23)
        Me.LabelCiudad.TabIndex = 8
        Me.LabelCiudad.Text = "Ciudad"
        '
        'WebBrowserClima
        '
        Me.WebBrowserClima.Location = New System.Drawing.Point(1267, 609)
        Me.WebBrowserClima.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserClima.Name = "WebBrowserClima"
        Me.WebBrowserClima.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowserClima.TabIndex = 20
        Me.WebBrowserClima.Url = New System.Uri("https://www.google.com.mx/?gws_rd=ssl#q=clima", System.UriKind.Absolute)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Controls.Add(Me.PBClima)
        Me.GroupBox2.Controls.Add(Me.LabelTemp)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.LabelCiudad)
        Me.GroupBox2.Controls.Add(Me.LabelViento)
        Me.GroupBox2.Controls.Add(Me.LabelPrecip)
        Me.GroupBox2.Controls.Add(Me.LabelHumedad)
        Me.GroupBox2.Controls.Add(Me.LabelClima)
        Me.GroupBox2.Controls.Add(Me.LabelDia)
        Me.GroupBox2.Location = New System.Drawing.Point(897, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 175)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Timer_Clima
        '
        Me.Timer_Clima.Interval = 3000
        '
        'Timer_nombre_desaparece
        '
        Me.Timer_nombre_desaparece.Interval = 3000
        '
        'Form_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(1348, 636)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.WebBrowserClima)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ASISTENCIA)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Asistencia Automatico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.QR_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASISTENCIA.ResumeLayout(False)
        Me.ASISTENCIA.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBClima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Pic_perfil As PictureBox
    Friend WithEvents ASISTENCIA As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_clase As Label
    Friend WithEvents lbl_clase_Tema As Label
    Friend WithEvents lbl_claseNoIniciada As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents PBClima As PictureBox
    Friend WithEvents LabelPrecip As Label
    Friend WithEvents LabelDia As Label
    Friend WithEvents LabelViento As Label
    Friend WithEvents LabelHumedad As Label
    Friend WithEvents LabelClima As Label
    Friend WithEvents LabelTemp As Label
    Friend WithEvents LabelCiudad As Label
    Friend WithEvents WebBrowserClima As WebBrowser
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Timer_Clima As Timer
    Friend WithEvents Timer_nombre_desaparece As Timer
End Class
