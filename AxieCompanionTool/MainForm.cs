using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxieCompanionTool.BOL;
using System.Configuration;
namespace AxieCompanionTool
{
    public partial class MainForm : Form
    {
        Resource _Energy;
        Resource _Cards;

        const int InitialEnergy = 3;
        const int InitialCard = 6;

        const int MaxEnergy = 10;
        const int MaxCard = 12;

        const int EnergyGainPerRound = 2;
        const int CardGainPerRound = 3;

        string CmdEnergyGain;
        string CmdEnergyLose;
        string CmdCardGain;
        string CmdCardLose;
        string CmdNewGame;
        string CmdNextRound;

        bool IsCapturingSetting;
        public MainForm()
        {
            _Energy = new Resource(MaxEnergy);
            _Cards = new Resource(MaxCard);

            // Get values from the config
            CmdEnergyGain = GetSetting("CmdGainEnergy", '8'.GetHashCode().ToString());
            CmdEnergyLose = GetSetting("CmdLoseEnergy", '2'.GetHashCode().ToString());
            CmdCardGain = GetSetting("CmdGainCard", '6'.GetHashCode().ToString());
            CmdCardLose = GetSetting("CmdLoseCard", '4'.GetHashCode().ToString());
            CmdNextRound = GetSetting("CmdNextRound", '7'.GetHashCode().ToString());
            CmdNewGame = GetSetting("CmdNewGame", '9'.GetHashCode().ToString());

            InitializeComponent();
        }

        private string GetSetting(string key, string defaultValue)
        {
            string setting = ConfigurationManager.AppSettings[key];
            return setting == "" ? defaultValue : setting;
        }

        private void ResetResource()
        {
            _Energy.Modify(InitialEnergy);
            _Cards.Modify(InitialCard);

            UpdateResourceUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetResource();

            TbWins.Text = "0";
            TbLoses.Text = "0";
            TbDraws.Text = "0";

            UpdateResourceUI();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            LblTest.Text = e.KeyChar.GetHashCode().ToString();

            string hashCode = e.KeyChar.GetHashCode().ToString();
            bool isExessive = false; // Implement on user inputs only

            if (hashCode == CmdEnergyGain)
            {
                isExessive = _Energy.Gain();
            }
            else if (hashCode == CmdEnergyLose)
            {
                isExessive = _Energy.Lose();
            }
            else if (hashCode == CmdCardGain)
            {
                isExessive = _Cards.Gain();
            }
            else if (hashCode == CmdCardLose)
            {
                isExessive = _Cards.Lose();
            }
            else if (hashCode == CmdNewGame)
            {
                ResetResource();
            }
            else if (hashCode == CmdNextRound)
            {
                _Energy.Gain(EnergyGainPerRound);
                _Cards.Gain(CardGainPerRound);
            }

            if (isExessive)
                System.Media.SystemSounds.Exclamation.Play();

            UpdateResourceUI();
        }

        private void UpdateResourceUI()
        {
            LblCards.Text = _Cards.Value().ToString();
            LblEnergy.Text = _Energy.Value().ToString();
        }

        private void AddWin(object sender, EventArgs e) => TbWins.Text = AddOne(TbWins.Text);

        private void AddLose(object sender, EventArgs e) => TbLoses.Text = AddOne(TbLoses.Text);

        private void AddDraw(object sender, EventArgs e) => TbDraws.Text = AddOne(TbDraws.Text);

        private string AddOne(string value)
        {
            if (int.TryParse(value, out int n))
            {
                return (n + 1).ToString();
            }
            else return "0";
        }
    }
}
