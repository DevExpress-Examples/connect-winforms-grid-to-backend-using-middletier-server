Imports DevExpress.XtraEditors

Namespace WinForms.Client

    Public Partial Class AuthForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public ReadOnly Property Login As String
            Get
                Return userNameEdit.Text
            End Get
        End Property

        Public ReadOnly Property Password As String
            Get
                Return passwordEdit.Text
            End Get
        End Property
    End Class
End Namespace
