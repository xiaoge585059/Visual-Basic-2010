<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkPromptOnExit = New System.Windows.Forms.CheckBox()
        Me.grpDefaultBackcolor = New System.Windows.Forms.GroupBox()
        Me.optBackgrounWhite = New System.Windows.Forms.RadioButton()
        Me.optBackgroundDefault = New System.Windows.Forms.RadioButton()
        Me.tabOptions = New System.Windows.Forms.TabControl()
        Me.pgeGeneral = New System.Windows.Forms.TabPage()
        Me.pgeAppearance = New System.Windows.Forms.TabPage()
        Me.grpDefaultBackcolor.SuspendLayout()
        Me.tabOptions.SuspendLayout()
        Me.pgeGeneral.SuspendLayout()
        Me.pgeAppearance.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(160, 207)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(103, 42)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(6, 9)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(125, 25)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "User Name: "
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(137, 6)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(209, 32)
        Me.txtUserName.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(269, 207)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 42)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkPromptOnExit
        '
        Me.chkPromptOnExit.AutoSize = True
        Me.chkPromptOnExit.Location = New System.Drawing.Point(11, 44)
        Me.chkPromptOnExit.Name = "chkPromptOnExit"
        Me.chkPromptOnExit.Size = New System.Drawing.Size(270, 29)
        Me.chkPromptOnExit.TabIndex = 4
        Me.chkPromptOnExit.Text = "Prompt to confirm on exit"
        Me.chkPromptOnExit.UseVisualStyleBackColor = True
        '
        'grpDefaultBackcolor
        '
        Me.grpDefaultBackcolor.Controls.Add(Me.optBackgrounWhite)
        Me.grpDefaultBackcolor.Controls.Add(Me.optBackgroundDefault)
        Me.grpDefaultBackcolor.Location = New System.Drawing.Point(6, 6)
        Me.grpDefaultBackcolor.Name = "grpDefaultBackcolor"
        Me.grpDefaultBackcolor.Size = New System.Drawing.Size(340, 101)
        Me.grpDefaultBackcolor.TabIndex = 5
        Me.grpDefaultBackcolor.TabStop = False
        Me.grpDefaultBackcolor.Text = "Default Picture Background Color"
        '
        'optBackgrounWhite
        '
        Me.optBackgrounWhite.AutoSize = True
        Me.optBackgrounWhite.Location = New System.Drawing.Point(6, 66)
        Me.optBackgrounWhite.Name = "optBackgrounWhite"
        Me.optBackgrounWhite.Size = New System.Drawing.Size(84, 29)
        Me.optBackgrounWhite.TabIndex = 7
        Me.optBackgrounWhite.Text = "White"
        Me.optBackgrounWhite.UseVisualStyleBackColor = True
        '
        'optBackgroundDefault
        '
        Me.optBackgroundDefault.AutoSize = True
        Me.optBackgroundDefault.Checked = True
        Me.optBackgroundDefault.Location = New System.Drawing.Point(6, 31)
        Me.optBackgroundDefault.Name = "optBackgroundDefault"
        Me.optBackgroundDefault.Size = New System.Drawing.Size(145, 29)
        Me.optBackgroundDefault.TabIndex = 6
        Me.optBackgroundDefault.TabStop = True
        Me.optBackgroundDefault.Text = "Defalut Gray"
        Me.optBackgroundDefault.UseVisualStyleBackColor = True
        '
        'tabOptions
        '
        Me.tabOptions.Controls.Add(Me.pgeGeneral)
        Me.tabOptions.Controls.Add(Me.pgeAppearance)
        Me.tabOptions.Location = New System.Drawing.Point(12, 12)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.SelectedIndex = 0
        Me.tabOptions.Size = New System.Drawing.Size(360, 189)
        Me.tabOptions.TabIndex = 6
        '
        'pgeGeneral
        '
        Me.pgeGeneral.Controls.Add(Me.lblUserName)
        Me.pgeGeneral.Controls.Add(Me.txtUserName)
        Me.pgeGeneral.Controls.Add(Me.chkPromptOnExit)
        Me.pgeGeneral.Location = New System.Drawing.Point(4, 34)
        Me.pgeGeneral.Name = "pgeGeneral"
        Me.pgeGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeGeneral.Size = New System.Drawing.Size(352, 151)
        Me.pgeGeneral.TabIndex = 0
        Me.pgeGeneral.Text = "General"
        Me.pgeGeneral.UseVisualStyleBackColor = True
        '
        'pgeAppearance
        '
        Me.pgeAppearance.Controls.Add(Me.grpDefaultBackcolor)
        Me.pgeAppearance.Location = New System.Drawing.Point(4, 34)
        Me.pgeAppearance.Name = "pgeAppearance"
        Me.pgeAppearance.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeAppearance.Size = New System.Drawing.Size(352, 151)
        Me.pgeAppearance.TabIndex = 1
        Me.pgeAppearance.Text = "Appearance"
        Me.pgeAppearance.UseVisualStyleBackColor = True
        '
        'OptionsForm
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.tabOptions)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Picture Viewer Options"
        Me.grpDefaultBackcolor.ResumeLayout(False)
        Me.grpDefaultBackcolor.PerformLayout()
        Me.tabOptions.ResumeLayout(False)
        Me.pgeGeneral.ResumeLayout(False)
        Me.pgeGeneral.PerformLayout()
        Me.pgeAppearance.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkPromptOnExit As CheckBox
    Friend WithEvents grpDefaultBackcolor As GroupBox
    Friend WithEvents optBackgroundDefault As RadioButton
    Friend WithEvents optBackgrounWhite As RadioButton
    Friend WithEvents tabOptions As TabControl
    Friend WithEvents pgeGeneral As TabPage
    Friend WithEvents pgeAppearance As TabPage
End Class
