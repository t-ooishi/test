Imports System.IO.Ports
Imports System.Threading

''' <summary>
''' シリアル通信
''' </summary>
''' <remarks>
''' シリアル通信の接続,切断と送受信を行う
''' </remarks>
Public Class DefSerialPort
    Inherits SerialPort
    Private _semaphore As Semaphore
    Private _observer As IDefObserver
    Private _indata As String
    Private _received As Boolean

    ''' <summary>
    ''' インスタンス生成
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Console.WriteLine("@ start")
        CreateObject()
        Console.WriteLine("@ end")
    End Sub

    ''' <summary>
    ''' インスタンス生成
    ''' </summary>
    ''' <param name="portName"></param>
    ''' <param name="baudRate"></param>
    ''' <param name="parity"></param>
    ''' <param name="dataBits"></param>
    ''' <param name="stopBits"></param>
    ''' <param name="handshake"></param>
    ''' <remarks></remarks>
    Public Sub New(
                  portName As String,
                  baudRate As Integer,
                  parity As Parity,
                  dataBits As Integer,
                  stopBits As StopBits,
                  handshake As Handshake
                  )
        Me.PortName = portName
        Me.BaudRate = baudRate
        Me.Parity = parity
        Me.DataBits = dataBits
        Me.StopBits = stopBits
        Me.Handshake = handshake

        CreateObject()
    End Sub

    ''' <summary>
    ''' 各種オブジェクト生成
    ''' </summary>
    ''' <remarks>
    ''' セマフォ生成とシリアル受信ハンドラ登録を行う
    ''' </remarks>
    Private Sub CreateObject()
        _received = False
        _semaphore = New Semaphore(0, 1)
        AddHandler Me.DataReceived, AddressOf DataReceivedHandler
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

    ''' <summary>
    ''' 書込み処理(Wrapper)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DummyWrite(data As String)
        Me.Write(data)
    End Sub

    ''' <summary>
    ''' 読み出し処理(Wrapper)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DummyRead() As String
        Return Me.ReadExisting()
    End Function

    ''' <summary>
    ''' シリアル送信
    ''' </summary>
    ''' <param name="data"></param>
    ''' <remarks></remarks>
    Public Sub Send(data As String)
        If Not Me.IsOpen Then
            Return
        End If

        'Me.Write(data)
        DummyWrite(data)
    End Sub

    ''' <summary>
    ''' シリアル受信(同期)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Receive() As String
        If Not Me.IsOpen Then
            Return Nothing
        End If

        Console.WriteLine("@ Receive(Sync) start")
        _indata = Nothing
        _observer = Nothing
        _received = True
        _semaphore.WaitOne()
        _received = False
        Console.WriteLine("@ Receive(Sync) end")
        Return _indata
    End Function

    ''' <summary>
    ''' シリアル受信(非同期)
    ''' </summary>
    ''' <param name="observer"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Receive(observer As IDefObserver) As String
        If Not Me.IsOpen Then
            Return Nothing
        End If

        Console.WriteLine("@ Receive(Async) start")
        _indata = Nothing
        _observer = observer
        Console.WriteLine("@ Receive(Async) end")
        Return _indata
    End Function

    ''' <summary>
    ''' シリアル受信(非同期)の中断
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Abort()
        _indata = Nothing
        _observer = Nothing
    End Sub


    ''' <summary>
    ''' シリアル受信ハンドラ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Shared Sub DataReceivedHandler(
                        sender As Object,
                        e As SerialDataReceivedEventArgs)
        Dim sp As DefSerialPort = CType(sender, DefSerialPort)

        'sp._indata = sp.ReadExisting()
        sp._indata = sp.DummyRead()

        sp.Notice()
        Console.Write("Data Received: ")
        Console.WriteLine(sp._indata)
    End Sub

    ''' <summary>
    ''' シリアル受信のイベント通知
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Notice()
        If _observer Is Nothing Then
            If _received Then
                _semaphore.Release()
            End If
        Else
            Console.WriteLine("@ Receive(Async) notice")
            _observer.Notice(_indata)
        End If
    End Sub

End Class
