<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRYITOUT20
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
        Me.btnScope = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRY IT OUT Scope"
        '
        'btnScope
        '
        Me.btnScope.Location = New System.Drawing.Point(18, 52)
        Me.btnScope.Name = "btnScope"
        Me.btnScope.Size = New System.Drawing.Size(75, 23)
        Me.btnScope.TabIndex = 1
        Me.btnScope.Text = "scope"
        Me.btnScope.UseVisualStyleBackColor = True
        '
        'TRYITOUT20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnScope)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TRYITOUT20"
        Me.Text = "TRYITOUT20"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnScope As Button
End Class
