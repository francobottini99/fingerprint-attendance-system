<?php
	include "ConexionBD.php";

	$now = time();
	$num = date("w");

	if ($num == 0) { $sub = 6; }
	else { $sub = ($num-1); }

	$WeekMon  = mktime(0, 0, 0, date("m", $now)  , date("d", $now)-$sub, date("Y", $now));  
	
	$todayh = getdate($WeekMon);

	$d = $todayh[mday];
	$m = $todayh[mon];
	$y = $todayh[year];
	
	$Fecha = $y . "-" . $m . "-" . $d; 
 	
 	$Alumnos = mysqli_query($Conn, "SELECT * FROM Alumnos");
 	$RAlum = mysqli_fetch_row($Alumnos);
 	$NAlumn = mysqli_num_rows($Alumnos) 

 	for($i = 0; $i < $NAlumn; $i++){
 		$RAlum[]

 		$sql = "INSERT INTO Asistencia (Fecha, Asistencia, HoraIngreso, Alumnos_idAlumnos, Horarios_idHorarios, CicloLectivo_idCiclo_Lectivo, Usuarios_idUsuarios) VALUES ('$Fecha', 'Ausente', '-', '$Alumnos_idAlumnos', '$Horarios_idHorarios')";
 	}

	mysqli_query($Conn, $sql);

	mysqli_close($Conn);
?>