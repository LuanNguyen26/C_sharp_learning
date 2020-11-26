using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using _10_wpf_data_binding_command;
using Common.Model;
using Student_Information_Management.Model;
using Student_Information_Management.Service;

namespace Student_Information_Management.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        private string _SearchBox;
        private string _SelectedClass;

        public MainWindowViewModel()
        {
            SearchCommand = new RelayCommand(o => Search(), o => !string.IsNullOrEmpty(SearchBox) || !string.IsNullOrEmpty(SelectedClass));
            ResetCommand = new RelayCommand(o => Reset(), o => !string.IsNullOrEmpty(SearchBox) || !string.IsNullOrEmpty(SelectedClass));
            MenuNewStudent = new RelayCommand(o => Menu());


            StudentService = new StudentService();

            StudentList = new ObservableCollection<Student>(StudentService.SearchStudent(new StudentSearchCriteria()));

            ClassList = new ObservableCollection<string>(StudentService.GetAllClasses());
        }

       

        public ObservableCollection<Student> StudentList { get; set; }
        public StudentService StudentService { get; set; }
        public ObservableCollection<string> ClassList { get; set; }


        public string SearchBox
        {
            get
            {
                return _SearchBox;
            }

            set
            {
                _SearchBox = value;
                OnPropertyChanged(nameof(SearchBox));
            }
        }
        public string SelectedClass
        {
            get
            {
                return _SelectedClass;
            }

            set
            {
                _SelectedClass = value;
                OnPropertyChanged(nameof(SelectedClass));
            }
        }
        


        public ICommand SearchCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand MenuNewStudent { get; set; }


        public void Search()
        {
            StudentList.Clear();
            var ketqua = StudentService.SearchStudent(
                new StudentSearchCriteria { SearchText = SearchBox, ClassName = SelectedClass }
            );
            foreach (var item in ketqua)
            {
                StudentList.Add(item);
            }
        }
        public void Reset()
        {
            SearchBox = null ;
            SelectedClass = null;
            StudentList.Clear();
            var ketqua = StudentService.SearchStudent(
                new StudentSearchCriteria { SearchText = SearchBox, ClassName = SelectedClass }
            );
            foreach (var item in ketqua)
            {
                StudentList.Add(item);
            }
        }
        public void Menu()
        {
            Window window = new NewStudent();
            window.ShowDialog();
        }
       
        
    }
}
