using DesafioPOO.Models;

Console.WriteLine("Nokia:");

Nokia cel1 = new Nokia(numero: "15921556578",modelo:"Modelo teste",imei:"8484asda484", memoria: 456);
cel1.Ligar();
cel1.ReceberLigacao();
cel1.InstalarAplicativo("pou");

Console.WriteLine("Iphone:");
Iphone cel2 = new Iphone(numero: "11935786321",modelo:"Modelo caro",imei:"5474sahghda256", memoria: 200);
cel2.Ligar();
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Subway surf");