<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectionsExampleForm
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
        Me.btnShowNames = New System.Windows.Forms.Button()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowNames
        '
        Me.btnShowNames.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnShowNames.Location = New System.Drawing.Point(343, 332)
        Me.btnShowNames.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnShowNames.Name = "btnShowNames"
        Me.btnShowNames.Size = New System.Drawing.Size(327, 64)
        Me.btnShowNames.TabIndex = 0
        Me.btnShowNames.Text = "Show Control Names"
        Me.btnShowNames.UseVisualStyleBackColor = True
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(338, 211)
        Me.lblFirst.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(50, 25)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "First"
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(430, 208)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(240, 32)
        Me.txtFirst.TabIndex = 2
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSecond.Location = New System.Drawing.Point(338, 259)
        Me.lblSecond.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(80, 25)
        Me.lblSecond.TabIndex = 3
        Me.lblSecond.Text = "Second"
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(430, 256)
        Me.txtSecond.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(240, 32)
        Me.txtSecond.TabIndex = 4
        '
        'btnCopy
        '
        Me.btnCopy.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCopy.Location = New System.Drawing.Point(343, 408)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(327, 64)
        Me.btnCopy.TabIndex = 5
        Me.btnCopy.Text = "Copy First To Second"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'CollectionsExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.btnShowNames)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "CollectionsExampleForm"
        Me.Text = "Collections Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowNames As Button
    Friend WithEvents lblFirst As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents lblSecond As Label
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents btnCopy As Button
End Class
