Public Class Form1
    Dim FirstNumber As Decimal
    Dim SecondNumber As Decimal
    Dim Operations As Integer
    Dim Operator_select As Boolean = False
    Dim tal1, tal2, tal3 As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'SecondNumber = 1
    End Sub
    Private Sub LommeregnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LommeregnerToolStripMenuItem.Click
        Panel_Lommeregner.Visible = True
        Panel_KraftArbejde1.Visible = False
        Panel_KraftArbejde2.Visible = False
        Panel_EnergiVarme1.Visible = False
        Panel_ElektricitetMagnatisme1.Visible = False
    End Sub
    Private Sub Lommeregner_0_Click(sender As Object, e As EventArgs) Handles Lommeregner_0.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "0"
        End If
    End Sub
    Private Sub Lommeregner_1_Click(sender As Object, e As EventArgs) Handles Lommeregner_1.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "1"
        Else
            Lommeregner_Textbox.Text = "1"
        End If
    End Sub
    Private Sub Lommeregner_2_Click(sender As Object, e As EventArgs) Handles Lommeregner_2.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "2"
        Else
            Lommeregner_Textbox.Text = "2"
        End If
    End Sub
    Private Sub Lommeregner_3_Click(sender As Object, e As EventArgs) Handles Lommeregner_3.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "3"
        Else
            Lommeregner_Textbox.Text = "3"
        End If
    End Sub
    Private Sub Lommeregner_4_Click(sender As Object, e As EventArgs) Handles Lommeregner_4.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "4"
        Else
            Lommeregner_Textbox.Text = "4"
        End If
    End Sub
    Private Sub Lommeregner_5_Click(sender As Object, e As EventArgs) Handles Lommeregner_5.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "5"
        Else
            Lommeregner_Textbox.Text = "5"
        End If
    End Sub
    Private Sub Lommeregner_6_Click(sender As Object, e As EventArgs) Handles Lommeregner_6.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "6"
        Else
            Lommeregner_Textbox.Text = "6"
        End If
    End Sub
    Private Sub Lommeregner_7_Click(sender As Object, e As EventArgs) Handles Lommeregner_7.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "7"
        Else
            Lommeregner_Textbox.Text = "7"
        End If
    End Sub
    Private Sub Lommeregner_8_Click(sender As Object, e As EventArgs) Handles Lommeregner_8.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "8"
        Else
            Lommeregner_Textbox.Text = "8"
        End If
    End Sub
    Private Sub Lommeregner_9_Click(sender As Object, e As EventArgs) Handles Lommeregner_9.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "9"
        Else
            Lommeregner_Textbox.Text = "9"
        End If
    End Sub
    Private Sub Lommeregner_point_Click(sender As Object, e As EventArgs) Handles Lommeregner_point.Click
        If Not (Lommeregner_Textbox.Text.Contains(".")) Then
            Lommeregner_Textbox.Text += "."
        End If
    End Sub
    Private Sub Lommeregner_add_Click(sender As Object, e As EventArgs) Handles Lommeregner_add.Click
        FirstNumber = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = "0"
        Operator_select = True
        Operations = 1
    End Sub
    Private Sub Lommeregner_minus_Click(sender As Object, e As EventArgs) Handles Lommeregner_minus.Click
        FirstNumber = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = "0"
        Operator_select = True
        Operations = 2
    End Sub
    Private Sub Lommeregner_multi_Click(sender As Object, e As EventArgs) Handles Lommeregner_multi.Click
        FirstNumber = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = "0"
        Operator_select = True
        Operations = 3
    End Sub
    Private Sub Lommeregner_divide_Click(sender As Object, e As EventArgs) Handles Lommeregner_divide.Click
        FirstNumber = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = "0"
        Operator_select = True
        Operations = 4
    End Sub
    Private Sub Lommeregner_equal_Click(sender As Object, e As EventArgs) Handles Lommeregner_equal.Click
        If Operator_select = True And Lommeregner_Textbox.Text > 0 Then
            SecondNumber = Lommeregner_Textbox.Text
            If Operations = 1 Then
                Lommeregner_Textbox.Text = FirstNumber + SecondNumber
            ElseIf Operations = 2 Then
                Lommeregner_Textbox.Text = FirstNumber - SecondNumber
            ElseIf Operations = 3 Then
                Lommeregner_Textbox.Text = FirstNumber * SecondNumber
            Else
                If SecondNumber = 0 Then
                    Lommeregner_Textbox.Text = "0"
                Else
                    Lommeregner_Textbox.Text = FirstNumber / SecondNumber
                End If
            End If
            Operator_select = False
        End If
    End Sub
    Private Sub Lommeregner_C_Click(sender As Object, e As EventArgs) Handles Lommeregner_C.Click
        Operator_select = False
        Lommeregner_Textbox.Text = "0"
    End Sub
    Private Sub Lommeregner_Procent_Click(sender As Object, e As EventArgs) Handles Lommeregner_Procent.Click
        FirstNumber = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = FirstNumber / 100
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
