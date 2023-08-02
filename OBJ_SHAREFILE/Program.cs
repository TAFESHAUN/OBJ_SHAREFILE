using OBJ_SHAREFILE;

Car ford = new Car(2000,"Mustang", 205);
Car holden = new Car(2001, "Comadore", 200);
Car opel = new Car(2005, "Astra", 180);


ford.CarSound();
holden.CarSound();
opel.CarSound();

int fordOutput = ford.ExpoCarMake();

Console.WriteLine($"The current Car Make is {fordOutput}");
int output = ford.ChangeCarMake(1969);
//Console.WriteLine($"The Updated Car Make is {ford.CarMake}");

Console.WriteLine("Hello my car is: " + ford.ExpoCarModel());
Console.WriteLine("The year updated to: " + output);

Console.WriteLine(opel.ExpoMaxSpeed());

//END
Console.ReadKey();



#region DoingExAsMethods
////Task1
//static void MyTask1()
//{
//    Console.WriteLine("DO SOMETHING LATER");
//}

////Task 2
//static void MyTask2()
//{
//    Console.WriteLine("DO SOMETHING LATER");
//}

//MyTask1();
//MyTask2();
#endregion