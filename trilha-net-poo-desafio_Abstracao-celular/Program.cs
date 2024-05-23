using DesafioPOO.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO: Realizar os testes com as classes Nokia e Iphone

bool escolherSmartphone = true;

while (escolherSmartphone) {
 
    Console.WriteLine("Digite a sua opção: \n1 - Nokia \n2 - Iphone \n3 - encerrar!");

    switch (Console.ReadLine()) {
        case "1" : 
        Console.Clear();
        Console.WriteLine("Digite o numero do celular: ");
        Smartphone nokia = new Nokia(numero: Console.ReadLine(), modelo: "NK-29", imei: "111111111", memoria: 20);
        nokia.Ligar();
        nokia.InstalarAplicativo("Zoom");
        break;

        case "2" :
        Console.Clear();
        Smartphone iphone = new Nokia(numero: "(11)99999-9999", modelo: "IP-39", imei: "111111111", memoria: 20);
        iphone.Ligar();
        iphone.InstalarAplicativo("Zoom");
        iphone.ReceberLigacao();
        break;

        case "3" :
        escolherSmartphone = false;
        Console.Clear();
        break;

        default:
        Console.Clear();
        Console.WriteLine("Insira um valor válido!");
        Console.ReadLine();
        break;
    }
}