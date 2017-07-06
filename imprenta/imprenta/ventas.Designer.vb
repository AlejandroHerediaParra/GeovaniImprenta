<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventas
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
        Dim Cod_ClienteLabel As System.Windows.Forms.Label
        Dim NitLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PedidoCliente_Cod_PedidoLabel As System.Windows.Forms.Label
        Dim TipoMaterial_Cod_MaterialLabel As System.Windows.Forms.Label
        Dim Cod_DetalleLabel As System.Windows.Forms.Label
        Dim Detalle_PedidoLabel As System.Windows.Forms.Label
        Dim CantidadLabel1 As System.Windows.Forms.Label
        Dim Cod_PedidoLabel As System.Windows.Forms.Label
        Dim Cliente_Cod_ClienteLabel As System.Windows.Forms.Label
        Dim DetalleLabel As System.Windows.Forms.Label
        Dim Fecha_PedidoLabel As System.Windows.Forms.Label
        Dim Fecha_EntregaLabel As System.Windows.Forms.Label
        Dim CantidadLabel2 As System.Windows.Forms.Label
        Dim Codigo_VentaLabel As System.Windows.Forms.Label
        Dim Cliente_Cod_ClienteLabel1 As System.Windows.Forms.Label
        Dim Producto_Cod_ProductoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim CantidadLabel3 As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim NombreLabel3 As System.Windows.Forms.Label
        Dim NombreLabel5 As System.Windows.Forms.Label
        Dim NombreLabel7 As System.Windows.Forms.Label
        Dim DetalleLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ventas))
        Me.Salir_Btn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Cod_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImprentaDataSet = New imprenta.imprentaDataSet()
        Me.NitTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.NombreLabel6 = New System.Windows.Forms.Label()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PedidosClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.Cod_PedidoTextBox = New System.Windows.Forms.TextBox()
        Me.Cliente_Cod_ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.DetalleTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_PedidoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_EntregaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTextBox2 = New System.Windows.Forms.TextBox()
        Me.PedidosClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CantidadTextBox4 = New System.Windows.Forms.TextBox()
        Me.TipoMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleLabel2 = New System.Windows.Forms.Label()
        Me.NombreLabel8 = New System.Windows.Forms.Label()
        Me.PedidoCliente_Cod_PedidoComboBox = New System.Windows.Forms.ComboBox()
        Me.DetallePedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoMaterial_Cod_MaterialComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Cod_DetalleTextBox = New System.Windows.Forms.TextBox()
        Me.Detalle_PedidoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox1 = New System.Windows.Forms.TextBox()
        Me.DetallePedidoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NombreLabel4 = New System.Windows.Forms.Label()
        Me.NombreLabel2 = New System.Windows.Forms.Label()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.VentasClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.Codigo_VentaTextBox = New System.Windows.Forms.TextBox()
        Me.Cliente_Cod_ClienteComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Producto_Cod_ProductoComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox3 = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.VentasClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteTableAdapter = New imprenta.imprentaDataSetTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New imprenta.imprentaDataSetTableAdapters.TableAdapterManager()
        Me.PedidosClienteTableAdapter = New imprenta.imprentaDataSetTableAdapters.PedidosClienteTableAdapter()
        Me.DetallePedidoTableAdapter = New imprenta.imprentaDataSetTableAdapters.DetallePedidoTableAdapter()
        Me.VentasClienteTableAdapter = New imprenta.imprentaDataSetTableAdapters.VentasClienteTableAdapter()
        Me.ProductoTableAdapter = New imprenta.imprentaDataSetTableAdapters.ProductoTableAdapter()
        Me.TipoMaterialTableAdapter = New imprenta.imprentaDataSetTableAdapters.TipoMaterialTableAdapter()
        Cod_ClienteLabel = New System.Windows.Forms.Label()
        NitLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PedidoCliente_Cod_PedidoLabel = New System.Windows.Forms.Label()
        TipoMaterial_Cod_MaterialLabel = New System.Windows.Forms.Label()
        Cod_DetalleLabel = New System.Windows.Forms.Label()
        Detalle_PedidoLabel = New System.Windows.Forms.Label()
        CantidadLabel1 = New System.Windows.Forms.Label()
        Cod_PedidoLabel = New System.Windows.Forms.Label()
        Cliente_Cod_ClienteLabel = New System.Windows.Forms.Label()
        DetalleLabel = New System.Windows.Forms.Label()
        Fecha_PedidoLabel = New System.Windows.Forms.Label()
        Fecha_EntregaLabel = New System.Windows.Forms.Label()
        CantidadLabel2 = New System.Windows.Forms.Label()
        Codigo_VentaLabel = New System.Windows.Forms.Label()
        Cliente_Cod_ClienteLabel1 = New System.Windows.Forms.Label()
        Producto_Cod_ProductoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        CantidadLabel3 = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        NombreLabel3 = New System.Windows.Forms.Label()
        NombreLabel5 = New System.Windows.Forms.Label()
        NombreLabel7 = New System.Windows.Forms.Label()
        DetalleLabel1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImprentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.PedidosClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.TipoMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallePedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DetallePedidoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.VentasClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_ClienteLabel
        '
        Cod_ClienteLabel.AutoSize = True
        Cod_ClienteLabel.Location = New System.Drawing.Point(29, 52)
        Cod_ClienteLabel.Name = "Cod_ClienteLabel"
        Cod_ClienteLabel.Size = New System.Drawing.Size(64, 13)
        Cod_ClienteLabel.TabIndex = 3
        Cod_ClienteLabel.Text = "Cod Cliente:"
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Location = New System.Drawing.Point(29, 78)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(23, 13)
        NitLabel.TabIndex = 5
        NitLabel.Text = "Nit:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(29, 104)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 7
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(232, 52)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 9
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(232, 78)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 11
        TelefonoLabel.Text = "Telefono:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(232, 104)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(52, 13)
        CantidadLabel.TabIndex = 13
        CantidadLabel.Text = "Cantidad:"
        '
        'PedidoCliente_Cod_PedidoLabel
        '
        PedidoCliente_Cod_PedidoLabel.AutoSize = True
        PedidoCliente_Cod_PedidoLabel.Location = New System.Drawing.Point(392, 60)
        PedidoCliente_Cod_PedidoLabel.Name = "PedidoCliente_Cod_PedidoLabel"
        PedidoCliente_Cod_PedidoLabel.Size = New System.Drawing.Size(136, 13)
        PedidoCliente_Cod_PedidoLabel.TabIndex = 12
        PedidoCliente_Cod_PedidoLabel.Text = "Pedido Cliente Cod Pedido:"
        '
        'TipoMaterial_Cod_MaterialLabel
        '
        TipoMaterial_Cod_MaterialLabel.AutoSize = True
        TipoMaterial_Cod_MaterialLabel.Location = New System.Drawing.Point(41, 86)
        TipoMaterial_Cod_MaterialLabel.Name = "TipoMaterial_Cod_MaterialLabel"
        TipoMaterial_Cod_MaterialLabel.Size = New System.Drawing.Size(133, 13)
        TipoMaterial_Cod_MaterialLabel.TabIndex = 11
        TipoMaterial_Cod_MaterialLabel.Text = "Tipo Material Cod Material:"
        '
        'Cod_DetalleLabel
        '
        Cod_DetalleLabel.AutoSize = True
        Cod_DetalleLabel.Location = New System.Drawing.Point(41, 56)
        Cod_DetalleLabel.Name = "Cod_DetalleLabel"
        Cod_DetalleLabel.Size = New System.Drawing.Size(65, 13)
        Cod_DetalleLabel.TabIndex = 1
        Cod_DetalleLabel.Text = "Cod Detalle:"
        '
        'Detalle_PedidoLabel
        '
        Detalle_PedidoLabel.AutoSize = True
        Detalle_PedidoLabel.Location = New System.Drawing.Point(392, 86)
        Detalle_PedidoLabel.Name = "Detalle_PedidoLabel"
        Detalle_PedidoLabel.Size = New System.Drawing.Size(79, 13)
        Detalle_PedidoLabel.TabIndex = 7
        Detalle_PedidoLabel.Text = "Detalle Pedido:"
        '
        'CantidadLabel1
        '
        CantidadLabel1.AutoSize = True
        CantidadLabel1.Location = New System.Drawing.Point(41, 121)
        CantidadLabel1.Name = "CantidadLabel1"
        CantidadLabel1.Size = New System.Drawing.Size(52, 13)
        CantidadLabel1.TabIndex = 9
        CantidadLabel1.Text = "Cantidad:"
        '
        'Cod_PedidoLabel
        '
        Cod_PedidoLabel.AutoSize = True
        Cod_PedidoLabel.Location = New System.Drawing.Point(20, 45)
        Cod_PedidoLabel.Name = "Cod_PedidoLabel"
        Cod_PedidoLabel.Size = New System.Drawing.Size(65, 13)
        Cod_PedidoLabel.TabIndex = 1
        Cod_PedidoLabel.Text = "Cod Pedido:"
        '
        'Cliente_Cod_ClienteLabel
        '
        Cliente_Cod_ClienteLabel.AutoSize = True
        Cliente_Cod_ClienteLabel.Location = New System.Drawing.Point(20, 71)
        Cliente_Cod_ClienteLabel.Name = "Cliente_Cod_ClienteLabel"
        Cliente_Cod_ClienteLabel.Size = New System.Drawing.Size(99, 13)
        Cliente_Cod_ClienteLabel.TabIndex = 3
        Cliente_Cod_ClienteLabel.Text = "Cliente Cod Cliente:"
        '
        'DetalleLabel
        '
        DetalleLabel.AutoSize = True
        DetalleLabel.Location = New System.Drawing.Point(20, 98)
        DetalleLabel.Name = "DetalleLabel"
        DetalleLabel.Size = New System.Drawing.Size(43, 13)
        DetalleLabel.TabIndex = 5
        DetalleLabel.Text = "Detalle:"
        '
        'Fecha_PedidoLabel
        '
        Fecha_PedidoLabel.AutoSize = True
        Fecha_PedidoLabel.Location = New System.Drawing.Point(436, 43)
        Fecha_PedidoLabel.Name = "Fecha_PedidoLabel"
        Fecha_PedidoLabel.Size = New System.Drawing.Size(76, 13)
        Fecha_PedidoLabel.TabIndex = 7
        Fecha_PedidoLabel.Text = "Fecha Pedido:"
        '
        'Fecha_EntregaLabel
        '
        Fecha_EntregaLabel.AutoSize = True
        Fecha_EntregaLabel.Location = New System.Drawing.Point(436, 69)
        Fecha_EntregaLabel.Name = "Fecha_EntregaLabel"
        Fecha_EntregaLabel.Size = New System.Drawing.Size(80, 13)
        Fecha_EntregaLabel.TabIndex = 9
        Fecha_EntregaLabel.Text = "Fecha Entrega:"
        '
        'CantidadLabel2
        '
        CantidadLabel2.AutoSize = True
        CantidadLabel2.Location = New System.Drawing.Point(436, 94)
        CantidadLabel2.Name = "CantidadLabel2"
        CantidadLabel2.Size = New System.Drawing.Size(52, 13)
        CantidadLabel2.TabIndex = 11
        CantidadLabel2.Text = "Cantidad:"
        '
        'Codigo_VentaLabel
        '
        Codigo_VentaLabel.AutoSize = True
        Codigo_VentaLabel.Location = New System.Drawing.Point(43, 40)
        Codigo_VentaLabel.Name = "Codigo_VentaLabel"
        Codigo_VentaLabel.Size = New System.Drawing.Size(74, 13)
        Codigo_VentaLabel.TabIndex = 1
        Codigo_VentaLabel.Text = "Codigo Venta:"
        '
        'Cliente_Cod_ClienteLabel1
        '
        Cliente_Cod_ClienteLabel1.AutoSize = True
        Cliente_Cod_ClienteLabel1.Location = New System.Drawing.Point(43, 66)
        Cliente_Cod_ClienteLabel1.Name = "Cliente_Cod_ClienteLabel1"
        Cliente_Cod_ClienteLabel1.Size = New System.Drawing.Size(99, 13)
        Cliente_Cod_ClienteLabel1.TabIndex = 3
        Cliente_Cod_ClienteLabel1.Text = "Cliente Cod Cliente:"
        '
        'Producto_Cod_ProductoLabel
        '
        Producto_Cod_ProductoLabel.AutoSize = True
        Producto_Cod_ProductoLabel.Location = New System.Drawing.Point(43, 93)
        Producto_Cod_ProductoLabel.Name = "Producto_Cod_ProductoLabel"
        Producto_Cod_ProductoLabel.Size = New System.Drawing.Size(121, 13)
        Producto_Cod_ProductoLabel.TabIndex = 5
        Producto_Cod_ProductoLabel.Text = "Producto Cod Producto:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(43, 121)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Location = New System.Drawing.Point(43, 146)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(53, 13)
        ProductoLabel.TabIndex = 9
        ProductoLabel.Text = "Producto:"
        '
        'CantidadLabel3
        '
        CantidadLabel3.AutoSize = True
        CantidadLabel3.Location = New System.Drawing.Point(408, 40)
        CantidadLabel3.Name = "CantidadLabel3"
        CantidadLabel3.Size = New System.Drawing.Size(52, 13)
        CantidadLabel3.TabIndex = 11
        CantidadLabel3.Text = "Cantidad:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(408, 66)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 13
        PrecioLabel.Text = "Precio:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(408, 92)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 15
        DescripcionLabel.Text = "Descripcion:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(228, 93)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(47, 13)
        NombreLabel1.TabIndex = 18
        NombreLabel1.Text = "Nombre:"
        '
        'NombreLabel3
        '
        NombreLabel3.AutoSize = True
        NombreLabel3.Location = New System.Drawing.Point(228, 66)
        NombreLabel3.Name = "NombreLabel3"
        NombreLabel3.Size = New System.Drawing.Size(47, 13)
        NombreLabel3.TabIndex = 20
        NombreLabel3.Text = "Nombre:"
        '
        'NombreLabel5
        '
        NombreLabel5.AutoSize = True
        NombreLabel5.Location = New System.Drawing.Point(187, 71)
        NombreLabel5.Name = "NombreLabel5"
        NombreLabel5.Size = New System.Drawing.Size(47, 13)
        NombreLabel5.TabIndex = 14
        NombreLabel5.Text = "Nombre:"
        '
        'NombreLabel7
        '
        NombreLabel7.AutoSize = True
        NombreLabel7.Location = New System.Drawing.Point(247, 86)
        NombreLabel7.Name = "NombreLabel7"
        NombreLabel7.Size = New System.Drawing.Size(47, 13)
        NombreLabel7.TabIndex = 13
        NombreLabel7.Text = "Nombre:"
        '
        'DetalleLabel1
        '
        DetalleLabel1.AutoSize = True
        DetalleLabel1.Location = New System.Drawing.Point(594, 60)
        DetalleLabel1.Name = "DetalleLabel1"
        DetalleLabel1.Size = New System.Drawing.Size(43, 13)
        DetalleLabel1.TabIndex = 14
        DetalleLabel1.Text = "Detalle:"
        '
        'Salir_Btn
        '
        Me.Salir_Btn.Location = New System.Drawing.Point(729, 446)
        Me.Salir_Btn.Name = "Salir_Btn"
        Me.Salir_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Salir_Btn.TabIndex = 1
        Me.Salir_Btn.Text = "Salir"
        Me.Salir_Btn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 423)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Cod_ClienteLabel)
        Me.TabPage1.Controls.Add(Me.Cod_ClienteTextBox)
        Me.TabPage1.Controls.Add(NitLabel)
        Me.TabPage1.Controls.Add(Me.NitTextBox)
        Me.TabPage1.Controls.Add(NombreLabel)
        Me.TabPage1.Controls.Add(Me.NombreTextBox)
        Me.TabPage1.Controls.Add(DireccionLabel)
        Me.TabPage1.Controls.Add(Me.DireccionTextBox)
        Me.TabPage1.Controls.Add(TelefonoLabel)
        Me.TabPage1.Controls.Add(Me.TelefonoTextBox)
        Me.TabPage1.Controls.Add(CantidadLabel)
        Me.TabPage1.Controls.Add(Me.CantidadTextBox)
        Me.TabPage1.Controls.Add(Me.ClienteBindingNavigator)
        Me.TabPage1.Controls.Add(Me.ClienteDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(784, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CLIENTE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Cod_ClienteTextBox
        '
        Me.Cod_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Cod_Cliente", True))
        Me.Cod_ClienteTextBox.Enabled = False
        Me.Cod_ClienteTextBox.Location = New System.Drawing.Point(99, 49)
        Me.Cod_ClienteTextBox.Name = "Cod_ClienteTextBox"
        Me.Cod_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_ClienteTextBox.TabIndex = 4
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.ImprentaDataSet
        '
        'ImprentaDataSet
        '
        Me.ImprentaDataSet.DataSetName = "imprentaDataSet"
        Me.ImprentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NitTextBox
        '
        Me.NitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nit", True))
        Me.NitTextBox.Location = New System.Drawing.Point(99, 75)
        Me.NitTextBox.Name = "NitTextBox"
        Me.NitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NitTextBox.TabIndex = 6
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(99, 101)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 8
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(302, 49)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 10
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(302, 75)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 12
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(302, 101)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 14
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.ClienteBindingNavigator.TabIndex = 3
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClienteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(62, 174)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.ReadOnly = True
        Me.ClienteDataGridView.Size = New System.Drawing.Size(644, 220)
        Me.ClienteDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cod_Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod_Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nit"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nit"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(NombreLabel5)
        Me.TabPage3.Controls.Add(Me.NombreLabel6)
        Me.TabPage3.Controls.Add(Me.BindingNavigator2)
        Me.TabPage3.Controls.Add(Cod_PedidoLabel)
        Me.TabPage3.Controls.Add(Me.Cod_PedidoTextBox)
        Me.TabPage3.Controls.Add(Cliente_Cod_ClienteLabel)
        Me.TabPage3.Controls.Add(Me.Cliente_Cod_ClienteComboBox)
        Me.TabPage3.Controls.Add(DetalleLabel)
        Me.TabPage3.Controls.Add(Me.DetalleTextBox)
        Me.TabPage3.Controls.Add(Fecha_PedidoLabel)
        Me.TabPage3.Controls.Add(Me.Fecha_PedidoDateTimePicker)
        Me.TabPage3.Controls.Add(Fecha_EntregaLabel)
        Me.TabPage3.Controls.Add(Me.Fecha_EntregaDateTimePicker)
        Me.TabPage3.Controls.Add(CantidadLabel2)
        Me.TabPage3.Controls.Add(Me.CantidadTextBox2)
        Me.TabPage3.Controls.Add(Me.PedidosClienteDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(784, 397)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PEDIDO"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'NombreLabel6
        '
        Me.NombreLabel6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre", True))
        Me.NombreLabel6.Location = New System.Drawing.Point(240, 71)
        Me.NombreLabel6.Name = "NombreLabel6"
        Me.NombreLabel6.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel6.TabIndex = 15
        Me.NombreLabel6.Text = "Label1"
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator2.BindingSource = Me.PedidosClienteBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator2.DeleteItem = Me.ToolStripButton3
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton8})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton4
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton7
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton6
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton5
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator2.Size = New System.Drawing.Size(280, 25)
        Me.BindingNavigator2.TabIndex = 13
        Me.BindingNavigator2.Text = "BindingNavigator2"
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
        'PedidosClienteBindingSource
        '
        Me.PedidosClienteBindingSource.DataMember = "PedidosCliente"
        Me.PedidosClienteBindingSource.DataSource = Me.ImprentaDataSet
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Eliminar"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Mover primero"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Mover anterior"
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
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Mover siguiente"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Guardar datos"
        '
        'Cod_PedidoTextBox
        '
        Me.Cod_PedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosClienteBindingSource, "Cod_Pedido", True))
        Me.Cod_PedidoTextBox.Enabled = False
        Me.Cod_PedidoTextBox.Location = New System.Drawing.Point(125, 42)
        Me.Cod_PedidoTextBox.Name = "Cod_PedidoTextBox"
        Me.Cod_PedidoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cod_PedidoTextBox.TabIndex = 2
        '
        'Cliente_Cod_ClienteComboBox
        '
        Me.Cliente_Cod_ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosClienteBindingSource, "Cliente_Cod_Cliente", True))
        Me.Cliente_Cod_ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.Cliente_Cod_ClienteComboBox.DisplayMember = "Cod_Cliente"
        Me.Cliente_Cod_ClienteComboBox.FormattingEnabled = True
        Me.Cliente_Cod_ClienteComboBox.Location = New System.Drawing.Point(125, 68)
        Me.Cliente_Cod_ClienteComboBox.Name = "Cliente_Cod_ClienteComboBox"
        Me.Cliente_Cod_ClienteComboBox.Size = New System.Drawing.Size(48, 21)
        Me.Cliente_Cod_ClienteComboBox.TabIndex = 4
        Me.Cliente_Cod_ClienteComboBox.ValueMember = "Cod_Cliente"
        '
        'DetalleTextBox
        '
        Me.DetalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosClienteBindingSource, "Detalle", True))
        Me.DetalleTextBox.Location = New System.Drawing.Point(125, 95)
        Me.DetalleTextBox.Multiline = True
        Me.DetalleTextBox.Name = "DetalleTextBox"
        Me.DetalleTextBox.Size = New System.Drawing.Size(200, 73)
        Me.DetalleTextBox.TabIndex = 6
        '
        'Fecha_PedidoDateTimePicker
        '
        Me.Fecha_PedidoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosClienteBindingSource, "Fecha_Pedido", True))
        Me.Fecha_PedidoDateTimePicker.Location = New System.Drawing.Point(541, 39)
        Me.Fecha_PedidoDateTimePicker.Name = "Fecha_PedidoDateTimePicker"
        Me.Fecha_PedidoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_PedidoDateTimePicker.TabIndex = 8
        '
        'Fecha_EntregaDateTimePicker
        '
        Me.Fecha_EntregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosClienteBindingSource, "Fecha_Entrega", True))
        Me.Fecha_EntregaDateTimePicker.Location = New System.Drawing.Point(541, 65)
        Me.Fecha_EntregaDateTimePicker.Name = "Fecha_EntregaDateTimePicker"
        Me.Fecha_EntregaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_EntregaDateTimePicker.TabIndex = 10
        '
        'CantidadTextBox2
        '
        Me.CantidadTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosClienteBindingSource, "Cantidad", True))
        Me.CantidadTextBox2.Location = New System.Drawing.Point(541, 91)
        Me.CantidadTextBox2.Name = "CantidadTextBox2"
        Me.CantidadTextBox2.Size = New System.Drawing.Size(89, 20)
        Me.CantidadTextBox2.TabIndex = 12
        '
        'PedidosClienteDataGridView
        '
        Me.PedidosClienteDataGridView.AutoGenerateColumns = False
        Me.PedidosClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.PedidosClienteDataGridView.DataSource = Me.PedidosClienteBindingSource
        Me.PedidosClienteDataGridView.Location = New System.Drawing.Point(0, 174)
        Me.PedidosClienteDataGridView.Name = "PedidosClienteDataGridView"
        Me.PedidosClienteDataGridView.Size = New System.Drawing.Size(778, 220)
        Me.PedidosClienteDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Cod_Pedido"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cod_Pedido"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Cliente_Cod_Cliente"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cliente_Cod_Cliente"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Detalle"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Fecha_Pedido"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fecha_Pedido"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Fecha_Entrega"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fecha_Entrega"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.CantidadTextBox4)
        Me.TabPage4.Controls.Add(DetalleLabel1)
        Me.TabPage4.Controls.Add(Me.DetalleLabel2)
        Me.TabPage4.Controls.Add(NombreLabel7)
        Me.TabPage4.Controls.Add(Me.NombreLabel8)
        Me.TabPage4.Controls.Add(PedidoCliente_Cod_PedidoLabel)
        Me.TabPage4.Controls.Add(Me.PedidoCliente_Cod_PedidoComboBox)
        Me.TabPage4.Controls.Add(TipoMaterial_Cod_MaterialLabel)
        Me.TabPage4.Controls.Add(Me.TipoMaterial_Cod_MaterialComboBox)
        Me.TabPage4.Controls.Add(Me.BindingNavigator1)
        Me.TabPage4.Controls.Add(Cod_DetalleLabel)
        Me.TabPage4.Controls.Add(Me.Cod_DetalleTextBox)
        Me.TabPage4.Controls.Add(Detalle_PedidoLabel)
        Me.TabPage4.Controls.Add(Me.Detalle_PedidoTextBox)
        Me.TabPage4.Controls.Add(CantidadLabel1)
        Me.TabPage4.Controls.Add(Me.CantidadTextBox1)
        Me.TabPage4.Controls.Add(Me.DetallePedidoDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(784, 397)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "DETALLE PEDIDO"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CantidadTextBox4
        '
        Me.CantidadTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoMaterialBindingSource, "Cantidad", True))
        Me.CantidadTextBox4.Enabled = False
        Me.CantidadTextBox4.Location = New System.Drawing.Point(282, 118)
        Me.CantidadTextBox4.Name = "CantidadTextBox4"
        Me.CantidadTextBox4.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox4.TabIndex = 17
        '
        'TipoMaterialBindingSource
        '
        Me.TipoMaterialBindingSource.DataMember = "TipoMaterial"
        Me.TipoMaterialBindingSource.DataSource = Me.ImprentaDataSet
        '
        'DetalleLabel2
        '
        Me.DetalleLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosClienteBindingSource, "Detalle", True))
        Me.DetalleLabel2.Location = New System.Drawing.Point(643, 60)
        Me.DetalleLabel2.Name = "DetalleLabel2"
        Me.DetalleLabel2.Size = New System.Drawing.Size(100, 23)
        Me.DetalleLabel2.TabIndex = 15
        Me.DetalleLabel2.Text = "Label1"
        '
        'NombreLabel8
        '
        Me.NombreLabel8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipoMaterialBindingSource, "Nombre", True))
        Me.NombreLabel8.Location = New System.Drawing.Point(300, 86)
        Me.NombreLabel8.Name = "NombreLabel8"
        Me.NombreLabel8.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel8.TabIndex = 14
        Me.NombreLabel8.Text = "Label1"
        '
        'PedidoCliente_Cod_PedidoComboBox
        '
        Me.PedidoCliente_Cod_PedidoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "PedidoCliente_Cod_Pedido", True))
        Me.PedidoCliente_Cod_PedidoComboBox.DataSource = Me.PedidosClienteBindingSource
        Me.PedidoCliente_Cod_PedidoComboBox.DisplayMember = "Cod_Pedido"
        Me.PedidoCliente_Cod_PedidoComboBox.FormattingEnabled = True
        Me.PedidoCliente_Cod_PedidoComboBox.Location = New System.Drawing.Point(534, 57)
        Me.PedidoCliente_Cod_PedidoComboBox.Name = "PedidoCliente_Cod_PedidoComboBox"
        Me.PedidoCliente_Cod_PedidoComboBox.Size = New System.Drawing.Size(48, 21)
        Me.PedidoCliente_Cod_PedidoComboBox.TabIndex = 13
        Me.PedidoCliente_Cod_PedidoComboBox.ValueMember = "Cod_Pedido"
        '
        'DetallePedidoBindingSource
        '
        Me.DetallePedidoBindingSource.DataMember = "DetallePedido"
        Me.DetallePedidoBindingSource.DataSource = Me.ImprentaDataSet
        '
        'TipoMaterial_Cod_MaterialComboBox
        '
        Me.TipoMaterial_Cod_MaterialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "TipoMaterial_Cod_Material", True))
        Me.TipoMaterial_Cod_MaterialComboBox.DataSource = Me.TipoMaterialBindingSource
        Me.TipoMaterial_Cod_MaterialComboBox.DisplayMember = "Cod_Material"
        Me.TipoMaterial_Cod_MaterialComboBox.FormattingEnabled = True
        Me.TipoMaterial_Cod_MaterialComboBox.Location = New System.Drawing.Point(180, 83)
        Me.TipoMaterial_Cod_MaterialComboBox.Name = "TipoMaterial_Cod_MaterialComboBox"
        Me.TipoMaterial_Cod_MaterialComboBox.Size = New System.Drawing.Size(54, 21)
        Me.TipoMaterial_Cod_MaterialComboBox.TabIndex = 12
        Me.TipoMaterial_Cod_MaterialComboBox.ValueMember = "Cod_Material"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.DetallePedidoBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(280, 25)
        Me.BindingNavigator1.TabIndex = 11
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Guardar datos"
        '
        'Cod_DetalleTextBox
        '
        Me.Cod_DetalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "Cod_Detalle", True))
        Me.Cod_DetalleTextBox.Enabled = False
        Me.Cod_DetalleTextBox.Location = New System.Drawing.Point(183, 53)
        Me.Cod_DetalleTextBox.Name = "Cod_DetalleTextBox"
        Me.Cod_DetalleTextBox.Size = New System.Drawing.Size(82, 20)
        Me.Cod_DetalleTextBox.TabIndex = 2
        '
        'Detalle_PedidoTextBox
        '
        Me.Detalle_PedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "Detalle_Pedido", True))
        Me.Detalle_PedidoTextBox.Location = New System.Drawing.Point(534, 83)
        Me.Detalle_PedidoTextBox.Multiline = True
        Me.Detalle_PedidoTextBox.Name = "Detalle_PedidoTextBox"
        Me.Detalle_PedidoTextBox.Size = New System.Drawing.Size(163, 88)
        Me.Detalle_PedidoTextBox.TabIndex = 8
        '
        'CantidadTextBox1
        '
        Me.CantidadTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallePedidoBindingSource, "Cantidad", True))
        Me.CantidadTextBox1.Location = New System.Drawing.Point(183, 118)
        Me.CantidadTextBox1.Name = "CantidadTextBox1"
        Me.CantidadTextBox1.Size = New System.Drawing.Size(82, 20)
        Me.CantidadTextBox1.TabIndex = 10
        '
        'DetallePedidoDataGridView
        '
        Me.DetallePedidoDataGridView.AutoGenerateColumns = False
        Me.DetallePedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallePedidoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DetallePedidoDataGridView.DataSource = Me.DetallePedidoBindingSource
        Me.DetallePedidoDataGridView.Location = New System.Drawing.Point(129, 191)
        Me.DetallePedidoDataGridView.Name = "DetallePedidoDataGridView"
        Me.DetallePedidoDataGridView.Size = New System.Drawing.Size(547, 200)
        Me.DetallePedidoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cod_Detalle"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cod_Detalle"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TipoMaterial_Cod_Material"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TipoMaterial_Cod_Material"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PedidoCliente_Cod_Pedido"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PedidoCliente_Cod_Pedido"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Detalle_Pedido"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Detalle_Pedido"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(NombreLabel3)
        Me.TabPage2.Controls.Add(Me.NombreLabel4)
        Me.TabPage2.Controls.Add(NombreLabel1)
        Me.TabPage2.Controls.Add(Me.NombreLabel2)
        Me.TabPage2.Controls.Add(Me.BindingNavigator3)
        Me.TabPage2.Controls.Add(Codigo_VentaLabel)
        Me.TabPage2.Controls.Add(Me.Codigo_VentaTextBox)
        Me.TabPage2.Controls.Add(Cliente_Cod_ClienteLabel1)
        Me.TabPage2.Controls.Add(Me.Cliente_Cod_ClienteComboBox1)
        Me.TabPage2.Controls.Add(Producto_Cod_ProductoLabel)
        Me.TabPage2.Controls.Add(Me.Producto_Cod_ProductoComboBox)
        Me.TabPage2.Controls.Add(FechaLabel)
        Me.TabPage2.Controls.Add(Me.FechaDateTimePicker)
        Me.TabPage2.Controls.Add(ProductoLabel)
        Me.TabPage2.Controls.Add(Me.ProductoTextBox)
        Me.TabPage2.Controls.Add(CantidadLabel3)
        Me.TabPage2.Controls.Add(Me.CantidadTextBox3)
        Me.TabPage2.Controls.Add(PrecioLabel)
        Me.TabPage2.Controls.Add(Me.PrecioTextBox)
        Me.TabPage2.Controls.Add(DescripcionLabel)
        Me.TabPage2.Controls.Add(Me.DescripcionTextBox)
        Me.TabPage2.Controls.Add(Me.VentasClienteDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(784, 397)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "VENTAS CLIENTE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NombreLabel4
        '
        Me.NombreLabel4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre", True))
        Me.NombreLabel4.Location = New System.Drawing.Point(281, 66)
        Me.NombreLabel4.Name = "NombreLabel4"
        Me.NombreLabel4.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel4.TabIndex = 21
        Me.NombreLabel4.Text = "Label1"
        '
        'NombreLabel2
        '
        Me.NombreLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre", True))
        Me.NombreLabel2.Location = New System.Drawing.Point(281, 93)
        Me.NombreLabel2.Name = "NombreLabel2"
        Me.NombreLabel2.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel2.TabIndex = 19
        Me.NombreLabel2.Text = "Label1"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.ImprentaDataSet
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.ToolStripButton9
        Me.BindingNavigator3.BindingSource = Me.VentasClienteBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator3.DeleteItem = Me.ToolStripButton10
        Me.BindingNavigator3.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton13, Me.ToolStripButton14, Me.ToolStripSeparator6, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripButton15})
        Me.BindingNavigator3.Location = New System.Drawing.Point(6, 3)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton11
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton14
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton13
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton12
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator3.Size = New System.Drawing.Size(280, 25)
        Me.BindingNavigator3.TabIndex = 17
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Agregar nuevo"
        '
        'VentasClienteBindingSource
        '
        Me.VentasClienteBindingSource.DataMember = "VentasCliente"
        Me.VentasClienteBindingSource.DataSource = Me.ImprentaDataSet
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel2.Text = "de {0}"
        Me.ToolStripLabel2.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Eliminar"
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Mover primero"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Mover anterior"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Posición"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Mover siguiente"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Mover último"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Guardar datos"
        '
        'Codigo_VentaTextBox
        '
        Me.Codigo_VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasClienteBindingSource, "Codigo_Venta", True))
        Me.Codigo_VentaTextBox.Enabled = False
        Me.Codigo_VentaTextBox.Location = New System.Drawing.Point(170, 37)
        Me.Codigo_VentaTextBox.Name = "Codigo_VentaTextBox"
        Me.Codigo_VentaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Codigo_VentaTextBox.TabIndex = 2
        '
        'Cliente_Cod_ClienteComboBox1
        '
        Me.Cliente_Cod_ClienteComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasClienteBindingSource, "Cliente_Cod_Cliente", True))
        Me.Cliente_Cod_ClienteComboBox1.DataSource = Me.ClienteBindingSource
        Me.Cliente_Cod_ClienteComboBox1.DisplayMember = "Cod_Cliente"
        Me.Cliente_Cod_ClienteComboBox1.FormattingEnabled = True
        Me.Cliente_Cod_ClienteComboBox1.Location = New System.Drawing.Point(170, 63)
        Me.Cliente_Cod_ClienteComboBox1.Name = "Cliente_Cod_ClienteComboBox1"
        Me.Cliente_Cod_ClienteComboBox1.Size = New System.Drawing.Size(50, 21)
        Me.Cliente_Cod_ClienteComboBox1.TabIndex = 4
        Me.Cliente_Cod_ClienteComboBox1.ValueMember = "Cod_Cliente"
        '
        'Producto_Cod_ProductoComboBox
        '
        Me.Producto_Cod_ProductoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasClienteBindingSource, "Producto_Cod_Producto", True))
        Me.Producto_Cod_ProductoComboBox.DataSource = Me.ProductoBindingSource
        Me.Producto_Cod_ProductoComboBox.DisplayMember = "Cod_Producto"
        Me.Producto_Cod_ProductoComboBox.FormattingEnabled = True
        Me.Producto_Cod_ProductoComboBox.Location = New System.Drawing.Point(170, 90)
        Me.Producto_Cod_ProductoComboBox.Name = "Producto_Cod_ProductoComboBox"
        Me.Producto_Cod_ProductoComboBox.Size = New System.Drawing.Size(50, 21)
        Me.Producto_Cod_ProductoComboBox.TabIndex = 6
        Me.Producto_Cod_ProductoComboBox.ValueMember = "Cod_Producto"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasClienteBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(170, 117)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 8
        '
        'ProductoTextBox
        '
        Me.ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasClienteBindingSource, "Producto", True))
        Me.ProductoTextBox.Location = New System.Drawing.Point(170, 143)
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductoTextBox.TabIndex = 10
        '
        'CantidadTextBox3
        '
        Me.CantidadTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasClienteBindingSource, "Cantidad", True))
        Me.CantidadTextBox3.Location = New System.Drawing.Point(535, 37)
        Me.CantidadTextBox3.Name = "CantidadTextBox3"
        Me.CantidadTextBox3.Size = New System.Drawing.Size(79, 20)
        Me.CantidadTextBox3.TabIndex = 12
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasClienteBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(535, 63)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(79, 20)
        Me.PrecioTextBox.TabIndex = 14
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasClienteBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(535, 89)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 74)
        Me.DescripcionTextBox.TabIndex = 16
        '
        'VentasClienteDataGridView
        '
        Me.VentasClienteDataGridView.AutoGenerateColumns = False
        Me.VentasClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.VentasClienteDataGridView.DataSource = Me.VentasClienteBindingSource
        Me.VentasClienteDataGridView.Location = New System.Drawing.Point(6, 171)
        Me.VentasClienteDataGridView.Name = "VentasClienteDataGridView"
        Me.VentasClienteDataGridView.Size = New System.Drawing.Size(772, 220)
        Me.VentasClienteDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Codigo_Venta"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Codigo_Venta"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Cliente_Cod_Cliente"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Cliente_Cod_Cliente"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Producto_Cod_Producto"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Producto_Cod_Producto"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Producto"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.Compras_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.DetallePedidoTableAdapter = Me.DetallePedidoTableAdapter
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.PedidosClienteTableAdapter = Me.PedidosClienteTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.TipoMaterialTableAdapter = Me.TipoMaterialTableAdapter
        Me.TableAdapterManager.UpdateOrder = imprenta.imprentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasClienteTableAdapter = Me.VentasClienteTableAdapter
        '
        'PedidosClienteTableAdapter
        '
        Me.PedidosClienteTableAdapter.ClearBeforeFill = True
        '
        'DetallePedidoTableAdapter
        '
        Me.DetallePedidoTableAdapter.ClearBeforeFill = True
        '
        'VentasClienteTableAdapter
        '
        Me.VentasClienteTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TipoMaterialTableAdapter
        '
        Me.TipoMaterialTableAdapter.ClearBeforeFill = True
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 481)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Salir_Btn)
        Me.Name = "ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ventas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImprentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.PedidosClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.TipoMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallePedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.DetallePedidoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.VentasClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Salir_Btn As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ImprentaDataSet As imprentaDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
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
    Friend WithEvents Cod_ClienteTextBox As TextBox
    Friend WithEvents NitTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DetallePedidoBindingSource As BindingSource
    Friend WithEvents TipoMaterialBindingSource As BindingSource
    Friend WithEvents PedidosClienteBindingSource As BindingSource
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Cod_PedidoTextBox As TextBox
    Friend WithEvents Cliente_Cod_ClienteComboBox As ComboBox
    Friend WithEvents DetalleTextBox As TextBox
    Friend WithEvents Fecha_PedidoDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_EntregaDateTimePicker As DateTimePicker
    Friend WithEvents CantidadTextBox2 As TextBox
    Friend WithEvents PedidosClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents PedidoCliente_Cod_PedidoComboBox As ComboBox
    Friend WithEvents TipoMaterial_Cod_MaterialComboBox As ComboBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Cod_DetalleTextBox As TextBox
    Friend WithEvents Detalle_PedidoTextBox As TextBox
    Friend WithEvents CantidadTextBox1 As TextBox
    Friend WithEvents DetallePedidoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents VentasClienteBindingSource As BindingSource
    Friend WithEvents Codigo_VentaTextBox As TextBox
    Friend WithEvents Cliente_Cod_ClienteComboBox1 As ComboBox
    Friend WithEvents Producto_Cod_ProductoComboBox As ComboBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents CantidadTextBox3 As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents VentasClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents NombreLabel2 As Label
    Friend WithEvents NombreLabel6 As Label
    Friend WithEvents DetalleLabel2 As Label
    Friend WithEvents NombreLabel8 As Label
    Friend WithEvents NombreLabel4 As Label
    Friend WithEvents CantidadTextBox4 As TextBox
    Friend WithEvents ClienteTableAdapter As imprentaDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As imprentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetallePedidoTableAdapter As imprentaDataSetTableAdapters.DetallePedidoTableAdapter
    Friend WithEvents PedidosClienteTableAdapter As imprentaDataSetTableAdapters.PedidosClienteTableAdapter
    Friend WithEvents VentasClienteTableAdapter As imprentaDataSetTableAdapters.VentasClienteTableAdapter
    Friend WithEvents ProductoTableAdapter As imprentaDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TipoMaterialTableAdapter As imprentaDataSetTableAdapters.TipoMaterialTableAdapter
End Class
