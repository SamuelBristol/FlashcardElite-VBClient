<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnNewCard = New System.Windows.Forms.Button()
        Me.btnDrillCards = New System.Windows.Forms.Button()
        Me.gboMyCards = New System.Windows.Forms.GroupBox()
        Me.lboMyCards = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gboMyCards.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNewCard
        '
        Me.btnNewCard.Location = New System.Drawing.Point(13, 22)
        Me.btnNewCard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewCard.Name = "btnNewCard"
        Me.btnNewCard.Size = New System.Drawing.Size(357, 43)
        Me.btnNewCard.TabIndex = 0
        Me.btnNewCard.Text = "&New Card"
        Me.btnNewCard.UseVisualStyleBackColor = True
        '
        'btnDrillCards
        '
        Me.btnDrillCards.Location = New System.Drawing.Point(13, 72)
        Me.btnDrillCards.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDrillCards.Name = "btnDrillCards"
        Me.btnDrillCards.Size = New System.Drawing.Size(357, 43)
        Me.btnDrillCards.TabIndex = 1
        Me.btnDrillCards.Text = "&Drill Cards"
        Me.btnDrillCards.UseVisualStyleBackColor = True
        '
        'gboMyCards
        '
        Me.gboMyCards.Controls.Add(Me.lboMyCards)
        Me.gboMyCards.Location = New System.Drawing.Point(13, 123)
        Me.gboMyCards.Margin = New System.Windows.Forms.Padding(4)
        Me.gboMyCards.Name = "gboMyCards"
        Me.gboMyCards.Padding = New System.Windows.Forms.Padding(4)
        Me.gboMyCards.Size = New System.Drawing.Size(357, 160)
        Me.gboMyCards.TabIndex = 2
        Me.gboMyCards.TabStop = False
        Me.gboMyCards.Text = "My Cards"
        '
        'lboMyCards
        '
        Me.lboMyCards.FormattingEnabled = True
        Me.lboMyCards.ItemHeight = 16
        Me.lboMyCards.Location = New System.Drawing.Point(9, 23)
        Me.lboMyCards.Margin = New System.Windows.Forms.Padding(4)
        Me.lboMyCards.Name = "lboMyCards"
        Me.lboMyCards.Size = New System.Drawing.Size(337, 116)
        Me.lboMyCards.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(13, 290)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(357, 43)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 355)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gboMyCards)
        Me.Controls.Add(Me.btnDrillCards)
        Me.Controls.Add(Me.btnNewCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Flashcard Elite, v. 0.1"
        Me.gboMyCards.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewCard As System.Windows.Forms.Button
    Friend WithEvents btnDrillCards As System.Windows.Forms.Button
    Friend WithEvents gboMyCards As System.Windows.Forms.GroupBox
    Friend WithEvents lboMyCards As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
