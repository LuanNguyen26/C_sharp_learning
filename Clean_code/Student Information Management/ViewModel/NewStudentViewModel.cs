using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_Management.ViewModel
{
    class NewStudentViewModel : BaseViewModel
    {
        private string _StudentID;
        private string _FirstName;
        private string _LastName;
        private string _Brithday;
        private string _Gender;
        private string _Address;
        private string _Email;
        private List<string> _ListComboBox = new List<string> { "Item 1", "Item 2", "Item 3" };
        private string _SelectedClass;

        public string StudentID { get => _StudentID; set => _StudentID = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string Brithday { get => _Brithday; set => _Brithday = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Email { get => _Email; set => _Email = value; }
        public List<string> ListComboBox { get => _ListComboBox; set => _ListComboBox = value; }
        public string SelectedClass { get => _SelectedClass; set => _SelectedClass = value; }
    }
}
