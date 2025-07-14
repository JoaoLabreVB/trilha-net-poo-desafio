using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("12345", "Imei123", 128);
Console.WriteLine($"Smartphone Nokia: \n ");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");

Console.WriteLine($"Smartphone Iphone: \n ");
Smartphone iphone = new Iphone("67891", "Imei987", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
