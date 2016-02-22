Public Class DefSerialComm
    Private _port As DefSerialPort

    ''' <summary>
    ''' インスタンス生成
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' 初期化
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Initialize()
        _port = New DefSerialPort()
        _port.Initialize()
    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Terminate()
        _port.Terminate()
        _port = Nothing
    End Sub

    ''' <summary>
    ''' 書込みコマンド
    ''' </summary>
    ''' <param name="command"></param>
    ''' <remarks></remarks>
    Public Function WriteCommand(command As DefCommand) As Boolean
        _port.Send(command.ToString)
        Return True
    End Function

    Public Function ReadCommand(command As DefCommand, ByRef value As Integer) As Boolean
        _port.Send(command.ToString)
        Received()
        Return True
    End Function

    Protected Function Received() As String
        Dim result As String
        Dim work As String

        work = _port.Receive()



        Return result
    End Function


End Class
