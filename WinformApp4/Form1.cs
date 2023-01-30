namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            int year = int.Parse(this.textBoxByear.Text);
            double grade = double.Parse(this.textBoxGpa.Text);
            //
            Student students = new Student(name, year, grade);
            this.classroom.addStudent(students);
            //
            label5.Text = this.classroom.ShowStudent();
            label17.Text = this.classroom.ShowAllAge().ToString();
            //
            this.classroom.SetGrade();
            //
            this.labelMaxGrade.Text = this.classroom.ShowMaxGrade().ToString();
            this.labelMinGrade.Text = this.classroom.ShowMinGrade().ToString();
            this.labelNameMaxGrade.Text = this.classroom.ShowMaxGradeName();
            this.labelNameMinGrade.Text = this.classroom.ShowMinGradeName();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}