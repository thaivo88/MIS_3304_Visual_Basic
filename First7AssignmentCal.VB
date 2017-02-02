Module Module1
    Sub Main()
        Dim name As String = Nothing
        Dim gradeScore As Integer = 1
        Dim Sum As Integer = 0
        Dim numberOfGrades As Integer = 0
        Dim average As Double = Nothing

        Console.WriteLine("Enter First and Last Name: ")
        name = Console.ReadLine()
        Console.WriteLine(" ")

        Console.WriteLine("Student Name is " + name.ToString())
        Console.WriteLine(" ")

        Console.WriteLine("Enter the first 7 MyITLab Assignment grades to calculate the average.")
        Console.WriteLine("Press Enter after each input grade.")
        Console.WriteLine("After Assignment 7 press enter to complete the program")
        Console.WriteLine(" ")

        Console.WriteLine("Please enter first MyITLab Assignment grade.")

        gradeScore = Console.ReadLine()
        Do
            Sum += gradeScore
            numberOfGrades += 1
            average = Sum / numberOfGrades
            Console.WriteLine(" ")
            Console.WriteLine("MyITLab Assignment " + numberOfGrades.ToString + " Grade is " + gradeScore.ToString)
            Console.WriteLine("The Total is " + Sum.ToString)
            Console.Write("Next Assignment is ")
            gradeScore = Console.ReadLine()
        Loop While (numberOfGrades <> 7)

        Math.Round(average)

        Console.WriteLine("The average is " + average.ToString)

        Console.ReadLine()

    End Sub
End Module
