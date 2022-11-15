using RecordTypeValeur.ApresRecord;
using RecordTypeValeur.Avant;
//Avant record
var cl1 = new Client { dateCreation = DateTime.UtcNow, idClient = 1, nomClient = "oumdin" };
var cl2 = new Client { dateCreation = DateTime.UtcNow, idClient = 1, nomClient = "oumdin" };
cl1.Equals(cl2); // false


// Apres record
var clRecord1 = new MyRecord { dateCreation = DateTime.UtcNow, idClient = 1, nomClient = "oumdin" };
var clRecord2 = clRecord1 with { idClient = 3 };
var clRecord3 = clRecord1;

clRecord1.Equals(clRecord2); // true



