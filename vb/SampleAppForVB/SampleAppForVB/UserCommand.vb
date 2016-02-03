Public Class UserCommand
    Private _command As DefCommand
    Private _mode As Integer
    Private _section As String
    Private _item As String
    Private _max As Integer
    Private _min As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="mode"></param>
    ''' <param name="section"></param>
    ''' <param name="item"></param>
    ''' <param name="max"></param>
    ''' <param name="min"></param>
    ''' <param name="command"></param>
    ''' <remarks></remarks>
    Public Sub New(
                  mode As Integer,
                  section As String,
                  item As String,
                  max As Integer,
                  min As Integer,
                  command As DefCommand)
        _mode = mode
        _section = section
        _item = item
        _max = max
        _min = min
        _command = command
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetValue(value As Integer)
        _command.SetValue(value)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetValue(value As String)
        _command.SetValue(Integer.Parse(value))
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SetValueWithCheck(value As Integer) As Boolean
        Dim res As Boolean = False

        If _min <= value And value <= _max Then
            _command.SetValue(value)
            res = True
        End If

        Return res
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SetValueWithCheck(value As String) As Boolean
        Dim v As Integer = Integer.Parse(value)
        Return SetValueWithCheck(v)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetValue() As Integer
        Return _command.GetValue()
    End Function

End Class
