<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.Blue
        Me.CircularProgressBar1.InnerColor = System.Drawing.SystemColors.ActiveCaption
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(37, 12)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Maximum = 60
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.Yellow
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.Cyan
        Me.CircularProgressBar1.ProgressWidth = 25
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(229, 219)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ""
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = ""
        Me.CircularProgressBar1.TabIndex = 0
        Me.CircularProgressBar1.Text = "00:00:00"
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Digital-7", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(109, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "000"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(30, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(114, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(30, 285)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(241, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "lap"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(12, 314)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(276, 123)
        Me.ListBox1.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(196, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
End Class
