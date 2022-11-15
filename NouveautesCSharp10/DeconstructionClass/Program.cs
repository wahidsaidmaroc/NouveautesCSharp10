using DeconstructionClass;

var obj = new Client();
obj.idClient = 1;
obj.nomClient = "Said";

var id = 3;

(id, string nom) = obj;

Console.WriteLine(id);
Console.WriteLine(nom);