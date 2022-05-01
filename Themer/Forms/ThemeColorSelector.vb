Imports ThemeFunctions.Json
Imports ThemeFunctions.Colors


Public Class ThemeColorSelector

    Public SelectedThemeColor As ThemeColor
    Private _unusedEditorProps As List(Of String)
    Private _hexColorPalette As List(Of String)

    Public Sub New(unusedEditorProps As List(Of String), hexColorPalette As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        _unusedEditorProps = unusedEditorProps
        _hexColorPalette = hexColorPalette

    End Sub

    Private Sub scopeSelector_Load(sender As Object, e As EventArgs) Handles Me.Load

        cmbThemeColor.Items.AddRange(_unusedEditorProps.ToArray())

        cmbThemeColor.SelectedIndex = 0

    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        SelectedThemeColor = New ThemeColor() With {.Name = cmbThemeColor.SelectedItem, .HexColor = txtHexColor.Text}

        Me.DialogResult = DialogResult.OK

        Me.Close()

    End Sub

    Private Sub cmbThemeColor_TextChanged(sender As Object, e As EventArgs) Handles cmbThemeColor.TextChanged
        btnOk.Enabled = cmbThemeColor.SelectedItem IsNot Nothing
    End Sub

    Private Sub txtHexColor_TextChanged(sender As Object, e As EventArgs) Handles txtHexColor.TextChanged
        btnOk.Enabled = txtHexColor.Text.Length > 0 And cmbThemeColor.SelectedItem IsNot Nothing
    End Sub

    Private Sub cmbThemeColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemeColor.SelectedIndexChanged
        btnOk.Enabled = txtHexColor.Text.Length > 0 And cmbThemeColor.SelectedItem IsNot Nothing
    End Sub

    Private Sub txtHexColor_Click(sender As Object, e As EventArgs) Handles txtHexColor.Click
        SetColor()
    End Sub

    Private Sub lblColor_Click(sender As Object, e As EventArgs) Handles lblColor.Click
        SetColor()
    End Sub

    Private Sub SetColor()

        Dim frmColor As New ColorSelector(_hexColorPalette, If(txtHexColor.Text.Length = 0, Nothing, lblColor.BackColor.ToHexColorString()))

        Dim rslt = frmColor.ShowDialog()

        If (rslt = DialogResult.OK) Then

            Dim newColor = frmColor.SelectedHexColor

            txtHexColor.Text = newColor

            lblColor.BackColor = newColor.ToArgbColor()

        End If

    End Sub


End Class