﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.New_Window_opener = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel_start = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KraftArbejdeToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergiVarmeToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_KraftArbejde1 = New System.Windows.Forms.Panel()
        Me.FresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FresF1F2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_KarftArbejde2 = New System.Windows.Forms.Panel()
        Me.Panel_EnergiVarme = New System.Windows.Forms.Panel()
        Me.ElektricitetMagnatismeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OhmsLovToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_ElektricitetMagnatisme = New System.Windows.Forms.Panel()
        Me.Panel_start.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'New_Window_opener
        '
        Me.New_Window_opener.Location = New System.Drawing.Point(230, 166)
        Me.New_Window_opener.Margin = New System.Windows.Forms.Padding(4)
        Me.New_Window_opener.Name = "New_Window_opener"
        Me.New_Window_opener.Size = New System.Drawing.Size(149, 71)
        Me.New_Window_opener.TabIndex = 1
        Me.New_Window_opener.Text = "New Window"
        Me.New_Window_opener.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 166)
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KraftArbejdeToolStrip, Me.EnergiVarmeToolStrip, Me.ElektricitetMagnatismeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(539, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KraftArbejdeToolStrip
        '
        Me.KraftArbejdeToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FresToolStripMenuItem, Me.FresF1F2ToolStripMenuItem})
        Me.KraftArbejdeToolStrip.Name = "KraftArbejdeToolStrip"
        Me.KraftArbejdeToolStrip.Size = New System.Drawing.Size(130, 24)
        Me.KraftArbejdeToolStrip.Text = "Kraft og arbejde"
        '
        'EnergiVarmeToolStrip
        '
        Me.EnergiVarmeToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QCToolStripMenuItem})
        Me.EnergiVarmeToolStrip.Name = "EnergiVarmeToolStrip"
        Me.EnergiVarmeToolStrip.Size = New System.Drawing.Size(131, 24)
        Me.EnergiVarmeToolStrip.Text = "Energi og Varme"
        '
        'Panel_KraftArbejde1
        '
        Me.Panel_KraftArbejde1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_KraftArbejde1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KraftArbejde1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_KraftArbejde1.Name = "Panel_KraftArbejde1"
        Me.Panel_KraftArbejde1.Size = New System.Drawing.Size(539, 364)
        Me.Panel_KraftArbejde1.TabIndex = 0
        '
        'FresToolStripMenuItem
        '
        Me.FresToolStripMenuItem.Name = "FresToolStripMenuItem"
        Me.FresToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.FresToolStripMenuItem.Text = "Fres = m * a"
        '
        'FresF1F2ToolStripMenuItem
        '
        Me.FresF1F2ToolStripMenuItem.Name = "FresF1F2ToolStripMenuItem"
        Me.FresF1F2ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.FresF1F2ToolStripMenuItem.Text = "Fres = F1 + F2"
        '
        'QCToolStripMenuItem
        '
        Me.QCToolStripMenuItem.Name = "QCToolStripMenuItem"
        Me.QCToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.QCToolStripMenuItem.Text = "Q = C * ∆T"
        '
        'Panel_KarftArbejde2
        '
        Me.Panel_KarftArbejde2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_KarftArbejde2.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KarftArbejde2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_KarftArbejde2.Name = "Panel_KarftArbejde2"
        Me.Panel_KarftArbejde2.Size = New System.Drawing.Size(539, 364)
        Me.Panel_KarftArbejde2.TabIndex = 1
        '
        'Panel_EnergiVarme
        '
        Me.Panel_EnergiVarme.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_EnergiVarme.Location = New System.Drawing.Point(0, -1)
        Me.Panel_EnergiVarme.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_EnergiVarme.Name = "Panel_EnergiVarme"
        Me.Panel_EnergiVarme.Size = New System.Drawing.Size(539, 364)
        Me.Panel_EnergiVarme.TabIndex = 4
        '
        'ElektricitetMagnatismeToolStripMenuItem
        '
        Me.ElektricitetMagnatismeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OhmsLovToolStripMenuItem})
        Me.ElektricitetMagnatismeToolStripMenuItem.Name = "ElektricitetMagnatismeToolStripMenuItem"
        Me.ElektricitetMagnatismeToolStripMenuItem.Size = New System.Drawing.Size(199, 24)
        Me.ElektricitetMagnatismeToolStripMenuItem.Text = "Elektricitet og Magnatisme"
        '
        'OhmsLovToolStripMenuItem
        '
        Me.OhmsLovToolStripMenuItem.Name = "OhmsLovToolStripMenuItem"
        Me.OhmsLovToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.OhmsLovToolStripMenuItem.Text = "U = R * I"
        '
        'Panel_ElektricitetMagnatisme
        '
        Me.Panel_ElektricitetMagnatisme.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_ElektricitetMagnatisme.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ElektricitetMagnatisme.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_ElektricitetMagnatisme.Name = "Panel_ElektricitetMagnatisme"
        Me.Panel_ElektricitetMagnatisme.Size = New System.Drawing.Size(539, 364)
        Me.Panel_ElektricitetMagnatisme.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 362)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel_start)
        Me.Controls.Add(Me.Panel_KraftArbejde1)
        Me.Controls.Add(Me.Panel_KarftArbejde2)
        Me.Controls.Add(Me.Panel_EnergiVarme)
        Me.Controls.Add(Me.Panel_ElektricitetMagnatisme)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel_start.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents New_Window_opener As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_start As Panel
    Friend WithEvents Panel_KraftArbejde1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KraftArbejdeToolStrip As ToolStripMenuItem
    Friend WithEvents EnergiVarmeToolStrip As ToolStripMenuItem
    Friend WithEvents FresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FresF1F2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_KarftArbejde2 As Panel
    Friend WithEvents Panel_EnergiVarme As Panel
    Friend WithEvents ElektricitetMagnatismeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OhmsLovToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_ElektricitetMagnatisme As Panel
End Class
