Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic

Module ImpExcel
    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")

            If Not String.IsNullOrEmpty(xSheet) Then
                conn = New OleDbConnection( _
                                  "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                  "data source=" & ExcelFile & "; " & _
                                 "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                Try
                    da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                    conn.Open()
                    da.Fill(ds, "MyData")
                    dt = ds.Tables("MyData")
                    tabla.DataSource = ds
                    tabla.DataMember = "MyData"

                    If tabla.RowCount < 1 Then
                        MsgBox("Error: Planilla Excel vacia... !", MsgBoxStyle.Information, "Servicio de Alertas")
                    End If
                Catch ex As Exception
                    MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Servicio de Alertas")
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub
End Module
