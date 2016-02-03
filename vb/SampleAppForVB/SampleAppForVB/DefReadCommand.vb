Public Class DefReadCommand : Inherits DefCommand

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="header"></param>
    ''' <param name="id"></param>
    ''' <param name="flag"></param>
    ''' <param name="code"></param>
    ''' <param name="terminator"></param>
    ''' <remarks></remarks>
    Public Sub New(
        header As String,
        id As Integer,
        flag As String,
        code As String,
        terminator As String)
        MyBase.New(header, id, flag, code, terminator)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return ToStringForReadCommand()
    End Function

End Class
