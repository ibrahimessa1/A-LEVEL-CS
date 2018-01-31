Module Module1

    Sub Main()
        Dim Member_Name As String = ""
        Dim Member_ID As Integer = 0
        Dim Member_TelephoneNo As String = ""
        Dim StartDate As String = ""

        FileOpen(1, "D:\VB example\MembershipData.txt", OpenMode.Input)
        FileOpen(2, "D:VB example\NewMembershipData.txt", OpenMode.Output)

        While Not EOF(1)
            Input(1, Member_Name)
            Input(1, Member_ID)

            Console.Write("Enter " & Member_Name) : Console.Write(" Telephone Number : ")
            Member_TelephoneNo = Console.ReadLine
            Console.Write("Enter " & Member_Name) : Console.Write(" Registration Date : ")
            StartDate = Console.ReadLine

            WriteLine(2, Member_Name)
            WriteLine(2, Member_ID)
            WriteLine(2, Member_TelephoneNo)
            WriteLine(2, StartDate)
        End While

        FileClose(1)
        FileClose(2)

        My.Computer.FileSystem.DeleteFile("D:\VB example\MembershipData.txt")
        FileSystem.Rename("D:\VB example\NewMembershipData.txt", "E:\StudentRecord\MembershipData.txt")

        Console.ReadKey()
    End Sub

End Module
