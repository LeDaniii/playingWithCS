int zahl1 = 2;
double zahl2 = zahl1; // Funktioniert

double zahl3 = 2;
float zahl4 = zahl3; // Funktioniert nicht

double zahl5 = 23.214;
float zahl6 = (float)zahl5; // Funktioniert

// Implizite Konvertierung (Automatisch)

float float1 = 123.321F;
double double1 = float1; // Funktioniert weil keine Daten veroren gehen da float mehr als double speichern kann

// Expliziete Konvertierung (Manuell)

double double2 = 213.2;
float float2 = (float)double2; // Cast Operator

//Hilfsklassen zum Konvedrtieren
float2 = Convert.ToSingle(double2);