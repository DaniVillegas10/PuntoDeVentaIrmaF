<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMenu))
        ToolStripMenu = New ToolStrip()
        ToolStripSeparator6 = New ToolStripSeparator()
        toolStripDropDownButton1 = New ToolStripSplitButton()
        GestionDeInventarioToolStripMenuItem = New ToolStripMenuItem()
        AdministraciónDePreciosToolStripMenuItem = New ToolStripMenuItem()
        SugerenciasDeInventarioToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        toolStripDropDownButton2 = New ToolStripSplitButton()
        HistorialDeVentasToolStripMenuItem = New ToolStripMenuItem()
        RegistrarVentaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStripButton1 = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        ToolStripButton3 = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        ToolStripSplitButton1 = New ToolStripButton()
        ToolStripSeparator5 = New ToolStripSeparator()
        toolStripDropDownButton3 = New ToolStripSplitButton()
        IdiomaToolStripMenuItem = New ToolStripMenuItem()
        AdministracionDePerfilesToolStripMenuItem = New ToolStripMenuItem()
        PersonalizacionDeTemaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        lblDateTime = New ToolStripLabel()
        ToolStripSeparator8 = New ToolStripSeparator()
        ToolStripSplitButton4 = New ToolStripButton()
        timerDateTime = New Timer(components)
        RegistroDeProductosToolStripMenuItem = New ToolStripMenuItem()
        RegistroDeInventarioToolStripMenuItem = New ToolStripMenuItem()
        ProductoMásVendidoToolStripMenuItem = New ToolStripMenuItem()
        btnProductos = New ToolStripSplitButton()
        ToolStripMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStripMenu
        ' 
        ToolStripMenu.BackColor = Color.Transparent
        ToolStripMenu.ImageScalingSize = New Size(64, 64)
        ToolStripMenu.Items.AddRange(New ToolStripItem() {ToolStripSeparator6, toolStripDropDownButton1, ToolStripSeparator1, toolStripDropDownButton2, ToolStripSeparator2, ToolStripButton1, ToolStripSeparator3, ToolStripButton3, ToolStripSeparator4, ToolStripSplitButton1, ToolStripSeparator5, toolStripDropDownButton3, ToolStripSeparator7, lblDateTime, ToolStripSeparator8, ToolStripSplitButton4})
        ToolStripMenu.Location = New Point(0, 0)
        ToolStripMenu.Name = "ToolStripMenu"
        ToolStripMenu.Padding = New Padding(0, 0, 5, 0)
        ToolStripMenu.RenderMode = ToolStripRenderMode.System
        ToolStripMenu.Size = New Size(1701, 98)
        ToolStripMenu.Stretch = True
        ToolStripMenu.TabIndex = 0
        ToolStripMenu.TabStop = True
        ToolStripMenu.Text = "ToolStrip1"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.AutoSize = False
        ToolStripSeparator6.ForeColor = Color.Transparent
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(90, 98)
        ' 
        ' toolStripDropDownButton1
        ' 
        toolStripDropDownButton1.DropDownItems.AddRange(New ToolStripItem() {GestionDeInventarioToolStripMenuItem, AdministraciónDePreciosToolStripMenuItem, SugerenciasDeInventarioToolStripMenuItem})
        toolStripDropDownButton1.Image = CType(resources.GetObject("toolStripDropDownButton1.Image"), Image)
        toolStripDropDownButton1.ImageAlign = ContentAlignment.TopCenter
        toolStripDropDownButton1.ImageTransparentColor = Color.Magenta
        toolStripDropDownButton1.Name = "toolStripDropDownButton1"
        toolStripDropDownButton1.Size = New Size(136, 93)
        toolStripDropDownButton1.Text = "PRODUCTOS"
        toolStripDropDownButton1.TextAlign = ContentAlignment.BottomCenter
        toolStripDropDownButton1.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' GestionDeInventarioToolStripMenuItem
        ' 
        GestionDeInventarioToolStripMenuItem.Name = "GestionDeInventarioToolStripMenuItem"
        GestionDeInventarioToolStripMenuItem.Size = New Size(316, 34)
        GestionDeInventarioToolStripMenuItem.Text = "Gestion de inventario"
        ' 
        ' AdministraciónDePreciosToolStripMenuItem
        ' 
        AdministraciónDePreciosToolStripMenuItem.Name = "AdministraciónDePreciosToolStripMenuItem"
        AdministraciónDePreciosToolStripMenuItem.Size = New Size(316, 34)
        AdministraciónDePreciosToolStripMenuItem.Text = "Productos estrella"
        ' 
        ' SugerenciasDeInventarioToolStripMenuItem
        ' 
        SugerenciasDeInventarioToolStripMenuItem.Name = "SugerenciasDeInventarioToolStripMenuItem"
        SugerenciasDeInventarioToolStripMenuItem.Size = New Size(316, 34)
        SugerenciasDeInventarioToolStripMenuItem.Text = "Sugerencias de inventario"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.AutoSize = False
        ToolStripSeparator1.ForeColor = Color.Transparent
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(90, 98)
        ' 
        ' toolStripDropDownButton2
        ' 
        toolStripDropDownButton2.DropDownItems.AddRange(New ToolStripItem() {HistorialDeVentasToolStripMenuItem, RegistrarVentaToolStripMenuItem})
        toolStripDropDownButton2.Image = My.Resources.Resources.coin_dollar_finance_icon_125510
        toolStripDropDownButton2.ImageAlign = ContentAlignment.TopCenter
        toolStripDropDownButton2.ImageTransparentColor = Color.Magenta
        toolStripDropDownButton2.Name = "toolStripDropDownButton2"
        toolStripDropDownButton2.Size = New Size(96, 93)
        toolStripDropDownButton2.Text = "VENTAS"
        toolStripDropDownButton2.TextAlign = ContentAlignment.BottomCenter
        toolStripDropDownButton2.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' HistorialDeVentasToolStripMenuItem
        ' 
        HistorialDeVentasToolStripMenuItem.Name = "HistorialDeVentasToolStripMenuItem"
        HistorialDeVentasToolStripMenuItem.Size = New Size(260, 34)
        HistorialDeVentasToolStripMenuItem.Text = "Historial de ventas"
        ' 
        ' RegistrarVentaToolStripMenuItem
        ' 
        RegistrarVentaToolStripMenuItem.Name = "RegistrarVentaToolStripMenuItem"
        RegistrarVentaToolStripMenuItem.Size = New Size(260, 34)
        RegistrarVentaToolStripMenuItem.Text = "Registrar venta"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.AutoSize = False
        ToolStripSeparator2.ForeColor = Color.Transparent
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(90, 98)
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageAlign = ContentAlignment.TopCenter
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(100, 93)
        ToolStripButton1.Text = "COMPRAS"
        ToolStripButton1.TextAlign = ContentAlignment.BottomCenter
        ToolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.AutoSize = False
        ToolStripSeparator3.ForeColor = Color.Transparent
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(90, 98)
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        ToolStripButton3.ImageAlign = ContentAlignment.TopCenter
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(137, 93)
        ToolStripButton3.Text = "PROVEEDORES"
        ToolStripButton3.TextAlign = ContentAlignment.BottomCenter
        ToolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.AutoSize = False
        ToolStripSeparator4.ForeColor = Color.Transparent
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(90, 98)
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), Image)
        ToolStripSplitButton1.ImageAlign = ContentAlignment.TopCenter
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(98, 93)
        ToolStripSplitButton1.Text = "REPORTES"
        ToolStripSplitButton1.TextAlign = ContentAlignment.BottomCenter
        ToolStripSplitButton1.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.AutoSize = False
        ToolStripSeparator5.ForeColor = Color.Transparent
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(90, 98)
        ' 
        ' toolStripDropDownButton3
        ' 
        toolStripDropDownButton3.DropDownItems.AddRange(New ToolStripItem() {IdiomaToolStripMenuItem, AdministracionDePerfilesToolStripMenuItem, PersonalizacionDeTemaToolStripMenuItem})
        toolStripDropDownButton3.Image = CType(resources.GetObject("toolStripDropDownButton3.Image"), Image)
        toolStripDropDownButton3.ImageAlign = ContentAlignment.TopCenter
        toolStripDropDownButton3.ImageTransparentColor = Color.Magenta
        toolStripDropDownButton3.Name = "toolStripDropDownButton3"
        toolStripDropDownButton3.Size = New Size(175, 93)
        toolStripDropDownButton3.Text = "CONFIGURACIÓN"
        toolStripDropDownButton3.TextAlign = ContentAlignment.BottomCenter
        toolStripDropDownButton3.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' IdiomaToolStripMenuItem
        ' 
        IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        IdiomaToolStripMenuItem.Size = New Size(320, 34)
        IdiomaToolStripMenuItem.Text = "Idioma"
        ' 
        ' AdministracionDePerfilesToolStripMenuItem
        ' 
        AdministracionDePerfilesToolStripMenuItem.Name = "AdministracionDePerfilesToolStripMenuItem"
        AdministracionDePerfilesToolStripMenuItem.Size = New Size(320, 34)
        AdministracionDePerfilesToolStripMenuItem.Text = "Administracion de perfiles"
        ' 
        ' PersonalizacionDeTemaToolStripMenuItem
        ' 
        PersonalizacionDeTemaToolStripMenuItem.Name = "PersonalizacionDeTemaToolStripMenuItem"
        PersonalizacionDeTemaToolStripMenuItem.Size = New Size(320, 34)
        PersonalizacionDeTemaToolStripMenuItem.Text = "Personalizacion de tema"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.AutoSize = False
        ToolStripSeparator7.ForeColor = Color.Transparent
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(50, 98)
        ' 
        ' lblDateTime
        ' 
        lblDateTime.ActiveLinkColor = Color.Transparent
        lblDateTime.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblDateTime.ForeColor = Color.White
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(137, 93)
        lblDateTime.Text = "00:00:00"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.AutoSize = False
        ToolStripSeparator8.ForeColor = Color.Transparent
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(50, 98)
        ' 
        ' ToolStripSplitButton4
        ' 
        ToolStripSplitButton4.Image = CType(resources.GetObject("ToolStripSplitButton4.Image"), Image)
        ToolStripSplitButton4.ImageAlign = ContentAlignment.TopCenter
        ToolStripSplitButton4.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton4.Name = "ToolStripSplitButton4"
        ToolStripSplitButton4.Size = New Size(68, 93)
        ToolStripSplitButton4.Text = "SALIR"
        ToolStripSplitButton4.TextAlign = ContentAlignment.BottomCenter
        ToolStripSplitButton4.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' timerDateTime
        ' 
        ' 
        ' RegistroDeProductosToolStripMenuItem
        ' 
        RegistroDeProductosToolStripMenuItem.Name = "RegistroDeProductosToolStripMenuItem"
        RegistroDeProductosToolStripMenuItem.Size = New Size(311, 34)
        RegistroDeProductosToolStripMenuItem.Text = "Gestión de productos"
        ' 
        ' RegistroDeInventarioToolStripMenuItem
        ' 
        RegistroDeInventarioToolStripMenuItem.Name = "RegistroDeInventarioToolStripMenuItem"
        RegistroDeInventarioToolStripMenuItem.Size = New Size(311, 34)
        RegistroDeInventarioToolStripMenuItem.Text = "Gestión de inventario"
        ' 
        ' ProductoMásVendidoToolStripMenuItem
        ' 
        ProductoMásVendidoToolStripMenuItem.Name = "ProductoMásVendidoToolStripMenuItem"
        ProductoMásVendidoToolStripMenuItem.Size = New Size(311, 34)
        ProductoMásVendidoToolStripMenuItem.Text = "Productos más vendidos"
        ' 
        ' btnProductos
        ' 
        btnProductos.DropDownItems.AddRange(New ToolStripItem() {RegistroDeProductosToolStripMenuItem, RegistroDeInventarioToolStripMenuItem, ProductoMásVendidoToolStripMenuItem})
        btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), Image)
        btnProductos.ImageAlign = ContentAlignment.TopCenter
        btnProductos.ImageTransparentColor = Color.Magenta
        btnProductos.Name = "btnProductos"
        btnProductos.Size = New Size(136, 93)
        btnProductos.Text = "PRODUCTOS"
        btnProductos.TextAlign = ContentAlignment.BottomCenter
        btnProductos.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1701, 552)
        Controls.Add(ToolStripMenu)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMenu"
        WindowState = FormWindowState.Maximized
        ToolStripMenu.ResumeLayout(False)
        ToolStripMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStripMenu As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As ToolStripButton
    Friend WithEvents toolStripDropDownButton2 As ToolStripSplitButton
    Friend WithEvents HistorialDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripDropDownButton3 As ToolStripSplitButton
    Friend WithEvents ToolStripSplitButton4 As ToolStripButton
    Friend WithEvents lblDateTime As ToolStripLabel
    Friend WithEvents timerDateTime As Timer
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents IdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionDePerfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalizacionDeTemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents RegistroDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoMásVendidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnProductos As ToolStripSplitButton
    Friend WithEvents toolStripDropDownButton1 As ToolStripSplitButton
    Friend WithEvents GestionDeInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministraciónDePreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SugerenciasDeInventarioToolStripMenuItem As ToolStripMenuItem
End Class
