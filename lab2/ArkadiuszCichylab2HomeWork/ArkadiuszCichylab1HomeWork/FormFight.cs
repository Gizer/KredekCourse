using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArkadiuszCichyLab2Homework.Units;
using ArkadiuszCichylab1HomeWork;

namespace ArkadiuszCichyLab2Homework
{
    /// <summary>
    /// Fight window
    /// </summary>
    public partial class FormFight : Form
    {
        /// <summary>
        /// List of player units obtained from FormMain
        /// </summary>
        private static List<Unit> playerUnits;

        /// <summary>
        /// List of occupied points. Used during units setup
        /// </summary>
        private List<Point> occupiedPoints = new List<Point>();

        /// <summary>
        /// Enemy unit
        /// </summary>
        private Boss evilUnit;

        /// <summary>
        /// Chosen unit
        /// </summary>
        private Unit currentUnit;

        /// <summary>
        /// Three variables that help to chose propper action
        /// </summary>
        private bool ableToChangeSelection = true; // due to dgv.ClearSelection(), this variable blocks program from chosing an action

        private bool playersTurn = true;
        private bool toFar = false;

        /// <summary>
        /// Random number generator
        /// </summary>
        private Random random = new Random();

        public FormFight(FormMain form)
        {
            InitializeComponent();

            this.Text = "Egzamin";

            // New soundtrack setup
            FormMain.player = new System.Media.SoundPlayer("Resources/sound/Combat.wav");
            FormMain.player.PlayLooping();

            // Obtaining player units
            playerUnits = FormMain.GetPlayerUnits();

            // Generating enemy
            evilUnit = new Boss(FormMain.winCount, random.Next(1, 4));
            evilUnit.Move(11, random.Next(4, 6));

            // Setting up DataGridView
            for (int i = 0; i < 12; i++)
            {
                // New image columns with grass image on default
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageColumn.Image = new Bitmap("Resources/img/units/grass.png");
                dataGridViewBattlefield.Columns.Add(imageColumn);
            }
            for (int i = 0; i < 6; i++)
            {
                dataGridViewBattlefield.Rows.Add();
            }

            // Chosing place for player units
            foreach (Unit unit in playerUnits)
            {
                bool isOccupied = true;
                while (isOccupied)
                {
                    int rndy = random.Next(0, 6);
                    int rndx = random.Next(0, 2);
                    if (!occupiedPoints.Contains(new Point(rndx, rndy))) // Drawing unit position until position is not occupied
                    {
                        isOccupied = false;
                        unit.Move(rndx, rndy);
                        UpdateImage(unit);
                        occupiedPoints.Add(new Point(rndx, rndy));
                    }
                }
            }

            // Chosing place for enemy
            UpdateImage(evilUnit);
            occupiedPoints.Add(new Point(evilUnit.XPosition, evilUnit.YPosition));
        }

        /// <summary>
        /// Chosing propper action on SelectionChange. To be honest this could be done better.
        /// But i run out of time and due to bad first design, this method could be buggy and it is quite cpu heavy.
        /// It is working but for example, if after attack you click on enemy unit, it no longer shows boss info.
        /// To many hotfixes were applied to call that method succesful.
        /// I will try to fix that later, probaly after review
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewBattlefield_SelectionChanged(object sender, EventArgs e)
        {
            if (ableToChangeSelection == true || playersTurn == false)
            {
                if (playersTurn == true) // If player still has his/her turn
                {
                    if (IsAlly()) // if selected field was ally
                    {
                        currentUnit.ChangeState(2);
                        UpdateImage(currentUnit);
                        labelUnitInfo.Text = currentUnit.GetInfo();
                    }
                    else if (IsUnitEvil()) // if selected field has enemy
                    {
                        toFar = false;
                        if (currentUnit != null) // if player had unit selected. If yes, attack is initiated
                        {
                            if (currentUnit.ToString() != "Mage") // Mage have diffrent attack
                            {
                                if (IsInRange(currentUnit.AttackDistance)) // If enemy is in range of currentUnit
                                {
                                    Attack(evilUnit);
                                    ableToChangeSelection = false;
                                    playersTurn = false;
                                }
                                else
                                {
                                    textBoxBattleLog.Text += "Cel jest za daleko.\r\n";
                                    toFar = true;
                                    currentUnit.ChangeState(0);
                                    UpdateImage(currentUnit);
                                }
                            }
                            else
                            {
                                Mage mage = (Mage)currentUnit;
                                if (mage.ManaAttackThreshold <= mage.ManaPoints)
                                    if (IsInRange(currentUnit.AttackDistance))
                                    {
                                        Attack(evilUnit);
                                        ableToChangeSelection = false;
                                        playersTurn = false;
                                    }
                                    else
                                    {
                                        textBoxBattleLog.Text += "Cel jest za daleko.\r\n";
                                        toFar = true;
                                        currentUnit.ChangeState(0);
                                        UpdateImage(currentUnit);
                                    }
                                else
                                {
                                    textBoxBattleLog.Text += mage.ToString() + " ma za mało many.\r\n";
                                    toFar = true;
                                    currentUnit.ChangeState(0);
                                    UpdateImage(currentUnit);
                                }
                            }
                        }
                        labelUnitInfo.Text = evilUnit.GetInfo();
                        if (!evilUnit.IsAlive()) // Due to always having one enemy, it's death means that player wins
                        {
                            textBoxBattleLog.Text += evilUnit.ToString() + " został zabity.\r\n";
                            dataGridViewBattlefield.Rows[evilUnit.YPosition].Cells[evilUnit.XPosition].Value = new Bitmap("Resources/img/units/grass.png");
                            evilUnit = null;
                            MessageBox.Show("Zdałeś egzamin.\r\n\r\nWygrana.");
                            --FormMain.deficiency;
                            FormMain.playerUnits = playerUnits;
                            FormMain.player = new System.Media.SoundPlayer("Resources/sound/HoMM3main.wav");
                            FormMain.player.PlayLooping();
                            ++FormMain.winCount;
                            toFar = true;
                            foreach (Unit unit in playerUnits)
                            {
                                unit.Heal();
                                unit.LevelUp();
                            }
                            this.Close();
                        }
                        // After fight clean up
                        ReplaceGrass(true);
                        currentUnit = null;
                        if (toFar == false)
                            dataGridViewBattlefield.ClearSelection();
                    }
                    else // if selected field is grass
                    {
                        if (currentUnit != null)
                        {
                            ReplaceGrass(true);
                            if (IsInRange(currentUnit.MoveDistance))
                            {
                                // Moving player procedure. Updating both playerUnit and occupiedPoints lists and image of unit
                                occupiedPoints.Remove(new Point(currentUnit.XPosition, currentUnit.YPosition));
                                playerUnits.Remove(currentUnit);
                                dataGridViewBattlefield.Rows[currentUnit.YPosition].Cells[currentUnit.XPosition].Value = new Bitmap("Resources/img/units/grass.png");
                                currentUnit.Move(dataGridViewBattlefield.SelectedCells[0].ColumnIndex, dataGridViewBattlefield.SelectedCells[0].RowIndex);
                                playerUnits.Add(currentUnit);
                                occupiedPoints.Add(new Point(currentUnit.XPosition, currentUnit.YPosition));
                                dataGridViewBattlefield.Rows[currentUnit.YPosition].Cells[currentUnit.XPosition].Value = currentUnit.image;
                                playersTurn = false;
                            }
                            else
                            {
                                textBoxBattleLog.Text += "Nie możesz tam iść.\r\n";
                            }
                            currentUnit.ChangeState(0);
                            UpdateImage(currentUnit);
                            currentUnit = null;
                        }
                        else
                        {
                            labelUnitInfo.Text = "Nie wybrano jednostki.";
                        }
                        ableToChangeSelection = false;
                        dataGridViewBattlefield.ClearSelection();
                    }
                }
                else // Enemy's turn. For now, enemy can only attack
                {
                    currentUnit = evilUnit;
                    int rnd = random.Next(0, playerUnits.Count());
                    Attack(playerUnits.ElementAt(rnd)); // Attacking random unit
                    if (!playerUnits.ElementAt(rnd).IsAlive()) // If ally is killed
                    {
                        textBoxBattleLog.Text += playerUnits.ElementAt(rnd).ToString() + " został zabity.\r\n";
                        dataGridViewBattlefield.Rows[playerUnits.ElementAt(rnd).YPosition].Cells[playerUnits.ElementAt(rnd).XPosition].Value = new Bitmap("Resources/img/units/grass.png");
                        occupiedPoints.Remove(new Point(playerUnits.ElementAt(rnd).XPosition, playerUnits.ElementAt(rnd).YPosition));
                        playerUnits.RemoveAt(rnd);
                    }
                    currentUnit = null;
                    playersTurn = true;
                    ableToChangeSelection = true;
                    if (LoseConditionCheck() == true) // Check if player loses battle
                    {
                        MessageBox.Show("Straciłeś wszystkie jednoski.\r\n\r\nPrzegrywasz.");
                        ++FormMain.deficiency;
                        FormMain.playerUnits = playerUnits;
                        FormMain.player = new System.Media.SoundPlayer("Resources/sound/HoMM3main.wav");
                        FormMain.player.PlayLooping();
                        this.Close();
                    }
                }
            }
            else
                ableToChangeSelection = true;
        }

        /// <summary>
        /// When ally unit is selected, lights up fields that player can move on
        /// </summary>
        /// <param name="normalGrass">True = normal grass, False = highlighted grass</param>
        private void ReplaceGrass(bool normalGrass)
        {
            if (currentUnit != null)
                if (!normalGrass)
                {
                    for (int i = -currentUnit.MoveDistance; i <= currentUnit.MoveDistance; i++)
                    {
                        for (int j = -currentUnit.MoveDistance; j <= currentUnit.MoveDistance; j++)
                        {
                            // if field dont have unit on it
                            if (!occupiedPoints.Contains(new Point(currentUnit.XPosition + i, currentUnit.YPosition + j)))
                            {
                                // Distance calculation
                                if (Math.Sqrt(Math.Abs(i * i + j * j)) <= currentUnit.MoveDistance)
                                {
                                    try
                                    {
                                        dataGridViewBattlefield.Rows[currentUnit.YPosition + j].Cells[currentUnit.XPosition + i].Value = new Bitmap("Resources/img/units/grassMovable.png");
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = -currentUnit.MoveDistance; i <= currentUnit.MoveDistance; i++)
                    {
                        for (int j = -currentUnit.MoveDistance; j <= currentUnit.MoveDistance; j++)
                        {
                            if (!occupiedPoints.Contains(new Point(currentUnit.XPosition + i, currentUnit.YPosition + j)))
                            {
                                if (Math.Sqrt(Math.Abs(i * i + j * j)) <= currentUnit.MoveDistance)
                                {
                                    try
                                    {
                                        dataGridViewBattlefield.Rows[currentUnit.YPosition + j].Cells[currentUnit.XPosition + i].Value = new Bitmap("Resources/img/units/grass.png");
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                            }
                        }
                    }
                }
        }

        /// <summary>
        /// Check if player lost all units
        /// </summary>
        /// <returns>True if player lost</returns>
        private bool LoseConditionCheck()
        {
            if (playerUnits.Count == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Calculating distance
        /// </summary>
        /// <param name="givenDistance">Max distance range</param>
        /// <returns>True if calculated distance is less or equal to givenDistance</returns>
        private bool IsInRange(int givenDistance)
        {
            int dgvX = dataGridViewBattlefield.SelectedCells[0].ColumnIndex;
            int dgvY = dataGridViewBattlefield.SelectedCells[0].RowIndex;
            int squaredDistance = Math.Abs(((dgvX - currentUnit.XPosition) * (dgvX - currentUnit.XPosition)) + ((dgvY - currentUnit.YPosition) * (dgvY - currentUnit.YPosition)));
            double distance = Math.Sqrt(squaredDistance);
            //textBoxBattleLog.Text += distance.ToString() + "\r\n";
            if (distance <= givenDistance)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check if selected field has ally unit, and if so, change its state and surroundin grass
        /// </summary>
        /// <returns></returns>
        private bool IsAlly()
        {
            foreach (Unit unit in playerUnits)
                if (dataGridViewBattlefield.SelectedCells.Count != 0 && unit.XPosition == dataGridViewBattlefield.SelectedCells[0].ColumnIndex && unit.YPosition == dataGridViewBattlefield.SelectedCells[0].RowIndex)
                {
                    if (currentUnit != null)
                    {
                        currentUnit.ChangeState(0);
                        UpdateImage(currentUnit);
                        ReplaceGrass(true);
                    }
                    currentUnit = unit;
                    ReplaceGrass(false);
                    return true;
                }
            return false;
        }

        /// <summary>
        /// Is selected field grass
        /// </summary>
        /// <returns></returns>
        private bool IsGrass()
        {
            foreach (Unit unit in playerUnits)
                if (unit != currentUnit || (unit.XPosition != dataGridViewBattlefield.SelectedCells[0].ColumnIndex && unit.YPosition != dataGridViewBattlefield.SelectedCells[0].RowIndex))
                    return true;
            return false;
        }

        /// <summary>
        /// Check if selected field has evil unit on it
        /// </summary>
        /// <returns></returns>
        private bool IsUnitEvil()
        {
            if (dataGridViewBattlefield.SelectedCells.Count != 0 && evilUnit.XPosition == dataGridViewBattlefield.SelectedCells[0].ColumnIndex && evilUnit.YPosition == dataGridViewBattlefield.SelectedCells[0].RowIndex)
                return true;
            return false;
        }

        /// <summary>
        /// Attack unit, change states of both sides and update battle log
        /// </summary>
        /// <param name="unit">Unit that will be hitted</param>
        private void Attack(Unit unit)
        {
            unit.ChangeState(-1);
            UpdateImage(unit);
            currentUnit.ChangeState(1);
            UpdateImage(currentUnit);

            textBoxBattleLog.Text += currentUnit.ToString() + " zadał " + unit.ToString() + " " + unit.HittedByUnit(currentUnit.AttackValue) + " obrażeń\r\n";
            Thread.Sleep(1500);

            unit.ChangeState(0);
            UpdateImage(unit);
            currentUnit.ChangeState(0);
            UpdateImage(currentUnit);
        }

        /// <summary>
        /// Update image of given unit
        /// </summary>
        /// <param name="unit">Unit which image will be updated</param>
        private void UpdateImage(Unit unit)
        {
            dataGridViewBattlefield.Rows[unit.YPosition].Cells[unit.XPosition].Value = unit.image;
            dataGridViewBattlefield.Update();
        }

        /// <summary>
        /// Auto scrolling through battle log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxBattleLog_TextChanged(object sender, EventArgs e)
        {
            textBoxBattleLog.SelectionStart = textBoxBattleLog.Text.Length;
            textBoxBattleLog.ScrollToCaret();
        }

        /// <summary>
        /// Stop/Play soundtrack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopPlay_Click(object sender, EventArgs e)
        {
            if (buttonStopPlay.Text == "Stop soundtrack")
            {
                FormMain.player.Stop();
                buttonStopPlay.Text = "Start soundtrack";
            }
            else
            {
                FormMain.player.PlayLooping();
                buttonStopPlay.Text = "Stop soundtrack";
            }
        }
    }
}