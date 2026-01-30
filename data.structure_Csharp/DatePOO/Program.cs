using Class_library;

var answer = String.Empty;
var options = new List<string> { "s", "n" };
do
{
    try
    {
        Console.Write("Ingrese un año :");
        int y = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese un mes :");
        int m = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese un dia :");
        int d = int.Parse(Console.ReadLine()!);

        var date1 = new Date();
        var date2 = new Date(y, m, d);

        Console.WriteLine(date1);
        Console.WriteLine(date2);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar S[si], N[no] ? : ", options);
    }
    while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));