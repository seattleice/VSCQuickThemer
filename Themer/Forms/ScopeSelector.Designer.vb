<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScopeSelector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSyntax = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbScope = New System.Windows.Forms.ComboBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbLanguage
        '
        Me.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLanguage.FormattingEnabled = True
        Me.cmbLanguage.Location = New System.Drawing.Point(112, 28)
        Me.cmbLanguage.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Size = New System.Drawing.Size(145, 31)
        Me.cmbLanguage.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Language"
        '
        'cmbSyntax
        '
        Me.cmbSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSyntax.FormattingEnabled = True
        Me.cmbSyntax.Location = New System.Drawing.Point(112, 103)
        Me.cmbSyntax.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbSyntax.Name = "cmbSyntax"
        Me.cmbSyntax.Size = New System.Drawing.Size(145, 31)
        Me.cmbSyntax.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Scope:"
        '
        'cmbScope
        '
        Me.cmbScope.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbScope.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbScope.FormattingEnabled = True
        Me.cmbScope.Location = New System.Drawing.Point(276, 103)
        Me.cmbScope.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmbScope.Name = "cmbScope"
        Me.cmbScope.Size = New System.Drawing.Size(445, 31)
        Me.cmbScope.TabIndex = 4
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Enabled = False
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOk.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOk.Location = New System.Drawing.Point(511, 246)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(91, 31)
        Me.btnOk.TabIndex = 44
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Location = New System.Drawing.Point(617, 246)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 31)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ScopeSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cmbScope)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSyntax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "ScopeSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "scopeSelector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbLanguage As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSyntax As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbScope As ComboBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
