using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


/*
 * STUDENT NAME: VANDANA
 * STUDENT ID: 301045522
 * DESCRIPTION: This is the character generator form(The main form of the application)
 * */

namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the BackButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count -1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

       public List<string> FirstNameList = new List<string>();
       public List<string> LastNameList = new List<string>();
        public void LoadNames()
        {
            using (var sr = new StreamReader("firstNames.txt"))
            {
                while (sr.Peek() >= 0)
                    FirstNameList.Add(sr.ReadLine());
            }
            using (var sr = new StreamReader("lastNames.txt"))
            {
                while (sr.Peek() >= 0)
                    LastNameList.Add(sr.ReadLine());
            }
        }
        public void GenerateNames()
        {
            Random first = new Random();
            Random last = new Random();
            foreach(string f in FirstNameList)
            {
                first = 
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader inputStream = new StreamReader(File.Load("Abc.txt", FileMode.Open)))
            {
                //inputStream.ReadLine();
                inputString.Close();
                inputString.Dispose();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputString = new StreamWriter(File.Open("Abc.txt", FileMode.Create)))
            {
                outputString.WriteLine();
                outputString.Close();
                outputString.Dispose();
            }
        }
    }
}
