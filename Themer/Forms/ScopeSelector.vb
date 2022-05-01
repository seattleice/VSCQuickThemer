Imports ThemeFunctions.Json
Imports ThemeFunctions.Sorting

Public Class ScopeSelector

    Public SelectedScope As String = String.Empty

    Private _defaultScopes As TokenScopes
    Private _scopesInUse As List(Of String)


    Public Sub New(scopesInUse As List(Of String), defaultScopes As TokenScopes)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _defaultScopes = defaultScopes
        _scopesInUse = scopesInUse

    End Sub

    Private Sub scopeSelector_Load(sender As Object, e As EventArgs) Handles Me.Load

        cmbLanguage.Items.AddRange(_defaultScopes.Languages.ToArray())

        cmbLanguage.SelectedIndex = 0

        cmbSyntax.Items.AddRange(_defaultScopes.Syntaxes.ToArray())

    End Sub

    Private Sub cmbSyntax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSyntax.SelectedIndexChanged

        cmbScope.Items.Clear()

        If (cmbSyntax.SelectedItem Is Nothing) Then Return

        Dim scope As SyntaxScope = cmbSyntax.SelectedItem

        Dim unusedScopes = scope.Scopes

        If (_scopesInUse IsNot Nothing) Then
            unusedScopes = scope.Scopes.Where(Function(s) _scopesInUse.All(Function(s2) s2 <> s)).Select(Function(sc) sc).ToList()
        End If

        cmbScope.Items.AddRange(unusedScopes.ToArray())

    End Sub

    Private Sub cmbScope_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbScope.SelectedIndexChanged
        btnOk.Enabled = cmbScope.SelectedItem IsNot Nothing
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        SelectedScope = cmbScope.Text & cmbLanguage.SelectedItem.Value
    End Sub

    Private Sub cmbScope_TextChanged(sender As Object, e As EventArgs) Handles cmbScope.TextChanged
        btnOk.Enabled = cmbScope.Text.Length > 0
    End Sub

End Class