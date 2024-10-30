// using DesignPatternsInCSharp.src.OopPrinciples.Encapsulation;
// using DesignPatternsInCSharp.src.OopPrinciples.Abstraction;
// using DesignPatternsInCSharp.src.OopPrinciples.Inheritance;
// using DesignPatternsInCSharp.src.CSharpConcepts;

// #region OopPrinciples
// #region Encapsulation
// // Let us consider a bank account class that has a balance property.
// // The BadBankAccount class has a public property Balance that can be accessed and modified from outside the class.
// var badBankAccount = new BadBankAccount()
// {
//     Balance = 100
// };

// // The user can set the balance to any value, even a negative value.
// badBankAccount.Balance = -100;

// // This is a violation of bank account rules.
// // The balance should not be set to a negative value.
// // We can add a validation here to prevent this, but it is better to encapsulate the balance property.
// // This way, the balance can only be modified through methods in the class and it can be validated before setting it.
// var bankAccount = new BankAccount(100);

// // The balance can only be modified through the Deposit and Withdraw methods.
// bankAccount.Deposit(100);
// bankAccount.Withdraw(50);

// // The balance can be retrieved using the GetBalance method.
// Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

// // The balance cannot be set to a negative value.
// bankAccount.Deposit(-100); // This will throw an ArgumentException
// bankAccount.Withdraw(200); // This will throw an InvalidOperationException
// #endregion Encapsulation

// #region Abstraction
// // Let us consider an email service class that has methods to send an email, connect to the email server, authenticate, and disconnect.
// // The BadEmailService class has all these methods in a single class.
// var badEmailService = new BadEmailService();
// badEmailService.Connect();
// badEmailService.Authenticate();
// badEmailService.SendEmail();
// badEmailService.Disconnect();

// // This means that the user has to know the internal details of the email service class to use it.
// // To send an email, the user has to call the Connect, Authenticate, SendEmail, and Disconnect methods in the correct order.
// // This is not ideal as it exposes the internal details of the email service class to the user.
// // We can improve this by using abstraction.
// // We can simplify the email service class by handling the internal details within the class and exposing only the SendEmail method to the user.
// var emailService = new EmailService();
// emailService.SendEmail();
// #endregion Abstraction

// #region Inheritance
// // Let us consider a vehicle class that has common properties and methods for all vehicles.
// // The Vehicle class has properties like Brand, Model, and Year, and methods like Start and Stop.
// var vehicle = new Vehicle()
// {
//     Brand = "Toyota",
//     Model = "Corolla",
//     Year = 2020
// };
// Console.WriteLine($"Vehicle Brand: {vehicle.Brand}");

// // The Car class inherits from the Vehicle class and adds specific properties like NumberOfDoors and NumberOfWheels.
// // Hence, the Car class does not need to define the Brand, Model, and Year properties again. It can reuse them from the Vehicle class.
// var car = new Car()
// {
//     Brand = "Toyota",
//     Model = "Corolla",
//     Year = 2020,
//     NumberOfDoors = 4,
//     NumberOfWheels = 4
// };

// // The properties and methods of the Vehicle class are accessible from the Car class.
// car.Start();
// car.Stop();

// // The Car class can also access its specific properties.
// Console.WriteLine($"Car Brand: {car.Brand}");

// // The Vehicle class can be used to create other types of vehicles like a Bike.
// var bike = new Bike()
// {
//     Brand = "Honda",
//     Model = "CBR",
//     Year = 2020,
//     NumberOfWheels = 2
// };
// Console.WriteLine($"Bike Brand: {bike.Brand}");
// #endregion Inheritance

// #region Polymorphism
// // Let us consider a Vehicle class with a Start method that starts the vehicle.
// // The Car class and Bike class inherit from the Vehicle class and override the Start method to provide their own implementation.
// // This helps in achieving polymorphism where the Start method behaves differently based on the type of vehicle.
// var vehicle1 = new Vehicle();
// var car1 = new Car();
// var bike1 = new Bike();

// vehicle1.Start(); // Output: Vehicle started
// car1.Start(); // Output: Car started
// bike1.Start(); // Output: Bike started

// // Polymorphism allows us to treat objects of different classes in a similar way.
// List<object> oVehicles = [];
// oVehicles.Add(new Car { Brand = "Toyota", Model = "Corolla", Year = 2020, NumberOfDoors = 4, NumberOfWheels = 4 });
// oVehicles.Add(new Bike { Brand = "Honda", Model = "CBR", Year = 2020, NumberOfWheels = 2 });

// // Vehicle inspection
// foreach (var _vehicle in oVehicles)
// {
//     if (_vehicle is Car)
//     {
//         var _car = (Car)_vehicle;
//         _car.Start();
//     }
//     else if (_vehicle is Bike)
//     {
//         var _bike = (Bike)_vehicle;
//         _bike.Start();
//     }
// }

// // The above foreach loop has a lot of boilerplate code to check the type of each vehicle and cast it to the correct type.
// List<Vehicle> vehicles = [];
// vehicles.Add(new Car { Brand = "Toyota", Model = "Corolla", Year = 2020, NumberOfDoors = 4, NumberOfWheels = 4 });
// vehicles.Add(new Bike { Brand = "Honda", Model = "CBR", Year = 2020, NumberOfWheels = 2 });

// // Vehicle inspection
// // The Start method of each vehicle will be called based on the actual type of the vehicle (Car or Bike).
// // Treating different types of vehicles
// foreach (var _vehicle in vehicles)
// {
//     _vehicle.Start();
// }
// #endregion Polymorphism
// #endregion OopPrinciples

// #region CSharpConcepts
// // `virtual` Methods
// VirtualMethod.Run();

// // `abstract` Methods
// AbstractMethod.Run();

// // Method Hiding
// MethodHiding.Run();

// // Null References
// NullReferences.Run();
// #endregion CSharpConcepts