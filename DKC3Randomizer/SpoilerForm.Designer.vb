<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpoilerForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportLocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportLocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Offset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.World = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultEnemy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewEnemy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportLocationsToolStripMenuItem, Me.ImportLocationsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Seed: "
        '
        'ExportLocationsToolStripMenuItem
        '
        Me.ExportLocationsToolStripMenuItem.Name = "ExportLocationsToolStripMenuItem"
        Me.ExportLocationsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ExportLocationsToolStripMenuItem.Text = "Export Locations"
        '
        'ImportLocationsToolStripMenuItem
        '
        Me.ImportLocationsToolStripMenuItem.Name = "ImportLocationsToolStripMenuItem"
        Me.ImportLocationsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ImportLocationsToolStripMenuItem.Text = "Import Locations"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Offset, Me.World, Me.Level, Me.DefaultEnemy, Me.NewEnemy})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(800, 426)
        Me.DataGridView1.TabIndex = 2
        '
        'Offset
        '
        Me.Offset.HeaderText = "Hex Offset"
        Me.Offset.Name = "Offset"
        Me.Offset.ReadOnly = True
        Me.Offset.Width = 82
        '
        'World
        '
        Me.World.HeaderText = "World"
        Me.World.Name = "World"
        Me.World.ReadOnly = True
        Me.World.Width = 60
        '
        'Level
        '
        Me.Level.HeaderText = "Level"
        Me.Level.Name = "Level"
        Me.Level.ReadOnly = True
        Me.Level.Width = 58
        '
        'DefaultEnemy
        '
        Me.DefaultEnemy.HeaderText = "Default Enemy"
        Me.DefaultEnemy.Name = "DefaultEnemy"
        Me.DefaultEnemy.ReadOnly = True
        Me.DefaultEnemy.Width = 101
        '
        'NewEnemy
        '
        Me.NewEnemy.HeaderText = "New Enemy"
        Me.NewEnemy.Name = "NewEnemy"
        Me.NewEnemy.ReadOnly = True
        Me.NewEnemy.Width = 89
        '
        'SpoilerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "SpoilerForm"
        Me.ShowIcon = False
        Me.Text = "Spoiler Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExportLocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportLocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Offset As DataGridViewTextBoxColumn
    Friend WithEvents World As DataGridViewTextBoxColumn
    Friend WithEvents Level As DataGridViewTextBoxColumn
    Friend WithEvents DefaultEnemy As DataGridViewTextBoxColumn
    Friend WithEvents NewEnemy As DataGridViewTextBoxColumn
End Class
