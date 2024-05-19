using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "num sei", "piorou", 20);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");
Console.WriteLine(nokia.Numero);

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("098765", "15 pro max", "piorou2", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Basicos");
