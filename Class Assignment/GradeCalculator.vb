Module Module1
    Sub Main()
        Dim name As String = Nothing
        Dim numberOfGrades As Integer = 7
        Dim average As Double
        Dim grades(6) As Double
        Dim Sum As Double
        Dim letterGrade As String
        Console.WriteLine("Enter First and Last Name: ")
        name = Console.ReadLine()
        Console.WriteLine(" ")
        Console.WriteLine("Enter the first 7 MyITLab Assignment grades to calculate the average.")
        Console.WriteLine("Press Enter after each input grade.")
        For element As Integer = 0 To 6
            grades(element) = Console.ReadLine()
        Next element
        For Each assignment As Integer In grades
            Sum = Sum + assignment
            average = Sum / numberOfGrades
        Next assignment
        Dim roundAverage As Integer = Math.Round(average)
        Console.WriteLine(" ")
        Console.WriteLine("Student name: " + name.ToString())
        For element As Integer = 0 To 6
            Console.WriteLine("Grade " + element.ToString() + " is " + grades(element).ToString())
        Next element
        If average < 60 Then
            letterGrade = "F"
        ElseIf average < 70 Then
            letterGrade = "D"
        ElseIf average < 80 Then
            letterGrade = "C"
        ElseIf average < 90 Then
            letterGrade = "B"
        ElseIf average < 100 Then
            letterGrade = "A"
        End If
        Console.WriteLine(" ")
        Console.WriteLine("The first 7 MyITLab average grade is: " + roundAverage.ToString() + " Letter grade is: " + letterGrade.ToString())
        Console.ReadLine()
    End Sub
End Module
