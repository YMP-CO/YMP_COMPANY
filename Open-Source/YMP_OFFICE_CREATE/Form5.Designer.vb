<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.MetroToggle2 = New MetroFramework.Controls.MetroToggle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MetroToggle3 = New MetroFramework.Controls.MetroToggle()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Темы"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Цвет главного окна"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(23, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 39)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Выбрать цвет"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 39)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Работа с документами"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(116, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(421, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Показать бытрые действия при работе с документами?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(16, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(362, 39)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Работа с картинками"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(16, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(348, 39)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Работа с таблицами"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(430, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Пока это всё!"
        '
        'MetroToggle1
        '
        Me.MetroToggle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.MetroToggle1.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroToggle1.Location = New System.Drawing.Point(23, 171)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(87, 24)
        Me.MetroToggle1.TabIndex = 17
        Me.MetroToggle1.Text = "Off"
        Me.MetroToggle1.UseVisualStyleBackColor = True
        '
        'MetroToggle2
        '
        Me.MetroToggle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroToggle2.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.MetroToggle2.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroToggle2.Location = New System.Drawing.Point(23, 275)
        Me.MetroToggle2.Name = "MetroToggle2"
        Me.MetroToggle2.Size = New System.Drawing.Size(87, 24)
        Me.MetroToggle2.TabIndex = 18
        Me.MetroToggle2.Text = "Off"
        Me.MetroToggle2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 12.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(116, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(410, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Добавить кнопку ""Помощь по созданию скринштов""?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 12.25!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(116, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(403, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Показать бытрые действия при работе с таблицами?"
        '
        'MetroToggle3
        '
        Me.MetroToggle3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroToggle3.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.MetroToggle3.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.MetroToggle3.Location = New System.Drawing.Point(20, 371)
        Me.MetroToggle3.Name = "MetroToggle3"
        Me.MetroToggle3.Size = New System.Drawing.Size(87, 24)
        Me.MetroToggle3.TabIndex = 21
        Me.MetroToggle3.Text = "Off"
        Me.MetroToggle3.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(543, 444)
        Me.Controls.Add(Me.MetroToggle3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MetroToggle2)
        Me.Controls.Add(Me.MetroToggle1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.ShowIcon = False
        Me.Text = "Настройки"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MetroToggle1 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroToggle2 As MetroFramework.Controls.MetroToggle
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MetroToggle3 As MetroFramework.Controls.MetroToggle
End Class
