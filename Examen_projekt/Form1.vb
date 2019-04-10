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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KraftArbejdeToolStrip.Click
        TestForm.Show()
    End Sub
End Class
