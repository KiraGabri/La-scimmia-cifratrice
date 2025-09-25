#include <LiquidCrystal.h>
#include <Entropy.h>

LiquidCrystal lcd(12,11,5,4,3,2);
byte numeroCar=0;
char monkeyString[256]="";  //inizzializo la stringa casuale a 255 come valore massimo

int stringStart, stringEnd = 0;
int scrollCursor = 16; 


void setup() {
Serial.begin(115200);
Entropy.initialize();
lcd.begin(16,2);
}

void createRandomString()
{
  monkeyString[numeroCar]='\0';
  
  for(int i=0;i<numeroCar;i++)
  {
    byte randomValue;
    do
    {
      randomSeed(Entropy.random()); // Viene scelto il nuovo seed di random 
      randomValue = random(33, 127); 
    }while(randomValue==92 || randomValue==39 || randomValue==34);
    char letter = randomValue ; 
    monkeyString[i]=letter; // Salvo la lettera nella stringa
  }
  
}
  



void loop() 
{
  stringEnd = 0;
  stringStart = 0;
  scrollCursor = 16;
  
  lcd.setCursor(0,0);
  lcd.print("Aspetto i Dati"); // Stampo nell'LCD due stringhe per indicare l'attesa dei dati
  lcd.setCursor(0,1);
  lcd.print("Scimmia annoiata...");
  delay(1000);
  if(Serial.available())
  {// Ricevo un segnale dalla porta seriale
    

    
    numeroCar=Serial.parseInt(); // Leggo il numero di caratteri dalla seriale
    
    lcd.clear();
    lcd.setCursor(0,0);
    if(numeroCar!=0){lcd.print("Scimmia scrive..");}
    createRandomString(); // Richiamo il metodo per scrivere una nuova stringa scimmia
    if(numeroCar>16)
    {
      for(int i=0;i<numeroCar;i--)
      {// Ciclo di stampa e scorrimento della stringa creata
    
        lcd.clear();
        lcd.setCursor(0,0);
        lcd.print("Scimmia dice:"); // Stringa della prima riga
        lcd.setCursor(scrollCursor,1); // cambio il cursore LCD al valore a cui scrivere il prossimo carattere
        
    
        for(int f=stringStart;f<=stringEnd;f++) 
        {// stampo tutti i caratteri a partire dall'attuale inizio stringa
      
          lcd.print(monkeyString[f]);
          if(f==numeroCar) 
          {// Nel momento in cui abbiamo stampato tutti i caratteri della stringa, imposto stringEnd a un numero impossibile da raggiungere normalmente
            delay(2000);
            stringEnd=257;
            break;
          }
        }
        if(stringEnd==257)
        {// Se abbiamo terminato la stampa dell'intera stringa, esce dal ciclo.
          delay(1000);
          break;
        }
  
        delay(500);
        
        if(scrollCursor > 0)
        {
          scrollCursor--; // continuo a Spostare il cursore da 16 fino a 0 (stringStart comincia ad aumentare dopo questo passaggio)
          stringEnd++;             
        }
        else 
        { // aumento le variabili di controllo stampa della stringa
          stringStart++;
          stringEnd++;
        }
      }
    }
    else
    {
      lcd.clear();
      lcd.setCursor(0,0);
      lcd.print("Scimmia dice:");
      lcd.setCursor(0,1);
      lcd.print(monkeyString);
      delay(3000);
    }

    if(numeroCar!=0)
    {
      Serial.println(monkeyString); // Invio alla seriale la stringa creata
    }
  
  }

  delay(1000);
}
