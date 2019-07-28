Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        select_row(1)
        Me.Text = "Cash Count  v" & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." & My.Application.Info.Version.Revision.ToString

    End Sub
    Public Class GlobalVariables
        Public Shared note_100 As Integer
        Public Shared note_50 As Integer
        Public Shared note_20 As Integer
        Public Shared note_10 As Integer
        Public Shared note_5 As Integer
        Public Shared coin_1 As Integer
        Public Shared coin_2 As Integer
        Public Shared coin_50 As Integer
        Public Shared coin_20 As Integer
        Public Shared coin_10 As Integer
        Public Shared coin_5 As Integer
        Public Shared eftpos As Decimal
        Public Shared cheque As Decimal
        Public Shared pos As Decimal
        Public Shared total As Decimal
    End Class

    Private Sub calculateit()
        Dim calc As Decimal
        calc = calc + (GlobalVariables.note_100 * 100)
        calc = calc + (GlobalVariables.note_50 * 50)
        calc = calc + (GlobalVariables.note_20 * 20)
        calc = calc + (GlobalVariables.note_10 * 10)
        calc = calc + (GlobalVariables.note_5 * 5)
        calc = calc + (GlobalVariables.coin_2 * 2)
        calc = calc + (GlobalVariables.coin_1 * 1)
        calc = calc + (GlobalVariables.coin_50 * 0.5)
        calc = calc + (GlobalVariables.coin_20 * 0.2)
        calc = calc + (GlobalVariables.coin_10 * 0.1)
        calc = calc + (GlobalVariables.coin_5 * 0.05)
        calc = calc + GlobalVariables.eftpos
        calc = calc + GlobalVariables.cheque
        GlobalVariables.total = calc
        calc = calc - GlobalVariables.pos

        If calc > 0 Then
            total_info.Text = "You are OVER by " & String.Format("{0:C2}", CDec(calc))
            check_line.Text = "Please check your counts"
            total_info.ForeColor = Color.DodgerBlue
            check_line.ForeColor = Color.DodgerBlue
        End If
        If calc < 0 Then
            total_info.Text = "You are SHORT by " & String.Format("{0:C2}", CDec(calc))
            check_line.Text = "Please check your counts"
            total_info.ForeColor = Color.Red
            check_line.ForeColor = Color.Red
        End If
        If calc = 0 Then
            total_info.Text = "You have Balanced"
            check_line.Text = ""
            total_info.ForeColor = Color.FromArgb(90, 185, 129)

        End If

    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "1"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "8"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "9"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "6"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "3"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If cashcount1.Text = "0" Then cashcount1.Text = ""
        cashcount1.Text = cashcount1.Text + "."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cashcount1.Text = cashcount1.Text.Remove(cashcount1.Text.Length - 1)
        If cashcount1.Text.Length = 0 Then
            cashcount1.Text = "0"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If Label1.Text = "ENTER THE NUMBER OF $100 NOTES" Then
            GlobalVariables.note_100 = cashcount1.Text
            count1.Text = String.Format("{0:C2}", CDec(GlobalVariables.note_100 * 100))
            select_row(2)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE NUMBER OF $50 NOTES" Then
            GlobalVariables.note_50 = cashcount1.Text
            count2.Text = String.Format("{0:C2}", CDec(GlobalVariables.note_50 * 50))
            select_row(3)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE NUMBER OF $20 NOTES" Then
            GlobalVariables.note_20 = cashcount1.Text
            count3.Text = String.Format("{0:C2}", CDec(GlobalVariables.note_20 * 20))
            select_row(4)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE NUMBER OF $10 NOTES" Then
            GlobalVariables.note_10 = cashcount1.Text
            count4.Text = String.Format("{0:C2}", CDec(GlobalVariables.note_10 * 10))
            select_row(5)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE NUMBER OF $5 NOTES" Then
            GlobalVariables.note_5 = cashcount1.Text
            count5.Text = String.Format("{0:C2}", CDec(GlobalVariables.note_5 * 5))
            select_row(6)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE NUMBER OF $2 COINS" Then
            GlobalVariables.coin_2 = cashcount1.Text
            count6.Text = String.Format("{0:C2}", CDec(GlobalVariables.coin_2 * 2))
            select_row(7)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE NUMBER OF $1 COINS" Then
            GlobalVariables.coin_1 = cashcount1.Text
            count7.Text = String.Format("{0:C2}", CDec(GlobalVariables.coin_1 * 1))
            select_row(8)
            Exit Sub
        End If

        If Label1.Text = "ENTER THE NUMBER OF 50c COINS" Then
            GlobalVariables.coin_50 = cashcount1.Text

            count8.Text = String.Format("{0:C2}", CDec(GlobalVariables.coin_50 * 0.5))
            select_row(9)
            Exit Sub
        End If


        If Label1.Text = "ENTER THE NUMBER OF 20c COINS" Then
            GlobalVariables.coin_20 = cashcount1.Text
            count9.Text = String.Format("{0:C2}", CDec(GlobalVariables.coin_20 * 0.2))
            select_row(10)
            Exit Sub
        End If



        If Label1.Text = "ENTER THE NUMBER OF 10c COINS" Then
            GlobalVariables.coin_10 = cashcount1.Text
            count10.Text = String.Format("{0:C2}", CDec(GlobalVariables.coin_10 * 0.1))
            select_row(11)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE NUMBER OF 5c COINS" Then
            GlobalVariables.coin_5 = cashcount1.Text
            count11.Text = String.Format("{0:C2}", CDec(GlobalVariables.coin_5 * 0.05))
            select_row(12)
            Exit Sub

        End If
        If Label1.Text = "ENTER THE EFTPOS AMOUNT" Then
            GlobalVariables.eftpos = cashcount1.Text
            count12.Text = String.Format("{0:C2}", GlobalVariables.eftpos)
            select_row(13)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE CHEQUE AMOUNT" Then
            GlobalVariables.cheque = cashcount1.Text
            count13.Text = String.Format("{0:C2}", CDec(GlobalVariables.cheque * 1))
            select_row(14)
            Exit Sub
        End If
        If Label1.Text = "ENTER THE POS SALES AMOUNT" Then
            GlobalVariables.pos = cashcount1.Text
            count14.Text = String.Format("{0:C2}", CDec(GlobalVariables.pos * 1))
            Label1.Text = "TOTAL CALCULATED"
            clear_all()
            cashcount1.Text = "0"
            calculateit()
            Exit Sub
        End If

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        select_row(1)
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        select_row(2)
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        select_row(3)
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        select_row(4)
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        select_row(5)
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        select_row(6)
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        select_row(7)
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        select_row(8)
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        select_row(9)
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        select_row(10)
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        select_row(11)
    End Sub
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        select_row(12)
    End Sub
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        select_row(13)
    End Sub
    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        select_row(14)
    End Sub
    Private Sub select_row(i As Integer)
        clear_all()
        Dim lbl1 As Label = Me.Controls.Find("count" & i, True).FirstOrDefault
        lbl1.BackColor = Color.FromArgb(90, 185, 129)
        lbl1.ForeColor = Color.White
        Dim lbl2 As Label = Me.Controls.Find("title" & i, True).FirstOrDefault
        lbl2.BackColor = Color.FromArgb(90, 185, 129)
        lbl2.ForeColor = Color.White
        Dim pic1 As PictureBox = Me.Controls.Find("PictureBox" & i, True).FirstOrDefault
        pic1.BackColor = Color.FromArgb(90, 185, 129)
        pic1.BackgroundImage = My.Resources.note_white

        If i > 5 And i < 12 Then
            pic1.BackColor = Color.FromArgb(90, 185, 129)
            pic1.BackgroundImage = My.Resources.coint_white
        End If
        If i = 12 Then
            pic1.BackColor = Color.FromArgb(90, 185, 129)
            pic1.BackgroundImage = My.Resources.eft_white
        End If
        If i = 13 Then
            pic1.BackColor = Color.FromArgb(90, 185, 129)
            pic1.BackgroundImage = My.Resources.cheque_white
        End If
        If i = 14 Then
            pic1.BackColor = Color.FromArgb(90, 185, 129)
            pic1.BackgroundImage = My.Resources.reg_white
        End If


        Select Case i
            Case 1
                Label1.Text = "ENTER THE NUMBER OF $100 NOTES"
                cashcount1.Text = "0"
            Case 2
                Label1.Text = "ENTER THE NUMBER OF $50 NOTES"
                cashcount1.Text = "0"
            Case 3
                Label1.Text = "ENTER THE NUMBER OF $20 NOTES"
                cashcount1.Text = "0"
            Case 4
                Label1.Text = "ENTER THE NUMBER OF $10 NOTES"
                cashcount1.Text = "0"
            Case 5
                Label1.Text = "ENTER THE NUMBER OF $5 NOTES"
                cashcount1.Text = "0"
            Case 6
                Label1.Text = "ENTER THE NUMBER OF $2 COINS"
                cashcount1.Text = "0"
            Case 7
                Label1.Text = "ENTER THE NUMBER OF $1 COINS"
                cashcount1.Text = "0"
            Case 8
                Label1.Text = "ENTER THE NUMBER OF 50c COINS"
                cashcount1.Text = "0"
            Case 9
                Label1.Text = "ENTER THE NUMBER OF 20c COINS"
                cashcount1.Text = "0"
            Case 10
                Label1.Text = "ENTER THE NUMBER OF 10c COINS"
                cashcount1.Text = "0"
            Case 11
                Label1.Text = "ENTER THE NUMBER OF 5c COINS"
                cashcount1.Text = "0"
            Case 12
                Label1.Text = "ENTER THE EFTPOS AMOUNT"
                cashcount1.Text = "0"
            Case 13
                Label1.Text = "ENTER THE CHEQUE AMOUNT"
                cashcount1.Text = "0"
            Case 14
                Label1.Text = "ENTER THE POS SALES AMOUNT"
                cashcount1.Text = "0"
        End Select
    End Sub

    Private Sub clear_all()
        For ii As Integer = 1 To 14
            Dim lbl1 As Label = Me.Controls.Find("count" & ii, True).FirstOrDefault
            lbl1.BackColor = Color.White
            lbl1.ForeColor = Color.DimGray
            Dim lbl2 As Label = Me.Controls.Find("title" & ii, True).FirstOrDefault
            lbl2.BackColor = Color.White
            lbl2.ForeColor = Color.Black
            Dim pic1 As PictureBox = Me.Controls.Find("PictureBox" & ii, True).FirstOrDefault
            pic1.BackColor = Color.White
            pic1.BackgroundImage = My.Resources.note_black
            If ii > 5 And ii < 12 Then
                pic1.BackColor = Color.White
                pic1.BackgroundImage = My.Resources.coint_black
            End If
            If ii = 12 Then
                pic1.BackColor = Color.White
                pic1.BackgroundImage = My.Resources.eft_black
            End If
            If ii = 13 Then
                pic1.BackColor = Color.White
                pic1.BackgroundImage = My.Resources.cheque_black
            End If
            If ii = 14 Then
                pic1.BackColor = Color.White
                pic1.BackgroundImage = My.Resources.reg_black
            End If
        Next
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        reset_all()


    End Sub

    Private Sub reset_all()
        clear_all()
        Label1.Text = "ENTER THE NUMBER OF $100 NOTES"
        GlobalVariables.note_100 = 0
        GlobalVariables.note_50 = 0
        GlobalVariables.note_20 = 0
        GlobalVariables.note_10 = 0
        GlobalVariables.note_5 = 0
        GlobalVariables.coin_2 = 0
        GlobalVariables.coin_1 = 0
        GlobalVariables.coin_50 = 0
        GlobalVariables.coin_20 = 0
        GlobalVariables.coin_10 = 0
        GlobalVariables.coin_5 = 0
        GlobalVariables.eftpos = 0
        GlobalVariables.cheque = 0
        GlobalVariables.pos = 0
        count1.Text = "$0.00"
        count2.Text = "$0.00"
        count3.Text = "$0.00"
        count4.Text = "$0.00"
        count5.Text = "$0.00"
        count6.Text = "$0.00"
        count7.Text = "$0.00"
        count8.Text = "$0.00"
        count9.Text = "$0.00"
        count10.Text = "$0.00"
        count11.Text = "$0.00"
        count12.Text = "$0.00"
        count13.Text = "$0.00"
        count14.Text = "$0.00"
        total_info.Text = ""
        check_line.Text = ""
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Me.Close()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        reset_all()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles check_line.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim blackPen As New Pen(Color.Black, 2)
        Dim point1 As New Point(0, 155)
        Dim point2 As New Point(275, 155)
        Dim point3 As New Point(0, 575)
        Dim point4 As New Point(275, 575)
        Dim left1 As Integer = 10
        Dim right1 As Integer = 130
        Dim ReportFontBold As Font = New Drawing.Font("Calibri", 14, FontStyle.Bold)
        Dim ReportFont As Font = New Drawing.Font("Calibri", 14)
        Dim ReportMetaBold As Font = New Drawing.Font("Calibri", 11, FontStyle.Bold)
        Dim ReportMeta As Font = New Drawing.Font("Calibri", 11)
        Dim ReportHeader As Font = New Drawing.Font("Calibri", 18, FontStyle.Bold)
        Dim lineheight As Integer

        e.Graphics.DrawString("Majura Park Gun Club", ReportHeader, Brushes.Black, 22, 25)
        e.Graphics.DrawString("POS Reconciliation", ReportHeader, Brushes.Black, 35, 55)
        lineheight = 95
        e.Graphics.DrawString("Terminal:", ReportMetaBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(Environment.MachineName, ReportMeta, Brushes.Black, left1 + 80, lineheight)
        lineheight = lineheight + 15
        e.Graphics.DrawString("Date:", ReportMetaBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyy"), ReportMeta, Brushes.Black, left1 + 80, lineheight)
        lineheight = lineheight + 15
        e.Graphics.DrawString("Time:", ReportMetaBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(DateTime.Now.ToString("HH:mm:ss"), ReportMeta, Brushes.Black, left1 + 80, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawLine(blackPen, point1, point2)
        lineheight = lineheight + 20
        e.Graphics.DrawString("Item", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString("Qty", ReportFontBold, Brushes.Black, left1 + 100, lineheight)
        e.Graphics.DrawString("Value", ReportFontBold, Brushes.Black, left1 + 175, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("$100", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.note_100, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.note_100 * 100)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("$50", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.note_50, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.note_50 * 50)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("$20", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.note_20, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.note_20 * 20)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("$10", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.note_10, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.note_10 * 10)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("$5", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.note_10, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.note_5 * 5)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("$2", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.coin_2, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.coin_2 * 2)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("$1", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.coin_1, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.coin_1 * 1)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("50c", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.coin_50, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.coin_50 * 0.5)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("20c", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.coin_20, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.coin_20 * 0.2)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("10c", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.coin_10, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.coin_10 * 0.1)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("5c", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(GlobalVariables.coin_5, ReportFont, Brushes.Black, left1 + 110, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.coin_5 * 0.05)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("EFTPOS", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.eftpos * 1)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("Cheque", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.cheque * 1)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        e.Graphics.DrawString("Total", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.total * 1)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        lineheight = lineheight + 20
        e.Graphics.DrawString("POS Amount", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.pos * 1)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        lineheight = lineheight + 10
        e.Graphics.DrawString("Difference +/-", ReportFontBold, Brushes.Black, left1, lineheight)
        e.Graphics.DrawString(String.Format("{0:C2}", CDec(GlobalVariables.total - GlobalVariables.pos)), ReportFont, Brushes.Black, left1 + 170, lineheight)
        lineheight = lineheight + 20
        If GlobalVariables.total - GlobalVariables.pos = 0 Then
            e.Graphics.DrawString("Balanced", ReportFontBold, Brushes.Black, left1 + 170, lineheight)
        End If
        If GlobalVariables.total - GlobalVariables.pos < 0 Then
            e.Graphics.DrawString("Short", ReportFontBold, Brushes.Black, left1 + 170, lineheight)
        End If
        If GlobalVariables.total - GlobalVariables.pos > 0 Then
            e.Graphics.DrawString("Over", ReportFontBold, Brushes.Black, left1 + 170, lineheight)
        End If
        lineheight = lineheight + 20
        e.Graphics.DrawLine(blackPen, point3, point4)
        e.Graphics.DrawString(" ", ReportFontBold, Brushes.Black, left1 + 170, 620)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If total_info.Text <> " " Then
            Dim printerName As String
            printerName = "SAM4S ELLIX30"
            PrintDocument1.PrinterSettings.PrinterName = printerName
            PrintDocument1.Print()
        Else
            MsgBox("You need to balance the POS before printing")
        End If

    End Sub

    Private Sub title1_Click(sender As Object, e As EventArgs) Handles title1.Click
        select_row(1)
    End Sub

    Private Sub count1_Click(sender As Object, e As EventArgs) Handles count1.Click
        select_row(1)
    End Sub

    Private Sub title2_Click(sender As Object, e As EventArgs) Handles title2.Click
        select_row(2)
    End Sub

    Private Sub count2_Click(sender As Object, e As EventArgs) Handles count2.Click
        select_row(2)
    End Sub

    Private Sub title3_Click(sender As Object, e As EventArgs) Handles title3.Click
        select_row(3)
    End Sub

    Private Sub count3_Click(sender As Object, e As EventArgs) Handles count3.Click
        select_row(3)
    End Sub

    Private Sub title4_Click(sender As Object, e As EventArgs) Handles title4.Click
        select_row(4)
    End Sub

    Private Sub count4_Click(sender As Object, e As EventArgs) Handles count4.Click
        select_row(4)
    End Sub

    Private Sub title5_Click(sender As Object, e As EventArgs) Handles title5.Click
        select_row(5)
    End Sub

    Private Sub count5_Click(sender As Object, e As EventArgs) Handles count5.Click
        select_row(5)
    End Sub

    Private Sub title6_Click(sender As Object, e As EventArgs) Handles title6.Click
        select_row(6)
    End Sub

    Private Sub count6_Click(sender As Object, e As EventArgs) Handles count6.Click
        select_row(6)
    End Sub

    Private Sub title7_Click(sender As Object, e As EventArgs) Handles title7.Click
        select_row(7)
    End Sub

    Private Sub count7_Click(sender As Object, e As EventArgs) Handles count7.Click
        select_row(7)
    End Sub

    Private Sub title8_Click(sender As Object, e As EventArgs) Handles title8.Click
        select_row(8)
    End Sub

    Private Sub count8_Click(sender As Object, e As EventArgs) Handles count8.Click
        select_row(8)
    End Sub

    Private Sub title9_Click(sender As Object, e As EventArgs) Handles title9.Click
        select_row(9)
    End Sub

    Private Sub count9_Click(sender As Object, e As EventArgs) Handles count9.Click
        select_row(9)
    End Sub

    Private Sub title10_Click(sender As Object, e As EventArgs) Handles title10.Click
        select_row(10)
    End Sub

    Private Sub count10_Click(sender As Object, e As EventArgs) Handles count10.Click
        select_row(10)
    End Sub

    Private Sub title11_Click(sender As Object, e As EventArgs) Handles title11.Click
        select_row(11)
    End Sub

    Private Sub count11_Click(sender As Object, e As EventArgs) Handles count11.Click
        select_row(11)
    End Sub

    Private Sub title12_Click(sender As Object, e As EventArgs) Handles title12.Click
        select_row(12)
    End Sub

    Private Sub count12_Click(sender As Object, e As EventArgs) Handles count12.Click
        select_row(12)
    End Sub

    Private Sub title13_Click(sender As Object, e As EventArgs) Handles title13.Click
        select_row(13)
    End Sub

    Private Sub count13_Click(sender As Object, e As EventArgs) Handles count13.Click
        select_row(13)
    End Sub

    Private Sub title14_Click(sender As Object, e As EventArgs) Handles title14.Click
        select_row(14)
    End Sub

    Private Sub count14_Click(sender As Object, e As EventArgs) Handles count14.Click
        select_row(14)
    End Sub


End Class