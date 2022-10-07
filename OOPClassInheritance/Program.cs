
using OOPClassInheritance;

Account acc = new Account(1001, "Alex",  0.0);
BusinessAccount bacc = new BusinessAccount(1002, "Mary", 0.0, 500.0);

//Upcasting
Account acc1 = bacc; //O compilador aceita por o businessaccount é um account
Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); //O compilador aceita por o businessaccount é um account

//Sintaxe alternativa de fazer o casting é usar o operador as
Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01); //O compilador aceita por o savingsaccount é um account

//Downcasting é uma operação insegura e precisa ser testado
//BusinessAccount acc4 = (BusinessAccount)acc2; //precisa ser feito um casting do tipo BusinessAccount
//Sintaxe alternativa de fazer o casting é usar o operador as
BusinessAccount acc4 = acc2 as BusinessAccount;
acc4.Loan(100);

//BusinessAccount acc5 = (BusinessAccount)acc3;
// embora o compilador não apresente erro será gerando em tempo de execução pq o acc3 é do tipo SavingAccount e o casting só funciona se fosse Account pq o BusinessAcount é um Acount

//como testar usando is(é)
if(acc3 is BusinessAccount)
{
    BusinessAccount acc5 = (BusinessAccount)acc3;
    acc5.Loan(200.0);
    Console.WriteLine("Loan!");
}

if(acc3 is SavingsAccount)
{
    SavingsAccount acc5 = (SavingsAccount)acc3;
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
}

//testando methodo virtual and override
Account acc6 = new Account(1001, "Alex", 500.0);
Account acc7 = new SavingsAccount(1002, "Anna", 500.0, 0.01);//Upcasting

acc6.WithDraw(10.0);
acc7.WithDraw(10.0);

Console.WriteLine(acc6.Balance);
Console.WriteLine(acc7.Balance);




