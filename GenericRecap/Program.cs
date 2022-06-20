// See https://aka.ms/new-console-template for more information
using GenericRecap;

MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
dictionary.Add(1, "Mert");
dictionary.Add(2, "Ceren");
dictionary.Add(3, "Yunus");
dictionary.Add(4, "Sude");
dictionary.List();
dictionary.Delete(1);
dictionary.List();
dictionary.Update(2, "Elif");
dictionary.List();
Console.WriteLine(dictionary.Find(2));
Console.WriteLine(dictionary.Count);