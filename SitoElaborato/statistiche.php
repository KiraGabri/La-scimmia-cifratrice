<?php
include ("ints.php");
include ("dbConnection.php");
?>

<div id="main-content">
<h1>
Dati statistici
</h1>

<section>
<article>
<div id="tab">

<table>
<tr>
<th><h3>Lunghezza chiave</h3></th> 
<th><h3>Simboli al posto giusto</h3></th> 
<th><h3>Media Simboli giusti</h3></th> 
<th><h3>Frasi sbagliate</h3></th> 
</tr>
<?php 
$sameSymbol=0;
$NoSymbolMatching=0;
$cSymbol=0;
$keyLength=0;
$sameSymbolPosition=0;
$sql="SELECT KeyLength,cryptoString,monkeyString FROM monkey.mStrings,monkey.mKeys WHERE mKeys.IDKey=mStrings.Key_ID ORDER BY KeyLength";
$result=mysqli_query($connessione, $sql);
if(mysqli_num_rows($result)>0)
{
    $rowCounter=0;
    $currentRow=0;

    while($row = mysqli_fetch_assoc($result))
    {
        $currentRow++;
        $rowCounter++;
        if($keyLength==0)
        {
            $keyLength=$row['KeyLength'];
        }
        if($keyLength!=$row['KeyLength'])
        {
            echo"<tr>";
            echo "<th><h3> ".$keyLength."</h3></th>";
            printf("<th><h3>".$sameSymbolPosition."</h3></th>"); 
            printf("<th><h3>".round(($sameSymbol)/$currentRow,1)."</h3></th>");
            echo"<th><h3>".round(($NoSymbolMatching/$currentRow)*(100),1)."%</h3></th>";
            echo"</tr>";
            $sameSymbolPosition=0;
            $NoSymbolMatching=0;
            $sameSymbol=0;
            $cSymbol=0;
            $currentRow=0;
            $keyLength=$row['KeyLength'];
        }
        $cSymbol=$sameSymbol;
        $cryptoString=$row['cryptoString'];
        $monkeyString=$row['monkeyString'];
        $cS="";
        $mS="";
        
        for($i=0;$i<strlen($monkeyString);$i++)
        {
            if($monkeyString[$i]==$cryptoString[$i])
            {
                $sameSymbolPosition++;
            }
        }
        for($i=0;$i<strlen($monkeyString);$i++)
        {
            if(!strpos($mS,$monkeyString[$i],0))
            {
                $mS[$i]=$monkeyString[$i];
            }
            if(!strpos($cS,$cryptoString[$i],0))
            {
                $cS[$i]=$cryptoString[$i];
            }
        }
        
        for($c=0;$c<strlen($cS);$c++)
        {
           if(strpos($mS,$cS[$c],0))
           {
               $sameSymbol++;
           }
        }
        if($cSymbol==$sameSymbol)
        {
            $NoSymbolMatching++;
        }
        if(mysqli_num_rows($result)==$rowCounter)
        {
            echo "<th><h3>".$row['KeyLength']."</h3></th>";
            printf("<th><h3>".$sameSymbolPosition."</h3></th>"); 
            printf("<th><h3>".round(($sameSymbol)/$currentRow,1)."</h3></th>");
            echo"<th><h3>".round(($NoSymbolMatching/$currentRow)*(100),1)."%</h3></th>";
            $sameSymbolPosition=0;
            $NoSymbolMatching=0;
            $sameSymbol=0;
            $cSymbol=0;
        }

    }

}
?>
</table>

</article>
</section>
</div>

<?php
include ("piede.html");
?>

