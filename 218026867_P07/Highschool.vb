Option Strict On
Option Explicit On
Option Infer Off
'*********************************************************************************************
' Surname, Initials:PANANA R
' Practical: P07
'***********************************
<Serializable()> Public Class Highschool
    Inherits Student
    'attributes
    Private _Extramural As Boolean
    Private _Perfect As Boolean
    'constructor
    Public Sub New(fname As String, numMarks As Integer)
        MyBase.New(fname, numMarks)
    End Sub
    'property methods
    Public Property Extramural As Boolean
        Get
            Return _Extramural
        End Get
        Set(value As Boolean)
            _Extramural = value
        End Set
    End Property
    Public Property Perfect As Boolean
        Get
            Return _Perfect
        End Get
        Set(value As Boolean)
            _Perfect = value
        End Set
    End Property

    'function to evaluate if the student qualifies for the bursary 
    Public Overrides Function EvaluateStudent() As Boolean
        _Qualifies = False
        If Average > 80 Or Average > 70 And Extramural = True Or Perfect = True Then
            _Qualifies = True
        End If
        Return _Qualifies
    End Function

End Class
