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

namespace Scoring_system_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayerTeamEntry_Click(object sender, EventArgs e)
        {





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Events_Click(object sender, EventArgs e)
        {

        }

        private void Scoring_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit2_Click(object sender, EventArgs e)
        {
            File.AppendAllLines("Player.txt", new string[] { txt_IndividualName2.Text });
            txt_IndividualName2.Text = "";
            MessageBox.Show("New Team player added");
            ShowTeamData();
        }
        void ShowTeamData()
        {
            NameList.Items.Clear();
            foreach (string line in File.ReadLines(@"Player.txt", Encoding.UTF8))
            {
                // process the line
                NameList.Items.Add(line);
            }
            NameList.Show();
        }



        private void btn_Submit1_Click(object sender, EventArgs e)
        {
            File.AppendAllLines("Player.txt", new string[] { txt_IndividualName1.Text });
            txt_IndividualName1.Text = "";
            MessageBox.Show("New player added");
            ShowPlayerData();

        }
        void ShowPlayerData()
        {
            NameList.Items.Clear();
            foreach (string line in File.ReadLines(@"Player.txt", Encoding.UTF8))
            {
                // process the line
                NameList.Items.Add(line);
            }
            NameList.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddEvent_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddScore_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Scores scr = new Scores();
                scr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_IndividualName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox_Team2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Event_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Event_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }



