using DesafioPOO.Models;

Console.WriteLine("Nokia:\n");
Smartphone nokia = new Nokia(numero:"123456", modelo: "tijolão", imei: "11111111", memoria:512);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Clash Royale");

Console.WriteLine("\nIphone:\n");
Smartphone iphone = new Iphone(numero:"654321", modelo: "Iphone 14", imei: "22222222", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");