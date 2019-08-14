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
            if(MainTabControl.SelectedIndex == 3)
            {
                HeroNameDataLabel.Text =
                GeneratedNameDataLabel.Text=
                AbilitiesDataLabel.Text=
                InventoryItemsDataLabel.Text=
            }
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
        /// <summary>
        /// Creating Firstname and Lastname lists 
        /// </summary>
       public List<string> FirstNameList = new List<string>();
       public List<string> LastNameList = new List<string>();
        public void loadnames()
        {
            //Inputing First Name
            var firstName = File.ReadAllLines("../../Data/firstNames.txt");
            var firstNameList = new List<string>(firstName);

            //Inputing Last Name
            var lastName = File.ReadAllLines("../../Data/lastNames.txt");
            var lastNameList = new List<string>(lastName);
        }
        public void GenerateNames()
        {
            //Inputing First Name
            var firstName = File.ReadAllLines("../../Data/firstNames.txt");
            var firstNameList = new List<string>(firstName);
            Random rand = new Random();
            int index = rand.Next(firstNameList.Count);
            FirstNameDataLabel.Text = firstNameList[index];

            //Inputing Last Name
            var lastName = File.ReadAllLines("../../Data/lastNames.txt");
            var lastNameList = new List<string>(lastName);
            Random random = new Random();
            int indexs = random.Next(lastNameList.Count);
            LastNameDataLabel.Text = lastNameList[indexs];
            CharacterNameTextBox.Text = firstNameList[index] + " " + lastNameList[indexs];
        }
        /// <summary>
        /// EXit toolstrip code to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Save File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.ShowDialog();
            using (StreamWriter outputString = new StreamWriter(File.Open("Abc.txt", FileMode.Create)))
            {
                outputString.WriteLine(Program.character);
                outputString.Close();
                outputString.Dispose();
            }

        }
        //open File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader inputStream = new StreamReader(File.Open("Abc.txt", FileMode.Open)))
            {
                inputStream.ReadLine();
                inputStream.Close();
                inputStream.Dispose();
            }

        }
       
        //Generate Abilities button click event
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int strength = rnd.Next(3,18);
            int dexterity = rnd.Next(3, 18);
            int constitution = rnd.Next(3, 18);
            int intelligence = rnd.Next(3, 18);
            int wisdom = rnd.Next(3, 18);
            int charisma = rnd.Next(3, 18);
            StrengthDataLabel.Text = strength.ToString();
            DexterityDataLabel.Text = dexterity.ToString();
            CostitutionDataLabel.Text = constitution.ToString();
            IntelligenceDataLabel.Text = intelligence.ToString();
            WisdomDataLabel.Text = wisdom.ToString();
            CharismaDataLabel.Text = charisma.ToString();
            
        }
        //creating Inventory List
        public List<string> InventoryList = new List<string>();
        public void LoadInventory()
        {
            var inventory = File.ReadAllLines("../../Data/inventory.txt");

            var InventoryList = new List<string>(inventory);
        }
        //CharacterGenertaorFormLoadEvent
        private void CharacterGeneratorForm_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }
        public void GenerateRandomInventory()
        {
            Random InvRnd1 = new Random();
            int inx1 = InvRnd1.Next(5,20); 
            InventoryLabel1.Text = InventoryList[2];
            
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            
        }

        private void GenerateInventoryButton_Click(object sender, EventArgs e)
        {
            GenerateRandomInventory();
        }

        

    }
}
