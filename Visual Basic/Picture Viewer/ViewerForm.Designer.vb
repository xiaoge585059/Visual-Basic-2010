<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewerForm))
        Me.picShowPicture = New System.Windows.Forms.PictureBox()
        Me.mnuPictureContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DrawBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdSelectPicture = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnlarge = New System.Windows.Forms.Button()
        Me.btnShrink = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfirmonExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDrawBorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbrMainToolBar = New System.Windows.Forms.ToolStrip()
        Me.tbbOpenPicture = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbDrawBorder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbOptions = New System.Windows.Forms.ToolStripButton()
        Me.sbrMyStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbShowLog = New System.Windows.Forms.ToolStripButton()
        CType(Me.picShowPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPictureContext.SuspendLayout()
        Me.mnuMainMenu.SuspendLayout()
        Me.tbrMainToolBar.SuspendLayout()
        Me.sbrMyStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'picShowPicture
        '
        Me.picShowPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShowPicture.ContextMenuStrip = Me.mnuPictureContext
        Me.picShowPicture.Location = New System.Drawing.Point(15, 56)
        Me.picShowPicture.Margin = New System.Windows.Forms.Padding(6)
        Me.picShowPicture.Name = "picShowPicture"
        Me.picShowPicture.Size = New System.Drawing.Size(847, 645)
        Me.picShowPicture.TabIndex = 2
        Me.picShowPicture.TabStop = False
        '
        'mnuPictureContext
        '
        Me.mnuPictureContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawBorderToolStripMenuItem})
        Me.mnuPictureContext.Name = "mnuPictureContext"
        Me.mnuPictureContext.Size = New System.Drawing.Size(152, 26)
        '
        'DrawBorderToolStripMenuItem
        '
        Me.DrawBorderToolStripMenuItem.Name = "DrawBorderToolStripMenuItem"
        Me.DrawBorderToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DrawBorderToolStripMenuItem.Text = "Draw Border"
        '
        'ofdSelectPicture
        '
        Me.ofdSelectPicture.Filter = "JPEG Files|*.JPG|Windows Bitmaps|*.BMP|GIF Files|*.GIF"
        Me.ofdSelectPicture.Title = "Select Picture"
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnlarge.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnlarge.Location = New System.Drawing.Point(874, 651)
        Me.btnEnlarge.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(54, 50)
        Me.btnEnlarge.TabIndex = 4
        Me.btnEnlarge.Text = "^"
        Me.btnEnlarge.UseVisualStyleBackColor = True
        '
        'btnShrink
        '
        Me.btnShrink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShrink.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShrink.Location = New System.Drawing.Point(940, 651)
        Me.btnShrink.Margin = New System.Windows.Forms.Padding(6)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(53, 50)
        Me.btnShrink.TabIndex = 5
        Me.btnShrink.Text = "v"
        Me.btnShrink.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(874, 548)
        Me.lblX.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(35, 25)
        Me.lblX.TabIndex = 6
        Me.lblX.Text = "X: "
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(874, 573)
        Me.lblY.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(34, 25)
        Me.lblY.TabIndex = 7
        Me.lblY.Text = "Y: "
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(1008, 25)
        Me.mnuMainMenu.TabIndex = 8
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenPicture, Me.mnuConfirmonExit, Me.mnuQuit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuOpenPicture
        '
        Me.mnuOpenPicture.Name = "mnuOpenPicture"
        Me.mnuOpenPicture.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpenPicture.Size = New System.Drawing.Size(198, 22)
        Me.mnuOpenPicture.Text = "&Open Picture"
        '
        'mnuConfirmonExit
        '
        Me.mnuConfirmonExit.Checked = True
        Me.mnuConfirmonExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuConfirmonExit.Name = "mnuConfirmonExit"
        Me.mnuConfirmonExit.Size = New System.Drawing.Size(198, 22)
        Me.mnuConfirmonExit.Text = "Confirm on Exit"
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(198, 22)
        Me.mnuQuit.Text = "&Quit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDrawBorder, Me.ToolStripSeparator1, Me.mnuOptions})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'mnuDrawBorder
        '
        Me.mnuDrawBorder.Name = "mnuDrawBorder"
        Me.mnuDrawBorder.Size = New System.Drawing.Size(151, 22)
        Me.mnuDrawBorder.Text = "&Draw Border"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'mnuOptions
        '
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(151, 22)
        Me.mnuOptions.Text = "&Options ..."
        '
        'tbrMainToolBar
        '
        Me.tbrMainToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbbOpenPicture, Me.ToolStripSeparator2, Me.tbbDrawBorder, Me.ToolStripSeparator3, Me.tbbOptions, Me.ToolStripSeparator4, Me.tbbShowLog})
        Me.tbrMainToolBar.Location = New System.Drawing.Point(0, 25)
        Me.tbrMainToolBar.Name = "tbrMainToolBar"
        Me.tbrMainToolBar.Size = New System.Drawing.Size(1008, 25)
        Me.tbrMainToolBar.TabIndex = 10
        Me.tbrMainToolBar.Text = "ToolStrip1"
        '
        'tbbOpenPicture
        '
        Me.tbbOpenPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOpenPicture.Image = CType(resources.GetObject("tbbOpenPicture.Image"), System.Drawing.Image)
        Me.tbbOpenPicture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOpenPicture.Name = "tbbOpenPicture"
        Me.tbbOpenPicture.Size = New System.Drawing.Size(23, 22)
        Me.tbbOpenPicture.Text = "Open Picture"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbbDrawBorder
        '
        Me.tbbDrawBorder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbDrawBorder.Image = CType(resources.GetObject("tbbDrawBorder.Image"), System.Drawing.Image)
        Me.tbbDrawBorder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbDrawBorder.Name = "tbbDrawBorder"
        Me.tbbDrawBorder.Size = New System.Drawing.Size(23, 22)
        Me.tbbDrawBorder.Text = "Draw Border"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbbOptions
        '
        Me.tbbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOptions.Image = CType(resources.GetObject("tbbOptions.Image"), System.Drawing.Image)
        Me.tbbOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOptions.Name = "tbbOptions"
        Me.tbbOptions.Size = New System.Drawing.Size(23, 22)
        Me.tbbOptions.Text = "Options"
        '
        'sbrMyStatusStrip
        '
        Me.sbrMyStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.sbrMyStatusStrip.Location = New System.Drawing.Point(0, 707)
        Me.sbrMyStatusStrip.Name = "sbrMyStatusStrip"
        Me.sbrMyStatusStrip.Size = New System.Drawing.Size(1008, 22)
        Me.sbrMyStatusStrip.SizingGrip = False
        Me.sbrMyStatusStrip.TabIndex = 11
        Me.sbrMyStatusStrip.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(111, 17)
        Me.lblStatus.Text = "No image loaded"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tbbShowLog
        '
        Me.tbbShowLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbShowLog.Image = CType(resources.GetObject("tbbShowLog.Image"), System.Drawing.Image)
        Me.tbbShowLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbShowLog.Name = "tbbShowLog"
        Me.tbbShowLog.Size = New System.Drawing.Size(23, 22)
        Me.tbbShowLog.Text = "View Picture Log"
        '
        'ViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.sbrMyStatusStrip)
        Me.Controls.Add(Me.tbrMainToolBar)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.btnEnlarge)
        Me.Controls.Add(Me.picShowPicture)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ViewerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Picture Viewer"
        CType(Me.picShowPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPictureContext.ResumeLayout(False)
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.tbrMainToolBar.ResumeLayout(False)
        Me.tbrMainToolBar.PerformLayout()
        Me.sbrMyStatusStrip.ResumeLayout(False)
        Me.sbrMyStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picShowPicture As PictureBox
    Friend WithEvents ofdSelectPicture As OpenFileDialog
    Friend WithEvents btnEnlarge As Button
    Friend WithEvents btnShrink As Button
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents mnuMainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuOpenPicture As ToolStripMenuItem
    Friend WithEvents mnuConfirmonExit As ToolStripMenuItem
    Friend WithEvents mnuQuit As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDrawBorder As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuOptions As ToolStripMenuItem
    Friend WithEvents mnuPictureContext As ContextMenuStrip
    Friend WithEvents DrawBorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbrMainToolBar As ToolStrip
    Friend WithEvents tbbOpenPicture As ToolStripButton
    Friend WithEvents tbbDrawBorder As ToolStripButton
    Friend WithEvents tbbOptions As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents sbrMyStatusStrip As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tbbShowLog As ToolStripButton
End Class
