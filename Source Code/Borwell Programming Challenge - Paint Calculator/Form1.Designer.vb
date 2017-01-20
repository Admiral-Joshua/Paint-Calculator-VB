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
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.InstructionsLabel = New System.Windows.Forms.Label()
        Me.LengthLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InputTitleLabel = New System.Windows.Forms.Label()
        Me.HeightTextbox = New System.Windows.Forms.TextBox()
        Me.WidthTextbox = New System.Windows.Forms.TextBox()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.LengthTextbox = New System.Windows.Forms.TextBox()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TotalVolumeOutputLabel = New System.Windows.Forms.Label()
        Me.RoomVolumeTitleLabel = New System.Windows.Forms.Label()
        Me.WallAreaOutputLabel = New System.Windows.Forms.Label()
        Me.WallAreaTitleLabel = New System.Windows.Forms.Label()
        Me.SurfaceAreaOutputLabel = New System.Windows.Forms.Label()
        Me.SurfaceAreaLabel = New System.Windows.Forms.Label()
        Me.OutputTitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ActualPaintOutputLabel = New System.Windows.Forms.Label()
        Me.AmountOfPaintLabel = New System.Windows.Forms.Label()
        Me.PaintTypeLabel = New System.Windows.Forms.Label()
        Me.PaintTypeDropdownBox = New System.Windows.Forms.ComboBox()
        Me.PaintOutputTitleLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(6, 5)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(157, 37)
        Me.WelcomeLabel.TabIndex = 0
        Me.WelcomeLabel.Text = "Welcome"
        '
        'InstructionsLabel
        '
        Me.InstructionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionsLabel.Location = New System.Drawing.Point(10, 53)
        Me.InstructionsLabel.Name = "InstructionsLabel"
        Me.InstructionsLabel.Size = New System.Drawing.Size(457, 54)
        Me.InstructionsLabel.TabIndex = 1
        Me.InstructionsLabel.Text = "Welcome to the Room Size and Paint Required Calculator Program." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This program wil" &
    "l quickly calculate dimensions of the Room and tell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you how much paint you will" &
    " need to paint the walls."
        Me.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LengthLabel
        '
        Me.LengthLabel.Location = New System.Drawing.Point(4, 42)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(100, 25)
        Me.LengthLabel.TabIndex = 2
        Me.LengthLabel.Text = "Length: (in M)"
        Me.LengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InputTitleLabel)
        Me.GroupBox1.Controls.Add(Me.HeightTextbox)
        Me.GroupBox1.Controls.Add(Me.WidthTextbox)
        Me.GroupBox1.Controls.Add(Me.HeightLabel)
        Me.GroupBox1.Controls.Add(Me.LengthTextbox)
        Me.GroupBox1.Controls.Add(Me.WidthLabel)
        Me.GroupBox1.Controls.Add(Me.LengthLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(13, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 205)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'InputTitleLabel
        '
        Me.InputTitleLabel.AutoSize = True
        Me.InputTitleLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTitleLabel.Location = New System.Drawing.Point(15, 22)
        Me.InputTitleLabel.Name = "InputTitleLabel"
        Me.InputTitleLabel.Size = New System.Drawing.Size(166, 16)
        Me.InputTitleLabel.TabIndex = 8
        Me.InputTitleLabel.Text = "Input - Room Dimensions"
        '
        'HeightTextbox
        '
        Me.HeightTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightTextbox.Location = New System.Drawing.Point(37, 174)
        Me.HeightTextbox.Name = "HeightTextbox"
        Me.HeightTextbox.Size = New System.Drawing.Size(112, 24)
        Me.HeightTextbox.TabIndex = 7
        '
        'WidthTextbox
        '
        Me.WidthTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WidthTextbox.Location = New System.Drawing.Point(37, 121)
        Me.WidthTextbox.Name = "WidthTextbox"
        Me.WidthTextbox.Size = New System.Drawing.Size(112, 24)
        Me.WidthTextbox.TabIndex = 6
        '
        'HeightLabel
        '
        Me.HeightLabel.Location = New System.Drawing.Point(4, 148)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(100, 25)
        Me.HeightLabel.TabIndex = 4
        Me.HeightLabel.Text = "Height: (in M)"
        Me.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LengthTextbox
        '
        Me.LengthTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LengthTextbox.Location = New System.Drawing.Point(37, 65)
        Me.LengthTextbox.Name = "LengthTextbox"
        Me.LengthTextbox.Size = New System.Drawing.Size(112, 24)
        Me.LengthTextbox.TabIndex = 5
        '
        'WidthLabel
        '
        Me.WidthLabel.Location = New System.Drawing.Point(4, 95)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(100, 25)
        Me.WidthLabel.TabIndex = 3
        Me.WidthLabel.Text = "Width: (in M)"
        Me.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TotalVolumeOutputLabel)
        Me.GroupBox2.Controls.Add(Me.RoomVolumeTitleLabel)
        Me.GroupBox2.Controls.Add(Me.WallAreaOutputLabel)
        Me.GroupBox2.Controls.Add(Me.WallAreaTitleLabel)
        Me.GroupBox2.Controls.Add(Me.SurfaceAreaOutputLabel)
        Me.GroupBox2.Controls.Add(Me.SurfaceAreaLabel)
        Me.GroupBox2.Controls.Add(Me.OutputTitleLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 205)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'TotalVolumeOutputLabel
        '
        Me.TotalVolumeOutputLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalVolumeOutputLabel.Location = New System.Drawing.Point(6, 161)
        Me.TotalVolumeOutputLabel.Name = "TotalVolumeOutputLabel"
        Me.TotalVolumeOutputLabel.Size = New System.Drawing.Size(178, 22)
        Me.TotalVolumeOutputLabel.TabIndex = 16
        Me.TotalVolumeOutputLabel.Text = "35m Cubed"
        Me.TotalVolumeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoomVolumeTitleLabel
        '
        Me.RoomVolumeTitleLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomVolumeTitleLabel.Location = New System.Drawing.Point(6, 139)
        Me.RoomVolumeTitleLabel.Name = "RoomVolumeTitleLabel"
        Me.RoomVolumeTitleLabel.Size = New System.Drawing.Size(178, 22)
        Me.RoomVolumeTitleLabel.TabIndex = 15
        Me.RoomVolumeTitleLabel.Text = "Total Volume of Room:"
        Me.RoomVolumeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WallAreaOutputLabel
        '
        Me.WallAreaOutputLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WallAreaOutputLabel.Location = New System.Drawing.Point(6, 117)
        Me.WallAreaOutputLabel.Name = "WallAreaOutputLabel"
        Me.WallAreaOutputLabel.Size = New System.Drawing.Size(178, 22)
        Me.WallAreaOutputLabel.TabIndex = 14
        Me.WallAreaOutputLabel.Text = "50m Squared"
        Me.WallAreaOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WallAreaTitleLabel
        '
        Me.WallAreaTitleLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WallAreaTitleLabel.Location = New System.Drawing.Point(6, 95)
        Me.WallAreaTitleLabel.Name = "WallAreaTitleLabel"
        Me.WallAreaTitleLabel.Size = New System.Drawing.Size(178, 22)
        Me.WallAreaTitleLabel.TabIndex = 13
        Me.WallAreaTitleLabel.Text = "Total Area of Walls:"
        Me.WallAreaTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SurfaceAreaOutputLabel
        '
        Me.SurfaceAreaOutputLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurfaceAreaOutputLabel.Location = New System.Drawing.Point(6, 67)
        Me.SurfaceAreaOutputLabel.Name = "SurfaceAreaOutputLabel"
        Me.SurfaceAreaOutputLabel.Size = New System.Drawing.Size(178, 22)
        Me.SurfaceAreaOutputLabel.TabIndex = 12
        Me.SurfaceAreaOutputLabel.Text = "20m Squared"
        Me.SurfaceAreaOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SurfaceAreaLabel
        '
        Me.SurfaceAreaLabel.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurfaceAreaLabel.Location = New System.Drawing.Point(6, 45)
        Me.SurfaceAreaLabel.Name = "SurfaceAreaLabel"
        Me.SurfaceAreaLabel.Size = New System.Drawing.Size(178, 22)
        Me.SurfaceAreaLabel.TabIndex = 11
        Me.SurfaceAreaLabel.Text = "Surface Area of Floor:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.SurfaceAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OutputTitleLabel
        '
        Me.OutputTitleLabel.AutoSize = True
        Me.OutputTitleLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputTitleLabel.Location = New System.Drawing.Point(2, 16)
        Me.OutputTitleLabel.Name = "OutputTitleLabel"
        Me.OutputTitleLabel.Size = New System.Drawing.Size(186, 16)
        Me.OutputTitleLabel.TabIndex = 9
        Me.OutputTitleLabel.Text = "Output - Areas and Volumes"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ActualPaintOutputLabel)
        Me.GroupBox3.Controls.Add(Me.AmountOfPaintLabel)
        Me.GroupBox3.Controls.Add(Me.PaintTypeLabel)
        Me.GroupBox3.Controls.Add(Me.PaintTypeDropdownBox)
        Me.GroupBox3.Controls.Add(Me.PaintOutputTitleLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(446, 132)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'ActualPaintOutputLabel
        '
        Me.ActualPaintOutputLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualPaintOutputLabel.Location = New System.Drawing.Point(-1, 86)
        Me.ActualPaintOutputLabel.Name = "ActualPaintOutputLabel"
        Me.ActualPaintOutputLabel.Size = New System.Drawing.Size(447, 43)
        Me.ActualPaintOutputLabel.TabIndex = 21
        Me.ActualPaintOutputLabel.Text = "10 Litres of Paint"
        Me.ActualPaintOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AmountOfPaintLabel
        '
        Me.AmountOfPaintLabel.AutoSize = True
        Me.AmountOfPaintLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountOfPaintLabel.Location = New System.Drawing.Point(6, 70)
        Me.AmountOfPaintLabel.Name = "AmountOfPaintLabel"
        Me.AmountOfPaintLabel.Size = New System.Drawing.Size(244, 16)
        Me.AmountOfPaintLabel.TabIndex = 20
        Me.AmountOfPaintLabel.Text = "Amount of Paint Required for Room:"
        '
        'PaintTypeLabel
        '
        Me.PaintTypeLabel.AutoSize = True
        Me.PaintTypeLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaintTypeLabel.Location = New System.Drawing.Point(23, 38)
        Me.PaintTypeLabel.Name = "PaintTypeLabel"
        Me.PaintTypeLabel.Size = New System.Drawing.Size(158, 15)
        Me.PaintTypeLabel.TabIndex = 19
        Me.PaintTypeLabel.Text = "Type of Paint being Used: "
        '
        'PaintTypeDropdownBox
        '
        Me.PaintTypeDropdownBox.FormattingEnabled = True
        Me.PaintTypeDropdownBox.Items.AddRange(New Object() {"Dulux Matt Emulsion Paint ( 1 Litres / 13 Metres Squared )", "Generic Paint Type ( 1 Litres / 11 Metres Squared )"})
        Me.PaintTypeDropdownBox.Location = New System.Drawing.Point(187, 36)
        Me.PaintTypeDropdownBox.Name = "PaintTypeDropdownBox"
        Me.PaintTypeDropdownBox.Size = New System.Drawing.Size(253, 21)
        Me.PaintTypeDropdownBox.TabIndex = 18
        '
        'PaintOutputTitleLabel
        '
        Me.PaintOutputTitleLabel.AutoSize = True
        Me.PaintOutputTitleLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaintOutputTitleLabel.Location = New System.Drawing.Point(6, 14)
        Me.PaintOutputTitleLabel.Name = "PaintOutputTitleLabel"
        Me.PaintOutputTitleLabel.Size = New System.Drawing.Size(278, 16)
        Me.PaintOutputTitleLabel.TabIndex = 17
        Me.PaintOutputTitleLabel.Text = "Output - Amount of Paint Required:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 463)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.InstructionsLabel)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paint Required Calculator Program"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents InstructionsLabel As Label
    Friend WithEvents LengthLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InputTitleLabel As Label
    Friend WithEvents HeightTextbox As TextBox
    Friend WithEvents WidthTextbox As TextBox
    Friend WithEvents LengthTextbox As TextBox
    Friend WithEvents HeightLabel As Label
    Friend WithEvents WidthLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TotalVolumeOutputLabel As Label
    Friend WithEvents RoomVolumeTitleLabel As Label
    Friend WithEvents WallAreaOutputLabel As Label
    Friend WithEvents WallAreaTitleLabel As Label
    Friend WithEvents SurfaceAreaOutputLabel As Label
    Friend WithEvents SurfaceAreaLabel As Label
    Friend WithEvents OutputTitleLabel As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AmountOfPaintLabel As Label
    Friend WithEvents PaintTypeLabel As Label
    Friend WithEvents PaintTypeDropdownBox As ComboBox
    Friend WithEvents PaintOutputTitleLabel As Label
    Friend WithEvents ActualPaintOutputLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
