using System;
using System.Collections.Generic;
using System.ComponentModel;
using PropertyChanged;

namespace Xoom.Models
{
    public class Recipient: INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public TransferFlag Transfer { get; set; }
        public string LastUpdate { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        public List<Recipient> GetRecipients()
        {
            return new List<Recipient>
            {
                new Recipient
                {
                    FirstName = "Glenda", 
                    MiddleName = "Elizabeth", 
                    LastName = "Valdivieso Ulloa", 
                    Transfer = TransferFlag.Track,
                    LastUpdate = new DateTimeOffset(new DateTime(2021,1,08)).ToString("D")
                },
                new Recipient
                {
                    FirstName = "Oscar", 
                    MiddleName = "Gabriel", 
                    LastName = "Valdivieso Macias", 
                    Transfer = TransferFlag.Completed,
                    LastUpdate = new DateTimeOffset(new DateTime(2020,12,08)).ToString("D")
                },
                new Recipient
                {
                    FirstName = "Willi", 
                    MiddleName = "Andres", 
                    LastName = "Reyes Reyes", 
                    Transfer = TransferFlag.Completed,
                    LastUpdate = new DateTimeOffset(new DateTime(2020,12,23)).ToString("D")
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

    public enum TransferFlag
    {
        Track,
        Completed
    }
}