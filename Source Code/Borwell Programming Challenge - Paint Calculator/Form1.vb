Public Class Form1

    ' Quickly Defining a series of variables to store all the different types of data
    Public RoomLength As Decimal
    Public RoomWidth As Decimal
    Public RoomHeight As Decimal

    Public WallsX As Decimal
    Public WallsY As Decimal

    Public FloorArea As Decimal
    Public TotalWallArea As Decimal
    Public RoomVolume As Decimal

    Public PaintRequired As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' To start with, I clear the values of each of the labels I am using for output to the user.
        SurfaceAreaOutputLabel.Text = ""
        WallAreaOutputLabel.Text = ""
        TotalVolumeOutputLabel.Text = ""
        ActualPaintOutputLabel.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Checks each textbox to make sure they have a value entered in
        ' ( It checks the length of the text in the textbox to see whether it is larger than 0 )
        If LengthTextbox.Text.Length > 0 And WidthTextbox.Text.Length > 0 And HeightTextbox.Text.Length > 0 Then
            ' Checks to make sure that the data that has been inputed is in fact, numerical (numbers) and has no letters/symbols in
            '  ( By use of the IsNumeric function, built into Visual Basic )
            If IsNumeric(LengthTextbox.Text) And IsNumeric(WidthTextbox.Text) And IsNumeric(HeightTextbox.Text) Then
                ' Resets the Instructions Label with the default text, only added in so the error message is
                '  replaced when the user has entered the correct data.
                InstructionsLabel.Text = ("Welcome to the Room Size and Paint Required Calculator Program.
    This program will quickly calculate dimensions of the Room and tell
    you how much paint you will need to paint the walls.")
                InstructionsLabel.ForeColor = Color.Black

                ' Assigning the Width, Length and Height variables with the text in the textboxes.
                '  (After converting them to Decimal values as you can not perform mathematical calculations with a string data type.
                RoomWidth = CDec(WidthTextbox.Text)
                RoomHeight = CDec(HeightTextbox.Text)
                RoomLength = CDec(LengthTextbox.Text)

                ' Performing the Mathematical Calculations for Surface area of the floor and the 2 pairs of matching walls.
                FloorArea = (RoomWidth * RoomLength)
                WallsX = (RoomWidth * RoomHeight) * 2   ' Multiplied by 2 as there will be 2 matching walls in the room.
                WallsY = (RoomLength * RoomHeight) * 2

                ' Adds together both pairs of wall values so that we get a total surface area.
                TotalWallArea = WallsX + WallsY
                ' Calculates the total volume of the room and stores it in the 'RoomVolume' variable.
                RoomVolume = (RoomWidth * RoomLength * RoomHeight)

                ' This part assigns the values of each of the labels in the form to the correct values
                SurfaceAreaOutputLabel.Text = FloorArea.ToString() + " Metres Squared"
                WallAreaOutputLabel.Text = TotalWallArea.ToString() + " Metres Squared"
                TotalVolumeOutputLabel.Text = RoomVolume.ToString() + " Metres Cubed"


                ' This part of the code now checks to see what Paint Type the user has selected from the dropdown box.
                ' If they have the chosen the "Dulux Matt Emulsion" option, then the program will proceed to use the 13 Metres Squared value
                If PaintTypeDropdownBox.Text = "Dulux Matt Emulsion Paint ( 1 Litres / 13 Metres Squared )" Then
                    ' Program proceeds to divide the Total Wall Area (that needs covering) by the number of metres a single litre will cover.
                    PaintRequired = TotalWallArea / 13
                    ' Alternatively if the user selects the other option "Generic Paint Type" it will use the 11 Metres squared value
                ElseIf PaintTypeDropdownBox.Text = "Generic Paint Type ( 1 Litres / 11 Metres Squared )" Then
                    ' Program proceeds to divide the Total Wall Area (that needs covering) by the number of metres a single litre will cover.
                    PaintRequired = TotalWallArea / 11
                End If
                ' The Final Label that will show to the user the 
                ActualPaintOutputLabel.Text = Math.Round(PaintRequired, 1).ToString() + " Litres of Paint"
            Else
                InstructionsLabel.Text = "Invalid Input!
This error means you have accidentally entered a non-numeric value into the size fields."
                InstructionsLabel.ForeColor = Color.Red
            End If
        End If

    End Sub
End Class
