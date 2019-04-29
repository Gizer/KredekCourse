using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArkadiuszCichylab1HomeWork
{
    public partial class FormMain : Form
    {
        // Resorces amount
        private int wood = 20;

        private int stone = 0;
        private int gems = 0;
        private int food = 20;
        private int money = 100;

        // Special resource that will not have continous income
        private int deficiency;

        //Resources income
        private int woodIncome = 0;

        private int stoneIncome = 0;
        private int gemsIncome = 0;
        private int foodIncome = 0;
        private int moneyIncome = 0;

        // Turn counter
        private uint turnCounter = 0;

        // How many evil events there are
        private int numberOfEvilEvents = 4;

        // Object of Random that will be responsible for generating numbers for all random events
        private Random random = new Random();

        // Soundtrack for the game
        private System.Media.SoundPlayer player = new System.Media.SoundPlayer("Resources/sound/HoMM3main.wav");

        public FormMain()
        {
            InitializeComponent();

            // Starting timer for resources
            timerResources.Start();

            // Starting timer for evil events
            timerEvilEvents.Start();

            // Adding buildings to the comoboBoxBuildings
            comboBoxBuildings.Items.Add("Tartak");
            comboBoxBuildings.Items.Add("Kamieniołom");
            comboBoxBuildings.Items.Add("Kopalnia");
            comboBoxBuildings.Items.Add("Farma");
            comboBoxBuildings.Items.Add("Rozbudowa zamku");

            // Playing soundtack
            player.PlayLooping();
        }

        /// <summary>
        /// Every tick, income and lucky events will be added to resources.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerResources_Tick(object sender, EventArgs e)
        {
            // Calling function that updates incomes
            UpdateIncomes();

            // Adding incomes and lucky events to resources
            wood += woodIncome;
            stone += stoneIncome;
            if (stoneIncome > 0 && random.Next(1, 100) < 10)
                ++gems;
            gems += gemsIncome;
            food += foodIncome;
            money += moneyIncome;

            // Adding colors to indicate income state. Green = gain, black = no income, red = loss
            ChangeIncomeColor();

            // Updating all resource labels
            UpdateResourceLabels();

            // Counting and displaying how many turns passed
            ++turnCounter;
            labelTurnCount.Text = turnCounter.ToString();

            // End-game condiitons
            if (deficiency > 11)
            {
                timerResources.Stop();
                MessageBox.Show("Uwaliłeś.\r\n\r\nKoniec gry.");
                Close();
            }
            else if (food < 1)
            {
                timerResources.Stop();
                MessageBox.Show("Twoim poddanym skończyły się zupki chińskie. Królestwo cierpi głód.\r\n\r\nKoniec gry.");
                Close();
            }
        }

        /// <summary>
        /// Updating colors of resource labels to match state of income. Green = gain, black = no income, red = loss
        /// </summary>
        private void ChangeIncomeColor()
        {
            if (woodIncome > 0) // If wood income is positive
                labelWoodNumber.ForeColor = Color.Green;
            else if (woodIncome < 0) // If wood income is negative
                labelWoodNumber.ForeColor = Color.Red;
            else // If there is no wood income
                labelWoodNumber.ForeColor = Color.Black;

            if (stoneIncome > 0)
                labelStoneNumber.ForeColor = Color.Green;
            else if (stoneIncome < 0)
                labelStoneNumber.ForeColor = Color.Red;
            else
                labelStoneNumber.ForeColor = Color.Black;

            if (gemsIncome > 0)
                labelGemsNumber.ForeColor = Color.Green;
            else if (gemsIncome < 0)
                labelGemsNumber.ForeColor = Color.Red;
            else
                labelGemsNumber.ForeColor = Color.Black;

            if (foodIncome > 0)
                labelFoodNumber.ForeColor = Color.Green;
            else if (foodIncome < 0)
                labelFoodNumber.ForeColor = Color.Red;
            else
                labelFoodNumber.ForeColor = Color.Black;

            if (moneyIncome > 0)
                labelMoneyNumber.ForeColor = Color.Green;
            else if (moneyIncome < 0)
                labelMoneyNumber.ForeColor = Color.Red;
            else
                labelMoneyNumber.ForeColor = Color.Black;
        }

        /// <summary>
        /// Function that updates incomes of the player
        /// </summary>
        private void UpdateIncomes()
        {
            // Calculating incomes
            woodIncome = Sawmill.GetBaseProduction() * Sawmill.GetSawmillsCount();
            stoneIncome = Quarry.GetBaseProduction() * Quarry.GetQuarriesCount();
            gemsIncome = Mine.GetBaseProduction() * Mine.GetMinesCount();
            // Food income depends on how many other buildings player has
            foodIncome = Farm.GetBaseProduction() * Farm.GetFarmsCount() -
                (Quarry.GetFoodIncomeCost() + Mine.GetFoodIncomeCost() + Castle.GetFoodIncomeCost());
            moneyIncome = 10 + Castle.GetBaseProduction();
        }

        /// <summary>
        /// Function that updates text in resource labels
        /// </summary>
        private void UpdateResourceLabels()
        {
            labelWoodNumber.Text = wood.ToString();
            labelStoneNumber.Text = stone.ToString();
            labelGemsNumber.Text = gems.ToString();
            labelFoodNumber.Text = food.ToString();
            labelMoneyNumber.Text = money.ToString();
            labelDeficiencyNumber.Text = deficiency.ToString();
        }

        /// <summary>
        /// Function that updates text in buildings labels
        /// </summary>
        private void UpdateBuildingsCountLabels()
        {
            labelSawmillCount.Text = Sawmill.GetSawmillsCount().ToString();
            labelQuarriesCount.Text = Quarry.GetQuarriesCount().ToString();
            labelMinesCount.Text = Mine.GetMinesCount().ToString();
            labelFarmsCount.Text = Farm.GetFarmsCount().ToString();
            labelCastleLevel.Text = Castle.GetLevel().ToString();
        }

        /// <summary>
        /// If possible, selected building will be built
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            Build();

            // Hide menu for building/destroying many buildings
            labelQuantity.Visible = false;
            textBoxQuantity.Visible = false;
            buttonBuildMany.Visible = false;
            buttonDestroyMany.Visible = false;
        }

        /// <summary>
        /// Function that takes care of building proper building
        /// </summary>
        private void Build()
        {
            // Getting selected item from comboBox
            string chosedOption = comboBoxBuildings.SelectedItem.ToString();
            switch (chosedOption) // Depending on chosed item, propper building procedure will begin
            {
                case "Tartak":
                    if (Sawmill.ResourceCheck(ref wood, ref money))
                    {
                        Sawmill.Build();
                    }
                    else
                    {
                        MessageBox.Show("Nie posiadasz odpowiedniej liczby surowców");
                    }
                    break;

                case "Kamieniołom":
                    if (Quarry.ResourceCheck(ref wood, ref money))
                    {
                        Quarry.Build();
                    }
                    else
                    {
                        MessageBox.Show("Nie posiadasz odpowiedniej liczby surowców");
                    }
                    break;

                case "Kopalnia":
                    if (Mine.ResourcesCheck(ref wood, ref stone, ref money))
                    {
                        Mine.Build();
                    }
                    else
                    {
                        MessageBox.Show("Nie posiadasz odpowiedniej liczby surowców");
                    }
                    break;

                case "Farma":
                    if (Farm.ResourceCheck(ref wood, ref money))
                    {
                        Farm.Build();
                    }
                    else
                    {
                        MessageBox.Show("Nie posiadasz odpowiedniej liczby surowców");
                    }
                    break;

                case "Rozbudowa zamku":
                    if (Castle.ResourceCheck(ref wood, ref stone, ref gems, ref money))
                    {
                        Castle.Build();
                        if (Castle.GetLevel() < 5)
                        {
                            Bitmap image = new Bitmap("Resources/img/castle" + Castle.GetLevel().ToString() + ".png"); // Loading new images for specific level of upgrade. There is 4 levels, but you can build more
                            pictureBoxCastle.Image = image; // Assigning image to pictureBox
                        }
                        labelCost.Text = Castle.GetCost(); // Updating label
                    }
                    else
                    {
                        MessageBox.Show("Nie posiadasz odpowiedniej liczby surowców");
                    }
                    break;
            }
            UpdateIncomes();                // After building is done, there is need to update propper labels
            UpdateBuildingsCountLabels();
        }

        /// <summary>
        /// Change labelCost content when new item was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxBuildings_SelectedValueChanged(object sender, EventArgs e)
        {
            // Getting selected item from comboBox
            string chosedOption = comboBoxBuildings.SelectedItem.ToString();
            switch (chosedOption) // Depending on selected item, propper cost will be displayed
            {
                case "Tartak":
                    labelCost.Text = "Koszt: " + Sawmill.GetCost();
                    break;

                case "Kamieniołom":
                    labelCost.Text = "Koszt: " + Quarry.GetCost();
                    break;

                case "Kopalnia":
                    labelCost.Text = "Koszt: " + Mine.GetCost();
                    break;

                case "Farma":
                    labelCost.Text = "Koszt: " + Farm.GetCost();
                    break;

                case "Rozbudowa zamku":
                    labelCost.Text = "Koszt: " + Castle.GetCost();
                    break;
            }

            // Showing build/destroy many menu
            labelQuantity.Visible = true;
            textBoxQuantity.Visible = true;
            buttonBuildMany.Visible = true;
            buttonDestroyMany.Visible = true;
        }

        /// <summary>
        /// Destroy selected building
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDestroy_Click(object sender, EventArgs e)
        {
            Destroy();

            // Hide menu for building/destroying many buildings
            labelQuantity.Visible = false;
            textBoxQuantity.Visible = false;
            buttonBuildMany.Visible = false;
            buttonDestroyMany.Visible = false;
        }

        /// <summary>
        /// Function that takes care of destroying propper building
        /// </summary>
        private void Destroy()
        {
            // Getting selected item from comboBox
            string chosedOption = comboBoxBuildings.SelectedItem.ToString();
            switch (chosedOption) // Depending on selected item, propper destroying procedure will began
            {
                case "Tartak":
                    if (Sawmill.GetSawmillsCount() > 0)
                    {
                        Sawmill.Destroy();
                        MessageBox.Show("Zburzono tartak");
                    }
                    else
                    {
                        MessageBox.Show("Nie masz tartaków");
                    }
                    break;

                case "Kamieniołom":
                    if (Quarry.GetQuarriesCount() > 0)
                    {
                        Quarry.Destroy();
                        MessageBox.Show("Zburzono kamieniołom");
                    }
                    else
                    {
                        MessageBox.Show("Nie masz kamieniołomów");
                    }
                    break;

                case "Kopalnia":
                    if (Mine.GetMinesCount() > 0)
                    {
                        Mine.Destroy();
                        MessageBox.Show("Zburzono kopalnię");
                    }
                    else
                    {
                        MessageBox.Show("Nie masz kopalni");
                    }
                    break;

                case "Farma":
                    if (Farm.GetFarmsCount() > 0)
                    {
                        Farm.Destroy();
                        MessageBox.Show("Zburzono farmę");
                    }
                    break;

                case "Rozbudowa zamku":
                    if (Castle.GetLevel() > 1)
                    {
                        Castle.Destroy();
                        if (Castle.GetLevel() < 5)
                        {
                            Bitmap image = new Bitmap("Resources/img/castle" + Castle.GetLevel().ToString() + ".png"); // Loading new images for specific level of upgrade. There is 4 levels, but you can build more
                            pictureBoxCastle.Image = image; // Assigning image to pictureBox
                        }
                        MessageBox.Show("Wyburzono część zamku");
                        labelCost.Text = Castle.GetCost(); //updating label
                    }
                    else
                    {
                        MessageBox.Show("Nie możesz zniszczyć zamku");
                    }
                    break;
            }
            UpdateIncomes();                // After demolition, there is need to update propper labels
            UpdateBuildingsCountLabels();
        }

        /// <summary>
        /// Speed up/Slow down game time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            // Checking in what state game is (normal or faster)
            if (timerResources.Interval == 2000)
            {
                timerResources.Interval = 500;
                timerEvilEvents.Interval = 1250;
                buttonSpeedUp.Text = "Zwolnij";
            }
            else
            {
                timerEvilEvents.Interval = 5000;
                timerResources.Interval = 2000;
                buttonSpeedUp.Text = "Przyspiesz";
            }
        }

        /// <summary>
        /// Every tick a number is drawn. There is 5% chance for evil event to happen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEvilEvents_Tick(object sender, EventArgs e)
        {
            timerEvilEvents.Stop(); // Stopping timer to avoid multiple bad events showing at once
            if (random.Next(1, 100) < 6)
            {
                switch (random.Next(0, numberOfEvilEvents + 1)) // Selecting what event will happen
                {
                    case 0:
                        MessageBox.Show("Twoją krainę spowiła ciemność. Przybył Dżanusz Biernut i uwalił całe Twoje królestwo." +
                            "\r\n\r\nDeficyt królestwa zwiększa się.");
                        ++deficiency;
                        break;

                    case 1:
                        MessageBox.Show("Uczelnia nie otworzyła wystarczającej liczby miejsc na kurs." +
                            "Pomimo wielu prób, Twoim poddanym nie udało się zapisać na zajęcia.\r\n\r\n" +
                            "Deficyt królestwa zwiększa się.");
                        ++deficiency;
                        break;

                    case 2:
                        MessageBox.Show("Prowadzący zmienił zasady zaliczenia dzień przed egzaminem." +
                            "Twoi poddani nie zdążyli zareagować.\r\n\r\n" +
                            "Deficyt królestwa zwiększa się.");
                        ++deficiency;
                        break;

                    case 3:
                        if (Castle.GetLevel() < 3)
                        {
                            MessageBox.Show("Na pobliskiej wyspie odbyła się celebracja nazwy dnia tygodnia." +
                                "Wydałeś pieniądze na zabawę.\r\n\r\n" +
                                "Ilość pieniędzy królestwa zmniejsza się. (-1000)");
                            money -= 1000;
                        }
                        break;

                    case 4:
                        if (Castle.GetLevel() < 2 && Farm.GetFarmsCount() > 0 && Sawmill.GetSawmillsCount() > 0)
                        {
                            MessageBox.Show("O nie! W domu studenckim Twoich poddanych wybuchł pożar!" +
                                "To nie jest fałszywy alarm.\r\n\r\n" +
                                "Utracono Farmę oraz Tartak.");
                            Farm.Destroy();
                            Sawmill.Destroy();
                        }
                        break;
                }
            }
            timerEvilEvents.Start();
            UpdateBuildingsCountLabels();
            UpdateResourceLabels();
        }

        /// <summary>
        /// Event when mouse is over textbox, text disapears (after additional checks)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxQuantity_MouseEnter(object sender, EventArgs e)
        {
            // If textbox is not null or white spaces and text equals "Liczba budynków", erase text
            if (!string.IsNullOrWhiteSpace(textBoxQuantity.Text) && textBoxQuantity.Text.Equals("Liczba budynków"))
                textBoxQuantity.Text = "";
        }

        /// <summary>
        /// Event when mouse leave textbox, text appears (after additional checks)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxQuantity_MouseLeave(object sender, EventArgs e)
        {
            // If textbox is null or white spaces and texbox is not selected, write text
            if (string.IsNullOrWhiteSpace(textBoxQuantity.Text) && !textBoxQuantity.Focused)
            {
                textBoxQuantity.Text = "Liczba budynków";
            }
        }

        /// <summary>
        /// When clicked, player could build many buildings at once
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuildMany_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxQuantity.Text, out int buildingsToBuild) && buildingsToBuild > 0) // Check if texbox has positive integer value. buildingsToBuild -> How many building player wants to build
            {
                while (buildingsToBuild > 0) // Calling build() function buildingToBuild number of times
                {
                    Build();
                    --buildingsToBuild;
                }

                // Hide menu for building/destroying many buildings
                labelQuantity.Visible = false;
                textBoxQuantity.Visible = false;
                buttonBuildMany.Visible = false;
                buttonDestroyMany.Visible = false;
            }
        }

        /// <summary>
        /// When clicked, player could destroy many building at once
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDestroyMany_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxQuantity.Text, out int buildingToDestroy) && buildingToDestroy > 0) // Check if texbox has positive integer value. buildingToDestroy -> How may buildings player wants to destroy
            {
                while (buildingToDestroy > 0) // Calling destroy() function buildingToDestroy number of times
                {
                    Destroy();
                    --buildingToDestroy;
                }

                // Hide menu for building/destroying many buildings
                labelQuantity.Visible = false;
                textBoxQuantity.Visible = false;
                buttonBuildMany.Visible = false;
                buttonDestroyMany.Visible = false;
            }
        }

        /// <summary>
        /// When clicked, player can stop or play music
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMusicStopPlay_Click(object sender, EventArgs e)
        {
            if (buttonMusicStopPlay.Text == "Stop soundtrack")
            {
                player.Stop();
                buttonMusicStopPlay.Text = "Play soundtrack";
            }
            else
            {
                player.PlayLooping();
                buttonMusicStopPlay.Text = "Stop soundtrack";
            }
        }
    }
}