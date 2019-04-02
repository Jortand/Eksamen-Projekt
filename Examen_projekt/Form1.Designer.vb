<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.New_Window_opener = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel_start = New System.Windows.Forms.Panel()
        Me.Panel_tést = New System.Windows.Forms.Panel()
        Me.Formel_Label = New System.Windows.Forms.Label()
        Me.Panel_start.SuspendLayout()
        Me.Panel_tést.SuspendLayout()
        Me.SuspendLayout()
        '
        'New_Window_opener
        '
        Me.New_Window_opener.Location = New System.Drawing.Point(52, 126)
        Me.New_Window_opener.Name = "New_Window_opener"
        Me.New_Window_opener.Size = New System.Drawing.Size(112, 58)
        Me.New_Window_opener.TabIndex = 1
        Me.New_Window_opener.Text = "New Window"
        Me.New_Window_opener.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 58)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Same Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel_start
        '
        Me.Panel_start.Controls.Add(Me.Button1)
        Me.Panel_start.Controls.Add(Me.New_Window_opener)
        Me.Panel_start.Location = New System.Drawing.Point(0, 0)
        Me.Panel_start.Name = "Panel_start"
        Me.Panel_start.Size = New System.Drawing.Size(404, 296)
        Me.Panel_start.TabIndex = 3
        '
        'Panel_tést
        '
        Me.Panel_tést.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_tést.Controls.Add(Me.Formel_Label)
        Me.Panel_tést.Location = New System.Drawing.Point(0, 0)
        Me.Panel_tést.Name = "Panel_tést"
        Me.Panel_tést.Size = New System.Drawing.Size(404, 296)
        Me.Panel_tést.TabIndex = 0
        '
        'Formel_Label
        '
        Me.Formel_Label.AutoSize = True
        Me.Formel_Label.Location = New System.Drawing.Point(170, 126)
        Me.Formel_Label.Name = "Formel_Label"
        Me.Formel_Label.Size = New System.Drawing.Size(47, 13)
        Me.Formel_Label.TabIndex = 0
        Me.Formel_Label.Text = "Formel :)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 294)
        Me.Controls.Add(Me.Panel_start)
        Me.Controls.Add(Me.Panel_tést)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel_start.ResumeLayout(False)
        Me.Panel_tést.ResumeLayout(False)
        Me.Panel_tést.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents New_Window_opener As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_start As Panel
    Friend WithEvents Panel_tést As Panel
    Friend WithEvents Formel_Label As Label
End Class
