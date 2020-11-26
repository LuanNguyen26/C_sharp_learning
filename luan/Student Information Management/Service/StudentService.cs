using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Common.Model;
using Student_Information_Management.Model;

namespace Student_Information_Management.Service
{
    class StudentService
    {
        private List<Student> _data;
        public StudentService()
        {
            _data = LoadDataFromXml().Students;
        }

        private static Dataset LoadDataFromXml()
        {
            XmlSerializer reader = new XmlSerializer(typeof(Dataset));
            StreamReader file = new StreamReader(@"..\..\..\student_sample_data.xml");

            Dataset data = (Dataset)reader.Deserialize(file);
            file.Close();
            return data;
        }

        public Student Add(Student student)
        {
            _data.Add(student);
            return student;
        }

        public List<string> GetAllClasses()
        {
            return _data.OrderBy(o => o.Class).Select(o => o.Class).Distinct().ToList();
        }


        public void Remove(int studentId)
        {
            var removeStudent = _data.FirstOrDefault(s => s.StudentId == studentId);
            _data.Remove(removeStudent);
        }


        public List<Student> SearchStudent(StudentSearchCriteria criteria)
        {
            return _data.Where(s => 
                (string.IsNullOrEmpty(criteria.SearchText) ||
                    s.StudentId.ToString().Contains(criteria.SearchText) ||
                    s.FirstName.Contains(criteria.SearchText) ||
                    s.LastName.Contains(criteria.SearchText) )
                &&
                (string.IsNullOrEmpty(criteria.ClassName) ||
                    s.Class.Contains(criteria.ClassName))
            ).ToList();
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
