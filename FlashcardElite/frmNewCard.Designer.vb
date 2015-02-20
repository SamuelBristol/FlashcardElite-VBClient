<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.gboKeyword = New System.Windows.Forms.GroupBox()
        Me.gboAnswer = New System.Windows.Forms.GroupBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gboKeyword.SuspendLayout()
        Me.gboAnswer.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(9, 23)
        Me.txtKeyword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(336, 22)
        Me.txtKeyword.TabIndex = 1
        '
        'gboKeyword
        '
        Me.gboKeyword.Controls.Add(Me.txtKeyword)
        Me.gboKeyword.Location = New System.Drawing.Point(13, 24)
        Me.gboKeyword.Margin = New System.Windows.Forms.Padding(4)
        Me.gboKeyword.Name = "gboKeyword"
        Me.gboKeyword.Padding = New System.Windows.Forms.Padding(4)
        Me.gboKeyword.Size = New System.Drawing.Size(357, 68)
        Me.gboKeyword.TabIndex = 4
        Me.gboKeyword.TabStop = False
        Me.gboKeyword.Text = "Keyword"
        '
        'gboAnswer
        '
        Me.gboAnswer.Controls.Add(Me.txtAnswer)
        Me.gboAnswer.Location = New System.Drawing.Point(13, 99)
        Me.gboAnswer.Margin = New System.Windows.Forms.Padding(4)
        Me.gboAnswer.Name = "gboAnswer"
        Me.gboAnswer.Padding = New System.Windows.Forms.Padding(4)
        Me.gboAnswer.Size = New System.Drawing.Size(357, 192)
        Me.gboAnswer.TabIndex = 5
        Me.gboAnswer.TabStop = False
        Me.gboAnswer.Text = "Answer"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(9, 23)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(336, 160)
        Me.txtAnswer.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(28, 302)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 28)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(196, 302)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(160, 28)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmNewCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 355)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gboAnswer)
        Me.Controls.Add(Me.gboKeyword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNewCard"
        Me.Text = "Create A New Card"
        Me.gboKeyword.ResumeLayout(False)
        Me.gboKeyword.PerformLayout()
        Me.gboAnswer.ResumeLayout(False)
        Me.gboAnswer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents gboKeyword As System.Windows.Forms.GroupBox
    Friend WithEvents gboAnswer As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
