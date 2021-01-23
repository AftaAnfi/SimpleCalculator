Option Explicit On
Option Strict On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Simple Calculator
'https://github.com/AftaAnfi/SimpleCalculator.git


Module SimpleCalc


    Sub Main()

        Dim firstnumber As Integer
        Dim secondnumber As Integer
        Dim userInput As String
        Dim userIntInput As Integer

        Console.Title = "Calculator (Simple)"
        Console.WriteLine("WELCOME TO CALCULATOR")
        Console.WriteLine("")
        System.Threading.Thread.Sleep(1500)

LineFirstInput:
        Console.Clear()
        Console.WriteLine("Enter first number")


        userInput = Console.ReadLine()
        Try
            firstnumber = CInt(userInput)
        Catch e As Exception
            Console.WriteLine($"You didn't enter a number, you entered {userInput}")
            Console.WriteLine("Try again")
            Console.WriteLine(".")
            System.Threading.Thread.Sleep(700)
            Console.WriteLine(".")
            System.Threading.Thread.Sleep(700)
            Console.WriteLine(".")
            System.Threading.Thread.Sleep(700)
            GoTo LineFirstInput
        End Try

LineSecondInput:
        Console.Clear()
        Console.WriteLine("Enter second number")


        userInput = Console.ReadLine()
        Try
            secondnumber = CInt(userInput)
        Catch e As Exception
            Console.WriteLine($"You didn't enter a number, you entered {userInput}")
            Console.WriteLine("Try again")
            Console.WriteLine(".")
            System.Threading.Thread.Sleep(700)
            Console.WriteLine(".")
            System.Threading.Thread.Sleep(700)
            Console.WriteLine(".")
            System.Threading.Thread.Sleep(700)
            GoTo LineSecondInput
        End Try

LineResultStart:
        Console.Clear()
        Console.WriteLine("Which of the following operations would you like to do?")
        Console.WriteLine($"1. Add ({firstnumber} + {secondnumber})")
        Console.WriteLine($"2. Multiply ({firstnumber} * {secondnumber})")

        userInput = Console.ReadLine()

        Try
            userIntInput = CInt(userInput)
        Catch ex As Exception
            Console.WriteLine("That was not 1 or 2, Press any key to continue...")
            Console.ReadKey(False)
            GoTo LineResultStart
        End Try

        Select Case userIntInput
            Case 1
                Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}")
            Case 2
                Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}")
            Case Else
                Console.WriteLine("That was not 1 or 2, Press any key to continue...")
                Console.ReadKey(False)
                GoTo LineResultStart
        End Select


        Console.WriteLine("Press any key to continue...")
        Console.ReadKey(False)


    End Sub

    'class notes
    'Dim countBy As Integer = 1
    'Dim someText As String
    ''For i = 0 To 10 Step countBy
    ''    someText &= "*"
    ''    Console.WriteLine(someText)
    ''    If i >= 9 Then
    ''        countBy = -1
    ''    End If
    ''Next

    'Dim loopCount As Integer

    'While loopCount < 10

    '    Console.WriteLine(StrDup(loopCount, "*"))

    '    loopCount += 1
    'End While


    'Console.Clear()


    'for i = 0 to 10 step 2
    'Console.WriteLine(i)
    'Next
    'Console.ReadLine()

End Module
