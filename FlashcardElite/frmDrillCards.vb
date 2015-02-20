' Author: Samuel Bristol
' Email: samuel.d.bristol@gmail.com
' Website: http://www.samuelbristol.com
' Date: 10/15/2014
' Purpose: A form to drill flashcards until the user exits the form.

Option Strict On
Option Explicit On

Public Class frmDrillCards
    ' Variables
    Private mobjCardController As FlashcardController

    ' Properties
    Public Property Controller() As FlashcardController
        Get
            Return mobjCardController
        End Get
        Set(ByVal value As FlashcardController)
            mobjCardController = value
        End Set
    End Property

    ' Functions
    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        ' Hide the button
        btnShowAnswer.Visible = False

        ' Unhide the answer
        lblAnswer.Visible = True
    End Sub

    Private Sub btnNextCard_Click(sender As Object, e As EventArgs) Handles btnNextCard.Click
        ' Unide the show answer button, if hidden
        btnShowAnswer.Visible = True

        ' Hide the answer
        lblAnswer.Visible = False

        ' Display a random card
        DisplayRandomCard()
    End Sub

    Private Sub frmDrillCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayRandomCard()
    End Sub

    Private Sub DisplayRandomCard()
        ' Get a random card and display it to the user
        Dim objRandomCard = mobjCardController.GetRandomCard()

        ' Set the controls to the card's information
        lblKeyword.Text = objRandomCard.Keyword
        lblAnswer.Text = objRandomCard.Answer
    End Sub
End Class