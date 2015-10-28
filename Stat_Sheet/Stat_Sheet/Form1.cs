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
    public partial class Form1 : Form
    {

        int strength = 5;
        int dexterity = 5;
        int willpower = 5;
        int intellect = 5;
        int cunning = 5;
        int perception = 5;
        int meleeProwess = 5;
        int marksmanship = 5;
        int spellcasting = 5;
        int luck = 0;
        int pool = 50;
        bool focus = false;



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            stat_str.Text = strength.ToString();
            stat_dex.Text = dexterity.ToString();
            stat_will.Text = willpower.ToString();
            stat_int.Text = intellect.ToString();
            stat_cun.Text = cunning.ToString();
            stat_perc.Text = perception.ToString();
            stat_mp.Text = meleeProwess.ToString();
            stat_mm.Text = marksmanship.ToString();
            stat_sc.Text = spellcasting.ToString();
            stat_luck.Text = luck.ToString();
            stat_pool.Text = pool.ToString();

        }

        //Minus buttons below
        private void minus_str_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            strength = Minus_Stat(strength);

            stat_str.Text = strength.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_dex_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            dexterity = Minus_Stat(dexterity);

            stat_dex.Text = dexterity.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_will_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            willpower = Minus_Stat(willpower);

            stat_will.Text = willpower.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_int_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            intellect = Minus_Stat(intellect);

            stat_int.Text = intellect.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_cun_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            cunning = Minus_Stat(cunning);

            stat_cun.Text = cunning.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_perc_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            perception = Minus_Stat(perception);

            stat_perc.Text = perception.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_mp_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            meleeProwess = Minus_Stat(meleeProwess);

            stat_mp.Text = meleeProwess.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_mm_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            marksmanship = Minus_Stat(marksmanship);

            stat_mm.Text = marksmanship.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_sc_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            spellcasting = Minus_Stat(spellcasting);

            stat_sc.Text = spellcasting.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void minus_luck_Click(object sender, EventArgs e)
        {
            label_error.Text = null;
            if (luck > 0)
            {
                luck--;
                pool++;
            }
            else if (luck == 0)
            {
                label_error.Text = "Stat cannot go below 0!";
            }
            stat_luck.Text = luck.ToString();
            stat_pool.Text = pool.ToString();
        }

        //Plus buttons below
        private void plus_str_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            strength = Plus_Stat(strength);

            stat_str.Text = strength.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_dex_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            dexterity = Plus_Stat(dexterity);

            stat_dex.Text = dexterity.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_will_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            willpower = Plus_Stat(willpower);

            stat_will.Text = willpower.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_int_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            intellect = Plus_Stat(intellect);

            stat_int.Text = intellect.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_cun_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            cunning = Plus_Stat(cunning);

            stat_cun.Text = cunning.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_perc_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            perception = Plus_Stat(perception);

            stat_perc.Text = perception.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_mp_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            meleeProwess = Plus_Stat(meleeProwess);

            stat_mp.Text = meleeProwess.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_mm_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            marksmanship = Plus_Stat(marksmanship);

            stat_mm.Text = marksmanship.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_sc_Click(object sender, EventArgs e)
        {
            label_error.Text = null;

            spellcasting = Plus_Stat(spellcasting);

            stat_sc.Text = spellcasting.ToString();
            stat_pool.Text = pool.ToString();
        }

        private void plus_luck_Click(object sender, EventArgs e)
        {
            label_error.Text = null;
            if (luck == 5)
            {
                label_error.Text = "Stat already maxed!"; //stat max
            }
            else if (luck < 5 && pool >= 1)
            {
                luck++;
                pool--;
            }
            else if (luck < 5 && pool == 0)
            {
                label_error.Text = "Not enough points!"; //not enough points
            }
            stat_luck.Text = luck.ToString();
            stat_pool.Text = pool.ToString();
        }


        //error label
        private void label_error_Click(object sender, EventArgs e)
        {
            label_error.Text = null;
        }

        private int Plus_Stat (int stat)
        {
            if (stat < 20 && stat > 15 && pool >= 2)
            {
                stat++;
                pool = pool - 2;
            }
            else if (stat == 15 && pool >= 2 && focus == false)
            {
                stat++;
                pool = pool - 2;
                focus = true;
            }
            else if (stat < 15 && pool >= 1)
            {
                stat++;
                pool--;
            }
            else if ((stat >= 15 && pool < 2) || pool == 0)
            {
                label_error.Text = "Not enough points!"; //not enough points
            }
            else if (stat == 20)
            {
                label_error.Text = "Stat already maxed!"; //stat maxed
            }
            else if (stat == 15 && focus == true)
            {
                label_error.Text = "Only one stat can go above 15!"; //focus already chosen
            }
            return stat;
        }

        private int Minus_Stat (int stat)
        {
            if (stat > 16)
            {
                stat--;
                pool = pool + 2;
            }
            else if (stat == 16)
            {
                stat--;
                pool = pool + 2;
                focus = false;
            }
            else if (stat > 5 && stat <= 15)
            {
                stat--;
                pool++;
            }
            else if (stat == 5)
            {
                label_error.Text = "Stat cannot go below 5!";
            }
            return stat;
        }

        private void next_page_Click(object sender, EventArgs e)
        {
            FormProvider.PerkMenu.Show();
            FormProvider.MainMenu.Hide();
        }

        public int Str
        {
            get { return strength; }
        }
        public int Dex
        {
            get { return dexterity; }
        }
        public int Will
        {
            get { return willpower; }
        }
        public int Int
        {
            get { return intellect; }
        }
        public int Cunn
        {
            get { return cunning; }
        }
        public int Perc
        {
            get { return perception; }
        }
        public int MP
        {
            get { return meleeProwess; }
        }
        public int MM
        {
            get { return marksmanship; }
        }
        public int SC
        {
            get { return spellcasting; }
        }
        public int Luck
        {
            get { return luck; }
        }


    }
}
