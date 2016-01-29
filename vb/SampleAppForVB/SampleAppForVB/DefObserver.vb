Public Class DefObserver
    Implements IDefObserver
    Private _f As Form1
    Private _no As Integer

    Sub New(f As Form1, no As Integer)
        _f = f
        _no = no
    End Sub

    Sub Notice(p As Object) Implements IDefObserver.Notice
        Dim s As String = CType(p, String)
        _f.SetText(_no, s)
    End Sub
End Class
