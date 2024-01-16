<?php
	include "ConexionBD.php";
	date_default_timezone_set('America/Buenos_Aires');

	$ID = $_GET['ID'];

	$Año = date("Y");
	$Fecha = date("Y-m-d");

	$Feriado = mysqli_query($Conn, "SELECT * FROM feriados_paros JOIN CicloLectivo ON CicloLectivo_idCiclo_Lectivo = idCiclo_Lectivo WHERE Fecha = '$Fecha' AND Año = '$Año'");

	if(mysqli_num_rows($Feriado) > 0) {
		echo "<p>" . "NOH";
		exit();
	}

	if (date("H:i") > date("12:40") && date("H:i") < date("18:35")) {
		$Tur = "Tarde";
	}
	elseif (date("H:i") > date("06:00") && date("H:i") < date("12:35")) {
		$Tur = "Mañana";
	}
	else {
		echo "<p>" . "NOH";
		exit();
	}

	$Alumno = mysqli_query($Conn, "SELECT * FROM Alumnos JOIN CicloLectivo ON CicloLectivo_idCiclo_Lectivo = idCiclo_Lectivo WHERE idHuella_Digital = '$ID' AND Año = '$Año'");
		
	if(mysqli_num_rows($Alumno) < 1) {
		echo "<p>" . "NOB";
		exit();
	}

	$RAlumno = mysqli_fetch_array($Alumno);

	$array_dias['Sunday'] = "Domingo";
	$array_dias['Monday'] = "Lunes";
	$array_dias['Tuesday'] = "Martes";
	$array_dias['Wednesday'] = "Miércoles";
	$array_dias['Thursday'] = "Jueves";
	$array_dias['Friday'] = "Viernes";
	$array_dias['Saturday'] = "Sabado";

	$D = $array_dias[date('l', strtotime($Fecha))];
	$idGrupo = $RAlumno["Grupo_idGrupo"];
	$idCurso = $RAlumno["Curso_idCurso"];
	$idAlumno = $RAlumno["idAlumnos"];
	$idCicloLectivo = $RAlumno["CicloLectivo_idCiclo_Lectivo"];
	
	$Horario = mysqli_query($Conn, "SELECT * FROM Horarios JOIN Grupo ON Grupo_idGrupo = idGrupo WHERE Turno = '$Tur' AND Dia = '$D' AND Horarios.CicloLectivo_idCiclo_Lectivo = '$idCicloLectivo'");

	$Continuar = false;

	if (mysqli_num_rows($Horario) > 0) {
		while ($RHorario = mysqli_fetch_array($Horario)){
			if ($RHorario["Curso_idCurso"] == $idCurso) {
				if ($RHorario["Grupo"] == "Todos") {
					$Continuar = true;
					$Grupo = "Todos";
				}
				elseif ($RHorario["idGrupo"] == $idGrupo) {
					$Continuar = true;
					$Grupo = $RHorario["idGrupo"];
				}
			}
		}
	}
	else {
		echo "<p>" . "NOH";
		exit();
	}

	if ($Continuar == true) {
		if ($Grupo == "Todos") {
			$Horario = mysqli_query($Conn, "SELECT * FROM Horarios JOIN Grupo ON Grupo_idGrupo = idGrupo WHERE Turno = '$Tur' AND Dia = '$D'AND Horarios.CicloLectivo_idCiclo_Lectivo = '$idCicloLectivo' AND Grupo = 'Todos' AND Curso_idCurso = '$idCurso' AND Tipo != '-'");	
		}
		else {
			$Horario = mysqli_query($Conn, "SELECT * FROM Horarios JOIN Grupo ON Grupo_idGrupo = idGrupo WHERE Grupo_idGrupo = '$Grupo' AND Tipo != '-'");
		}

		if (mysqli_num_rows($Horario) > 1) {
			while ($RHorario = mysqli_fetch_array($Horario)){
				if ($RHorario["Tipo"] == "Temporal") {
					$idHorario = $RHorario["idHorarios"];
					$HoraIng = $RHorario["Entrada"];

					mysqli_query($Conn, "UPDATE Horarios SET Tipo = '-' WHERE idHorarios = '$idHorario'");
				}
			}
		}
		else {
			$RHorario = mysqli_fetch_array($Horario);
			$idHorario = $RHorario["idHorarios"];
			$HoraIng = $RHorario["Entrada"];
		}

		$Asistencia = mysqli_query($Conn, "SELECT * FROM Asistencia JOIN Horarios ON Horarios_idHorarios = idHorarios WHERE 	Alumnos_idAlumnos = '$idAlumno' AND Fecha = '$Fecha' AND Turno = '$Tur'");

		if(mysqli_num_rows($Asistencia) < 1){
			if ($Grupo == "Todos") {
				$TAlumnos = mysqli_query($Conn, "SELECT * FROM Alumnos WHERE Curso_idCurso = '$idCurso'");	
			}
			else {
				$TAlumnos = mysqli_query($Conn, "SELECT * FROM Alumnos WHERE Curso_idCurso = '$idCurso' AND Grupo_idGrupo = '$Grupo'");		
			}

			while ($RTAlumnos = mysqli_fetch_array($TAlumnos)){
				$idCicloLectivo = $RTAlumnos["CicloLectivo_idCiclo_Lectivo"];
				$idTAlumnos = $RTAlumnos["idAlumnos"];

				if ($HoraIng == "S/C") {
					$Asiss = "S/C";
				}
				elseif ($RTAlumnos["Estado"] == "PasantiasT" && $Tur == "Tarde") { 
					$Asiss = "Pasantias";
				}
				elseif ($RTAlumnos["Estado"] == "PasantiasM" && $Tur == "Mañana") {
					$Asiss = "Pasantias";
				}
				elseif ($RTAlumnos["Estado"] == "PasantiasMT") {
					$Asiss = "Pasantias";
				}					
				else {
					$Asiss = "Ausente";
				}

				mysqli_query($Conn, "INSERT INTO Asistencia(Fecha, Asistencia, HoraIngreso, Alumnos_idAlumnos, Horarios_idHorarios, CicloLectivo_idCiclo_Lectivo, Usuarios_idUsuarios) VALUES ('$Fecha', '$Asiss', '-', '$idTAlumnos', '$idHorario', '$idCicloLectivo', '1')");
			}

			$Asistencia = mysqli_query($Conn, "SELECT * FROM Asistencia JOIN Horarios ON Horarios_idHorarios = idHorarios WHERE Alumnos_idAlumnos = '$idAlumno' AND Fecha = '$Fecha' AND Turno = '$Tur'");
		}

		$RAsistencia = mysqli_fetch_array($Asistencia);

		if ($RAsistencia["HoraIngreso"] != "-") {
			echo "<p>" . "PRE";
			exit();
		}
		elseif ($RAsistencia["Asistencia"] == "S/C") {
			echo "<p>" . "NOH";
			exit();
		}
		else {
			$Hora = substr($HoraIng, 0, 2);
			$Min = substr($HoraIng, -2);

			$Tolerancia = mysqli_query($Conn, "SELECT * FROM Tolerancia");

			$RTolerancia = mysqli_fetch_array($Tolerancia);

			if (date("H:i") <= date($Hora . ":" . ($Min + $RTolerancia["Llegada_Tarde"]))) {
				$Asis = "Presente";
			}
			elseif (date("H:i") > date($Hora . ":" . ($Min + $RTolerancia["Llegada_Tarde"])) && date("H:i") <= date($Hora . ":" . ($Min + $RTolerancia["Ausente"]))) {
				$Asis = "Tarde";
			}
			else {
				$Asis = "Ausente";
			}

			$H = date("H") . ":" . date("i");

			mysqli_query($Conn, "UPDATE Asistencia SET Asistencia = '$Asis', HoraIngreso = '$H' WHERE Alumnos_idAlumnos = '$idAlumno'");

			echo "<p>" . $RAlumno["Nombre"];
		}
	}
	else {
		echo "<p>" . "NOH";
		exit();
	}
?>