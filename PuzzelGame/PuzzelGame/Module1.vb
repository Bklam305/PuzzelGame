Module Module1
    Sub EmptySpotChecker(ByRef Butt1 As Button, ByRef Butt2 As Button)
        If Butt2.Tag.ToString = "" Then
            Butt2.Tag = Butt1.Tag
            Butt1.Tag = ""
            Butt2.BackgroundImage = Butt1.BackgroundImage
            Butt1.BackgroundImage = Nothing
        End If
    End Sub
    Sub SolutionChecker()
        If Form1.Button1.Tag = "1" And Form1.Button2.Tag = "2" And Form1.Button3.Tag = "3" And Form1.Button4.Tag = "4" And
            Form1.Button5.Tag = "5" And Form1.Button6.Tag = "6" And Form1.Button7.Tag = "7" And Form1.Button8.Tag = "8" And
            Form1.Button9.Tag = "9" And Form1.Button10.Tag = "10" And Form1.Button11.Tag = "11" And Form1.Button12.Tag = "12" And
            Form1.Button13.Tag = "13" And Form1.Button14.Tag = "14" And Form1.Button15.Tag = "15" Then
            MessageBox.Show("Well Done You Are a Wizard", "Shuffle Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Form1.counter += 1
        Form1.TextBox1.Tag = "Number of Clicks " & Form1.counter
    End Sub
    Sub Shuffle()
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))
            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i += 1
            End If
        Loop

        Form1.Button1.Tag = a(1)
        Form1.Button2.Tag = a(2)
        Form1.Button3.Tag = a(3)
        Form1.Button4.Tag = a(4)
        Form1.Button5.Tag = a(5)
        Form1.Button6.Tag = a(6)
        Form1.Button7.Tag = a(7)
        Form1.Button8.Tag = a(8)
        Form1.Button9.Tag = a(9)
        Form1.Button10.Tag = a(10)
        Form1.Button11.Tag = a(11)
        Form1.Button12.Tag = a(12)
        Form1.Button13.Tag = a(13)
        Form1.Button14.Tag = a(14)
        Form1.Button15.Tag = a(15)
        Form1.Button16.Tag = ""
        Form1.Button1.BackgroundImage = Form1.ImageList1.Images(a(1) - 1)
        Form1.Button2.BackgroundImage = Form1.ImageList1.Images(a(2) - 1)
        Form1.Button3.BackgroundImage = Form1.ImageList1.Images(a(3) - 1)
        Form1.Button4.BackgroundImage = Form1.ImageList1.Images(a(4) - 1)
        Form1.Button5.BackgroundImage = Form1.ImageList1.Images(a(5) - 1)
        Form1.Button6.BackgroundImage = Form1.ImageList1.Images(a(6) - 1)
        Form1.Button7.BackgroundImage = Form1.ImageList1.Images(a(7) - 1)
        Form1.Button8.BackgroundImage = Form1.ImageList1.Images(a(8) - 1)
        Form1.Button9.BackgroundImage = Form1.ImageList1.Images(a(9) - 1)
        Form1.Button10.BackgroundImage = Form1.ImageList1.Images(a(10) - 1)
        Form1.Button11.BackgroundImage = Form1.ImageList1.Images(a(11) - 1)
        Form1.Button12.BackgroundImage = Form1.ImageList1.Images(a(12) - 1)
        Form1.Button13.BackgroundImage = Form1.ImageList1.Images(a(13) - 1)
        Form1.Button14.BackgroundImage = Form1.ImageList1.Images(a(14) - 1)
        Form1.Button15.BackgroundImage = Form1.ImageList1.Images(a(15) - 1)
        Form1.Button16.BackgroundImage = Nothing
    End Sub
End Module
