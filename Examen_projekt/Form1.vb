Public Class Form1
    Dim tal As Integer
    Dim resultat As Double
    Dim tal1, tal2, tal3 As Decimal

    Private Sub New_Window_opener_Click(sender As Object, e As EventArgs) Handles New_Window_opener.Click
        TestForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_KraftArbejde1.Visible = True
        Panel_start.Visible = False
    End Sub

    Private Sub Panel_start_Paint(sender As Object, e As PaintEventArgs) Handles Panel_start.Paint



    End Sub

    'Dette er for Fres = F1 + F2
    Private Sub KraftArbejde1_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KraftArbejde1_ToolStripMenuItem.Click
        Panel_start.Visible = False
        Panel_KraftArbejde1.Visible = True
        Panel_KarftArbejde2.Visible = False
        Panel_EnergiVarme.Visible = False
        Panel_ElektricitetMagnatisme.Visible = False

    End Sub
    Private Sub KraftArbejde1_Button_Beregn_Click(sender As Object, e As EventArgs) Handles KraftArbejde1_Button_Beregn.Click
        If Len(KraftArbejde1_Textbox_Fres.Text) < 1 And Len(KraftArbejde1_Textbox_F1.Text) > 0 And Len(KraftArbejde1_Textbox_F1.Text) > 0 Then
            tal1 = CDec(KraftArbejde1_Textbox_F1.Text)
            tal2 = CDec(KraftArbejde1_Textbox_F2.Text)
            tal3 = tal1 + tal2
            KraftArbejde1_Textbox_Fres.Text = tal3
            KraftArbejde1_Label_Resultat.Text = "Fres er " & tal3
        ElseIf Len(KraftArbejde1_Textbox_F2.Text) < 1 And Len(KraftArbejde1_Textbox_F1.Text) > 0 And Len(KraftArbejde1_Textbox_Fres.Text) > 0 Then
            tal1 = CDec(KraftArbejde1_Textbox_F1.Text)
            tal3 = CDec(KraftArbejde1_Textbox_Fres.Text)
            tal2 = tal1 - tal3
            KraftArbejde1_Textbox_F2.Text = tal2
            KraftArbejde1_Label_Resultat.Text = "F2 er " & tal2
        ElseIf Len(KraftArbejde1_Textbox_F1.Text) < 1 And Len(KraftArbejde1_Textbox_Fres.Text) > 0 And Len(KraftArbejde1_Textbox_F2.Text) > 0 Then
            tal2 = CDec(KraftArbejde1_Textbox_F2.Text)
            tal3 = CDec(KraftArbejde1_Textbox_Fres.Text)
            tal1 = tal3 - tal2
            KraftArbejde1_Textbox_F1.Text = tal1
            KraftArbejde1_Label_Resultat.Text = "F1 er " & tal1
        End If

        tal1 = 0
        tal2 = 0
        tal3 = 0
    End Sub
    Private Sub KraftArbejde1_Button_Clear_Click(sender As Object, e As EventArgs) Handles KraftArbejde1_Button_Clear.Click
        KraftArbejde1_Textbox_F1.Text = ""
        KraftArbejde1_Textbox_F2.Text = ""
        KraftArbejde1_Textbox_Fres.Text = ""
        KraftArbejde1_Label_Resultat.Text = ""

    End Sub

    'Dette er for Fres = M * A
    Private Sub KraftArbejde2_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KraftArbejde2_ToolStripMenuItem.Click
        Panel_start.Visible = False
        Panel_KraftArbejde1.Visible = False
        Panel_KarftArbejde2.Visible = True
        Panel_EnergiVarme.Visible = False
        Panel_ElektricitetMagnatisme.Visible = False

    End Sub

    Private Sub QCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QCToolStripMenuItem.Click
        Panel_start.Visible = False
        Panel_KraftArbejde1.Visible = False
        Panel_KarftArbejde2.Visible = False
        Panel_EnergiVarme.Visible = True
        Panel_ElektricitetMagnatisme.Visible = False

    End Sub
    Private Sub OhmsLovToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OhmsLovToolStripMenuItem.Click
        Panel_start.Visible = False
        Panel_KraftArbejde1.Visible = False
        Panel_KarftArbejde2.Visible = False
        Panel_EnergiVarme.Visible = False
        Panel_ElektricitetMagnatisme.Visible = True

    End Sub



End Class
