<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Me.Calendar1 = New WindowsFormsCalendar.Calendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Draft = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Draft.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Calendar1
        '
        Me.Calendar1.CalendarTimeFormat = WindowsFormsCalendar.CalendarTimeFormat.TwentyFourHour
        Me.Calendar1.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Calendar1.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Calendar1.ForeColor = System.Drawing.Color.Tomato
        Me.Calendar1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Calendar1.ItemsBackgroundColor = System.Drawing.Color.RoyalBlue
        Me.Calendar1.ItemsFont = New System.Drawing.Font("VNI-Avo", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Calendar1.ItemsForeColor = System.Drawing.Color.Black
        Me.Calendar1.Location = New System.Drawing.Point(0, 1)
        Me.Calendar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 10000)
        Me.Calendar1.MaximumFullDays = 5
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.Scrollbars = WindowsFormsCalendar.CalendarScrollBars.Both
        Me.Calendar1.Size = New System.Drawing.Size(1186, 607)
        Me.Calendar1.TabIndex = 0
        Me.Calendar1.Text = "Calendar1"
        Me.Calendar1.TimeScale = WindowsFormsCalendar.CalendarTimeScale.SixtyMinutes
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Teko SemiBold", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome James,"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Winter 2024", "Spring 2024", "Summer 2023"})
        Me.ComboBox1.Location = New System.Drawing.Point(218, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(98, 29)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Fall 2024"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Winter 2024", "Spring 2024", "Summer 2023"})
        Me.ComboBox2.Location = New System.Drawing.Point(333, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(118, 29)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.Text = "Final Revised"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(470, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Filter Options"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(12, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 31)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Export"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button3.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(12, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 31)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Import"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button4.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(12, 316)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 31)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Email"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Draft
        '
        Me.Draft.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.Draft.Controls.Add(Me.TabPage1)
        Me.Draft.Controls.Add(Me.TabPage2)
        Me.Draft.Controls.Add(Me.TabPage3)
        Me.Draft.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Draft.Location = New System.Drawing.Point(161, 63)
        Me.Draft.Multiline = True
        Me.Draft.Name = "Draft"
        Me.Draft.SelectedIndex = 0
        Me.Draft.Size = New System.Drawing.Size(1197, 642)
        Me.Draft.TabIndex = 11
        Me.Draft.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Calendar1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1189, 608)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rivised Schedule"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1189, 608)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Final "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1189, 608)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "+"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGreen
        Me.Button5.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(1234, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 31)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Add Class"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("VNI-Avo", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(593, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "*Edit and Delete Class by Double Click at the Schedule "
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 717)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Draft)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainScreen"
        Me.Draft.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Draft As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Calendar1 As WindowsFormsCalendar.Calendar
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
End Class
