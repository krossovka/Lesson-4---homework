using System.Collections.Generic;

Dictionary<string, string> translator = new Dictionary<string, string>();
translator.Add("apple", "яблоко");
translator.Add("banana", "банан");
translator.Add("orange", "апельсин");
translator.Add("pineapple", "ананас");
translator.Add("kiwi", "киви");
translator.Add("grapefruit", "грейпфрут");
translator.Add("mandarin", "мандарин");
translator.Add("watermelon", "арбуз");
translator.Add("plum", "слива");
translator.Add("cherry", "вишня");

foreach (KeyValuePair<string, string> item in translator)
{
    translator[item.Key] = item.Value;
    Console.WriteLine(item.Key);
}

Console.WriteLine("\n" + "Введите слово из списка");
string word = Console.ReadLine();
if (translator.ContainsKey(word))
{
    Console.WriteLine("Перевод на русский - " + translator[word]);
}
else
{
    Console.WriteLine("Слово не было найдено");
}
Console.ReadKey();