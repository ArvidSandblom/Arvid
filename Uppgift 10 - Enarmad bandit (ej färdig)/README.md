# Uppgift 10: Enarmad bandit

För att lösa denna uppgift kommer ni att behöva använda er utav allt som ni har lärt er. 

## Uppgiftsbeskrivning
Precis som med Sten, sax, påse-spelet så ska ni följa kravspecifikationen nedtill. För denna uppgift finns det inget krav på att ni måste skapa ett flödesschema, men om ni har svårt att komma igång så är det en god idé att börja där då man får en överskådlig blick av problemet. När ni är färdiga med uppgiften så laddar ni upp både flödesschemat och er project.cs-fil till Git. 

Kravspecifikation för produkten
* Spelaren ska själv kunna sätta in hur mycket pengar de vill ha på sitt konto. De ska inte kunna ha mindre än 10 och inte mer än 1000.
* Spelaren ska fritt kunna välja hur mycket de satsar (enbart heltal), men de ska inte kunna satsa mer pengar än vad de har på sitt konto. De ska inte heller kunna satsa 0 eller en negativ summa.
* Efter varje omgång ska spelaren få välja att kunna avsluta spelet. När de väljer att sluta spela ska de få information om hur mycket pengar de har på sitt saldo och hur mycket de vunnit/förlorat under spelets gång.
* Spelfältet ska skriva ut tre möjliga karaktärer (exempelvis X, Y, Z). Får man tre i rad så ska det leda till att spelaren dubblar det hen satsat.
* All information ska presenteras tydligt. Dvs. när man spelar ska det skrivas ut i konsolfönstret vilka symboler som slumpats fram, och det ska tydligt framgå hur mycket man vunnit eller förlorat.

BONUS:
* Skapa tre spelfält. Spelaren ska kunna vinna om tre symboler är lika i vågrät riktning. 
* Lägg till ytterligare vinstvillkor: spelaren ska kunna vinna om tre symboler är lika i lodrät riktning. 
* Lägg till ytterligare vinstvillkor: spelaren ska kunna vinna om tre symboler är lika i diagonal riktning.
