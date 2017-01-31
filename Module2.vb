Module Module1

    Sub Main()

        Dim name As String = Nothing
        Dim grade1 As Integer = Nothing
        Dim grade2 As Integer = Nothing
        Dim grade3 As Integer = Nothing
        Dim grade4 As Integer = Nothing
        Dim grade5 As Integer = Nothing
        Dim grade6 As Integer = Nothing

        Console.WriteLine("What is your name?")
        name = Console.ReadLine()
        Console.WriteLine("Enter your 1st MyITLab Homework Assignment Grade.")
        grade1 = Console.ReadLine()
        Console.WriteLine("Enter your 2nd MyITLab Homework Assignment Grade.")
        grade2 = Console.ReadLine()
        Console.WriteLine("Enter your 3rd MyITLab Homework Assignment Grade.")
        grade3 = Console.ReadLine()
        Console.WriteLine("Enter your 4th MyITLab Homework Assignment Grade.")
        grade4 = Console.ReadLine()
        Console.WriteLine("Enter your 5th MyITLab Homework Assignment Grade.")
        grade5 = Console.ReadLine()
        Console.WriteLine("Enter your 6th MyITLab Homework Assignment Grade.")
        grade6 = Console.ReadLine()

        Dim average As Integer
        average = (grade1 + grade2 + grade3 + grade4 + grade5 + grade6) / 6

        Console.WriteLine("Your name is: " & name)
        Console.WriteLine("HW1 " & grade1 & " HW2 " & grade2 & " HW3 " & grade3 & " HW4 " & grade4 & " HW5 " & grade5 & " HW6 " & grade6)
        Console.WriteLine("Your average grade for all six MyITLab Homework Assignment is: " & average)
        Console.ReadLine()

    End Sub

End Module
