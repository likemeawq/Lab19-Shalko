// Console.WriteLine(CountCharacter("мама", 'м'));
// Console.WriteLine(CountCharacter("", 'м'));

// int CountCharacter(string text, char target)
// {
//     int count = 0;

//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             count++;
//         }
//     }

//     return count;
// }


// Console.WriteLine(CountDigits("A2B3"));

// int CountDigits(string text)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count++;
//         }
//     }

//     return count;
// }

// Console.WriteLine(FindCharacterIndex("banana", 'a'));
// Console.WriteLine(FindCharacterIndex("banana", 'b'));
// Console.WriteLine(FindCharacterIndex("banana", 'z'));
// Console.WriteLine(FindCharacterIndex("", 'a'));

// int FindCharacterIndex(string text, char target)
// {
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             return i;
//         }
//     }

//     return -1;
// }

// string sample = "  кот  ";
// sample = sample.Trim();
// Console.WriteLine($"[{sample}]");

// Console.WriteLine(CountWords("Я изучаю C#"));
// Console.WriteLine(CountWords("  кот  дом  "));
// Console.WriteLine(CountWords(""));
// Console.WriteLine(CountWords("   "));

// int CountWords(string text)
// {
//     string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     return words.Length;
// }

Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";

Console.WriteLine();
Console.WriteLine(">>> Анализ строки <<<");
Console.WriteLine();
Console.WriteLine($"Исходная строка: [{text}]");
Console.WriteLine($"Длина: {text.Length}");
Console.WriteLine($"Букв: {CountLetters(text)}");
Console.WriteLine($"Цифр: {CountDigits(text)}");
Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
Console.WriteLine($"Слов: {CountWords(text)}");
Console.WriteLine($"Без пробелов по краям: [{text.Trim()}]");
Console.WriteLine($"Верхний регистр: [{text.ToUpper()}]");
Console.WriteLine($"Замена пробелов: [{text.Replace(' ', '_')}]");

Console.Write("Введите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine());

int index = FindCharacterIndex(text, target);
if (index == -1)
{
    Console.WriteLine("Символ не найден");
}
else
{
    Console.WriteLine($"Первый индекс: {index}");
}

int CountCharacter(string text, char target)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (symbol == target)
        {
            count++;
        }
    }

    return count;
}

int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }

    return count;
}

int CountLetters(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            count++;
        }
    }

    return count;
}

int FindCharacterIndex(string text, char target)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            return i;
        }
    }

    return -1;
}

int CountWords(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}