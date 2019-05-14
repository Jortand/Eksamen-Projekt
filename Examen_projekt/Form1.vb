Public Class Form1
    'Her sættes de variabler som vi skal bruge til Lommeregneren og Formel-Samlingen.
    Dim Numb1 As Decimal
    Dim Numb2 As Decimal
    Dim Action As Integer
    Dim ActionMade As Boolean = False

    Dim tal1, tal2, tal3 As Decimal

    Private Sub LommeregnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LommeregnerToolStripMenuItem.Click
        'Denne Subrutine bliver brugt for at holde styr på vores Panels vi bruger Panels for at få flere sider på samme Form. 
        'For at klikke imellem de forskellige Panels bruger vi en MenuStrip som altid ligger øverest i vores Document Outline 
        'sådan at brugeren nemt kan klikke sig rundt i programmet.
        'Denne måde at holde styr på Panels bliver brugt flere gange igennem programmet.
        Panel_Lommeregner.Visible = True
        Panel_KraftArbejde1.Visible = False
        Panel_KraftArbejde2.Visible = False
        Panel_EnergiVarme1.Visible = False
        Panel_ElektricitetMagnatisme1.Visible = False
    End Sub

    'Lommeregner starter her
    Private Sub Lommeregner_1_Click(sender As Object, e As EventArgs) Handles Lommeregner_1.Click
        'Denne Subrutine bliver brugt til at styre en tal knap på Lommeregneren
        'denne If sætning spørger om der i Textboxen ikke står talet 0 hvis dette er sandt indsætter koden et 1 i Textboxen
        'hvis der allerede er Tal i Textboxen vil det 1 blive sat bagerst 
        'Hvis denne If er forkert skriver koden 1 i Textboxen
        'Denne måde at skrive tal ind i Lommeregneren bliver brugt for alle tal fra 1 til 9 i dette program.
        'talet 0 er anderledes i at der er blevet taget "Else" ud da der allerede står 0 til at starte med men virker på samme princip
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
    Private Sub Lommeregner_0_Click(sender As Object, e As EventArgs) Handles Lommeregner_0.Click
        If Lommeregner_Textbox.Text <> "0" Then
            Lommeregner_Textbox.Text += "0"
        End If
    End Sub

    Private Sub Lommeregner_point_Click(sender As Object, e As EventArgs) Handles Lommeregner_point.Click
        'Denne Subrutine er brugt til at indskrive et , i lommeregneren
        'If Not sætningen spør om Textboxen allerede har et , hvis denne sættning er sand vil rutinen ikke gøre noget,
        'Hvis denne sætning er falsk vil koden indsætte et , ind i Textboxen
        'Vi bruger om Textboxen Contains et , fordi der kun kan være et , i en matematisk udregning så vi vil ikke have 
        'at man skal kunne indskrive mere end en.
        If Not Lommeregner_Textbox.Text.Contains(",") Then
            Lommeregner_Textbox.Text += ","
        End If
    End Sub
    Private Sub Lommeregner_add_Click(sender As Object, e As EventArgs) Handles Lommeregner_add.Click
        'Denne Subrutine er brugt til at + tal sammen
        'Først skriver programmet det der står i Textboxen ind i Numb1 jeg bruger Numb1 som et sted at holde på talet indtil jeg skal bruge det igen.
        'Herefter nulstilles Textboxen igen for at brugeren kan skrive nye tal ind
        'ActionMade bliver sat til True, jeg bruger denne Boolean for at checke længere nede i koden om et symbol som + - * eller / er bliver tykket
        'Action bliver sat til 1, jeg bruger integer Action for at bestemme imellem de forskellige symboler + har 1, - har 2 osv.
        'Denne måde at kode Symboler på bliver brugt til alle 4 symboler på Lommeregneren.
        Numb1 = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = "0"
        ActionMade = True
        Action = 1
    End Sub
    Private Sub Lommeregner_minus_Click(sender As Object, e As EventArgs) Handles Lommeregner_minus.Click
        Numb1 = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = "0"
        ActionMade = True
        Action = 2
    End Sub
    Private Sub Lommeregner_multi_Click(sender As Object, e As EventArgs) Handles Lommeregner_multi.Click
        Numb1 = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = "0"
        ActionMade = True
        Action = 3
    End Sub
    Private Sub Lommeregner_divide_Click(sender As Object, e As EventArgs) Handles Lommeregner_divide.Click
        Numb1 = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = "0"
        ActionMade = True
        Action = 4
    End Sub
    Private Sub Lommeregner_equal_Click(sender As Object, e As EventArgs) Handles Lommeregner_equal.Click
        'Denne Subrutine er for når = bliver trykket
        'Der bliver først spurt om ActionMade = True dette kan kun være True hvis et Symbol er bliver trykket før,
        'der bliver spurt om det som står i Textboxen er over 0, dette er for at fixe en bug med at dividere med 0 som ville så Programmet til at crashe.
        'Programmet skriver det tal som står i Textboxen over til Numb2 da Numb1 allerede er optaget af det tal som var før brugeren trykkede på et symbol
        'Herefter går Programmet igennem Action og spør hvad for et tal der matcher for at vide hvad for et symbol Brugeren har trykket
        'Resultatet af denne udregning bliver skrevet i Textboxen
        'Ved Dividere har det været nødventigt at lave et extra check for at Numb2 ikke bliver 0 da man ikke kan dividere med 0
        'Til sidste bliver ActionMade lavet til False for at = ikke kan blive trykket flere gange i træk uden at Brugeren trykket et nyt symbol.
        If ActionMade = True And Lommeregner_Textbox.Text > 0 Then
            Numb2 = Lommeregner_Textbox.Text
            If Action = 1 Then
                Lommeregner_Textbox.Text = Numb1 + Numb2
            ElseIf Action = 2 Then
                Lommeregner_Textbox.Text = Numb1 - Numb2
            ElseIf Action = 3 Then
                Lommeregner_Textbox.Text = Numb1 * Numb2
            Else
                If Numb2 = 0 Then
                    Lommeregner_Textbox.Text = "0"
                Else
                    Lommeregner_Textbox.Text = Numb1 / Numb2
                End If
            End If
            ActionMade = False
        End If
    End Sub
    Private Sub Lommeregner_C_Click(sender As Object, e As EventArgs) Handles Lommeregner_C.Click
        'Denne kode bliver brugt til C-knappen på Lommeregneren også kaldet Clear-knappen.
        'koden sætter ActionMade som er den Boolean som bliver brugt for at programet ved om et Symbol er bliver trykket.
        'Textboxen bliver sat til 0 for at nulstille Lommeregneren og den er klar til brug på ny.
        ActionMade = False
        Lommeregner_Textbox.Text = "0"
    End Sub
    Private Sub Lommeregner_Procent_Click(sender As Object, e As EventArgs) Handles Lommeregner_Procent.Click
        'Denne kode bliver brugt til nemt og hurtigt at lave et tal om til procent / decimaltal.
        'Det som står i Textboxen bliver skrevet over til Numb1.
        'Herefter bliver Numb1 divideret med 100 og resultatet bliver skrevet til Textboxen.
        Numb1 = Lommeregner_Textbox.Text
        Lommeregner_Textbox.Text = Numb1 / 100
    End Sub
    Private Sub Lommeregner_addorminus_Click(sender As Object, e As EventArgs) Handles Lommeregner_addorminus.Click
        'Denne kode er for at få et tal til at gå fra minus til plus og omvent.
        'Der bliver spurt om Textboxen ikke indeholder et - hvis dette er sandt bliver Textboxens indhold skrvet til Numb1.
        'Textboxen bliver så omskrevet til -numb1 for at få et - foran hvad der allerede stod i Textboxen.
        'hvis den første If er forkert bliver der spurt om Textboxen indeholder et - Hvis dette er sandt bliver Textboxens indhold skrevet til Numb1
        'Textboxen bliver så omskrevet til Numb1 + Numb1 * Numb1 for at få det der allerede stod i Textboxen som var i minus til at være plus
        If Not Lommeregner_Textbox.Text.Contains("-") Then
            Numb1 = Lommeregner_Textbox.Text
            Lommeregner_Textbox.Text = -Numb1
        ElseIf Lommeregner_Textbox.Text.Contains("-") Then
            Numb1 = Lommeregner_Textbox.Text
            Lommeregner_Textbox.Text = Numb1 + Numb1 * Numb1
        End If
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
