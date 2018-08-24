﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner_Party_Planner
{
    public partial class Form : System.Windows.Forms.Form
    {
        private DinnerParty dinnerParty;

        public Form()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty() {NumberOfPeople = 5};
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();

        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyCheckBox.Checked);
            costLabel.Text = Cost.ToString("c");

        }

        private void Form_Load(object sender, EventArgs e)
        {
        }

        private void numberOfPeopleNumericUD_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int) numberOfPeopleNumericUD.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyCheckBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
