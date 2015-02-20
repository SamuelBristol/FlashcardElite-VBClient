' Author: Samuel Bristol
' Email: samuel.d.bristol@gmail.com
' Website: http://www.samuelbristol.com
' Date: 10/15/2014
' Purpose: A VB.Net class to encapsulate Flashcard behavior.

Option Strict On
Option Explicit On

Public Class Flashcard
    ' Member variables
    Private mstrKeyword As String
    Private mstrAnswer As String

    ' Constructors
    Public Sub New()
        mstrKeyword = String.Empty
        mstrAnswer = String.Empty
    End Sub

    Public Sub New(ByVal keyword As String, ByVal answer As String)
        mstrKeyword = keyword
        mstrAnswer = answer
    End Sub

    ' Properties
    Public Property Keyword() As String
        Get
            Return mstrKeyword
        End Get
        Set(value As String)
            mstrKeyword = value
        End Set
    End Property

    Public Property Answer() As String
        Get
            Return mstrAnswer
        End Get
        Set(value As String)
            mstrAnswer = value
        End Set
    End Property

End Class
