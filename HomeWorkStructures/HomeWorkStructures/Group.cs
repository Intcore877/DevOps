using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructures
{
    using System.Linq.Expressions;

    struct Group
    {
        private int _groupSize;
        private Student[] _student;
        private int _groupId;
        private string _name;

        private int _studentsCount;

        public Group(string name, int groupSize, int groupId)
        {
            _name = name;
            _groupId = groupId;
            _student = new Student[groupSize];
            _groupSize = groupSize;
            _studentsCount = 0;
        }

        #region Methods1
        public void AddStudentInGroup(Student StudentOne)
        {
            if (this._studentsCount >= _student.Length - 1)
            {
                Array.Resize(ref _student, _student.Length * 2);
            }
            _student[this._studentsCount++] = StudentOne;
        }

        public void ShowInfoAboutGroup()
        {
            for (int i = 0; i <= _student.Length-1; i++)
            {
                _student[i].GetInfoAboutStudent();
            }
        }

        public void ChangeStudentInGroup(Group testGroup, int index, Student newStudent)
        {
            testGroup._student[index] = newStudent;
        }

        public void RemoveStudentFromGroup(Student testStudent)
        {
            for (int index = 0; index <= this._student.Length - 1; index++)
            {
                if (_student[index].Equals(testStudent))
                {
                    for (int y = index; y < this._student.Length - 1;)
                    {
                        this._student[y] = this._student[++y];
                    }
                    _studentsCount--;
                }
            }
        }
        #endregion

        public void UpateGroupInfo(string newName, int newGroupID)
        {
            _name = newName;
            _groupId = newGroupID;
        }

        public Student FindStudentInGroup(Group testGroup, Student testStudent)
        {
            for (int index = 0; index <= this._student.Length - 1; index++)
            {
                if (_student[index].Equals(testStudent))
                {
                    return _student[index];
                }
            }
            return new Student();
        }



    }
}
