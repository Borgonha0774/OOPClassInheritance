
using OOPClassInheritance;

Account acc = new Account(1001, "Alex",  0.0);
BusinessAccount bacc = new BusinessAccount(1002, "Mary", 0.0, 500.0);

//Upcasting
Account acc1 = bacc; //O compilador aceita por o businessaccount é um account
Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
