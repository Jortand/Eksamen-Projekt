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
        Me.FresF1F2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FresMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnergiVarmeToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.QCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElektricitetMagnatismeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OhmsLovToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_KraftArbejde1 = New System.Windows.Forms.Panel()
        Me.KraftArbejde1_Button_Beregn = New System.Windows.Forms.Button()
        Me.KraftArbejde1_PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.KraftArbejde1_PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KraftArbejde1_Textbox_Fres = New System.Windows.Forms.TextBox()
        Me.KraftArbejde1_Textbox_F2 = New System.Windows.Forms.TextBox()
        Me.KraftArbejde1_Textbox_F1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_KarftArbejde2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_EnergiVarme = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_ElektricitetMagnatisme = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KraftArbejde1_ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel_start.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_KraftArbejde1.SuspendLayout()
        CType(Me.KraftArbejde1_PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KraftArbejde1_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_KarftArbejde2.SuspendLayout()
        Me.Panel_EnergiVarme.SuspendLayout()
        Me.Panel_ElektricitetMagnatisme.SuspendLayout()
        Me.SuspendLayout()
        '
        'New_Window_opener
        '
        Me.New_Window_opener.Location = New System.Drawing.Point(306, 174)
        Me.New_Window_opener.Name = "New_Window_opener"
        Me.New_Window_opener.Size = New System.Drawing.Size(112, 58)
        Me.New_Window_opener.TabIndex = 1
        Me.New_Window_opener.Text = "New Window"
        Me.New_Window_opener.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 172)
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
        Me.Panel_start.Location = New System.Drawing.Point(0, 3)
        Me.Panel_start.Name = "Panel_start"
        Me.Panel_start.Size = New System.Drawing.Size(596, 403)
        Me.Panel_start.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KraftArbejdeToolStrip, Me.EnergiVarmeToolStrip, Me.ElektricitetMagnatismeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KraftArbejdeToolStrip
        '
        Me.KraftArbejdeToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FresF1F2ToolStripMenuItem, Me.FresMAToolStripMenuItem})
        Me.KraftArbejdeToolStrip.Name = "KraftArbejdeToolStrip"
        Me.KraftArbejdeToolStrip.Size = New System.Drawing.Size(103, 20)
        Me.KraftArbejdeToolStrip.Text = "Kraft og arbejde"
        '
        'FresF1F2ToolStripMenuItem
        '
        Me.FresF1F2ToolStripMenuItem.Name = "FresF1F2ToolStripMenuItem"
        Me.FresF1F2ToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.FresF1F2ToolStripMenuItem.Text = "Fres = F1 + F2"
        '
        'FresMAToolStripMenuItem
        '
        Me.FresMAToolStripMenuItem.Name = "FresMAToolStripMenuItem"
        Me.FresMAToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.FresMAToolStripMenuItem.Text = "Fres = m * a"
        '
        'EnergiVarmeToolStrip
        '
        Me.EnergiVarmeToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QCToolStripMenuItem})
        Me.EnergiVarmeToolStrip.Name = "EnergiVarmeToolStrip"
        Me.EnergiVarmeToolStrip.Size = New System.Drawing.Size(106, 20)
        Me.EnergiVarmeToolStrip.Text = "Energi og Varme"
        '
        'QCToolStripMenuItem
        '
        Me.QCToolStripMenuItem.Name = "QCToolStripMenuItem"
        Me.QCToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.QCToolStripMenuItem.Text = "Q = C * ∆T"
        '
        'ElektricitetMagnatismeToolStripMenuItem
        '
        Me.ElektricitetMagnatismeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OhmsLovToolStripMenuItem})
        Me.ElektricitetMagnatismeToolStripMenuItem.Name = "ElektricitetMagnatismeToolStripMenuItem"
        Me.ElektricitetMagnatismeToolStripMenuItem.Size = New System.Drawing.Size(160, 20)
        Me.ElektricitetMagnatismeToolStripMenuItem.Text = "Elektricitet og Magnatisme"
        '
        'OhmsLovToolStripMenuItem
        '
        Me.OhmsLovToolStripMenuItem.Name = "OhmsLovToolStripMenuItem"
        Me.OhmsLovToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.OhmsLovToolStripMenuItem.Text = "U = R * I"
        '
        'Panel_KraftArbejde1
        '
        Me.Panel_KraftArbejde1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Button_Beregn)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_PictureBox2)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_PictureBox1)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Textbox_Fres)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Textbox_F2)
        Me.Panel_KraftArbejde1.Controls.Add(Me.KraftArbejde1_Textbox_F1)
        Me.Panel_KraftArbejde1.Controls.Add(Me.Label1)
        Me.Panel_KraftArbejde1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KraftArbejde1.Name = "Panel_KraftArbejde1"
        Me.Panel_KraftArbejde1.Size = New System.Drawing.Size(596, 406)
        Me.Panel_KraftArbejde1.TabIndex = 0
        '
        'KraftArbejde1_Button_Beregn
        '
        Me.KraftArbejde1_Button_Beregn.Location = New System.Drawing.Point(447, 177)
        Me.KraftArbejde1_Button_Beregn.Name = "KraftArbejde1_Button_Beregn"
        Me.KraftArbejde1_Button_Beregn.Size = New System.Drawing.Size(120, 43)
        Me.KraftArbejde1_Button_Beregn.TabIndex = 6
        Me.KraftArbejde1_Button_Beregn.Text = "Beregn"
        Me.KraftArbejde1_Button_Beregn.UseVisualStyleBackColor = True
        '
        'KraftArbejde1_PictureBox2
        '
        Me.KraftArbejde1_PictureBox2.Location = New System.Drawing.Point(292, 193)
        Me.KraftArbejde1_PictureBox2.Name = "KraftArbejde1_PictureBox2"
        Me.KraftArbejde1_PictureBox2.Size = New System.Drawing.Size(23, 22)
        Me.KraftArbejde1_PictureBox2.TabIndex = 5
        Me.KraftArbejde1_PictureBox2.TabStop = False
        '
        'KraftArbejde1_PictureBox1
        '
        Me.KraftArbejde1_PictureBox1.Location = New System.Drawing.Point(157, 195)
        Me.KraftArbejde1_PictureBox1.Name = "KraftArbejde1_PictureBox1"
        Me.KraftArbejde1_PictureBox1.Size = New System.Drawing.Size(23, 20)
        Me.KraftArbejde1_PictureBox1.TabIndex = 4
        Me.KraftArbejde1_PictureBox1.TabStop = False
        '
        'KraftArbejde1_Textbox_Fres
        '
        Me.KraftArbejde1_Textbox_Fres.Location = New System.Drawing.Point(321, 195)
        Me.KraftArbejde1_Textbox_Fres.Name = "KraftArbejde1_Textbox_Fres"
        Me.KraftArbejde1_Textbox_Fres.Size = New System.Drawing.Size(100, 20)
        Me.KraftArbejde1_Textbox_Fres.TabIndex = 3
        '
        'KraftArbejde1_Textbox_F2
        '
        Me.KraftArbejde1_Textbox_F2.Location = New System.Drawing.Point(186, 195)
        Me.KraftArbejde1_Textbox_F2.Name = "KraftArbejde1_Textbox_F2"
        Me.KraftArbejde1_Textbox_F2.Size = New System.Drawing.Size(100, 20)
        Me.KraftArbejde1_Textbox_F2.TabIndex = 2
        '
        'KraftArbejde1_Textbox_F1
        '
        Me.KraftArbejde1_Textbox_F1.Location = New System.Drawing.Point(50, 195)
        Me.KraftArbejde1_Textbox_F1.Name = "KraftArbejde1_Textbox_F1"
        Me.KraftArbejde1_Textbox_F1.Size = New System.Drawing.Size(100, 20)
        Me.KraftArbejde1_Textbox_F1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "F1 + F2 = Fres"
        '
        'Panel_KarftArbejde2
        '
        Me.Panel_KarftArbejde2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_KarftArbejde2.Controls.Add(Me.Label2)
        Me.Panel_KarftArbejde2.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KarftArbejde2.Name = "Panel_KarftArbejde2"
        Me.Panel_KarftArbejde2.Size = New System.Drawing.Size(596, 406)
        Me.Panel_KarftArbejde2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fres = m * a"
        '
        'Panel_EnergiVarme
        '
        Me.Panel_EnergiVarme.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_EnergiVarme.Controls.Add(Me.Label3)
        Me.Panel_EnergiVarme.Location = New System.Drawing.Point(0, -1)
        Me.Panel_EnergiVarme.Name = "Panel_EnergiVarme"
        Me.Panel_EnergiVarme.Size = New System.Drawing.Size(596, 407)
        Me.Panel_EnergiVarme.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Q = C * ∆T"
        '
        'Panel_ElektricitetMagnatisme
        '
        Me.Panel_ElektricitetMagnatisme.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_ElektricitetMagnatisme.Controls.Add(Me.Label4)
        Me.Panel_ElektricitetMagnatisme.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ElektricitetMagnatisme.Name = "Panel_ElektricitetMagnatisme"
        Me.Panel_ElektricitetMagnatisme.Size = New System.Drawing.Size(596, 406)
        Me.Panel_ElektricitetMagnatisme.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 406)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel_KraftArbejde1)
        Me.Controls.Add(Me.Panel_start)
        Me.Controls.Add(Me.Panel_KarftArbejde2)
        Me.Controls.Add(Me.Panel_EnergiVarme)
        Me.Controls.Add(Me.Panel_ElektricitetMagnatisme)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel_start.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_KraftArbejde1.ResumeLayout(False)
        Me.Panel_KraftArbejde1.PerformLayout()
        CType(Me.KraftArbejde1_PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KraftArbejde1_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FresMAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FresF1F2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_KarftArbejde2 As Panel
    Friend WithEvents Panel_EnergiVarme As Panel
    Friend WithEvents ElektricitetMagnatismeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OhmsLovToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_ElektricitetMagnatisme As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents KraftArbejde1_Textbox_Fres As TextBox
    Friend WithEvents KraftArbejde1_Textbox_F2 As TextBox
    Friend WithEvents KraftArbejde1_Textbox_F1 As TextBox
    Friend WithEvents KraftArbejde1_PictureBox2 As PictureBox
    Friend WithEvents KraftArbejde1_PictureBox1 As PictureBox
    Friend WithEvents KraftArbejde1_Button_Beregn As Button
    Friend WithEvents KraftArbejde1_ImageList As ImageList
End Class
