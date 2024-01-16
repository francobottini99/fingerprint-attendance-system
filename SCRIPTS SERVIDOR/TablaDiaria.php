<?php
	include "ConexionBD.php";
	date_default_timezone_set('America/Buenos_Aires');

	$Año = date("Y");
	$Fecha = date("Y-m-d");

	if (date("H:i") > date("12:35") && date("H:i") < date("18:35")) {
		$Tur = "Tarde";
	}
	elseif (date("H:i") >= date("00:00")) {
		$Tur = "Mañana";
	}
	else {
		$Tur = "Mañana";
		$Fecha = strtotime($Fecha . "+1 days");
	}

	$Feriado = mysqli_query($Conn, "SELECT * FROM feriados_paros JOIN CicloLectivo ON CicloLectivo_idCiclo_Lectivo = idCiclo_Lectivo WHERE Fecha = '$Fecha' AND Año = '$Año'");

	if(mysqli_num_rows($Feriado) > 0) {
		echo "<p>" . "NOC";
		exit();
	}

	$RFeriado = mysqli_fetch_array($Feriado);

	$idCicloLectivo = $RFeriado["CicloLectivo_idCiclo_Lectivo"];

	$array_dias['Sunday'] = "Domingo";
	$array_dias['Monday'] = "Lunes";
	$array_dias['Tuesday'] = "Martes";
	$array_dias['Wednesday'] = "Miércoles";
	$array_dias['Thursday'] = "Jueves";
	$array_dias['Friday'] = "Viernes";
	$array_dias['Saturday'] = "Sabado";

	$D = $array_dias[date('l', strtotime($Fecha))];

	$Asistencia = mysqli_query($Conn, "SELECT * FROM Asistencia JOIN Horarios ON Horarios_idHorarios = idHorarios WHERE Fecha = '$Fecha' AND Turno = '$Tur'");

	if(mysqli_num_rows($Asistencia) < 1) {
		$Horario = mysqli_query($Conn, "SELECT * FROM Horarios JOIN Grupo ON Grupo_idGrupo = idGrupo WHERE Turno = '$Tur' AND Dia = '$D' AND Horarios.CicloLectivo_idCiclo_Lectivo = '$idCicloLectivo'");

		if(mysqli_num_rows($Horario) > 0) {
			while ($RHorario = mysqli_fetch_array($Horario)){
				if ($RHorario["Grupo"] == "Todos") {
					$idCurso = $RHorario["Curso_idCurso"];
					$idHorario = $RHorario["idHorarios"];
					$TAlumnos = mysqli_query($Conn, "SELECT * FROM Alumnos WHERE Curso_idCurso = '$idCurso'");	
				}
				else {
					$Grupo = $RHorario["Grupo"];
					$idHorario = $RHorario["idHorarios"];
					$TAlumnos = mysqli_query($Conn, "SELECT * FROM Alumnos WHERE Grupo_idGrupo = '$Grupo'");		
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
			}


			$Asistencia = mysqli_query($Conn, "SELECT * FROM Asistencia JOIN Horarios ON Horarios_idHorarios = idHorarios WHERE Fecha = '$Fecha' AND Turno = '$Tur'");

			if (mysqli_num_rows($Asistencia) > 0) {
				echo "<p>" . "OK";
				exit();
			}
			else {
				echo "<p>" . "NOG";
				exit();
			}
		}
		else {
			echo "<p>" . "NOC";
			exit();
		}
	}
	else {
		echo "<p>" . "YAG";
		exit();
	}
?>