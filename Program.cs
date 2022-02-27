string[] massivOfString = { "Сколько", "дурака", "не", "мотивируй", ",", "максимум", "чего", "вы", "добьетесь", "-", "это", "мотивированный", "дурак" };


string[] CreateMassivOfStrings(string[] massivOfFirstText)
{

    string[] massivOfThreeOrLessLetters = new string[] { };
    int j = 0;
    for (int i = 0; i < massivOfFirstText.Length; i++)
    {
        if (massivOfFirstText[i].Length <= 3)
        {

            Array.Resize(ref massivOfThreeOrLessLetters, massivOfThreeOrLessLetters.Length + 1);
            massivOfThreeOrLessLetters[massivOfThreeOrLessLetters.Length - 1] = massivOfFirstText[i];

        }

    }
    return massivOfThreeOrLessLetters;
}


void PrintMassiv(string[] massivOfSomeText)
{
    for (int i = 0; i < massivOfSomeText.Length; i++)
    {
        Console.WriteLine(massivOfSomeText[i]);
    }
}

Console.WriteLine ("Первоначальный массив:");
PrintMassiv(massivOfString);
Console.WriteLine();
string[] massivOfLessOrThreeLetters = CreateMassivOfStrings(massivOfString);
Console.WriteLine ("Массив со словами, состоящими не более, чем из трех букв:");
PrintMassiv(massivOfLessOrThreeLetters);
