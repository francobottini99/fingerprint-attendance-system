<?php
	include "ConexionBD.php";

	$MaxID = mysqli_query($Conn, "SELECT Max(idHuella_Digital) as MaxIDHuella FROM Alumnos");

	$row = mysqli_fetch_array($MaxID);

	if($row["MaxIDHuella"] == 1000){
		echo "<p>Lleno";
	}
	else {
		echo "<p>" .  $row["MaxIDHuella"];
	}

	mysqli_close($Conn);
?>