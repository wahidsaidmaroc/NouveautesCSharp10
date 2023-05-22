using DeconstructionClass;








var obj = new Client();
obj.idClient = 1;
obj.nomClient = "Said";

//C# 9
//Erreur 
var id = 3;

(id, string nom) = obj;

//C# 10
var idNew = 3;

(idNew, string nomNew) = obj;

Console.WriteLine(id);
Console.WriteLine(nom);