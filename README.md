# Komis #

## Opis projektu

Projekt jest prostą aplikacją do zarządzania komisem samochodowym. Umożliwia dodawanie, edytowanie oraz usuwanie samochodów i klientów, a także oznaczanie samochodów jako sprzedane. Aplikacja została napisana w języku C# za pomocą Windows Forms oraz użyty został pakiet Newtonsoft.Json, który służy do zapisywanie i odczytu danych.

## Funkcjonalności

## Wyświetlanie samochodów

W głównym formularzu znajdują się dwie opcje wyświetlania samochodów:
- "Wyświetl sprzedane samochody" - pokazuje wszystkie sprzedane samochody.
- "Wyświetl nie sprzedane samochody" - pokazuje wszystkie niesprzedane samochody.
  
![main](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/7e22648e-34c3-4c49-9748-b7225e9934cb)

## Dodawanie samochodów

Aby dodać nowy samochód, wypełnij pola "Marka", "Model", "Rok produkcji", "Cena zakupu" oraz "Cena wystawiona" i kliknij przycisk "Dodaj". Nowy samochód zostanie dodany do listy samochodów.

![Bez tytułu](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/0e793e19-0f19-4458-9461-ae10da5e1d5b)

## Edytowanie samochodów

Aby edytować samochód, kliknij dwukrotnie na wybrany samochód z listy. Otworzy się formularz, w którym można zmienić dane samochodu.

![edit](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/63fb11ec-52f0-4c94-9c08-ba71e907d8aa)

## Usuwanie samochodów

Aby usunąć samochód z listy należy kliknąć na wybrany samochód dwukrotnie. Pojawi nam się wtedy okno do edycji gdzie znajduje się przycisk "Usuń".

![usunc](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/2ad49bcc-da0e-483f-8a61-2857e9cb07cd)

## Oznaczanie samochodów jako sprzedane

Aby oznaczyć samochód jako sprzedany, kliknij dwukrotnie na wybrany samochód z listy, następnie kliknij guzik "Oznacz jako jako sprzedany". Otworzy się formularz, w którym można wybrać klienta oraz podać cenę i datę sprzedaży. Klienta wybieramy poprzez dwukrotne kliknięcie na niego na liście.

![OznJakSprzed](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/64cb6b73-4c93-4f0a-a177-9bfcb605a017)

![OznJakSprzed](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/4ea191a9-e85d-4f91-8466-10699b6d26be)

## Dodawanie klientów

Aby dodać nowego klienta, otwórz formularz zarządzania klientami, wypełnij pola "Imię", "Nazwisko", "Adres" oraz "Numer telefonu" i kliknij przycisk "Dodaj". Nowy klient zostanie dodany do listy klientów.

![DodKli](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/9208c2e3-f843-4891-8d53-39eadf1e4ccf)

## Edytowanie klientów

Aby edytować klienta, kliknij dwukrotnie na wybranego klienta z listy. Otworzy się formularz, w którym można zmienić dane klienta.

![EdytKli](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/bb96c1ac-aa41-4915-a720-7add0d40d003)

## Usuwanie klientów

Aby edytować klienta, kliknij dwukrotnie na wybranego klienta z listy. Otworzy się formularz, w którym można zmienić dane klienta.

![DelKli](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/4c24223e-6108-4d44-90aa-320fd6f33920)

## UML

![UML](https://github.com/MateuszPasternak25/Komis-Samochodowy/assets/168337261/0d036ccc-6863-4fa0-bef7-1fba338e06f9)


## Aspekty objektowości w projekcie: 

 **Dziedziczenie:**
 
- Klasa Samochód dziedziczy po klasie Pojazd
- Klasa klient dziedziczy po klasie Osoba
  
**Polimorfizm**
  
- Metoda ToString() w klasie Pojazd i Samochod

**Hermetyzacja**
- Pola do przypisywanie ID dla samochodów i klientów
- Metody WczytajDaneZPliku oraz ZapiszDane odpowiedzialne za zapisywanie i odczyt danych

## Wymagania systemowe

- .NET Framework 6.0.0 lub nowszy
- System operacyjny Windows
- pakiet Newtonsoft.Json

## Autorzy

- Mateusz Mendyk
- Mateusz Pasternak




