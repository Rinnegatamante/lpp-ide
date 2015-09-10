Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization

<Designer("System.Windows.Forms.Design.ControlDesigner, System.Design")>
<DesignerSerializer("System.ComponentModel.Design.Serialization.TypeCodeDomSerializer , System.Design", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design")>
Public Class AvalonEdit_WinFormHost
    Inherits System.Windows.Forms.Integration.ElementHost
    Public Property TextEditor() As ICSharpCode.AvalonEdit.TextEditor
        Get
            Return m_TextEditor
        End Get
        Set
            m_TextEditor = Value
        End Set
    End Property
    Private m_TextEditor As ICSharpCode.AvalonEdit.TextEditor

    Public Sub New()
        TextEditor = New ICSharpCode.AvalonEdit.TextEditor()
        MyBase.Child = TextEditor
    End Sub
End Class