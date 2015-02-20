' Author: Samuel Bristol
' Email: samuel.d.bristol@gmail.com
' Website: http://www.samuelbristol.com
' Date: 10/15/2014
' Purpose: A form to create a new flashcard.

Option Strict On
Option Explicit On

Public Class frmNewCard
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsValidated() Then
            ' Create a new flashcard object with the validated form inputs
            Dim objFlashcard As New Flashcard(txtKeyword.Text, txtAnswer.Text)

            ' Add new card to the Controller
            mobjCardController.AddCard(objFlashcard)

            ' Update the main form's controls
            frmMain.updateControls()

            ' Close this form
            Me.Close()
        End If
    End Sub

    Private Function IsValidated() As Boolean
        ' Return variable
        Dim blnResult As Boolean

        ' Are the inputs empty? If so, display an error message
        If txtKeyword.Text = String.Empty Then
            blnResult = False
            MessageBox.Show("The flashcard must have a keyword.")
        ElseIf txtAnswer.Text = String.Empty Then
            blnResult = False
            MessageBox.Show("The flashcard must have an answer.")
        Else
            ' Validation passes, inputs contain text
            blnResult = True
        End If

        Return blnResult
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close this form
        Me.Close()
    End Sub
End Class