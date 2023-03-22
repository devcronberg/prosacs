| Tid (min) | Emne                           | Beskrivelse                                                                                                            |
| --------- | ------------------------------ | ---------------------------------------------------------------------------------------------------------------------- |
| 0-5       | Introduktion                   | Præsentation af foredragsholderen og en kort introduktion til C# og dets anvendelser.                                  |
| 5-15      | "Hello, World!"-eksempel       | Vejledning i, hvordan man opretter og kører et simpelt "Hello, World!"-program i C# fra bunden.                        |
| 15-25     | Formål og anvendelser          | Forklaring af, hvad C# kan bruges til, og eksempler på forskellige typer af applikationer og systemer, der bruger C#.  |
| 25-35     | Værktøjer og opsætning         | Introduktion til Visual Studio, Visual Studio Code og .NET SDK. Vejledning i, hvordan man opsætter et udviklingsmiljø. |
| 35-50     | Grundlæggende C#-syntaks       | Gennemgang af grundlæggende C#-syntaks såsom variabler, datatyper, operatører og kontrolstrukturer (if, for, while).   |
| 50-65     | Metoder og lambda-udtryk       | Forklaring af metoder, herunder hvordan man definerer og kalder dem, parametre, returtyper og lambda-udtryk.           |
| 65-80     | Pause                          | En 15-minutters pause for at give deltagerne en chance for at strække benene og stille spørgsmål.                      |
| 80-95     | Objektorienteret programmering | Introduktion til klasser, objekter, egenskaber og metoder, arv, interfaces og serialisering.                           |
| 95-105    | Fejlhåndtering og undtagelser  | Introduktion til fejlhåndtering i C# ved hjælp af try-catch blokke og undtagelsesklasser.                              |
| 105-115   | Samlinger og LINQ              | Gennemgang af samlingstyper som arrays, lister og ordbøger, samt introduktion til Language Integrated Query (LINQ).    |
| 115-120   | Spørgsmål og opsummering       | Mulighed for at stille spørgsmål og en kort opsummering af de vigtigste punkter fra foredraget.                        |

## Introduktion

-   C#'s historie
-   Hvorfor lære C#

### C#'s historie

C# er et moderne, objektorienteret programmeringssprog, der blev udviklet af Microsoft som en del af deres .NET Framework. Det blev først introduceret i 2000 af Anders Hejlsberg, som tidligere var kendt for at have arbejdet på Turbo Pascal og Delphi. C# er inspireret af C, C++ og Java og er designet til at være enkle og nemme at bruge, samtidig med at det tilbyder avancerede funktioner som stærk typekontrol, garbage collection og sprogbaseret understøttelse af parallel programmering.

C# har gennemgået flere versioner siden sin første udgivelse, og hver version har tilføjet nye funktioner og forbedringer. Nogle af de vigtigste milepæle i C#'s udvikling inkluderer:

-   C# 2.0 (2005): Generiske typer, anonyme metoder og iteratorer
-   C# 3.0 (2007): LINQ, lambda-udtryk, automatisk implementerede egenskaber og objektinitialisatorer
-   C# 5.0 (2012): async/await, som forenkler asynkron programmering
-   C# 7.0 (2017): Tupler, pattern matching og lokale funktioner

### Hvorfor lære C#?

Der er flere gode grunde til at lære C#:

-   Bred anvendelse: C# bruges i en lang række applikationer, herunder webudvikling (ASP.NET), desktop-applikationer (WPF, UWP), spiludvikling (Unity) og mobiludvikling (Xamarin). At lære C# giver dig mulighed for at arbejde på mange forskellige typer projekter.

-   Stærkt jobmarked: C# er et populært sprog, der er efterspurgt i mange brancher. At lære C# kan forbedre dine jobmuligheder og gøre dig mere attraktiv for potentielle arbejdsgivere.

-   .NET-økosystemet: C# er tæt integreret med .NET Framework og .NET Core, som tilbyder et stort bibliotek af klasser og funktioner, der gør det nemt at opbygge avancerede applikationer. Desuden understøtter .NET-platformen mange andre programmeringssprog, hvilket gør det nemt at samarbejde med andre udviklere og genbruge eksisterende kode.

-   Stærk community-støtte: C# har et stort og aktivt community, der arbejder sammen for at forbedre sproget og hjælpe andre med at lære det. Dette betyder, at du kan finde masser af ressourcer, værktøjer og hjælp fra andre udviklere, når du lærer C#.

-   Moderne sprogfunktioner: C# indeholder mange moderne sprogfunktioner, såsom lambda-udtryk, LINQ, asynkron programmering og pattern matching

## "Hello, World!"-eksempel

-   Oprettelse af et nyt C#-projekt
-   Skrivning af "Hello, World!"-koden
-   Kompilering og kørsel af programmet

## Formål og anvendelser

-   Desktopapplikationer
-   Webapplikationer
-   Mobilapplikationer
-   Spiludvikling

C# er et alsidigt programmeringssprog, der kan bruges til en bred vifte af applikationer. Nogle af de mest almindelige anvendelser inkluderer:

1. **Desktopapplikationer:**

    - C# bruges ofte til at oprette desktopapplikationer og konsolapplikationer på Windows-platformen.
    - Nogle populære teknologier og rammer til at bygge desktopapplikationer i C# inkluderer: - Console Application: En simpel applikationstype, der kører i en kommandoprompt og er velegnet til at lære programmering eller til at oprette små værktøjer og scripts. - Windows Presentation Foundation (WPF): En moderne UI-ramme til at bygge Windows-desktopapplikationer. - Universal Windows Platform (UWP): En ramme til at skabe applikationer, der kører på tværs af Windows-enheder, herunder pc'er, tablets og smartphones. - WinForms: En ældre ramme til at bygge Windows-desktopapplikationer, der stadig bruges i nogle eksisterende projekter. - .NET MAUI (Multi-platform App UI): En cross-platform ramme til at skabe native applikationer til Windows, macOS, iOS og Android ved hjælp af en enkelt kodebase. MAUI er efterfølgeren til Xamarin.Forms og er en del af .NET 6 og frem.
      ter.

2. **Webapplikationer:**

    - C# er et populært valg for webudvikling gennem ASP.NET-rammen, som understøtter både server-side og client-side programmering samt API-udvikling.
    - Nogle populære teknologier og rammer til webudvikling og API-udvikling i C# inkluderer:
        - ASP.NET Core: En open-source og cross-platform ramme til at bygge moderne webapplikationer, RESTful API'er og realtidsapplikationer ved hjælp af SignalR.
        - ASP.NET MVC: En ramme baseret på Model-View-Controller-arkitekturen til at skabe skalerbare og testbare webapplikationer og API'er.
        - Blazor: En SPA-ramme (Single Page Application) til at bygge interaktive klient-side webapplikationer ved hjælp af C# i stedet for JavaScript.
        - Web API: En ramme til at bygge HTTP-baserede API'er, der kan bruges fra forskellige klienter, herunder webbrowsere og mobile applikationer.

3. **Mobilapplikationer:**

    - C# bruges til at oprette mobilapplikationer til Android og iOS ved hjælp af Xamarin-rammen og .NET MAUI, som er en del af .NET-platformen.
    - Nogle populære teknologier og rammer til mobiludvikling i C# inkluderer:
        - Xamarin.Forms: En cross-platform ramme til at skabe native mobilapplikationer til Android og iOS ved hjælp af en enkelt kodebase. Xamarin.Forms tillader udviklere at skrive en fælles kodebase, som kan deles mellem forskellige platforme, hvilket reducerer tiden og omkostningerne ved at oprette separate applikationer til hver platform.
        - .NET MAUI (Multi-platform App UI): En cross-platform ramme til at skabe native applikationer til Windows, macOS, iOS og Android ved hjælp af en enkelt kodebase. MAUI er efterfølgeren til Xamarin.Forms og er en del af .NET 6 og frem.

4. **Spiludvikling:**
    - C# er det primære programmeringssprog for flere populære spilmotorer, herunder Unity og MonoGame.
    - Nogle populære teknologier og rammer til spiludvikling i C# inkluderer:
        - Unity: En af de mest populære spilmotorer i verden, der bruges til at oprette 2D- og 3D-spil, virtual reality og augmented reality oplevelser til en lang række platforme, herunder pc'er, konsoller, mobiltelefoner og webbrowsere.
        - MonoGame: En open-source, cross-platform spiludviklingsramme, der er en efterfølger til Microsoft XNA. MonoGame tillader udviklere at oprette 2D- og 3D-spil til en lang række platforme, herunder Windows, macOS, Linux, Android, iOS og mere.

## Værktøjer

-   [Visual Studio](https://visualstudio.microsoft.com/): Et kraftfuldt udviklingsmiljø til Windows og macOS, der understøtter C# og mange andre sprog. Visual Studio indeholder en lang række værktøjer og funktioner til at lette udviklingen af applikationer og spil.
-   [Visual Studio Code](https://code.visualstudio.com/): En letvægts, open-source og cross-platform kode-editor til Windows, macOS og Linux, der understøtter C# og mange andre sprog. Visual Studio Code kan udvides med et stort antal udvidelser, der tilføjer ekstra funktionalitet og understøttelse for forskellige sprog og teknologier.
-   [.NET SDK](https://dotnet.microsoft.com/download): Software Development Kit (SDK) til .NET-platformen, der indeholder værktøjer, kompilatorer og biblioteker, der er nødvendige for at udvikle, bygge og køre C#-applikationer. .NET SDK er tilgængelig for Windows, macOS og Linux.

## Grundlæggende C#-syntaks

### Variabler

En variabel er en navngivet lagerplads i computerens hukommelse, der indeholder en værdi af en bestemt datatype. Variabler bruges i programmering til at gemme midlertidige værdier, der kan ændres i løbet af programkørslen. I C# skal du deklarere en variabel ved at angive dens datatypen og navn, f.eks. `int count = 0;`, som opretter en variabel med navnet "count" og tildeler den en startværdi på 0.

### Datatyper

I C# er der forskellige typer af data, som kan opbevares i variabler. Nogle af de mest almindelige datatyper inkluderer:

-   `int`: heltal (f.eks. 1, 2, 3)
-   `double`: decimaltal med høj præcision (f.eks. 3.1415)
-   `string`: tekststreng (f.eks. "Hej verden!")
-   `bool`: en sand eller falsk værdi (f.eks. `true` eller `false`)
-   `char`: en enkelt karakter (f.eks. 'a' eller 'b')

### Operatører

Operatører i C# bruges til at udføre aritmetiske, logiske og sammenligningsmæssige operationer på variabler og værdier. Nogle af de mest almindelige operatører inkluderer:

-   Aritmetiske operatører: `+` (addition), `-` (subtraktion), `*` (multiplikation), `/` (division), `%` (modulo)
-   Logiske operatører: `&&` (and), `||` (or), `!` (not)
-   Sammenligningsmæssige operatører: `==` (lig med), `!=` (ikke lig med), `<` (mindre end), `>` (større end), `<=` (mindre end eller lig med), `>=` (større end eller lig med)

### Kontrolstrukturer

Kontrolstrukturer i C# bruges til at styre programflowet og tage beslutninger baseret på visse betingelser. Nogle af de mest almindelige kontrolstrukturer inkluderer:

-   `if`-statement: Bruges til at udføre en kodeblok, hvis en betingelse er sand.
-   `for`-loop: Bruges til at udføre en kodeblok et bestemt antal gange.
-   `while`-loop: Bruges til at udføre en kodeblok, så længe en betingelse er sand.

```csharp
using System;

namespace BasicCSharpSyntaxExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabler og datatyper
            int number1 = 10;
            double number2 = 20.5;
            char character = 'A';
            string text = "Hello, world!";
            bool isTrue = true;

            // Operatorer
            int sum = number1 + (int)number2; // Typekonvertering fra double til int
            int difference = number1 - 5;
            double product = number1 * number2;
            double quotient = number1 / number2;

            // Kontrolstrukturer: if-else
            if (number1 > number2)
            {
                Console.WriteLine("number1 er større end number2");
            }
            else
            {
                Console.WriteLine("number1 er mindre end eller lig med number2");
            }

            // Kontrolstrukturer: for-løkke
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Tæller: {i}");
            }

            // Kontrolstrukturer: while-løkke
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine($"Counter: {counter}");
                counter++;
            }

            // Kontrolstrukturer: switch-case
            switch (character)
            {
                case 'A':
                    Console.WriteLine("Character er A");
                    break;
                case 'B':
                    Console.WriteLine("Character er B");
                    break;
                default:
                    Console.WriteLine("Character er hverken A eller B");
                    break;
            }
        }
    }
}
```

## Metoder og lambda-udtryk

### Metode-definitioner

En metode i C# er en kodeblok, der udfører en bestemt handling og kan kaldes fra andre dele af koden. Metoder skal defineres med et navn, en række parametre og en returtype. En metode kan også have en kodeblok, der udføres, når metoden kaldes.

### Parametre

Parametre er værdier, som en metode modtager, når den kaldes. Parametre kan bruges i metoden til at udføre en bestemt handling. Parametre skal defineres med en datatype og et navn i metode-definitionen.

### Returtyper

Returtypen i en metode definerer den datatype, som metoden returnerer, når den er færdig med at udføre sin handling. Hvis en metode ikke returnerer nogen værdi, skal den defineres med en returtype af typen `void`.

# ## Lambda-udtryk

Et lambda-udtryk er en kort syntaks til at definere en anonym metode i C#. Lambda-udtryk kan bruges til at definere en inline funktion, der kan bruges til at udføre en bestemt handling. Lambda-udtryk består normalt af en parameterliste, en pile-operatør (`=>`) og en kodeblok, der udfører handlingen.

```csharp
using System;

namespace MethodsAndLambdasExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definere og kalde en metode
            int sum = AddNumbers(5, 10);
            Console.WriteLine($"Summen af 5 og 10 er: {sum}");

            // Definere og kalde en metode med returtypen void
            PrintGreeting("John");

            // Anonyme metoder
            Func<int, int, int> multiply = delegate(int a, int b)
            {
                return a * b;
            };
            Console.WriteLine($"Produktet af 3 og 4 er: {multiply(3, 4)}");

            // Lambda-udtryk
            Func<int, int, int> subtract = (a, b) => a - b;
            Console.WriteLine($"Differencen mellem 7 og 2 er: {subtract(7, 2)}");
        }

        // En metode, der tager to heltal som parametre og returnerer deres sum
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // En metode, der tager en streng som parameter og udskriver en hilsen
        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hej, {name}!");
        }
    }
}
```

## Objektorienteret programmering

### Klasser

I C# bruges klasser til at definere objekttyper. En klasse er en skabelon eller en blåprint, der beskriver egenskaberne og adfærden af objekter af denne type. En klasse kan indeholde datamedlemmer, metoder og andre typer af medlemmer.

### Objekter

Objekter i C# er instanser af klasser. Når du opretter et objekt, oprettes der en ny instans af klassen. Objekter kan indeholde data og udføre handlinger i henhold til klassedefinitionen.

### Egenskaber

Egenskaber i C# er medlemmer af klasser, der bruges til at få eller sætte værdier på en bestemt data medlem i klassen. Egenskaber består normalt af en get-metode og en set-metode, der bruges til at hente og gemme værdier i klassen.

### Serialisering

Serialisering i C# er processen med at konvertere et objekt til en strøm af bytes, der kan gemmes eller overføres. C# understøtter forskellige typer af serialisering, f.eks. binær serialisering, XML-serialisering og JSON-serialisering.

### Metoder

Metoder i C# er kodeblokke, der udfører en bestemt handling og kan kaldes fra andre dele af koden. En metode kan have inputparametre og returnere en værdi. Metoder kan bruges til at udføre gentagne handlinger eller udføre komplekse operationer i programmet.

### Interfaces

Interfaces i C# er en samling af metoder og egenskaber, der kan implementeres af en klasse. Et interface definerer en kontrakt, som en klasse skal overholde for at være kompatibel med andre dele af koden. Interfaces kan bruges til at opdele store applikationer i mindre, mere sammenhængende dele og opnå løs kobling mellem forskellige dele af koden.

```csharp
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ObjectOrientedProgrammingExample
{
    interface IAnimal
    {
        void MakeSound();
    }

    [DataContract]
    class Animal : IAnimal
    {
        [DataMember]
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} laver en lyd.");
        }
    }

    [DataContract]
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} siger vov!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("Dyr");
            myAnimal.MakeSound();

            Dog myDog = new Dog("Hund");
            myDog.MakeSound();

            IAnimal animalInterface = myDog;
            animalInterface.MakeSound();

            SerializeAnimal(myDog, "dog.json");
            Dog deserializedDog = DeserializeAnimal<Dog>("dog.json");
            Console.WriteLine($"Deserialiseret hundens navn: {deserializedDog.Name}");
        }

        static void SerializeAnimal<T>(T animal, string fileName)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var stream = File.Create(fileName))
            {
                serializer.WriteObject(stream, animal);
            }
        }

        static T DeserializeAnimal<T>(string fileName)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var stream = File.OpenRead(fileName))
            {
                return (T)serializer.ReadObject(stream);
            }
        }
    }
}
```

## Fejlhåndtering og undtagelser

-   Try-catch blokke
-   Brug af finally

```csharp
using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3 };

            try
            {
                // Dette kaster en IndexOutOfRangeException, da indekset 3 er uden for grænserne for arrayet
                int number = numbers[3];
                Console.WriteLine(number);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("En fejl opstod: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Dette vil altid blive kørt, uanset om der opstod en fejl eller ej.");
            }

            try
            {
                int result = Divide(10, 0);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("En fejl opstod: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Dette vil altid blive kørt, uanset om der opstod en fejl eller ej.");
            }
        }

        static int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Divisor kan ikke være 0.");
            }

            return dividend / divisor;
        }
    }
}
```

## Samlinger og LINQ

### Arrays

Arrays i C# er en samling af elementer af samme datatypen, der er gemt i en kontinuerlig hukommelsesblok. Du kan få adgang til elementerne i arrayet ved hjælp af deres indexnummer, som starter ved 0. Arrays i C# kan være af en hvilken som helst datatypen, og størrelsen af et array skal angives ved oprettelsestidspunktet.

### Lister

Lister i C# er en dynamisk samling af elementer af samme datatypen, der kan vokse og krympe efter behov. Du kan tilføje, slette eller ændre elementer i en liste ved hjælp af forskellige metoder. Lister i C# kan være af en hvilken som helst datatypen.

### LINQ grundlæggende

LINQ står for Language Integrated Query, og det er en måde at skrive SQL-lignende forespørgsler i C#. LINQ kan bruges til at hente data fra forskellige kilder, f.eks. arrays, lister, databaser osv. LINQ-forespørgsler består normalt af en række operationer, f.eks. filtrering, sortering, gruppe og projicering, og de kan udtrykkes ved hjælp af forskellige metoder.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndLinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            int[] numbersArray = new int[] { 1, 2, 3, 4, 5 };

            // Lister
            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };

            // LINQ grundlæggende: Forespørgselssyntaks
            var evenNumbersQuery = from number in numbersList
                                   where number % 2 == 0
                                   select number;

            Console.WriteLine("Lige tal (forespørgselssyntaks):");
            foreach (var number in evenNumbersQuery)
            {
                Console.WriteLine(number);
            }

            // LINQ grundlæggende: Metodesyntaks
            var evenNumbersMethod = numbersList.Where(number => number % 2 == 0);

            Console.WriteLine("Lige tal (metodesyntaks):");
            foreach (var number in evenNumbersMethod)
            {
                Console.WriteLine(number);
            }

            // Flere LINQ-eksempler
            var squaredNumbers = numbersList.Select(number => number * number);
            Console.WriteLine("Kvadrerede tal:");
            foreach (var number in squaredNumbers)
            {
                Console.WriteLine(number);
            }

            var sumOfNumbers = numbersList.Sum();
            Console.WriteLine($"Summen af tal: {sumOfNumbers}");

            var minNumber = numbersList.Min();
            Console.WriteLine($"Mindste tal: {minNumber}");

            var maxNumber = numbersList.Max();
            Console.WriteLine($"Største tal: {maxNumber}");

            var average = numbersList.Average();
            Console.WriteLine($"Gennemsnit: {average}");
        }
    }
}
```

## Spørgsmål og opsummering

-   Spørgsmål fra deltagerne
-   Opsummering af nøglepunkter
