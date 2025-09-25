<!DOCTYPE html>
<html lang="it">
	<head>
		<meta charset="utf-8" />
		<title>Benvenuti all'Hexagon Tours</title>
		<link href="css/monkeyStyle.css" rel="stylesheet" type="text/css" media="all" />
		<script type="text/javascript">
			function myFunction() {
				var x = document.getElementById("myTopnav");
				
				if (x.className === "topnav") {
					x.className += " responsive";
					
				} else {
					x.className = "topnav";
				}
			}	
		</script>
	</head>
	<body>
		<div id="container">
			<header id="header">
				<hgroup>
					<h1>La Scimmia Cifratrice 🐒</h1>
					
				</hgroup>
				<ul class="topnav" id="myTopnav">
					<li><a href='monkeyIndex.php' title='home page'>Homepage</a></li>
					<li><a href='statistiche.php' title='Le statistiche'>Le statistiche</a></li>		
					

					<li class="icon"><a href="javascript:void(0);" onclick="myFunction()">&#9776;</a></li>
				</ul>
			</header>