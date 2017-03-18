<?php

include "db.php";
session_start();

if(isset($_POST['user'])&&isset($_POST['pass']))
{
	if ($stmt =mysqli_prepare($conn,"SELECT `uuid` FROM `users` WHERE `username` = ? AND `password` = ?;"))
	{
		$user = 0;
		mysqli_stmt_bind_param($stmt,"ss", $_POST['user'], $_POST['pass']);
		mysqli_stmt_execute($stmt);
		mysqli_stmt_bind_result($stmt,$user);
		if(mysqli_stmt_fetch($stmt))
		{
			$_SESSION['uuid'] = $user;
			header('Location: index.php');
		}
		else
		{
		
			header('Location: login_error.php');
			//include("login_error.php");
			//header('Location: http://localhost:8080/SitePhp/');
			// echo "ERROR";
		}
	}
}
// mysqli_close($conn);
?>