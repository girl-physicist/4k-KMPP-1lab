Public Class Form1
    'секция объявления переменных
    Dim number1, number2, result As Double
    'создаем перечисление математических операций
    Enum Operators
        Summ
        Subtraction
        Division
        Multiplication
    End Enum
    'при загрузке формы прячем кнопки
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
    End Sub
    'по нажатию на кнопку заносим значения из текстбоксов в переменные, при этом пытаемся преобразовать их из типа String в тип Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Try
                number1 = Double.Parse(TextBox1.Text)
            Catch ex As FormatException
                MsgBox("Enter correct value number1")
                Throw ex
            End Try
            Try
                number2 = Double.Parse(TextBox2.Text)
            Catch ex As FormatException
                MsgBox("Enter correct value number2")
                Throw ex
            End Try
        Catch ex As Exception
            Return
        End Try
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
    End Sub
    'создаем функцию расчета
    Private Function GetResult(param As Operators)
        Select Case param
            Case Operators.Summ
                result = number1 + number2
            Case Operators.Subtraction
                result = number1 - number2
            Case Operators.Division
                result = number1 / number2
            Case Operators.Multiplication
                result = number1 * number2
        End Select
        Return result
    End Function
    'создаем процедуру вывода результата
    Private Sub ShowResult()
        TextBox3.Text = result.ToString
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'вызываем функцию расчета, при этом передаем ей в качествае параметра первый пункт из перечисления Operators.Summ
        GetResult(Operators.Summ)
        'вызываем процедуру вывода результата
        ShowResult()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GetResult(Operators.Subtraction)
        ShowResult()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GetResult(Operators.Multiplication)
        ShowResult()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GetResult(Operators.Division)
        ShowResult()
    End Sub
End Class
