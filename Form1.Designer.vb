<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 500
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(673, 28)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(701, 95)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(61, 23)
        Me.txtTime.TabIndex = 1
        Me.txtTime.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(654, 98)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(36, 15)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time:"
        Me.lblTime.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrTimer As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblTime As Label
End Class
