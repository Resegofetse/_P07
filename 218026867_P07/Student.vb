Option Strict On
Option Explicit On
Option Infer Off
'*********************************************************************************************
' Surname, Initials:PANANA R
' Practical: P07
'***********************************
<Serializable()> Public MustInherit Class Student
    'Attributes
    Private _Fullname As String
    Private _NumMarks As Integer
    Private _Marks() As Integer
    Private _Average As Double
    Protected _Qualifies As Boolean
    'property methods
    Public Sub New(fullname As String, numMarks As Integer)
        _Fullname = fullname
        _NumMarks = numMarks
        ReDim _Marks(_NumMarks)
    End Sub
    Public Property fullname As String
        Get
            Return _Fullname
        End Get
        Set(value As String)
            _Fullname = value
        End Set
    End Property
    Public Property numMarks As Integer
        Get
            Return _NumMarks
        End Get
        Set(value As Integer)
            _NumMarks = value
        End Set
    End Property
    Public Property Marks(index As Integer) As Integer
        Get
            Return _Marks(index)
        End Get
        Set(value As Integer)
            _Marks(index) = value
        End Set
    End Property
    Public ReadOnly Property Average As Double
        Get
            Return _Average
        End Get
    End Property
    Public ReadOnly Property Qualifies As Boolean
        Get
            Return _Qualifies
        End Get
    End Property

    'functions
    'function to calculate average for each student
    Public Function CalculateAve(sum As Integer, numMarks As Integer) As Double
        _Average = sum / numMarks
        Return _Average
    End Function

    Public MustOverride Function EvaluateStudent() As Boolean
    'function to output details of each student
    Public Function Display() As String
        Dim temp As String = ""
        temp &= "Name:" & fullname & "  " & "Average:" & (CStr(_Average)) & Environment.NewLine
        Return temp
    End Function


End Class
