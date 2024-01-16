Imports System.Net.Sockets
Imports System.Text

Public Class Arduino
    Dim tcpClient As New System.Net.Sockets.TcpClient()
    Dim networkStream As NetworkStream

    Public Function Arduino_Connect(ByVal IP As String, ByVal Port As Integer) As Boolean
        Try
            tcpClient.SendTimeout = 5000
            tcpClient.ReceiveTimeout = 5000
            tcpClient.Connect(IP, Port)
            networkStream = tcpClient.GetStream()
            If Not networkStream.CanWrite Or Not networkStream.CanRead Then
                tcpClient.Close()
                networkStream = Nothing
                Return False
            End If
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function Arduino_Write(ByVal Output As String)
        If Not IsNothing(networkStream) Then
            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(Output)

            networkStream.WriteTimeout = 5000
            networkStream.Write(sendBytes, 0, sendBytes.Length)

            If Arduino_Read() = "Error" Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Public Function Arduino_Read()
        If Not IsNothing(networkStream) Then
            Try
                tcpClient.SendTimeout = 5000
                tcpClient.ReceiveTimeout = 5000
                Dim bytes(tcpClient.ReceiveBufferSize) As Byte
                networkStream.ReadTimeout = 5000
                networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
                Dim returndata As String = Encoding.ASCII.GetString(bytes)

                Return returndata
            Catch
                Return "Error"
            End Try
        Else
            Return "Error"
        End If
    End Function

    Public Sub Arduino_Disconnect()
        If Not IsNothing(networkStream) Then
            tcpClient.Close()
            networkStream = Nothing
        End If
    End Sub
End Class
