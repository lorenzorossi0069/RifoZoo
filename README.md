Timings:
Lez01:

2': detection e caricamentodi plugin che faarò io
(interfacciarsi a devices o altro)

4': interfaccie
20': Abstract class

32: Overrides

40':lascio Abstract classi come Marsupial o Amphibian, perché NON sono logicamente implementabili.
Erediterò invece classi NON Abstract da esse come Koala o Crocodile, ceh trovano già tutto pronto.

47' apro visual studio e incollo da skype
SKIP(47.xx-50.35")

55' 34": NuGet

1h 29': intro Extension method .Where e LambdaExpression
1h 45': varie su override ToString, GetType, etc

Lez02:

15': Namespaces (sub folders)

18' class diagram e namespaces

37' la visibilità implicita è dentro il ramo di appartenenza del namespace 
(una foglia riesce a vedere tutto del ramo cui è "attaccata")
(viceversa una ramo NON sa nulla dei suoi sottorami, salvo esplicitare mendiante "using")

48': Git push e pull da Dogmasolutions a visual studio
54':(skip) inizio esercizio: (aggiungo Employees, gerarchia di classi e struttura di namespaces)
1h13':(skip) Namespace devono avere nomi diversi da classi, se no conflitti...
1h 40': (skip) Aggiungo funzioni Hire e getAllEmployee durante esercizio
(skip fino a fine: esercizio e tentativi da 54' a fine lezione)

Lez03:
4'20": Interface vs abstract class: 
	se eredito Interface => implementazione (o definizione) obbligtoria
	se eredito Abstract Class => NON serve ri-definire un membri abstract (solo concreto prima di istanziarlo)
	
30': Virtual methods {concrete, abstract, virtual, override, new}

38': OOP è basata su {Incapsulamento[membri e funzionalità autocontenuti], Composizione[=ereditarietà: estendo funzioni/membri VISIBILI, cioè public o protected; NON posso estendere menbri private, eg variabili membro di stato interno], Polimorfisomo[]}

1h 14': new per pseudo-override a seguito di re-design di metodo (sealed o senza decoration(abstract, virtual)}

1h 36' esercizio gabbie associate ad animali (demo metodi di cui si può fare override)

2h 02': anzichè virtual, pe revitare di dimenticare operazioni, isolo le funzioni comuni


Lez10 
(Lez10-20211007_Dispose_inizioGenerics)

1h 20" inizio generics

