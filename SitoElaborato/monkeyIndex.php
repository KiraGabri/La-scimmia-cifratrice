<?php
include ("ints.php");
include ("dbConnection.php");
?>
<div id="main-content">
<aside id="none">
</aside>
				<aside id="follow" class="follow">
					<h1>Dati recenti</h1>
					<hr />
					<h3>Frasi salvate:
				    <a >
					<p>
					<?php
						$sql="SELECT COUNT(IdStrings) AS Stringnum FROM monkey.mStrings ;";
						$result=mysqli_query($connessione, $sql);
						if(mysqli_num_rows($result)>0)
						{
    						while($row = mysqli_fetch_assoc($result))
    						printf("".$row['Stringnum']."");
    
						}
				    ?>
					</p>
					</a>
				</h3>
					<hr />
					<h3>Caratteri stringa minore:
					<a>
						<p>
						<?php
						$sql="SELECT MIN(LENGTH(CryptoString)) AS MinString FROM monkey.mStrings;";
						$result=mysqli_query($connessione, $sql);
						if(mysqli_num_rows($result)>0)
						{
							while($row = mysqli_fetch_assoc($result))
							printf("".$row['MinString']."");
							
						}
					?>	
					</p>
					</a>
				    </h3>
					<hr />
					<h3>Caratteri stringa maggiore:
						<a>
						<p>
							<?php
							$sql="SELECT MAX(LENGTH(CryptoString)) AS MaxString FROM monkey.mStrings;";
							$result=mysqli_query($connessione, $sql);
							if(mysqli_num_rows($result)>0)
							{
								while($row = mysqli_fetch_assoc($result))
								printf("".$row['MaxString']."");							
							}
						?>
						</p>
						</a>
					</h3>
					<hr />
					<h3> Lunghezza media:
						<a>
						<p>
							<?php
							$sql="SELECT AVG(LENGTH(CryptoString)) AS AvgString FROM monkey.mStrings;";
							$result=mysqli_query($connessione, $sql);
							if(mysqli_num_rows($result)>0)
							{
								while($row = mysqli_fetch_assoc($result))
								printf("".round($row['AvgString'])."");
							}
						?>
						</p>
						</a>
					</h3>
					
				</aside>
				<section>
					<article>
					<h1>Il progetto</h1>
						<p>
						L’obbiettivo di questo progetto è unire il Test di Turing con il teorema della scimmia instancabile, infatti comparando i risultati del dispositivo scimmia alle frasi criptate, è indistinguibile quale dei due origini da una frase scritta da un essere umano.
						Secondo il teorema della scimmia instancabile una scimmia che preme a caso i tasti di una tastiera per un tempo infinitamente lungo quasi certamente riuscirà a comporre qualsiasi testo prefissato, come ad esempio la “Divina commedia” di Dante.	
						</p>
						<div>
						<img src="Immagini/monke.jpg">
						</div>

						
					</article>
					
					<article>
					<h1>Il Dispositivo Scimmia</h1>
						
						<p>
						Il dispositivo Scimmia e` stato realizzato con Arduino, il suo compito e` di rispondere ad una richiesta sulla porta seriale generando una sequenza di simboli casuali della lunghezza richiesta.<br>
						La sequenza viene inoltre visualizzata su un display LCD e trasmessa via seriale.
						</p>
						<div>
						<img src="Immagini/Arduino1.jpeg">
						</div>
					</article>

					<article>
					<h1>Il Controllore Scimmia</h1>
						
						<p>
						Utilizzando un programma dotato di una interfaccia, nel quale è presente un form in cui bisogna autenticarsi, si accede ad una sezione del programma nella quale è possibile inserire la frase da criptare e creare diverse impostazioni di criptazione.
						 La frase inserita viene criptata e salvata in una tabella di una base dati. Contemporaneamente però si attiva la  sequenza di simboli di pari lunghezza della frase criptata. Questa sequenza di caratteri rappresenterà la cifratura scimmiottata e sarà anch’essa salvata nella base dati.
						</p>
						<div>
						<img src="Immagini/scimmia.png">
						</div>
						
					</article>

				</section>	
			</div>


<?php
include ("piede.html");
?>

