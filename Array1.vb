Module Module1

    Dim Ch(26) As Integer
    Sub Main()
        Dim count As Integer
        For count = 1 To 26
            Ch(count) = 0
        Next
        Call ReadFile()
        Call OutputArray()
        Console.ReadKey()
    End Sub
    Sub ReadFile()
        Dim Str As String = ""
        FileOpen(1, "D:VB example\Names.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, Str)
            Call UpdateArray(Str)
        End While
        FileClose(1)
    End Sub
    Sub UpdateArray(ByVal Str As String)
        Dim count As Integer = 0
        Dim Mychar As Char = ""
        For count = 1 To Len(Str)
            Mychar = Mid(Str, count, 1)
            Ch(Asc(UCase(Mychar)) - 64) = Ch(Asc(UCase(Mychar)) - 64) + 1
        Next
    End Sub
    Sub OutputArray()
        Dim count As Integer = 0
        Dim SingleCh As Char = ""
        For count = 65 To 90
            SingleCh = Chr(count)
            Console.WriteLine(Ch(count - 64) & " = " & SingleCh)
        Next

    End Sub

End Module
