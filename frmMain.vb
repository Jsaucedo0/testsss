'*******************************************
'*******************************************
'Programmer: Jaime Saucedo
'Course: ITSE 1332.10X1 (VB)
'Program purpose: Converts a users input into pig latin
'*******************************************
'*******************************************
#Region "Compiler_Directives"
'*******************************************
Option Explicit On
Option Strict On
Option Infer Off
#Disable Warning IDE1006
'*******************************************
#End Region
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Try
            'Converts the user input and display result
            lblPigLatinOutput.Text = ConvertStringToPigLatin(tbxEnglishWord.Text)

            'Sets focus to textbox and selects all
            tbxEnglishWord.Focus()
            tbxEnglishWord.SelectAll()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ConvertStringToPigLatin(word As String) As String

        'Declares variables
        Const LATIN_SUFFIX_AY As String = "ay"
        Dim strConvertedInput As String

        'Removes the first letter and place that letter at the end of the word
        strConvertedInput = word.Substring(1) + word.Substring(0, 1) + LATIN_SUFFIX_AY

        Return strConvertedInput

    End Function
End Class
