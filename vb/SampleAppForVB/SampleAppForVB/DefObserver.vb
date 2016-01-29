Public Class DefObserver
    Private _form As Form1

    Sub New(form As Form1)
        _form = form
    End Sub

    Sub ReceiveNotice(d As String)
        _form.SetText(2, d)
    End Sub


End Class
