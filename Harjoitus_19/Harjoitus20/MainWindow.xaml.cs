using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace WpfStudent
{
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                StudentID = txtStudentID.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            students.Add(student);

            lstStudents.Items.Add(student);

            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("students.bin", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, students);
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("students.bin", FileMode.Open, FileAccess.Read))
            {
                students = (List<Student>)formatter.Deserialize(stream);
            }

            lstStudents.Items.Clear();
            foreach (var student in students)
            {
                lstStudents.Items.Add(student);
            }
        }
    }

    [Serializable]
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({StudentID})";
        }
    }
}