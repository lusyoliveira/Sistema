﻿Imports OficinaMecanica
Imports Padaria
Imports ProjetoLocadora
Imports ProjetoBanco
Public Class frmModulos
    Private Sub btnOficina_Click(sender As Object, e As EventArgs) Handles btnOficina.Click
        Dim janela As New OficinaMecanica.frmPrincipal()
        janela.Show()
    End Sub

    Private Sub btnPadaria_Click(sender As Object, e As EventArgs) Handles btnPadaria.Click
        Dim janela As New Padaria.frmPrincipal()
        janela.Show()
    End Sub

    Private Sub btnLocadora_Click(sender As Object, e As EventArgs) Handles btnLocadora.Click
        Dim janela As New ProjetoLocadora.frmPrincipal()
        janela.Show()
    End Sub

    Private Sub btnBanco_Click(sender As Object, e As EventArgs) Handles btnBanco.Click
        Dim janela As New ProjetoBanco.frmPrincipal()
        janela.Show()
    End Sub


End Class
