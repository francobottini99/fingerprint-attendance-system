<?php
	include "ConexionBD.php";

	$ID = $_GET['ID'];
	$FECHA = date("Y-m-d");

	$Alumno = mysqli_query($Conn, "SELECT * FROM Alumnos WHERE idHuella_Digital = $ID");
	$RAlumno = mysqli_fetch_row($Alumno);
	$Asistencia = mysqli_query($Conn, "SELECT * FROM Asistencia WHERE Alumnos_idAlumnos = $RAlumno[0] AND Fecha = $FECHA");
	$RAsistencia = mysqli_fetch_row($Asistencia);

	if(mysqli_num_rows($Asistencia) < 1){

	}

	$dias = array('Lunes','Martes','Miercoles','Jueves','Viernes','Sabado','Domingo');

	$wDay = $dias[date('N', strtotime(time()))];

	$Horario = mysqli_query($Conn, "SELECT * FROM Horarios WHERE Grupo_idGrupo = $RAlumno[7] AND Dia = $wDay");
	$RHorario = mysqli_fetch_row($Horario);

	$HORA = date("G") . ":" . date("i") 

	if($RAsistencia[2] == 'Ausente'){
		if(mysqli_num_rows($Horario) > 1) {
			if(($HORA - $RHorario[3]) < 5){
				mysqli_query($Conn, "UPDATE Asistencia SET Asistencia = 'Presente', HoraIngreso = $HORA WHERE Alumnos_idAlumnos = $RAlumno[0]");
			}		
			elseif (($HORA - $RHorario[3]) < 15) {
				mysqli_query($Conn, "UPDATE Asistencia SET Asistencia = 'Tarde', HoraIngreso = $HORA WHERE Alumnos_idAlumnos = $RAlumno[0]");
			}
			else {	
				mysqli_query($Conn, "UPDATE Asistencia SET Asistencia = 'Ingreso - Ausente', HoraIngreso = $HORA WHERE Alumnos_idAlumnos = $RAlumno[0]");	
			}

			echo "<p>" .  $RAlumno[1] . "<p>" . "Bienvenido";
		}
		elseif (mysqli_num_rows($Horario) == 1) {
			
		}
		else {
			echo "<p>" . "NoH"
		}
	}
	else {
		echo "<p>" .  $RAlumno[1] . "<p>" . "Presente";
	}

	mysqli_close($Conn);
?>