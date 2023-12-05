using DesafioPOO.Models;




Nokia nokia = new Nokia("97757-0831", "N9", "312312312", 5, DateTime.Now.AddYears(-10));
nokia.RetornarInformacaoSmartphone();
Console.WriteLine();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n--------------------------------------------------------------------\n");

Iphone iphone = new Iphone("97757-0122", "Iphone X", "3112212312", 10, DateTime.Now.AddYears(-3));
iphone.RetornarInformacaoSmartphone();
Console.WriteLine();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

