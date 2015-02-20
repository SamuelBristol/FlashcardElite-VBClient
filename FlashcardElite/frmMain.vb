' Author: Samuel Bristol
' Email: samuel.d.bristol@gmail.com
' Website: http://www.samuelbristol.com
' Date: 10/15/2014
' Purpose: The main form for FlashcardElite.

Option Strict On
Option Explicit On

Public Class frmMain
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

    Private Sub btnNewCard_Click(sender As Object, e As EventArgs) Handles btnNewCard.Click
        ' Create the New Card form
        Dim frmNewCard As New frmNewCard

        ' Pass the form the controller
        frmNewCard.Controller = mobjCardController

        ' Show the form
        frmNewCard.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close this form
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create the card controller
        mobjCardController = New FlashcardController()
        UpdateControls()
    End Sub

    Public Sub UpdateControls()
        ' Populate the listbox with data
        For Each objCard In mobjCardController.GetAll
            lboMyCards.Items.Add(objCard.Keyword)
        Next
    End Sub

    Private Sub btnDrillCards_Click(sender As Object, e As EventArgs) Handles btnDrillCards.Click
        ' Create the Drill form
        Dim frmDrillCards As New frmDrillCards

        ' Pass the controller to the form
        frmDrillCards.Controller = mobjCardController

        ' Show the form
        frmDrillCards.ShowDialog()
    End Sub
End Class
