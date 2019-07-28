

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim printerName As String
        printerName = "EPSON TM-T88V Receipt"
        PrintDocument1.PrinterSettings.PrinterName = printerName
        PrintDocument1.Print()

    End Sub



    Private Sub Till_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Till.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Note100_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Note100.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Note50_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Note50.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Note20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Note20.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Note5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Note5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Coin1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Coin1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Coin2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Coin2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Coin50_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Coin50.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Coin20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Coin20.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Coin10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Coin10.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Coin5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Coin5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Note10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Note10.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Note100_TextChanged(sender As Object, e As EventArgs) Handles Note100.TextChanged
        If Note100.Text <> "" Then
            Dim cash As Decimal = Note100.Text * 100
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub100.Text = cashDisplay
            GlobalVariables.n100 = cash
            Totaling()
        Else
            sub100.Text = "$0.00"
        End If
    End Sub
    Private Sub Note50_TextChanged(sender As Object, e As EventArgs) Handles Note50.TextChanged
        If Note50.Text <> "" Then
            Dim cash As Decimal = Note50.Text * 50
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub50.Text = cashDisplay
            GlobalVariables.n50 = cash
            Totaling()
        Else
            sub50.Text = "$0.00"
        End If
    End Sub
    Private Sub Note20_TextChanged(sender As Object, e As EventArgs) Handles Note20.TextChanged
        If Note20.Text <> "" Then
            Dim cash As Decimal = Note20.Text * 20
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub20.Text = cashDisplay
            GlobalVariables.n20 = cash
            Totaling()
        Else
            sub20.Text = "$0.00"
        End If
    End Sub
    Private Sub Note10_TextChanged(sender As Object, e As EventArgs) Handles Note10.TextChanged
        If Note10.Text <> "" Then
            Dim cash As Decimal = Note10.Text * 10
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub10.Text = cashDisplay
            GlobalVariables.n10 = cash
            Totaling()
        Else
            sub10.Text = "$0.00"
        End If
    End Sub
    Private Sub Note5_TextChanged(sender As Object, e As EventArgs) Handles Note5.TextChanged
        If Note5.Text <> "" Then
            Dim cash As Decimal = Note5.Text * 5
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub5.Text = cashDisplay
            GlobalVariables.n5 = cash
            Totaling()
        Else
            sub5.Text = "$0.00"
        End If
    End Sub
    Private Sub Coin2_TextChanged(sender As Object, e As EventArgs) Handles Coin2.TextChanged
        If Coin2.Text <> "" Then
            Dim cash As Decimal = Coin2.Text * 2
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub2.Text = cashDisplay
            GlobalVariables.c2 = cash
            Totaling()
        Else
            sub2.Text = "$0.00"
        End If
    End Sub
    Private Sub Coin1_TextChanged(sender As Object, e As EventArgs) Handles Coin1.TextChanged
        If Coin1.Text <> "" Then
            Dim cash As Decimal = Coin1.Text * 1
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub1.Text = cashDisplay
            GlobalVariables.c1 = cash
            Totaling()
        Else
            sub1.Text = "$0.00"
        End If
    End Sub
    Private Sub Coin50_TextChanged(sender As Object, e As EventArgs) Handles Coin50.TextChanged
        If Coin50.Text <> "" Then
            Dim cash As Decimal = Coin50.Text * 0.5
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub50c.Text = cashDisplay
            GlobalVariables.c50 = cash
            Totaling()
        Else
            sub50c.Text = "$0.00"
        End If
    End Sub
    Private Sub Coin20_TextChanged(sender As Object, e As EventArgs) Handles Coin20.TextChanged
        If Coin20.Text <> "" Then
            Dim cash As Decimal = Coin20.Text * 0.2
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub20c.Text = cashDisplay
            GlobalVariables.c20 = cash
            Totaling()
        Else
            sub20c.Text = "$0.00"
        End If
    End Sub
    Private Sub Coin10_TextChanged(sender As Object, e As EventArgs) Handles Coin10.TextChanged
        If Coin10.Text <> "" Then
            Dim cash As Decimal = Coin10.Text * 0.1
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub10c.Text = cashDisplay
            GlobalVariables.c10 = cash
            Totaling()
        Else
            sub10c.Text = "$0.00"
        End If
    End Sub
    Private Sub Coin5_TextChanged(sender As Object, e As EventArgs) Handles Coin5.TextChanged
        If Coin5.Text <> "" Then
            Dim cash As Decimal = Coin5.Text * 0.05
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            sub5c.Text = cashDisplay
            GlobalVariables.c5 = cash
            Totaling()
        Else
            sub5c.Text = "$0.00"
        End If
    End Sub

    Private Sub Totaling()
        'Dim Totals As Decimal = (Coin5.Text * 0.05) + (Coin10.Text * 0.1) + (Coin20.Text * 0.2) + (Coin50.Text * 0.5) + (Coin1.Text * 1) + (Coin2.Text * 2) + (Note5.Text * 5) + (Note10.Text * 10) + (Note20.Text * 20) + (Note50.Text * 50) + (Note100.Text * 100)
        Dim Totals As Decimal = GlobalVariables.n100 + GlobalVariables.n50 + GlobalVariables.n20 + GlobalVariables.n10 + GlobalVariables.n5 + GlobalVariables.c2 + GlobalVariables.c1 + GlobalVariables.c50 + GlobalVariables.c20 + GlobalVariables.c10 + GlobalVariables.c5
        Dim totalDisplay As String = "$" & FormatNumber(Totals, 2, TriState.True, TriState.True, TriState.True)
        TotalCash.Text = totalDisplay


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim ReportFont As Font = New Drawing.Font("Calibri", 14)
        Dim ReportHeader As Font = New Drawing.Font("Calibri", 24)

        e.Graphics.DrawString("Cash Count", ReportHeader, Brushes.Black, 50, 25)

        e.Graphics.DrawString("$100", ReportFont, Brushes.Black, 15, 75)
        e.Graphics.DrawString(Note100.Text, ReportFont, Brushes.Black, 80, 75)
        e.Graphics.DrawString(sub100.Text, ReportFont, Brushes.Black, 180, 75)
        e.Graphics.DrawString("$50", ReportFont, Brushes.Black, 15, 100)
        e.Graphics.DrawString(Note50.Text, ReportFont, Brushes.Black, 80, 100)
        e.Graphics.DrawString(sub50.Text, ReportFont, Brushes.Black, 180, 100)
        e.Graphics.DrawString("$20", ReportFont, Brushes.Black, 15, 125)
        e.Graphics.DrawString(Note20.Text, ReportFont, Brushes.Black, 80, 125)
        e.Graphics.DrawString(sub20.Text, ReportFont, Brushes.Black, 180, 125)
        e.Graphics.DrawString("$10", ReportFont, Brushes.Black, 15, 150)
        e.Graphics.DrawString(Note10.Text, ReportFont, Brushes.Black, 80, 150)
        e.Graphics.DrawString(sub10.Text, ReportFont, Brushes.Black, 180, 150)
        e.Graphics.DrawString("$5", ReportFont, Brushes.Black, 15, 175)
        e.Graphics.DrawString(Note5.Text, ReportFont, Brushes.Black, 80, 175)
        e.Graphics.DrawString(sub5.Text, ReportFont, Brushes.Black, 180, 175)
        e.Graphics.DrawString("$2", ReportFont, Brushes.Black, 15, 200)
        e.Graphics.DrawString(Coin2.Text, ReportFont, Brushes.Black, 80, 200)
        e.Graphics.DrawString(sub2.Text, ReportFont, Brushes.Black, 180, 200)
        e.Graphics.DrawString("$1", ReportFont, Brushes.Black, 15, 225)
        e.Graphics.DrawString(Coin1.Text, ReportFont, Brushes.Black, 80, 225)
        e.Graphics.DrawString(sub1.Text, ReportFont, Brushes.Black, 180, 225)
        e.Graphics.DrawString("50c", ReportFont, Brushes.Black, 15, 250)
        e.Graphics.DrawString(Coin50.Text, ReportFont, Brushes.Black, 80, 250)
        e.Graphics.DrawString(sub50c.Text, ReportFont, Brushes.Black, 180, 250)
        e.Graphics.DrawString("20c", ReportFont, Brushes.Black, 15, 275)
        e.Graphics.DrawString(Coin20.Text, ReportFont, Brushes.Black, 80, 275)
        e.Graphics.DrawString(sub20c.Text, ReportFont, Brushes.Black, 180, 275)
        e.Graphics.DrawString("10c", ReportFont, Brushes.Black, 15, 300)
        e.Graphics.DrawString(Coin10.Text, ReportFont, Brushes.Black, 80, 300)
        e.Graphics.DrawString(sub10c.Text, ReportFont, Brushes.Black, 180, 300)
        e.Graphics.DrawString("5c", ReportFont, Brushes.Black, 15, 325)
        e.Graphics.DrawString(Coin5.Text, ReportFont, Brushes.Black, 80, 325)
        e.Graphics.DrawString(sub5c.Text, ReportFont, Brushes.Black, 180, 325)
        e.Graphics.DrawString("-----------------------------------", ReportFont, Brushes.Black, 15, 350)
    End Sub

    Private Sub Till_TextChanged(sender As Object, e As EventArgs) Handles Till.TextChanged
        If Till.Text <> "" Then
            Dim cash As Decimal = Till.Text
            Dim cashDisplay As String = "$" & FormatNumber(cash, 2, TriState.True, TriState.True, TriState.True)
            takingsval.Text = cashDisplay
            GlobalVariables.takings = cash
            Totaling()
        Else
            takingsval.Text = "$0.00"
        End If
    End Sub
End Class

Public Class GlobalVariables
    Public Shared n100, n50, n20, n10, n5, c2, c1, c50, c20, c10, c5, takings As Decimal
End Class

