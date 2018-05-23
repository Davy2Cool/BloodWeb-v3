using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Blood_Web_V3
{
    public partial class Form2 : Form
    {
        ExploitAPI api = new ExploitAPI();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.DoBlockHead(player);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.TeleportMyCharacterTo(player);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.AddFire(player);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.ConsoleWarn(player);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.SetWalkSpeed(player);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.AddSparkles(player);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.AddSmoke(player);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            api.SetJumpPower();
        }

        private void button26_Click(object sender, EventArgs e)
        { 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.SendLimitedLuaScript("game.Players." + player + ".Character.Humanoid.MaxHealth = math.huge");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            api.DoKill();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.DoKill(player);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.RemoveFire(player);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.SendLimitedLuaScript("game.Workspace." + player + ".Torso.Anchored = true");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.SendLimitedLuaScript("game.Workspace." + player + " Torso.Anchored = false");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.CreateForceField(player);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.RemoveLimbs(player);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.DoFloat(player);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.DoNoFloat(player);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string player = textBox1.Text;
            api.DoBTools(player);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
           
        }
    }
}
