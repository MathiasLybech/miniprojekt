# miniprojekt
Miniprojekt for vibenhus gymnasium

Eksamensopgaven i imperativ programmering 2016


I den danske superliga mødes 12 fodboldhold indbyrdes i et antal kampe. Kampene er inddelt i runder med seks kampe i hver runde. (Dette var strukturen i superligaen i 2015-2016, og tidligere årgange). Der gives tre point for en sejr, ét point for uafgjort, og nul point for en tabt kamp. I tilfælde af pointlighed mellem to hold afgør målforskellen (differencen mellem antal mål scoret af holdet og antal mål scoret mod holdet), og dernæst det samlede antal scorede mål den indbyrdes placering af de to hold (sådan er reglerne i denne opgave). Hvis alt står lige, beslutter vi blot at ordne de to hold alfabetisk efter det forkortede klubnavn (som er på to eller tre store bogstaver).

Tekstfilen med kampresultaterne er linjeopdelt, med én kamp per linje. Formatet af en linje er følgende:
runde  ugedag  dato  klokkeslæt    hjemmehold - udehold   hjemmemål - udemål   tilskuerantal

Runden angives som Rn, hvor n er et heltal mellem 1 og 33. Et eller flere mellemrum adskiller disse bestanddele i tekstfilen. Eksempelvis betyder linjen
 R1 Fre     17/07/2015  18.00     FCN - SDR     0 - 2     3.211  

at FCN spillede mod SDR i runde 1; FCN scorede ingen mål; SDR scorede to mål; Kampen blev spillet 17. juli 2015 kl 18.00 på FCNs hjemmebane. Kampen blev overværet af 3211 tilskuere.

På baggrund af de indlæste data om kampene skal du skrive et C program med følgende problemløsningsfunktioner:

En funktion som finder (og returnerer) en liste af uafgjorte kampe, hvor der (i hver kamp) er scoret fire mål, eller flere.

En funktion som finder en evt. runde, hvor der er scoret mindre end 10 mål. Hvis runden findes skal både rundenummer og det antal mål, der i alt er scoret i denne runde, sendes tilbage til kaldstedet via parametre.
*Hint: Benyt pass by reference*

En funktion der finder (og returnerer) en liste af de hold, som vinder flere kampe på udebane end på hjemmebane.

En funktion der finder det hold, som i 2015-kampe har haft færrest tilskuere ved kampe, som spilles på klubbens hjemmebane. Den funktion, som løser problemet, skal både sende holdnavn og tilskuertallet tilbage til kaldstedet via parametre.

En funktion der finder et array af kampe med starttidspunkt mellem to givne klokkeslæt k1 og k2 og som spilles på en bestemt ugedag u. Funktionen, som løser dette problem, skal have k1, k2 og u som input parametre (side om side med andre nødvendige parametre). Det kan antages at k1 og k2 er klokkeslæt i det samme døgn. Kampe som starter præcist på tidspunkterne k1 og k2 medtages. Klokkeslæt-parametre i din funktion angives som tekststrenge på formen "hh:mm", f.eks. "15:00". Ugedags-parametren angives i dit program på samme forkortede form som i tekstfilen. Det fundne array af kampe skal enten returneres med return, eller sendes tilbage til kaldstedet via en parameter.

Meget svær opgave:
En funktion der beregner og (på standard output) udskriver en samlet tabel over stillingen i turneringen efter sidste spillerunde, i stil med stillingen vist i Wikipedias artikel om superligaen 2015 - 2016. I tabellen skal holdene være ordnede efter placeringen i turneringen, med det bedst placerede hold først og det dårligst placerede hold sidst. Endvidere skal der udskrives 'søjler' med point, antal spillede kampe, antal vundne kampe, antal tabte kampe, antal uafgjorte kampe, og målforskel.

*Hint*:
Lav en klasse.

