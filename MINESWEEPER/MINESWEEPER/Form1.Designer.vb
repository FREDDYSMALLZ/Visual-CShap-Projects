<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mine_Sweeper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mine_Sweeper))
        Me.button_NewGame = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_NewGame
        '
        Me.button_NewGame.Location = New System.Drawing.Point(58, 495)
        Me.button_NewGame.Margin = New System.Windows.Forms.Padding(4)
        Me.button_NewGame.Name = "button_NewGame"
        Me.button_NewGame.Size = New System.Drawing.Size(281, 57)
        Me.button_NewGame.TabIndex = 0
        Me.button_NewGame.Text = "&New Game"
        Me.button_NewGame.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(430, 495)
        Me.button_Exit.Margin = New System.Windows.Forms.Padding(4)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(240, 57)
        Me.button_Exit.TabIndex = 1
        Me.button_Exit.Text = "&Exit"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'Mine_Sweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 570)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_NewGame)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Mine_Sweeper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MINESWEEPER"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_NewGame As Button
    Friend WithEvents button_Exit As Button
End Class
