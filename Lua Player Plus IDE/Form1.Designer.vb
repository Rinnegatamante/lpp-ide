<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SyntaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lpp3dsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ModifyToolStripMenuItem, Me.SearchToolStripMenuItem, Me.SyntaxToolStripMenuItem, Me.DebugToolStripMenuItem, Me.ReleaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1176, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.NewScriptToolStripMenuItem, Me.OpenProjectToolStripMenuItem, Me.OpenScriptToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.SaveFileToolStripMenuItem, Me.CloseProjectToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        '
        'NewScriptToolStripMenuItem
        '
        Me.NewScriptToolStripMenuItem.Enabled = False
        Me.NewScriptToolStripMenuItem.Name = "NewScriptToolStripMenuItem"
        Me.NewScriptToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.NewScriptToolStripMenuItem.Text = "New Script"
        '
        'OpenProjectToolStripMenuItem
        '
        Me.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem"
        Me.OpenProjectToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.OpenProjectToolStripMenuItem.Text = "Open Project"
        '
        'OpenScriptToolStripMenuItem
        '
        Me.OpenScriptToolStripMenuItem.Enabled = False
        Me.OpenScriptToolStripMenuItem.Name = "OpenScriptToolStripMenuItem"
        Me.OpenScriptToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.OpenScriptToolStripMenuItem.Text = "Open Script"
        '
        'SaveProjectToolStripMenuItem
        '
        Me.SaveProjectToolStripMenuItem.Enabled = False
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        Me.SaveProjectToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SaveProjectToolStripMenuItem.Text = "Save Project"
        '
        'SaveFileToolStripMenuItem
        '
        Me.SaveFileToolStripMenuItem.Enabled = False
        Me.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        Me.SaveFileToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SaveFileToolStripMenuItem.Text = "Save File"
        '
        'CloseProjectToolStripMenuItem
        '
        Me.CloseProjectToolStripMenuItem.Enabled = False
        Me.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem"
        Me.CloseProjectToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CloseProjectToolStripMenuItem.Text = "Close Project"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem, Me.ReplaceToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FindToolStripMenuItem.Text = "Find..."
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        Me.ReplaceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReplaceToolStripMenuItem.Text = "Replace..."
        '
        'SyntaxToolStripMenuItem
        '
        Me.SyntaxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lpp3dsToolStripMenuItem})
        Me.SyntaxToolStripMenuItem.Name = "SyntaxToolStripMenuItem"
        Me.SyntaxToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SyntaxToolStripMenuItem.Text = "Syntax"
        '
        'Lpp3dsToolStripMenuItem
        '
        Me.Lpp3dsToolStripMenuItem.Name = "Lpp3dsToolStripMenuItem"
        Me.Lpp3dsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.Lpp3dsToolStripMenuItem.Text = "lpp-3ds"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugProjectToolStripMenuItem})
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'DebugProjectToolStripMenuItem
        '
        Me.DebugProjectToolStripMenuItem.Enabled = False
        Me.DebugProjectToolStripMenuItem.Name = "DebugProjectToolStripMenuItem"
        Me.DebugProjectToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.DebugProjectToolStripMenuItem.Text = "Debug Project with Citra"
        '
        'ReleaseToolStripMenuItem
        '
        Me.ReleaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileProjectToolStripMenuItem, Me.CompileScriptToolStripMenuItem, Me.BuildProjectToolStripMenuItem})
        Me.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem"
        Me.ReleaseToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ReleaseToolStripMenuItem.Text = "Release"
        '
        'CompileProjectToolStripMenuItem
        '
        Me.CompileProjectToolStripMenuItem.Enabled = False
        Me.CompileProjectToolStripMenuItem.Name = "CompileProjectToolStripMenuItem"
        Me.CompileProjectToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CompileProjectToolStripMenuItem.Text = "Compile Project"
        '
        'CompileScriptToolStripMenuItem
        '
        Me.CompileScriptToolStripMenuItem.Enabled = False
        Me.CompileScriptToolStripMenuItem.Name = "CompileScriptToolStripMenuItem"
        Me.CompileScriptToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CompileScriptToolStripMenuItem.Text = "Compile Script"
        '
        'BuildProjectToolStripMenuItem
        '
        Me.BuildProjectToolStripMenuItem.Enabled = False
        Me.BuildProjectToolStripMenuItem.Name = "BuildProjectToolStripMenuItem"
        Me.BuildProjectToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BuildProjectToolStripMenuItem.Text = "Build Project"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1176, 477)
        Me.TabControl1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 501)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Lua Player Plus IDE v.0.1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents NewProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SyntaxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lpp3dsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReleaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
End Class
