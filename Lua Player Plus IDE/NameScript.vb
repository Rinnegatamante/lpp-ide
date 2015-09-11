Public Class NameScript
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Invalid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Globals.CheckScript(TextBox1.Text & ".lua") Then
                MessageBox.Show("This script already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                'Create new script
                Dim page As New TabPage
                page.Text = TextBox1.Text & ".lua"
                Dim editor As New AvalonEdit_WinFormHost
                Globals.PrepareEditor(editor, page)
                Globals.editors(Globals.pages) = editor
                Globals.saved(Globals.pages) = True
                Globals.names(Globals.pages) = TextBox1.Text & ".lua"
                Form1.TabControl1.SelectedIndex = Globals.pages
                Globals.index = Globals.pages
                Globals.pages = Globals.pages + 1

                Me.Close()

            End If
        End If
    End Sub

    Private Sub NameScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class