<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.ReoGridControl1 = New unvell.ReoGrid.ReoGridControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьКакToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ЗакрытьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СимволToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СайтToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YmpcogithubioYMPCOMPANYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReoGridControl1
        '
        Me.ReoGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReoGridControl1.BackColor = System.Drawing.Color.White
        Me.ReoGridControl1.ColumnHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.LeadHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.Location = New System.Drawing.Point(19, 93)
        Me.ReoGridControl1.Name = "ReoGridControl1"
        Me.ReoGridControl1.RowHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.Script = Nothing
        Me.ReoGridControl1.SheetTabContextMenuStrip = Nothing
        Me.ReoGridControl1.SheetTabNewButtonVisible = True
        Me.ReoGridControl1.SheetTabVisible = True
        Me.ReoGridControl1.SheetTabWidth = 60
        Me.ReoGridControl1.ShowScrollEndSpacing = True
        Me.ReoGridControl1.Size = New System.Drawing.Size(881, 421)
        Me.ReoGridControl1.TabIndex = 0
        Me.ReoGridControl1.Text = "ReoGridControl1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "YMP TABLES CREATE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ВставкаToolStripMenuItem, Me.ОПрограммеToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(19, 66)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(211, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СохранитьToolStripMenuItem, Me.СохранитьКакToolStripMenuItem, Me.ОткрытьToolStripMenuItem, Me.ToolStripSeparator1, Me.ЗакрытьToolStripMenuItem})
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
        'ЗакрытьToolStripMenuItem
        '
        Me.ЗакрытьToolStripMenuItem.Name = "ЗакрытьToolStripMenuItem"
        Me.ЗакрытьToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ЗакрытьToolStripMenuItem.Text = "Закрыть"
        '
        'ВставкаToolStripMenuItem
        '
        Me.ВставкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СимволToolStripMenuItem})
        Me.ВставкаToolStripMenuItem.Name = "ВставкаToolStripMenuItem"
        Me.ВставкаToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ВставкаToolStripMenuItem.Text = "Вставка"
        '
        'СимволToolStripMenuItem
        '
        Me.СимволToolStripMenuItem.Name = "СимволToolStripMenuItem"
        Me.СимволToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
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
        Me.СайтToolStripMenuItem.Size = New System.Drawing.Size(501, 22)
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
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(498, 6)
        '
        'YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem
        '
        Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem.Name = "YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem"
        Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem.Size = New System.Drawing.Size(501, 22)
        Me.YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem.Text = "YMP TABLES CREATE - Программа для написания простых таблиц. Версия: 1.0"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "*.rgf|*.rgf|*,*|*.*"
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(633, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 421)
        Me.Panel1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(2, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Советы:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(-4, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 340)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(227, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.YMP_OFFICE_CREATE.My.MySettings.Default, "CPC2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button5.Location = New System.Drawing.Point(598, 63)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(29, 24)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = ">"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = Global.YMP_OFFICE_CREATE.My.MySettings.Default.CPC2
        '
        'Button4
        '
        Me.Button4.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Global.YMP_OFFICE_CREATE.My.MySettings.Default, "CPC2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button4.Location = New System.Drawing.Point(570, 63)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(28, 24)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = Global.YMP_OFFICE_CREATE.My.MySettings.Default.CPC2
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(906, 526)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReoGridControl1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReoGridControl1 As unvell.ReoGrid.ReoGridControl
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьКакToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОткрытьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ЗакрытьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВставкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СимволToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СайтToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YmpcogithubioYMPCOMPANYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents YMPDOCUMENTCREATEПрограммаДляНаписанияПростыхДокументовВерсия10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
