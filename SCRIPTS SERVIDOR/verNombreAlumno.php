<?php
	include "ConexionBD.php";

	$ID = $_GET['ID'];

	$Año = date("Y");
	$Fecha = date("Y-m-d");

	if (date("G") > 12) {
		$Turno = "Tarde"
	}
	else {
		$Turno = "Mañana"
	}

	$Alumno = mysqli_query($Conn, "SELECT * FROM Alumnos JOIN CicloLectivo ON CicloLectivo_idCiclo_Lectivo = idCiclo_Lectivo WHERE idHuella_Digital = $ID AND Año = $Año");

	$RAlumno = mysqli_fetch_array($Alumno);
		
	if(mysqli_num_rows($Alumno) < 1) {
		echo "<p>" . "NOB";
		exit();
	}

	$array_dias['Sunday'] = "Domingo";
	$array_dias['Monday'] = "Lunes";
	$array_dias['Tuesday'] = "Martes";
	$array_dias['Wednesday'] = "Miercoles";
	$array_dias['Thursday'] = "Jueves";
	$array_dias['Friday'] = "Viernes";
	$array_dias['Saturday'] = "Sabado";

	$Dia = $array_dias[date('l', strtotime($Fecha))];

	$Horario = mysqli_query($Conn, "SELECT * FROM Horarios WHERE Grupo_idGrupo = $RAlumno["Grupo_idGrupo"] AND Turno = $Turno AND Dia = $Dia");

	if (mysqli_num_rows($Horario) < 1) {
		echo "<p>" . "NOH";
		exit();
	}

	$Asistencia = mysqli_query($Conn, "SELECT * FROM Asistencia JOIN Horarios ON Horarios_idHorarios = idHorarios WHERE Alumnos_idAlumnos = $RAlumno["idAlumnos"] AND Fecha = $Fecha AND Turno = $Turno");

	if(mysqli_num_rows($Asistencia) < 1){
		$TAlumnos = mysqli_query($Conn, "SELECT * FROM Alumnos WHERE Curso_idCurso = $RAlumno["Curso_idCurso"] AND Año = Grupo_idGrupo = $RAlumno["Grupo_idGrupo"]");

		if (mysqli_num_rows($Horario) > 1) {
			while ($RHorario = mysqli_fetch_array($Horario)){
				if ($RHorario["Tipo"] = "Temporal") {
					$idHorario = $RHorario["idHorarios"]
				}
			}
		}
		else {
			$RHorario = mysqli_fetch_array($Horario)
			$idHorario = $RHorario["idHorarios"]
		}

		while ($RTAlumnos = mysqli_fetch_array($TAlumnos)){
			mysqli_query($Conn, "INSERT INTO Asistencia(Fecha, Asistencia, HoraIngreso, Alumnos_idAlumnos, Horarios_idHorarios, CicloLectivo_idCiclo_Lectivo, Usuarios_idUsuarios) VALUES ($Fecha, 'Ausente', '-', $RTAlumnos["idAlumnos"], $idHorario, $RTAlumnos["CicloLectivo_idCiclo_Lectivo"], '1')");
		}

		mysqli_query($Conn, "DELETE FROM Horarios WHERE idHorarios = $idHorario");

		$Asistencia = mysqli_query($Conn, "SELECT * FROM Asistencia JOIN Horarios ON Horarios_idHorarios = idHorarios WHERE Alumnos_idAlumnos = $RAlumno["idAlumnos"] AND Fecha = $Fecha AND Turno = $Turno");
	}

	$RAsistencia = mysqli_fetch_array($Asistencia)

	if ($RAsistencia["Asistencia"] == "Presente") {
		echo "<p>" . "PRE";
	}
	else {
		$HoraIng = date("G") . ":" . date("i")

		if () {
			mysqli_query($Conn, "UPDATE Asistencia SET Asistencia = 'Presente', HoraIngreso = $HoraIng WHERE Alumnos_idAlumnos = $RAlumno["idAlumnos"]");

			echo "<p>" . $RAlumno["Nombre"];
		}
	}
?>