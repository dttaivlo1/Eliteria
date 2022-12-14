using Eliteria.DataAccess;

using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Threading.Tasks;

namespace Eliteria.Models
{
    public class SavingsAccount
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public decimal Balance { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Gender { get; set; }

        public DateTime DoB { get; set; }
        public DateTime OpenDate { get; set; }
        public int IdTransactionType { get; set; }
        public DateTime NextDueDate { get; set; }
        public string PrescribedAmountDrawn { get; set; }
        public DateTime BeforeDueDate { get; set; }
        public int IdSavingType { get; set; }
        public int MinDaysToWithdrawn { get; set; }
        public decimal Interest { get; set; }
        public static async Task<ObservableCollection<SavingsAccount>> LoadListFromDatabase()
        {
            ObservableCollection<SavingsAccount> savingsAccounts = new ObservableCollection<SavingsAccount>();
            string querry = "EXEC Eliteria_GetSavingAccounts";
            DataTable data = await ExecuteQuery.ExecuteReaderAsync(querry);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                SavingsAccount savingsAccount = new SavingsAccount();
                savingsAccount.Name = data.Rows[i][0].ToString();
                savingsAccount.AccountNumber = data.Rows[i][1].ToString();
                savingsAccount.IdentificationNumber = data.Rows[i][2].ToString();
                savingsAccount.Balance = Convert.ToDecimal(data.Rows[i][3]);
                savingsAccount.Type = data.Rows[i][4].ToString();
                savingsAccount.OpenDate = Convert.ToDateTime(data.Rows[i][5]);

                savingsAccount.Address = data.Rows[i][6].ToString();
                savingsAccount.Email = data.Rows[i][7].ToString();
                savingsAccount.Phonenumber = data.Rows[i][8].ToString();


                if ((bool)data.Rows[i][9])
                {
                    savingsAccount.Gender = "Nam";
                }
                else
                    savingsAccount.Gender = "Nữ";
                savingsAccount.DoB = Convert.ToDateTime(data.Rows[i][10]);
                savingsAccounts.Add(savingsAccount);
            }
            return savingsAccounts;
        }
    }

}