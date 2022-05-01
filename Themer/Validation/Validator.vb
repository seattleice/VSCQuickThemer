Imports System.Text.RegularExpressions

Module Validator

    Public Function ValidateName(text As String) As Boolean

        If String.IsNullOrEmpty(text) Then Return False

        If (text.Length < 4) Or (text.Length > 40) Then Return False

        Return Regex.IsMatch(text, "^[a-zA-Z]([\w-]*[a-zA-Z])?$")

    End Function

    Public Function ValidateDisplayName(text As String) As Boolean

        If String.IsNullOrEmpty(text) Then Return False

        If (text.Length < 4) Or (text.Length > 40) Then Return False

        Return Regex.IsMatch(text, "^[a-zA-Z]([\w _-]*[a-zA-Z])?$")

    End Function

End Module
