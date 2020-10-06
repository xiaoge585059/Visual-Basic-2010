<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Child1Form
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
        Me.btnShowChild2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowChild2
        '
        Me.btnShowChild2.Location = New System.Drawing.Point(296, 495)
        Me.btnShowChild2.Name = "btnShowChild2"
        Me.btnShowChild2.Size = New System.Drawing.Size(176, 54)
        Me.btnShowChild2.TabIndex = 0
        Me.btnShowChild2.Text = "Show Child 2"
        Me.btnShowChild2.UseVisualStyleBackColor = True
        '
        'Child1Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnShowChild2)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Name = "Child1Form"
        Me.Text = "Child 1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShowChild2 As Button
End Class
