using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        class Anket
        {
            public Anket(string name, string surname, string fatherName, int age, string gender, string country, string specialty, string gamil)
            {
                Name = name;
                Surname = surname;
                FatherName = fatherName;
                Age = age;
                Gender = gender;
                Country = country;
                Specialty = specialty;
                Gamil = gamil;
            }

            public string Name { get; set; }
            public string Surname { get; set; }
            public string FatherName { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string Country { get; set; }
            public string Specialty { get; set; }
            public string Gamil { get; set; }

        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int age = Convert.ToInt32(this.textBox3.Text);  //You dont need the "this"
            Anket myAnket = new Anket(textBox1.Text,textBox2.Text,textBox8.Text,age
                , textBox4.Text, textBox5.Text,textBox6.Text,textBox7.Text);

            var serializer = new JsonSerializer();
            using (var sw=new StreamWriter($"{textBox1.Text}.json"))
            {
                using (var jw=new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw,myAnket);
                }
            }
            MessageBox.Show("Your anket was submitted");
            
        }
    }
}
