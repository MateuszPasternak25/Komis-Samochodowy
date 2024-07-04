

# Komis #

## Opis projektu

Projekt jest prostą aplikacją do zarządzania komisem samochodowym. Umożliwia dodawanie, edytowanie oraz usuwanie samochodów i klientów, a także oznaczanie samochodów jako sprzedane. Aplikacja została napisana w języku C# z wykorzystaniem Windows Forms.

## Struktura plików


- `Zarzadzanie.cs`: Klasa zarządzająca logiką biznesową aplikacji, taką jak dodawanie, usuwanie i edytowanie samochodów i klientów.
- `Samochod.cs`: Klasa reprezentująca samochód.
- `Klient.cs`: Klasa reprezentująca klienta.
- `Sprzedaz.cs`: Klasa reprezentująca informacje na temat sprzedaży samochodu.
- `Main.cs`: Główny formularz aplikacji.
- `ZarzadzajKlientemForm.cs`: Formularz do zarządzania klientami.
- `OznJakoSprzedanyForm.cs`: Formularz do oznaczania samochodów jako sprzedane.
- `EdytujSamochodForm.cs`: Formularz do edytowania informacji o samochodach.
- `Program.cs`: Punkt wejścia do aplikacji.

## Jak uruchomić ##

1. Upewnij się, że masz zainstalowane środowisko programistyczne, takie jak Visual Studio.
2. Otwórz projekt w Visual Studio.
3. Załącz aplikacje klikając u góry zielony trójkąt koło którego znajduję się napis "komis".


## Funkcjonalności

### Dodawanie samochodów

Aby dodać nowy samochód, wypełnij pola "Marka", "Model", "Rok produkcji", "Cena zakupu" oraz "Cena wystawiona" i kliknij przycisk "Dodaj". Nowy samochód zostanie dodany do listy samochodów.

### Wyświetlanie samochodów

W głównym formularzu znajdują się dwie opcje wyświetlania samochodów:
- "Wyświetl sprzedane samochody" - pokazuje wszystkie sprzedane samochody.
- "Wyświetl nie sprzedane samochody" - pokazuje wszystkie niesprzedane samochody.

### Edytowanie samochodów

Aby edytować samochód, kliknij dwukrotnie na wybrany samochód z listy. Otworzy się formularz, w którym można zmienić dane samochodu.

### Dodawanie klientów

Aby dodać nowego klienta, otwórz formularz zarządzania klientami, wypełnij pola "Imię", "Nazwisko", "Adres" oraz "Numer telefonu" i kliknij przycisk "Dodaj". Nowy klient zostanie dodany do listy klientów.

### Edytowanie klientów

Aby edytować klienta, kliknij dwukrotnie na wybranego klienta z listy. Otworzy się formularz, w którym można zmienić dane klienta.

### Oznaczanie samochodów jako sprzedane

Aby oznaczyć samochód jako sprzedany, kliknij dwukrotnie na wybrany samochód z listy. Otworzy się formularz, w którym można wybrać klienta oraz podać cenę i datę sprzedaży.

## Wymagania systemowe

- .NET Framework 6.0.0 lub nowszy
- System operacyjny Windows

## Autorzy

- Mateusz Mendyk
- Mateusz Pasternak

 ## Aspekty objektowości w projekcie: 

##  Dziedziczenie:
- Klasa Samochód dziedziczy po klasie Pojazd
- Klasa klient dziedziczy po klasie Osoba
##  Polimorfizm
- Metoda ToString() w klasie Pojazd i Samochod


