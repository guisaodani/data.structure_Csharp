using Arrays.Logic;

Console.WriteLine("ARRAY");

MyArray array = new(20);
array.Fill(1, 10);

Console.WriteLine("Arreglo Desordenado:");
Console.WriteLine(array);

array.Sort();
Console.WriteLine("Arreglo Odenado:");
Console.WriteLine(array);