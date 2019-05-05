var cookiesAmmount = 0;
var cookiesIncome = 0;
var expensivness = 1.21; // Jak szybko będzie się zwiększać koszt budynków

var cookiesPerClick = 1;
var cookiesPerGran = 5;
var cookiesPerFarm = 20;
var cookiesPerMine = 40;
var cookiesPerFactory = 90;

var grandmas = 0; // Ile budynków danego typu posiada gracz
var farms = 0;
var mines = 0;
var factories = 0;

var granBaseCost = 100; // Podstawowy koszt budynku
var granCurrentCost = 100; // Aktualny koszt budynku który ponosi gracz
var farmBaseCost = 1000;
var farmCurrentCost = 1000;
var mineBaseCost = 5000;
var mineCurrentCost = 5000;
var factBaseCost = 15000;
var factCurrentCost = 15000;

// Wyliczanie przychodu i dodawanie go do liczby ciastek
function CalculateIncome() {
    cookiesIncome = grandmas * cookiesPerGran + farms * cookiesPerFarm +
        mines * cookiesPerMine + factories * cookiesPerFactory;
    cookiesAmmount += cookiesIncome;
}

// Ponieważ "Info" to kolejna strona, aby przekazać odpowiednie dane, musiałem dodać je
// do magazynu sesji. Dzięki temu strona "Info" ma dostęp do aktualnych danych
function SetStorage() {
    sessionStorage.setItem('grandmas', grandmas);
    sessionStorage.setItem('cookiesPerGran', cookiesPerGran);

    sessionStorage.setItem('farms', farms);
    sessionStorage.setItem('cookiesPerFarm', cookiesPerFarm);

    sessionStorage.setItem('mines', mines);
    sessionStorage.setItem('cookiesPerMine', cookiesPerMine);

    sessionStorage.setItem('factories', factories);
    sessionStorage.setItem('cookiesPerFactory', cookiesPerFactory);
}

// Odświeża liczbę ciastek
function UpdateCookiesAmmount() {
    document.getElementById('cookiesAmmountText').innerText = cookiesAmmount;
    document.getElementById('cookiesIncome').innerText = cookiesIncome;
    SetStorage();
}

// Wciśnięcie myszy nad ciastkiem
function CookieClick() {
    cookiesAmmount += cookiesPerClick;
    // Zmian ciastka na mniejsze
    document.getElementById('bigCookie').src = "images/cookieSmall.png";
}

// Puszczenie myszy nad ciastkiem
function CookieRelese() {
    // Zmiana ciastka na większe
    document.getElementById('bigCookie').src = "images/cookie.png";
}

// Kupowanie Babci
function BuyGran() {
    if (cookiesAmmount >= granCurrentCost) {
        cookiesAmmount -= granCurrentCost;
        grandmas++;
        granCurrentCost = Math.floor(granBaseCost * Math.pow(expensivness, grandmas)); // Obliczanie kosztu kolejnej babci
        document.getElementById("grans").innerText = "Ilość: " + grandmas + " || Koszt: " + granCurrentCost; // Wyświetlanie kosztów i ilości
    } else
        alert("Nie stać cię");
}
 // Kupowanie farmy
function BuyFarm() {
    if (cookiesAmmount >= farmCurrentCost) {
        cookiesAmmount -= farmCurrentCost;
        farms++;
        farmCurrentCost = Math.floor(farmBaseCost * Math.pow(expensivness, farms));
        document.getElementById("farms").innerText = "Ilość: " + farms + " || Koszt: " + farmCurrentCost;
    } else
        alert("Nie stać cię");
}

// Kupowanie kopalni
function BuyMine() {
    if (cookiesAmmount >= mineCurrentCost) {
        cookiesAmmount -= mineCurrentCost;
        mines++;
        mineCurrentCost = Math.floor(mineBaseCost * Math.pow(expensivness, mines));
        document.getElementById("mines").innerText = "Ilość: " + mines + " || Koszt: " + mineCurrentCost;
    } else
        alert("Nie stać cię");
}

// Kupowanie fabryki
function BuyFactory() {
    if (cookiesAmmount >= factCurrentCost) {
        cookiesAmmount -= factCurrentCost;
        factories++;
        factCurrentCost = Math.floor(factBaseCost * Math.pow(expensivness, factories));
        document.getElementById("factories").innerText = "Ilość: " + factories + " || Koszt: " + factCurrentCost;
    } else
        alert("Nie stać cię");
}

// Wyświetlanie informacji na stronie "Info"
function ShowInfo() {
    document.getElementById("infoText").innerText = "Ilość produkowanych ciasteczek\r\nBabcie: " + sessionStorage.getItem('grandmas') * // Uzyskiwanie zapisanych w sesji danych
        sessionStorage.getItem('cookiesPerGran') + "\r\nFarmy: " + sessionStorage.getItem('farms') * sessionStorage.getItem('cookiesPerFarm') +
        "\r\nKopalnie: " + sessionStorage.getItem('mines') * sessionStorage.getItem('cookiesPerMine') + "\r\nFabryki: " +
        sessionStorage.getItem('factories') * sessionStorage.getItem('cookiesPerFactory') +
        "\r\n\r\n\r\nProdukcja ciasteczek na jeden budynek:\r\nBabcia: " + cookiesPerGran + "\r\nFarma: " + cookiesPerFarm +
        "\r\nKopalnia: " + cookiesPerMine + "\r\nFabryka: " + cookiesPerFactory;
}