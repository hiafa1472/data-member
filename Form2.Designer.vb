<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormDataKustomorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiAkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeskripsiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELAMAT DATANG DI CAR WASH KAMI"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(143, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 242)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplikasiToolStripMenuItem, Me.AkunToolStripMenuItem, Me.AboutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AplikasiToolStripMenuItem
        '
        Me.AplikasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormDataKustomorToolStripMenuItem, Me.FormKasirToolStripMenuItem})
        Me.AplikasiToolStripMenuItem.Name = "AplikasiToolStripMenuItem"
        Me.AplikasiToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AplikasiToolStripMenuItem.Text = "Aplikasi"
        '
        'FormDataKustomorToolStripMenuItem
        '
        Me.FormDataKustomorToolStripMenuItem.Name = "FormDataKustomorToolStripMenuItem"
        Me.FormDataKustomorToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.FormDataKustomorToolStripMenuItem.Text = "Form Data Kustomor"
        '
        'FormKasirToolStripMenuItem
        '
        Me.FormKasirToolStripMenuItem.Name = "FormKasirToolStripMenuItem"
        Me.FormKasirToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.FormKasirToolStripMenuItem.Text = "Form Kasir"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiAkunToolStripMenuItem})
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.AkunToolStripMenuItem.Text = "Akun"
        '
        'GantiAkunToolStripMenuItem
        '
        Me.GantiAkunToolStripMenuItem.Name = "GantiAkunToolStripMenuItem"
        Me.GantiAkunToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GantiAkunToolStripMenuItem.Text = "Ganti Akun"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeskripsiToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DeskripsiToolStripMenuItem
        '
        Me.DeskripsiToolStripMenuItem.Name = "DeskripsiToolStripMenuItem"
        Me.DeskripsiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeskripsiToolStripMenuItem.Text = "Deskripsi"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarAplikasiToolStripMenuItem})
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'KeluarAplikasiToolStripMenuItem
        '
        Me.KeluarAplikasiToolStripMenuItem.Name = "KeluarAplikasiToolStripMenuItem"
        Me.KeluarAplikasiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KeluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormDataKustomorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormKasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AkunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GantiAkunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeskripsiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarAplikasiToolStripMenuItem As ToolStripMenuItem
End Class
