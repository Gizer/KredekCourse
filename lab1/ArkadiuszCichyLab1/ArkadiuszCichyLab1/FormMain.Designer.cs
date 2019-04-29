namespace ArkadiuszCichyLab1
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonChangeAll = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(210, 31);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Arkadiusz Cichy";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(672, 415);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(116, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(15, 43);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Zmień";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonChangeAll
            // 
            this.buttonChangeAll.Location = new System.Drawing.Point(15, 415);
            this.buttonChangeAll.Name = "buttonChangeAll";
            this.buttonChangeAll.Size = new System.Drawing.Size(134, 23);
            this.buttonChangeAll.TabIndex = 3;
            this.buttonChangeAll.Text = "Zmiana wszystkiego";
            this.buttonChangeAll.UseVisualStyleBackColor = true;
            this.buttonChangeAll.Click += new System.EventHandler(this.buttonChangeAll_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(362, 415);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Pokaż";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(348, 345);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 5;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(348, 389);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(249, 20);
            this.textBoxOutput.TabIndex = 6;
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 73);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start Timer";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(13, 103);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(75, 23);
            this.buttonNewWindow.TabIndex = 8;
            this.buttonNewWindow.Text = "Nowe Okno";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonChangeAll);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelName);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonChangeAll;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

