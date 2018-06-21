   Miljö och utveckling
  
 ===================================================  
 
Detta projekt genererades i Visual Studio 2017. För att köra det här projektet måste du ha 
 en full version
 av Visual Studio 2017 och Microsoft operativsystem.


  

   Kör Server och Endpoint
 
 ===================================================  
 Servern 

kör på IISExpress och Internet Explorer men bör kunna köras på alla webbläsare
 (som körs på Microsoft operativsystem) för user interface. Att köra
 detta projektet 
 behöver ni för att navigera till http://localhost:50290/Catalog/Index i webbläsare.

  Nödvändiga dependecies och C# bibliotek
  
 ==================================================
 Följande krävs för att driva projektet (inställning från början)
 
  using System.Linq;
  using System.Net;
  using System.Net.Http;
  using System.Web.Http;
  using System.Xml.Linq;



  Funktionalitet
  
 =================================================== 
 En användare som kör API utan problem med http://localhost:50290/Catalog/Index, kommer att
 komma till sidan med en sökruta(search box).Först kommer användaren att kunna se alla 
 böcker i tabell form med titel, författare, genre, pris, publiceringsdatum och beskrivning
 (title, author, genre,price, publish_date and description).
 Användaren kan leta efter en bok via titel genom att skriva minst en bokstav eller fler.
 Efter att en bokstav eller fler till exempel i små eller stora bokstäver skrivits in i 
 sökrutan(search box) behöver användaren klicka på sök(search).Den relevanta informationen
 kommer att visas i tabellen. Om användaren vill se hela bok katalogen trycker denne 
 på ta bort knappen(a clear button click) och användaren kommer tillbaka till hela katalogen
 med böcker.
 
 Running unit tests

Run
 
 =====================================================
 Det finns unit testing där och jag kunde har lagt till fler detaljer om det hade behövts.