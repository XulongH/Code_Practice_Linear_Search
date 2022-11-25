using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Practice_Linear_Search
{
    public partial class Form1 : Form
    {
        // Use this list
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            // Don't remove this code
            GenerateList(students);
            DisplayOGList(students);
        } // Form1()

        // Part 1: Contains
        // Write a method that takes an string and a List<int> and returns a bool
        // Create a linear search that returns true if the name is found on the list, and false if not
        // Display the result in a MessageBox.
    

        private void btnContains_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtContains.Text;

     
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
            }
        } // btnContains_Click

        // Write Code Below
        // bool Contains(string name, List<Student> list)
        public bool LinearSearch(string name, List<Student> list)
        {
            foreach (Student student in list)
            {
                if(student.Name == name)
                {
                    return true;
                }
            }
            return false;
        }



        //-----------------------------------------------------------------

        // Part 2: Find The Index
        // Write a method that takes an string ( name ) and a List<int> and returns an int
        // Ask the user for student name. If found display the index of where the student is located in a message box
        // Else display -1


        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFindName.Text;


            }
            catch
            {
                MessageBox.Show("Enter a valid number");
            }
        } // btnFind_Click

        // Write Code Below
        // int FindByIndex(string name, List<Student> list)
        public int FindIndex(string name, List<Student> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                string name = list[i].Name;

                if(name == name)
                {
                    return i;
                }
            }
            return -1;
        }


        //-----------------------------------------------------------------

        // Part 3: Display All CSI student
        // Create a method that takes a List<Student> and returns a List<Student>
        // Write a method that loops through a list of students. Return a list of students who are a part of the CSI program
        // use "CSI" for the search

        private void btnCSI_Click(object sender, EventArgs e)
        {
            

            // DisplayFilteredList(Filtered List); /* <---- Use this method to display your filtered list*/

        } // btnCSI_Click

        // Write Code Below
        // List<Student> FindCSI(List<Student> students)
        public Student FindCSI(string Program, List<Student> students)
        {
            string Program = CSI;
            foreach (Student student in students)
            {
                
                string studentProgram = student.Program;

                
                if (studentProgram == CSI)
                {
                    
                    return student;
                }
            }

            return null; 
        }
    }




        //-----------------------------------------------------------------
        // Part 4: Display all students with grades in between a range of numbers
        // Create a method that takes a 2 ints and a List<Student> and returns a List<Student>
        // Write a method that returns a list that contains all students who grades are between a Low and High value
        // Example. Low = 40, High = 80. Your returned list will have every students who has grades between 40 and 80


        private void btnFilterRange_Click(object sender, EventArgs e)
        {

            try
            {
                int low = int.Parse(txtMin.Text);
                int high = int.Parse(txtMax.Text);


                // DisplayFilteredList(Filtered List); /* <---- Use this method to display your filtered list*/
            }
            catch
            {
                MessageBox.Show("Enter a valid number");
            }
        } // btnFilterRange_Click

        // Write Code Below
        // List<Student> FindStudentsWithGrades(int low, int high, List<Student> students)
        public List<Student> FindStudentsWithGrades(int low, int high, List<Student> students)
        {
            
            foreach (Student student in students)
            {
                
                int low = 40;
                int high  = 80;
                int studentGrade = student.Grade;

                if (studentGrade == low && high)
                {
                    return students;
                }
            }
            return null;
        }



        // Helper Method------------------------------------

        public void DisplayFilteredList(List<Student> students)
        {
            lbFilterResult.Items.Clear();
            foreach (Student student in students)
            {
                lbFilterResult.Items.Add(student);
            }
        } // DisplayFilteredList()


        //-----------------------------------------------------------------

        #region GenerateList

        public void GenerateList(List<Student> list)
        {
            Random rand = new Random();
            string[] firstNames = {
                "James",
                "Mary",
                "Robert",
                "Patricia",
                "John",
                "Jennifer",
                "Michael",
                "Linda",
                "David",
                "Elizabeth",
                "William",
                "Elizabeth",
                "Barbara",
                "Richard",
                "Susan",
                "Joseph",
                "Jessica",
                "Thomas",
                "Sarah",
                "Charles",
                "Karen",
                "Christopher",
                "Lisa",
                "Daniel",
                "Nancy",
                "Matthew",
                "Betty",
                "Anthony",
                "Margaret",
                "Mark",
                "Sandra"
            };

            string[] programs = { "CSI", "CNT" };

            for(int i = 0; i < firstNames.Length; i++)
            {
                list.Add(new Student(firstNames[i], rand.Next(0, 101), programs[rand.Next(programs.Length)]));
            }


        } // GenerateList

        public void DisplayOGList(List<Student> list)
        {
            lbAll.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                lbAll.Items.Add(i + ": " + students[i].ToString());
            }
        }



        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } // class

} // namespace
