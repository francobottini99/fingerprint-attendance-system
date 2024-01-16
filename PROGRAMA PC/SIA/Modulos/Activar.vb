Module Activar
    Public Sub ActivarCtrls(ByVal _frm As String)
        Select Case _frm
            Case frmAltasCurso.Name
                With frmAltasCurso
                    .gbxPPal.Enabled = True
                    .gbxCursos.Enabled = False

                    .pbxNuevo.Enabled = False
                    .pbxGuardar.Enabled = True
                    .pbxCancelar.Enabled = True
                    .pbxModificar.Enabled = False
                    .pbxSalir.Enabled = False
                End With
            Case frmAltasAlumnos.Name
                With frmAltasAlumnos
                    .gbxDatos.Enabled = True
                    .gbxCursos.Enabled = False

                    .pbxNuevo.Enabled = False
                    .pbxGuardar.Enabled = True
                    .pbxCancelar.Enabled = True
                    .pbxModificar.Enabled = False
                    .pbxSalir.Enabled = False
                End With
            Case frmAltasFeriados.Name
                With frmAltasFeriados
                    .mtcCalendario.Enabled = True
                    .txtMotivo.Enabled = True
                    .gbxFeriados.Enabled = False

                    .pbxNuevo.Enabled = False
                    .pbxGuardar.Enabled = True
                    .pbxCancelar.Enabled = True
                    .pbxEliminar.Enabled = False
                    .pbxSalir.Enabled = False
                End With
            Case frmAltasGrupo.Name
                With frmAltasGrupo
                    .gbxPPal.Enabled = True
                    .gbxGrupos.Enabled = False

                    .pbxNuevo.Enabled = False
                    .pbxGuardar.Enabled = True
                    .pbxCancelar.Enabled = True
                    .pbxModificar.Enabled = False
                    .pbxSalir.Enabled = False
                End With
            Case frmManejoHorarios.Name
                With frmManejoHorarios
                    .gbxPPal.Enabled = True
                    .gbxHorarios.Enabled = False

                    .pbxNuevo.Enabled = False
                    .pbxGuardar.Enabled = True
                    .pbxCancelar.Enabled = True
                    .pbxModificar.Enabled = False
                    .pbxSalir.Enabled = False
                End With
            Case frmManejoAsistenciaManual.Name
                With frmManejoAsistenciaManual
                    .gbxPlanilla.Enabled = True
                    .gbxDetalles.Enabled = True
                    .gbxSeleccion.Enabled = False

                    .pbxGuardar.Enabled = True
                    .pbxCancelar.Enabled = True
                    .pbxSalir.Enabled = False
                End With
        End Select
    End Sub
End Module
