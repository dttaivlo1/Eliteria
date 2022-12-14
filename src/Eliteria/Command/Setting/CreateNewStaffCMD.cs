using DevExpress.ClipboardSource.SpreadsheetML;

using Eliteria.DataAccess;
using Eliteria.Models;

using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Eliteria.Command
{
   
    public class CreateNewStaffCMD : BaseCommandAsync
    {
        ViewModels.AddStaffViewModel viewModel;
        ViewModels.StaffsViewModel staffsViewModel;

        public CreateNewStaffCMD(ViewModels.AddStaffViewModel viewModel, ViewModels.StaffsViewModel staffsViewModel)
        {
            this.viewModel = viewModel;
            this.staffsViewModel = staffsViewModel;
        }
         public int countStaff()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IK1QN6E;Initial Catalog=ELITERIA;Integrated Security=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN", conn);
            Int32 count = (Int32)comm.ExecuteScalar();
            return count;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            if (Validation(viewModel.Name, viewModel.IdentificationNumber, viewModel.Password, viewModel.PhoneNumber, viewModel.Address, BlankNameCallBack, BlankIdCallBack, BlankPassCallBack, BlankPhoneCallBack, BlankAddrCallBack))
            {
                if (viewModel.Email == null) viewModel.Email = "";
                Models.Account account = new Models.Account()
                {
                   

                StaffID = countStaff(),
                    Email = viewModel.Email,
                    Password = viewModel.Password,
                    StaffName = viewModel.Name,
                    PhoneNum = viewModel.PhoneNumber,
                    ID = viewModel.IdentificationNumber,
                    Address = viewModel.Address,
                    Sex = viewModel.SelectedGender,
                    Position = viewModel.SelectedPosition,
                    Birthdate = viewModel.Birthday
                };
                //DAStaffList dAStaffList = new DAStaffList();
               
             var res = await ProxyDAStaffList.CreateNewStaff(account);             //(viewModel.SelectedPosition, viewModel.Name, viewModel.IdentificationNumber, viewModel.SelectedGender, viewModel.Birthday, viewModel.PhoneNumber, viewModel.Address, viewModel.Password, viewModel.Email).ContinueWith(OnQueryFinished);
                if (res == staffName.Valid)
                {
                    staffsViewModel.StaffList = await DataAccess.DAStaffList.Load();

                    viewModel.StatusMessage = "Thêm nhân viên thành công";
                    viewModel.StatusColor = Brushes.Green;
                }
                else if (res == staffName.InvalidBirthday)
                {
                    viewModel.StatusMessage = "Đã xảy ra lỗi khi thực thi hành động này. Xin vui lòng kiểm tra lại ngày sinh";
                    viewModel.StatusColor = Brushes.Red;
                }
                else if (res == staffName.InvalidFullName)
                {
                    viewModel.StatusMessage = "Đã xảy ra lỗi khi thực thi hành động này. Xin vui lòng kiểm tra lại Tên nhân viên";
                    viewModel.StatusColor = Brushes.Red;
                }
                else
                {
                    viewModel.StatusMessage = "Đã xảy ra lỗi khi thực thi hành động này. Xin vui lòng kiểm tra lại  dữ liệu nhập vào";
                    viewModel.StatusColor = Brushes.Red;
                }
            }
        }

        private void BlankAddrCallBack()
        {
            viewModel.StatusMessage = "Vui lòng nhập địa chỉ";
            viewModel.StatusColor = Brushes.Red;
        }

        private void BlankPhoneCallBack()
        {
            viewModel.StatusMessage = "Vui lòng nhập số điện thoại";
            viewModel.StatusColor = Brushes.Red;
        }

        private void BlankPassCallBack()
        {
            viewModel.StatusMessage = "Vui lòng nhập mật khẩu để có thể đăng nhập vào phần mềm này";
            viewModel.StatusColor = Brushes.Red;
        }

        private void BlankIdCallBack()
        {
            viewModel.StatusMessage = "Vui lòng nhập căn cước công dân";
            viewModel.StatusColor = Brushes.Red;
        }

        private void BlankNameCallBack()
        {
            viewModel.StatusMessage = "Vui lòng nhập tên";
            viewModel.StatusColor = Brushes.Red;
        }

        private int OnQueryFinished(Task<int> arg)
        {
            if (arg.IsFaulted)
            {
                return -1;
            }
            return arg.Result;
        }

        public static bool Validation(string name, string iden, string pass, string phone, string addr, Action blankNameCallBack = null, Action blankIdCallBack = null, Action blankPassCallBack = null, Action blankPhoneCallBack = null, Action blankAddrCallBack = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                blankNameCallBack?.Invoke();
                return false;
            }
            if (string.IsNullOrEmpty(iden))
            {
                blankIdCallBack?.Invoke();
                return false;
            }
            if (string.IsNullOrEmpty(pass))
            {
                blankPassCallBack?.Invoke();
                return false;
            }
            if (string.IsNullOrEmpty(phone))
            {
                blankPhoneCallBack?.Invoke();
                return false;
            }
            if (string.IsNullOrEmpty(addr))
            {
                blankAddrCallBack?.Invoke();
                return false;
            }
            return true;
        }
    }
}
