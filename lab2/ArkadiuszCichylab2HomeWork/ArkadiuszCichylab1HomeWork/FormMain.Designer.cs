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
            this.labelUnitBuyMenu = new System.Windows.Forms.Label();
            this.comboBoxBuyUnits = new System.Windows.Forms.ComboBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonFight = new System.Windows.Forms.Button();
            this.labelPlayerUnitsTitle = new System.Windows.Forms.Label();
            this.labelPlayerUnits = new System.Windows.Forms.Label();
            this.labelUnitCost = new System.Windows.Forms.Label();
            this.labelPassedExams = new System.Windows.Forms.Label();
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
            this.labelResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResources.Location = new System.Drawing.Point(12, 9);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(72, 20);
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
            this.labelStone.Location = new System.Drawing.Point(83, 37);
            this.labelStone.Name = "labelStone";
            this.labelStone.Size = new System.Drawing.Size(45, 13);
            this.labelStone.TabIndex = 3;
            this.labelStone.Text = "Kamień:";
            // 
            // labelStoneNumber
            // 
            this.labelStoneNumber.AutoSize = true;
            this.labelStoneNumber.Location = new System.Drawing.Point(83, 54);
            this.labelStoneNumber.Name = "labelStoneNumber";
            this.labelStoneNumber.Size = new System.Drawing.Size(13, 13);
            this.labelStoneNumber.TabIndex = 4;
            this.labelStoneNumber.Text = "0";
            // 
            // labelGems
            // 
            this.labelGems.AutoSize = true;
            this.labelGems.Location = new System.Drawing.Point(153, 37);
            this.labelGems.Name = "labelGems";
            this.labelGems.Size = new System.Drawing.Size(44, 13);
            this.labelGems.TabIndex = 5;
            this.labelGems.Text = "Klejnoty";
            // 
            // labelGemsNumber
            // 
            this.labelGemsNumber.AutoSize = true;
            this.labelGemsNumber.Location = new System.Drawing.Point(153, 54);
            this.labelGemsNumber.Name = "labelGemsNumber";
            this.labelGemsNumber.Size = new System.Drawing.Size(13, 13);
            this.labelGemsNumber.TabIndex = 6;
            this.labelGemsNumber.Text = "0";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(223, 37);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(49, 13);
            this.labelFood.TabIndex = 7;
            this.labelFood.Text = "Jedzenie";
            // 
            // labelFoodNumber
            // 
            this.labelFoodNumber.AutoSize = true;
            this.labelFoodNumber.Location = new System.Drawing.Point(223, 54);
            this.labelFoodNumber.Name = "labelFoodNumber";
            this.labelFoodNumber.Size = new System.Drawing.Size(13, 13);
            this.labelFoodNumber.TabIndex = 8;
            this.labelFoodNumber.Text = "0";
            // 
            // labelDeficiency
            // 
            this.labelDeficiency.AutoSize = true;
            this.labelDeficiency.Location = new System.Drawing.Point(293, 37);
            this.labelDeficiency.Name = "labelDeficiency";
            this.labelDeficiency.Size = new System.Drawing.Size(40, 13);
            this.labelDeficiency.TabIndex = 9;
            this.labelDeficiency.Text = "Deficyt";
            // 
            // labelDeficiencyNumber
            // 
            this.labelDeficiencyNumber.AutoSize = true;
            this.labelDeficiencyNumber.Location = new System.Drawing.Point(293, 54);
            this.labelDeficiencyNumber.Name = "labelDeficiencyNumber";
            this.labelDeficiencyNumber.Size = new System.Drawing.Size(13, 13);
            this.labelDeficiencyNumber.TabIndex = 10;
            this.labelDeficiencyNumber.Text = "0";
            // 
            // labelBuildings
            // 
            this.labelBuildings.AutoSize = true;
            this.labelBuildings.Location = new System.Drawing.Point(12, 89);
            this.labelBuildings.Name = "labelBuildings";
            this.labelBuildings.Size = new System.Drawing.Size(45, 13);
            this.labelBuildings.TabIndex = 11;
            this.labelBuildings.Text = "Budynki";
            // 
            // comboBoxBuildings
            // 
            this.comboBoxBuildings.FormattingEnabled = true;
            this.comboBoxBuildings.Location = new System.Drawing.Point(16, 105);
            this.comboBoxBuildings.Name = "comboBoxBuildings";
            this.comboBoxBuildings.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuildings.TabIndex = 12;
            this.comboBoxBuildings.SelectedValueChanged += new System.EventHandler(this.comboBoxBuildings_SelectedValueChanged);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(15, 168);
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
            this.labelCost.Location = new System.Drawing.Point(13, 139);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(47, 17);
            this.labelCost.TabIndex = 14;
            this.labelCost.Text = "Koszt:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(363, 37);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(53, 13);
            this.labelMoney.TabIndex = 15;
            this.labelMoney.Text = "Pieniądze";
            // 
            // labelMoneyNumber
            // 
            this.labelMoneyNumber.AutoSize = true;
            this.labelMoneyNumber.Location = new System.Drawing.Point(366, 54);
            this.labelMoneyNumber.Name = "labelMoneyNumber";
            this.labelMoneyNumber.Size = new System.Drawing.Size(13, 13);
            this.labelMoneyNumber.TabIndex = 16;
            this.labelMoneyNumber.Text = "0";
            // 
            // buttonDestroy
            // 
            this.buttonDestroy.Location = new System.Drawing.Point(99, 168);
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
            this.pictureBoxSawmill.Location = new System.Drawing.Point(12, 209);
            this.pictureBoxSawmill.Name = "pictureBoxSawmill";
            this.pictureBoxSawmill.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxSawmill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSawmill.TabIndex = 18;
            this.pictureBoxSawmill.TabStop = false;
            // 
            // pictureBoxQuarry
            // 
            this.pictureBoxQuarry.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuarry.Image")));
            this.pictureBoxQuarry.Location = new System.Drawing.Point(178, 209);
            this.pictureBoxQuarry.Name = "pictureBoxQuarry";
            this.pictureBoxQuarry.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxQuarry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuarry.TabIndex = 19;
            this.pictureBoxQuarry.TabStop = false;
            // 
            // pictureBoxMine
            // 
            this.pictureBoxMine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMine.Image")));
            this.pictureBoxMine.Location = new System.Drawing.Point(344, 209);
            this.pictureBoxMine.Name = "pictureBoxMine";
            this.pictureBoxMine.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxMine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMine.TabIndex = 20;
            this.pictureBoxMine.TabStop = false;
            // 
            // pictureBoxFarm
            // 
            this.pictureBoxFarm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFarm.Image")));
            this.pictureBoxFarm.Location = new System.Drawing.Point(510, 209);
            this.pictureBoxFarm.Name = "pictureBoxFarm";
            this.pictureBoxFarm.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFarm.TabIndex = 21;
            this.pictureBoxFarm.TabStop = false;
            // 
            // pictureBoxCastle
            // 
            this.pictureBoxCastle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCastle.Image")));
            this.pictureBoxCastle.Location = new System.Drawing.Point(676, 209);
            this.pictureBoxCastle.Name = "pictureBoxCastle";
            this.pictureBoxCastle.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCastle.TabIndex = 22;
            this.pictureBoxCastle.TabStop = false;
            // 
            // labelSawmillCount
            // 
            this.labelSawmillCount.AutoSize = true;
            this.labelSawmillCount.Location = new System.Drawing.Point(58, 372);
            this.labelSawmillCount.Name = "labelSawmillCount";
            this.labelSawmillCount.Size = new System.Drawing.Size(13, 13);
            this.labelSawmillCount.TabIndex = 23;
            this.labelSawmillCount.Text = "0";
            // 
            // labelQuarriesCount
            // 
            this.labelQuarriesCount.AutoSize = true;
            this.labelQuarriesCount.Location = new System.Drawing.Point(254, 372);
            this.labelQuarriesCount.Name = "labelQuarriesCount";
            this.labelQuarriesCount.Size = new System.Drawing.Size(13, 13);
            this.labelQuarriesCount.TabIndex = 24;
            this.labelQuarriesCount.Text = "0";
            // 
            // labelMinesCount
            // 
            this.labelMinesCount.AutoSize = true;
            this.labelMinesCount.Location = new System.Drawing.Point(398, 372);
            this.labelMinesCount.Name = "labelMinesCount";
            this.labelMinesCount.Size = new System.Drawing.Size(13, 13);
            this.labelMinesCount.TabIndex = 25;
            this.labelMinesCount.Text = "0";
            // 
            // labelFarmsCount
            // 
            this.labelFarmsCount.AutoSize = true;
            this.labelFarmsCount.Location = new System.Drawing.Point(551, 372);
            this.labelFarmsCount.Name = "labelFarmsCount";
            this.labelFarmsCount.Size = new System.Drawing.Size(13, 13);
            this.labelFarmsCount.TabIndex = 26;
            this.labelFarmsCount.Text = "0";
            // 
            // labelCastleLevel
            // 
            this.labelCastleLevel.AutoSize = true;
            this.labelCastleLevel.Location = new System.Drawing.Point(754, 372);
            this.labelCastleLevel.Name = "labelCastleLevel";
            this.labelCastleLevel.Size = new System.Drawing.Size(13, 13);
            this.labelCastleLevel.TabIndex = 27;
            this.labelCastleLevel.Text = "1";
            // 
            // labelTurnCount
            // 
            this.labelTurnCount.AutoSize = true;
            this.labelTurnCount.Location = new System.Drawing.Point(816, 38);
            this.labelTurnCount.Name = "labelTurnCount";
            this.labelTurnCount.Size = new System.Drawing.Size(13, 13);
            this.labelTurnCount.TabIndex = 28;
            this.labelTurnCount.Text = "0";
            // 
            // buttonSpeedUp
            // 
            this.buttonSpeedUp.Location = new System.Drawing.Point(735, 33);
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
            this.labelTurn.Location = new System.Drawing.Point(803, 9);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(32, 13);
            this.labelTurn.TabIndex = 30;
            this.labelTurn.Text = "Tura:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(215, 106);
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
            this.labelQuantity.Location = new System.Drawing.Point(212, 90);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(93, 13);
            this.labelQuantity.TabIndex = 32;
            this.labelQuantity.Text = "Liczba budynków:";
            this.labelQuantity.Visible = false;
            // 
            // buttonBuildMany
            // 
            this.buttonBuildMany.Location = new System.Drawing.Point(340, 106);
            this.buttonBuildMany.Name = "buttonBuildMany";
            this.buttonBuildMany.Size = new System.Drawing.Size(76, 20);
            this.buttonBuildMany.TabIndex = 33;
            this.buttonBuildMany.Text = "Zbuduj wiele";
            this.buttonBuildMany.UseVisualStyleBackColor = true;
            this.buttonBuildMany.Visible = false;
            this.buttonBuildMany.Click += new System.EventHandler(this.buttonBuildMany_Click);
            // 
            // buttonDestroyMany
            // 
            this.buttonDestroyMany.Location = new System.Drawing.Point(422, 106);
            this.buttonDestroyMany.Name = "buttonDestroyMany";
            this.buttonDestroyMany.Size = new System.Drawing.Size(85, 20);
            this.buttonDestroyMany.TabIndex = 34;
            this.buttonDestroyMany.Text = "Zniszcz wiele";
            this.buttonDestroyMany.UseVisualStyleBackColor = true;
            this.buttonDestroyMany.Visible = false;
            this.buttonDestroyMany.Click += new System.EventHandler(this.buttonDestroyMany_Click);
            // 
            // labelSawmillQuantity
            // 
            this.labelSawmillQuantity.AutoSize = true;
            this.labelSawmillQuantity.Location = new System.Drawing.Point(9, 372);
            this.labelSawmillQuantity.Name = "labelSawmillQuantity";
            this.labelSawmillQuantity.Size = new System.Drawing.Size(43, 13);
            this.labelSawmillQuantity.TabIndex = 35;
            this.labelSawmillQuantity.Text = "Tartaki:";
            // 
            // labelQuarriesQuantity
            // 
            this.labelQuarriesQuantity.AutoSize = true;
            this.labelQuarriesQuantity.Location = new System.Drawing.Point(175, 372);
            this.labelQuarriesQuantity.Name = "labelQuarriesQuantity";
            this.labelQuarriesQuantity.Size = new System.Drawing.Size(76, 13);
            this.labelQuarriesQuantity.TabIndex = 36;
            this.labelQuarriesQuantity.Text = "Kamieniołomy:";
            // 
            // labelMinesQuantity
            // 
            this.labelMinesQuantity.AutoSize = true;
            this.labelMinesQuantity.Location = new System.Drawing.Point(341, 372);
            this.labelMinesQuantity.Name = "labelMinesQuantity";
            this.labelMinesQuantity.Size = new System.Drawing.Size(51, 13);
            this.labelMinesQuantity.TabIndex = 37;
            this.labelMinesQuantity.Text = "Kopalnie:";
            // 
            // labelFarmsQuantity
            // 
            this.labelFarmsQuantity.AutoSize = true;
            this.labelFarmsQuantity.Location = new System.Drawing.Point(507, 372);
            this.labelFarmsQuantity.Name = "labelFarmsQuantity";
            this.labelFarmsQuantity.Size = new System.Drawing.Size(38, 13);
            this.labelFarmsQuantity.TabIndex = 38;
            this.labelFarmsQuantity.Text = "Farmy:";
            // 
            // labelCastleLvl
            // 
            this.labelCastleLvl.AutoSize = true;
            this.labelCastleLvl.Location = new System.Drawing.Point(673, 372);
            this.labelCastleLvl.Name = "labelCastleLvl";
            this.labelCastleLvl.Size = new System.Drawing.Size(78, 13);
            this.labelCastleLvl.TabIndex = 39;
            this.labelCastleLvl.Text = "Poziom zamku:";
            // 
            // buttonMusicStopPlay
            // 
            this.buttonMusicStopPlay.Location = new System.Drawing.Point(735, 79);
            this.buttonMusicStopPlay.Name = "buttonMusicStopPlay";
            this.buttonMusicStopPlay.Size = new System.Drawing.Size(100, 23);
            this.buttonMusicStopPlay.TabIndex = 40;
            this.buttonMusicStopPlay.Text = "Stop soundtrack";
            this.buttonMusicStopPlay.UseVisualStyleBackColor = true;
            this.buttonMusicStopPlay.Click += new System.EventHandler(this.buttonMusicStopPlay_Click);
            // 
            // labelUnitBuyMenu
            // 
            this.labelUnitBuyMenu.AutoSize = true;
            this.labelUnitBuyMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUnitBuyMenu.Location = new System.Drawing.Point(12, 423);
            this.labelUnitBuyMenu.Name = "labelUnitBuyMenu";
            this.labelUnitBuyMenu.Size = new System.Drawing.Size(112, 17);
            this.labelUnitBuyMenu.TabIndex = 41;
            this.labelUnitBuyMenu.Text = "Zakup jednostki:";
            // 
            // comboBoxBuyUnits
            // 
            this.comboBoxBuyUnits.FormattingEnabled = true;
            this.comboBoxBuyUnits.Location = new System.Drawing.Point(15, 443);
            this.comboBoxBuyUnits.Name = "comboBoxBuyUnits";
            this.comboBoxBuyUnits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBuyUnits.TabIndex = 42;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(15, 470);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 43;
            this.buttonBuy.Text = "Zakup";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonFight
            // 
            this.buttonFight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFight.ForeColor = System.Drawing.Color.Red;
            this.buttonFight.Location = new System.Drawing.Point(510, 423);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(75, 86);
            this.buttonFight.TabIndex = 44;
            this.buttonFight.Text = "Idź na egazmin!";
            this.buttonFight.UseVisualStyleBackColor = false;
            this.buttonFight.Click += new System.EventHandler(this.buttonFight_Click);
            // 
            // labelPlayerUnitsTitle
            // 
            this.labelPlayerUnitsTitle.AutoSize = true;
            this.labelPlayerUnitsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerUnitsTitle.Location = new System.Drawing.Point(293, 423);
            this.labelPlayerUnitsTitle.Name = "labelPlayerUnitsTitle";
            this.labelPlayerUnitsTitle.Size = new System.Drawing.Size(105, 17);
            this.labelPlayerUnitsTitle.TabIndex = 45;
            this.labelPlayerUnitsTitle.Text = "Twoje jednoski:";
            // 
            // labelPlayerUnits
            // 
            this.labelPlayerUnits.AutoSize = true;
            this.labelPlayerUnits.Location = new System.Drawing.Point(254, 446);
            this.labelPlayerUnits.Name = "labelPlayerUnits";
            this.labelPlayerUnits.Size = new System.Drawing.Size(0, 13);
            this.labelPlayerUnits.TabIndex = 46;
            // 
            // labelUnitCost
            // 
            this.labelUnitCost.AutoSize = true;
            this.labelUnitCost.Location = new System.Drawing.Point(13, 496);
            this.labelUnitCost.Name = "labelUnitCost";
            this.labelUnitCost.Size = new System.Drawing.Size(206, 13);
            this.labelUnitCost.TabIndex = 47;
            this.labelUnitCost.Text = "Koszt każdej jednostki to 5000 sztuk złota";
            // 
            // labelPassedExams
            // 
            this.labelPassedExams.AutoSize = true;
            this.labelPassedExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassedExams.Location = new System.Drawing.Point(673, 423);
            this.labelPassedExams.Name = "labelPassedExams";
            this.labelPassedExams.Size = new System.Drawing.Size(117, 17);
            this.labelPassedExams.TabIndex = 48;
            this.labelPassedExams.Text = "Zdane egazminy:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(847, 536);
            this.Controls.Add(this.labelPassedExams);
            this.Controls.Add(this.labelUnitCost);
            this.Controls.Add(this.labelPlayerUnits);
            this.Controls.Add(this.labelPlayerUnitsTitle);
            this.Controls.Add(this.buttonFight);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.comboBoxBuyUnits);
            this.Controls.Add(this.labelUnitBuyMenu);
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
        private System.Windows.Forms.Label labelUnitBuyMenu;
        private System.Windows.Forms.ComboBox comboBoxBuyUnits;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.Label labelPlayerUnitsTitle;
        private System.Windows.Forms.Label labelPlayerUnits;
        private System.Windows.Forms.Label labelUnitCost;
        private System.Windows.Forms.Label labelPassedExams;
    }
}

