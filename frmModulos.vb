Imports Oficina_Mecânica
Imports Padaria
Imports Projeto_Locadora
Public Class frmModulos
    Private Sub btnOficina_Click(sender As Object, e As EventArgs) Handles btnOficina.Click
        Dim janela As New Oficina_Mecânica.frmPrincipal()
        janela.Show()
    End Sub

    Private Sub btnPadaria_Click(sender As Object, e As EventArgs) Handles btnPadaria.Click
        Dim janela As New Padaria.frmPrincipal()
        janela.Show()
    End Sub

    Private Sub btnLocadora_Click(sender As Object, e As EventArgs) Handles btnLocadora.Click
        Dim janela As New Projeto_Locadora.frmPrincipal()
        janela.Show()
    End Sub
End Class
