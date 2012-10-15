<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtguess = New System.Windows.Forms.TextBox()
        Me.lbltitleLetters = New System.Windows.Forms.Label()
        Me.lbltitleAttused = New System.Windows.Forms.Label()
        Me.lblUsedLetters = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnrestart = New System.Windows.Forms.Button()
        Me.btnGiveUp = New System.Windows.Forms.Button()
        Me.lblAttUsed = New System.Windows.Forms.Label()
        Me.txtUsedLetters = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(160, 30)
        Me.txtWord.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWord.Multiline = True
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(132, 41)
        Me.txtWord.TabIndex = 0
        Me.txtWord.TabStop = False
        '
        'txtguess
        '
        Me.txtguess.Location = New System.Drawing.Point(160, 81)
        Me.txtguess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtguess.Multiline = True
        Me.txtguess.Name = "txtguess"
        Me.txtguess.Size = New System.Drawing.Size(71, 45)
        Me.txtguess.TabIndex = 0
        '
        'lbltitleLetters
        '
        Me.lbltitleLetters.AutoSize = True
        Me.lbltitleLetters.Location = New System.Drawing.Point(157, 162)
        Me.lbltitleLetters.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitleLetters.Name = "lbltitleLetters"
        Me.lbltitleLetters.Size = New System.Drawing.Size(89, 17)
        Me.lbltitleLetters.TabIndex = 2
        Me.lbltitleLetters.Text = "Used Letters"
        '
        'lbltitleAttused
        '
        Me.lbltitleAttused.AutoSize = True
        Me.lbltitleAttused.Location = New System.Drawing.Point(156, 139)
        Me.lbltitleAttused.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitleAttused.Name = "lbltitleAttused"
        Me.lbltitleAttused.Size = New System.Drawing.Size(133, 17)
        Me.lbltitleAttused.TabIndex = 3
        Me.lbltitleAttused.Text = "Number of Attempts"
        '
        'lblUsedLetters
        '
        Me.lblUsedLetters.AutoSize = True
        Me.lblUsedLetters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUsedLetters.Location = New System.Drawing.Point(160, 184)
        Me.lblUsedLetters.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsedLetters.Name = "lblUsedLetters"
        Me.lblUsedLetters.Size = New System.Drawing.Size(2, 19)
        Me.lblUsedLetters.TabIndex = 4
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(28, 30)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(100, 42)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Check for Letter"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnrestart
        '
        Me.btnrestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrestart.Location = New System.Drawing.Point(16, 251)
        Me.btnrestart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnrestart.Name = "btnrestart"
        Me.btnrestart.Size = New System.Drawing.Size(145, 65)
        Me.btnrestart.TabIndex = 6
        Me.btnrestart.TabStop = False
        Me.btnrestart.Text = "Start New Game"
        Me.btnrestart.UseVisualStyleBackColor = True
        '
        'btnGiveUp
        '
        Me.btnGiveUp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGiveUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiveUp.ForeColor = System.Drawing.Color.DarkRed
        Me.btnGiveUp.Location = New System.Drawing.Point(220, 231)
        Me.btnGiveUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGiveUp.Name = "btnGiveUp"
        Me.btnGiveUp.Size = New System.Drawing.Size(156, 91)
        Me.btnGiveUp.TabIndex = 7
        Me.btnGiveUp.TabStop = False
        Me.btnGiveUp.Text = "GIVE UP"
        Me.btnGiveUp.UseVisualStyleBackColor = True
        '
        'lblAttUsed
        '
        Me.lblAttUsed.AutoSize = True
        Me.lblAttUsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAttUsed.Location = New System.Drawing.Point(297, 139)
        Me.lblAttUsed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAttUsed.Name = "lblAttUsed"
        Me.lblAttUsed.Size = New System.Drawing.Size(2, 19)
        Me.lblAttUsed.TabIndex = 8
        '
        'txtUsedLetters
        '
        Me.txtUsedLetters.Enabled = False
        Me.txtUsedLetters.Location = New System.Drawing.Point(190, 193)
        Me.txtUsedLetters.Name = "txtUsedLetters"
        Me.txtUsedLetters.Size = New System.Drawing.Size(100, 22)
        Me.txtUsedLetters.TabIndex = 9
        '
        'Main_Form
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 322)
        Me.Controls.Add(Me.txtUsedLetters)
        Me.Controls.Add(Me.lblAttUsed)
        Me.Controls.Add(Me.btnGiveUp)
        Me.Controls.Add(Me.btnrestart)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblUsedLetters)
        Me.Controls.Add(Me.lbltitleAttused)
        Me.Controls.Add(Me.lbltitleLetters)
        Me.Controls.Add(Me.txtguess)
        Me.Controls.Add(Me.txtWord)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Main_Form"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents txtguess As System.Windows.Forms.TextBox
    Friend WithEvents lbltitleLetters As System.Windows.Forms.Label
    Friend WithEvents lbltitleAttused As System.Windows.Forms.Label
    Friend WithEvents lblUsedLetters As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnrestart As System.Windows.Forms.Button
    Friend WithEvents btnGiveUp As System.Windows.Forms.Button
    Friend WithEvents lblAttUsed As System.Windows.Forms.Label
    Friend WithEvents txtUsedLetters As System.Windows.Forms.TextBox

End Class
