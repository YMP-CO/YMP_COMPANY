<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 30.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(386, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 54)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Добро пожаловать!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(390, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 50)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Создавайте быстро икомфортно документы, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "картинки, таблицы и презентации!"
        '
        'MetroTile2
        '
        Me.MetroTile2.Location = New System.Drawing.Point(184, 12)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(166, 149)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTile2.TabIndex = 7
        Me.MetroTile2.Text = "Создать таблицу"
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        '
        'MetroTile3
        '
        Me.MetroTile3.Location = New System.Drawing.Point(12, 168)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(165, 145)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTile3.TabIndex = 8
        Me.MetroTile3.Text = "Создать картинку"
        Me.MetroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        '
        'MetroTile4
        '
        Me.MetroTile4.Location = New System.Drawing.Point(184, 168)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(166, 145)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTile4.TabIndex = 9
        Me.MetroTile4.Text = "Открыть PDF"
        Me.MetroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        '
        'MetroPanel1
        '
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(357, 13)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(23, 346)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Black
        Me.MetroPanel1.TabIndex = 10
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroTile5
        '
        Me.MetroTile5.Location = New System.Drawing.Point(386, 168)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(160, 145)
        Me.MetroTile5.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTile5.TabIndex = 11
        Me.MetroTile5.Text = "Настройки"
        Me.MetroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        '
        'MetroTile6
        '
        Me.MetroTile6.Location = New System.Drawing.Point(552, 168)
        Me.MetroTile6.Name = "MetroTile6"
        Me.MetroTile6.Size = New System.Drawing.Size(164, 145)
        Me.MetroTile6.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTile6.TabIndex = 12
        Me.MetroTile6.Text = "Закрыть"
        Me.MetroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        '
        'MetroTile1
        '
        Me.MetroTile1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.MetroTile1.Location = New System.Drawing.Point(12, 12)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(165, 149)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile1.TabIndex = 6
        Me.MetroTile1.Text = "Создать документ"
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile1.TileImage = Global.YMP_OFFICE_CREATE.My.Resources.Resources.dc
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.YMP_OFFICE_CREATE.My.MySettings.Default.color_phone
        Me.ClientSize = New System.Drawing.Size(776, 371)
        Me.Controls.Add(Me.MetroTile6)
        Me.Controls.Add(Me.MetroTile5)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.YMP_OFFICE_CREATE.My.MySettings.Default, "color_phone", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.Name = "Form1"
        Me.Text = "YMP_OFFICE_CREATE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
End Class
