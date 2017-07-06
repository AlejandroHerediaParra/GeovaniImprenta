<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contabilidad
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
        Dim Cod_FacturaLabel As System.Windows.Forms.Label
        Dim PedidoCliente_Cod_PedidoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Tipo_MaterialLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim TipoMaterial_Cod_MaterialLabel As System.Windows.Forms.Label
        Dim Proveedor_Cod_ProveedorLabel As System.Windows.Forms.Label
        Dim FechaLabel1 As System.Windows.Forms.Label
        Dim Descripcion_CompraLabel As System.Windows.Forms.Label
        Dim Precio_MaterialLabel As System.Windows.Forms.Label
        Dim CantidadLabel1 As System.Windows.Forms.Label
        Dim Total_CompraLabel As System.Windows.Forms.Label
        Dim DetalleLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NombreLabel2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(contabilidad))
        Me.Salir_Btn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DetalleLabel1 = New System.Windows.Forms.Label()
        Me.PedidosClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImprentaDataSet = New imprenta.imprentaDataSet()
        Me.FacturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cod_FacturaTextBox = New System.Windows.Forms.TextBox()
        Me.PedidoCliente_Cod_PedidoComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tipo_MaterialTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NombreLabel3 = New System.Windows.Forms.Label()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.TipoMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Compras_ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.TipoMaterial_Cod_MaterialComboBox = New System.Windows.Forms.ComboBox()
        Me.Proveedor_Cod_ProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Descripcion_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_MaterialTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox1 = New System.Windows.Forms.TextBox()
        Me.Total_CompraTextBox = New System.Windows.Forms.TextBox()
        Me.Compras_ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaTableAdapter = New imprenta.imprentaDataSetTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager = New imprenta.imprentaDataSetTableAdapters.TableAdapterManager()
        Me.Compras_ProveedorTableAdapter = New imprenta.imprentaDataSetTableAdapters.Compras_ProveedorTableAdapter()
        Me.PedidosClienteTableAdapter = New imprenta.imprentaDataSetTableAdapters.PedidosClienteTableAdapter()
        Me.ProveedorTableAdapter = New imprenta.imprentaDataSetTableAdapters.ProveedorTableAdapter()
        Me.TipoMaterialTableAdapter = New imprenta.imprentaDataSetTableAdapters.TipoMaterialTableAdapter()
        Cod_FacturaLabel = New System.Windows.Forms.Label()
        PedidoCliente_Cod_PedidoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Tipo_MaterialLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        TipoMaterial_Cod_MaterialLabel = New System.Windows.Forms.Label()
        Proveedor_Cod_ProveedorLabel = New System.Windows.Forms.Label()
        FechaLabel1 = New System.Windows.Forms.Label()
        Descripcion_CompraLabel = New System.Windows.Forms.Label()
        Precio_MaterialLabel = New System.Windows.Forms.Label()
        CantidadLabel1 = New System.Windows.Forms.Label()
        Total_CompraLabel = New System.Windows.Forms.Label()
        DetalleLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        NombreLabel2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PedidosClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturaBindingNavigator.SuspendLayout()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Compras_ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Compras_ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_FacturaLabel
        '
        Cod_FacturaLabel.AutoSize = True
        Cod_FacturaLabel.Location = New System.Drawing.Point(12, 35)
        Cod_FacturaLabel.Name = "Cod_FacturaLabel"
        Cod_FacturaLabel.Size = New System.Drawing.Size(68, 13)
        Cod_FacturaLabel.TabIndex = 1
        Cod_FacturaLabel.Text = "Cod Factura:"
        '
        'PedidoCliente_Cod_PedidoLabel
        '
        PedidoCliente_Cod_PedidoLabel.AutoSize = True
        PedidoCliente_Cod_PedidoLabel.Location = New System.Drawing.Point(12, 61)
        PedidoCliente_Cod_PedidoLabel.Name = "PedidoCliente_Cod_PedidoLabel"
        PedidoCliente_Cod_PedidoLabel.Size = New System.Drawing.Size(136, 13)
        PedidoCliente_Cod_PedidoLabel.TabIndex = 3
        PedidoCliente_Cod_PedidoLabel.Text = "Pedido Cliente Cod Pedido:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(12, 89)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'Tipo_MaterialLabel
        '
        Tipo_MaterialLabel.AutoSize = True
        Tipo_MaterialLabel.Location = New System.Drawing.Point(12, 114)
        Tipo_MaterialLabel.Name = "Tipo_MaterialLabel"
        Tipo_MaterialLabel.Size = New System.Drawing.Size(71, 13)
        Tipo_MaterialLabel.TabIndex = 7
        Tipo_MaterialLabel.Text = "Tipo Material:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(375, 35)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 9
        DescripcionLabel.Text = "Descripcion:"
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Location = New System.Drawing.Point(375, 61)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New System.Drawing.Size(49, 13)
        SubtotalLabel.TabIndex = 11
        SubtotalLabel.Text = "Subtotal:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(375, 87)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 13
        TotalLabel.Text = "Total:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(375, 113)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 15
        CantidadLabel.Text = "Cantidad:"
        '
        'TipoMaterial_Cod_MaterialLabel
        '
        TipoMaterial_Cod_MaterialLabel.AutoSize = True
        TipoMaterial_Cod_MaterialLabel.Location = New System.Drawing.Point(16, 34)
        TipoMaterial_Cod_MaterialLabel.Name = "TipoMaterial_Cod_MaterialLabel"
        TipoMaterial_Cod_MaterialLabel.Size = New System.Drawing.Size(133, 13)
        TipoMaterial_Cod_MaterialLabel.TabIndex = 1
        TipoMaterial_Cod_MaterialLabel.Text = "Tipo Material Cod Material:"
        '
        'Proveedor_Cod_ProveedorLabel
        '
        Proveedor_Cod_ProveedorLabel.AutoSize = True
        Proveedor_Cod_ProveedorLabel.Location = New System.Drawing.Point(16, 61)
        Proveedor_Cod_ProveedorLabel.Name = "Proveedor_Cod_ProveedorLabel"
        Proveedor_Cod_ProveedorLabel.Size = New System.Drawing.Size(133, 13)
        Proveedor_Cod_ProveedorLabel.TabIndex = 3
        Proveedor_Cod_ProveedorLabel.Text = "Proveedor Cod Proveedor:"
        '
        'FechaLabel1
        '
        FechaLabel1.AutoSize = True
        FechaLabel1.Location = New System.Drawing.Point(16, 89)
        FechaLabel1.Name = "FechaLabel1"
        FechaLabel1.Size = New System.Drawing.Size(40, 13)
        FechaLabel1.TabIndex = 5
        FechaLabel1.Text = "Fecha:"
        '
        'Descripcion_CompraLabel
        '
        Descripcion_CompraLabel.AutoSize = True
        Descripcion_CompraLabel.Location = New System.Drawing.Point(16, 114)
        Descripcion_CompraLabel.Name = "Descripcion_CompraLabel"
        Descripcion_CompraLabel.Size = New System.Drawing.Size(105, 13)
        Descripcion_CompraLabel.TabIndex = 7
        Descripcion_CompraLabel.Text = "Descripcion Compra:"
        '
        'Precio_MaterialLabel
        '
        Precio_MaterialLabel.AutoSize = True
        Precio_MaterialLabel.Location = New System.Drawing.Point(376, 34)
        Precio_MaterialLabel.Name = "Precio_MaterialLabel"
        Precio_MaterialLabel.Size = New System.Drawing.Size(80, 13)
        Precio_MaterialLabel.TabIndex = 9
        Precio_MaterialLabel.Text = "Precio Material:"
        '
        'CantidadLabel1
        '
        CantidadLabel1.AutoSize = True
        CantidadLabel1.Location = New System.Drawing.Point(376, 60)
        CantidadLabel1.Name = "CantidadLabel1"
        CantidadLabel1.Size = New System.Drawing.Size(52, 13)
        CantidadLabel1.TabIndex = 11
        CantidadLabel1.Text = "Cantidad:"
        '
        'Total_CompraLabel
        '
        Total_CompraLabel.AutoSize = True
        Total_CompraLabel.Location = New System.Drawing.Point(376, 86)
        Total_CompraLabel.Name = "Total_CompraLabel"
        Total_CompraLabel.Size = New System.Drawing.Size(73, 13)
        Total_CompraLabel.TabIndex = 13
        Total_CompraLabel.Text = "Total Compra:"
        '
        'DetalleLabel
        '
        DetalleLabel.AutoSize = True
        DetalleLabel.Location = New System.Drawing.Point(205, 61)
        DetalleLabel.Name = "DetalleLabel"
        DetalleLabel.Size = New System.Drawing.Size(43, 13)
        DetalleLabel.TabIndex = 18
        DetalleLabel.Text = "Detalle:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(202, 34)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 16
        NombreLabel.Text = "Nombre:"
        '
        'NombreLabel2
        '
        NombreLabel2.AutoSize = True
        NombreLabel2.Location = New System.Drawing.Point(202, 61)
        NombreLabel2.Name = "NombreLabel2"
        NombreLabel2.Size = New System.Drawing.Size(47, 13)
        NombreLabel2.TabIndex = 18
        NombreLabel2.Text = "Nombre:"
        '
        'Salir_Btn
        '
        Me.Salir_Btn.Location = New System.Drawing.Point(729, 404)
        Me.Salir_Btn.Name = "Salir_Btn"
        Me.Salir_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Salir_Btn.TabIndex = 1
        Me.Salir_Btn.Text = "Salir"
        Me.Salir_Btn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 386)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(DetalleLabel)
        Me.TabPage1.Controls.Add(Me.DetalleLabel1)
        Me.TabPage1.Controls.Add(Me.FacturaBindingNavigator)
        Me.TabPage1.Controls.Add(Cod_FacturaLabel)
        Me.TabPage1.Controls.Add(Me.Cod_FacturaTextBox)
        Me.TabPage1.Controls.Add(PedidoCliente_Cod_PedidoLabel)
        Me.TabPage1.Controls.Add(Me.PedidoCliente_Cod_PedidoComboBox)
        Me.TabPage1.Controls.Add(FechaLabel)
        Me.TabPage1.Controls.Add(Me.FechaDateTimePicker)
        Me.TabPage1.Controls.Add(Tipo_MaterialLabel)
        Me.TabPage1.Controls.Add(Me.Tipo_MaterialTextBox)
        Me.TabPage1.Controls.Add(DescripcionLabel)
        Me.TabPage1.Controls.Add(Me.DescripcionTextBox)
        Me.TabPage1.Controls.Add(SubtotalLabel)
        Me.TabPage1.Controls.Add(Me.SubtotalTextBox)
        Me.TabPage1.Controls.Add(TotalLabel)
        Me.TabPage1.Controls.Add(Me.TotalTextBox)
        Me.TabPage1.Controls.Add(CantidadLabel)
        Me.TabPage1.Controls.Add(Me.CantidadTextBox)
        Me.TabPage1.Controls.Add(Me.FacturaDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(784, 360)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "FACTURA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DetalleLabel1
        '
        Me.DetalleLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosClienteBindingSource, "Detalle", True))
        Me.DetalleLabel1.Location = New System.Drawing.Point(254, 61)
        Me.DetalleLabel1.Name = "DetalleLabel1"
        Me.DetalleLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DetalleLabel1.TabIndex = 19
        Me.DetalleLabel1.Text = "Label1"
        '
        'PedidosClienteBindingSource
        '
        Me.PedidosClienteBindingSource.DataMember = "PedidosCliente"
        Me.PedidosClienteBindingSource.DataSource = Me.ImprentaDataSet
        '
        'ImprentaDataSet
        '
        Me.ImprentaDataSet.DataSetName = "imprentaDataSet"
        Me.ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingNavigator
        '
        Me.FacturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturaBindingNavigator.BindingSource = Me.FacturaBindingSource
        Me.FacturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacturaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.FacturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturaBindingNavigatorSaveItem})
        Me.FacturaBindingNavigator.Location = New System.Drawing.Point(6, 4)
        Me.FacturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturaBindingNavigator.Name = "FacturaBindingNavigator"
        Me.FacturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturaBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.FacturaBindingNavigator.TabIndex = 3
        Me.FacturaBindingNavigator.Text = "BindingNavigator1"
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
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.ImprentaDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FacturaBindingNavigatorSaveItem
        '
        Me.FacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturaBindingNavigatorSaveItem.Name = "FacturaBindingNavigatorSaveItem"
        Me.FacturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FacturaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Cod_FacturaTextBox
        '
        Me.Cod_FacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Cod_Factura", True))
        Me.Cod_FacturaTextBox.Location = New System.Drawing.Point(154, 32)
        Me.Cod_FacturaTextBox.Name = "Cod_FacturaTextBox"
        Me.Cod_FacturaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cod_FacturaTextBox.TabIndex = 2
        '
        'PedidoCliente_Cod_PedidoComboBox
        '
        Me.PedidoCliente_Cod_PedidoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "PedidoCliente_Cod_Pedido", True))
        Me.PedidoCliente_Cod_PedidoComboBox.DataSource = Me.PedidosClienteBindingSource
        Me.PedidoCliente_Cod_PedidoComboBox.DisplayMember = "Cod_Pedido"
        Me.PedidoCliente_Cod_PedidoComboBox.FormattingEnabled = True
        Me.PedidoCliente_Cod_PedidoComboBox.Location = New System.Drawing.Point(154, 58)
        Me.PedidoCliente_Cod_PedidoComboBox.Name = "PedidoCliente_Cod_PedidoComboBox"
        Me.PedidoCliente_Cod_PedidoComboBox.Size = New System.Drawing.Size(40, 21)
        Me.PedidoCliente_Cod_PedidoComboBox.TabIndex = 4
        Me.PedidoCliente_Cod_PedidoComboBox.ValueMember = "Cod_Pedido"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(154, 85)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 6
        '
        'Tipo_MaterialTextBox
        '
        Me.Tipo_MaterialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Tipo_Material", True))
        Me.Tipo_MaterialTextBox.Location = New System.Drawing.Point(154, 111)
        Me.Tipo_MaterialTextBox.Name = "Tipo_MaterialTextBox"
        Me.Tipo_MaterialTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tipo_MaterialTextBox.TabIndex = 8
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(517, 32)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescripcionTextBox.TabIndex = 10
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Subtotal", True))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(517, 58)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SubtotalTextBox.TabIndex = 12
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(517, 84)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 14
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(517, 110)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox.TabIndex = 16
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(6, 137)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.Size = New System.Drawing.Size(772, 220)
        Me.FacturaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cod_Factura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod_Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PedidoCliente_Cod_Pedido"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PedidoCliente_Cod_Pedido"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tipo_Material"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo_Material"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(NombreLabel2)
        Me.TabPage2.Controls.Add(Me.NombreLabel3)
        Me.TabPage2.Controls.Add(NombreLabel)
        Me.TabPage2.Controls.Add(Me.NombreLabel1)
        Me.TabPage2.Controls.Add(Me.BindingNavigator1)
        Me.TabPage2.Controls.Add(TipoMaterial_Cod_MaterialLabel)
        Me.TabPage2.Controls.Add(Me.TipoMaterial_Cod_MaterialComboBox)
        Me.TabPage2.Controls.Add(Proveedor_Cod_ProveedorLabel)
        Me.TabPage2.Controls.Add(Me.Proveedor_Cod_ProveedorComboBox)
        Me.TabPage2.Controls.Add(FechaLabel1)
        Me.TabPage2.Controls.Add(Me.FechaDateTimePicker1)
        Me.TabPage2.Controls.Add(Descripcion_CompraLabel)
        Me.TabPage2.Controls.Add(Me.Descripcion_CompraTextBox)
        Me.TabPage2.Controls.Add(Precio_MaterialLabel)
        Me.TabPage2.Controls.Add(Me.Precio_MaterialTextBox)
        Me.TabPage2.Controls.Add(CantidadLabel1)
        Me.TabPage2.Controls.Add(Me.CantidadTextBox1)
        Me.TabPage2.Controls.Add(Total_CompraLabel)
        Me.TabPage2.Controls.Add(Me.Total_CompraTextBox)
        Me.TabPage2.Controls.Add(Me.Compras_ProveedorDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(784, 360)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "COMPRAS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NombreLabel3
        '
        Me.NombreLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Nombre", True))
        Me.NombreLabel3.Location = New System.Drawing.Point(255, 61)
        Me.NombreLabel3.Name = "NombreLabel3"
        Me.NombreLabel3.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel3.TabIndex = 19
        Me.NombreLabel3.Text = "Label1"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.ImprentaDataSet
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoMaterialBindingSource, "Nombre", True))
        Me.NombreLabel1.Location = New System.Drawing.Point(255, 34)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel1.TabIndex = 17
        Me.NombreLabel1.Text = "Label1"
        '
        'TipoMaterialBindingSource
        '
        Me.TipoMaterialBindingSource.DataMember = "TipoMaterial"
        Me.TipoMaterialBindingSource.DataSource = Me.ImprentaDataSet
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator1.BindingSource = Me.Compras_ProveedorBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Me.ToolStripButton2
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton7})
        Me.BindingNavigator1.Location = New System.Drawing.Point(6, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(280, 25)
        Me.BindingNavigator1.TabIndex = 15
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Agregar nuevo"
        '
        'Compras_ProveedorBindingSource
        '
        Me.Compras_ProveedorBindingSource.DataMember = "Compras_Proveedor"
        Me.Compras_ProveedorBindingSource.DataSource = Me.ImprentaDataSet
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Eliminar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Mover primero"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Mover siguiente"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Guardar datos"
        '
        'TipoMaterial_Cod_MaterialComboBox
        '
        Me.TipoMaterial_Cod_MaterialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Compras_ProveedorBindingSource, "TipoMaterial_Cod_Material", True))
        Me.TipoMaterial_Cod_MaterialComboBox.DataSource = Me.TipoMaterialBindingSource
        Me.TipoMaterial_Cod_MaterialComboBox.DisplayMember = "Cod_Material"
        Me.TipoMaterial_Cod_MaterialComboBox.FormattingEnabled = True
        Me.TipoMaterial_Cod_MaterialComboBox.Location = New System.Drawing.Point(155, 31)
        Me.TipoMaterial_Cod_MaterialComboBox.Name = "TipoMaterial_Cod_MaterialComboBox"
        Me.TipoMaterial_Cod_MaterialComboBox.Size = New System.Drawing.Size(46, 21)
        Me.TipoMaterial_Cod_MaterialComboBox.TabIndex = 2
        Me.TipoMaterial_Cod_MaterialComboBox.ValueMember = "Cod_Material"
        '
        'Proveedor_Cod_ProveedorComboBox
        '
        Me.Proveedor_Cod_ProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Compras_ProveedorBindingSource, "Proveedor_Cod_Proveedor", True))
        Me.Proveedor_Cod_ProveedorComboBox.DataSource = Me.ProveedorBindingSource
        Me.Proveedor_Cod_ProveedorComboBox.DisplayMember = "Cod_Proveedor"
        Me.Proveedor_Cod_ProveedorComboBox.FormattingEnabled = True
        Me.Proveedor_Cod_ProveedorComboBox.Location = New System.Drawing.Point(155, 58)
        Me.Proveedor_Cod_ProveedorComboBox.Name = "Proveedor_Cod_ProveedorComboBox"
        Me.Proveedor_Cod_ProveedorComboBox.Size = New System.Drawing.Size(46, 21)
        Me.Proveedor_Cod_ProveedorComboBox.TabIndex = 4
        Me.Proveedor_Cod_ProveedorComboBox.ValueMember = "Cod_Proveedor"
        '
        'FechaDateTimePicker1
        '
        Me.FechaDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Compras_ProveedorBindingSource, "Fecha", True))
        Me.FechaDateTimePicker1.Location = New System.Drawing.Point(155, 85)
        Me.FechaDateTimePicker1.Name = "FechaDateTimePicker1"
        Me.FechaDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker1.TabIndex = 6
        '
        'Descripcion_CompraTextBox
        '
        Me.Descripcion_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Compras_ProveedorBindingSource, "Descripcion_Compra", True))
        Me.Descripcion_CompraTextBox.Location = New System.Drawing.Point(155, 111)
        Me.Descripcion_CompraTextBox.Name = "Descripcion_CompraTextBox"
        Me.Descripcion_CompraTextBox.Size = New System.Drawing.Size(560, 20)
        Me.Descripcion_CompraTextBox.TabIndex = 8
        '
        'Precio_MaterialTextBox
        '
        Me.Precio_MaterialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Compras_ProveedorBindingSource, "Precio_Material", True))
        Me.Precio_MaterialTextBox.Location = New System.Drawing.Point(515, 31)
        Me.Precio_MaterialTextBox.Name = "Precio_MaterialTextBox"
        Me.Precio_MaterialTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Precio_MaterialTextBox.TabIndex = 10
        '
        'CantidadTextBox1
        '
        Me.CantidadTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Compras_ProveedorBindingSource, "Cantidad", True))
        Me.CantidadTextBox1.Location = New System.Drawing.Point(515, 57)
        Me.CantidadTextBox1.Name = "CantidadTextBox1"
        Me.CantidadTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.CantidadTextBox1.TabIndex = 12
        '
        'Total_CompraTextBox
        '
        Me.Total_CompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Compras_ProveedorBindingSource, "Total_Compra", True))
        Me.Total_CompraTextBox.Enabled = False
        Me.Total_CompraTextBox.Location = New System.Drawing.Point(515, 83)
        Me.Total_CompraTextBox.Name = "Total_CompraTextBox"
        Me.Total_CompraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Total_CompraTextBox.TabIndex = 14
        '
        'Compras_ProveedorDataGridView
        '
        Me.Compras_ProveedorDataGridView.AutoGenerateColumns = False
        Me.Compras_ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Compras_ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Compras_ProveedorDataGridView.DataSource = Me.Compras_ProveedorBindingSource
        Me.Compras_ProveedorDataGridView.Location = New System.Drawing.Point(6, 137)
        Me.Compras_ProveedorDataGridView.Name = "Compras_ProveedorDataGridView"
        Me.Compras_ProveedorDataGridView.Size = New System.Drawing.Size(772, 220)
        Me.Compras_ProveedorDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TipoMaterial_Cod_Material"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TipoMaterial_Cod_Material"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Proveedor_Cod_Proveedor"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Proveedor_Cod_Proveedor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Descripcion_Compra"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Descripcion_Compra"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Precio_Material"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Precio_Material"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Total_Compra"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Total_Compra"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Compras_ProveedorTableAdapter = Me.Compras_ProveedorTableAdapter
        Me.TableAdapterManager.DetallePedidoTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.PedidosClienteTableAdapter = Me.PedidosClienteTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.TipoMaterialTableAdapter = Me.TipoMaterialTableAdapter
        Me.TableAdapterManager.UpdateOrder = imprenta.imprentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasClienteTableAdapter = Nothing
        '
        'Compras_ProveedorTableAdapter
        '
        Me.Compras_ProveedorTableAdapter.ClearBeforeFill = True
        '
        'PedidosClienteTableAdapter
        '
        Me.PedidosClienteTableAdapter.ClearBeforeFill = True
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TipoMaterialTableAdapter
        '
        Me.TipoMaterialTableAdapter.ClearBeforeFill = True
        '
        'contabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 439)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Salir_Btn)
        Me.Name = "contabilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "contabilidad"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PedidosClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturaBindingNavigator.ResumeLayout(False)
        Me.FacturaBindingNavigator.PerformLayout()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Compras_ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Compras_ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Salir_Btn As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImprentaDataSet As imprentaDataSet
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As imprentaDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager As imprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FacturaBindingNavigator As BindingNavigator
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
    Friend WithEvents FacturaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cod_FacturaTextBox As TextBox
    Friend WithEvents PedidoCliente_Cod_PedidoComboBox As ComboBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents Tipo_MaterialTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents FacturaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Compras_ProveedorTableAdapter As imprentaDataSetTableAdapters.Compras_ProveedorTableAdapter
    Friend WithEvents Compras_ProveedorBindingSource As BindingSource
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents TipoMaterial_Cod_MaterialComboBox As ComboBox
    Friend WithEvents Proveedor_Cod_ProveedorComboBox As ComboBox
    Friend WithEvents FechaDateTimePicker1 As DateTimePicker
    Friend WithEvents Descripcion_CompraTextBox As TextBox
    Friend WithEvents Precio_MaterialTextBox As TextBox
    Friend WithEvents CantidadTextBox1 As TextBox
    Friend WithEvents Total_CompraTextBox As TextBox
    Friend WithEvents Compras_ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents TipoMaterialTableAdapter As imprentaDataSetTableAdapters.TipoMaterialTableAdapter
    Friend WithEvents TipoMaterialBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As imprentaDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents PedidosClienteTableAdapter As imprentaDataSetTableAdapters.PedidosClienteTableAdapter
    Friend WithEvents PedidosClienteBindingSource As BindingSource
    Friend WithEvents DetalleLabel1 As Label
    Friend WithEvents NombreLabel3 As Label
    Friend WithEvents NombreLabel1 As Label
End Class
