# Axevalla folkhögskola: Programmering (grund)

Kommandoguide för GIT:

1. Jag vill hämta ett projekt från Git till min dator.
Gå in på det repository ni vill hämta och klicka på den gröna knappen där det står **<> Code**. Sedan kopierar ni HTTPS-adressen. Därefter orienterar ni er till var ni vill spara projektet på datorn. Högerklicka och välj att öppna Git bash. Sedan skriver ni in följande: 
* git **clone** [klistra in er adress här]

2. Jag vill byta till min branch.
För att byta branch skriver ni följande kommando: git checkout [namnet på er branch]
Vill ni skapa en ny branch så kan ni skriva följande: 
* git **checkout -b** [namn på er nya branch]

3. Jag vill spara mina ändringar. Då skriver ni följande kommando:
* git **add .**
* git **commit -m** **"**[skriv ett meddelande här innanför citattecknena]**"**

4. Jag vill ladda upp mina ändringar till Git. Då skriver ni följande kommando:
* git **push**

5. Jag vill hämta ändringar i projektet från nätet. Då skriver ni följande kommando:
* git **pull**
