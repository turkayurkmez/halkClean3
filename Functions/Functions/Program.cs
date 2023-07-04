const string Up = "Yukarı";
const string Down = "Aşağı";
const string Equal = "Bildiniz";
// See https://aka.ms/new-console-template for more information
/*
 * Bir oyun Pseudo  kodu
 * 1. 1 - 100 arasında rasgele sayı seç.
 * 2. Kullanıcıdan tahmin iste
 * 3. Tahmin ile tututulan sayıyı karşılaştır.
 *     - tahmin > tutulan : "Aşağı"
 *     - tahmin < tutulan : "Yukarı"
 *     - tahmin = tutulan : "Bildin"
 * 4. Bilene dek devam et.
 *
 */
var target = getRandomNumber(1, 100);
var output = string.Empty;
do
{

    var suggest = getSuggestedNumberFromUser();
    output = compareSuggestedAndTarget(target, suggest);
    Console.WriteLine(output);

} while (output != Equal);

Console.WriteLine("Hello, World!");

int getRandomNumber(int min, int max)
{
    //One  job at a time
    return new Random().Next(min, max);
}





int getSuggestedNumberFromUser()
{
    Console.WriteLine("Sayıyı tahmin edin:");
    return int.Parse(Console.ReadLine());
}

string compareSuggestedAndTarget(int target, int suggest)
{
    if (suggest > target)
    {
        return Down;
    }
    else if (suggest < target) { return Up; }
    else
    {
        return Equal;
    }
}





