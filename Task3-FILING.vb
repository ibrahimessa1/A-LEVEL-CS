Module Module1

    Sub Main()
        Dim SearchName As String = ""
        Dim MemberName As String = ""
        Dim MemberId As Integer = 0
        Dim IsFound As Boolean = False

        FileOpen(1, "D:\VB example\Members.txt", OpenMode.Input)

        Console.WriteLine("Enter the name you want to search for:  ")
        SearchName = Console.ReadLine

        While Not EOF(1) And IsFound = False

            Input(1, MemberName)
            Input(1, MemberId)

            If SearchName = MemberName Then
                IsFound = True
                Console.WriteLine("Member Name : " & MemberName)
                Console.WriteLine("Member ID : " & MemberId)

            End If

        End While

        If IsFound = False Then
            Console.WriteLine("Record Not Found...!")
        End If

        FileClose(1)

        Console.ReadKey()

    End Sub

End Module
