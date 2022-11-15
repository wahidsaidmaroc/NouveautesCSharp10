string nom = "Said WAHID";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Bonjour, {0}! aujourd'hui  est {1}, et {2:HH:mm} .", nom, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Bonjour, {nom}! aujourd'hui  est{date.DayOfWeek}, et {date:HH:mm} ");
// Both calls produce the same output that is similar to:



int X = 2;
int Y = 3;

var pointMessage = $"The point {X}, {Y} is {Math.Sqrt(X * X + Y * Y)} from the origin";
Console.WriteLine(pointMessage);
// output:  The point "2, 3" is 3.605551275463989 from the origin.



//Conversions implicites et comment spécifier IFormatProvider l’implémentation
double speedOfLight = 299792.458;
FormattableString message = $"The speed of light is {speedOfLight:N3} km/s.";

System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("nl-NL");
string messageInCurrentCulture = message.ToString();

var specificCulture = System.Globalization.CultureInfo.GetCultureInfo("en-IN");
string messageInSpecificCulture = message.ToString(specificCulture);

string messageInInvariantCulture = FormattableString.Invariant(message);

Console.WriteLine($"{System.Globalization.CultureInfo.CurrentCulture,-10} {messageInCurrentCulture}");
Console.WriteLine($"{specificCulture,-10} {messageInSpecificCulture}");
Console.WriteLine($"{"Invariant",-10} {messageInInvariantCulture}");
// Expected output is:
// nl-NL      The speed of light is 299.792,458 km/s.
// en-IN      The speed of light is 2,99,792.458 km/s.
// Invariant  The speed of light is 299,792.458 km/s.