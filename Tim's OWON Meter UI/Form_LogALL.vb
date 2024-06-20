
Imports System.IO

Public Class Form_LogALL


	Private File_Name As String
	Private String_Value As String
	Private IsLogging As Boolean = False


	Private Sub Form_LogALL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		File_Name = My.Settings.LogFileName
		Location = My.Settings.Form_LogALL_Location

	End Sub
	Private Sub Form_LogALL_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

		Form1.LogALL = False
		IsLogging = False

	End Sub

	Private Sub Button_File_Click(sender As Object, e As EventArgs) Handles Button_ChooseFile.Click

		Dim saveFileDialog As New SaveFileDialog()
		saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
		saveFileDialog.Title = "Create a New Text File"

		If saveFileDialog.ShowDialog() = DialogResult.OK Then
			' User selected a location and entered a file name
			File_Name = saveFileDialog.FileName
			My.Settings.LogFileName = File_Name
			Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(File_Name)
			TextBox_FileName.Text = fileNameWithoutExtension

			' Create an empty text file
			File.WriteAllText(File_Name, String.Empty)

			' Update the label with the file name
			Label_Value.Text = fileNameWithoutExtension
		End If

	End Sub

	Public Sub ProcessOutputData(recived_OwonB41T_Output As String)


		Label_Value.Text = recived_OwonB41T_Output
		If IsLogging Then

			' Append the output to a text file (each output on a new line)
			Dim _newLine As String = recived_OwonB41T_Output.TrimEnd(vbCr, vbLf)

			' Add a tab character and the current date and time
			_newLine = $"{_newLine}{vbTab}{DateTime.Now:yyyy-MM-dd}" & vbTab & $"{DateTime.Now:HH:mm:ss.fff}"

			Using writer As New StreamWriter(File_Name, True) ' 'True' appends to the file
				writer.WriteLine(_newLine)
			End Using

		End If

	End Sub

	Private Sub Button_StartLoggingALL_Click(sender As Object, e As EventArgs) Handles Button_StartLoggingALL.Click

		If Not File.Exists(File_Name) Then
			IsLogging = False
			MessageBox.Show("The file does not exist. Please create it first.")
		Else

			If IsLogging Then
				IsLogging = False
				Label_Status.Text = "Idle"
				Button_StartLoggingALL.Text = "Start Logging"
				Button_StartLoggingALL.ForeColor = Color.Yellow
				Button_StartLoggingALL.BackColor = Color.Green

			Else
				IsLogging = True
				Label_Status.Text = "Writing Log"
				Button_StartLoggingALL.Text = "Stop"
				Button_StartLoggingALL.ForeColor = Color.Blue
				Button_StartLoggingALL.BackColor = Color.Red

			End If

		End If
	End Sub

End Class