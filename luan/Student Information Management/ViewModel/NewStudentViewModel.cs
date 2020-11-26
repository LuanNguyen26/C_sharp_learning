using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using _10_wpf_data_binding_command;
using Common.Model;
using Student_Information_Management.Service;

namespace Student_Information_Management.ViewModel
{
    class NewStudentViewModel : BaseViewModel, IDataErrorInfo
    {
        private int _StudentID;
        private string _FirstName;
        private string _LastName;
        private DateTime _Brithday = DateTime.Now;
        private string _Gender;
        private string _Address;
        private string _Email;
        private List<string> _ListComboBox = new List<string> { "Item 1", "Item 2", "Item 3" };
        private string _SelectedClass;
        private bool _Male;
        private bool _Female;



        public string Error => throw new NotImplementedException();

        #region get/set

        public int StudentID { get => _StudentID; set => _StudentID = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public DateTime Brithday { get => _Brithday; set => _Brithday = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Email { get => _Email; set => _Email = value; }
        public List<string> ListComboBox { get => _ListComboBox; set => _ListComboBox = value; }
        public string SelectedClass { get => _SelectedClass; set => _SelectedClass = value; }
        public bool Male { get => _Male; set => _Male = value; }
        public bool Female { get => _Female; set => _Female = value; }




        #endregion
        //baoloi
        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                if (nameof(StudentID) == columnName)
                {
                    if (StudentID<0)
                    {
                        result = "ID is mandatory";
                    }
                }
                if (nameof(FirstName) == columnName)
                {
                    if (string.IsNullOrEmpty(FirstName))
                    {
                        result = "firstname is mandatory";
                    }
                }
                if (nameof(LastName) == columnName)
                {
                    if (string.IsNullOrEmpty(LastName))
                    {
                        result = "lastname is mandatory";
                    }
                }
                if (nameof(Brithday) == columnName)
                {
                    if (Brithday > DateTime.Now)
                    {
                        result = "Birthday is mandatory";
                    }
                }

                return result;
            }
        }

       

        public NewStudentViewModel()
        {
            SaveCommand = new RelayCommand(
                o => Save(), o => StudentID > 0
                &&   !string.IsNullOrEmpty(FirstName)
                &&   !string.IsNullOrEmpty(LastName)
                &&   Brithday < DateTime.Now
            );
            CancelCommand = new RelayCommand(
                o => Cancel(), o => StudentID >0
                || !string.IsNullOrEmpty(FirstName)
                || !string.IsNullOrEmpty(LastName)
                || !string.IsNullOrEmpty(Gender)
                || !string.IsNullOrEmpty(Address)
               
            );
            StudentService = new StudentService();
        }

        public StudentService StudentService { get; set; }

        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public void Save()
        {
           
        }
        public void Cancel()
        {
           
        }
    }
}