Imports System.IO.Ports
Imports System.Threading

Public Class DefSerialPort
    Inherits SerialPort
    'Private Shared _instance As DefSerialPort
    Private _sender As Thread
    Private _receiver As Thread
    Private _semaphore As Semaphore
    Private _indata As String
    Public Sub New()
        Console.WriteLine("@ start")
        _semaphore = New Semaphore(0, 1)

        _sender = New Thread(New ThreadStart(AddressOf SendHandler))
        _sender.Start()

        _receiver = New Thread(New ThreadStart(AddressOf ReceiveHandler))
        _receiver.Start()

        AddHandler Me.DataReceived, AddressOf DataReceivedHandler

        Console.WriteLine("@ end")
    End Sub

    'Public Shared Function Instance() As DefSerialPort
    '    If _instance Is Nothing Then
    '        _instance = New DefSerialPort
    '    End If

    '    Return _instance
    'End Function

    ''' <summary>
    ''' 送信ハンドラ
    ''' </summary>
    ''' <remarks></remarks>
    Sub SendHandler()
        Console.WriteLine("@ SendHandler")

    End Sub

    Sub Send(data As String)
        Me.Write(data)
    End Sub

    Private _observer As DefObserver
    ''' <summary>
    ''' 受信ハンドラ
    ''' </summary>
    ''' <remarks></remarks>
    Sub ReceiveHandler()
        Console.WriteLine("@ ReceiveHandler")
        While 1
            'Dim data As String
            'Const BufSz = 1024
            'Dim bytes(BufSz) As Byte
            'data = Me.ReadExisting()
            ''Me.Read(bytes, 0, BufSz)
            ''data = System.Text.Encoding.ASCII.GetString(bytes, 0, BufSz)
            'If Not _observer Is Nothing Then
            '    _observer.ReceiveNotice(data)
            '    '_observer = Nothing
            'End If
        End While
    End Sub

    Function Receive(observer As DefObserver) As String
        'Dim data As String
        'Const BufSz = 1024
        'Dim bytes(BufSz) As Byte
        'Me.Read(bytes, 0, BufSz)
        'data = System.Text.Encoding.ASCII.GetString(bytes, 0, BufSz)
        'Return data
        _observer = observer
        Return ""
    End Function

    Function Receive() As String
        'Dim data As String
        'Const BufSz = 1024
        'Dim bytes(BufSz) As Byte
        'Me.Read(bytes, 0, BufSz)
        'data = System.Text.Encoding.ASCII.GetString(bytes, 0, BufSz)
        'Return data
        Console.WriteLine("@ Receive start")
        _indata = Nothing
        _semaphore.WaitOne()
        _observer = Nothing
        Console.WriteLine("@ Receive end")
        Return _indata
    End Function

    Public Sub Notice(d As String)
        If Not _observer Is Nothing Then
            _observer.ReceiveNotice(d)
            '_observer = Nothing
        Else
            _semaphore.Release()
        End If

    End Sub

    Private Shared Sub DataReceivedHandler(
                        sender As Object,
                        e As SerialDataReceivedEventArgs)
        Dim sp As DefSerialPort = CType(sender, DefSerialPort)

        sp._indata = sp.ReadExisting()

        'Dim indata As String
        'Dim BufSz As Integer = 1024
        'Dim bytes(BufSz) As Byte
        'sp.Read(bytes, 0, BufSz)
        'indata = System.Text.Encoding.ASCII.GetString(bytes, 0, BufSz)
        'sp.NewLine = Chr(3)
        sp.Notice(sp._indata)
        sp.DiscardInBuffer()
        Console.Write("Data Received: ")
        Console.WriteLine(sp._indata)


    End Sub

    ''' <summary>
    ''' 初期化
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Initialize()
        Me.Open()
    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Terminate()
        Me.Close()
    End Sub


End Class
