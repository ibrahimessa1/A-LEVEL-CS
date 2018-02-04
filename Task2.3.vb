Module Module1

    Sub Main()

        Dim first As String
        Dim second As String
        Dim updatedS As String = ""
        Console.Write("Enter first string: ")
        first = Console.ReadLine()
        Console.Write("Enter second string: ")
        second = Console.ReadLine()
        updatedS = Mid(second, 1, 2) & Mid(first, 3) & " " & Mid(first, 1, 2) & Mid(second, 3)
        Console.WriteLine(updatedS)
        Console.ReadKey()


    End Sub

End Module
