Imports Newtonsoft.Json
Imports ThemeFunctions.Json
Imports ThemeFunctions.Sorting
Imports System.ComponentModel
Imports ThemeFunctions.Colors

Public Class MainFormNew

    Private ReadOnly _environmentColorFile = "editorColorsList.json"
    Private ReadOnly _tokenColorFile = "tokenScopeList.json"

    Private _editExisting As Boolean = False
    Private _existingFile As String = String.Empty

    Private _jsonTheme As ThemeFunctions.Json.ColorTheme

    Private _dsEnvironment As List(Of ThemeColor)
    Private _blEnvironment As BindingList(Of ThemeColor)

    Private _dsToken As List(Of EditorToken)
    Private _blToken As BindingList(Of EditorToken)

    Private _tokenTabShown As Boolean
    Private _templateFolder As String
    Private _blankTemplateFile As String = "new-blank-theme.json"

    Private _pkgDefExe As String

    Private _dflt_EditorColors As List(Of ThemeColor)
    Private _dflt_TokenScopes As TokenScopes

    Private _fontList As Object() = New Object() {DBNull.Value, "bold", "italic", "underline"}

    Private Sub btnSelectJsonTemplate_Click(sender As Object, e As EventArgs) Handles btnSelectJsonTemplate.Click

        If (dlgOpenJson.ShowDialog() = DialogResult.OK) Then

            Dim newTemplateFile As String = System.IO.Path.Combine(_templateFolder, System.IO.Path.GetFileName(dlgOpenJson.FileName) & "c")

            If (System.IO.File.Exists(newTemplateFile)) Then System.IO.File.Delete(newTemplateFile)

            System.IO.File.Copy(dlgOpenJson.FileName, newTemplateFile)

            FillTemplates()

        End If

    End Sub

    Private Sub MainFormNew_Load(sender As Object, e As EventArgs) Handles Me.Load

        FillTemplates()

        _pkgDefExe = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "ThemeConverter.exe")

        pnlToken.Visible = tabEdit.SelectedIndex = 1

        Dim colorFile As String = System.IO.Path.Combine(_templateFolder, _environmentColorFile)

        Dim Json = My.Computer.FileSystem.ReadAllText(colorFile)

        _dflt_EditorColors = JsonConvert.DeserializeObject(Of List(Of ThemeColor))(Json)


        Dim tokenFile As String = System.IO.Path.Combine(_templateFolder, _tokenColorFile)

        Json = My.Computer.FileSystem.ReadAllText(tokenFile)

        _dflt_TokenScopes = JsonConvert.DeserializeObject(Of TokenScopes)(Json)

    End Sub

    Private Sub FillTemplates()

        cmbTemplate.Items.Clear()
        cmbTemplate.Text = ""

        _templateFolder = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Templates")

        Dim files = System.IO.Directory.EnumerateFiles(_templateFolder, "*.jsonc").ToList()

        For Each file As String In files
            If System.IO.Path.GetFileName(file) <> _blankTemplateFile Then
                cmbTemplate.Items.Add(System.IO.Path.GetFileName(file))
            End If
        Next

        If (cmbTemplate.Items.Count > 0) Then cmbTemplate.SelectedIndex = 0

    End Sub

    Private Sub btnCreateFromTemplate_Click(sender As Object, e As EventArgs) Handles btnCreateFromTemplate.Click

        If (cmbTemplate.SelectedItem Is Nothing) Then Return

        If (dgvEnvironment.DataSource IsNot Nothing) Then
            If (MsgBoxResult.Yes <> MsgBox("There is a file currently open. Are you sure you wish to discard this file and open a new one?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo)) Then
                Return
            End If
        End If

        _editExisting = False
        _existingFile = String.Empty

        Dim jsonFile As String = CStr(cmbTemplate.SelectedItem)

        Dim templateFile As String = System.IO.Path.Combine(_templateFolder, jsonFile)

        Dim Json = My.Computer.FileSystem.ReadAllText(templateFile)

        Dim jsonTheme = JsonConvert.DeserializeObject(Of ColorTheme)(json)

        jsonTheme.SetTokenNullNames()

        Dim themeName As String = If(String.IsNullOrEmpty(jsonTheme.ThemeName), System.IO.Path.GetFileNameWithoutExtension(jsonFile), jsonTheme.ThemeName)

        txtThemeName.Text = themeName
        txtDisplayName.Text = themeName
        txtDescription.Text = $"Color Theme based on {themeName}"
        cmbThemeType.SelectedItem = jsonTheme.ThemeType
        txtVersion1.Text = "1"
        txtVersion2.Text = "00"
        txtVersion3.Text = "00"

        txtThemeName.Enabled = True
        txtDisplayName.Enabled = True
        txtDescription.Enabled = True
        cmbThemeType.Enabled = True
        txtVersion1.Enabled = True
        txtVersion2.Enabled = True
        txtVersion3.Enabled = True

        _tokenTabShown = False

        Me.Text = $"Visual Studio Code - Quick Theme Editor ( Template - {CStr(cmbTemplate.SelectedItem)} )"

        ParseTheme(jsonTheme)

    End Sub

    Private Sub btnEditExisting_Click(sender As Object, e As EventArgs) Handles btnEditExisting.Click

        If (dgvEnvironment.DataSource IsNot Nothing) Then
            If (MsgBoxResult.Yes <> MsgBox("There is a file currently open. Are you sure you wish to discard this file and open a new one?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo)) Then
                Return
            End If
        End If

        If (dlgOpenJson.ShowDialog() = DialogResult.OK) Then

            _editExisting = True
            _existingFile = dlgOpenJson.FileName

            Dim json = My.Computer.FileSystem.ReadAllText(_existingFile)

            Dim jsonTheme = JsonConvert.DeserializeObject(Of ColorTheme)(json)

            jsonTheme.SetTokenNullNames()

            Dim themeName As String = If(String.IsNullOrEmpty(jsonTheme.ThemeName), System.IO.Path.GetFileNameWithoutExtension(_existingFile), jsonTheme.ThemeName)

            txtThemeName.Text = themeName
            txtDisplayName.Text = themeName
            txtDescription.Text = "Edit Existing Theme In-Place"
            cmbThemeType.SelectedItem = If(String.IsNullOrEmpty(jsonTheme.ThemeType), "light", jsonTheme.ThemeType)
            txtVersion1.Text = "0"
            txtVersion2.Text = "00"
            txtVersion3.Text = "00"

            txtThemeName.Enabled = False
            txtDisplayName.Enabled = False
            txtDescription.Enabled = False
            cmbThemeType.Enabled = False
            txtVersion1.Enabled = False
            txtVersion2.Enabled = False
            txtVersion3.Enabled = False

            _tokenTabShown = False

            Me.Text = $"Visual Studio Code - Quick Theme Editor ( Existing Theme - {_existingFile} )"

            ParseTheme(jsonTheme)

        End If

    End Sub

    Private Sub ParseTheme(jsonTheme As ColorTheme)

        _jsonTheme = jsonTheme

        dgvEnvironment.DataSource = Nothing
        dgvEnvironment.Columns.Clear()
        dgvEnvironment.Rows.Clear()

        _dsEnvironment = _jsonTheme.EnvironmentColors
        _blEnvironment = New BindingList(Of ThemeColor)(_dsEnvironment)

        dgvEnvironment.DataSource = _blEnvironment

        dgvEnvironment.Columns("Name").DisplayIndex = 0
        dgvEnvironment.Columns("HexColor").DisplayIndex = 1
        dgvEnvironment.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "editColor", .DisplayIndex = 2, .HeaderText = "Color"})

        dgvEnvironment.Columns("Name").SortMode = DataGridViewColumnSortMode.Automatic
        dgvEnvironment.Columns("HexColor").SortMode = DataGridViewColumnSortMode.Automatic
        dgvEnvironment.Columns("editColor").SortMode = DataGridViewColumnSortMode.Automatic

        dgvEnvironment.Columns("Name").Width = 530
        dgvEnvironment.Columns("HexColor").Width = 100
        dgvEnvironment.Columns("editColor").Width = 100

        '-----------------------------------------------------------

        dgvToken.DataSource = Nothing
        dgvToken.Columns.Clear()
        dgvToken.Rows.Clear()

        dgvToken.AutoGenerateColumns = False

        _dsToken = _jsonTheme.TokenColors.Select(Function(x) New ThemeFunctions.Json.EditorToken() With
                                                                {.name = x.Name, .background = x.Settings.Background, .foreground = x.Settings.Foreground, .fontStyle = x.Settings.FontStyle, .scope = x.Scope}).ToList()
        _blToken = New BindingList(Of EditorToken)(_dsToken)


        dgvToken.Columns.Add(New DataGridViewTextBoxColumn() With {.DisplayIndex = 0, .Name = "Name", .DataPropertyName = "Name"})
        dgvToken.Columns.Add(New DataGridViewComboBoxColumn() With {.DisplayIndex = 1, .Name = "FontStyle", .HeaderText = "Font Style", .DataSource = _fontList, .DataPropertyName = "fontStyle"})
        dgvToken.Columns.Add(New DataGridViewTextBoxColumn() With {.DisplayIndex = 2, .Name = "Foreground", .DataPropertyName = "foreground"})
        dgvToken.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "editForeground", .DisplayIndex = 3, .HeaderText = "<"})
        dgvToken.Columns.Add(New DataGridViewTextBoxColumn() With {.DisplayIndex = 4, .Name = "Background", .DataPropertyName = "background"})
        dgvToken.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "editBackground", .DisplayIndex = 5, .HeaderText = "<"})

        dgvToken.Columns("Name").SortMode = DataGridViewColumnSortMode.Automatic
        dgvToken.Columns("Foreground").SortMode = DataGridViewColumnSortMode.Automatic
        dgvToken.Columns("Background").SortMode = DataGridViewColumnSortMode.Automatic

        dgvToken.Columns("Name").ReadOnly = True
        dgvToken.Columns("FontStyle").ReadOnly = False
        dgvToken.Columns("Foreground").ReadOnly = True
        dgvToken.Columns("editForeground").ReadOnly = True
        dgvToken.Columns("Background").ReadOnly = True
        dgvToken.Columns("editBackground").ReadOnly = True

        dgvToken.Columns("Name").Width = 330
        dgvToken.Columns("FontStyle").Width = 100
        dgvToken.Columns("Foreground").Width = 100
        dgvToken.Columns("editForeground").Width = 48
        dgvToken.Columns("Background").Width = 100
        dgvToken.Columns("editBackground").Width = 48

        dgvToken.DataSource = _blToken

    End Sub

    ' Store Properties for next sort  to see if it is a new column or we need to reverse current column
    Private _sortEnvAscending As Boolean = False
    Private _sortEnvName As String = String.Empty

    Private Sub dgvEnvironment_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvEnvironment.ColumnHeaderMouseClick

        If (_dsEnvironment Is Nothing) Then Return

        Dim colName As String = dgvEnvironment.Columns(e.ColumnIndex).Name

        Dim colType As ThemeColorSortTypeEnum

        Select Case colName.ToLower
            Case "name"
                colType = ThemeColorSortTypeEnum.byName
            Case "hexcolor"
                colType = ThemeColorSortTypeEnum.byHexColorString
            Case "editcolor"
                colType = ThemeColorSortTypeEnum.byHexColorRGB
            Case Else
                Return
        End Select

        _sortEnvAscending = If(_sortEnvName = colName, Not _sortEnvAscending, True)

        _sortEnvName = colName

        _dsEnvironment.Sort(New ThemeColorSortComparer(_sortEnvAscending, colType))

        For Each col In dgvEnvironment.Columns
            col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        _blEnvironment.ResetBindings()

        dgvEnvironment.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = If(_sortEnvAscending, SortOrder.Ascending, SortOrder.Descending)

    End Sub

    ' Store Properties for next sort  to see if it is a new column or we need to reverse current column
    Private _sortEditAscending As Boolean = False
    Private _sortEditType As EditorTokenSortTypeEnum

    Private Sub dgvToken_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvToken.ColumnHeaderMouseClick

        If (_dsToken Is Nothing) Then Return

        Dim colName As String = dgvToken.Columns(e.ColumnIndex).Name

        Dim sortType As EditorTokenSortTypeEnum

        Select Case colName.ToLower()
            Case "name"
                sortType = EditorTokenSortTypeEnum.byName
            Case "foreground"
                sortType = EditorTokenSortTypeEnum.byforegroundHexColorString
            Case "editforeground"
                sortType = EditorTokenSortTypeEnum.byforegroundHexColorRGB
            Case "background"
                sortType = EditorTokenSortTypeEnum.bybackgroundHexColorString
            Case "editbackground"
                sortType = EditorTokenSortTypeEnum.bybackgroundHexColorRGB
            Case Else
                Return
        End Select

        _sortEditAscending = If(_sortEditType = sortType, Not _sortEditAscending, True)

        _sortEditType = sortType

        _dsToken.Sort(New EditorTokenSortComparer(_sortEditAscending, _sortEditType))

        For Each col In dgvToken.Columns
            col.HeaderCell.SortGlyphDirection = SortOrder.None
        Next

        _blToken.ResetBindings()

        dgvToken.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = If(_sortEditAscending, SortOrder.Ascending, SortOrder.Descending)

    End Sub

    Private Sub tabEdit_TabIndexChanged(sender As Object, e As EventArgs) Handles tabEdit.SelectedIndexChanged

        If (tabEdit.SelectedIndex = 1) Then
            If Not _tokenTabShown Then
                _tokenTabShown = True
                For Each row In dgvToken.Rows
                    row.Cells("editForeground").Style.BackColor = CStr(row.Cells("Foreground").Value).ToArgbColor(True)
                    row.Cells("editBackground").Style.BackColor = CStr(row.Cells("Background").Value).ToArgbColor(True)
                Next
                dgvToken.Refresh()
            End If
        End If

        pnlToken.Visible = tabEdit.SelectedIndex = 1
        pnlColor.Visible = tabEdit.SelectedIndex = 0
        btnEditBackground.Visible = tabEdit.SelectedIndex = 1
        btnEditForeground.Visible = tabEdit.SelectedIndex = 1
        btnEditEnvironmentColor.Visible = tabEdit.SelectedIndex = 0
    End Sub

    Private Sub txtThemeName_TextChanged(sender As Object, e As EventArgs) Handles txtThemeName.TextChanged

        Dim valid = Validator.ValidateName(txtThemeName.Text)

        lblValidName.Tag = valid
        lblValidName.Visible = Not valid

    End Sub

    Private Sub txtDisplayName_TextChanged(sender As Object, e As EventArgs) Handles txtDisplayName.TextChanged

        Dim valid = Validator.ValidateDisplayName(txtDisplayName.Text)

        lblValidDisplayName.Tag = valid
        lblValidDisplayName.Visible = Not valid

    End Sub

    Private Sub txtPublisher_TextChanged(sender As Object, e As EventArgs) Handles txtPublisher.TextChanged

        Dim valid = Validator.ValidateDisplayName(txtDisplayName.Text)

        lblValidPublisher.Tag = valid
        lblValidPublisher.Visible = Not valid

    End Sub

    Private Sub btnOpenTemplatesFolder_Click(sender As Object, e As EventArgs) Handles btnOpenTemplatesFolder.Click
        System.Diagnostics.Process.Start("explorer.exe", _templateFolder)
    End Sub

    Private Sub dgvToken_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvToken.DataError
        Dim f = e.Context
    End Sub

    Private _currToken As EditorToken = Nothing

    Private Sub dgvToken_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvToken.RowEnter

        If (_dsToken Is Nothing) Then Return

        _currToken = CType(dgvToken.Rows(e.RowIndex).DataBoundItem, EditorToken)

        lblScopes.Text = $"Scopes for {_currToken.name} <--"

        lstScopes.Items.Clear()

        If (_currToken.scope IsNot Nothing) Then lstScopes.Items.AddRange(_currToken.scope.ToArray())

    End Sub

    Private Sub btnEditForeground_Click(sender As Object, e As EventArgs) Handles btnEditForeground.Click

        If (_dsToken Is Nothing) Then Return

        Dim firstRow = dgvToken.SelectedCells.OfType(Of DataGridViewCell).Select(Function(c) c.RowIndex).Min
        Dim lastRow = dgvToken.SelectedCells.OfType(Of DataGridViewCell).Select(Function(c) c.RowIndex).Max

        EditTokenColor(firstRow, lastRow, True)

    End Sub

    Private Sub btnEditBackground_Click(sender As Object, e As EventArgs) Handles btnEditBackground.Click

        If (_dsToken Is Nothing) Then Return

        Dim firstRow = dgvToken.SelectedCells.OfType(Of DataGridViewCell).Select(Function(c) c.RowIndex).Min
        Dim lastRow = dgvToken.SelectedCells.OfType(Of DataGridViewCell).Select(Function(c) c.RowIndex).Max

        EditTokenColor(firstRow, lastRow, False)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If (_dsEnvironment Is Nothing) Then Return

        ' If editing existing, we are simply getting properties back and overwriting theme file
        If (_editExisting) Then

            _jsonTheme = GetTheme()

            If (System.IO.File.Exists(_existingFile)) Then System.IO.File.Delete(_existingFile)

            Dim themeString = JsonConvert.SerializeObject(_jsonTheme, Formatting.Indented, New JsonSerializerSettings() With {.NullValueHandling = NullValueHandling.Ignore})

            My.Computer.FileSystem.WriteAllText(_existingFile, themeString, False, System.Text.Encoding.UTF8)

            If (Not System.IO.File.Exists(_existingFile)) Then

                MsgBox("Error Saving Theme", MsgBoxStyle.Critical)

            End If

        Else

            _jsonTheme = GetTheme()

            Dim package As New ColorPackage() With
            {
                .name = txtThemeName.Text,
                .publisher = txtPublisher.Text,
                .displayName = txtDisplayName.Text,
                .version = New Version(txtVersion1.Text, txtVersion2.Text, txtVersion3.Text)
            }

            package.contributes.themes.Add(New TitleTheme() With {.label = txtThemeName.Text, .uiTheme = "vsctheme", .path = $"./themes/{txtThemeName.Text}.json"})

            dlgThemeFolder.RootFolder = Environment.SpecialFolder.UserProfile
            dlgThemeFolder.SelectedPath = System.IO.Path.Combine(System.Environment.GetEnvironmentVariable("USERPROFILE"), ".vscode")

            If dlgThemeFolder.ShowDialog <> DialogResult.OK Then Return

            Dim newFolder As String = System.IO.Path.Combine(dlgThemeFolder.SelectedPath, txtPublisher.Text & "-VSC-" & txtThemeName.Text & "\")

            Dim pkgFile As String = System.IO.Path.Combine(newFolder, "package.json")
            Dim themeFolder As String = System.IO.Path.Combine(newFolder, "themes\")
            Dim themeFile As String = System.IO.Path.Combine(themeFolder, txtThemeName.Text & ".json")

            If (Not System.IO.Directory.Exists(newFolder)) Then System.IO.Directory.CreateDirectory(newFolder)
            If (Not System.IO.Directory.Exists(themeFolder)) Then System.IO.Directory.CreateDirectory(themeFolder)

            If (System.IO.File.Exists(pkgFile)) Then System.IO.File.Delete(pkgFile)
            If (System.IO.File.Exists(themeFile)) Then System.IO.File.Delete(themeFile)

            'PKG.Theme = _themeProps.GetJsonTheme()

            Dim pkgString = JsonConvert.SerializeObject(package, Formatting.Indented, New JsonSerializerSettings() With {.NullValueHandling = NullValueHandling.Ignore})

            My.Computer.FileSystem.WriteAllText(pkgFile, pkgString, False, System.Text.Encoding.UTF8)

            Dim themeString = JsonConvert.SerializeObject(_jsonTheme, Formatting.Indented, New JsonSerializerSettings() With {.NullValueHandling = NullValueHandling.Ignore})

            My.Computer.FileSystem.WriteAllText(themeFile, themeString, False, System.Text.Encoding.UTF8)

            If (System.IO.File.Exists(themeFile)) Then

                MsgBox("Theme Saved")

                _editExisting = True
                _existingFile = themeFile

                Me.Text = $"Visual Studio Code - Quick Theme Editor ( Existing Theme - {_existingFile} )"

            End If

        End If

    End Sub

    Private Function GetTheme() As ColorTheme

        Dim newTheme As New ColorTheme()

        newTheme.ThemeName = txtThemeName.Text

        newTheme.EnvironmentColors = (From f In _dsEnvironment Select f).ToList()

        newTheme.TokenColors = (
                From t In _dsToken
                Select New TokenColor With
                    {
                    .Name = t.name,
                    .Scope = t.scope,
                    .Settings = New TokenSettings With
                        {
                            .Foreground = If(String.IsNullOrEmpty(t.foreground), Nothing, t.foreground),
                            .Background = If(String.IsNullOrEmpty(t.background), Nothing, t.background),
                            .FontStyle = If(String.IsNullOrEmpty(t.fontStyle), Nothing, t.fontStyle)
                        }
                    }).ToList()

        Return newTheme

    End Function

    Private Sub btnAddToken_Click(sender As Object, e As EventArgs) Handles btnAddToken.Click

        If (_dsToken Is Nothing) Then Return

        Dim pnt As Point = btnAddToken.PointToScreen(New Point(0, btnAddToken.Height + 1))

        Dim newToken As String = InputBox("Enter new Token Name", "", "", pnt.X, pnt.Y)

        If (newToken.Length > 0) Then

            Dim existingRow = FindTokenRow(newToken)

            If (existingRow <> -1) Then

                MsgBox("That token already exists", MsgBoxStyle.Exclamation)

                dgvToken.FirstDisplayedScrollingRowIndex = existingRow

            Else

                _dsToken.Add(New EditorToken() With {.name = newToken})

                _blToken.ResetBindings()

                Dim index = FindTokenRow(newToken)

                If (index > -1) Then
                    dgvToken.CurrentCell = dgvToken.Rows(index).Cells("name")
                    dgvToken.FirstDisplayedScrollingRowIndex = index
                End If

            End If

        End If

    End Sub

    Private Function FindTokenRow(tokenName As String) As Integer

        For i As Integer = 0 To dgvToken.Rows.Count - 1

            Dim rowItem = CType(dgvToken.Rows(i).DataBoundItem, EditorToken)

            If (rowItem.name = tokenName) Then
                Return i
            End If

        Next

        Return -1

    End Function

    Private Function FindScopeRow(scope As String, startrow As Integer) As Integer

        For i As Integer = startrow To dgvToken.Rows.Count - 1

            Dim rowItem = CType(dgvToken.Rows(i).DataBoundItem, EditorToken)

            If (Not rowItem.scope Is Nothing) Then

                For Each sc In rowItem.scope

                    If (HasMatch(sc, scope)) Then Return i

                Next

            End If

        Next

        Return -1

    End Function

    Private Sub btnFindScope_Click(sender As Object, e As EventArgs) Handles btnFindScope.Click

        If (_dsToken Is Nothing) Then Return

        Dim startRow As Integer = dgvToken.CurrentCell.RowIndex

        Dim existingRow = FindScopeRow(txtFindScope.Text, startRow + 1)

        If ((existingRow = -1) AndAlso (startRow > 0)) Then

            startRow = 0

            existingRow = FindScopeRow(txtFindScope.Text, startRow)

        End If

        If (existingRow > -1) Then
            dgvToken.CurrentCell = dgvToken.Rows(existingRow).Cells("name")
            dgvToken.FirstDisplayedScrollingRowIndex = existingRow
        End If

    End Sub

    Private Sub btnDeleteScope_Click(sender As Object, e As EventArgs) Handles btnDeleteScope.Click
        If (_currToken IsNot Nothing) And (lstScopes.SelectedItem IsNot Nothing) Then
            _currToken.scope.Remove(lstScopes.SelectedItem)
            lstScopes.Items.Remove(lstScopes.SelectedItem)
        End If
    End Sub

    'Private Sub btnAddScope_Click(sender As Object, e As EventArgs) Handles btnAddScope.Click

    '    If (_currToken Is Nothing) Then Return
    '    If (_dsToken Is Nothing) Then Return

    '    Dim pt As New Point(btnAddScope.PointToScreen(New Point(btnAddScope.Width + 30, -100)))

    '    Dim newScope As String = InputBox("Enter New Scope", XPos:=pt.X, YPos:=pt.Y)

    '    If (newScope.Length = 0) Then Return

    '    Dim existingRow = FindScopeRow(newScope, 0)

    '    If (existingRow <> -1) Then

    '        Dim rowItem = CType(dgvToken.Rows(existingRow).DataBoundItem, EditorToken)

    '        MsgBox($"That scope already exists under Token '{rowItem.name}'", MsgBoxStyle.Exclamation)

    '    Else

    '        If (_currToken.scope Is Nothing) Then _currToken.scope = New List(Of String)()

    '        _currToken.scope.Add(newScope)

    '        lstScopes.Items.Clear()

    '        lstScopes.Items.AddRange(_currToken.scope.ToArray())

    '        lstScopes.SelectedItem = newScope

    '    End If

    'End Sub

    Private Sub btnAddScope_Click(sender As Object, e As EventArgs) Handles btnAddScope.Click

        If (_currToken Is Nothing) Then Return
        If (_dsToken Is Nothing) Then Return

        Dim scopes As New List(Of String)

        For Each tk In _dsToken
            scopes.Concat(tk.scope)
        Next

        Dim frmScope As New ScopeSelector(scopes, _dflt_TokenScopes)

        If (frmScope.ShowDialog() <> DialogResult.OK) Then Return

        Dim newScope As String = frmScope.SelectedScope

        Dim existingRow = FindScopeRow(newScope, 0)

        If (existingRow <> -1) Then

            Dim rowItem = CType(dgvToken.Rows(existingRow).DataBoundItem, EditorToken)

            MsgBox($"That scope already exists under Token '{rowItem.name}'", MsgBoxStyle.Exclamation)

        Else

            If (_currToken.scope Is Nothing) Then _currToken.scope = New List(Of String)()

            _currToken.scope.Add(newScope)

            lstScopes.Items.Clear()

            lstScopes.Items.AddRange(_currToken.scope.ToArray())

            lstScopes.SelectedItem = newScope

        End If

    End Sub

    Private Function HasMatch(stringToSearch As String, stringToFind As String) As Boolean

        Dim pattern = $"^{stringToFind.Replace("*", ".*?")}$"

        Return System.Text.RegularExpressions.Regex.IsMatch(stringToSearch, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase)

    End Function


    Private Sub btnDeleteToken_Click(sender As Object, e As EventArgs) Handles btnDeleteToken.Click

        If (_dsToken Is Nothing) Then Return

        If (_currToken IsNot Nothing) Then

            _dsToken.Remove(_currToken)

            _currToken = Nothing

            _blToken.ResetBindings()

        End If

    End Sub

    Private Sub btnFindColor_Click(sender As Object, e As EventArgs) Handles btnFindColor.Click

        If (_dsEnvironment Is Nothing) Then Return

        Dim existingRow = FindColorRow(txtFindColor.Text)

        If (existingRow <> -1) Then
            dgvEnvironment.CurrentCell = dgvEnvironment.Rows(existingRow).Cells("name")
            dgvEnvironment.FirstDisplayedScrollingRowIndex = existingRow
        End If

    End Sub

    Private Function FindColorRow(propName As String) As Integer

        For i As Integer = 0 To dgvEnvironment.Rows.Count - 1

            Dim rowItem = CType(dgvEnvironment.Rows(i).DataBoundItem, ThemeColor)

            If (rowItem.Name = propName) Then
                Return i
            End If

        Next

        Return -1

    End Function

    Private Sub btnDeleteEditorColor_Click(sender As Object, e As EventArgs) Handles btnDeleteEditorColor.Click

        If (_dsEnvironment Is Nothing) Then Return

        Dim rowItem = CType(dgvEnvironment.Rows(dgvEnvironment.CurrentCell.RowIndex).DataBoundItem, ThemeColor)

        _dsEnvironment.Remove(rowItem)

        _blEnvironment.ResetBindings()

    End Sub

    Private Sub dgvEnvironment_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvEnvironment.CellFormatting

        If (dgvEnvironment.Columns(e.ColumnIndex).Name = "editColor") Then

            Dim rowItem = CType(dgvEnvironment.Rows(e.RowIndex).DataBoundItem, ThemeColor)

            e.CellStyle.BackColor = rowItem.HexColor.ToArgbColor(True)

        End If

    End Sub

    Private Sub dgvToken_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvToken.CellFormatting

        If (dgvToken.Columns(e.ColumnIndex).Name = "editForeground") Then

            Dim rowItem = CType(dgvToken.Rows(e.RowIndex).DataBoundItem, EditorToken)

            e.CellStyle.BackColor = rowItem.foreground.ToArgbColor(True)

        ElseIf (dgvToken.Columns(e.ColumnIndex).Name = "editBackground") Then

            Dim rowItem = CType(dgvToken.Rows(e.RowIndex).DataBoundItem, EditorToken)

            e.CellStyle.BackColor = rowItem.background.ToArgbColor(True)

        End If

    End Sub

    Private Sub btnAddEditorColor_Click(sender As Object, e As EventArgs) Handles btnAddEditorColor.Click

        If (_dsEnvironment Is Nothing) Then Return

        'First get list of unused properties
        Dim unusedList = _dflt_EditorColors.Where(Function(c) _dsEnvironment.All(Function(c2) c2.Name <> c.Name)).Select(Function(p) p.Name).ToList()

        Dim newPalette = _dsEnvironment.Where(Function(c) Not String.IsNullOrEmpty(c.HexColor)).Select(Function(c) c.HexColor.FormatHexColor(True)).Distinct().ToList()

        Dim frmSelEditor As New ThemeColorSelector(unusedList, newPalette)

        If (frmSelEditor.ShowDialog() = DialogResult.OK) Then

            _dsEnvironment.Add(New ThemeColor() With {.Name = frmSelEditor.SelectedThemeColor.Name, .HexColor = frmSelEditor.SelectedThemeColor.HexColor})

            _blEnvironment.ResetBindings()

        End If

    End Sub

    Private Sub dgvEnvironment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnvironment.CellDoubleClick

        If (_dsEnvironment Is Nothing) Then Return

        If (e.RowIndex < 0) Then Return

        If (dgvEnvironment.Columns(e.ColumnIndex).Name = "Name") Then

            Dim rowItem = CType(dgvEnvironment.Rows(e.RowIndex).DataBoundItem, ThemeColor)

            Dim rect = dgvEnvironment.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)

            Dim pnt As Point = dgvEnvironment.PointToScreen(New Point(rect.X, rect.Y))

            Dim newScope As String = InputBox("Enter New Name", "Edit Name", rowItem.Name, pnt.X, pnt.Y - 100)

            If ((newScope.Length = 0) OrElse (rowItem.Name = newScope)) Then Return

            rowItem.Name = newScope

            _blEnvironment.ResetBindings()

        ElseIf (dgvEnvironment.Columns(e.ColumnIndex).Name = "HexColor") Or (dgvEnvironment.Columns(e.ColumnIndex).Name = "editColor") Then

            EditEnvironmentColor(e.RowIndex, e.RowIndex)

        End If

    End Sub

    Private Sub btnEditEnvironmentColor_Click(sender As Object, e As EventArgs) Handles btnEditEnvironmentColor.Click

        If (_dsEnvironment Is Nothing) Then Return

        Dim firstRow = dgvEnvironment.SelectedCells.OfType(Of DataGridViewCell).Select(Function(c) c.RowIndex).Min
        Dim lastRow = dgvEnvironment.SelectedCells.OfType(Of DataGridViewCell).Select(Function(c) c.RowIndex).Max

        EditEnvironmentColor(firstRow, lastRow)

    End Sub

    Private Sub EditEnvironmentColor(startRowIndex As Integer, endRowIndex As Integer)

        Dim newPalette = _dsEnvironment.Where(Function(c) Not String.IsNullOrEmpty(c.HexColor)).Select(Function(c) c.HexColor.FormatHexColor(True)).Distinct().ToList()

        newPalette.Sort(New HexColorDifferenceComparer())

        Dim firstRowItem = CType(dgvEnvironment.Rows(startRowIndex).DataBoundItem, ThemeColor)

        Dim origColor As String = firstRowItem.HexColor

        Dim frmColor As New ColorSelector(newPalette, If(String.IsNullOrEmpty(origColor), Nothing, origColor.FormatHexColor()))

        Dim rslt = frmColor.ShowDialog()

        If (rslt = DialogResult.OK) Then

            Dim newColor = frmColor.SelectedHexColor

            For i As Integer = startRowIndex To endRowIndex

                Dim rowItem = CType(dgvEnvironment.Rows(i).DataBoundItem, ThemeColor)

                rowItem.HexColor = newColor

                dgvEnvironment.Rows(i).Cells("editColor").Style.BackColor = newColor.ToArgbColor(True)

            Next

        End If

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        mnuSettings.Show(btnSettings, New Point(0, btnSettings.Height))
    End Sub

    Private Sub DefaultEnvironmentPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultEnvironmentPropertiesToolStripMenuItem.Click
        Dim colorFile As String = System.IO.Path.Combine(_templateFolder, _environmentColorFile)
        System.Diagnostics.Process.Start("notepad.exe", colorFile)
    End Sub

    Private Sub DefaultEditorScopesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultEditorScopesToolStripMenuItem.Click
        Dim tokenFile As String = System.IO.Path.Combine(_templateFolder, _tokenColorFile)
        System.Diagnostics.Process.Start("notepad.exe", tokenFile)
    End Sub

    Private Sub dgvToken_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvToken.CellDoubleClick

        If (_dsToken Is Nothing) Then Return

        If (e.RowIndex < 0) Then Return

        If (dgvToken.Columns(e.ColumnIndex).Name = "Name") Then

            Dim rowItem = CType(dgvToken.Rows(e.RowIndex).DataBoundItem, EditorToken)

            Dim rect = dgvEnvironment.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)

            Dim pnt As Point = dgvEnvironment.PointToScreen(New Point(rect.X, rect.Y))

            Dim newName As String = InputBox("Enter New Name", "Edit Name", rowItem.name, pnt.X, pnt.Y - 100)

            If ((newName.Length = 0) OrElse (rowItem.name = newName)) Then Return

            rowItem.name = newName

            _blToken.ResetBindings()

        ElseIf (dgvToken.Columns(e.ColumnIndex).Name = "Foreground") Or (dgvToken.Columns(e.ColumnIndex).Name = "editForeground") Then

            EditTokenColor(e.RowIndex, e.RowIndex, True)

        ElseIf (dgvToken.Columns(e.ColumnIndex).Name = "Background") Or (dgvToken.Columns(e.ColumnIndex).Name = "editBackground") Then

            EditTokenColor(e.RowIndex, e.RowIndex, False)

        End If

    End Sub

    Private Sub EditTokenColor(startRowIndex As Integer, endRowIndex As Integer, isForeground As Boolean)

        Dim newPalette

        If (isForeground) Then
            newPalette = _dsToken.Where(Function(c) Not String.IsNullOrEmpty(c.foreground)).Select(Function(c) c.foreground.FormatHexColor(True)).Distinct().ToList()
        Else
            newPalette = _dsToken.Where(Function(c) Not String.IsNullOrEmpty(c.background)).Select(Function(c) c.background.FormatHexColor(True)).Distinct().ToList()
        End If

        newPalette.Sort(New HexColorDifferenceComparer())

        Dim firstRowItem = CType(dgvToken.Rows(startRowIndex).DataBoundItem, EditorToken)

        Dim origColor As String = If(isForeground, firstRowItem.foreground, firstRowItem.background)

        Dim frmColor As New ColorSelector(newPalette, If(String.IsNullOrEmpty(origColor), Nothing, origColor.FormatHexColor()))

        Dim rslt = frmColor.ShowDialog()

        If (rslt = DialogResult.OK) Then

            Dim newColor = frmColor.SelectedHexColor

            For i As Integer = startRowIndex To endRowIndex

                Dim rowItem = CType(dgvToken.Rows(i).DataBoundItem, EditorToken)

                If isForeground Then
                    rowItem.foreground = newColor
                    dgvToken.Rows(i).Cells("editForeground").Style.BackColor = newColor.ToArgbColor(True)
                Else
                    rowItem.background = newColor
                    dgvToken.Rows(i).Cells("editBackground").Style.BackColor = newColor.ToArgbColor(True)
                End If

            Next

        End If

    End Sub

    Private Sub btnPkgDef_Click(sender As Object, e As EventArgs) Handles btnPkgDef.Click


        _jsonTheme = GetTheme()

        dlgThemeFolder.RootFolder = Environment.SpecialFolder.UserProfile
        dlgThemeFolder.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        If dlgThemeFolder.ShowDialog <> DialogResult.OK Then Return

        Dim jsonFile As String = System.IO.Path.Combine(dlgThemeFolder.SelectedPath, $"{_jsonTheme.ThemeName}.json")

        If (System.IO.File.Exists(jsonFile)) Then System.IO.File.Delete(jsonFile)

        Dim themeString = JsonConvert.SerializeObject(_jsonTheme, Formatting.Indented, New JsonSerializerSettings() With {.NullValueHandling = NullValueHandling.Ignore})

        My.Computer.FileSystem.WriteAllText(jsonFile, themeString, False, System.Text.Encoding.UTF8)

        If (System.IO.File.Exists(jsonFile)) Then

            System.Diagnostics.Process.Start(_pkgDefExe, $" -i {jsonFile} -o {dlgThemeFolder.SelectedPath}")

            Dim path As String = System.IO.Path.Combine(dlgThemeFolder.SelectedPath, $"{_jsonTheme.ThemeName}.pkgdef")

            System.Diagnostics.Process.Start("explorer.exe", $"/select ""{path}""")

        End If

    End Sub

End Class

