Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
'*********************************************************************************************
' Surname, Initials:PANANA R
' Practical: P07
'***********************************
Public Class Form1
    'variables
    Private students() As Student
    Private numstudents, typeofstudent As Integer
    Private Uni As University
    Private HS As Highschool
    Private sum As Integer
    Private NM As String
    Private HSmarks As Integer = 3
    Private Unimarks As Integer = 2
    Private numunistud As Integer = 0
    'file stuff
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private Const Filename As String = "218026867_P07.ipb"
    'calculate average of each student
    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        'read in number of students from the user
        numstudents = CInt(txtnumstudents.Text)
        'resize the array
        ReDim students(numstudents)
        For i As Integer = 1 To numstudents
            typeofstudent = CInt(InputBox("Enter type of student for student" & CStr(i) & Environment.NewLine & "1.Highschool" & Environment.NewLine & "2.University"))
            NM = InputBox("Enter name")
            Select Case typeofstudent
                'highschool
                Case 1
                    'instintiate object of type highschool
                    HS = New Highschool(NM, HSmarks)
                    sum = 0
                    For x As Integer = 1 To HSmarks
                        'read in marks from the user
                        HS.Marks(x) = CInt(InputBox("Enter Mark" & CStr(x)))
                        sum += HS.Marks(x)
                    Next x
                    HS.Extramural = CBool(InputBox("Enter True if you participated on Extramural activities and False if you didnt"))
                    HS.Perfect = CBool(InputBox("Enter True for perfect and False if not perfect"))
                    'calculate average
                    HS.CalculateAve(sum, HSmarks)
                    'upcast
                    students(i) = HS
                'uni
                Case 2
                    'instintiate object of type university
                    Uni = New University(NM)
                    sum = 0
                    numunistud += 1
                    For t As Integer = 1 To Unimarks
                        'read in marks from the user
                        Uni.Marks(t) = CInt(InputBox("Enter Mark" & CStr(t)))
                        sum += Uni.Marks(t)
                    Next t
                    'calculate average
                    Uni.CalculateAve(sum, Unimarks)
                    'upcast
                    students(i) = Uni
            End Select
        Next i
    End Sub
    'display information of each student
    Private Sub btn_display_Click(sender As Object, e As EventArgs) Handles btn_display.Click
        Dim temp As String = ""
        For i As Integer = 1 To numstudents
            temp &= students(i).Display()
        Next i
        txtdisplay.Text = temp
    End Sub
    'save to  the file , all of objects of type university
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        FS = New FileStream(Filename, FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()
        'downcasting
        For i As Integer = 1 To numstudents
            Uni = TryCast(students(i), University)
            If Not (Uni Is Nothing) Then
                BF.Serialize(FS, students(i))
            End If
        Next i
        FS.Close()


    End Sub

    'read from the file
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim count As Integer
        Dim max As Double
        Dim BFoundation As Integer = 175000
        Dim Addition As Integer = 10000
        Dim tempo() As Student
        FS = New FileStream(Filename, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()
        Dim counter As Integer
        While FS.Position < FS.Length
            counter += 1
            ReDim Preserve tempo(counter)
            tempo(counter) = DirectCast(BF.Deserialize(FS), Student)
        End While
        count += 0
        FS.Close()
        numstudents = counter
        ReDim students(numstudents)
        'checks if the student qualifies for bursary
        For i As Integer = 1 To numstudents
            students(i) = tempo(i)
            If students(i).Qualifies = True Then
                count += 1
            End If

        Next i
        Dim index As Integer
        'calculate total funds of top student
        Dim funds As Double = BFoundation / counter + Addition
        'determine the top student by getting maximum average
        For x As Integer = 1 To numstudents
            If max < students(x).Average Then
                max = students(x).Average
                index = x
            End If
        Next x
        'display top student info in the textbox
        txtTopStud.Text = "The top student is" & CStr(students(index).Display() & "Total funds =" & CStr(funds))

    End Sub



End Class
