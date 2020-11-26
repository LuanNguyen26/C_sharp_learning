using Practice.Command;
using Practice.Interface;
using Practice.Models;
using Practice.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Practice.ViewModels
{
    class MainWindowVM : BaseVM
    {
        private string _ContentSearchBox; 
        private string _ClassSelected;
        public string ContentSearchBox
        {
            get => _ContentSearchBox;
            set
            {
                _ContentSearchBox = value;
                OnPropertyChanged(nameof(ContentSearchBox));
            }
        }
        public string ClassSelected
        {
            get => _ClassSelected;
            set
            {
                _ClassSelected = value;
                OnPropertyChanged(nameof(ClassSelected));
            }
        }


        public IStudentService StudentService { get; set; }
        public ObservableCollection<Student> StudentList { get; set; }
        public ObservableCollection<string> ClassList { get; set; }
        public Student SelectStudent { get; set; }
        public MainWindowVM()
        {
            ButtonSearch = new RelayCommand(parameter => Search(),
                parameter => !string.IsNullOrEmpty(ContentSearchBox) || !string.IsNullOrEmpty(ClassSelected));
            ButtonReset = new RelayCommand(parameter => Reset(),
                parameter => !string.IsNullOrEmpty(ContentSearchBox) || !string.IsNullOrEmpty(ClassSelected));
           
            NewStudentMenu = new RelayCommand(o => Menu());

            DeleteStudent = new RelayCommand(parameter => Delete(), parameter => SelectStudent != null);

            // get data
            StudentService = new StudentService();

            StudentList = new ObservableCollection<Student>(StudentService.SearchStudent(new StudentSearchCriteria()));

            ClassList = new ObservableCollection<string>(StudentService.GetAllClasses());
            
        }


        //Command
        #region 
        public ICommand ButtonSearch { get; set; }
        public ICommand ButtonReset { get; set; }
        public ICommand NewStudentMenu { get; set; }
        public ICommand DeleteStudent { get; set; }
        
        public void Search()
        {
            StudentList.Clear();
            var result = StudentService.SearchStudent(
                new StudentSearchCriteria { SearchText = ContentSearchBox, ClassName = ClassSelected }
            );
            foreach (var item in result)
            {
                StudentList.Add(item);
            }
            MessageBox.Show("Search successfully!!");
        }
        public void Reset()
        {
            ContentSearchBox = null;
            ClassSelected = null;
            StudentList.Clear();
            var result = StudentService.SearchStudent(
                new StudentSearchCriteria { SearchText = ContentSearchBox, ClassName = ClassSelected }
            );
            foreach (var item in result)
            {
                StudentList.Add(item);
            }
            MessageBox.Show("Re-enter data!!!");
        }
        public void Menu()
        {
            Window window = new NewStudent();
            window.ShowDialog();
        }
        public void Delete()
        {
            StudentService.Remove(SelectStudent.StudentID);
            StudentList.Clear();
            var result = StudentService.SearchStudent(
                new StudentSearchCriteria { SearchText = ContentSearchBox, ClassName = ClassSelected 
            });
            foreach (var item in result)
            {
                StudentList.Add(item);
            }
            MessageBox.Show("Delete successful!");
        }
        #endregion
    }
}
