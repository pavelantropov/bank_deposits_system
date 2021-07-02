﻿using System.Collections.ObjectModel;
using BankDepositsSystem.Enum;

namespace BankDepositsSystem.Entity
{
    public class Client
    {
        public string Name { get; }
        public ClientType Type { get; }
        public bool IsHighCreditScore { get; }

        public ObservableCollection<Account> Accounts { get; set; }

        public Client(string name, ClientType type, bool isHighCreditScore)
        {
            Name = name;
            Type = type;
            IsHighCreditScore = isHighCreditScore;
            Accounts = new ObservableCollection<Account>();
        }
    }
}
