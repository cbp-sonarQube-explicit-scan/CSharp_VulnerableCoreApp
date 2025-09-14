Public Class ExampleController
    Inherits Controller

    <HttpGet>
    Public Function GetUser(Id As String) As IActionResult
        Dim Url As String = "http://example.com/api/user/" & Id
        Dim Request As HttpWebRequest = CType(WebRequest.Create(Url), HttpWebRequest) ' Noncompliant

        Return Ok()
    End Function
End Class
