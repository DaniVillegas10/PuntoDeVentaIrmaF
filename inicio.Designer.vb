<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioDeSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmInicioDeSesion))
        Label1 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        txtUsuario = New TextBox()
        txtContrasena = New TextBox()
        Button1 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(58, 375)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 0
        Label1.Text = "USUARIO: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Broadway", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(96, 278)
        Label3.Name = "Label3"
        Label3.Size = New Size(301, 32)
        Label3.TabIndex = 2
        Label3.Text = "INICIO DE SESIÓN:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(133, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(226, 198)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(45, 437)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 4
        Label2.Text = "CONTRASEÑA: "
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(195, 372)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(237, 31)
        txtUsuario.TabIndex = 5
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(195, 434)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(237, 31)
        txtContrasena.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.Delete_80_icon_icons_com_57340
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(120, 530)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 52)
        Button1.TabIndex = 7
        Button1.Text = "SALIR"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(258, 530)
        Button3.Name = "Button3"
        Button3.Size = New Size(148, 52)
        Button3.TabIndex = 9
        Button3.Text = "INGRESAR"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' frmInicioDeSesion
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Captura_de_pantalla_2024_06_20_201008
        ClientSize = New Size(491, 692)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(txtContrasena)
        Controls.Add(txtUsuario)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmInicioDeSesion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
