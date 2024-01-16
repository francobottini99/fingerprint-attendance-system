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

	$modEstado = mysqli_query($Conn, "UPDATE Lectores SET Estado = '-' WHERE MAC = '$macAddr'");

	if($modEstado) {
		echo "<p>" . "MOD";
	}
	else {
		echo "<p>" . "NOC";
	}
?>
