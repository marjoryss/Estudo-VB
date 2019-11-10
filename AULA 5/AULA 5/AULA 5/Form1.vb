Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Mostra uma caixa de mensagem para o usuario
        MessageBox.Show("Ola, " & txtName.Text & " Bem vindo ao Visual Basic 2015", "Mensagem ao usuario")

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Fim do programa
        Me.Close()
    End Sub
End Class
