Module KeszaruCimkezo

    Public Sub PrintZPL()
        Dim s As String
        Dim pd As New PrintDialog()
        Dim res As Boolean
        Dim FILE_NAME As String = "Cimkek.txt"
        Dim dlgRes As DialogResult

        Dim TextLine As String
        If Form1.CheckBoxEgyes.Checked Then
            s = labelcodes(0)
            s = s.Replace("VONALKOD", Form1.TextBoxCimke.Text)
            s = s.Replace("POLCNEV", Form1.TextBoxCimke.Text)
            s = s.Replace("POLCZPL", ZebraPrint.GetZPLutf8Code(Form1.TextBoxCimke.Text))
            s = s.Replace("LABELQTY", Form1.TextBoxPld.Text)

            Console.WriteLine(s)

            ' Open the printer dialog box, and then allow the user to select a printer.
            res = ZebraPrint.SendStringToPrinter(printerwinnames(Form1.ComboBoxPrinter.SelectedIndex), s)

        Else
            dlgRes = MessageBox.Show("Biztosan nyomtatod a Cimkek.txt tartalmát? Ez többszáz címke is lehet!", "FIGYELEM", MessageBoxButtons.YesNo)
            If dlgRes = DialogResult.Yes Then

                If System.IO.File.Exists(FILE_NAME) = True Then

                    Dim objReader As New System.IO.StreamReader(FILE_NAME)

                    Do While objReader.Peek() <> -1
                        TextLine = objReader.ReadLine()
                        s = labelcodes(0)
                        s = s.Replace("VONALKOD", TextLine)
                        s = s.Replace("POLCNEV", TextLine)
                        s = s.Replace("POLCZPL", ZebraPrint.GetZPLutf8Code(TextLine))
                        s = s.Replace("LABELQTY", Form1.TextBoxPld.Text)

                        Console.WriteLine(s)

                        ' Open the printer dialog box, and then allow the user to select a printer.
                        res = ZebraPrint.SendStringToPrinter(printerwinnames(Form1.ComboBoxPrinter.SelectedIndex), s)
                    Loop
                Else

                    MessageBox.Show("Cimkek.txt nem található")
                End If





            End If

        End If


        MessageBox.Show("Kész!")
    End Sub
End Module
