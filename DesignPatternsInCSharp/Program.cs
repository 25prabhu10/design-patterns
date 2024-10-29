using DesignPatternsInCSharp.src.OopPrinciples.Encapsulation;

#region OopPrinciples
#region Encapsulation
// Let us consider a bank account class that has a balance property.
// The BadBankAccount class has a public property Balance that can be accessed and modified from outside the class.
var badBankAccount = new BadBankAccount()
{
    Balance = 100
};

// The user can set the balance to any value, even a negative value.
badBankAccount.Balance = -100;

// This is a violation of bank account rules.
// The balance should not be set to a negative value.
// We can add a validation here to prevent this, but it is better to encapsulate the balance property.
// This way, the balance can only be modified through methods in the class and it can be validated before setting it.
var bankAccount = new BankAccount(100);

// The balance can only be modified through the Deposit and Withdraw methods.
bankAccount.Deposit(100);
bankAccount.Withdraw(50);

// The balance can be retrieved using the GetBalance method.
Console.WriteLine($"Balance: {bankAccount.GetBalance()}");

// The balance cannot be set to a negative value.
bankAccount.Deposit(-100); // This will throw an ArgumentException
bankAccount.Withdraw(200); // This will throw an InvalidOperationException
#endregion Encapsulation

#region Abstraction
// Let us consider an email service class that has methods to send an email, connect to the email server, authenticate, and disconnect.
// The BadEmailService class has all these methods in a single class.
var badEmailService = new BadEmailService();
badEmailService.Connect();
badEmailService.Authenticate();
badEmailService.SendEmail();
badEmailService.Disconnect();

// This means that the user has to know the internal details of the email service class to use it.
// To send an email, the user has to call the Connect, Authenticate, SendEmail, and Disconnect methods in the correct order.
// This is not ideal as it exposes the internal details of the email service class to the user.
// We can improve this by using abstraction.
// We can simplify the email service class by handling the internal details within the class and exposing only the SendEmail method to the user.
var emailService = new EmailService();
emailService.SendEmail();
#endregion Abstraction
#endregion OopPrinciples