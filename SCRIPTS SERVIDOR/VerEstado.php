<?php
	include "ConexionBD.php";

	$ipAddress=$_SERVER['REMOTE_ADDR']; 
	$macAddr=false; 
	$arp=`arp -a $ipAddress`; 
	$lines=explode("\n", $arp); 
	
	foreach($lines as $line) { 
		$cols=preg_split('/\s+/', trim($line)); 
		
		if ($cols[0]==$ipAddress) { 
			$macAddr=$cols[1]; 
		} 
	} 

	$Estado = mysqli_query($Conn, "SELECT * FROM Lectores WHERE MAC = '$macAddr'");

	if(mysqli_num_rows($Estado) > 0) {
		$REstado = mysqli_fetch_array($Estado);

		if ($REstado["Estado"] == "Actualizar") {
			echo "<p>" . "ACT";
		}
		else {
			echo "<p>" . "NOA";
		}
	}
	else {
		echo "<p>" . "NOE";
	}
?>
