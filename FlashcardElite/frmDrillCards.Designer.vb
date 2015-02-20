<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrillCards
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
        Me.btnNextCard = New System.Windows.Forms.Button()
        Me.lblKeyword = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNextCard
        '
        Me.btnNextCard.Location = New System.Drawing.Point(13, 295)
        Me.btnNextCard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNextCard.Name = "btnNextCard"
        Me.btnNextCard.Size = New System.Drawing.Size(357, 43)
        Me.btnNextCard.TabIndex = 1
        Me.btnNextCard.Text = "&Next Card"
        Me.btnNextCard.UseVisualStyleBackColor = True
        '
        'lblKeyword
        '
        Me.lblKeyword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblKeyword.Location = New System.Drawing.Point(13, 16)
        Me.lblKeyword.Name = "lblKeyword"
        Me.lblKeyword.Size = New System.Drawing.Size(357, 61)
        Me.lblKeyword.TabIndex = 2
        Me.lblKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnswer
        '
        Me.lblAnswer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblAnswer.Location = New System.Drawing.Point(83, 81)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(217, 210)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Visible = False
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(141, 152)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(100, 43)
        Me.btnShowAnswer.TabIndex = 4
        Me.btnShowAnswer.Text = "&Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'frmDrillCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 355)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblKeyword)
        Me.Controls.Add(Me.btnNextCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDrillCards"
        Me.ShowIcon = False
        Me.Text = "Drill Cards"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNextCard As System.Windows.Forms.Button
    Friend WithEvents lblKeyword As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnShowAnswer As System.Windows.Forms.Button
End Class
