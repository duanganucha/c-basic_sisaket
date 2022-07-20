


void PrintName(string name, int age)
{

    Console.WriteLine("Name " + name + " age " + age); ;

}

PrintName("waiwai", 20);




string PrintName2(string name, int age)
{

    string person = "xName " + name + " age " + age;

    return person;

}

string p = PrintName2("waiwai", 20);

Console.WriteLine(p);








void Cal(int age1, int age2)
{

    int age = age1 + age2;
    Console.WriteLine("sum age : " + age);
}

Cal(80, 40);

Cal(20, 50);













string PrintName3(string name, int age)
{

    string person = "xName " + name + " age " + age;

    return person;

}

string name3 = PrintName3(age: 40, name: "waiwai3");


Console.WriteLine(name3);
