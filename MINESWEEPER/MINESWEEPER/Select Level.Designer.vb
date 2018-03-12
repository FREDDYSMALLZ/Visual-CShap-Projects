<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Level
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbttn_easy = New System.Windows.Forms.RadioButton()
        Me.rbttn_difficult = New System.Windows.Forms.RadioButton()
        Me.rbttn_moderate = New System.Windows.Forms.RadioButton()
        Me.button_Start = New System.Windows.Forms.Button()
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Select your level of difficulty "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbttn_easy
        '
        Me.rbttn_easy.AutoSize = True
        Me.rbttn_easy.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttn_easy.Location = New System.Drawing.Point(110, 170)
        Me.rbttn_easy.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbttn_easy.Name = "rbttn_easy"
        Me.rbttn_easy.Size = New System.Drawing.Size(137, 29)
        Me.rbttn_easy.TabIndex = 1
        Me.rbttn_easy.TabStop = True
        Me.rbttn_easy.Text = "Easy Mode"
        Me.rbttn_easy.UseVisualStyleBackColor = True
        '
        'rbttn_difficult
        '
        Me.rbttn_difficult.AutoSize = True
        Me.rbttn_difficult.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttn_difficult.Location = New System.Drawing.Point(110, 319)
        Me.rbttn_difficult.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbttn_difficult.Name = "rbttn_difficult"
        Me.rbttn_difficult.Size = New System.Drawing.Size(169, 29)
        Me.rbttn_difficult.TabIndex = 2
        Me.rbttn_difficult.TabStop = True
        Me.rbttn_difficult.Text = "Difficult Mode"
        Me.rbttn_difficult.UseVisualStyleBackColor = True
        '
        'rbttn_moderate
        '
        Me.rbttn_moderate.AutoSize = True
        Me.rbttn_moderate.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttn_moderate.Location = New System.Drawing.Point(108, 245)
        Me.rbttn_moderate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.rbttn_moderate.Name = "rbttn_moderate"
        Me.rbttn_moderate.Size = New System.Drawing.Size(178, 29)
        Me.rbttn_moderate.TabIndex = 3
        Me.rbttn_moderate.TabStop = True
        Me.rbttn_moderate.Text = "Moderate Mode"
        Me.rbttn_moderate.UseVisualStyleBackColor = True
        '
        'button_Start
        '
        Me.button_Start.Location = New System.Drawing.Point(108, 448)
        Me.button_Start.Name = "button_Start"
        Me.button_Start.Size = New System.Drawing.Size(223, 54)
        Me.button_Start.TabIndex = 4
        Me.button_Start.Text = "&Start Game"
        Me.button_Start.UseVisualStyleBackColor = True
        '
        'button_Cancel
        '
        Me.button_Cancel.Location = New System.Drawing.Point(412, 448)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(223, 54)
        Me.button_Cancel.TabIndex = 5
        Me.button_Cancel.Text = "&Cancel"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'Select_Level
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 536)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_Start)
        Me.Controls.Add(Me.rbttn_moderate)
        Me.Controls.Add(Me.rbttn_difficult)
        Me.Controls.Add(Me.rbttn_easy)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Select_Level"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select_Level"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rbttn_easy As RadioButton
    Friend WithEvents rbttn_difficult As RadioButton
    Friend WithEvents rbttn_moderate As RadioButton
    Friend WithEvents button_Start As Button
    Friend WithEvents button_Cancel As Button
End Class
