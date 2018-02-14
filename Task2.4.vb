Module Module1

    Sub Main()

        Dim Input_string As String = ""
        Dim Not_found As Boolean = False
        Dim Bad_found As Boolean = False
        Dim Final_string As String = ""
        Dim Left_string As String = ""
        Dim Right_string As String = ""
        Dim Not_position As Integer = 0
        Dim Bad_position As Integer = 0

        Console.Write("Enter the string: ")
        Input_string = Console.ReadLine

        If InStr(Input_string, "not") <> 0 Then
            Not_position = InStr(Input_string, "not")
            Not_found = True
        End If
        If InStr(Input_string, "bad") <> 0 Then
            Bad_position = InStr(Input_string, "bad")
            Bad_found = True
        End If
        If Not_found = False And Bad_found = False Then
            Console.WriteLine("Not And Bad are not found...!")
        Else
            Left_string = Mid(Input_string, 1, Not_position - 1)
            Right_string = Mid(Input_string, Bad_position + 3, Len(Input_string))
            Final_string = Left_string & "good" & Right_string

            Console.WriteLine("Output : " & Final_string)
        End If
        Console.ReadKey()

    End Sub

End Module
