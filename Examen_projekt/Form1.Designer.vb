<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.New_Window_opener = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel_start = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KraftArbejdeToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.KraftArbejde1_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KraftArbejde2_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergiVarmeToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.QCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElektricitetMagnatismeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OhmsLovToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_KraftArbejde1 = New System.Windows.Forms.Panel()
        Me.KraftArbejde1_Button_Clear = New System.Windows.Forms.Button()
        Me.KraftArbejde1_Label_Fres = New System.Windows.Forms.Label()
        Me.KraftArbejde1_Label_F2 = New System.Windows.Forms.Label()
        Me.KraftArbejde1_Label_F1 = New System.Windows.Forms.Label()
        Me.KraftArbejde1_Label_Resultat = New System.Windows.Forms.Label()
        Me.KraftArbejde1_Button_Beregn = New System.Windows.Forms.Button()
        Me.KraftArbejde1_Textbox_Fres = New System.Windows.Forms.TextBox()
        Me.KraftArbejde1_Textbox_F2 = New System.Windows.Forms.TextBox()
        Me.KraftArbejde1_Textbox_F1 = New System.Windows.Forms.TextBox()
        Me.KraftArbejde1_Label_Formel = New System.Windows.Forms.Label()
        Me.Panel_KarftArbejde2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_EnergiVarme = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_ElektricitetMagnatisme = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KraftArbejde1_ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.KraftArbejde2_Button_Beregn = New System.Windows.Forms.Button()
        Me.Panel_start.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_KraftArbejde1.SuspendLayout()
        Me.Panel_KarftArbejde2.SuspendLayout()
        Me.Panel_EnergiVarme.SuspendLayout()
        Me.Panel_ElektricitetMagnatisme.SuspendLayout()
        Me.SuspendLayout()
        '
        'New_Window_opener
        '
        Me.New_Window_opener.Location = New System.Drawing.Point(408, 214)
        Me.New_Window_opener.Margin = New System.Windows.Forms.Padding(4)
        Me.New_Window_opener.Name = "New_Window_opener"
        Me.New_Window_opener.Size = New System.Drawing.Size(149, 71)
        Me.New_Window_opener.TabIndex = 1
        Me.New_Window_opener.Text = "New Window"
        Me.New_Window_opener.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 212)
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
        Me.Panel_start.Location = New System.Drawing.Point(0, 4)
        Me.Panel_start.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_start.Name = "Panel_start"
        Me.Panel_start.Size = New System.Drawing.Size(795, 496)
        Me.Panel_start.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KraftArbejdeToolStrip, Me.EnergiVarmeToolStrip, Me.ElektricitetMagnatismeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KraftArbejdeToolStrip
        '
        Me.KraftArbejdeToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KraftArbejde1_ToolStripMenuItem, Me.KraftArbejde2_ToolStripMenuItem})
        Me.KraftArbejdeToolStrip.Name = "KraftArbejdeToolStrip"
        Me.KraftArbejdeToolStrip.Size = New System.Drawing.Size(130, 24)
        Me.KraftArbejdeToolStrip.Text = "Kraft og arbejde"
        '
        'KraftArbejde1_ToolStripMenuItem
        '
        Me.KraftArbejde1_ToolStripMenuItem.Name = "KraftArbejde1_ToolStripMenuItem"
        Me.KraftArbejde1_ToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.KraftArbejde1_ToolStripMenuItem.Text = "Fres = F1 + F2"
        '
        'KraftArbejde2_ToolStripMenuItem
        '
        Me.KraftArbejde2_ToolStripMenuItem.Name = "KraftArbejde2_ToolStripMenuItem"
        Me.KraftArbejde2_ToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.KraftArbejde2_ToolStripMenuItem.Text = "Fres = m * a"
        '
        'EnergiVarmeToolStrip
        '
        Me.EnergiVarmeToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QCToolStripMenuItem})
        Me.EnergiVarmeToolStrip.Name = "EnergiVarmeToolStrip"
        Me.EnergiVarmeToolStrip.Size = New System.Drawing.Size(131, 24)
        Me.EnergiVarmeToolStrip.Text = "Energi og Varme"
        '
        'QCToolStripMenuItem
        '
        Me.QCToolStripMenuItem.Name = "QCToolStripMenuItem"
        Me.QCToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.QCToolStripMenuItem.Text = "Q = C * ∆T"
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
        Me.OhmsLovToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.OhmsLovToolStripMenuItem.Text = "U = R * I"
        '
        'Panel_KraftArbejde1
        '
        Me.Panel_KraftArbejde1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Button_Clear)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Label_Fres)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Label_F2)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Label_F1)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Label_Resultat)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Button_Beregn)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Textbox_Fres)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Textbox_F2)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Textbox_F1)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Label_Formel)
        Me.Panel_KraftArbejde1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KraftArbejde1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_KraftArbejde1.Name = "Panel_KraftArbejde1"
        Me.Panel_KraftArbejde1.Size = New System.Drawing.Size(795, 500)
        Me.Panel_KraftArbejde1.TabIndex = 0
        '
        'KraftArbejde1_Button_Clear
        '
        Me.KraftArbejde1_Button_Clear.Location = New System.Drawing.Point(585, 228)
        Me.KraftArbejde1_Button_Clear.Name = "KraftArbejde1_Button_Clear"
        Me.KraftArbejde1_Button_Clear.Size = New System.Drawing.Size(160, 61)
        Me.KraftArbejde1_Button_Clear.TabIndex = 11
        Me.KraftArbejde1_Button_Clear.Text = "Clear"
        Me.KraftArbejde1_Button_Clear.UseVisualStyleBackColor = True
        '
        'KraftArbejde1_Label_Fres
        '
        Me.KraftArbejde1_Label_Fres.AutoSize = True
        Me.KraftArbejde1_Label_Fres.Location = New System.Drawing.Point(69, 267)
        Me.KraftArbejde1_Label_Fres.Name = "KraftArbejde1_Label_Fres"
        Me.KraftArbejde1_Label_Fres.Size = New System.Drawing.Size(36, 17)
        Me.KraftArbejde1_Label_Fres.TabIndex = 10
        Me.KraftArbejde1_Label_Fres.Text = "Fres"
        '
        'KraftArbejde1_Label_F2
        '
        Me.KraftArbejde1_Label_F2.AutoSize = True
        Me.KraftArbejde1_Label_F2.Location = New System.Drawing.Point(81, 219)
        Me.KraftArbejde1_Label_F2.Name = "KraftArbejde1_Label_F2"
        Me.KraftArbejde1_Label_F2.Size = New System.Drawing.Size(24, 17)
        Me.KraftArbejde1_Label_F2.TabIndex = 9
        Me.KraftArbejde1_Label_F2.Text = "F2"
        '
        'KraftArbejde1_Label_F1
        '
        Me.KraftArbejde1_Label_F1.AutoSize = True
        Me.KraftArbejde1_Label_F1.Location = New System.Drawing.Point(81, 171)
        Me.KraftArbejde1_Label_F1.Name = "KraftArbejde1_Label_F1"
        Me.KraftArbejde1_Label_F1.Size = New System.Drawing.Size(24, 17)
        Me.KraftArbejde1_Label_F1.TabIndex = 8
        Me.KraftArbejde1_Label_F1.Text = "F1"
        '
        'KraftArbejde1_Label_Resultat
        '
        Me.KraftArbejde1_Label_Resultat.AutoSize = True
        Me.KraftArbejde1_Label_Resultat.Location = New System.Drawing.Point(313, 221)
        Me.KraftArbejde1_Label_Resultat.Name = "KraftArbejde1_Label_Resultat"
        Me.KraftArbejde1_Label_Resultat.Size = New System.Drawing.Size(0, 17)
        Me.KraftArbejde1_Label_Resultat.TabIndex = 7
        '
        'KraftArbejde1_Button_Beregn
        '
        Me.KraftArbejde1_Button_Beregn.Location = New System.Drawing.Point(585, 160)
        Me.KraftArbejde1_Button_Beregn.Margin = New System.Windows.Forms.Padding(4)
        Me.KraftArbejde1_Button_Beregn.Name = "KraftArbejde1_Button_Beregn"
        Me.KraftArbejde1_Button_Beregn.Size = New System.Drawing.Size(160, 61)
        Me.KraftArbejde1_Button_Beregn.TabIndex = 6
        Me.KraftArbejde1_Button_Beregn.Text = "Beregn"
        Me.KraftArbejde1_Button_Beregn.UseVisualStyleBackColor = True
        '
        'KraftArbejde1_Textbox_Fres
        '
        Me.KraftArbejde1_Textbox_Fres.Location = New System.Drawing.Point(112, 267)
        Me.KraftArbejde1_Textbox_Fres.Margin = New System.Windows.Forms.Padding(4)
        Me.KraftArbejde1_Textbox_Fres.Name = "KraftArbejde1_Textbox_Fres"
        Me.KraftArbejde1_Textbox_Fres.Size = New System.Drawing.Size(132, 22)
        Me.KraftArbejde1_Textbox_Fres.TabIndex = 3
        '
        'KraftArbejde1_Textbox_F2
        '
        Me.KraftArbejde1_Textbox_F2.Location = New System.Drawing.Point(112, 216)
        Me.KraftArbejde1_Textbox_F2.Margin = New System.Windows.Forms.Padding(4)
        Me.KraftArbejde1_Textbox_F2.Name = "KraftArbejde1_Textbox_F2"
        Me.KraftArbejde1_Textbox_F2.Size = New System.Drawing.Size(132, 22)
        Me.KraftArbejde1_Textbox_F2.TabIndex = 2
        '
        'KraftArbejde1_Textbox_F1
        '
        Me.KraftArbejde1_Textbox_F1.Location = New System.Drawing.Point(112, 168)
        Me.KraftArbejde1_Textbox_F1.Margin = New System.Windows.Forms.Padding(4)
        Me.KraftArbejde1_Textbox_F1.Name = "KraftArbejde1_Textbox_F1"
        Me.KraftArbejde1_Textbox_F1.Size = New System.Drawing.Size(132, 22)
        Me.KraftArbejde1_Textbox_F1.TabIndex = 1
        '
        'KraftArbejde1_Label_Formel
        '
        Me.KraftArbejde1_Label_Formel.AutoSize = True
        Me.KraftArbejde1_Label_Formel.Location = New System.Drawing.Point(292, 96)
        Me.KraftArbejde1_Label_Formel.Name = "KraftArbejde1_Label_Formel"
        Me.KraftArbejde1_Label_Formel.Size = New System.Drawing.Size(100, 17)
        Me.KraftArbejde1_Label_Formel.TabIndex = 0
        Me.KraftArbejde1_Label_Formel.Text = "F1 + F2 = Fres"
        '
        'Panel_KarftArbejde2
        '
        Me.Panel_KarftArbejde2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_KarftArbejde2.Controls.Add(Me.KraftArbejde2_Button_Beregn)
        Me.Panel_KarftArbejde2.Controls.Add(Me.Label2)
        Me.Panel_KarftArbejde2.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KarftArbejde2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_KarftArbejde2.Name = "Panel_KarftArbejde2"
        Me.Panel_KarftArbejde2.Size = New System.Drawing.Size(795, 500)
        Me.Panel_KarftArbejde2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fres = m * a"
        '
        'Panel_EnergiVarme
        '
        Me.Panel_EnergiVarme.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_EnergiVarme.Controls.Add(Me.Label3)
        Me.Panel_EnergiVarme.Location = New System.Drawing.Point(0, -1)
        Me.Panel_EnergiVarme.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_EnergiVarme.Name = "Panel_EnergiVarme"
        Me.Panel_EnergiVarme.Size = New System.Drawing.Size(795, 501)
        Me.Panel_EnergiVarme.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Q = C * ∆T"
        '
        'Panel_ElektricitetMagnatisme
        '
        Me.Panel_ElektricitetMagnatisme.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_ElektricitetMagnatisme.Controls.Add(Me.Label4)
        Me.Panel_ElektricitetMagnatisme.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ElektricitetMagnatisme.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_ElektricitetMagnatisme.Name = "Panel_ElektricitetMagnatisme"
        Me.Panel_ElektricitetMagnatisme.Size = New System.Drawing.Size(795, 500)
        Me.Panel_ElektricitetMagnatisme.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "U = R * I"
        '
        'KraftArbejde1_ImageList
        '
        Me.KraftArbejde1_ImageList.ImageStream = CType(resources.GetObject("KraftArbejde1_ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.KraftArbejde1_ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.KraftArbejde1_ImageList.Images.SetKeyName(0, "3_-_Basic_UI_Glyph_Black-4-512.png")
        Me.KraftArbejde1_ImageList.Images.SetKeyName(1, "free-png-plus-sign-plus-icon-512.png")
        '
        'KraftArbejde2_Button_Beregn
        '
        Me.KraftArbejde2_Button_Beregn.Location = New System.Drawing.Point(611, 228)
        Me.KraftArbejde2_Button_Beregn.Name = "KraftArbejde2_Button_Beregn"
        Me.KraftArbejde2_Button_Beregn.Size = New System.Drawing.Size(120, 56)
        Me.KraftArbejde2_Button_Beregn.TabIndex = 1
        Me.KraftArbejde2_Button_Beregn.Text = "Beregn"
        Me.KraftArbejde2_Button_Beregn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 500)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel_KarftArbejde2)
        Me.Controls.Add(Me.Panel_start)
        Me.Controls.Add(Me.Panel_KraftArbejde1)
        Me.Controls.Add(Me.Panel_EnergiVarme)
        Me.Controls.Add(Me.Panel_ElektricitetMagnatisme)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel_start.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_KraftArbejde1.ResumeLayout(False)
        Me.Panel_KraftArbejde1.PerformLayout()
        Me.Panel_KarftArbejde2.ResumeLayout(False)
        Me.Panel_KarftArbejde2.PerformLayout()
        Me.Panel_EnergiVarme.ResumeLayout(False)
        Me.Panel_EnergiVarme.PerformLayout()
        Me.Panel_ElektricitetMagnatisme.ResumeLayout(False)
        Me.Panel_ElektricitetMagnatisme.PerformLayout()
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
    Friend WithEvents KraftArbejde2_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KraftArbejde1_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_KarftArbejde2 As Panel
    Friend WithEvents Panel_EnergiVarme As Panel
    Friend WithEvents ElektricitetMagnatismeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OhmsLovToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_ElektricitetMagnatisme As Panel
    Friend WithEvents KraftArbejde1_Label_Formel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents KraftArbejde1_Textbox_Fres As TextBox
    Friend WithEvents KraftArbejde1_Textbox_F2 As TextBox
    Friend WithEvents KraftArbejde1_Textbox_F1 As TextBox
    Friend WithEvents KraftArbejde1_Button_Beregn As Button
    Friend WithEvents KraftArbejde1_ImageList As ImageList
    Friend WithEvents KraftArbejde1_Label_Resultat As Label
    Friend WithEvents KraftArbejde1_Label_Fres As Label
    Friend WithEvents KraftArbejde1_Label_F2 As Label
    Friend WithEvents KraftArbejde1_Label_F1 As Label
    Friend WithEvents KraftArbejde1_Button_Clear As Button
    Friend WithEvents KraftArbejde2_Button_Beregn As Button
End Class
