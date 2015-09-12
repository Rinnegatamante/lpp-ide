Imports ICSharpCode.AvalonEdit.TextEditor
Imports ICSharpCode.AvalonEdit.Highlighting
Imports ICSharpCode.AvalonEdit.Highlighting.Xshd
Imports Lua_Player_Plus_IDE.AvalonEdit_WinFormHost
Imports System.IO
Imports System.Xml
Imports System.Reflection
Imports System.Windows.Input
Imports FindReplace
Imports FindReplace.FindReplaceDialog

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
                Dim result As Integer = MessageBox.Show("Some scripts needs to be saved to not lose your changes. Do you want to save the project before creating a new ones?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim z As Integer = 0
                    While z < Globals.pages
                        Globals.SaveFile(i)
                        z = z + 1
                    End While
                End If
                Exit While
            End If
            i = i + 1
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
        DebugProjectToolStripMenuItem.Enabled = False
        CompileProjectToolStripMenuItem.Enabled = False
        CompileScriptToolStripMenuItem.Enabled = False
        BuildProjectToolStripMenuItem.Enabled = False

        NewProject.Show()
    End Sub

    'Exit button
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
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
                Dim result As Integer = MessageBox.Show("Some scripts needs to be saved to not lose your changes. Do you want to save the project before closing it?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
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
        DebugProjectToolStripMenuItem.Enabled = False
        CompileProjectToolStripMenuItem.Enabled = False
        CompileScriptToolStripMenuItem.Enabled = False
        BuildProjectToolStripMenuItem.Enabled = False

    End Sub

    'Exiting Code
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim i As Integer = 0
        While i < Globals.pages
            If Not Globals.saved(i) Then
                Dim result As Integer = MessageBox.Show("Some scripts needs to be saved to not lose your changes. Do you want to save the project before exiting?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim z As Integer = 0
                    While z < Globals.pages
                        Globals.SaveFile(i)
                        z = z + 1
                    End While
                End If
                Exit While
            End If
            i = i + 1
        End While
    End Sub

    'Open Script button
    Private Sub OpenScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenScriptToolStripMenuItem.Click
        Dim h As New OpenFileDialog
        h.Filter = "Lua Script|*.lua"
        h.Multiselect = False
        Dim result = h.ShowDialog()
        If result = System.Windows.Forms.DialogResult.OK Then
            Dim file = h.FileName
            Dim name = h.SafeFileName
            Dim subname = name.Substring(0, Len(name) - 4)
            Dim idx = 1
            While Globals.CheckScript(name)
                name = subname & " (" & idx & ")" & ".lua"
                idx = idx + 1
            End While

            'Create new script
            Dim page As New TabPage
            page.Text = name
            Dim editor As New AvalonEdit_WinFormHost
            editor.TextEditor.Text = System.IO.File.ReadAllText(file)
            Globals.PrepareEditor(editor, page)
            Globals.editors(Globals.pages) = editor
            Globals.saved(Globals.pages) = True
            Globals.names(Globals.pages) = name
            TabControl1.SelectedIndex = Globals.pages
            Globals.index = Globals.pages
            Globals.pages = Globals.pages + 1

        End If
    End Sub

    'Compile Script button
    Private Sub CompileScriptToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CompileScriptToolStripMenuItem.Click
        Globals.SaveFile(Globals.index)
        Globals.CompileFile(Globals.index)
    End Sub

    'Compile Project button
    Private Sub CompileProjectToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CompileProjectToolStripMenuItem.Click
        Dim i As Integer = 0
        While i < Globals.pages
            Globals.SaveFile(i)
            Globals.CompileFile(i)
            i = i + 1
        End While
    End Sub

    'Open Project button
    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        Dim i As Integer = 0
        While i < Globals.pages
            If Not Globals.saved(i) Then
                Dim result As Integer = MessageBox.Show("Some scripts needs to be saved to not lose your changes. Do you want to save the project before exiting?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim z As Integer = 0
                    While z < Globals.pages
                        Globals.SaveFile(i)
                        z = z + 1
                    End While
                End If
                Exit While
            End If
            i = i + 1
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
        DebugProjectToolStripMenuItem.Enabled = False
        CompileProjectToolStripMenuItem.Enabled = False
        CompileScriptToolStripMenuItem.Enabled = False
        BuildProjectToolStripMenuItem.Enabled = False

        Dim x As New FolderBrowserDialog
        Dim res = x.ShowDialog()
        If res = 1 Then
            Dim is_project As Boolean = False
            Dim scripts = New String(1024) {}
            Dim files = Directory.GetFiles(x.SelectedPath)
            Dim j As Integer = 0
            If files.Count < 1 Then
                MessageBox.Show("Selected folder is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For Each f As String In files
                    If f.Substring(Len(f) - 4, 4) = ".lua" Then
                        Dim sf As String = f.Substring(Len(x.SelectedPath) + 1, Len(f) - Len(x.SelectedPath) - 1)
                        If sf = "index.lua" Then
                            is_project = True
                        End If
                        scripts(j) = sf
                        j = j + 1
                    End If
                Next
            End If
            If is_project Then
                Globals.project_path = x.SelectedPath
                j = j - 1

                'Create needed folders
                If Not System.IO.Directory.Exists(Globals.project_path & "\Release") Then
                    System.IO.Directory.CreateDirectory(Globals.project_path & "\Release")
                End If

                While j >= 0

                    'Create new script
                    Dim page As New TabPage
                    page.Text = scripts(j)
                    Dim editor As New AvalonEdit_WinFormHost
                    editor.TextEditor.Text = System.IO.File.ReadAllText(Globals.project_path & "/" & scripts(j))
                    Globals.PrepareEditor(editor, page)
                    Globals.editors(Globals.pages) = editor
                    Globals.saved(Globals.pages) = True
                    Globals.names(Globals.pages) = scripts(j)
                    TabControl1.SelectedIndex = Globals.pages
                    Globals.index = Globals.pages
                    Globals.pages = Globals.pages + 1

                    j = j - 1
                End While

                'Enable project buttons
                NewScriptToolStripMenuItem.Enabled = True
                OpenScriptToolStripMenuItem.Enabled = True
                SaveFileToolStripMenuItem.Enabled = True
                SaveProjectToolStripMenuItem.Enabled = True
                CloseProjectToolStripMenuItem.Enabled = True
                DebugProjectToolStripMenuItem.Enabled = True
                CompileProjectToolStripMenuItem.Enabled = True
                CompileScriptToolStripMenuItem.Enabled = True
                BuildProjectToolStripMenuItem.Enabled = True

            Else
                MessageBox.Show("Missing index.lua.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    'Editor text changed callback
    Private Shared Function Citra_Exited(sender As Object, e As EventArgs) As EventHandler
        Dim i As Integer = 0
        While i < Globals.pages
            Globals.SaveFile(i)
            IO.File.Delete("Citra\user\sdmc\scripts\" & Globals.names(i))
            i = i + 1
        End While
        Globals.isCitraOn = False
    End Function

    'Debug Project button
    Private Sub DebugProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugProjectToolStripMenuItem.Click
        Dim i As Integer = 0
        While i < Globals.pages
            Globals.SaveFile(i)
            IO.File.Copy(Globals.project_path & "\" & Globals.names(i), "Citra\user\sdmc\scripts\" & Globals.names(i), True)
            i = i + 1
        End While
        Dim x = Process.Start("Citra\Citra.exe", "Citra\lpp-3ds.3dsx")
        Globals.isCitraOn = True

        'Set Citra Exiting callback
        AddHandler(x.Exited), AddressOf Citra_Exited
    End Sub

    'Find button
    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Globals.PrepareFindReplace()
        Globals.frm.ShowAsFind()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        Globals.PrepareFindReplace()
        Globals.frm.ShowAsReplace()
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
    Public Shared syntax As Byte() = Lua_Player_Plus_IDE.My.Resources._3DS
    Public Shared mode As String = "3DS"
    Public Shared isCitraOn As Boolean = False
    Public Shared frm As FindReplace.FindReplaceMgr = New FindReplace.FindReplaceMgr()


    'Global callbacks

    'Editor text changed callback
    Private Shared Function Editor_TextChanged(sender As Object, e As EventArgs) As EventHandler
        Dim x = DirectCast(sender, AvalonEdit_WinFormHost)
        Dim tab As TabPage = x.Parent
        Form1.TabControl1.SelectedIndex = tab.TabIndex
    End Function

    Private Shared Function test(sender As Object, e As EventArgs) As EventHandler
        Dim x = DirectCast(sender, FindReplaceMgr)
        Dim i = 0
        While i < pages
            If editors(i) = frm.CurrentEditor Then
                index = i
                Form1.TabControl1.SelectedIndex = index
                Exit While
            End If
            i = i + 1
        End While
    End Function

    'Global functions

    'PrepareFindReplace (Prepare Find/Replace feature)
    Public Shared Function PrepareFindReplace()
        Dim x As AvalonEdit_WinFormHost = editors(index)
        frm.CurrentEditor = New TextEditorAdapter(x.TextEditor)
        frm.Editors = editors
        frm.ShowSearchIn = True

        AddHandler frm.FindBinding.Executed, AddressOf test
        Return 1
    End Function

    'PrepareEditor (Create a new Editor instance for a LUA script)
    Public Shared Function PrepareEditor(editor As AvalonEdit_WinFormHost, page As TabPage)

        'Load highlighting settings
        Dim reader = New System.Xml.XmlTextReader(New MemoryStream(syntax))
        editor.TextEditor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance)

        'Set TextEditor properties
        page.Controls.Add(editor)
        editor.Dock = DockStyle.Fill
        editor.TextEditor.FontSize = 12
        editor.TextEditor.ShowLineNumbers = True

        'Set TextEditor callbacks
        AddHandler(editor.TextEditor.TextChanged), AddressOf Editor_TextChanged

        'Add TabPage to main TabControl
        Form1.TabControl1.TabPages.Add(page)

        Return 1
    End Function

    'ReloadEditor (Reload properties for a Editor)
    Public Shared Function ReloadEditor(editor As AvalonEdit_WinFormHost)

        'Load highlighting settings
        Dim reader = New System.Xml.XmlTextReader(New MemoryStream(syntax))
        editor.TextEditor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance)

        'Set TextEditor properties
        editor.TextEditor.FontSize = 12
        editor.TextEditor.ShowLineNumbers = True

        Return 1
    End Function

    'SaveFile (Save a script)
    Public Shared Function SaveFile(idx As Integer)
        Dim p As String
        If Not saved(idx) Then
            Form1.TabControl1.TabPages(idx).Text = Form1.TabControl1.TabPages(idx).Text.Substring(0, Len(Form1.TabControl1.TabPages(idx).Text) - 1)
        End If
        p = project_path & "\" & Form1.TabControl1.TabPages(idx).Text
        Dim tmp As AvalonEdit_WinFormHost = editors(idx)
        System.IO.File.WriteAllText(p, tmp.TextEditor.Text)
        If isCitraOn Then
            System.IO.File.WriteAllText("Citra\user\sdmc\scripts\" & Form1.TabControl1.TabPages(idx).Text, tmp.TextEditor.Text)
        End If
        saved(idx) = True
        Return 1
    End Function

    'CheckScript (Check if a selected script is already opened)
    Public Shared Function CheckScript(name As String) As Boolean
        Dim i = 0
        Dim not_found As Boolean = True
        While (i < pages) And (not_found)
            If name = (names(i) & ".lua") Then
                Return True
                not_found = False
            Else
                i = i + 1
            End If
        End While
        Return False
    End Function

    'CompileFile (Compile a script with luaC)
    Public Shared Function CompileFile(idx As Integer)
        Dim target = project_path & "\" & names(idx)
        Process.Start("LuaC\luac.exe", "-o " & project_path & "\Release\" & names(idx) & " " & target)
        Return 1
    End Function

End Class