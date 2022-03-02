<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinFormExampleForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.TheNamLabel = New System.Windows.Forms.Label()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ExitButton.ForeColor = System.Drawing.Color.DarkCyan
        Me.ExitButton.Location = New System.Drawing.Point(344, 267)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(76, 61)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Cursor = System.Windows.Forms.Cursors.Cross
        Me.GoButton.ForeColor = System.Drawing.Color.DarkCyan
        Me.GoButton.Location = New System.Drawing.Point(66, 276)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(76, 61)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'TheNamLabel
        '
        Me.TheNamLabel.AutoSize = True
        Me.TheNamLabel.ForeColor = System.Drawing.Color.DarkCyan
        Me.TheNamLabel.Location = New System.Drawing.Point(51, 37)
        Me.TheNamLabel.Name = "TheNamLabel"
        Me.TheNamLabel.Size = New System.Drawing.Size(45, 17)
        Me.TheNamLabel.TabIndex = 2
        Me.TheNamLabel.Text = "Name"
        '
        'NameTextBox1
        '
        Me.NameTextBox1.Location = New System.Drawing.Point(118, 34)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(338, 22)
        Me.NameTextBox1.TabIndex = 3
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(649, 371)
        Me.Controls.Add(Me.NameTextBox1)
        Me.Controls.Add(Me.TheNamLabel)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.ExitButton)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "WinFormExampleForm"
        Me.Text = "Hello"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents GoButton As Button
    Friend WithEvents TheNamLabel As Label
    Friend WithEvents NameTextBox1 As TextBox
End Class
