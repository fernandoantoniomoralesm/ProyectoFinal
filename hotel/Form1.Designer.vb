<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Id_estadiaLabel As System.Windows.Forms.Label
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim Id_empleadoLabel As System.Windows.Forms.Label
        Dim Id_habitacionLabel As System.Windows.Forms.Label
        Dim Fecha_ingresoLabel As System.Windows.Forms.Label
        Dim Hora_salidaLabel As System.Windows.Forms.Label
        Dim Num_personasLabel As System.Windows.Forms.Label
        Dim Fecha_salidaLabel As System.Windows.Forms.Label
        Dim Id_servicioLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HotelDataSet = New hotel.hotelDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New hotel.hotelDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New hotel.hotelDataSetTableAdapters.TableAdapterManager()
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EstadiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadiaTableAdapter = New hotel.hotelDataSetTableAdapters.estadiaTableAdapter()
        Me.EstadiaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_estadiaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Id_empleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_habitacionTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_ingresoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Hora_salidaTextBox = New System.Windows.Forms.TextBox()
        Me.Num_personasTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_salidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Id_servicioTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Id_estadiaLabel = New System.Windows.Forms.Label()
        Id_clienteLabel = New System.Windows.Forms.Label()
        Id_empleadoLabel = New System.Windows.Forms.Label()
        Id_habitacionLabel = New System.Windows.Forms.Label()
        Fecha_ingresoLabel = New System.Windows.Forms.Label()
        Hora_salidaLabel = New System.Windows.Forms.Label()
        Num_personasLabel = New System.Windows.Forms.Label()
        Fecha_salidaLabel = New System.Windows.Forms.Label()
        Id_servicioLabel = New System.Windows.Forms.Label()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.EstadiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(549, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HotelDataSet
        '
        Me.HotelDataSet.DataSetName = "hotelDataSet"
        Me.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.HotelDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.estadiaTableAdapter = Me.EstadiaTableAdapter
        Me.TableAdapterManager.habitacionTableAdapter = Nothing
        Me.TableAdapterManager.servicio_opcionalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = hotel.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(1053, 25)
        Me.ClienteBindingNavigator.TabIndex = 11
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ClienteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EstadiaBindingSource
        '
        Me.EstadiaBindingSource.DataMember = "estadia"
        Me.EstadiaBindingSource.DataSource = Me.HotelDataSet
        '
        'EstadiaTableAdapter
        '
        Me.EstadiaTableAdapter.ClearBeforeFill = True
        '
        'EstadiaDataGridView
        '
        Me.EstadiaDataGridView.AutoGenerateColumns = False
        Me.EstadiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstadiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.EstadiaDataGridView.DataSource = Me.EstadiaBindingSource
        Me.EstadiaDataGridView.Location = New System.Drawing.Point(700, 129)
        Me.EstadiaDataGridView.Name = "EstadiaDataGridView"
        Me.EstadiaDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.EstadiaDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_estadia"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_estadia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_empleado"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_empleado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_habitacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_habitacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "hora_salida"
        Me.DataGridViewTextBoxColumn6.HeaderText = "hora_salida"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "num_personas"
        Me.DataGridViewTextBoxColumn7.HeaderText = "num_personas"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fecha_salida"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fecha_salida"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_servicio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "id_servicio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Id_estadiaLabel
        '
        Id_estadiaLabel.AutoSize = True
        Id_estadiaLabel.Location = New System.Drawing.Point(391, 132)
        Id_estadiaLabel.Name = "Id_estadiaLabel"
        Id_estadiaLabel.Size = New System.Drawing.Size(55, 13)
        Id_estadiaLabel.TabIndex = 11
        Id_estadiaLabel.Text = "id estadia:"
        '
        'Id_estadiaTextBox
        '
        Me.Id_estadiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadiaBindingSource, "id_estadia", True))
        Me.Id_estadiaTextBox.Location = New System.Drawing.Point(473, 129)
        Me.Id_estadiaTextBox.Name = "Id_estadiaTextBox"
        Me.Id_estadiaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_estadiaTextBox.TabIndex = 12
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Location = New System.Drawing.Point(391, 158)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(52, 13)
        Id_clienteLabel.TabIndex = 13
        Id_clienteLabel.Text = "id cliente:"
        '
        'Id_clienteTextBox
        '
        Me.Id_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadiaBindingSource, "id_cliente", True))
        Me.Id_clienteTextBox.Location = New System.Drawing.Point(473, 155)
        Me.Id_clienteTextBox.Name = "Id_clienteTextBox"
        Me.Id_clienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_clienteTextBox.TabIndex = 14
        '
        'Id_empleadoLabel
        '
        Id_empleadoLabel.AutoSize = True
        Id_empleadoLabel.Location = New System.Drawing.Point(391, 184)
        Id_empleadoLabel.Name = "Id_empleadoLabel"
        Id_empleadoLabel.Size = New System.Drawing.Size(67, 13)
        Id_empleadoLabel.TabIndex = 15
        Id_empleadoLabel.Text = "id empleado:"
        '
        'Id_empleadoTextBox
        '
        Me.Id_empleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadiaBindingSource, "id_empleado", True))
        Me.Id_empleadoTextBox.Location = New System.Drawing.Point(473, 181)
        Me.Id_empleadoTextBox.Name = "Id_empleadoTextBox"
        Me.Id_empleadoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_empleadoTextBox.TabIndex = 16
        '
        'Id_habitacionLabel
        '
        Id_habitacionLabel.AutoSize = True
        Id_habitacionLabel.Location = New System.Drawing.Point(391, 210)
        Id_habitacionLabel.Name = "Id_habitacionLabel"
        Id_habitacionLabel.Size = New System.Drawing.Size(70, 13)
        Id_habitacionLabel.TabIndex = 17
        Id_habitacionLabel.Text = "id habitacion:"
        '
        'Id_habitacionTextBox
        '
        Me.Id_habitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadiaBindingSource, "id_habitacion", True))
        Me.Id_habitacionTextBox.Location = New System.Drawing.Point(473, 207)
        Me.Id_habitacionTextBox.Name = "Id_habitacionTextBox"
        Me.Id_habitacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_habitacionTextBox.TabIndex = 18
        '
        'Fecha_ingresoLabel
        '
        Fecha_ingresoLabel.AutoSize = True
        Fecha_ingresoLabel.Location = New System.Drawing.Point(391, 237)
        Fecha_ingresoLabel.Name = "Fecha_ingresoLabel"
        Fecha_ingresoLabel.Size = New System.Drawing.Size(74, 13)
        Fecha_ingresoLabel.TabIndex = 19
        Fecha_ingresoLabel.Text = "fecha ingreso:"
        '
        'Fecha_ingresoDateTimePicker
        '
        Me.Fecha_ingresoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstadiaBindingSource, "fecha_ingreso", True))
        Me.Fecha_ingresoDateTimePicker.Location = New System.Drawing.Point(473, 233)
        Me.Fecha_ingresoDateTimePicker.Name = "Fecha_ingresoDateTimePicker"
        Me.Fecha_ingresoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_ingresoDateTimePicker.TabIndex = 20
        '
        'Hora_salidaLabel
        '
        Hora_salidaLabel.AutoSize = True
        Hora_salidaLabel.Location = New System.Drawing.Point(391, 262)
        Hora_salidaLabel.Name = "Hora_salidaLabel"
        Hora_salidaLabel.Size = New System.Drawing.Size(61, 13)
        Hora_salidaLabel.TabIndex = 21
        Hora_salidaLabel.Text = "hora salida:"
        '
        'Hora_salidaTextBox
        '
        Me.Hora_salidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadiaBindingSource, "hora_salida", True))
        Me.Hora_salidaTextBox.Location = New System.Drawing.Point(473, 259)
        Me.Hora_salidaTextBox.Name = "Hora_salidaTextBox"
        Me.Hora_salidaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Hora_salidaTextBox.TabIndex = 22
        '
        'Num_personasLabel
        '
        Num_personasLabel.AutoSize = True
        Num_personasLabel.Location = New System.Drawing.Point(391, 288)
        Num_personasLabel.Name = "Num_personasLabel"
        Num_personasLabel.Size = New System.Drawing.Size(76, 13)
        Num_personasLabel.TabIndex = 23
        Num_personasLabel.Text = "num personas:"
        '
        'Num_personasTextBox
        '
        Me.Num_personasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadiaBindingSource, "num_personas", True))
        Me.Num_personasTextBox.Location = New System.Drawing.Point(473, 285)
        Me.Num_personasTextBox.Name = "Num_personasTextBox"
        Me.Num_personasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Num_personasTextBox.TabIndex = 24
        '
        'Fecha_salidaLabel
        '
        Fecha_salidaLabel.AutoSize = True
        Fecha_salidaLabel.Location = New System.Drawing.Point(391, 315)
        Fecha_salidaLabel.Name = "Fecha_salidaLabel"
        Fecha_salidaLabel.Size = New System.Drawing.Size(67, 13)
        Fecha_salidaLabel.TabIndex = 25
        Fecha_salidaLabel.Text = "fecha salida:"
        '
        'Fecha_salidaDateTimePicker
        '
        Me.Fecha_salidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EstadiaBindingSource, "fecha_salida", True))
        Me.Fecha_salidaDateTimePicker.Location = New System.Drawing.Point(473, 311)
        Me.Fecha_salidaDateTimePicker.Name = "Fecha_salidaDateTimePicker"
        Me.Fecha_salidaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_salidaDateTimePicker.TabIndex = 26
        '
        'Id_servicioLabel
        '
        Id_servicioLabel.AutoSize = True
        Id_servicioLabel.Location = New System.Drawing.Point(391, 340)
        Id_servicioLabel.Name = "Id_servicioLabel"
        Id_servicioLabel.Size = New System.Drawing.Size(57, 13)
        Id_servicioLabel.TabIndex = 27
        Id_servicioLabel.Text = "id servicio:"
        '
        'Id_servicioTextBox
        '
        Me.Id_servicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadiaBindingSource, "id_servicio", True))
        Me.Id_servicioTextBox.Location = New System.Drawing.Point(473, 337)
        Me.Id_servicioTextBox.Name = "Id_servicioTextBox"
        Me.Id_servicioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_servicioTextBox.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 39)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "registro"
        Me.Label2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 639)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Id_estadiaLabel)
        Me.Controls.Add(Me.Id_estadiaTextBox)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Me.Id_clienteTextBox)
        Me.Controls.Add(Id_empleadoLabel)
        Me.Controls.Add(Me.Id_empleadoTextBox)
        Me.Controls.Add(Id_habitacionLabel)
        Me.Controls.Add(Me.Id_habitacionTextBox)
        Me.Controls.Add(Fecha_ingresoLabel)
        Me.Controls.Add(Me.Fecha_ingresoDateTimePicker)
        Me.Controls.Add(Hora_salidaLabel)
        Me.Controls.Add(Me.Hora_salidaTextBox)
        Me.Controls.Add(Num_personasLabel)
        Me.Controls.Add(Me.Num_personasTextBox)
        Me.Controls.Add(Fecha_salidaLabel)
        Me.Controls.Add(Me.Fecha_salidaDateTimePicker)
        Me.Controls.Add(Id_servicioLabel)
        Me.Controls.Add(Me.Id_servicioTextBox)
        Me.Controls.Add(Me.EstadiaDataGridView)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.EstadiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents HotelDataSet As hotelDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As hotelDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As hotelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClienteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EstadiaTableAdapter As hotelDataSetTableAdapters.estadiaTableAdapter
    Friend WithEvents EstadiaBindingSource As BindingSource
    Friend WithEvents EstadiaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Id_estadiaTextBox As TextBox
    Friend WithEvents Id_clienteTextBox As TextBox
    Friend WithEvents Id_empleadoTextBox As TextBox
    Friend WithEvents Id_habitacionTextBox As TextBox
    Friend WithEvents Fecha_ingresoDateTimePicker As DateTimePicker
    Friend WithEvents Hora_salidaTextBox As TextBox
    Friend WithEvents Num_personasTextBox As TextBox
    Friend WithEvents Fecha_salidaDateTimePicker As DateTimePicker
    Friend WithEvents Id_servicioTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
