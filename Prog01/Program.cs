
void Zadacha()
{
    string[] words = { "hello", "12348", "45", "cat" };
    int length = words.Length;
    string[] wordsNew = new string[length];

    for (int i = 0; i < length; i++)
    {
        if (words[i].Length <= 3)
        {
            wordsNew[i] = words[i];
            Console.Write(wordsNew[i] + " ");
        }
    }
}
Zadacha();