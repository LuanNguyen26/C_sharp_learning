using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_Management.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        private string _SearchBox;
        private List<string> _ListClass = new List<string> { "Item 1", "Item 2", "Item 3" };
        private string _SelectedClass;

        public string SearchBox { get => _SearchBox; set =>  _SearchBox = value; }
        public List<string> ListClass { get => _ListClass; set => _ListClass = value; }
        public string SelectedClass { get => _SelectedClass; set =>     _SelectedClass = value; }
    }
}
