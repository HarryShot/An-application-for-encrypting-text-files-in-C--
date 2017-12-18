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

namespace Шифровалка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str2 = "";
            string l = textBox1.Text.ToString()+".txt";
            if (l == ".txt")
            {
                MessageBox.Show("Пожалуйста введите имя файла");
            }
            else
            {
                if (File.Exists(l))
                {
                    StreamReader streamReader = new StreamReader(l); //Открываем файл для чтения
                    string str = ""; //Объявляем переменную, в которую будем записывать текст из файла

                    while (!streamReader.EndOfStream) //Цикл длиться пока не будет достигнут конец файла
                    {
                        str += streamReader.ReadLine(); //В переменную str по строчно записываем содержимое файла
                    }
                    char[] arr = str.ToCharArray();
                    for (int i = 0; i < str.Length; i++)
                    { 
                       int a = i/10;
                      // if (a % 2 == 0)
                      // {
                      //     str2 += ((char)(arr[i] + 17)).ToString();
                      // }
                      // else 
                      // {
                           str2 += ((char)(arr[i] - 6)).ToString();
                      // }
                         }
                   
                    StreamWriter write_text;  //Класс для записи в файл
                    FileInfo file = new FileInfo("code.txt");
                    if (file.Exists == true) //Если файл существует
                    {
                        file.Delete(); //Удаляем
                    }
                    write_text = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
                    write_text.WriteLine(str2); //Записываем в файл текст из текстового поля
                    write_text.Close(); // Закрываем файл
                    MessageBox.Show("Файл зашифрован");
                   
                }
                else {
                    MessageBox.Show("Введите коррекное имя файла"); }
               
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str2 = "";
            string l = textBox1.Text.ToString() + ".txt";
            if (l == ".txt")
            {
                MessageBox.Show("Пожалуйста введите имя файла");
            }
            else
            {
                if (File.Exists(l))
                {
                    StreamReader streamReader = new StreamReader(l); //Открываем файл для чтения
                    string str = ""; //Объявляем переменную, в которую будем записывать текст из файла

                    while (!streamReader.EndOfStream) //Цикл длиться пока не будет достигнут конец файла
                    {
                        str += streamReader.ReadLine(); //В переменную str по строчно записываем содержимое файла
                    }
                    char[] arr = str.ToCharArray();
                    for (int i = 0; i < str.Length; i++)
                    {
                        int a = i / 10;
                      //  if (a % 2 == 0)
                       // {
                       //     str2 += ((char)(arr[i] - 17)).ToString();
                      //  }
                       // else
                       // {
                            str2 += ((char)(arr[i] + 6)).ToString();
                       // }
                    }
                    StreamWriter write_text;  //Класс для записи в файл
                    FileInfo file = new FileInfo("uncode.txt");
                    if (file.Exists == true) //Если файл существует
                    {
                        file.Delete(); //Удаляем
                    }
                    write_text = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
                    write_text.WriteLine(str2); //Записываем в файл текст из текстового поля
                    write_text.Close(); // Закрываем файл
                    MessageBox.Show("Файл расшифрован");

                }
                else
                {
                    MessageBox.Show("Введите коррекное имя файла");
                }

            }
        }
    }
}
