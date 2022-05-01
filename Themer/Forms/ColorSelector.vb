Imports System.Linq
Imports ThemeFunctions
Imports ThemeFunctions.Colors


Public Class ColorSelector

    Public Property SelectedHexColor As String
    Public Property HexColorPalette As List(Of String)

    Public Sub New(hexColors As List(Of String), selHexColor As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HexColorPalette = hexColors

        SelectedHexColor = selHexColor

        If (Not String.IsNullOrEmpty(SelectedHexColor)) Then
            lblCurrColor.BackColor = SelectedHexColor.ToArgbColor()
            colorPanel.Color = SelectedHexColor.ToArgbColor()
        End If

    End Sub

    Private _loading As Boolean = True

    Private Sub frm_Color_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetColors()

        _loading = False

    End Sub

    Private Sub SetColors()

        Dim max = Math.Min(42, HexColorPalette.Count)

        For i As Integer = 1 To max

            Dim rad = CType(Me.Controls("radColor" & i.ToString), RadioButton)

            rad.Visible = True

            rad.BackColor = HexColorPalette(i - 1).ToArgbColor()

            If (HexColorPalette(i - 1).Equals(SelectedHexColor)) Then
                rad.Checked = True
            End If

        Next

        For i As Integer = max + 1 To 42

            Dim rad = CType(Me.Controls("radColor" & i.ToString), Control)

        Next

    End Sub

    Private Sub radColor_CheckedChanged(sender As Object, e As EventArgs) Handles radColor1.Click, radColor2.Click, radColor3.Click, radColor4.Click, radColor5.Click, radColor6.Click, radColor7.Click, radColor8.Click, radColor9.Click, radColor10.Click, radColor11.Click, radColor12.Click, radColor13.Click, radColor14.Click, radColor15.Click, radColor16.Click, radColor17.Click, radColor18.Click, radColor19.Click, radColor20.Click, radColor21.Click, radColor22.Click, radColor23.Click, radColor24.Click, radColor25.Click, radColor26.Click, radColor27.Click, radColor28.Click, radColor29.Click, radColor30.Click, radColor31.Click, radColor32.Click, radColor33.Click, radColor34.Click, radColor35.Click, radColor36.Click, radColor37.Click, radColor38.Click, radColor39.Click, radColor40.Click

        If _loading Then Return

        If CType(sender, RadioButton).Checked Then
            colorPanel.Color = CType(sender, RadioButton).BackColor
        End If

    End Sub

    Private Sub SetSelectedColor()

        If (radNewColor.Checked) Then
            SelectedHexColor = colorPanel.Color.ToHexColorString()
        Else
            For i As Integer = 1 To 42

                Dim rad = CType(Me.Controls("radColor" & i.ToString), RadioButton)

                If (rad.Checked) Then
                    SelectedHexColor = rad.BackColor.ToHexColorString()
                    Exit For
                End If

            Next
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        SetSelectedColor()

        Me.DialogResult = DialogResult.OK

        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        SelectedHexColor = Nothing

        Me.DialogResult = DialogResult.OK

        Me.Close()

    End Sub
End Class