//ilk Dizi oluşturluyor...
int[] numbers = new int[10];

//Dizi elemanları rastgele sayı ile dolduruluyor..
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
    numbers[i] = random.Next(1,100);

//Dizi ekrana yazdırılıyor..
foreach (int i in numbers)
{
    Console.Write(i + " ");
}

// 11. eleman eklenmesi için yeni bir dizi oluşturuluyor.
int[] numbers1 = new int[11];

//Yeni diziye ilk dizinin eleman değerleri atılıyor..
for (int i = 0; i < numbers.Length; i++)
{
    numbers1[i] = numbers[i];
}

Console.WriteLine("\n Bir sayı giriniz");
numbers1[10]=int.Parse(Console.ReadLine());


//Dizi büyükten küçüğe yazdırılıyor.

Console.WriteLine("\n Dizi büyükten küçüğe yazdırılıyor");

int largestNumber = 0;

for (int i = 0; i < numbers1.Length; i++)
{
    for (int j = i; j < numbers1.Length; j++)
    {
        if (numbers1[j] > numbers1[i])
        {
            largestNumber = numbers1[j];
            numbers1[j] = numbers1[i];
            numbers1[i] = largestNumber;
        }
    }
    Console.Write(numbers1[i] + " ");
}


/*
//Büyükten küçüğe yazdırmak için  aşağıdaki Array metotlar da kullanılabilir

Array.Sort(numbers1);
Array.Reverse(numbers1);

foreach (int i in numbers1)
{
    Console.Write(i + " ");
}
*/
