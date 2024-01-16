Imports MySql.Data.MySqlClient

Public Class Mostrar

    Public Function verUltmIdHuella()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verUltmIdHuella"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar Tabla de Tolerancia" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verTolerancia()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verTolerancia"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar Tabla de Tolerancia" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verLectores()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verLectores"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar Tabla de Tolerancia" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verIPServidor()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verIPServidor"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar IP Servidor" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verHuella_idAlumno(ByVal aIdAlumno As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verHuella_idAlumno"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aIdAlumno"), MySqlParameter).Value = aIdAlumno

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCicloLectivoAño(ByVal Año As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verCicloLectivoAño"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@cicA"), MySqlParameter).Value = Año

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar ciclo lectivo" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verUsuario_Nombre(ByVal uNombre As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verUsuario_Nombre"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@uNombre"), MySqlParameter).Value = uNombre

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuario no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consUsuarioContraseña(ByVal ingNom As String, ByVal ingCont As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consUsuarioContraseña"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@ingN"), MySqlParameter).Value = ingNom
            CType(_cMd.Parameters("@ingC"), MySqlParameter).Value = ingCont

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Usuario no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    Public Function verUsuarios()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verUsuarios"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar ciclo lectivo" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCicloLectivo()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verCicloLectivo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar ciclo lectivo" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    Public Function consHorarios_Grupo_Curso()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consHorarios_Grupo_Curso"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Horarios" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consGrupo_Curso()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consGrupo_Curso"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Cursos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCurso()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verCurso"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Cursos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verLector_MAC(ByVal lMAC As String)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verLector_MAC"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@lMAC"), MySqlParameter).Value = lMAC

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Lectores" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consCursosPorCiclo(ByVal idC As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consCursosPorCiclo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@idCiclo"), MySqlParameter).Value = idC

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Cursos para este Ciclo Lectivo" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function



    Public Function verFeriado_Paro()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verFeriado_Paro"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Cursos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verHorarios()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verHorarios"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Cursos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verGrupo()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verGrupo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Cursos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verConexion()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verConexion"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar la conexion" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verAlumnos()
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verAlumnos"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error al cargar los Cursos" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verAlumno_Nombre_idCurso(ByVal aNombre As String, ByVal aIdCurso As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verAlumno_Nombre_idCurso"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aNombre"), MySqlParameter).Value = aNombre
            CType(_cMd.Parameters("@aIdCurso"), MySqlParameter).Value = aIdCurso

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlumno_Todos(ByVal aIdCl As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consAlumno_Todos"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aIdCl"), MySqlParameter).Value = aIdCl

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlumno_SinHuella(ByVal aIdCl As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consAlumno_SinHuella"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aIdCl"), MySqlParameter).Value = aIdCl

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAsistencia_Curso_Dia_Turno_Grupo(ByVal Fec As Date, ByVal Curs As Integer, ByVal Turn As String, ByVal Grp As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consAsistencia_Curso_Dia_Turno_Grupo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@asFecha"), MySqlParameter).Value = Fec
            CType(_cMd.Parameters("@asCurso"), MySqlParameter).Value = Curs
            CType(_cMd.Parameters("@asTurno"), MySqlParameter).Value = Turn
            CType(_cMd.Parameters("@asGrupo"), MySqlParameter).Value = Grp

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Asistencia no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlumno_Curso_SinHuella(ByVal aIdCurso As Integer, ByVal aIdCl As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consAlumno_Curso_SinHuella"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aIdCurso"), MySqlParameter).Value = aIdCurso
            CType(_cMd.Parameters("@aIdCl"), MySqlParameter).Value = aIdCl

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlumno_Curso_Grupo_Todos(ByVal aIdCurso As Integer, ByVal aIdGrupo As Integer, ByVal aIdCl As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consAlumno_Curso_Grupo_Todos"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aIdCurso"), MySqlParameter).Value = aIdCurso
            CType(_cMd.Parameters("@aIdGrupo"), MySqlParameter).Value = aIdGrupo
            CType(_cMd.Parameters("@aIdCl"), MySqlParameter).Value = aIdCl

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlumno_Curso_Grupo_SinHuella(ByVal aIdCurso As Integer, ByVal aIdGrupo As Integer, ByVal aIdCl As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consAlumno_Curso_Grupo_SinHuella"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aIdCurso"), MySqlParameter).Value = aIdCurso
            CType(_cMd.Parameters("@aIdGrupo"), MySqlParameter).Value = aIdGrupo
            CType(_cMd.Parameters("@aIdCl"), MySqlParameter).Value = aIdCl

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consHorarios_Curso_Tipo_Dia_Turno_Grupo(ByVal hTipo As String, ByVal hDia As String, ByVal hTurno As String, ByVal hIdCurso As Integer, hGrupo As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consHorarios_Curso_Tipo_Dia_Turno_Grupo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@hTipo"), MySqlParameter).Value = hTipo
            CType(_cMd.Parameters("@hDia"), MySqlParameter).Value = hDia
            CType(_cMd.Parameters("@hTurno"), MySqlParameter).Value = hTurno
            CType(_cMd.Parameters("@hIdCurso"), MySqlParameter).Value = hIdCurso
            CType(_cMd.Parameters("@hGrupo"), MySqlParameter).Value = hGrupo

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Grupo no puede cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function


    Public Function consHorarios_Curso_Tipo_Dia_Turno(ByVal hTipo As String, ByVal hDia As String, ByVal hTurno As String, ByVal hIdCurso As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consHorarios_Curso_Tipo_Dia_Turno"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@hTipo"), MySqlParameter).Value = hTipo
            CType(_cMd.Parameters("@hDia"), MySqlParameter).Value = hDia
            CType(_cMd.Parameters("@hTurno"), MySqlParameter).Value = hTurno
            CType(_cMd.Parameters("@hIdCurso"), MySqlParameter).Value = hIdCurso

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verFeriado_Paro_Fecha(ByVal fpFecha As Date)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verFeriado_Paro_Fecha"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@fpFecha"), MySqlParameter).Value = fpFecha

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlumno_Curso(ByVal aIdCurso As Integer, ByVal aIdCl As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consAlumno_Curso"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aIdCurso"), MySqlParameter).Value = aIdCurso
            CType(_cMd.Parameters("@aIdCl"), MySqlParameter).Value = aIdCl

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function consAlumno_Grupo(ByVal aIdGrupo As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.consAlumno_Grupo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@aIdGrupo"), MySqlParameter).Value = aIdGrupo

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verGrupo_Curso(ByVal gIdCurso As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verGrupo_Curso"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@gIdCurso"), MySqlParameter).Value = gIdCurso

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verGrupo_Grupo_idCurso(ByVal gGrupo As String, ByVal gIdCurso As Integer, ByVal gIdCiclo As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verGrupo_Grupo_idCurso"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@gGrupo"), MySqlParameter).Value = gGrupo
            CType(_cMd.Parameters("@gIdCurso"), MySqlParameter).Value = gIdCurso
            CType(_cMd.Parameters("@gIdCiclo"), MySqlParameter).Value = gIdCiclo

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verHorario_Dia_Turno_Tipo_Curso_Grupo(ByVal hDia As String, ByVal hTurno As String, ByVal hTipo As String, ByVal hCurso As Integer, ByVal hGrupo As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verHorario_Dia_Turno_Tipo_Curso_Grupo"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@hDia"), MySqlParameter).Value = hDia
            CType(_cMd.Parameters("@hTurno"), MySqlParameter).Value = hTurno
            CType(_cMd.Parameters("@hTipo"), MySqlParameter).Value = hTipo
            CType(_cMd.Parameters("@hCurso"), MySqlParameter).Value = hCurso
            CType(_cMd.Parameters("@hGrupo"), MySqlParameter).Value = hGrupo

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function

    Public Function verCurso_Año_Divsion(ByVal cAño As Integer, ByVal cDivision As String, ByVal cIdCiclo As Integer)
        Try
            Dim _cMd As New MySqlCommand

            BDcnn()
            _cMd.CommandText = "sistema_asistencia.verCurso_Año_Divsion"
            _cMd.CommandType = CommandType.StoredProcedure
            _cMd.Connection = _cX

            MySqlCommandBuilder.DeriveParameters(_cMd)
            CType(_cMd.Parameters("@cAño"), MySqlParameter).Value = cAño
            CType(_cMd.Parameters("@cDivision"), MySqlParameter).Value = cDivision
            CType(_cMd.Parameters("@cIdCiclo"), MySqlParameter).Value = cIdCiclo

            Dim _dA As New MySqlDataAdapter(_cMd)
            Dim _Dt As New DataTable
            _dA.Fill(_Dt)
            BDxxx()

            Return _Dt
        Catch ex As MySqlException
            MsgBox("Error: Cursos no pudo cargarse" & vbCrLf & vbCrLf & ex.ToString, vbExclamation, "Servicio de Alertas")
            Return Nothing
        Finally
            BDxxx()
        End Try
    End Function
End Class
