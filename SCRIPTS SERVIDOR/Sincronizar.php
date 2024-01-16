<?php
	include "ConexionBD.php";

	$Cont = $_GET['CONT'];

	$Huellas = mysqli_query($Conn, "SELECT * FROM Alumnos WHERE idHuella_Digital != '0' ORDER BY idHuella_Digital ASC");

	$i = 0;

	if((mysqli_num_rows($Huellas) - 1) >= $Cont) {
		while($RHuellas = mysqli_fetch_array($Huellas)){ 
			if ($Cont == $i) {
				$Modelo = rtrim($RHuellas["Modelo_Huella"]);

				echo "<p>" . $RHuellas["idHuella_Digital"] . "<p>" . $Modelo . "<p>" . "CON";
				break;
			}

			$i = $i + 1;
		}
	}
	else {
		echo "<p>" . "-" . "<p>" . "-" . "<p>" . "FIN";
	}
?>