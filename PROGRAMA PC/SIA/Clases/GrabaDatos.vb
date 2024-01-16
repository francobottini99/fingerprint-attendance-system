Imports MySql.Data.MySqlClient

Public Class GrabaDatos
    Private _cMd As New MySqlCommand
    Private Lector As MySqlDataReader

    Public Function Grabar(ByVal proC As String) As MySqlDataReader
        Try
            BDcnn()
            _cMd.CommandText = proC
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            Lector = _cMd.ExecuteReader()

            BDxxx()
            Return Lector
        Catch ex As MySqlException
            MsgBox("Error al intentar grabar datos en mysql !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            BDxxx()
            Return Nothing
        End Try
    End Function

    Public Function Grabar(ByVal oRg As String, ByVal iMg As String, ByVal proC As String, ByVal ParamArray paraM() As String) As MySqlDataReader
        Try
            Dim X As Integer
            BDcnn()
            _cMd.CommandText = proC
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            For X = 0 To paraM.Length - 1
                CType(_cMd.Parameters(X), MySqlParameter).Value = paraM(X)
            Next

            'If iMg = "Imagen" Then
            '    Select Case oRg
            '        Case Is = "Empresa"
            '            Dim mS As New IO.MemoryStream
            '            If Not frmEmpresa.pbxLogo.Image Is Nothing Then
            '                frmEmpresa.pbxLogo.Image.Save(mS, frmEmpresa.pbxLogo.Image.RawFormat)
            '            Else
            '                frmEmpresa.pbxLogo.Image = My.Resources.ImgTransp
            '                frmEmpresa.pbxLogo.Image.Save(mS, frmEmpresa.pbxLogo.Image.RawFormat)
            '            End If
            '            CType(_cMd.Parameters(paraM.Length), MySqlParameter).Value = mS.GetBuffer
            '    End Select
            'End If

            Lector = _cMd.ExecuteScalar()
            BDxxx()
            Return Lector
        Catch ex As MySqlException
            MsgBox("Error al intentar grabar datos en mysql !" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            BDxxx()
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function
End Class
