Public Class Form1
    Private Const MinFontSize As Single = 16.0F
    Private Const MaxFontSize As Single = 32.0F
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a new TableLayoutPanel and set Dock to fill the form
        Dim tableLayoutPanel As New TableLayoutPanel()
        tableLayoutPanel.Dock = DockStyle.Fill

        ' Set the number of rows and columns
        tableLayoutPanel.RowCount = 6
        tableLayoutPanel.ColumnCount = 5

        ' Define row styles based on the percentages you provided
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.56F)) ' Row 1
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 7.56F))  ' Row 2
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 8.67F))  ' Row 3
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 9.56F))  ' Row 4
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 8.22F))  ' Row 5
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.56F)) ' Row 6

        ' Define column styles based on the percentages you provided
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33F)) ' Column 1
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.67F)) ' Column 2
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.67F)) ' Column 3
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.13F)) ' Column 4
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 2.38F))  ' Column 5

        ' Optionally, add controls to specific cells
        ' For example, adding a Label in Row 1, Column 1
        Dim label1 As New Label()
        label1.Text = "Label 1"
        label1.Dock = DockStyle.Fill
        tableLayoutPanel.Controls.Add(label1, 0, 0) ' (column, row)

        ' Add TableLayoutPanel to the form
        Me.Controls.Add(tableLayoutPanel)
    End Sub
End Class
