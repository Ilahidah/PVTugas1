<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRYITOUT6
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRY IT OUT : Concatenation"
        '
        'btnStrings
        '
        Me.btnStrings.Location = New System.Drawing.Point(26, 56)
        Me.btnStrings.Name = "btnStrings"
        Me.btnStrings.Size = New System.Drawing.Size(147, 23)
        Me.btnStrings.TabIndex = 1
        Me.btnStrings.Text = "Using Strings"
        Me.btnStrings.UseVisualStyleBackColor = True
        '
        'btnConcatenation
        '
        Me.btnConcatenation.Location = New System.Drawing.Point(26, 97)
        Me.btnConcatenation.Name = "btnConcatenation"
        Me.btnConcatenation.Size = New System.Drawing.Size(147, 23)
        Me.btnConcatenation.TabIndex = 2
        Me.btnConcatenation.Text = "Concatenation"
        Me.btnConcatenation.UseVisualStyleBackColor = True
        '
        'TRYITOUT6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 197)
        Me.Controls.Add(Me.btnConcatenation)
        Me.Controls.Add(Me.btnStrings)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TRYITOUT6"
        Me.Text = "TRYITOUT6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStrings As Button
    Friend WithEvents btnConcatenation As Button
End Class
