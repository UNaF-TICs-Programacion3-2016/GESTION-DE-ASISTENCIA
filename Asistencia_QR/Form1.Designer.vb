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
        Me.components = New System.ComponentModel.Container()
        Me.QR_Picture = New System.Windows.Forms.PictureBox()
        Me.ASISTENCIA = New System.Windows.Forms.GroupBox()
        Me.list_codigos = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.Btn_detener = New System.Windows.Forms.Button()
        Me.Btn_Iniciar = New System.Windows.Forms.Button()
        Me.Cbo_Camaras = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grid_persona = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.QR_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASISTENCIA.SuspendLayout()
        CType(Me.grid_persona, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ASISTENCIA.Controls.Add(Me.list_codigos)
        Me.ASISTENCIA.Controls.Add(Me.Label2)
        Me.ASISTENCIA.Controls.Add(Me.lbl_Codigo)
        Me.ASISTENCIA.Controls.Add(Me.Btn_detener)
        Me.ASISTENCIA.Controls.Add(Me.Btn_Iniciar)
        Me.ASISTENCIA.Controls.Add(Me.Cbo_Camaras)
        Me.ASISTENCIA.Controls.Add(Me.QR_Picture)
        Me.ASISTENCIA.Font = New System.Drawing.Font("Constantia", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ASISTENCIA.Location = New System.Drawing.Point(12, 12)
        Me.ASISTENCIA.Name = "ASISTENCIA"
        Me.ASISTENCIA.Size = New System.Drawing.Size(622, 392)
        Me.ASISTENCIA.TabIndex = 1
        Me.ASISTENCIA.TabStop = False
        Me.ASISTENCIA.Text = "ASISTENCIA AUTOMATICA"
        '
        'list_codigos
        '
        Me.list_codigos.FormattingEnabled = True
        Me.list_codigos.ItemHeight = 14
        Me.list_codigos.Location = New System.Drawing.Point(435, 131)
        Me.list_codigos.Name = "list_codigos"
        Me.list_codigos.Size = New System.Drawing.Size(156, 228)
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
        'lbl_Codigo
        '
        Me.lbl_Codigo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Font = New System.Drawing.Font("Constantia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Codigo.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Codigo.Location = New System.Drawing.Point(48, 351)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(0, 23)
        Me.lbl_Codigo.TabIndex = 5
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
        'grid_persona
        '
        Me.grid_persona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_persona.Location = New System.Drawing.Point(640, 59)
        Me.grid_persona.Name = "grid_persona"
        Me.grid_persona.Size = New System.Drawing.Size(365, 146)
        Me.grid_persona.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(757, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 462)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grid_persona)
        Me.Controls.Add(Me.ASISTENCIA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.QR_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASISTENCIA.ResumeLayout(False)
        Me.ASISTENCIA.PerformLayout()
        CType(Me.grid_persona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QR_Picture As PictureBox
    Friend WithEvents ASISTENCIA As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Codigo As Label
    Friend WithEvents Btn_detener As Button
    Friend WithEvents Btn_Iniciar As Button
    Friend WithEvents Cbo_Camaras As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents list_codigos As ListBox
    Friend WithEvents grid_persona As DataGridView
    Friend WithEvents Button1 As Button
End Class
