Imports System.IO
Imports System.Text
Public Class Main_Form


    Public Function getDictionaryString() As String
        Dim fileReader As New System.IO.StreamReader("../../dictionary.txt")
        Dim sbDictionary As StringBuilder = New StringBuilder()
        Do While fileReader.Peek() <> -1
            sbDictionary.Append(fileReader.ReadLine())
            sbDictionary.Append(" ")

        Loop

        Return sbDictionary.ToString()
        getDictionaryString.Split(" ")

    End Function

    Dim arrLettersGuessed As ArrayList
    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
     
        Dim guess As String = txtguess.Text
        Dim totnumatt As Integer = 20
        Dim count As Integer = arrLettersGuessed.Count
        If arrLettersGuessed.Contains(guess) Then
            MessageBox.Show("already guessed that letter, try again")

        Else

            arrLettersGuessed.Add(guess)
        End If

        lblAttUsed.Text = count.ToString() + 1


        If totnumatt <= 20 Then
            For Each guess In totnumatt.ToString()

                txtUsedLetters.Text = arrLettersGuessed(count).ToString()
                lblUsedLetters.Text = arrLettersGuessed.Item(0).ToString()


                updateDisplayWord()
                txtguess.Clear()

            Next

        End If

    End Sub


    Private Sub updateDisplayWord()
        Dim displayWord As String = String.Empty
        For i As Integer = 0 To getDictionaryString().Length - 1
            Dim checkLetter As String = getDictionaryString(i)
            If (arrLettersGuessed.Contains(checkLetter)) Then
                displayWord = displayWord & checkLetter
            Else
                displayWord = displayWord & "*"
            End If
        Next
        txtWord.Text = displayWord
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'txtSecretWord.Text = secretWord
        getDictionaryString.Split(" ")

        arrLettersGuessed = New ArrayList()

        updateDisplayWord()

    End Sub

    Private Sub btnGiveUp_Click(sender As System.Object, e As System.EventArgs) Handles btnGiveUp.Click
        txtWord.Text = getDictionaryString.ToString()
        btnCheck.Hide()
    End Sub

    Private Sub btnrestart_Click(sender As System.Object, e As System.EventArgs) Handles btnrestart.Click
        btnCheck.Show()
        txtguess.Clear()
        lblUsedLetters.Text = String.Empty
        lblAttUsed.Text = String.Empty
        updateDisplayWord()
        txtguess.Focus()

    End Sub
End Class



