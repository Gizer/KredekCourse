namespace ArkadiuszCichylab1HomeWork
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerResources = new System.Windows.Forms.Timer(this.components);
            this.labelResources = new System.Windows.Forms.Label();
            this.labelWood = new System.Windows.Forms.Label();
            this.labelWoodNumber = new System.Windows.Forms.Label();
            this.labelStone = new System.Windows.Forms.Label();
            this.labelStoneNumber = new System.Windows.Forms.Label();
            this.labelGems = new System.Windows.Forms.Label();
            this.labelGemsNumber = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelFoodNumber = new System.Windows.Forms.Label();
            this.labelDeficiency = new System.Windows.Forms.Label();
            this.labelDeficiencyNumber = new System.Windows.Forms.Label();
            this.labelBuildings = new System.Windows.Forms.Label();
            this.comboBoxBuildings = new System.Windows.Forms.ComboBox();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelMoneyNumber = new System.Windows.Forms.Label();
            this.buttonDestroy = new System.Windows.Forms.Button();
            this.pictureBoxSawmill = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuarry = new System.Windows.Forms.PictureBox();
            this.pictureBoxMine = new System.Windows.Forms.PictureBox();
            this.pictureBoxFarm = new System.Windows.Forms.PictureBox();
            this.pictureBoxCastle = new System.Windows.Forms.PictureBox();
            this.labelSawmillCount = new System.Windows.Forms.Label();
            this.labelQuarriesCount = new System.Windows.Forms.Label();
            this.labelMinesCount = new System.Windows.Forms.Label();
            this.labelFarmsCount = new System.Windows.Forms.Label();
            this.labelCastleLevel = new System.Windows.Forms.Label();
            this.labelTurnCount = new System.Windows.Forms.Label();
            this.buttonSpeedUp = new System.Windows.Forms.Button();
            this.timerEvilEvents = new System.Windows.Forms.Timer(this.components);
            this.labelTurn = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonBuildMany = new System.Windows.Forms.Button();
            this.buttonDestroyMany = new System.Windows.Forms.Button();
            this.labelSawmillQuantity = new System.Windows.Forms.Label();
            this.labelQuarriesQuantity = new System.Windows.Forms.Label();
            this.labelMinesQuantity = new System.Windows.Forms.Label();
            this.labelFarmsQuantity = new System.Windows.Forms.Label();
            this.labelCastleLvl = new System.Windows.Forms.Label();
            this.buttonMusicStopPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSawmill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCastle)).BeginInit();
            this.SuspendLayout();
            // 
            // timerResources
            // 
            this.timerResources.Interval = 2000;
            this.timerResources.Tick += new System.EventHandler(this.timerResources_Tick);
            // 
            // labelResources
            // 
            this.labelResources.AutoSize = true;
            this.labelResources.Location = new System.Drawing.Point(12, 9);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(45, 13);
            this.labelResources.TabIndex = 0;
            this.labelResources.Text = "Zasoby:";
            // 
            // labelWood
            // 
            this.labelWood.AutoSize = true;
            this.labelWood.Location = new System.Drawing.Point(13, 37);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(46, 13);
            this.labelWood.TabIndex = 1;
            this.labelWood.Text = "Drzewo:";
            // 
            // labelWoodNumber
            // 
            this.labelWoodNumber.AutoSize = true;
            this.labelWoodNumber.Location = new System.Drawing.Point(13, 54);
            this.labelWoodNumber.Name = "labelWoodNumber";
            this.labelWoodNumber.Size = new System.Drawing.Size(13, 13);
            this.labelWoodNumber.TabIndex = 2;
            this.labelWoodNumber.Text = "0";
            // 
            // labelStone
            // 
            this.labelStone.AutoSize = true;
            this.labelStone.Location = new System.Drawing.Point(73, 37);
            this.labelStone.Name = "labelStone";
            this.labelStone.Size = new System.Drawing.Size(45, 13);
            this.labelStone.TabIndex = 3;
            this.labelStone.Text = "Kamień:";
            // 
            // labelStoneNumber
            // 
            this.labelStoneNumber.AutoSize = true;
            this.labelStoneNumber.Location = new System.Drawing.Point(73, 54);
            this.labelStoneNumber.Name = "labelStoneNumber";
            this.labelStoneNumber.Size = new System.Drawing.Size(13, 13);
            this.labelStoneNumber.TabIndex = 4;
            this.labelStoneNumber.Text = "0";
            // 
            // labelGems
            // 
            this.labelGems.AutoSize = true;
            this.labelGems.Location = new System.Drawing.Point(133, 37);
            this.labelGems.Name = "labelGems";
            this.labelGems.Size = new System.Drawing.Size(44, 13);
            this.labelGems.TabIndex = 5;
            this.labelGems.Text = "Klejnoty";
            // 
            // labelGemsNumber
            // 
            this.labelGemsNumber.AutoSize = true;
            this.labelGemsNumber.Location = new System.Drawing.Point(133, 54);
            this.labelGemsNumber.Name = "labelGemsNumber";
            this.labelGemsNumber.Size = new System.Drawing.Size(13, 13);
            this.labelGemsNumber.TabIndex = 6;
            this.labelGemsNumber.Text = "0";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(193, 37);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(49, 13);
            this.labelFood.TabIndex = 7;
            this.labelFood.Text = "Jedzenie";
            // 
            // labelFoodNumber
            // 
            this.labelFoodNumber.AutoSize = true;
            this.labelFoodNumber.Location = new System.Drawing.Point(193, 54);
            this.labelFoodNumber.Name = "labelFoodNumber";
            this.labelFoodNumber.Size = new System.Drawing.Size(13, 13);
            this.labelFoodNumber.TabIndex = 8;
            this.labelFoodNumber.Text = "0";
            // 
            // labelDeficiency
            // 
            this.labelDeficiency.AutoSize = true;
            this.labelDeficiency.Location = new System.Drawing.Point(253, 37);
            this.labelDeficiency.Name = "labelDeficiency";
            this.labelDeficiency.Size = new System.Drawing.Size(40, 13);
            this.labelDeficiency.TabIndex = 9;
            this.labelDeficiency.Text = "Deficyt";
            // 
            // labelDeficiencyNumber
            // 
            this.labelDeficiencyNumber.AutoSize = true;
            this.labelDeficiencyNumber.Location = new System.Drawing.Point(253, 54);
            this.labelDeficiencyNumber.Name = "labelDeficiencyNumber";
            this.labelDeficiencyNumber.Size = new System.Drawing.Size(13, 13);
            this.labelDeficiencyNumber.TabIndex = 10;
            this.labelDeficiencyNumber.Text = "0";
            // 
            // labelBuildings
            // 
            this.labelBuildings.AutoSize = true;
            this.labelBuildings.Location = new System.Drawing.Point(12, 144);
            this.labelBuildings.Name = "labelBuildings";
            this.labelBuildings.Size = new System.Drawing.Size(45, 13);
            this.labelBuildings.TabIndex = 11;
            this.labelBuildings.Text = "Budynki";
            // 
            // comboBoxBuildings
            // 
            this.comboBoxBuildings.FormattingEnabled = true;
            this.comboBoxBuildings.Location = new System.Drawing.Point(16, 160);
            this.comboBoxBuildings.Name = "comboBoxBuildings";
            this.comboBoxBuildings.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuildings.TabIndex = 12;
            this.comboBoxBuildings.SelectedValueChanged += new System.EventHandler(this.comboBoxBuildings_SelectedValueChanged);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(15, 223);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(78, 23);
            this.buttonBuild.TabIndex = 13;
            this.buttonBuild.Text = "Zbuduj jeden";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCost.Location = new System.Drawing.Point(13, 194);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(47, 17);
            this.labelCost.TabIndex = 14;
            this.labelCost.Text = "Koszt:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(313, 37);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(53, 13);
            this.labelMoney.TabIndex = 15;
            this.labelMoney.Text = "Pieniądze";
            // 
            // labelMoneyNumber
            // 
            this.labelMoneyNumber.AutoSize = true;
            this.labelMoneyNumber.Location = new System.Drawing.Point(316, 54);
            this.labelMoneyNumber.Name = "labelMoneyNumber";
            this.labelMoneyNumber.Size = new System.Drawing.Size(13, 13);
            this.labelMoneyNumber.TabIndex = 16;
            this.labelMoneyNumber.Text = "0";
            // 
            // buttonDestroy
            // 
            this.buttonDestroy.Location = new System.Drawing.Point(99, 223);
            this.buttonDestroy.Name = "buttonDestroy";
            this.buttonDestroy.Size = new System.Drawing.Size(81, 23);
            this.buttonDestroy.TabIndex = 17;
            this.buttonDestroy.Text = "Zniszcz jeden";
            this.buttonDestroy.UseVisualStyleBackColor = true;
            this.buttonDestroy.Click += new System.EventHandler(this.buttonDestroy_Click);
            // 
            // pictureBoxSawmill
            // 
            this.pictureBoxSawmill.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSawmill.Image")));
            this.pictureBoxSawmill.Location = new System.Drawing.Point(16, 303);
            this.pictureBoxSawmill.Name = "pictureBoxSawmill";
            this.pictureBoxSawmill.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxSawmill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSawmill.TabIndex = 18;
            this.pictureBoxSawmill.TabStop = false;
            // 
            // pictureBoxQuarry
            // 
            this.pictureBoxQuarry.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuarry.Image")));
            this.pictureBoxQuarry.Location = new System.Drawing.Point(122, 303);
            this.pictureBoxQuarry.Name = "pictureBoxQuarry";
            this.pictureBoxQuarry.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxQuarry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuarry.TabIndex = 19;
            this.pictureBoxQuarry.TabStop = false;
            // 
            // pictureBoxMine
            // 
            this.pictureBoxMine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMine.Image")));
            this.pictureBoxMine.Location = new System.Drawing.Point(228, 303);
            this.pictureBoxMine.Name = "pictureBoxMine";
            this.pictureBoxMine.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxMine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMine.TabIndex = 20;
            this.pictureBoxMine.TabStop = false;
            // 
            // pictureBoxFarm
            // 
            this.pictureBoxFarm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFarm.Image")));
            this.pictureBoxFarm.Location = new System.Drawing.Point(335, 303);
            this.pictureBoxFarm.Name = "pictureBoxFarm";
            this.pictureBoxFarm.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFarm.TabIndex = 21;
            this.pictureBoxFarm.TabStop = false;
            // 
            // pictureBoxCastle
            // 
            this.pictureBoxCastle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCastle.Image")));
            this.pictureBoxCastle.Location = new System.Drawing.Point(442, 303);
            this.pictureBoxCastle.Name = "pictureBoxCastle";
            this.pictureBoxCastle.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCastle.TabIndex = 22;
            this.pictureBoxCastle.TabStop = false;
            // 
            // labelSawmillCount
            // 
            this.labelSawmillCount.AutoSize = true;
            this.labelSawmillCount.Location = new System.Drawing.Point(66, 410);
            this.labelSawmillCount.Name = "labelSawmillCount";
            this.labelSawmillCount.Size = new System.Drawing.Size(13, 13);
            this.labelSawmillCount.TabIndex = 23;
            this.labelSawmillCount.Text = "0";
            // 
            // labelQuarriesCount
            // 
            this.labelQuarriesCount.AutoSize = true;
            this.labelQuarriesCount.Location = new System.Drawing.Point(193, 410);
            this.labelQuarriesCount.Name = "labelQuarriesCount";
            this.labelQuarriesCount.Size = new System.Drawing.Size(13, 13);
            this.labelQuarriesCount.TabIndex = 24;
            this.labelQuarriesCount.Text = "0";
            // 
            // labelMinesCount
            // 
            this.labelMinesCount.AutoSize = true;
            this.labelMinesCount.Location = new System.Drawing.Point(285, 410);
            this.labelMinesCount.Name = "labelMinesCount";
            this.labelMinesCount.Size = new System.Drawing.Size(13, 13);
            this.labelMinesCount.TabIndex = 25;
            this.labelMinesCount.Text = "0";
            // 
            // labelFarmsCount
            // 
            this.labelFarmsCount.AutoSize = true;
            this.labelFarmsCount.Location = new System.Drawing.Point(382, 410);
            this.labelFarmsCount.Name = "labelFarmsCount";
            this.labelFarmsCount.Size = new System.Drawing.Size(13, 13);
            this.labelFarmsCount.TabIndex = 26;
            this.labelFarmsCount.Text = "0";
            // 
            // labelCastleLevel
            // 
            this.labelCastleLevel.AutoSize = true;
            this.labelCastleLevel.Location = new System.Drawing.Point(523, 410);
            this.labelCastleLevel.Name = "labelCastleLevel";
            this.labelCastleLevel.Size = new System.Drawing.Size(13, 13);
            this.labelCastleLevel.TabIndex = 27;
            this.labelCastleLevel.Text = "1";
            // 
            // labelTurnCount
            // 
            this.labelTurnCount.AutoSize = true;
            this.labelTurnCount.Location = new System.Drawing.Point(523, 37);
            this.labelTurnCount.Name = "labelTurnCount";
            this.labelTurnCount.Size = new System.Drawing.Size(13, 13);
            this.labelTurnCount.TabIndex = 28;
            this.labelTurnCount.Text = "0";
            // 
            // buttonSpeedUp
            // 
            this.buttonSpeedUp.Location = new System.Drawing.Point(442, 32);
            this.buttonSpeedUp.Name = "buttonSpeedUp";
            this.buttonSpeedUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeedUp.TabIndex = 29;
            this.buttonSpeedUp.Text = "Przyspiesz";
            this.buttonSpeedUp.UseVisualStyleBackColor = true;
            this.buttonSpeedUp.Click += new System.EventHandler(this.buttonSpeedUp_Click);
            // 
            // timerEvilEvents
            // 
            this.timerEvilEvents.Interval = 5000;
            this.timerEvilEvents.Tick += new System.EventHandler(this.timerEvilEvents_Tick);
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.Location = new System.Drawing.Point(510, 8);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(32, 13);
            this.labelTurn.TabIndex = 30;
            this.labelTurn.Text = "Tura:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(231, 161);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 31;
            this.textBoxQuantity.Text = "Liczba budynków";
            this.textBoxQuantity.Visible = false;
            this.textBoxQuantity.MouseEnter += new System.EventHandler(this.textBoxQuantity_MouseEnter);
            this.textBoxQuantity.MouseLeave += new System.EventHandler(this.textBoxQuantity_MouseLeave);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(231, 144);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(93, 13);
            this.labelQuantity.TabIndex = 32;
            this.labelQuantity.Text = "Liczba budynków:";
            this.labelQuantity.Visible = false;
            // 
            // buttonBuildMany
            // 
            this.buttonBuildMany.Location = new System.Drawing.Point(338, 160);
            this.buttonBuildMany.Name = "buttonBuildMany";
            this.buttonBuildMany.Size = new System.Drawing.Size(100, 23);
            this.buttonBuildMany.TabIndex = 33;
            this.buttonBuildMany.Text = "Zbuduj wiele";
            this.buttonBuildMany.UseVisualStyleBackColor = true;
            this.buttonBuildMany.Visible = false;
            this.buttonBuildMany.Click += new System.EventHandler(this.buttonBuildMany_Click);
            // 
            // buttonDestroyMany
            // 
            this.buttonDestroyMany.Location = new System.Drawing.Point(442, 160);
            this.buttonDestroyMany.Name = "buttonDestroyMany";
            this.buttonDestroyMany.Size = new System.Drawing.Size(100, 23);
            this.buttonDestroyMany.TabIndex = 34;
            this.buttonDestroyMany.Text = "Zniszcz wiele";
            this.buttonDestroyMany.UseVisualStyleBackColor = true;
            this.buttonDestroyMany.Visible = false;
            this.buttonDestroyMany.Click += new System.EventHandler(this.buttonDestroyMany_Click);
            // 
            // labelSawmillQuantity
            // 
            this.labelSawmillQuantity.AutoSize = true;
            this.labelSawmillQuantity.Location = new System.Drawing.Point(17, 410);
            this.labelSawmillQuantity.Name = "labelSawmillQuantity";
            this.labelSawmillQuantity.Size = new System.Drawing.Size(43, 13);
            this.labelSawmillQuantity.TabIndex = 35;
            this.labelSawmillQuantity.Text = "Tartaki:";
            // 
            // labelQuarriesQuantity
            // 
            this.labelQuarriesQuantity.AutoSize = true;
            this.labelQuarriesQuantity.Location = new System.Drawing.Point(114, 410);
            this.labelQuarriesQuantity.Name = "labelQuarriesQuantity";
            this.labelQuarriesQuantity.Size = new System.Drawing.Size(76, 13);
            this.labelQuarriesQuantity.TabIndex = 36;
            this.labelQuarriesQuantity.Text = "Kamieniołomy:";
            // 
            // labelMinesQuantity
            // 
            this.labelMinesQuantity.AutoSize = true;
            this.labelMinesQuantity.Location = new System.Drawing.Point(228, 410);
            this.labelMinesQuantity.Name = "labelMinesQuantity";
            this.labelMinesQuantity.Size = new System.Drawing.Size(51, 13);
            this.labelMinesQuantity.TabIndex = 37;
            this.labelMinesQuantity.Text = "Kopalnie:";
            // 
            // labelFarmsQuantity
            // 
            this.labelFarmsQuantity.AutoSize = true;
            this.labelFarmsQuantity.Location = new System.Drawing.Point(338, 410);
            this.labelFarmsQuantity.Name = "labelFarmsQuantity";
            this.labelFarmsQuantity.Size = new System.Drawing.Size(38, 13);
            this.labelFarmsQuantity.TabIndex = 38;
            this.labelFarmsQuantity.Text = "Farmy:";
            // 
            // labelCastleLvl
            // 
            this.labelCastleLvl.AutoSize = true;
            this.labelCastleLvl.Location = new System.Drawing.Point(442, 410);
            this.labelCastleLvl.Name = "labelCastleLvl";
            this.labelCastleLvl.Size = new System.Drawing.Size(78, 13);
            this.labelCastleLvl.TabIndex = 39;
            this.labelCastleLvl.Text = "Poziom zamku:";
            // 
            // buttonMusicStopPlay
            // 
            this.buttonMusicStopPlay.Location = new System.Drawing.Point(442, 78);
            this.buttonMusicStopPlay.Name = "buttonMusicStopPlay";
            this.buttonMusicStopPlay.Size = new System.Drawing.Size(100, 23);
            this.buttonMusicStopPlay.TabIndex = 40;
            this.buttonMusicStopPlay.Text = "Stop soundtrack";
            this.buttonMusicStopPlay.UseVisualStyleBackColor = true;
            this.buttonMusicStopPlay.Click += new System.EventHandler(this.buttonMusicStopPlay_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(557, 434);
            this.Controls.Add(this.buttonMusicStopPlay);
            this.Controls.Add(this.labelCastleLvl);
            this.Controls.Add(this.labelFarmsQuantity);
            this.Controls.Add(this.labelMinesQuantity);
            this.Controls.Add(this.labelQuarriesQuantity);
            this.Controls.Add(this.labelSawmillQuantity);
            this.Controls.Add(this.buttonDestroyMany);
            this.Controls.Add(this.buttonBuildMany);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.buttonSpeedUp);
            this.Controls.Add(this.labelTurnCount);
            this.Controls.Add(this.labelCastleLevel);
            this.Controls.Add(this.labelFarmsCount);
            this.Controls.Add(this.labelMinesCount);
            this.Controls.Add(this.labelQuarriesCount);
            this.Controls.Add(this.labelSawmillCount);
            this.Controls.Add(this.pictureBoxCastle);
            this.Controls.Add(this.pictureBoxFarm);
            this.Controls.Add(this.pictureBoxMine);
            this.Controls.Add(this.pictureBoxQuarry);
            this.Controls.Add(this.pictureBoxSawmill);
            this.Controls.Add(this.buttonDestroy);
            this.Controls.Add(this.labelMoneyNumber);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.comboBoxBuildings);
            this.Controls.Add(this.labelBuildings);
            this.Controls.Add(this.labelDeficiencyNumber);
            this.Controls.Add(this.labelDeficiency);
            this.Controls.Add(this.labelFoodNumber);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelGemsNumber);
            this.Controls.Add(this.labelGems);
            this.Controls.Add(this.labelStoneNumber);
            this.Controls.Add(this.labelStone);
            this.Controls.Add(this.labelWoodNumber);
            this.Controls.Add(this.labelWood);
            this.Controls.Add(this.labelResources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Heroes of Math and Keyboards 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSawmill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuarry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCastle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerResources;
        private System.Windows.Forms.Label labelResources;
        private System.Windows.Forms.Label labelWood;
        private System.Windows.Forms.Label labelWoodNumber;
        private System.Windows.Forms.Label labelStone;
        private System.Windows.Forms.Label labelStoneNumber;
        private System.Windows.Forms.Label labelGems;
        private System.Windows.Forms.Label labelGemsNumber;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelFoodNumber;
        private System.Windows.Forms.Label labelDeficiency;
        private System.Windows.Forms.Label labelDeficiencyNumber;
        private System.Windows.Forms.Label labelBuildings;
        private System.Windows.Forms.ComboBox comboBoxBuildings;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelMoneyNumber;
        private System.Windows.Forms.Button buttonDestroy;
        private System.Windows.Forms.PictureBox pictureBoxSawmill;
        private System.Windows.Forms.PictureBox pictureBoxQuarry;
        private System.Windows.Forms.PictureBox pictureBoxMine;
        private System.Windows.Forms.PictureBox pictureBoxFarm;
        private System.Windows.Forms.PictureBox pictureBoxCastle;
        private System.Windows.Forms.Label labelSawmillCount;
        private System.Windows.Forms.Label labelQuarriesCount;
        private System.Windows.Forms.Label labelMinesCount;
        private System.Windows.Forms.Label labelFarmsCount;
        private System.Windows.Forms.Label labelCastleLevel;
        private System.Windows.Forms.Label labelTurnCount;
        private System.Windows.Forms.Button buttonSpeedUp;
        private System.Windows.Forms.Timer timerEvilEvents;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonBuildMany;
        private System.Windows.Forms.Button buttonDestroyMany;
        private System.Windows.Forms.Label labelSawmillQuantity;
        private System.Windows.Forms.Label labelQuarriesQuantity;
        private System.Windows.Forms.Label labelMinesQuantity;
        private System.Windows.Forms.Label labelFarmsQuantity;
        private System.Windows.Forms.Label labelCastleLvl;
        private System.Windows.Forms.Button buttonMusicStopPlay;
    }
}

