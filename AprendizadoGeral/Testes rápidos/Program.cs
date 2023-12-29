

List<string> list = new List<string>();
list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");

foreach(string ob in list)
{
    Console.WriteLine(ob);
}
list.Insert(2, "Marco");
Console.WriteLine("-----------------------------");
foreach (string ob in list)
{
    Console.WriteLine(ob);
}
Console.WriteLine("-----------------------------");

Console.WriteLine("List count " + list.Count);
Console.WriteLine("-----------------------------");

string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("Fist 'A': " + s1);
string s2 = list.Last(x => x[0] == 'A');
Console.WriteLine("Last 'A': " + s2);
Console.WriteLine("-----------------------------");

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("Fist position 'A': " + pos1);
int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Fist position 'A': " + pos2);
Console.WriteLine("-----------------------------");

List<string> list2 = list.FindAll(x => x.Length == 5);
Console.WriteLine("Nova lista com strings de tamanho == 5");
foreach(string obj in list2)
{
    Console.WriteLine(obj);
}
Console.WriteLine("-----------------------------");
list.Remove("Alex");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}
Console.WriteLine("-----------------------------");
list.RemoveAll(x => x[0] == 'M');
foreach (string obj in list)
{
    Console.WriteLine(obj);
}
Console.WriteLine("-----------------------------");
list.RemoveAt(list.Count-1/*Pode ser simplismente o numero"2 ou 1 ou 7"*/);
foreach (string obj in list)
{
    Console.WriteLine(obj);
}

list.RemoveRange(2, 2);

