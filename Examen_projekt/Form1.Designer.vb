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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KrafterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllæreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_tést = New System.Windows.Forms.Panel()
        Me.Formel_Label = New System.Windows.Forms.Label()
        Me.Panel_start.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_tést.SuspendLayout()
        Me.SuspendLayout()
        '
        'New_Window_opener
        '
        Me.New_Window_opener.Location = New System.Drawing.Point(177, 128)
        Me.New_Window_opener.Margin = New System.Windows.Forms.Padding(4)
        Me.New_Window_opener.Name = "New_Window_opener"
        Me.New_Window_opener.Size = New System.Drawing.Size(149, 71)
        Me.New_Window_opener.TabIndex = 1
        Me.New_Window_opener.Text = "New Window"
        Me.New_Window_opener.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 250)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 71)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Same Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel_start
        '
        Me.Panel_start.Controls.Add(Me.Button1)
        Me.Panel_start.Controls.Add(Me.New_Window_opener)
        Me.Panel_start.Location = New System.Drawing.Point(0, 0)
        Me.Panel_start.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_start.Name = "Panel_start"
        Me.Panel_start.Size = New System.Drawing.Size(539, 364)
        Me.Panel_start.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.EllæreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(539, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KrafterToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(76, 24)
        Me.ToolStripMenuItem1.Text = "Mekanik"
        '
        'KrafterToolStripMenuItem
        '
        Me.KrafterToolStripMenuItem.Name = "KrafterToolStripMenuItem"
        Me.KrafterToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.KrafterToolStripMenuItem.Text = "Krafter"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(230, 26)
        Me.ToolStripMenuItem2.Text = "Harmonisk bevægelse"
        '
        'EllæreToolStripMenuItem
        '
        Me.EllæreToolStripMenuItem.Name = "EllæreToolStripMenuItem"
        Me.EllæreToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.EllæreToolStripMenuItem.Text = "Ellære"
        '
        'Panel_tést
        '
        Me.Panel_tést.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_tést.Controls.Add(Me.Formel_Label)
        Me.Panel_tést.Location = New System.Drawing.Point(0, 0)
        Me.Panel_tést.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_tést.Name = "Panel_tést"
        Me.Panel_tést.Size = New System.Drawing.Size(539, 364)
        Me.Panel_tést.TabIndex = 0
        '
        'Formel_Label
        '
        Me.Formel_Label.AutoSize = True
        Me.Formel_Label.Location = New System.Drawing.Point(227, 155)
        Me.Formel_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Formel_Label.Name = "Formel_Label"
        Me.Formel_Label.Size = New System.Drawing.Size(64, 17)
        Me.Formel_Label.TabIndex = 0
        Me.Formel_Label.Text = "Formel :)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 362)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel_start)
        Me.Controls.Add(Me.Panel_tést)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel_start.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_tést.ResumeLayout(False)
        Me.Panel_tést.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents New_Window_opener As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_start As Panel
    Friend WithEvents Panel_tést As Panel
    Friend WithEvents Formel_Label As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KrafterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EllæreToolStripMenuItem As ToolStripMenuItem
End Class
