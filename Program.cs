class Program {
    static void Main(){
        BankAccount account1 = new BankAccount("Alyson", 800);

        Console.WriteLine(account1.Balance);
        account1.Deposit(100);
        account1.Withdrawal(50);
        Console.WriteLine(account1.Balance);
    }
}

class BankAccount{
    private string name;
    private decimal balance;

    public decimal Balance{
        get { return balance; }
    }

    public BankAccount(string name, decimal balance){
        if(string.IsNullOrWhiteSpace(name)){
            throw new ArgumentException("Invalid name.", nameof(name));
        }
        this.name = name;
        this.balance = balance;
    }

    public void Deposit(decimal amount){
        if(amount <= 0){
            throw new ArgumentException("Invalid deposit.", nameof(amount));
        }
        balance += amount;
    }

    public void Withdrawal(decimal amount){
        if(amount <= 0){
            throw new ArgumentException("Invalid withdrawal.", nameof(amount));
        }
        balance -= amount;
    }
}