<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        ID_Paciente = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellidos = New DataGridViewTextBoxColumn()
        Fecha_Nacimiento = New DataGridViewTextBoxColumn()
        Pueblo = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Plan = New DataGridViewTextBoxColumn()
        Contrato = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(364, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 43)
        Button1.TabIndex = 39
        Button1.Text = "GUARDAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(654, 107)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(134, 23)
        TextBox4.TabIndex = 38
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(616, 78)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(172, 23)
        TextBox3.TabIndex = 37
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(335, 79)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(186, 23)
        TextBox2.TabIndex = 36
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(95, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(142, 23)
        TextBox1.TabIndex = 35
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(130, 103)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(154, 23)
        ComboBox2.TabIndex = 34
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(186, 40)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(228, 23)
        DateTimePicker1.TabIndex = 33
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(364, 109)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(135, 23)
        ComboBox1.TabIndex = 32
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.RoyalBlue
        Label9.Location = New Point(437, 22)
        Label9.Name = "Label9"
        Label9.Size = New Size(342, 45)
        Label9.TabIndex = 31
        Label9.Text = "PACIENTE EXISTENTE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(237, 30)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 15)
        Label8.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(527, 109)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 21)
        Label7.TabIndex = 29
        Label7.Text = "Num contrato:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(15, 107)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 21)
        Label6.TabIndex = 28
        Label6.Text = "Plan Medico:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(290, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 21)
        Label5.TabIndex = 27
        Label5.Text = "Pueblo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(8, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(172, 21)
        Label4.TabIndex = 26
        Label4.Text = "Fecha de nacimiento:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(527, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 21)
        Label3.TabIndex = 25
        Label3.Text = "Telefono:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(243, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 24
        Label2.Text = "Apellidos:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 21)
        Label1.TabIndex = 23
        Label1.Text = "Nombre:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID_Paciente, Nombre, Apellidos, Fecha_Nacimiento, Pueblo, Telefono, Plan, Contrato})
        DataGridView1.Location = New Point(8, 136)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(794, 276)
        DataGridView1.TabIndex = 42
        ' 
        ' ID_Paciente
        ' 
        ID_Paciente.HeaderText = "ID_Paciente"
        ID_Paciente.Name = "ID_Paciente"
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' Apellidos
        ' 
        Apellidos.HeaderText = "Apellidos"
        Apellidos.Name = "Apellidos"
        ' 
        ' Fecha_Nacimiento
        ' 
        Fecha_Nacimiento.HeaderText = "Fecha_Nacimiento"
        Fecha_Nacimiento.Name = "Fecha_Nacimiento"
        ' 
        ' Pueblo
        ' 
        Pueblo.HeaderText = "Pueblo"
        Pueblo.Name = "Pueblo"
        ' 
        ' Telefono
        ' 
        Telefono.HeaderText = "Telefono"
        Telefono.Name = "Telefono"
        ' 
        ' Plan
        ' 
        Plan.HeaderText = "Plan"
        Plan.Name = "Plan"
        ' 
        ' Contrato
        ' 
        Contrato.HeaderText = "Contrato"
        Contrato.Name = "Contrato"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID_Paciente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Pueblo As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Plan As DataGridViewTextBoxColumn
    Friend WithEvents Contrato As DataGridViewTextBoxColumn
End Class
