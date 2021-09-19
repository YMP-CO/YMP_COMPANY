<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьКакToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ПечатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ЗакрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РедактироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВырезатьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ЖирныйШрифтToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ЦветШрифтаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ПоискToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПоискИЗаменаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КартинкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ДатаИВремяToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СимволToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СайтToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YmpcogithubioYMPCOMPANYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.AutoWordSelection = True
        Me.RichTextBox1.Location = New System.Drawing.Point(19, 89)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(954, 421)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "YMP DOCUMENT CREATE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.РедактироватьToolStripMenuItem, Me.ВставкаToolStripMenuItem, Me.ОПрограммеToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(19, 62)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(310, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СохранитьToolStripMenuItem, Me.СохранитьКакToolStripMenuItem, Me.ОткрытьToolStripMenuItem, Me.ToolStripSeparator1, Me.ПечатьToolStripMenuItem, Me.ToolStripSeparator2, Me.ЗакрытьToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СохранитьToolStripMenuItem
        '
        Me.СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem"
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.СохранитьToolStripMenuItem.Text = "Сохранить"
        '
        'СохранитьКакToolStripMenuItem
        '
        Me.СохранитьКакToolStripMenuItem.Name = "СохранитьКакToolStripMenuItem"
        Me.СохранитьКакToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.СохранитьКакToolStripMenuItem.Text = "Сохранить как"
        '
        'ОткрытьToolStripMenuItem
        '
        Me.ОткрытьToolStripMenuItem.Name = "ОткрытьToolStripMenuItem"
        Me.ОткрытьToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ОткрытьToolStripMenuItem.Text = "Открыть"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(151, 6)
        '
        'ПечатьToolStripMenuItem
        '
        Me.ПечатьToolStripMenuItem.Name = "ПечатьToolStripMenuItem"
        Me.ПечатьToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ПечатьToolStripMenuItem.Text = "Печать"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(151, 6)
        '
        'ЗакрытьToolStripMenuItem
        '
        Me.ЗакрытьToolStripMenuItem.Name = "ЗакрытьToolStripMenuItem"
        Me.ЗакрытьToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ЗакрытьToolStripMenuItem.Text = "Закрыть"
        '
        'РедактироватьToolStripMenuItem
        '
        Me.РедактироватьToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВырезатьToolStripMenuItem, Me.ВставитьToolStripMenuItem, Me.КопироватьToolStripMenuItem, Me.ToolStripSeparator3, Me.ЖирныйШрифтToolStripMenuItem, Me.ToolStripSeparator4, Me.ЦветШрифтаToolStripMenuItem, Me.ToolStripSeparator7, Me.ПоискToolStripMenuItem, Me.ПоискИЗаменаToolStripMenuItem})
        Me.РедактироватьToolStripMenuItem.Name = "РедактироватьToolStripMenuItem"
        Me.РедактироватьToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.РедактироватьToolStripMenuItem.Text = "Редактировать"
        '
        'ВырезатьToolStripMenuItem
        '
        Me.ВырезатьToolStripMenuItem.Name = "ВырезатьToolStripMenuItem"
        Me.ВырезатьToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ВырезатьToolStripMenuItem.Text = "Вырезать"
        '
        'ВставитьToolStripMenuItem
        '
        Me.ВставитьToolStripMenuItem.Name = "ВставитьToolStripMenuItem"
        Me.ВставитьToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ВставитьToolStripMenuItem.Text = "Вставить"
        '
        'КопироватьToolStripMenuItem
        '
        Me.КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        Me.КопироватьToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.КопироватьToolStripMenuItem.Text = "Копировать"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(178, 6)
        '
        'ЖирныйШрифтToolStripMenuItem
        '
        Me.ЖирныйШрифтToolStripMenuItem.Name = "ЖирныйШрифтToolStripMenuItem"
        Me.ЖирныйШрифтToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ЖирныйШрифтToolStripMenuItem.Text = "Настройка шрифта"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(178, 6)
        '
        'ЦветШрифтаToolStripMenuItem
        '
        Me.ЦветШрифтаToolStripMenuItem.Name = "ЦветШрифтаToolStripMenuItem"
        Me.ЦветШрифтаToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ЦветШрифтаToolStripMenuItem.Text = "Цвет шрифта"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(178, 6)
        '
        'ПоискToolStripMenuItem
        '
        Me.ПоискToolStripMenuItem.Name = "ПоискToolStripMenuItem"
        Me.ПоискToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ПоискToolStripMenuItem.Text = "Поиск"
        '
        'ПоискИЗаменаToolStripMenuItem
        '
        Me.ПоискИЗаменаToolStripMenuItem.Name = "ПоискИЗаменаToolStripMenuItem"
        Me.ПоискИЗаменаToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ПоискИЗаменаToolStripMenuItem.Text = "Поиск и замена"
        '
        'ВставкаToolStripMenuItem
        '
        Me.ВставкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КартинкаToolStripMenuItem, Me.ToolStripSeparator5, Me.ДатаИВремяToolStripMenuItem, Me.СимволToolStripMenuItem})
        Me.ВставкаToolStripMenuItem.Name = "ВставкаToolStripMenuItem"
        Me.ВставкаToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ВставкаToolStripMenuItem.Text = "Вставка"
        '
        'КартинкаToolStripMenuItem
        '
        Me.КартинкаToolStripMenuItem.Name = "КартинкаToolStripMenuItem"
        Me.КартинкаToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.КартинкаToolStripMenuItem.Text = "Картинка"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(143, 6)
        '
        'ДатаИВремяToolStripMenuItem
        '
        Me.ДатаИВремяToolStripMenuItem.Name = "ДатаИВремяToolStripMenuItem"
        Me.ДатаИВремяToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ДатаИВремяToolStripMenuItem.Text = "Дата и время"
        '
        'СимволToolStripMenuItem
        '
        Me.СимволToolStripMenuItem.Name = "СимволToolStripMenuItem"
        Me.СимволToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.СимволToolStripMenuItem.Text = "Символ"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СайтToolStripMenuItem, Me.ToolStripSeparator6, Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem})
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'СайтToolStripMenuItem
        '
        Me.СайтToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YmpcogithubioYMPCOMPANYToolStripMenuItem})
        Me.СайтToolStripMenuItem.Name = "СайтToolStripMenuItem"
        Me.СайтToolStripMenuItem.Size = New System.Drawing.Size(554, 22)
        Me.СайтToolStripMenuItem.Text = "Сайт"
        '
        'YmpcogithubioYMPCOMPANYToolStripMenuItem
        '
        Me.YmpcogithubioYMPCOMPANYToolStripMenuItem.Name = "YmpcogithubioYMPCOMPANYToolStripMenuItem"
        Me.YmpcogithubioYMPCOMPANYToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.YmpcogithubioYMPCOMPANYToolStripMenuItem.Text = "ymp-co.github.io/YMP_COMPANY"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(551, 6)
        '
        'YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem
        '
        Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem.Name = "YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem"
        Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem.Size = New System.Drawing.Size(554, 22)
        Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem.Text = "YMP DOCUMENT CREATE - Программа для написания простых документов. Версия: 1.8"
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "RichTextBox1"
        Me.PrintDocument1.OriginAtMargins = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowApply = True
        Me.FontDialog1.ShowColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.YMP_OFFICE_CREATE.My.MySettings.Default, "CPC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.Location = New System.Drawing.Point(635, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 24)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Вырезать"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = Global.YMP_OFFICE_CREATE.My.MySettings.Default.CPC
        '
        'Button2
        '
        Me.Button2.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.YMP_OFFICE_CREATE.My.MySettings.Default, "CPC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button2.Location = New System.Drawing.Point(543, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Вставить"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = Global.YMP_OFFICE_CREATE.My.MySettings.Default.CPC
        '
        'Button1
        '
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.YMP_OFFICE_CREATE.My.MySettings.Default, "CPC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.Location = New System.Drawing.Point(451, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Копировать"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = Global.YMP_OFFICE_CREATE.My.MySettings.Default.CPC
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MetroTile1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(718, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 421)
        Me.Panel1.TabIndex = 12
        '
        'MetroTile1
        '
        Me.MetroTile1.Location = New System.Drawing.Point(4, 4)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(122, 114)
        Me.MetroTile1.TabIndex = 0
        Me.MetroTile1.Text = "MetroTile1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(985, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "YMP DOCUMENT CREATE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьКакToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ПечатьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ЗакрытьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РедактироватьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВырезатьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВставитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КопироватьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ЖирныйШрифтToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ЦветШрифтаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВставкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КартинкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ДатаИВремяToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СимволToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СайтToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ПоискToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПоискИЗаменаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents ОткрытьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents YmpcogithubioYMPCOMPANYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
End Class
