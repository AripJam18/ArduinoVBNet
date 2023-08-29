Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ports As String() = IO.Ports.SerialPort.GetPortNames()
        ' Display each port name to ListBox1
        Dim port As String
        For Each port In ports
            ListBox1.Items.Add(port)
        Next port
    End Sub
#Region "Timbangan"
    Private Sub ButtonConnectTimbangan_Click(sender As Object, e As EventArgs) Handles ButtonConnectTimbangan.Click
        Try
            SerialPortTimbangan.PortName = ListBox1.SelectedItem
            SerialPortTimbangan.BaudRate = 9600
            SerialPortTimbangan.Open()
            LabelConnectionStatusTimbangan.Text = ListBox1.SelectedItem & " is connected."
        Catch ex As Exception
            LabelConnectionStatusTimbangan.Text = ListBox1.SelectedItem & " is not connected."
        End Try
    End Sub
    Private Sub SerialPortTimbangan_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortTimbangan.DataReceived
        TextBoxTimbangan.Invoke(New myDelegate(AddressOf updateTextBoxTimbangan), New Object() {})
    End Sub
    Public Sub updateTextBoxTimbangan()
        TextBoxTimbangan.Text = SerialPortTimbangan.ReadLine
        'If TextBoxTimbangan.Text.Length > 3 Then
        '    TextBoxTimbangan.Text = Mid(TextBoxTimbangan.Text, 1, 3)
        'End If
    End Sub
#End Region
#Region "Arduino"
    Private Sub ButtonLEDON_Click(sender As Object, e As EventArgs) Handles ButtonLEDON.Click
        If SerialPortArduino.IsOpen Then
            SerialPortArduino.WriteLine("A")
            Lampu.BackColor = Color.Red
        Else
            MsgBox("Serialport is not connected.")
        End If
    End Sub

    Private Sub ButtonLEDOFF_Click(sender As Object, e As EventArgs) Handles ButtonLEDOFF.Click
        If SerialPortArduino.IsOpen Then
            SerialPortArduino.WriteLine("B")
            Lampu.BackColor = Color.Black
        Else
            MsgBox("Serialport is not connected.")
        End If
    End Sub


    'Private Sub SerialPortArduino_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortArduino.DataReceived
    '    TextBoxArduino.Invoke(New myDelegate(AddressOf updateTextBoxArduino), New Object() {})
    'End Sub

    Public Delegate Sub myDelegate()
    Public Sub updateTextBoxArduino()
        TextBoxArduino.Text = SerialPortArduino.ReadLine
        'If TextBoxArduino.Text.Length <> 5 Then
        '    TextBoxArduino.Text = Mid(TextBoxArduino.Text, 1, 3)
        'End If

        If TextBoxArduino.Text = "START" Then
            BtnStart.BackColor = Color.Yellow
            BtnStop.BackColor = Color.Gray
            ''connectTimbangan 
        End If
        If TextBoxArduino.Text = "STOP" Then
            BtnStop.BackColor = Color.Yellow
            BtnStart.BackColor = Color.Gray
            ''DisconnectTimbangan
            ''SimpanData
        End If

    End Sub
    Private Sub ButtonConnectArduino_Click(sender As Object, e As EventArgs) Handles ButtonConnectArduino.Click
        Try
            SerialPortArduino.PortName = ListBox1.SelectedItem
            SerialPortArduino.BaudRate = 9600
            SerialPortArduino.Open()
            LabelConnectionStatusArduino.Text = ListBox1.SelectedItem & " is connected."
        Catch ex As Exception
            LabelConnectionStatusArduino.Text = ListBox1.SelectedItem & " is not connected."
        End Try
    End Sub



    Delegate Sub SetTextCallback(ByVal [text] As String)

    Private Sub SerialPortArduino_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortArduino.DataReceived
        Try
            'ini fungsi untuk menerima data dari SerialPort1, ReadExisting adalah perintah untuk mengambil data setiap saat/setiap serailport1 mengirimkan data
            ReceivedText(SerialPortArduino.ReadExisting())
        Catch ex As Exception
            MsgBox("Connection Port Error:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ReceivedText(ByVal [text] As String)
        'fungsi untuk menerima data/inputan dari timbangan kali ini yang kita mabil data berupa text/string
        Try

            'compares the ID of the creating Thread to the ID of the calling Thread
            If Me.TxtRichTemp.InvokeRequired Then
                Dim x As New SetTextCallback(AddressOf ReceivedText)
                Me.Invoke(x, New Object() {(text)})
            Else
                Me.TxtRichTemp.Text &= [text]
            End If
        Catch ex As Exception
            MsgBox("Connection Port Error:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub TxtRichTemp_TextChanged(sender As Object, e As EventArgs) Handles TxtRichTemp.TextChanged
        Try
            Dim jumlah_baris As String
            jumlah_baris = TxtRichTemp.Lines.Count 'menghitung jumlah baris di rtbreceived
            If jumlah_baris >= 1 Then 'jika txtjumlah nilainya lebih besar dari 2 maka
                TxtPerintah.Text = Strings.Left(TxtRichTemp.Text, 1)  'mengambil 7 karakter dimulai dari karkter ke 3
                TxtRichTemp.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub





#End Region
End Class