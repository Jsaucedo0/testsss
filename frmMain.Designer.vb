<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblEnglishWordDesc = New System.Windows.Forms.Label()
        Me.tbxEnglishWord = New System.Windows.Forms.TextBox()
        Me.lblPigLatinDesc = New System.Windows.Forms.Label()
        Me.lblPigLatinOutput = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnglishWordDesc
        '
        Me.lblEnglishWordDesc.AutoSize = True
        Me.lblEnglishWordDesc.Location = New System.Drawing.Point(171, 40)
        Me.lblEnglishWordDesc.Name = "lblEnglishWordDesc"
        Me.lblEnglishWordDesc.Size = New System.Drawing.Size(88, 17)
        Me.lblEnglishWordDesc.TabIndex = 0
        Me.lblEnglishWordDesc.Text = "Enter a word"
        '
        'tbxEnglishWord
        '
        Me.tbxEnglishWord.Location = New System.Drawing.Point(28, 69)
        Me.tbxEnglishWord.Name = "tbxEnglishWord"
        Me.tbxEnglishWord.Size = New System.Drawing.Size(375, 22)
        Me.tbxEnglishWord.TabIndex = 1
        Me.tbxEnglishWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPigLatinDesc
        '
        Me.lblPigLatinDesc.AutoSize = True
        Me.lblPigLatinDesc.Location = New System.Drawing.Point(142, 111)
        Me.lblPigLatinDesc.Name = "lblPigLatinDesc"
        Me.lblPigLatinDesc.Size = New System.Drawing.Size(146, 17)
        Me.lblPigLatinDesc.TabIndex = 2
        Me.lblPigLatinDesc.Text = "Your word in Pig Latin"
        '
        'lblPigLatinOutput
        '
        Me.lblPigLatinOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPigLatinOutput.Location = New System.Drawing.Point(28, 145)
        Me.lblPigLatinOutput.Name = "lblPigLatinOutput"
        Me.lblPigLatinOutput.Size = New System.Drawing.Size(375, 23)
        Me.lblPigLatinOutput.TabIndex = 3
        Me.lblPigLatinOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(28, 185)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(110, 30)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(293, 185)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 254)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblPigLatinOutput)
        Me.Controls.Add(Me.lblPigLatinDesc)
        Me.Controls.Add(Me.tbxEnglishWord)
        Me.Controls.Add(Me.lblEnglishWordDesc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "English to Pig Latin Convertor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnglishWordDesc As Label
    Friend WithEvents tbxEnglishWord As TextBox
    Friend WithEvents lblPigLatinDesc As Label
    Friend WithEvents lblPigLatinOutput As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
End Class
