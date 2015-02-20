' Author: Samuel Bristol
' Email: samuel.d.bristol@gmail.com
' Website: http://www.samuelbristol.com
' Date: 10/15/2014
' Purpose: A VB.Net class to manage flashcard application data.   

Option Strict On
Option Explicit On

Public Class FlashcardController
    ' Member variables
    Private mlstCardList As List(Of Flashcard)

    ' Constructors
    Public Sub New()
        ' Default data
        mlstCardList = New List(Of Flashcard)
        mlstCardList.Add(New Flashcard("SQL", "Structured Query Language"))
        mlstCardList.Add(New Flashcard("HTML", "Hyper Text Markup Language"))
        mlstCardList.Add(New Flashcard("PHP", "PHP Hypertext Preprocessor"))
    End Sub

    ' Functions
    Public Function GetAll() As List(Of Flashcard)
        Return mlstCardList
    End Function

    Public Function GetRandomCard() As Flashcard
        ' Pick a random number between 0 and the length of the card list
        Dim intRandomNumber As Integer = New Random().Next(0, mlstCardList.Count)

        ' Return the result
        Return mlstCardList(intRandomNumber)
    End Function

    Public Sub AddCard(ByVal objCard As Flashcard)
        mlstCardList.Add(objCard)
    End Sub



End Class
