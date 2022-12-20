using DevExpress.Xpo.DB.Helpers;

using Eliteria.Models;

using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Eliteria.DataAccess
{
    public enum staffName
    {
        InvalidFullName,
        InvalidBirthday,
        Valid
    }
    interface staffAccount
    {
        Task<staffName> CreateNewStaff(Account a);
    }
    public class ProxyDAStaffList : DAStaffList, staffAccount
    {
        private DAStaffList dAStaffList;

        public ProxyDAStaffList()
        {
        }

        public ProxyDAStaffList (DAStaffList dAStaffList)
        {
            this.dAStaffList = dAStaffList;
        }
        public static async Task<staffName> CreateNewStaff(Account _user)
        {
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            string notAllow = "Ho Chi Minh";
            var age = 0;
            if (_user.Birthdate != null)
            {
                age = DateTime.Now.Year - _user.Birthdate.Year;
            }

            var name = "";
            if (_user.StaffName != null)
            {
                name = _user.StaffName;
            }

            if (name.Contains(notAllow))
            {
                return staffName.InvalidFullName;

            }
            else
            {
                string query = "Eliteria_AddNewStaff @Position , @Name , @IdentificationNumber , @Gender , @Birthday , @PhoneNumber , @Address , @Password , @Email";
                await ExecuteQuery.ExecuteNoneQueryAsync(query, new object[] { _user.Position, _user.StaffName, _user.ID, _user.Sex, _user.Birthdate, _user.PhoneNum, _user.Address, _user.Password, _user.Email });
                return staffName.Valid;
            }
                     
        }
    }
    public  class DAStaffList
    {
       
        public static async Task<ObservableCollection<Models.Account>> Load()
        {
            ObservableCollection<Models.Account> ret = new ObservableCollection<Models.Account>();
            DataTable data = await ExecuteQuery.ExecuteReaderAsync("Eliteria_LoadAllStaffs");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                Models.Account staff = new Models.Account
                {
                    StaffName = data.Rows[i].ItemArray[0].ToString(),
                    Position = (int)data.Rows[i].ItemArray[1],
                    ID = data.Rows[i].ItemArray[2].ToString(),
                    Sex = (bool)data.Rows[i].ItemArray[3],
                    Birthdate = (DateTime)data.Rows[i].ItemArray[4],
                    PhoneNum = data.Rows[i].ItemArray[5].ToString(),
                    Address = data.Rows[i].ItemArray[6].ToString(),
                    Email = data.Rows[i].ItemArray[7].ToString(),
                    StaffID = (int)data.Rows[i].ItemArray[8]
                };
                ret.Add(staff);
            }
            return ret;
        }
        public  async Task<staffName> CreateNewStaff(Account a)     // (int Position, string Name, string IdentificationNumber, bool Gender, DateTime Birthday, string PhoneNumber, string Address, string Password, string Email)
        {
            string query = "Eliteria_AddNewStaff @Position , @Name , @IdentificationNumber , @Gender , @Birthday , @PhoneNumber , @Address , @Password , @Email";
             await ExecuteQuery.ExecuteNoneQueryAsync(query, new object[] { a.Position, a.StaffName, a.ID, a.Sex, a.Birthdate, a.PhoneNum, a.Address, a.Password, a.Email});
            return staffName.Valid;
        }

        public static async Task<int> ModifyStaffInfo(int StaffID, int Position, string Name, string PhoneNumber, string Email, string Address)
        {
            string query = "Eliteria_ModifyStaffInfo @StaffId , @Position , @Name , @PhoneNumber , @Email , @Address";
            return await ExecuteQuery.ExecuteNoneQueryAsync(query, new object[] { StaffID, Position, Name, PhoneNumber, Email, Address });
        }
        public static async Task<int> DeleteStaff(int StaffID)
        {
            string query = "Eliteria_RemoveStaff @StaffID";
            return await ExecuteQuery.ExecuteNoneQueryAsync(query, new object[] { StaffID });
        }
    }
}
