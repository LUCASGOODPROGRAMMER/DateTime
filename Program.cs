using BibliotecaData;
Ferramentas.Menu();
string escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.WriteLine("EX(dia/mês/ano");
    Console.Write("Informe a data: ");
    string primeiraData = Console.ReadLine();

    Console.Write("Informe os dias a serem somados: ");
    int dias = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Ferramentas.SomarDias(primeiraData, dias).ToString("d"));
}
else if (escolha == "2")
{
    Console.WriteLine("EX(dia/mês/ano hora:minuto:segundo)");
    Console.Write("Informe a primeira data: ");
    string primeiraData = Console.ReadLine();

    Console.Write("Informe a segunda data: ");
    string segundaData = Console.ReadLine();

    Console.WriteLine("Dias de diferença: " + Ferramentas.DiferencaDias(primeiraData,segundaData).TotalDays);
    Console.WriteLine("Meses de diferença: " + Ferramentas.DiferencaMeses(primeiraData,segundaData));
    Console.WriteLine("Anos de diferenca: " + Ferramentas.DiferencaAnos(primeiraData, segundaData));


}



