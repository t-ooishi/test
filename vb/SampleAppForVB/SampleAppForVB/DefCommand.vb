Public Class DefCommand
    Private _kind As Boolean
    Protected _header As String
    Protected _id As Integer
    Protected _flag As String
    Protected _code As String
    Protected _value As Integer
    Protected _terminator As String

    Const Write As Boolean = True
    Const Read As Boolean = False

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="header"></param>
    ''' <param name="id"></param>
    ''' <param name="flag"></param>
    ''' <param name="code"></param>
    ''' <param name="value"></param>
    ''' <param name="terminator"></param>
    ''' <remarks></remarks>
    Protected Sub New(
        header As String,
        id As Integer,
        flag As String,
        code As String,
        value As String,
        terminator As String)
        _kind = Write
        _header = header
        _id = id
        _flag = flag
        _code = code
        _value = value
        _terminator = terminator
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="header"></param>
    ''' <param name="id"></param>
    ''' <param name="flag"></param>
    ''' <param name="code"></param>
    ''' <param name="terminator"></param>
    ''' <remarks></remarks>
    Protected Sub New(
        header As String,
        id As Integer,
        flag As String,
        code As String,
        terminator As String)
        _kind = Read
        _header = header
        _id = id
        _flag = flag
        _code = code
        _value = Nothing
        _terminator = terminator
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function ToStringForWriteCommand() As String
        Return ""
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function ToStringForReadCommand() As String
        Return ""
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetValue(value As Integer)
        _value = value
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetValue() As Integer
        Return _value
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetKind() As Boolean
        Return _kind
    End Function

End Class
