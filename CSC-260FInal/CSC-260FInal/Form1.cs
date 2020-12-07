using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_260FInal
{
    public partial class Form1 : Form
    {
        You Your_character = new You("Billy");
        int init = 0;
   
        List<string> tuturial = new List<string>()
            {
                 "Welcome to this horrible mini rpg click next to continue",
                 "Over here you have your hp if that goes to 0 you die",
                "This bar has your current objective","This is where you can face of against enemies"

            };


        public Form1()
        {
            

            InitializeComponent();
            BattleText.Visible = false;
            EnemyHP.Visible = false;
            Return.Visible = false;
            HP.Visible = false;
            Battle.Visible = false;
            drone.Visible = false;
            HP.Text = "HP:";
            Quest.Visible = false;
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            switch (init)
            {
                case 0:
                    Quest.Visible = true;
                    start.Text = "Next";
                    Quest.Text = tuturial[init];
                    init++;
                    break;
                case 1:
                    HP.Visible = true;
                    Quest.Text = tuturial[init];
                    HP.Text = "HP:" + Your_character.hp;
                    init++;
                    break;
                case 2:
                    Quest.Text = tuturial[init];
                    init++;
                    break;
                case 3:
                    Quest.Text = tuturial[init];
                    Battle.Visible = true;
                    start.Visible = false;
                    break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Battle.Visible = false;
            start.Visible = true;
            Return.Visible = true;
            drone.Visible = true;
            
        }
        //drone battle
        private void button1_Click_1(object sender, EventArgs e)
        {
            Enemy Drone = new Enemy(1, Your_character.level);
            while (Drone.hp != 0 || Your_character.hp != 0)
            {
                Return.Visible = false;
                drone.Visible = false;
                BattleText.Visible = true;
                EnemyHP.Visible = true;
                EnemyHP.Text = "EnemyHP:" + Drone.hp;

           
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Return.Visible = false;
            Battle.Visible = true;
            drone.Visible = false;
        }

        private void EnemyHP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
