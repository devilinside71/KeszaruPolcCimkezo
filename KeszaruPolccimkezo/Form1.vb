Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadZPLSamples()
        Call LoadPrinters()
        'Call LoadTools()
        ComboBoxPrinter.Items.Clear()
        For Each lsa In printernames
            ComboBoxPrinter.Items.Add(lsa)
        Next
        ComboBoxPrinter.SelectedIndex = 0
        ComboBoxTipus.Items.Clear()
        For Each lsa In labelnames
            ComboBoxTipus.Items.Add(lsa)
        Next
        ComboBoxTipus.SelectedIndex = 0
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Call PrintZPL()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub CheckBoxEgyes_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBoxEgyes.Checked Then
            TextBoxCimke.Enabled = True
        Else
            TextBoxCimke.Enabled = False
        End If
    End Sub

    Private Sub CheckBoxEgyes_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxEgyes.CheckedChanged
        If CheckBoxEgyes.Checked Then
            TextBoxCimke.Enabled = True
        Else
            TextBoxCimke.Enabled = False
        End If
    End Sub
End Class
