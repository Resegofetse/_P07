Option Strict On
Option Explicit On
Option Infer Off
'*********************************************************************************************
' Surname, Initials:PANANA R
' Practical: P07
'***********************************
<Serializable()> Public Class University
    Inherits Student
    'constructor
    Public Sub New(Fname As String)
        MyBase.New(Fname, 2)
    End Sub
    'function to evaluate if the student qualifies for the bursary 
    Public Overrides Function EvaluateStudent() As Boolean
        If Average >= 65 Then
            _Qualifies = True
        Else
            _Qualifies = False
        End If
        Return _Qualifies
    End Function
End Class
