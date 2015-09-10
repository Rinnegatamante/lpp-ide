﻿Public Class NewProject

    'Browse button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New FolderBrowserDialog
        Dim result = x.ShowDialog()
        If result = 1 Then
            TextBox2.Text = x.SelectedPath
            Button2.Enabled = True
        End If
    End Sub

    'Create Project button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Set Project Path
        Globals.project_path = TextBox2.Text

        'Create new script (index.lua)
        Dim page As New TabPage
        page.Text = "index.lua"
        Globals.names(0) = "index.lua"
        Dim editor As New AvalonEdit_WinFormHost
        Globals.PrepareEditor(editor, page)
        Globals.saved(0) = True
        Globals.editors(0) = editor
        Globals.index = 0

        'Enable project buttons
        Form1.NewScriptToolStripMenuItem.Enabled = True
        Form1.OpenScriptToolStripMenuItem.Enabled = True
        Form1.SaveFileToolStripMenuItem.Enabled = True
        Form1.SaveProjectToolStripMenuItem.Enabled = True
        Form1.CloseProjectToolStripMenuItem.Enabled = True

        'Close New Project Form
        Me.Close()

    End Sub
End Class