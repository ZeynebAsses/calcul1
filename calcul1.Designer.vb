<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calcul1
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
        Label_a = New Label()
        Label_b = New Label()
        Textbox_a = New TextBox()
        TextBox_b = New TextBox()
        button_plus = New Button()
        Button_moins = New Button()
        Button_fois = New Button()
        Button_sur = New Button()
        Button_egale = New Button()
        Button_reset = New Button()
        Label_resultat = New Label()
        SuspendLayout()
        ' 
        ' Label_a
        ' 
        Label_a.AutoSize = True
        Label_a.BackColor = SystemColors.ActiveCaption
        Label_a.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_a.Location = New Point(280, 76)
        Label_a.Name = "Label_a"
        Label_a.Size = New Size(28, 29)
        Label_a.TabIndex = 0
        Label_a.Text = "a"
        ' 
        ' Label_b
        ' 
        Label_b.AutoSize = True
        Label_b.BackColor = SystemColors.ActiveCaption
        Label_b.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_b.Location = New Point(280, 166)
        Label_b.Name = "Label_b"
        Label_b.Size = New Size(29, 29)
        Label_b.TabIndex = 1
        Label_b.Text = "b"
        ' 
        ' Textbox_a
        ' 
        Textbox_a.Location = New Point(338, 81)
        Textbox_a.Name = "Textbox_a"
        Textbox_a.Size = New Size(125, 27)
        Textbox_a.TabIndex = 2
        ' 
        ' TextBox_b
        ' 
        TextBox_b.Location = New Point(338, 168)
        TextBox_b.Name = "TextBox_b"
        TextBox_b.Size = New Size(125, 27)
        TextBox_b.TabIndex = 3
        ' 
        ' button_plus
        ' 
        button_plus.BackColor = SystemColors.ActiveCaptionText
        button_plus.FlatStyle = FlatStyle.Popup
        button_plus.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        button_plus.ForeColor = SystemColors.ButtonHighlight
        button_plus.Location = New Point(12, 270)
        button_plus.Name = "button_plus"
        button_plus.Size = New Size(94, 29)
        button_plus.TabIndex = 4
        button_plus.Text = "+"
        button_plus.UseVisualStyleBackColor = False
        ' 
        ' Button_moins
        ' 
        Button_moins.BackColor = SystemColors.ActiveCaptionText
        Button_moins.FlatStyle = FlatStyle.Popup
        Button_moins.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_moins.ForeColor = SystemColors.ButtonHighlight
        Button_moins.Location = New Point(132, 310)
        Button_moins.Name = "Button_moins"
        Button_moins.Size = New Size(94, 29)
        Button_moins.TabIndex = 5
        Button_moins.Text = "-"
        Button_moins.UseVisualStyleBackColor = False
        ' 
        ' Button_fois
        ' 
        Button_fois.BackColor = SystemColors.ActiveCaptionText
        Button_fois.FlatStyle = FlatStyle.Popup
        Button_fois.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_fois.ForeColor = SystemColors.ButtonHighlight
        Button_fois.Location = New Point(249, 270)
        Button_fois.Name = "Button_fois"
        Button_fois.Size = New Size(94, 29)
        Button_fois.TabIndex = 6
        Button_fois.Text = "*"
        Button_fois.UseVisualStyleBackColor = False
        ' 
        ' Button_sur
        ' 
        Button_sur.BackColor = SystemColors.ActiveCaptionText
        Button_sur.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_sur.ForeColor = SystemColors.ButtonHighlight
        Button_sur.Location = New Point(369, 310)
        Button_sur.Name = "Button_sur"
        Button_sur.Size = New Size(94, 29)
        Button_sur.TabIndex = 7
        Button_sur.Text = "/"
        Button_sur.UseVisualStyleBackColor = False
        ' 
        ' Button_egale
        ' 
        Button_egale.BackColor = SystemColors.ActiveCaptionText
        Button_egale.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_egale.ForeColor = SystemColors.ButtonHighlight
        Button_egale.Location = New Point(492, 270)
        Button_egale.Name = "Button_egale"
        Button_egale.Size = New Size(94, 29)
        Button_egale.TabIndex = 8
        Button_egale.Text = "="
        Button_egale.UseVisualStyleBackColor = False
        ' 
        ' Button_reset
        ' 
        Button_reset.BackColor = SystemColors.ActiveCaptionText
        Button_reset.ForeColor = SystemColors.ButtonHighlight
        Button_reset.Location = New Point(653, 310)
        Button_reset.Name = "Button_reset"
        Button_reset.Size = New Size(94, 29)
        Button_reset.TabIndex = 9
        Button_reset.Text = "reset"
        Button_reset.UseVisualStyleBackColor = False
        ' 
        ' Label_resultat
        ' 
        Label_resultat.AutoSize = True
        Label_resultat.BackColor = SystemColors.ActiveCaption
        Label_resultat.Font = New Font("SimSun-ExtG", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_resultat.Location = New Point(249, 399)
        Label_resultat.Name = "Label_resultat"
        Label_resultat.Size = New Size(133, 30)
        Label_resultat.TabIndex = 10
        Label_resultat.Text = "resultat"
        ' 
        ' calcul1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label_resultat)
        Controls.Add(Button_reset)
        Controls.Add(Button_egale)
        Controls.Add(Button_sur)
        Controls.Add(Button_fois)
        Controls.Add(Button_moins)
        Controls.Add(button_plus)
        Controls.Add(TextBox_b)
        Controls.Add(Textbox_a)
        Controls.Add(Label_b)
        Controls.Add(Label_a)
        Name = "calcul1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_a As Label
    Friend WithEvents Label_b As Label
    Friend WithEvents Textbox_a As TextBox
    Friend WithEvents TextBox_b As TextBox
    Friend WithEvents button_plus As Button
    Friend WithEvents Button_moins As Button
    Friend WithEvents Button_fois As Button
    Friend WithEvents Button_sur As Button
    Friend WithEvents Button_egale As Button
    Friend WithEvents Button_reset As Button
    Friend WithEvents Label_resultat As Label

End Class
