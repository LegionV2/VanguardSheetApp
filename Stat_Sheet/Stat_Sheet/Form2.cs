using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stat_Sheet
{
    public partial class Form2 : Form
    {
        String perk1Name;
        String perk1Desc;

        String perk2Name;
        String perk2Desc;

        String perkOPName;
        String perkOPDesc;

        String[] sheetLines = new String[26];

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void On_Close(object sender, FormClosedEventArgs e)
        {
            FormProvider.MainMenu.Close();
        }

        private void Previous_Page_Click(object sender, EventArgs e)
        {
            FormProvider.MainMenu.Show();
            FormProvider.PerkMenu.Hide();    
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            sheetLines[0] = "Physical Skills";
            sheetLines[1] = String.Format("Strength: {0}\n",FormProvider.MainMenu.Str);
            sheetLines[2] = String.Format("Dexterity: {0}\n", FormProvider.MainMenu.Dex);
            sheetLines[3] = " ";
            sheetLines[4] = "Mental Skills";
            sheetLines[5] = String.Format("Willpower: {0}\n", FormProvider.MainMenu.Will);
            sheetLines[6] = String.Format("Intellect: {0}\n", FormProvider.MainMenu.Int);
            sheetLines[7] = String.Format("Cunning: {0}\n", FormProvider.MainMenu.Cunn);
            sheetLines[8] = String.Format("Perception: {0}\n", FormProvider.MainMenu.Perc);
            sheetLines[9] = " ";
            sheetLines[10] = "Combat Skills";
            sheetLines[11] = String.Format("Melee Prowess: {0}\n", FormProvider.MainMenu.MP);
            sheetLines[12] = String.Format("Marksmanship: {0}\n", FormProvider.MainMenu.MM);
            sheetLines[13] = String.Format("Spellcasting: {0}\n", FormProvider.MainMenu.SC);
            sheetLines[14] = " ";
            sheetLines[15] = "Other";
            sheetLines[16] = String.Format("Luck: {0}\n", FormProvider.MainMenu.Luck);
            sheetLines[17] = " ";
            sheetLines[18] = perk1Name;
            sheetLines[19] = perk1Desc;
            sheetLines[20] = " ";
            sheetLines[21] = perk2Name;
            sheetLines[22] = perk2Desc;
            sheetLines[23] = " ";
            sheetLines[24] = perkOPName;
            sheetLines[25] = perkOPDesc;

            System.IO.File.WriteAllLines(@"C:\Users\Public\WriteLines.txt", sheetLines);
        }

        // textfield updates
        private void perk1_name_TextChanged(object sender, EventArgs e)
        {
            perk1Name = perk1_name.Text;
        }

        private void perk1_desc_TextChanged(object sender, EventArgs e)
        {
            perk1Desc = perk1_desc.Text;
        }


        private void perk2_name_TextChanged(object sender, EventArgs e)
        {
            perk2Name = perk2_name.Text;
        }

        private void perk2_desc_TextChanged(object sender, EventArgs e)
        {
            perk2Desc = perk2_desc.Text;
        }


        private void perkOP_name_TextChanged(object sender, EventArgs e)
        {
            perkOPName = perkOP_name.Text;
        }

        private void perkOP_desc_TextChanged(object sender, EventArgs e)
        {
            perkOPDesc = perkOP_desc.Text;
        }
    }
}
