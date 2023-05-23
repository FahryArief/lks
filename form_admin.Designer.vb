<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_admin
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
        Me.components = New System.ComponentModel.Container()
        Me.PenumpangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LksDataSet = New $safeprojectname$.lksDataSet()
        Me.PemesananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PemesananTableAdapter = New $safeprojectname$.lksDataSetTableAdapters.pemesananTableAdapter()
        Me.PenumpangTableAdapter = New $safeprojectname$.lksDataSetTableAdapters.penumpangTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeretaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesawatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenumpangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PenumpangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PenumpangBindingSource
        '
        Me.PenumpangBindingSource.DataMember = "penumpang"
        Me.PenumpangBindingSource.DataSource = Me.LksDataSetBindingSource
        '
        'LksDataSetBindingSource
        '
        Me.LksDataSetBindingSource.DataSource = Me.LksDataSet
        Me.LksDataSetBindingSource.Position = 0
        '
        'LksDataSet
        '
        Me.LksDataSet.DataSetName = "lksDataSet"
        Me.LksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PemesananBindingSource
        '
        Me.PemesananBindingSource.DataMember = "pemesanan"
        Me.PemesananBindingSource.DataSource = Me.LksDataSetBindingSource
        '
        'PemesananTableAdapter
        '
        Me.PemesananTableAdapter.ClearBeforeFill = True
        '
        'PenumpangTableAdapter
        '
        Me.PenumpangTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.KeretaToolStripMenuItem, Me.PesawatToolStripMenuItem, Me.UserToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.PesananToolStripMenuItem, Me.LogoutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(745, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'KeretaToolStripMenuItem
        '
        Me.KeretaToolStripMenuItem.Name = "KeretaToolStripMenuItem"
        Me.KeretaToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeretaToolStripMenuItem.Text = "Kereta"
        '
        'PesawatToolStripMenuItem
        '
        Me.PesawatToolStripMenuItem.Name = "PesawatToolStripMenuItem"
        Me.PesawatToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.PesawatToolStripMenuItem.Text = "Pesawat"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenumpangToolStripMenuItem, Me.AdministratorToolStripMenuItem, Me.PetugasToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'PenumpangToolStripMenuItem
        '
        Me.PenumpangToolStripMenuItem.Name = "PenumpangToolStripMenuItem"
        Me.PenumpangToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PenumpangToolStripMenuItem.Text = "Penumpang"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PetugasToolStripMenuItem.Text = "Petugas"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogoutToolStripMenuItem.Text = "Laporan"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.panel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 279)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(745, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'panel1
        '
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(42, 17)
        Me.panel1.Text = "panel1"
        '
        'form_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 301)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "form_admin"
        Me.Text = "form_admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PenumpangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemesananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LksDataSetBindingSource As BindingSource
    Friend WithEvents LksDataSet As lksDataSet
    Friend WithEvents PemesananBindingSource As BindingSource
    Friend WithEvents PemesananTableAdapter As lksDataSetTableAdapters.pemesananTableAdapter
    Friend WithEvents PenumpangBindingSource As BindingSource
    Friend WithEvents PenumpangTableAdapter As lksDataSetTableAdapters.penumpangTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeretaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesawatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenumpangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents panel1 As ToolStripStatusLabel
End Class
