using projeto_dio.Models;

Console.WriteLine("\n");
Console.WriteLine("---------------------------------------");
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "(81) 99155-4914" , modelo: "N85", imei: "101096", memoria: 128);
nokia.Apresentar();
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("---------------------------------------");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "(81) 99155-5013" , modelo: "iPHONE 11", imei: "101096", memoria: 512);
iphone.Apresentar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
Console.WriteLine("---------------------------------------");
Console.WriteLine("\n");