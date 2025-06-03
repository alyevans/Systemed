<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        DataGridView2 = New DataGridView()
        ID_Medico = New DataGridViewTextBoxColumn()
        Nombre_Medico = New DataGridViewTextBoxColumn()
        Telefono_med = New DataGridViewTextBoxColumn()
        Especialidad = New DataGridViewTextBoxColumn()
        DataGridView3 = New DataGridView()
        Citas = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        Label5 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Contrato = New DataGridViewTextBoxColumn()
        Plan = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Pueblo = New DataGridViewTextBoxColumn()
        Fecha_Nacimiento = New DataGridViewTextBoxColumn()
        Apellidos = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        ID_Paciente = New DataGridViewTextBoxColumn()
        DataGridView1 = New DataGridView()
        ComboBox2 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {ID_Medico, Nombre_Medico, Telefono_med, Especialidad})
        DataGridView2.Location = New Point(310, 87)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(237, 161)
        DataGridView2.TabIndex = 48
        ' 
        ' ID_Medico
        ' 
        ID_Medico.HeaderText = "ID_Medico"
        ID_Medico.Name = "ID_Medico"
        ' 
        ' Nombre_Medico
        ' 
        Nombre_Medico.HeaderText = "Nombre"
        Nombre_Medico.Name = "Nombre_Medico"
        ' 
        ' Telefono_med
        ' 
        Telefono_med.HeaderText = "Telefono"
        Telefono_med.Name = "Telefono_med"
        ' 
        ' Especialidad
        ' 
        Especialidad.HeaderText = "Especialidad"
        Especialidad.Name = "Especialidad"
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToOrderColumns = True
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {Citas, DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8})
        DataGridView3.Location = New Point(574, 89)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(244, 159)
        DataGridView3.TabIndex = 49
        ' 
        ' Citas
        ' 
        Citas.HeaderText = "Citas"
        Citas.Name = "Citas"
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "ID_Paciente"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Apellidos"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "Fecha_Nacimiento"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "Pueblo"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.HeaderText = "Plan"
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.HeaderText = "Contrato"
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(608, 322)
        Button2.Name = "Button2"
        Button2.Size = New Size(184, 50)
        Button2.TabIndex = 50
        Button2.Text = "Buscar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(10, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 21)
        Label5.TabIndex = 53
        Label5.Text = "Nombre:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(599, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 46)
        Button1.TabIndex = 52
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(643, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 25)
        Label4.TabIndex = 47
        Label4.Text = "Citas"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(395, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 46
        Label3.Text = "Medico"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 322)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 54
        Label2.Text = "Apellidos:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(102, 324)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(186, 23)
        TextBox2.TabIndex = 56
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(93, 281)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 23)
        TextBox1.TabIndex = 55
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(102, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 25)
        Label1.TabIndex = 44
        Label1.Text = "Paciente"
        ' 
        ' Contrato
        ' 
        Contrato.HeaderText = "Contrato"
        Contrato.Name = "Contrato"
        ' 
        ' Plan
        ' 
        Plan.HeaderText = "Plan"
        Plan.Name = "Plan"
        ' 
        ' Telefono
        ' 
        Telefono.HeaderText = "Telefono"
        Telefono.Name = "Telefono"
        ' 
        ' Pueblo
        ' 
        Pueblo.HeaderText = "Pueblo"
        Pueblo.Name = "Pueblo"
        ' 
        ' Fecha_Nacimiento
        ' 
        Fecha_Nacimiento.HeaderText = "Fecha_Nacimiento"
        Fecha_Nacimiento.Name = "Fecha_Nacimiento"
        ' 
        ' Apellidos
        ' 
        Apellidos.HeaderText = "Apellidos"
        Apellidos.Name = "Apellidos"
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' ID_Paciente
        ' 
        ID_Paciente.DataPropertyName = "674744"
        ID_Paciente.HeaderText = "ID_Paciente"
        ID_Paciente.Name = "ID_Paciente"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID_Paciente, Nombre, Apellidos, Fecha_Nacimiento, Pueblo, Telefono, Plan, Contrato})
        DataGridView1.Location = New Point(12, 87)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(244, 159)
        DataGridView1.TabIndex = 43
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(310, 281)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(275, 23)
        ComboBox2.TabIndex = 57
        ComboBox2.Text = "Categoria( Citas,Medico,Pacientes)"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(374, 326)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(228, 23)
        DateTimePicker1.TabIndex = 58
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(310, 326)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 21)
        Label6.TabIndex = 59
        Label6.Text = "Fecha:"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(DataGridView3)
        Controls.Add(DataGridView2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Form4"
        Text = " "
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ID_Medico As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Medico As DataGridViewTextBoxColumn
    Friend WithEvents Telefono_med As DataGridViewTextBoxColumn
    Friend WithEvents Especialidad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Citas As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Contrato As DataGridViewTextBoxColumn
    Friend WithEvents Plan As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Pueblo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ID_Paciente As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
