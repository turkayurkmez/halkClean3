// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

//1. Kullandığınız isimler ANLAMLI olsun.
int x = 0;
int i = 0;
int d = 150; //Buradaki d, kullanıcının üye olmasından bu güne geçen gün sayısıdır.
int daysSinceUserCreated = 150;
//int musterininKaydindanBuYanaGecenGunSayisi = 150;

//2. Kısaltmalardan kaçının!
var hp = 15;

//hp marka bilgisayar
//healthPoint 
//horsePower
//Hit Point 
var healthyPoint = 100;
//3. Bir koleksiyonu tanımlamak için gündelik hayatta kullanulan çoğul eklerini kullanın.
var mailList = new List<string>();
var emailAddresses = new List<string>();
//4. Bir veritipini değişken adında kullanma:
var boolIsOk = false;
var isCorrect = false;
var homeAddress = string.Empty;

//Komplex tiplerde, instance sınıfın adını içermeli

DataTable ordersDataTable = new DataTable();
//textboxUserName
Random randomNumberGenerator = new Random();

//5. Karakter benzeşiminden kaçının!
//var o = 0;
//var l = 1;

//if (o == l)
//{
//    o = 1;
//}

List<int[]> cells = new List<int[]>();

List<int[]> getFlaggedCellsOnGameBoard()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in cells)
    {
        if (cell[0] == CellStateConstant.FlaggedCell)
        {
            flaggedCells.Add(cell);
        }
    }
    return flaggedCells;
}

public enum CellState
{
    Empty = 0,
    Flagged = 4
}

public class CellStateConstant
{
    public const int EmptyCell = 0;
    public const int FlaggedCell = 4;
}


