using pzlab004;

//var temp = new Person("Bartek", "Mikołajczuk", 22, new List<Car>());
//var temp2 = new Person("Test", "Testnazwisko", 23, new List<Car>());
//var temp4 = new Person("Test2", "Testnazwisko2", 21, new List<Car>());
//var tempcar = new Car();
//tempcar.Mark = "Audi";
//tempcar.Price = 1000;
//temp.Cars.Add(tempcar);
//var tempcar2 = new Car();
//tempcar2.Mark = "BMW";
//tempcar2.Price = 11000;
//temp.Cars.Add(tempcar2);
//var tempcar3 = new Car();
//tempcar3.Mark = "Seat";
//tempcar3.Price = 123000;
//temp.Cars.Add(tempcar3);
//var tempcar1 = new Car();
//tempcar1.Mark = "Audi";
//tempcar1.Price = 10200;
//temp2.Cars.Add(tempcar1);
//var tempcar22 = new Car();
//tempcar22.Mark = "BMW";
//tempcar22.Price = 31000;
//temp2.Cars.Add(tempcar22);
//var tempcar33 = new Car();
//tempcar33.Mark = "Seat";
//tempcar33.Price = 23000;
//temp2.Cars.Add(tempcar33);
//var tempcar111 = new Car();
//tempcar111.Mark = "mercedes";
//tempcar111.Price = 102300;
//temp4.Cars.Add(tempcar111);
//var tempcar222 = new Car();
//tempcar222.Mark = "FSO";
//tempcar222.Price = 100;
//temp4.Cars.Add(tempcar222);
//var tempcar333 = new Car();
//tempcar333.Mark = "Seat";
//tempcar333.Price = 193000;
//temp4.Cars.Add(tempcar333);

//foreach (var item in temp)
//{
//    Console.WriteLine(item);
//}

//List<Person> list = new List<Person>();
//list.Add(temp);
//list.Add(temp2);
//list.Add(temp4);

//list.ForEach(x => Console.WriteLine(x));
//list.Sort();
//list.ForEach(x => Console.WriteLine(x));

//Console.WriteLine(temp);
//Console.WriteLine(temp2);

//GenericMethod.Swap(ref temp, ref temp2);

//Console.WriteLine(temp);
//Console.WriteLine(temp2);

//GenericMethod.DescObject(ref temp, ref temp2);

//Console.WriteLine(temp);
//Console.WriteLine(temp2);

//var temp3 = GenericMethod.CreateNewObject<Person>();

//Console.Write(GenericMethod.Compare(temp, temp2));

//GenericMethod.SortParameters(temp, temp2, temp4).ForEach(x => Console.WriteLine(x));

List<GenericClass<int, int, string, string>> listgen = new List<GenericClass<int, int, string, string>>();
GenericClass<int, int, string, string> gtemp1 = new GenericClass<int, int, string, string>(1,10,"temp1","temp1");
GenericClass<int, int, string, string> gtemp2 = new GenericClass<int, int, string, string>(2, 20, "temp2", "temp2");
GenericClass<int, int, string, string> gtemp3 = new GenericClass<int, int, string, string>(3, 30, "temp3", "temp3");
GenericClass<int, int, string, string> gtemp4 = new GenericClass<int, int, string, string>(4, 40, "temp4", "temp4");
GenericClass<int, int, string, string> gtemp5 = new GenericClass<int, int, string, string>(6, 40, "temp5", "temp5");
GenericClass<int, int, string, string> gtemp6 = new GenericClass<int, int, string, string>(7, 40, "temp6", "temp6");
GenericClass<int, int, string, string> gtemp7 = new GenericClass<int, int, string, string>(8, 40, "temp7", "temp7");
listgen.Add(gtemp1);
listgen.Add(gtemp5);
listgen.Add(gtemp7);
listgen.Add(gtemp4);
listgen.Add(gtemp2);
listgen.Add(gtemp6);
listgen.Add(gtemp3);

foreach (var item in listgen)
{
    Console.WriteLine(item);
}

listgen.Sort();
Console.WriteLine("---------------------------------------");

foreach (var item in listgen)
{
    Console.WriteLine(item);
}