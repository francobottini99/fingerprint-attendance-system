<?php
	include "ConexionBD.php";

	$IPL = $_GET['IPL'];

	$DTLectores = mysqli_query($Conn, "SELECT * FROM Lectores");

	if(mysqli_num_rows($DTLectores) > 0){
		$fila = mysqli_fetch_row($DTLectores);

		echo "<p>" .  $fila[1];
	}
	else {
		mysqli_query($Conn, "INSERT INTO Lectores (IPLector, Estado) VALUES ('$IPL', 'Enrrolando')");

		echo "<p>Disponible";
	}

	mysqli_close($Conn);
?>