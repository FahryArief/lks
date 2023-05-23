<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_master))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RuteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipetransportasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TransportasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IdtransportasiDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JmlkursiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtipeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LksDataSet = New $safeprojectname$.lksDataSet()
        Me.IdtipeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamatipeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TujuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RuteawalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RuteakhirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtransportasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RuteTableAdapter = New $safeprojectname$.lksDataSetTableAdapters.ruteTableAdapter()
        Me.Tipe_transportasiTableAdapter = New $safeprojectname$.lksDataSetTableAdapters.tipe_transportasiTableAdapter()
        Me.TransportasiTableAdapter = New $safeprojectname$.lksDataSetTableAdapters.transportasiTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RuteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipetransportasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(863, 456)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.DaftarToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.AkunToolStripMenuItem.Text = "Akun"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DaftarToolStripMenuItem
        '
        Me.DaftarToolStripMenuItem.Name = "DaftarToolStripMenuItem"
        Me.DaftarToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.DaftarToolStripMenuItem.Text = "Daftar"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 29)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.AkunToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1699, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mind The Caps DEMO VERSION", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SELAMAT DATANG DI APLIKASI PEMESANAN TIKET"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TujuanDataGridViewTextBoxColumn, Me.RuteawalDataGridViewTextBoxColumn, Me.RuteakhirDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.IdtransportasiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RuteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 626)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(653, 230)
        Me.DataGridView1.TabIndex = 3
        '
        'RuteBindingSource
        '
        Me.RuteBindingSource.DataMember = "rute"
        Me.RuteBindingSource.DataSource = Me.LksDataSetBindingSource
        '
        'TipetransportasiBindingSource
        '
        Me.TipetransportasiBindingSource.DataMember = "tipe_transportasi"
        Me.TipetransportasiBindingSource.DataSource = Me.LksDataSetBindingSource
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtipeDataGridViewTextBoxColumn, Me.NamatipeDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TipetransportasiBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(1330, 626)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(344, 230)
        Me.DataGridView2.TabIndex = 4
        '
        'TransportasiBindingSource
        '
        Me.TransportasiBindingSource.DataMember = "transportasi"
        Me.TransportasiBindingSource.DataSource = Me.LksDataSetBindingSource
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtransportasiDataGridViewTextBoxColumn1, Me.KodeDataGridViewTextBoxColumn, Me.JmlkursiDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn1, Me.IdtipeDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.TransportasiBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(668, 626)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 28
        Me.DataGridView3.Size = New System.Drawing.Size(546, 150)
        Me.DataGridView3.TabIndex = 5
        '
        'IdtransportasiDataGridViewTextBoxColumn1
        '
        Me.IdtransportasiDataGridViewTextBoxColumn1.DataPropertyName = "id_transportasi"
        Me.IdtransportasiDataGridViewTextBoxColumn1.HeaderText = "id_transportasi"
        Me.IdtransportasiDataGridViewTextBoxColumn1.Name = "IdtransportasiDataGridViewTextBoxColumn1"
        Me.IdtransportasiDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'KodeDataGridViewTextBoxColumn
        '
        Me.KodeDataGridViewTextBoxColumn.DataPropertyName = "kode"
        Me.KodeDataGridViewTextBoxColumn.HeaderText = "kode"
        Me.KodeDataGridViewTextBoxColumn.Name = "KodeDataGridViewTextBoxColumn"
        '
        'JmlkursiDataGridViewTextBoxColumn
        '
        Me.JmlkursiDataGridViewTextBoxColumn.DataPropertyName = "jml_kursi"
        Me.JmlkursiDataGridViewTextBoxColumn.HeaderText = "jml_kursi"
        Me.JmlkursiDataGridViewTextBoxColumn.Name = "JmlkursiDataGridViewTextBoxColumn"
        '
        'KeteranganDataGridViewTextBoxColumn1
        '
        Me.KeteranganDataGridViewTextBoxColumn1.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn1.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn1.Name = "KeteranganDataGridViewTextBoxColumn1"
        '
        'IdtipeDataGridViewTextBoxColumn1
        '
        Me.IdtipeDataGridViewTextBoxColumn1.DataPropertyName = "id_tipe"
        Me.IdtipeDataGridViewTextBoxColumn1.HeaderText = "id_tipe"
        Me.IdtipeDataGridViewTextBoxColumn1.Name = "IdtipeDataGridViewTextBoxColumn1"
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
        'IdtipeDataGridViewTextBoxColumn
        '
        Me.IdtipeDataGridViewTextBoxColumn.DataPropertyName = "id_tipe"
        Me.IdtipeDataGridViewTextBoxColumn.HeaderText = "id_tipe"
        Me.IdtipeDataGridViewTextBoxColumn.Name = "IdtipeDataGridViewTextBoxColumn"
        Me.IdtipeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamatipeDataGridViewTextBoxColumn
        '
        Me.NamatipeDataGridViewTextBoxColumn.DataPropertyName = "nama_tipe"
        Me.NamatipeDataGridViewTextBoxColumn.HeaderText = "nama_tipe"
        Me.NamatipeDataGridViewTextBoxColumn.Name = "NamatipeDataGridViewTextBoxColumn"
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        '
        'TujuanDataGridViewTextBoxColumn
        '
        Me.TujuanDataGridViewTextBoxColumn.DataPropertyName = "tujuan"
        Me.TujuanDataGridViewTextBoxColumn.HeaderText = "tujuan"
        Me.TujuanDataGridViewTextBoxColumn.Name = "TujuanDataGridViewTextBoxColumn"
        '
        'RuteawalDataGridViewTextBoxColumn
        '
        Me.RuteawalDataGridViewTextBoxColumn.DataPropertyName = "rute_awal"
        Me.RuteawalDataGridViewTextBoxColumn.HeaderText = "rute_awal"
        Me.RuteawalDataGridViewTextBoxColumn.Name = "RuteawalDataGridViewTextBoxColumn"
        '
        'RuteakhirDataGridViewTextBoxColumn
        '
        Me.RuteakhirDataGridViewTextBoxColumn.DataPropertyName = "rute_akhir"
        Me.RuteakhirDataGridViewTextBoxColumn.HeaderText = "rute_akhir"
        Me.RuteakhirDataGridViewTextBoxColumn.Name = "RuteakhirDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'IdtransportasiDataGridViewTextBoxColumn
        '
        Me.IdtransportasiDataGridViewTextBoxColumn.DataPropertyName = "id_transportasi"
        Me.IdtransportasiDataGridViewTextBoxColumn.HeaderText = "id_transportasi"
        Me.IdtransportasiDataGridViewTextBoxColumn.Name = "IdtransportasiDataGridViewTextBoxColumn"
        '
        'RuteTableAdapter
        '
        Me.RuteTableAdapter.ClearBeforeFill = True
        '
        'Tipe_transportasiTableAdapter
        '
        Me.Tipe_transportasiTableAdapter.ClearBeforeFill = True
        '
        'TransportasiTableAdapter
        '
        Me.TransportasiTableAdapter.ClearBeforeFill = True
        '
        'form_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1699, 744)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "form_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RuteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipetransportasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ReToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LksDataSet1 As lksDataSet
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AkunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LksDataSetBindingSource As BindingSource
    Friend WithEvents LksDataSet As lksDataSet
    Friend WithEvents RuteBindingSource As BindingSource
    Friend WithEvents RuteTableAdapter As lksDataSetTableAdapters.ruteTableAdapter
    Friend WithEvents TipetransportasiBindingSource As BindingSource
    Friend WithEvents Tipe_transportasiTableAdapter As lksDataSetTableAdapters.tipe_transportasiTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents IdtipeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamatipeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransportasiBindingSource As BindingSource
    Friend WithEvents TransportasiTableAdapter As lksDataSetTableAdapters.transportasiTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents IdtransportasiDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents KodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JmlkursiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdtipeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TujuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RuteawalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RuteakhirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtransportasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
