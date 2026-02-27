using Arrays.Logic;
using System.ComponentModel.Design;

try
{
    Console.WriteLine("ARRAY");

    int option;
    MyArray myArray = new(10);
    myArray.Fill();
    do
    {
        option = Menu();
        switch (option)
        {
            case 1:
                Console.WriteLine("Ingrese numero de elementos: ");
                var nString = Console.ReadLine();
                int n = 10;
                int.TryParse(nString, out n);
                myArray = new(n);
                myArray.Fill();
                break;

            case 2:
                Console.WriteLine(myArray);
                break;

            case 3:
                Console.WriteLine(myArray.GetOdds());
                break;

            case 4:
                Console.WriteLine(myArray.GetPrimes());
                break;

            case 5:
                Console.WriteLine(myArray.GetNonRepeated());
                break;

            case 6:
                Console.WriteLine(myArray.GetMostRepeat());
                break;

            default:
                Console.WriteLine("no jodas!!!!");
                break;
        }
    } while (option != 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int Menu()
{
    Console.WriteLine("1. Definir tamaño de arreglo");
    Console.WriteLine("2. Mostrar arreglo");
    Console.WriteLine("3. Mostrar numeros Pares");
    Console.WriteLine("4. Mostrar numeros primos");
    Console.WriteLine("5. Mostrar numeros que no se repiten");
    Console.WriteLine("6. Mostrar numeros que mas se repiten");
    Console.WriteLine("0. salir");
    bool isValid = false;
    int option = 0;

    do
    {
        Console.Write("Digite su opcion: ");
        var optionstring = Console.ReadLine();
        if (!int.TryParse(optionstring, out option))
        {
            Console.WriteLine("Opcion incorrecta, debe ingresar solo numeros de 0 a 5");
            isValid = false;
        }
        else
        {
            isValid = true;
        }
    } while (!isValid || option < 0 || option > 6);

    return option;
}
//array.Fill(1, 6);

//Console.WriteLine("Arreglo Desordenado:");
//Console.WriteLine(array);

//array.Sort(descending: false);
//Console.WriteLine("Arreglo Odenado Ascendente:");
//Console.WriteLine(array);

//array.Sort(descending: true);
//Console.WriteLine("Arreglo Odenado Descendente:");
//Console.WriteLine(array);

//hacer un metodo que devuelva los numeros primos
// hacer metodo que devuelva  los que no se repiten
//hacer metodo que devuelva los que mas se repiten