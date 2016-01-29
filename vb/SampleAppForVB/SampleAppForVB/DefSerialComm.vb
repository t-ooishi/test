Public Class DefSerialComm
    Private _port As DefSerialPort

    Const _header As String = "@"
    Const _id As String = "00"
    Const _writeFrameFlg As String = "#"
    Const _readFrameFlg As String = "$"
    Const _terminator As String = ("*" + Chr(13))

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

    Public Sub WriteCommand(
                           code As String,
                           value As Integer
                           )
        Dim sendData As String = CreateCommandData(code, value)


    End Sub

    ''' <summary>
    ''' 送信電文を生成する
    ''' </summary>
    ''' <param name="code"></param>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateCommandData(
                                      code As String,
                                      value As String
                                      ) As String
        Return String.Format("{0}{1}{2}{3}{4}{5:000000000}{6}",
                                           _header,
                                           _id,
                                           _writeFrameFlg,
                                           code,
                                           value,
                                           _terminator)

        Return Nothing
    End Function

End Class
