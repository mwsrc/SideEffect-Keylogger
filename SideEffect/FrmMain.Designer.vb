<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.kClock = New System.Windows.Forms.Timer(Me.components)
        Me.tClock = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox.Location = New System.Drawing.Point(0, 0)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(397, 265)
        Me.TextBox.TabIndex = 0
        '
        'kClock
        '
        '
        'tClock
        '
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 265)
        Me.Controls.Add(Me.TextBox)
        Me.Name = "FrmMain"
        Me.Text = "SideEffect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox As TextBox
    Friend WithEvents kClock As Timer
    Friend WithEvents tClock As Timer
End Class
