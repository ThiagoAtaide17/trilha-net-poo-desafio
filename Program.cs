using DesafioPOO.Models;

// TODO: IMPLEMENTADO!!

Console.WriteLine("Smartphone Nokia:");
Nokia n1 = new Nokia("25","G10","5254",250);
n1.Ligar();
n1.InstalarAplicativo("Watsapp");

Console.WriteLine("Smartphone Iphone:");
Iphone i1 =  new Iphone("35","M10","3726",370);
i1.ReceberLigacao();
i1.InstalarAplicativo("Telegram");

