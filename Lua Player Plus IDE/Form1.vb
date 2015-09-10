Imports ICSharpCode.AvalonEdit.TextEditor
Imports ICSharpCode.AvalonEdit.Highlighting
Imports ICSharpCode.AvalonEdit.Highlighting.Xshd
Imports Lua_Player_Plus_IDE.AvalonEdit_WinFormHost
Imports System.IO
Imports System.Xml
Imports System.Reflection
Imports System.Windows.Input

Public Class Form1

    'New Script button
    Private Sub NewScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewScriptToolStripMenuItem.Click
        NameScript.Show()
    End Sub

    'New Project button
    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        Dim i As Integer = 0
        While i < Globals.pages
            If Not Globals.saved(i) Then
                Dim result As Integer = MessageBox.Show("Some scripts needs to be saved to not lose your changes. Do you want to save the project before creating a new ones?", "Warning", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Dim z As Integer = 0
                    While z < Globals.pages
                        Globals.SaveFile(i)
                        z = z + 1
                    End While
                End If
                Exit While
            End If
        End While
        TabControl1.TabPages.Clear()
        Globals.pages = 0
        Globals.index = 0

        'Disable project buttons
        NewScriptToolStripMenuItem.Enabled = False
        OpenScriptToolStripMenuItem.Enabled = False
        SaveFileToolStripMenuItem.Enabled = False
        SaveProjectToolStripMenuItem.Enabled = False
        CloseProjectToolStripMenuItem.Enabled = False

        NewProject.Show()
    End Sub

    'Exit button
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim i As Integer = 0
        While i < Globals.pages
            If Not Globals.saved(i) Then
                Dim result As Integer = MessageBox.Show("Some scripts needs to be saved to not lose your changes. Do you want to save the project before exiting?", "Warning", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Dim z As Integer = 0
                    While z < Globals.pages
                        Globals.SaveFile(i)
                        z = z + 1
                    End While
                End If
                Exit While
                End If
        End While
        Me.Close()
    End Sub

    'Save Script button
    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        Globals.SaveFile(Globals.index)
    End Sub

    'Switching towards scripts
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Globals.index = TabControl1.SelectedIndex
    End Sub

    'Save Project Button
    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click
        Dim i As Integer = 0
        While i < Globals.pages
            Globals.SaveFile(i)
            i = i + 1
        End While
    End Sub

    Private Sub CloseProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseProjectToolStripMenuItem.Click
        Dim i As Integer = 0
        While i < Globals.pages
            If Not Globals.saved(i) Then
                Dim result As Integer = MessageBox.Show("Some scripts needs to be saved to not lose your changes. Do you want to save the project before closing it?", "Warning", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Dim z As Integer = 0
                    While z < Globals.pages
                        Globals.SaveFile(i)
                        z = z + 1
                    End While
                End If
                Exit While
            End If
        End While
        TabControl1.TabPages.Clear()
        Globals.pages = 0
        Globals.index = 0

        'Disable project buttons
        NewScriptToolStripMenuItem.Enabled = False
        OpenScriptToolStripMenuItem.Enabled = False
        SaveFileToolStripMenuItem.Enabled = False
        SaveProjectToolStripMenuItem.Enabled = False
        CloseProjectToolStripMenuItem.Enabled = False
    End Sub
End Class

Public Class Globals

    'Global variables
    Public Shared project_path As String
    Public Shared saved = New Boolean(1024) {}
    Public Shared editors = New AvalonEdit_WinFormHost(1024) {}
    Public Shared names = New String(1024) {}
    Public Shared pages As Integer = 0
    Public Shared index As Integer = 0

    'Global callbacks

    'Editor text changed callback
    Private Shared Function Editor_TextChanged(sender As Object, e As EventArgs) As EventHandler
        If saved(Globals.index) Then
            saved(Globals.index) = False
            Form1.TabControl1.SelectedTab.Text = names(Globals.index) & "*"
        End If
    End Function

    'Global functions

    'PrepareEditor (Create a new Editor instance for a LUA script)
    Public Shared Function PrepareEditor(editor As AvalonEdit_WinFormHost, page As TabPage)

        'Load highlighting settings
        Dim reader = New System.Xml.XmlTextReader(New MemoryStream(Lua_Player_Plus_IDE.My.Resources._3DS))
        editor.TextEditor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance)

        'Set TextEditor properties
        page.Controls.Add(editor)
        editor.Dock = DockStyle.Fill
        editor.TextEditor.ShowLineNumbers = True

        'Set TextEditor callbacks
        AddHandler(editor.TextEditor.TextChanged), AddressOf Editor_TextChanged

        'Add TabPage to main TabControl
        Form1.TabControl1.TabPages.Add(page)

        Return 1
    End Function

    'SaveFile (Save a script)
    Public Shared Function SaveFile(idx As Integer)
        Dim p As String
        If Not saved(idx) Then
            Form1.TabControl1.TabPages(idx).Text = Form1.TabControl1.TabPages(idx).Text.Substring(0, Len(Form1.TabControl1.TabPages(idx).Text) - 1)
        End If
        p = Globals.project_path & "\" & Form1.TabControl1.TabPages(idx).Text
        Dim tmp As AvalonEdit_WinFormHost = editors(idx)
        System.IO.File.WriteAllText(p, tmp.TextEditor.Text)
        saved(idx) = True
        Return 1
    End Function

End Class