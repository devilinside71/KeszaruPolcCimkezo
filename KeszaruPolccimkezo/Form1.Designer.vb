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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPrinter = New System.Windows.Forms.ComboBox()
        Me.TextBoxCimke = New System.Windows.Forms.TextBox()
        Me.TextBoxPld = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBoxEgyes = New System.Windows.Forms.CheckBox()
        Me.ComboBoxTipus = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.46369!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.02794!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.50838!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonPrint, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxPrinter, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxCimke, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPld, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(717, 138)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonPrint.Location = New System.Drawing.Point(565, 72)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(149, 63)
        Me.ButtonPrint.TabIndex = 0
        Me.ButtonPrint.Text = "Nyomtat"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 69)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nyomtató:"
        '
        'ComboBoxPrinter
        '
        Me.ComboBoxPrinter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBoxPrinter.FormattingEnabled = True
        Me.ComboBoxPrinter.Location = New System.Drawing.Point(171, 72)
        Me.ComboBoxPrinter.Name = "ComboBoxPrinter"
        Me.ComboBoxPrinter.Size = New System.Drawing.Size(388, 45)
        Me.ComboBoxPrinter.TabIndex = 2
        '
        'TextBoxCimke
        '
        Me.TextBoxCimke.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCimke.Enabled = False
        Me.TextBoxCimke.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxCimke.Location = New System.Drawing.Point(171, 3)
        Me.TextBoxCimke.Name = "TextBoxCimke"
        Me.TextBoxCimke.Size = New System.Drawing.Size(388, 40)
        Me.TextBoxCimke.TabIndex = 4
        '
        'TextBoxPld
        '
        Me.TextBoxPld.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxPld.Location = New System.Drawing.Point(565, 3)
        Me.TextBoxPld.Name = "TextBoxPld"
        Me.TextBoxPld.Size = New System.Drawing.Size(100, 44)
        Me.TextBoxPld.TabIndex = 5
        Me.TextBoxPld.Text = "2"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBoxEgyes, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBoxTipus, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(162, 63)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'CheckBoxEgyes
        '
        Me.CheckBoxEgyes.AutoSize = True
        Me.CheckBoxEgyes.Location = New System.Drawing.Point(3, 3)
        Me.CheckBoxEgyes.Name = "CheckBoxEgyes"
        Me.CheckBoxEgyes.Size = New System.Drawing.Size(136, 17)
        Me.CheckBoxEgyes.TabIndex = 4
        Me.CheckBoxEgyes.Text = "Egyes címkenyomtatás"
        Me.CheckBoxEgyes.UseVisualStyleBackColor = True
        '
        'ComboBoxTipus
        '
        Me.ComboBoxTipus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxTipus.FormattingEnabled = True
        Me.ComboBoxTipus.Items.AddRange(New Object() {"Steril polc", "Kisdoboz"})
        Me.ComboBoxTipus.Location = New System.Drawing.Point(3, 34)
        Me.ComboBoxTipus.Name = "ComboBoxTipus"
        Me.ComboBoxTipus.Size = New System.Drawing.Size(156, 21)
        Me.ComboBoxTipus.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 138)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Készáru raktár polccímkéző    ©2020 Sanatmetal Kft Logisztika"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxPrinter As ComboBox
    Friend WithEvents TextBoxCimke As TextBox
    Friend WithEvents TextBoxPld As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents CheckBoxEgyes As CheckBox
    Friend WithEvents ComboBoxTipus As ComboBox
End Class
