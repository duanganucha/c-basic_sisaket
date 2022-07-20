
int[] myArray = new int[3];

myArray[0] = 20;
myArray[1] = 40;
myArray[2] = 80;


Console.WriteLine("ความยาว = " + myArray.Length);


// [20, 40, 80]


for (int i = 0; i < myArray.Length; i++)
{

    Console.WriteLine(myArray[i]);
}



string strYear = "2022";
int b;

if (int.TryParse(strYear, out b))
{
    int year = b + 543;
    Console.WriteLine("year : " + year);
    // กรณีแปลงสำเร็จจะเก็บตัวแปรไว้ที่ x
}
else
{
    Console.WriteLine("Convert error");
    // กรณีแปลงสำเร็จ
}










