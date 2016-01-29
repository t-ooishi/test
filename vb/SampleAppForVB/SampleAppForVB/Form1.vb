Public Class Form1
    Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private _port1 As DefSerialPort
    Private _port2 As DefSerialPort
    Private _observer As DefObserver

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _port1 = New DefSerialPort()
        _port1.PortName = "COM3"
        '_port1.Initialize()

        _port2 = New DefSerialPort()
        _port2.PortName = "COM5"
        '_port2.Initialize()

        '_observer = New DefObserver(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Invoke(Sub()
                   _port1.Send(TextBox1.Text)
               End Sub)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Invoke(Sub()
                   '                   TextBox2.Text = _port1.Receive(_observer)
                   'TextBox2.Text = _port1.Receive()
                   Dim observer As DefObserver = New DefObserver(Me, 2)
                   _port1.Receive(observer)
               End Sub)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Invoke(Sub()
                   Dim s As String = String.Format("a{0}b{1}c{2}", Chr(3), Chr(5), Chr(13))

                   '                   _port2.Send(TextBox3.Text)
                   '  Chr(
                   Dim d As Byte() = System.Text.Encoding.ASCII.GetBytes(s)
                   _port2.Send(s)
               End Sub)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Invoke(Sub()
                   '                   TextBox4.Text = _port2.Receive(_observer)
                   TextBox4.Text = _port2.Receive()
                   'Dim observer As DefObserver = New DefObserver(Me, 4)
                   '_port2.Receive(observer)
               End Sub)
    End Sub

    Public Sub SetText(no As Integer, str As String)
        Select Case no
            Case 2
                Invoke(Sub()
                           Dim d As Byte() = System.Text.Encoding.ASCII.GetBytes(str)
                           TextBox2.Text = str
                       End Sub)
            Case 4
                Invoke(Sub()
                           TextBox4.Text = str
                       End Sub)
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "接続" Then
            _port1.Initialize()
            Button5.Text = "切断"
        Else
            _port1.Terminate()
            Button5.Text = "接続"
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = "接続" Then
            _port2.Initialize()
            Button6.Text = "切断"
        Else
            _port2.Terminate()
            Button6.Text = "接続"
        End If


    End Sub
End Class
