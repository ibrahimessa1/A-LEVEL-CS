Module Module1

    Sub Main()
        Dim Count As Integer
        Console.Write("Enter number of donuts: ")
        Count = Console.ReadLine()
        If Count < 10 Then
            Console.WriteLine("Number of donuts: " & Count)
        Else : Console.WriteLine("Number of donuts: Many")
        End If
        Console.ReadKey()


    End Sub

End Module
