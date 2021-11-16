
using System;

//conversione esplicita
int g = 1000;
byte h = (byte)g;

Console.WriteLine(h); //output: 232 -> [resto di 1000/256]

int i = 100;
long l = i; //Conversione implicita 

//Esempio con enum

enum GenderEnum
{ Male,
 Female,
 NotDeclared]}
Console.WriteLine(GenderEnum.Male); //Output: Male

GenderEnum male = GenderEnum.Male;
Console.WriteLine((int)male);

//Object
object obj = new object(); //new -> punta a una nuova istanza
object obj2 = obj; //si riferisce alla stessa istana
object obj3 = null;
object obj4; //se non specifico, diventa null

// se voglio fare il boxing ovvero value tyoe in object
int m = 123;
object obj5 = m; //boxing, molto costoso è da evitare

//Type inference 
var n = 3;
// Visual studio decide lui che variabile sarà 3, usando la parola var
var o= 3f //float
