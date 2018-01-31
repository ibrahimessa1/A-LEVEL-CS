Module Module1

    Sub Main()
        Dim MemberName As String = ""
        Dim MemberID As Integer = 0
        Dim MoreRecord As Char = "Y"

        FileOpen(1, "D:\VB example\studentRecord.txt", OpenMode.Output)

        While MoreRecord = "Y" Or MoreRecord = "y"
            Console.Write("Enter Member Name : ")
            MemberName = Console.ReadLine

            Console.Write("Enter Member ID : ")
            MemberID = Console.ReadLine

            WriteLine(1, MemberName)
            WriteLine(1, MemberID)

            Console.Write("Do you want to enter more records? (Y/N) : ")
            MoreRecord = Console.ReadLine
        End While
        FileClose(1)
    End Sub

End Module
