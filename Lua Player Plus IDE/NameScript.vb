Public Class NameScript
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Error ("Invalid name")
        Else
            Dim i = 0
            Dim not_found As Boolean = True
            While (i < Globals.pages) And (not_found)
                If TextBox1.Text = (Globals.names(i) & ".lua") Then
                    Error ("Invalid name")
                    not_found = False
                Else
                    i = i + 1
                End If
            End While
            If not_found Then

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