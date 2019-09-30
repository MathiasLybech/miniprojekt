# Miniprojekt for vibenhus gymnasium

## Eksamensopgaven i imperativ programmering 2016


I den danske superliga m�des 12 fodboldhold indbyrdes i et antal kampe. Kampene er inddelt i runder med seks kampe i hver runde. (Dette var strukturen i superligaen i 2015-2016, og tidligere �rgange). Der gives tre point for en sejr, �t point for uafgjort, og nul point for en tabt kamp. I tilf�lde af pointlighed mellem to hold afg�r m�lforskellen (differencen mellem antal m�l scoret af holdet og antal m�l scoret mod holdet), og dern�st det samlede antal scorede m�l den indbyrdes placering af de to hold (s�dan er reglerne i denne opgave). Hvis alt st�r lige, beslutter vi blot at ordne de to hold alfabetisk efter det forkortede klubnavn (som er p� to eller tre store bogstaver).

Tekstfilen med kampresultaterne er linjeopdelt, med �n kamp per linje. Formatet af en linje er f�lgende:
runde  ugedag  dato  klokkesl�t    hjemmehold - udehold   hjemmem�l - udem�l   tilskuerantal

Runden angives som Rn, hvor n er et heltal mellem 1 og 33. Et eller flere mellemrum adskiller disse bestanddele i tekstfilen. Eksempelvis betyder linjen
 R1 Fre     17/07/2015  18.00     FCN - SDR     0 - 2     3.211  

at FCN spillede mod SDR i runde 1; FCN scorede ingen m�l; SDR scorede to m�l; Kampen blev spillet 17. juli 2015 kl 18.00 p� FCNs hjemmebane. Kampen blev overv�ret af 3211 tilskuere.

P� baggrund af de indl�ste data om kampene skal du skrive et C# program med f�lgende probleml�sningsfunktioner:

### Opgave 1:
En funktion som finder (og returnerer) en liste af uafgjorte kampe, hvor der (i hver kamp) er scoret fire m�l, eller flere.

### Opgave 2:
En funktion som finder en evt. runde, hvor der er scoret mindre end 10 m�l. Hvis runden findes skal b�de rundenummer og det antal m�l, der i alt er scoret i denne runde, sendes tilbage til kaldstedet via parametre.
*Hint: Benyt pass by reference*

### Opgave 3:
En funktion der finder (og returnerer) en liste af de hold, som vinder flere kampe p� udebane end p� hjemmebane.

### Opgave 4:
En funktion der finder det hold, som i 2015-kampe har haft f�rrest tilskuere ved kampe, som spilles p� klubbens hjemmebane. Den funktion, som l�ser problemet, skal b�de sende holdnavn og tilskuertallet tilbage til kaldstedet via parametre.

### Opgave 5:
En funktion der finder et array af kampe med starttidspunkt mellem to givne klokkesl�t k1 og k2 og som spilles p� en bestemt ugedag u. Funktionen, som l�ser dette problem, skal have k1, k2 og u som input parametre (side om side med andre n�dvendige parametre). Det kan antages at k1 og k2 er klokkesl�t i det samme d�gn. Kampe som starter pr�cist p� tidspunkterne k1 og k2 medtages. Klokkesl�t-parametre i din funktion angives som tekststrenge p� formen "hh:mm", f.eks. "15:00". Ugedags-parametren angives i dit program p� samme forkortede form som i tekstfilen. Det fundne array af kampe skal enten returneres med return, eller sendes tilbage til kaldstedet via en parameter.

### Opgave 6
Meget sv�r opgave:
En funktion der beregner og (p� standard output) udskriver en samlet tabel over stillingen i turneringen efter sidste spillerunde, i stil med stillingen vist i Wikipedias artikel om superligaen 2015 - 2016. I tabellen skal holdene v�re ordnede efter placeringen i turneringen, med det bedst placerede hold f�rst og det d�rligst placerede hold sidst. Endvidere skal der udskrives 's�jler' med point, antal spillede kampe, antal vundne kampe, antal tabte kampe, antal uafgjorte kampe, og m�lforskel.

*Hint*:
Lav en klasse.

