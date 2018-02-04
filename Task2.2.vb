Module Module1

    Sub Main()

        Dim s As String
        Dim first As Char
        Dim symbol As Char = "*"
        Dim updatedS As String
        Console.Write("Enter string: ")
        s = Console.ReadLine()
        first = s(0)
        updatedS = first
        For i = 1 To Len(s) - 1
            If s(i) <> first Then
                updatedS = updatedS & s(i)
            Else : updatedS = updatedS & symbol
            End If
        Next
        Console.WriteLine(updatedS)
        Console.ReadKey()

    End Sub

End Module
