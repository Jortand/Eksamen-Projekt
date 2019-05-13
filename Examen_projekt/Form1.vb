Public Class Form1
    Dim FirstNumber As Decimal
    Dim SencondNumber As Decimal
    Dim Operations As Integer
    Dim Operator_selector As Boolean = False

    Dim tal1, tal2, tal3 As Decimal

    Private Sub Panel_start_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Lommeregner.Paint


    End Sub

    Private Sub LommeregnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LommeregnerToolStripMenuItem.Click
        Panel_Lommeregner.Visible = True
        Panel_KraftArbejde1.Visible = False
        Panel_KraftArbejde2.Visible = False
        Panel_EnergiVarme1.Visible = False
        Panel_ElektricitetMagnatisme1.Visible = False
    End Sub

    'Dette er for Fres = F1 + F2
    Private Sub KraftArbejde1_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KraftArbejde1_ToolStripMenuItem.Click
        Panel_Lommeregner.Visible = False
        Panel_KraftArbejde1.Visible = True
        Panel_KraftArbejde2.Visible = False
        Panel_EnergiVarme1.Visible = False
        Panel_ElektricitetMagnatisme1.Visible = False
    End Sub
    Private Sub KraftArbejde1_Button_Beregn_Click(sender As Object, e As EventArgs) Handles KraftArbejde1_Button_Beregn.Click
        If Len(KraftArbejde1_Textbox_Fres.Text) < 1 And Len(KraftArbejde1_Textbox_F1.Text) > 0 And Len(KraftArbejde1_Textbox_F1.Text) > 0 Then
            tal1 = CDec(KraftArbejde1_Textbox_F1.Text)
            tal2 = CDec(KraftArbejde1_Textbox_F2.Text)
            tal3 = tal1 + tal2
            KraftArbejde1_Textbox_Fres.Text = tal3
            KraftArbejde1_Label_Resultat.Text = "Fres er " & Format(tal3, "0.00")
        ElseIf Len(KraftArbejde1_Textbox_F2.Text) < 1 And Len(KraftArbejde1_Textbox_F1.Text) > 0 And Len(KraftArbejde1_Textbox_Fres.Text) > 0 Then
            tal1 = CDec(KraftArbejde1_Textbox_F1.Text)
            tal3 = CDec(KraftArbejde1_Textbox_Fres.Text)
            tal2 = tal1 - tal3
            KraftArbejde1_Textbox_F2.Text = tal2
            KraftArbejde1_Label_Resultat.Text = "F2 er " & Format(tal2, "0.00")
        ElseIf Len(KraftArbejde1_Textbox_F1.Text) < 1 And Len(KraftArbejde1_Textbox_Fres.Text) > 0 And Len(KraftArbejde1_Textbox_F2.Text) > 0 Then
            tal2 = CDec(KraftArbejde1_Textbox_F2.Text)
            tal3 = CDec(KraftArbejde1_Textbox_Fres.Text)
            tal1 = tal3 - tal2
            KraftArbejde1_Textbox_F1.Text = tal1
            KraftArbejde1_Label_Resultat.Text = "F1 er " & Format(tal1, "0.00")
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
        Panel_Lommeregner.Visible = False
        Panel_KraftArbejde1.Visible = False
        Panel_KraftArbejde2.Visible = True
        Panel_EnergiVarme1.Visible = False
        Panel_ElektricitetMagnatisme1.Visible = False
    End Sub
    Private Sub KraftArbejde2_Button_Beregn_Click(sender As Object, e As EventArgs) Handles KraftArbejde2_Button_Beregn.Click
        If Len(KraftArbejde2_Textbox_Fres.Text) < 1 And Len(KraftArbejde2_Textbox_a.Text) > 0 And Len(KraftArbejde2_Textbox_m.Text) > 0 Then
            tal1 = CDec(KraftArbejde2_Textbox_a.Text)
            tal2 = CDec(KraftArbejde2_Textbox_m.Text)
            tal3 = tal1 * tal2
            KraftArbejde2_Label_Resultat.Text = "Fres er " & Format(tal3, "0.00")

        ElseIf Len(KraftArbejde2_Textbox_a.Text) < 1 And Len(KraftArbejde2_Textbox_m.Text) > 0 And Len(KraftArbejde2_Textbox_Fres.Text) > 0 Then
            tal2 = CDec(KraftArbejde2_Textbox_m.Text)
            tal3 = CDec(KraftArbejde2_Textbox_Fres.Text)
            tal1 = tal2 / tal3
            KraftArbejde2_Label_Resultat.Text = "a er " & Format(tal1, "0.00")


        ElseIf Len(KraftArbejde2_Textbox_m.Text) < 1 And Len(KraftArbejde2_Textbox_a.Text) > 0 And Len(KraftArbejde2_Textbox_Fres.Text) > 0 Then
            tal1 = CDec(KraftArbejde2_Textbox_a.Text)
            tal3 = CDec(KraftArbejde2_Textbox_Fres.Text)
            tal2 = tal1 / tal3
            KraftArbejde2_Label_Resultat.Text = "m er " & Format(tal2, "0.00")
        End If
        tal1 = 0
        tal2 = 0
        tal3 = 0
    End Sub
    Private Sub KraftArbejde2_Button_Clear_Click(sender As Object, e As EventArgs) Handles KraftArbejde2_Button_Clear.Click
        KraftArbejde2_Textbox_m.Text = ""
        KraftArbejde2_Textbox_a.Text = ""
        KraftArbejde2_Textbox_Fres.Text = ""
        KraftArbejde2_Label_Resultat.Text = ""
    End Sub

    'Dette er for Q = C * ∆T
    Private Sub EnergiVarme1_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnergiVarme1_ToolStripMenuItem.Click
        Panel_Lommeregner.Visible = False
        Panel_KraftArbejde1.Visible = False
        Panel_KraftArbejde2.Visible = False
        Panel_EnergiVarme1.Visible = True
        Panel_ElektricitetMagnatisme1.Visible = False
    End Sub
    Private Sub EnergiVarme1_Button_Beregn_Click(sender As Object, e As EventArgs) Handles EnergiVarme1_Button_Beregn.Click
        If Len(EnergiVarme1_Textbox_Q.Text) < 1 And Len(EnergiVarme1_Textbox_C.Text) > 0 And Len(EnergiVarme1_Textbox_T.Text) > 0 Then
            tal1 = CDec(EnergiVarme1_Textbox_C.Text)
            tal2 = CDec(EnergiVarme1_Textbox_T.Text)
            tal3 = tal1 * tal2
            EnergiVarme1_Label_Resultat.Text = "Q er " & Format(tal3, "0.00")

        ElseIf Len(EnergiVarme1_Textbox_C.Text) < 1 And Len(EnergiVarme1_Textbox_T.Text) > 0 And Len(EnergiVarme1_Textbox_Q.Text) > 0 Then
            tal2 = CDec(EnergiVarme1_Textbox_T.Text)
            tal3 = CDec(EnergiVarme1_Textbox_Q.Text)
            tal1 = tal2 / tal3
            EnergiVarme1_Label_Resultat.Text = "C er " & Format(tal1, "0.00")

        ElseIf Len(EnergiVarme1_Textbox_T.Text) < 1 And Len(EnergiVarme1_Textbox_C.Text) > 0 And Len(EnergiVarme1_Textbox_Q.Text) > 0 Then
            tal1 = CDec(EnergiVarme1_Textbox_C.Text)
            tal3 = CDec(EnergiVarme1_Textbox_Q.Text)
            tal2 = tal1 / tal3
            EnergiVarme1_Label_Resultat.Text = "∆T er " & Format(tal2, "0.00")
        End If
        tal1 = 0
        tal2 = 0
        tal3 = 0
    End Sub
    Private Sub EnergiVarme1_Button_Clear_Click(sender As Object, e As EventArgs) Handles EnergiVarme1_Button_Clear.Click
        EnergiVarme1_Textbox_C.Text = ""
        EnergiVarme1_Textbox_T.Text = ""
        EnergiVarme1_Textbox_Q.Text = ""
        EnergiVarme1_Label_Resultat.Text = ""
    End Sub

    'Dette er for U = R * I
    Private Sub ElekticitetMagnatisme1_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElektricitetMagnatisme1_ToolStripMenuItem.Click
        Panel_Lommeregner.Visible = False
        Panel_KraftArbejde1.Visible = False
        Panel_KraftArbejde2.Visible = False
        Panel_EnergiVarme1.Visible = False
        Panel_ElektricitetMagnatisme1.Visible = True
    End Sub
    Private Sub ElektricitetMagnatisme1_Button_Beregn_Click(sender As Object, e As EventArgs) Handles ElektricitetMagnatisme1_Button_Beregn.Click
        If Len(ElektricitetMagnatisme1_Textbox_U.Text) < 1 And Len(ElektricitetMagnatisme1_Textbox_R.Text) > 0 And Len(ElektricitetMagnatisme1_Textbox_I.Text) > 0 Then
            tal1 = CDec(ElektricitetMagnatisme1_Textbox_R.Text)
            tal2 = CDec(ElektricitetMagnatisme1_Textbox_I.Text)
            tal3 = tal1 * tal2
            ElektricitetMagnatisme1_Label_Resultat.Text = "U er " & Format(tal3, "0.00")

        ElseIf Len(ElektricitetMagnatisme1_Textbox_R.Text) < 1 And Len(ElektricitetMagnatisme1_Textbox_I.Text) > 0 And Len(ElektricitetMagnatisme1_Textbox_U.Text) > 0 Then
            tal2 = CDec(ElektricitetMagnatisme1_Textbox_I.Text)
            tal3 = CDec(ElektricitetMagnatisme1_Textbox_U.Text)
            tal1 = tal2 / tal3
            ElektricitetMagnatisme1_Label_Resultat.Text = "R er " & Format(tal1, "0.00")

        ElseIf Len(ElektricitetMagnatisme1_Textbox_I.Text) < 1 And Len(ElektricitetMagnatisme1_Textbox_R.Text) > 0 And Len(ElektricitetMagnatisme1_Textbox_U.Text) > 0 Then
            tal1 = CDec(ElektricitetMagnatisme1_Textbox_R.Text)
            tal3 = CDec(ElektricitetMagnatisme1_Textbox_I.Text)
            tal2 = tal1 / tal3
            ElektricitetMagnatisme1_Label_Resultat.Text = "I er " & Format(tal2, "0.00")
        End If
        tal1 = 0
        tal2 = 0
        tal3 = 0
    End Sub
    Private Sub ElektricitetMagnatisme1_Button_Clear_Click(sender As Object, e As EventArgs) Handles ElektricitetMagnatisme1_Button_Clear.Click
        ElektricitetMagnatisme1_Textbox_R.Text = ""
        ElektricitetMagnatisme1_Textbox_I.Text = ""
        ElektricitetMagnatisme1_Textbox_U.Text = ""
        ElektricitetMagnatisme1_Label_Resultat.Text = ""
    End Sub

End Class
