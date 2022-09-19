<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRYITOUT8
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStrings = New System.Windows.Forms.Button()
        Me.btnConcatenation = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.btnSubStrings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRY IT OUT : Working with Substrings"
        '
        'btnStrings
        '
        Me.btnStrings.Location = New System.Drawing.Point(37, 65)
        Me.btnStrings.Name = "btnStrings"
        Me.btnStrings.Size = New System.Drawing.Size(137, 23)
        Me.btnStrings.TabIndex = 1
        Me.btnStrings.Text = "Using Strings"
        Me.btnStrings.UseVisualStyleBackColor = True
        '
        'btnConcatenation
        '
        Me.btnConcatenation.Location = New System.Drawing.Point(37, 107)
        Me.btnConcatenation.Name = "btnConcatenation"
        Me.btnConcatenation.Size = New System.Drawing.Size(137, 23)
        Me.btnConcatenation.TabIndex = 2
        Me.btnConcatenation.Text = "Concatenation"
        Me.btnConcatenation.UseVisualStyleBackColor = True
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(37, 146)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(54, 23)
        Me.txtString.TabIndex = 3
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(99, 146)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(75, 23)
        Me.btnLength.TabIndex = 4
        Me.btnLength.Text = "Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'btnSubStrings
        '
        Me.btnSubStrings.Location = New System.Drawing.Point(41, 191)
        Me.btnSubStrings.Name = "btnSubStrings"
        Me.btnSubStrings.Size = New System.Drawing.Size(133, 23)
        Me.btnSubStrings.TabIndex = 5
        Me.btnSubStrings.Text = "SubStrings"
        Me.btnSubStrings.UseVisualStyleBackColor = True
        '
        'TRYITOUT8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSubStrings)
        Me.Controls.Add(Me.btnLength)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnConcatenation)
        Me.Controls.Add(Me.btnStrings)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TRYITOUT8"
        Me.Text = "TRYITOUT8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStrings As Button
    Friend WithEvents btnConcatenation As Button
    Friend WithEvents txtString As TextBox
    Friend WithEvents btnLength As Button
    Friend WithEvents btnSubStrings As Button
End Class
