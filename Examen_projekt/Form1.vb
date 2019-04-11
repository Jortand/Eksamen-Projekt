Public Class Form1
    Dim tal As Integer
    Dim resultat As Double

    Private Sub New_Window_opener_Click(sender As Object, e As EventArgs) Handles New_Window_opener.Click
        TestForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_KraftArbejde1.Visible = True
        Panel_start.Visible = False
    End Sub

    Private Sub Panel_start_Paint(sender As Object, e As PaintEventArgs) Handles Panel_start.Paint



    End Sub

    Private Sub FresF1F2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FresF1F2ToolStripMenuItem.Click
        Panel_start.Visible = False
        Panel_KraftArbejde1.Visible = True
        Panel_KarftArbejde2.Visible = False
        Panel_EnergiVarme.Visible = False
        Panel_ElektricitetMagnatisme.Visible = False

    End Sub
    Private Sub FresMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FresMAToolStripMenuItem.Click
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
