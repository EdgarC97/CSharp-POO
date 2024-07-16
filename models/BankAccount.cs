using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class BankAccount//● Crea una clase CuentaBancaria con propiedades Titular y Saldo.
    {
        public string? Holder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string? holder, double balance)
        {
            Holder = holder;
            Balance = balance;
        }

        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;
            Console.WriteLine($"Depósito de {depositAmount:C} realizado. Nuevo saldo: {Balance:C}");
        }

        public void WithDraw(double withdrawAmount)
        {
            Balance -= withdrawAmount;
            Console.WriteLine($"Retiro de {withdrawAmount:C} realizado. Nuevo saldo: {Balance:C}");
        }
    }
}