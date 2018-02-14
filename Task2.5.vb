Module Module1

    Sub Main()


        Dim String_front_1 As String = ""
        Dim String_front_2 As String = ""
        Dim String_back_1 As String = ""
        Dim String_back_2 As String = ""
        Dim String_input_1 As String = ""
        Dim String_input_2 As String = ""
        Dim String_output As String = ""
        Dim Length_1 As Integer = 0
        Dim Length_2 As Integer = 0

        Console.Write("Enter String 1 : ")
        String_input_1 = Console.ReadLine

        Console.Write("Enter String 2 : ")
        String_input_2 = Console.ReadLine

        If Len(String_input_1) Mod 2 = 0 Then
            String_front_1 = Left(String_input_1, (Len(String_input_1) / 2))
            String_back_1 = Right(String_input_1, (Len(String_input_1) / 2))
        Else
            Length_1 = Len(String_input_1) - 1
            String_front_1 = Left(String_input_1, (Length_1 / 2) + 1)
            String_back_1 = Right(String_input_1, (Length_1 / 2))
        End If

        If Len(String_input_2) Mod 2 = 0 Then
            String_front_2 = Left(String_input_2, (Len(String_input_2) / 2))
            String_back_2 = Right(String_input_2, (Len(String_input_2) / 2))
        Else
            Length_2 = Len(String_input_2) - 1
            String_front_2 = Left(String_input_2, (Length_2 / 2) + 1)
            String_back_2 = Right(String_input_2, (Length_2 / 2))
        End If

        String_output = String_front_1 & String_front_2 & String_back_1 & String_back_2

        Console.WriteLine("The Output String is : " & String_output)

        Console.ReadKey()
    End Sub

End Module
