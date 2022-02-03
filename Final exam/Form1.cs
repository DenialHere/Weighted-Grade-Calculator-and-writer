using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace Final_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dirpath = @"\Winter20\";
        string txtpath = @"\Winter20\Final.txt";


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting and parsing inputted grades
                Grades grades = new Grades();
                grades.Grade1 = double.Parse(txt_midTerm.Text);
                grades.Grade2 = double.Parse(txt_project.Text);
                grades.Grade3 = double.Parse(txt_final.Text);

                Regex validName = new Regex(@"^[a-zA-Z]{4,20}$");
                Regex session = new Regex(@"^(Summer|Winter|Fall)$");

                if (validName.IsMatch(txt_name.Text.Trim()) == true)
                {
                    if (txt_course.Text == "420-DA3-AS" || txt_course.Text == "420-DW1-AS" || txt_course.Text == "420-DM5-AS")
                    {
                        if (session.IsMatch(txt_session.Text.Trim()) == true)
                        {
                            if (txt_year.Text == "2019" || txt_year.Text == "2020" || txt_year.Text == "2021")
                            {
                                if (grades.Grade1 <= 100 && grades.Grade1 >= 0)
                                {
                                    if (grades.Grade2 <= 100 && grades.Grade2 >= 0)
                                    {
                                        if (grades.Grade3 <= 100 && grades.Grade3 >= 0)
                                        {
                                            grades.Weight();
                                            grades.LetterGrade();
                                            txt_midTermPercentage.Text = grades.Weight1.ToString() + '%';
                                            txt_ProjectPercentage.Text = grades.Weight2.ToString() + '%';
                                            txt_finalPercentage.Text = grades.Weight3.ToString() + '%';
                                            Math.Round(grades.WeightTotal, 1);
                                            txt_total.Text = grades.WeightTotal.ToString();
                                            txt_letterGrade.Text = grades.Letter;



                                        }
                                        else
                                        {
                                            MessageBox.Show("Please input a grade between 0-100 for your final mark.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please input a grade between 0-100 for your project mark.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please input a grade between 0-100 for your midterm mark.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please choose a valid year. (2019,2020, or 2021");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please choose a valid session. (Summer, Winter, Fall)");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose a valid course number. (420-DA3-AS, 420-DW1-AS or 420-DM5-AS) ");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid name! Please input a name between 4-20 characters.");
                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Danial Gosse April 30 2020
            if (!Directory.Exists(dirpath)) Directory.CreateDirectory(dirpath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex validName = new Regex(@"^[a-zA-Z]{4,20}$");
            Regex session = new Regex(@"^(Summer|Winter|Fall)$");
            Grades grades = new Grades();
            grades.Grade1 = double.Parse(txt_midTerm.Text);
            grades.Grade2 = double.Parse(txt_project.Text);
            grades.Grade3 = double.Parse(txt_final.Text);

            if (validName.IsMatch(txt_name.Text.Trim()) == true)
            {
                if (txt_course.Text == "420-DA3-AS" || txt_course.Text == "420-DW1-AS" || txt_course.Text == "420-DM5-AS")
                {
                    if (session.IsMatch(txt_session.Text.Trim()) == true)
                    {
                        if (txt_year.Text == "2019" || txt_year.Text == "2020" || txt_year.Text == "2021")
                        {
                            if (grades.Grade1 <= 100 && grades.Grade1 >= 0)
                            {
                                if (grades.Grade2 <= 100 && grades.Grade2 >= 0)
                                {
                                    if (grades.Grade3 <= 100 && grades.Grade3 >= 0)
                                    {
                                        if (!Directory.Exists(dirpath)) Directory.CreateDirectory(dirpath);
                                        FileStream fs = null;
                                        string filepath = dirpath + "Final.txt";
                                        fs = new FileStream(filepath, FileMode.Append);
                                        StreamWriter textout = new StreamWriter(fs);
                                        textout.Write(txt_name.Text + "|" + txt_course.Text + "|" + txt_session.Text + "|" + txt_year.Text + "|" + txt_midTerm.Text + "|" + txt_project.Text + "|" + txt_final.Text + "|" + txt_midTermPercentage.Text + "|" + txt_ProjectPercentage.Text + "|" + txt_finalPercentage.Text + "|" + txt_total.Text + "|" + txt_letterGrade.Text + "|" + "\n");
                                        textout.Close();
                                        MessageBox.Show("Sucessfully written to text file.");



                                    }
                                    else
                                    {
                                        MessageBox.Show("Please input a grade between 0-100 for your final mark.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please input a grade between 0-100 for your project mark.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please input a grade between 0-100 for your midterm mark.");
                            }

                      
                        }
                        else
                        {
                            MessageBox.Show("Please choose a valid year. (2019,2020, or 2021");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose a valid session. (Summer, Winter, Fall)");
                    }
                }
                else
                {
                    MessageBox.Show("Please choose a valid course number. (420-DA3-AS, 420-DW1-AS or 420-DM5-AS) ");
                }
            }
            else
            {
                MessageBox.Show("Invalid name! Please input a name between 4-20 characters.");
            }
        }

                               
        private void button4_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@dirpath + "Final.XML"))
            {
                MessageBox.Show("No XML File found!");
            }
            else
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;
                XmlReader xmlIn = XmlReader.Create(dirpath + "Final.xml", settings);
                string name, cNumber, session, year, mid1, project1, final1, total, mid2, project2, final2, letterGrade, tempStr = "";
                if (xmlIn.ReadToDescendant("Grade"))
                {
                    do
                    {
                        xmlIn.ReadStartElement("Grade");
                        name = xmlIn.ReadElementContentAsString();
                        cNumber = xmlIn.ReadElementContentAsString();
                        session = xmlIn.ReadElementContentAsString();
                        year = xmlIn.ReadElementContentAsString();
                        mid1 = xmlIn.ReadElementContentAsString();
                        project1 = xmlIn.ReadElementContentAsString();
                        final1 = xmlIn.ReadElementContentAsString();
                        mid2 = xmlIn.ReadElementContentAsString();
                        project2 = xmlIn.ReadElementContentAsString();
                        final2 = xmlIn.ReadElementContentAsString();
                        total = xmlIn.ReadElementContentAsString();
                        letterGrade = xmlIn.ReadElementContentAsString();
                        tempStr += "Student Name: " + name + "\nCourse Number: " + cNumber + "\nSession: " + session + "\nYear: " + year + "\nMid term grade: " + mid1 + "\nProject grade: " + project1 + "\nFinal grade: " + final1 + "\nMid term percentage: " + mid2 + "\nProject percentage: " + project2 + "\nFinal percentage: " + final2 + "\nTotal: " + total + "\nLetter Grade: " + letterGrade + "\r\n\n";
                    } while (xmlIn.ReadToNextSibling("Grade"));
                }
                MessageBox.Show(tempStr, "XML Reader");
                xmlIn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Are you sure you wish to exit?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirpath)) Directory.CreateDirectory(dirpath);
            if (!File.Exists(@txtpath))
            {
                MessageBox.Show("Please write to text file first.");
            }
            else
            {
                FileStream fs = new FileStream(txtpath, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true; settings.IndentChars = (" ");


                XmlWriter xmlOut = XmlWriter.Create(dirpath + "Final.xml", settings);

                xmlOut.WriteStartDocument();
                xmlOut.WriteStartElement("Root");
                {
                    while (textIn.Peek() != -1)
                    {
                        string row = textIn.ReadLine();
                        string[] columns = row.Split('|');
                        xmlOut.WriteStartElement("Grade");
                        xmlOut.WriteElementString("studentName", columns[0]);
                        xmlOut.WriteElementString("courseNumber", columns[1]);
                        xmlOut.WriteElementString("session", columns[2]);
                        xmlOut.WriteElementString("year", columns[3]);
                        xmlOut.WriteElementString("midTermMark", columns[4]);
                        xmlOut.WriteElementString("projectMark", columns[5]);
                        xmlOut.WriteElementString("midTermPercentage", columns[6]);
                        xmlOut.WriteElementString("projectPercentage", columns[7]);
                        xmlOut.WriteElementString("finalPercentage", columns[8]);
                        xmlOut.WriteElementString("totalPercentage", columns[9]);
                        xmlOut.WriteElementString("finalMark", columns[10]);
                        xmlOut.WriteElementString("letterGrade", columns[11]);
                        xmlOut.WriteEndElement();
  
                    }
                }

                xmlOut.WriteEndElement();
                xmlOut.Close();
                textIn.Close();
                MessageBox.Show("Sucessfully written to XML file.");
            }
        }
    }
 }


class Grades 
{
    private double grade1, grade2, grade3;
    private double weight1, weight2, weight3, weightTotal;
    private string letter;

    public void Weight()
    {
        weight1 = ((grade1 / 100) * 0.3) * 100;
        weight2 = ((grade2 / 100) * 0.3) * 100;
        weight3 = ((grade3 / 100) * 0.4) * 100;
        weightTotal = weight1 + weight2 + weight3;
    }
    public void LetterGrade()
    {
        if (weightTotal >= 90) 
        {
            letter = "A";
        }
        else if (weightTotal >= 80) 
        {
            letter = "B";
        }
        else if (weightTotal >= 70)
        {
            letter = "C";
        }
        else if (weightTotal >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
    }
    public Grades(double grade1, double grade2, double grade3, string letter)
    {
        this.grade1 = grade1;
        this.grade2 = grade2;
        this.grade3 = grade3;
        this.letter = letter;

    }
    public Grades()
    {

    }
    public double Grade1
    {
        get { return grade1; }
        set { grade1 = value; }
    }
    public double Grade2
    {
        get { return grade2; }
        set { grade2 = value; }
    }
    public double Grade3
    {
        get { return grade3; }
        set { grade3 = value; }
    }
    public double Weight1
    {
        get { return weight1; }
        set { weight1 = value; }
    }
    public double Weight2
    {
        get { return weight2; }
        set { weight2 = value; }
    }
    public double Weight3
    {
        get { return weight3; }
        set { weight3 = value; }
    }
    public double WeightTotal
    {
        get { return weightTotal; }
        set { weightTotal = value; }
    }
    public string Letter
    {
        get { return letter; }
        set { letter = value; }
    }

}
