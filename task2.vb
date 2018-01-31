Module Module1

    Sub Main()
        Dim Member_Name As String = ""
        Dim Member_ID As Integer = 0

        FileOpen(1, "D:\VB example\MembershipData.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, Member_Name)
            Input(1, Member_ID)

            Console.WriteLine("Member Name : " & Member_Name)
            Console.WriteLine("Member ID : " & Member_ID)
        End While

        FileClose(1)

        Console.ReadKey()
    End Sub

End Module
