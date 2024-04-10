using BibliotecaDate;
Ferramentas.Menu();
string escolha = Console.ReadLine();
Console.WriteLine("EX(dia/mês/ano-hora:minuto:segundo)");
if (escolha == "1")
{
    Console.Write("Informe a data: ");
    string data = Console.ReadLine();

    Console.Write("Informe os dias a serem somados: ");
    int dias = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Ferramentas.SomarDias(data, dias).ToString("d"));
}
else if (escolha == "2")
{
    Console.Write("Informe a primeira data: ");
    string primeiraData = Console.ReadLine();

    Console.Write("Informe a segunda data: ");
    string segundaData = Console.ReadLine();

    Console.WriteLine(Ferramentas.DiferencaDias(primeiraData, segundaData));
}


