<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_LogALL
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Button_StartLoggingALL = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button_ChooseFile = New System.Windows.Forms.Button()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.Label_Value = New System.Windows.Forms.Label()
		Me.Label_Status = New System.Windows.Forms.Label()
		Me.TextBox_FileName = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Button_StartLoggingALL
		'
		Me.Button_StartLoggingALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button_StartLoggingALL.BackColor = System.Drawing.Color.Green
		Me.Button_StartLoggingALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_StartLoggingALL.ForeColor = System.Drawing.Color.Yellow
		Me.Button_StartLoggingALL.Location = New System.Drawing.Point(319, 56)
		Me.Button_StartLoggingALL.Name = "Button_StartLoggingALL"
		Me.Button_StartLoggingALL.Size = New System.Drawing.Size(156, 40)
		Me.Button_StartLoggingALL.TabIndex = 0
		Me.Button_StartLoggingALL.Text = "Start Logging ALL"
		Me.Button_StartLoggingALL.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(51, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Save To:"
		'
		'Button_ChooseFile
		'
		Me.Button_ChooseFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button_ChooseFile.Location = New System.Drawing.Point(397, 10)
		Me.Button_ChooseFile.Name = "Button_ChooseFile"
		Me.Button_ChooseFile.Size = New System.Drawing.Size(75, 23)
		Me.Button_ChooseFile.TabIndex = 4
		Me.Button_ChooseFile.Text = "Choose File"
		Me.Button_ChooseFile.UseVisualStyleBackColor = True
		'
		'Label_Value
		'
		Me.Label_Value.AutoSize = True
		Me.Label_Value.Location = New System.Drawing.Point(66, 35)
		Me.Label_Value.Name = "Label_Value"
		Me.Label_Value.Size = New System.Drawing.Size(34, 13)
		Me.Label_Value.TabIndex = 5
		Me.Label_Value.Text = "Value"
		'
		'Label_Status
		'
		Me.Label_Status.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label_Status.Location = New System.Drawing.Point(69, 56)
		Me.Label_Status.Name = "Label_Status"
		Me.Label_Status.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label_Status.Size = New System.Drawing.Size(234, 40)
		Me.Label_Status.TabIndex = 6
		Me.Label_Status.Text = "Idle"
		Me.Label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox_FileName
		'
		Me.TextBox_FileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox_FileName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Tim_s_OWON_Meter_UI.My.MySettings.Default, "TextBox_FileName_Text", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.TextBox_FileName.Location = New System.Drawing.Point(69, 12)
		Me.TextBox_FileName.Name = "TextBox_FileName"
		Me.TextBox_FileName.Size = New System.Drawing.Size(322, 20)
		Me.TextBox_FileName.TabIndex = 2
		Me.TextBox_FileName.Text = Global.Tim_s_OWON_Meter_UI.My.MySettings.Default.TextBox_FileName_Text
		'
		'Form_LogALL
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(484, 106)
		Me.Controls.Add(Me.Label_Status)
		Me.Controls.Add(Me.Label_Value)
		Me.Controls.Add(Me.Button_ChooseFile)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox_FileName)
		Me.Controls.Add(Me.Button_StartLoggingALL)
		Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Tim_s_OWON_Meter_UI.My.MySettings.Default, "Form_LogALL_Location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Location = Global.Tim_s_OWON_Meter_UI.My.MySettings.Default.Form_LogALL_Location
		Me.Name = "Form_LogALL"
		Me.Text = "LogALL"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button_StartLoggingALL As Button
	Friend WithEvents TextBox_FileName As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Button_ChooseFile As Button
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents Label_Value As Label
	Friend WithEvents Label_Status As Label
End Class
