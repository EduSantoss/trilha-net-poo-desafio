using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// * Testes realizados *

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "9999999999", modelo: "Nokia G21", imei: "444444", memoria: 128);
Console.WriteLine($"Número: {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("Clash of clans");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "0000000000", modelo: "Iphone 14 plus", imei: "888888", memoria: 512);
Console.WriteLine($"Número: {iphone.Numero}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Pokémon GO");
