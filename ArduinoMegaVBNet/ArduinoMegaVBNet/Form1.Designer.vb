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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelConnectionStatusArduino = New System.Windows.Forms.Label()
        Me.TextBoxArduino = New System.Windows.Forms.TextBox()
        Me.ButtonConnectArduino = New System.Windows.Forms.Button()
        Me.TextBoxTimbangan = New System.Windows.Forms.TextBox()
        Me.LabelConnectionStatusTimbangan = New System.Windows.Forms.Label()
        Me.ButtonConnectTimbangan = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonLEDOFF = New System.Windows.Forms.Button()
        Me.ButtonLEDON = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lampu = New System.Windows.Forms.Button()
        Me.SerialPortArduino = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortTimbangan = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.TxtRichTemp = New System.Windows.Forms.RichTextBox()
        Me.TxtPerintah = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelConnectionStatusArduino)
        Me.GroupBox1.Controls.Add(Me.TextBoxArduino)
        Me.GroupBox1.Controls.Add(Me.ButtonConnectArduino)
        Me.GroupBox1.Controls.Add(Me.TextBoxTimbangan)
        Me.GroupBox1.Controls.Add(Me.LabelConnectionStatusTimbangan)
        Me.GroupBox1.Controls.Add(Me.ButtonConnectTimbangan)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'LabelConnectionStatusArduino
        '
        Me.LabelConnectionStatusArduino.AutoSize = True
        Me.LabelConnectionStatusArduino.Location = New System.Drawing.Point(150, 99)
        Me.LabelConnectionStatusArduino.Name = "LabelConnectionStatusArduino"
        Me.LabelConnectionStatusArduino.Size = New System.Drawing.Size(117, 13)
        Me.LabelConnectionStatusArduino.TabIndex = 6
        Me.LabelConnectionStatusArduino.Text = "Status Koneksi Arduino"
        '
        'TextBoxArduino
        '
        Me.TextBoxArduino.Location = New System.Drawing.Point(159, 131)
        Me.TextBoxArduino.Multiline = True
        Me.TextBoxArduino.Name = "TextBoxArduino"
        Me.TextBoxArduino.Size = New System.Drawing.Size(108, 79)
        Me.TextBoxArduino.TabIndex = 5
        '
        'ButtonConnectArduino
        '
        Me.ButtonConnectArduino.Location = New System.Drawing.Point(130, 15)
        Me.ButtonConnectArduino.Name = "ButtonConnectArduino"
        Me.ButtonConnectArduino.Size = New System.Drawing.Size(137, 31)
        Me.ButtonConnectArduino.TabIndex = 4
        Me.ButtonConnectArduino.Text = "Connect Arduino"
        Me.ButtonConnectArduino.UseVisualStyleBackColor = True
        '
        'TextBoxTimbangan
        '
        Me.TextBoxTimbangan.Location = New System.Drawing.Point(6, 131)
        Me.TextBoxTimbangan.Multiline = True
        Me.TextBoxTimbangan.Name = "TextBoxTimbangan"
        Me.TextBoxTimbangan.Size = New System.Drawing.Size(108, 79)
        Me.TextBoxTimbangan.TabIndex = 3
        '
        'LabelConnectionStatusTimbangan
        '
        Me.LabelConnectionStatusTimbangan.AutoSize = True
        Me.LabelConnectionStatusTimbangan.Location = New System.Drawing.Point(6, 99)
        Me.LabelConnectionStatusTimbangan.Name = "LabelConnectionStatusTimbangan"
        Me.LabelConnectionStatusTimbangan.Size = New System.Drawing.Size(134, 13)
        Me.LabelConnectionStatusTimbangan.TabIndex = 2
        Me.LabelConnectionStatusTimbangan.Text = "Status Koneksi Timbangan"
        '
        'ButtonConnectTimbangan
        '
        Me.ButtonConnectTimbangan.Location = New System.Drawing.Point(130, 52)
        Me.ButtonConnectTimbangan.Name = "ButtonConnectTimbangan"
        Me.ButtonConnectTimbangan.Size = New System.Drawing.Size(137, 32)
        Me.ButtonConnectTimbangan.TabIndex = 1
        Me.ButtonConnectTimbangan.Text = "Connect Timbangan"
        Me.ButtonConnectTimbangan.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 15)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(108, 69)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonLEDOFF)
        Me.GroupBox2.Controls.Add(Me.ButtonLEDON)
        Me.GroupBox2.Location = New System.Drawing.Point(338, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 79)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LED Control"
        '
        'ButtonLEDOFF
        '
        Me.ButtonLEDOFF.Location = New System.Drawing.Point(117, 28)
        Me.ButtonLEDOFF.Name = "ButtonLEDOFF"
        Me.ButtonLEDOFF.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLEDOFF.TabIndex = 1
        Me.ButtonLEDOFF.Text = "LED OFF"
        Me.ButtonLEDOFF.UseVisualStyleBackColor = True
        '
        'ButtonLEDON
        '
        Me.ButtonLEDON.Location = New System.Drawing.Point(18, 28)
        Me.ButtonLEDON.Name = "ButtonLEDON"
        Me.ButtonLEDON.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLEDON.TabIndex = 0
        Me.ButtonLEDON.Text = "LED ON"
        Me.ButtonLEDON.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.Lampu)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(338, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 117)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LED Status"
        '
        'Lampu
        '
        Me.Lampu.BackColor = System.Drawing.Color.Transparent
        Me.Lampu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lampu.Location = New System.Drawing.Point(27, 35)
        Me.Lampu.Name = "Lampu"
        Me.Lampu.Size = New System.Drawing.Size(161, 51)
        Me.Lampu.TabIndex = 0
        Me.Lampu.UseVisualStyleBackColor = False
        '
        'SerialPortArduino
        '
        '
        'SerialPortTimbangan
        '
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtPerintah)
        Me.GroupBox4.Controls.Add(Me.BtnStop)
        Me.GroupBox4.Controls.Add(Me.BtnStart)
        Me.GroupBox4.Location = New System.Drawing.Point(595, 38)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(211, 216)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Button Control"
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(117, 28)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(75, 56)
        Me.BtnStop.TabIndex = 1
        Me.BtnStop.Text = "STOP"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(18, 28)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 56)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "START"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'TxtRichTemp
        '
        Me.TxtRichTemp.Location = New System.Drawing.Point(21, 268)
        Me.TxtRichTemp.Name = "TxtRichTemp"
        Me.TxtRichTemp.Size = New System.Drawing.Size(785, 96)
        Me.TxtRichTemp.TabIndex = 3
        Me.TxtRichTemp.Text = ""
        '
        'TxtPerintah
        '
        Me.TxtPerintah.Location = New System.Drawing.Point(18, 106)
        Me.TxtPerintah.Multiline = True
        Me.TxtPerintah.Name = "TxtPerintah"
        Me.TxtPerintah.Size = New System.Drawing.Size(174, 79)
        Me.TxtPerintah.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 505)
        Me.Controls.Add(Me.TxtRichTemp)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelConnectionStatusTimbangan As Label
    Friend WithEvents ButtonConnectTimbangan As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonLEDOFF As Button
    Friend WithEvents ButtonLEDON As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxTimbangan As TextBox
    Friend WithEvents SerialPortArduino As IO.Ports.SerialPort
    Friend WithEvents Lampu As Button
    Friend WithEvents LabelConnectionStatusArduino As Label
    Friend WithEvents TextBoxArduino As TextBox
    Friend WithEvents ButtonConnectArduino As Button
    Friend WithEvents SerialPortTimbangan As IO.Ports.SerialPort
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnStop As Button
    Friend WithEvents BtnStart As Button
    Friend WithEvents TxtRichTemp As RichTextBox
    Friend WithEvents TxtPerintah As TextBox
End Class
