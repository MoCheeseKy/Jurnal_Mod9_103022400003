// See https://aka.ms/new-console-template for more information

using Modul9_103022400003;

class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig bankTransferConfig = new BankTransferConfig();
        double amount;

        if (bankTransferConfig.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Transfer Fee: " +
                (amount <= bankTransferConfig.config.transfer.treshold
                    ? bankTransferConfig.config.transfer.low_fee
                    : bankTransferConfig.config.transfer.high_fee)
                );
            Console.WriteLine("Amount: " + (amount + (amount <= bankTransferConfig.config.transfer.treshold
                     ? bankTransferConfig.config.transfer.low_fee
                     : bankTransferConfig.config.transfer.high_fee)
                 ));
            Console.WriteLine("Select transfer method: ");
            bankTransferConfig.config.methods.ForEach(method => Console.WriteLine(method));
        }
        else if (bankTransferConfig.config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di transfer:");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Biaya Transfer: " +
                 (amount <= bankTransferConfig.config.transfer.treshold
                     ? bankTransferConfig.config.transfer.low_fee
                     : bankTransferConfig.config.transfer.high_fee)
                 );
            Console.WriteLine("Total Biaya: " + (amount + (amount <= bankTransferConfig.config.transfer.treshold
                     ? bankTransferConfig.config.transfer.low_fee
                     : bankTransferConfig.config.transfer.high_fee)
                 ));
            Console.WriteLine("Pilih metode transfer: ");
            bankTransferConfig.config.methods.ForEach(method => Console.WriteLine(method));
        }
    }
}


