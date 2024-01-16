<?php
	include "ConexionBD.php";

	mysqli_query($Conn, "TRUNCATE Lectores");

	mysqli_close($Conn);
?>