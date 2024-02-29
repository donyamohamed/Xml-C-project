using Attendance_Management_System.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Attendance_Management_System.classes.User;
using static Attendance_Management_System.classes.Teacher;
using static Attendance_Management_System.classes.Course;
using static Attendance_Management_System.classes.RenderTable;
using static Attendance_Management_System.classes.RenderAttendanceTable;
using static Attendance_Management_System.classes.RenderStduentAttendanceofTecherTable;
using static Attendance_Management_System.classes.Class;
using Microsoft.VisualBasic.Logging;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace Attendance_Management_System.Forms
{
    public partial class TeacherForm : Form
    {
        public static List<string> myCIDs = getCoursesIDbyTeacherID(FormLogin.meTeacher.Id);
        public static List<Course> myCoursesObj = getListofCourse(myCIDs);
        public static List<StudentSessions> myStdSessionsObj = getListofmyStudentSessions(FormLogin.meTeacher.Id, myCIDs);
        public static List<Session> mySessionsObj = getListofSessions(myCIDs);
        public static List<DateTime> courseDates = getCDatesbyCIds(myCIDs);

        // public static List<Course> myCoursesObj = getCourseByID()

        public TeacherForm()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Program.appLanguage);
            InitializeComponent();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            // message to make sure the user want to save the data or not
            // if yes save the data and close the form
            // if no close the form
            // if cancel do nothing just return to the form

            DialogResult dialogResult = MessageBox.Show("Do you want to save the data before you leave?", "Save Data", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                // save the data
                Program.SaveDataAsXml(Program.usersPath, Program.coursesPath, Program.claSSesPath);
                // close the form
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                // close the form
                Close();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                // do nothing
                return;
            }

            FormLogin Formlogin = new FormLogin();
            Formlogin.Show();
            Hide();

            Close();
        }


        private void TeacherForm_Load(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = RenderDateTable(myCoursesObj);
            //Console.WriteLine(Program.claSSes);
            // dataGridViewAttendance.DataSource = RenderDateTable(mySessionsObj);
            // dataGridViewDateStatus.DataSource = RenderDateTable(mySessionsObj);



            dataGridViewAttendance.DataSource = RenderStdAttofTecherTable(mySessionsObj, myStdSessionsObj);



            labelID.Text = FormLogin.meTeacher.Id.ToString();
            labelAge.Text = FormLogin.meTeacher.Age.ToString();
            labelEmail.Text = FormLogin.meTeacher.Email.ToString();
            // labelPhoneNmber.Text = FormLogin.meTeacher.Phone.ToString();
            textBoxPhoneNumber.Text = FormLogin.meTeacher.Phone.ToString();
            textBoxAddress.Text = FormLogin.meTeacher.Address.ToString();
            textBoxAddress.ReadOnly = true;
            labelTeacher_Name.Text = FormLogin.meTeacher.FirstName.ToString() + " " + FormLogin.meTeacher.LastName.ToString();

            // listBoxCourses.DataSource = FormLogin.meTeacher.getCoursesIDbyTeacherID(FormLogin.meTeacher.Id).ToString();
            listBoxCourses.DataSource = myCIDs;
            listBoxCDates.DataSource = courseDates;


            //foreach (Control c in this.Controls)
            //{
            //    ComponentResourceManager resources = new ComponentResourceManager(typeof(FormSettings));
            //    resources.ApplyResources(c, c.Name, new System.Globalization.CultureInfo(Program.appConfig.Language));
            //}

        }

        private void buttonEditYourData_Click(object sender, EventArgs e)
        {
            if (buttonEditYourData.Text == "Edit Your Data")
            {
                buttonEditYourData.Text = "Save Your Data";
                textBoxAddress.ReadOnly = false;
                textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
                textBoxPhoneNumber.ReadOnly = false;
                textBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;

                labelID.Visible = false;
            }
            else if (buttonEditYourData.Text == "Save Your Data")
            {
                buttonEditYourData.Text = "Edit Your Data";
                textBoxAddress.ReadOnly = true;
                textBoxAddress.BorderStyle = BorderStyle.None;
                textBoxPhoneNumber.ReadOnly = false;
                textBoxPhoneNumber.BorderStyle = BorderStyle.None;
                labelID.Visible = true;

                FormLogin.meTeacher.changeTeacherData(
                    FormLogin.meTeacher.FirstName,
                    FormLogin.meTeacher.LastName,
                    FormLogin.meTeacher.Age,
                    FormLogin.meTeacher.Email,
                    FormLogin.meTeacher.Password,
                    textBoxPhoneNumber.Text,
                    textBoxAddress.Text
                    );
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxPhoneNumber.Text = FormLogin.meTeacher.Phone.ToString();
            textBoxAddress.Text = FormLogin.meTeacher.Address.ToString();
            textBoxAddress.ReadOnly = true;

            buttonEditYourData.Text = "Edit Your Data";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxPhoneNumber.ReadOnly = false;
            textBoxPhoneNumber.BorderStyle = BorderStyle.None;
            labelID.Visible = true;


        }

        private void dataGridViewAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Chagne the Color of the row
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                dataGridViewAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            // if cell contains "Absent" then change the color to red 
            // else if cell contains "Attend" then change the color to green
            if (e.Value != null && e.Value.ToString() == "Absent")
            {
                e.CellStyle.BackColor = Color.Red;
            }
            else if (e.Value != null && e.Value.ToString() == "Attend")
            {
                e.CellStyle.BackColor = Color.Green;
            }
            else
            {
                e.CellStyle.BackColor = Color.Orange;
            }
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            // prevent se
            if (indexRow < 0)
            {
                return;
            }
            selectedStudents = new List<Obj>(); ;

            DataGridViewRow row = dataGridViewCourses.Rows[indexRow];
            textBoxCouseID.Text = row.Cells[0].Value.ToString();
            textBoxCourseName.Text = row.Cells[1].Value.ToString();
            textBoxCourseDescription.Text = row.Cells[2].Value.ToString();
            textBoxCourseSessions.Text = row.Cells[3].Value.ToString();

            List<string> selectedCourse = new List<string>();
            selectedCourse.Add(row.Cells[0].Value.ToString());
            List<DateTime> courseDates = getCDatesbyCIds(selectedCourse);
            comboBoxCourseDates.DataSource = courseDates;


            /*
            if (selectedCourse.Contains(row.Cells[0].Value.ToString()))
                selectedCourse.Add(row.Cells[0].Value.ToString());
            else
                selectedCourse.Remove(row.Cells[0].Value.ToString());
            */




            // textBoxID.Text = row.Cells[0].Value.ToString();
            // textBoxName.Text = row.Cells[1].Value.ToString();
            // textBoxDescription.Text = row.Cells[2].Value.ToString();
            //dataGridViewAttendance.DataSource = 
            dataGridViewStudentStatus.DataSource = RenderAttTable(textBoxDate.Text, myStdSessionsObj);
            dataGridViewAttendance.DataSource = RenderStdAttofTecherTable(mySessionsObj, myStdSessionsObj);


        }

        class Obj
        {
            public string StudentID { get; set; }
            public string Status { get; set; }
            public string Name { get; set; }
            // constructor
            public Obj(string studentId, string status, string name)
            {
                StudentID = studentId;
                Status = status;
                Name = name;
            }

        }

        List<Obj> selectedStudents = new List<Obj>();

        private void dataGridViewStudentStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            DataGridViewRow row = dataGridViewStudentStatus.Rows[indexRow];


            Obj selectedStudent = new Obj(
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString()
                );

            if (selectedStudents.Contains(selectedStudent))
            {
                // If the student is already in the list, remove them (deselect)
                selectedStudents.Remove(selectedStudent);
            }
            else
            {
                // If the student is not in the list, add them (select)
                selectedStudents.Add(selectedStudent);
            }
            // check if the selectedStudents contains the student or not 
            if (selectedStudents.Count > 0)
            {
                buttonAttend.Visible = true;
                buttonAbsent.Visible = true;
            }
            else
            {
                buttonAttend.Visible = false;
                buttonAbsent.Visible = false;
            }
        }

        private void buttonAttend_Click(object sender, EventArgs e)
        {
            // make the selected students present 
            foreach (var student in selectedStudents)
            {
                student.Status = "Attend";
                changeStudentAttendance(FormLogin.meTeacher.Id, textBoxCouseID.Text, student.StudentID, Convert.ToDateTime(textBoxDate.Text), 1);
            }
            selectedStudents = new List<Obj>();
            dataGridViewStudentStatus.DataSource = RenderAttTable(textBoxDate.Text, myStdSessionsObj);
            dataGridViewAttendance.DataSource = RenderStdAttofTecherTable(mySessionsObj, myStdSessionsObj);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudents = new List<Obj>();
            textBoxDate.Text = comboBoxCourseDates.Text;
            dataGridViewStudentStatus.DataSource = RenderAttTable(textBoxDate.Text, myStdSessionsObj);

        }

        private void buttonAbsent_Click(object sender, EventArgs e)
        {
            // make the selected students present 
            foreach (var student in selectedStudents)
            {
                student.Status = "Attend";
                changeStudentAttendance(FormLogin.meTeacher.Id, textBoxCouseID.Text, student.StudentID, Convert.ToDateTime(textBoxDate.Text), -1);
            }
            selectedStudents = new List<Obj>();
            dataGridViewStudentStatus.DataSource = RenderAttTable(textBoxDate.Text, myStdSessionsObj);
            dataGridViewAttendance.DataSource = RenderStdAttofTecherTable(mySessionsObj, myStdSessionsObj);

        }

        private void dataGridViewStudentStatus_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                dataGridViewAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }

            // if cells of column "Satus" contains "1" then change the 1 to "Attend"

            if (e.Value != null && e.Value.ToString() == "1")
            {
                e.Value = "Attend";
            }
            else if (e.Value != null && e.Value.ToString() == "-1")
            {
                e.Value = "Absent";
            }
            else
            {
                e.CellStyle.BackColor = Color.Orange;
            }

            // if cell contains "Absent" then change the color to red 
            // else if cell contains "Attend" then change the color to green
            if (e.Value != null && e.Value.ToString() == "Absent")
            {
                e.CellStyle.BackColor = Color.Red;
            }
            else if (e.Value != null && e.Value.ToString() == "Attend")
            {
                e.CellStyle.BackColor = Color.Green;
            }
            else
            {
                e.CellStyle.BackColor = Color.Orange;
            }

        }

        private void buttonExpPDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentStatus.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridViewStudentStatus.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridViewStudentStatus.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridViewStudentStatus.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void dataGridViewCourses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Chagne the Color of the row
            if (e.RowIndex % 2 == 0)
            {
                dataGridViewAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                dataGridViewAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            // if cell contains "Absent" then change the color to red 
            // else if cell contains "Attend" then change the color to green
            if (e.Value != null && e.Value.ToString() == "Absent")
            {
                e.CellStyle.BackColor = Color.Red;
            }
            else if (e.Value != null && e.Value.ToString() == "Attend")
            {
                e.CellStyle.BackColor = Color.Green;
            }
            else
            {
                e.CellStyle.BackColor = Color.Orange;
            }

        }


        /*
        private void dataGridViewStudentStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // get list with selected Rows in the dataGridViewStudentStatus 
            // to change the status of the selected students
            int indexRow = e.RowIndex;

            if (indexRow < 0)
            {
                return;
            }

            // get the selected row data in a list 
            // when the user select on the row add to the list
            // when the user deselect the row remove from the list

            List<Obj> thisStd = new List<Obj>();

            Data


            DataGridViewRow row = dataGridViewStudentStatus.Rows[indexRow];
            textBoxStudentID.Text = row.Cells[0].Value.ToString();
            textBoxStatus.Text = row.Cells[1].Value.ToString();
            textBoxName.Text = row.Cells[2].Value.ToString();


        }
        */
    }
}
