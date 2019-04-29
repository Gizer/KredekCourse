namespace ArkadiuszCichyLab2
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
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonChangeSize = new System.Windows.Forms.Button();
            this.buttonPermimeter = new System.Windows.Forms.Button();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(13, 13);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 0;
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Location = new System.Drawing.Point(13, 40);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxPerimeter.TabIndex = 1;
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(120, 9);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(80, 23);
            this.buttonArea.TabIndex = 2;
            this.buttonArea.Text = "Oblicz pole";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonChangeSize
            // 
            this.buttonChangeSize.Location = new System.Drawing.Point(120, 36);
            this.buttonChangeSize.Name = "buttonChangeSize";
            this.buttonChangeSize.Size = new System.Drawing.Size(80, 23);
            this.buttonChangeSize.TabIndex = 3;
            this.buttonChangeSize.Text = "Zmien rozmiar";
            this.buttonChangeSize.UseVisualStyleBackColor = true;
            this.buttonChangeSize.Click += new System.EventHandler(this.buttonChangeSize_Click);
            // 
            // buttonPermimeter
            // 
            this.buttonPermimeter.Location = new System.Drawing.Point(120, 66);
            this.buttonPermimeter.Name = "buttonPermimeter";
            this.buttonPermimeter.Size = new System.Drawing.Size(80, 23);
            this.buttonPermimeter.TabIndex = 4;
            this.buttonPermimeter.Text = "Obwód";
            this.buttonPermimeter.UseVisualStyleBackColor = true;
            this.buttonPermimeter.Click += new System.EventHandler(this.buttonPermimeter_Click);
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Location = new System.Drawing.Point(231, 11);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShape.TabIndex = 5;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(625, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(154, 25);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Arkadiusz Cichy";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.buttonPermimeter);
            this.Controls.Add(this.buttonChangeSize);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.textBoxPerimeter);
            this.Controls.Add(this.textBoxArea);
            this.Name = "FormMain";
            this.Text = "ArkadiuszCichy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonChangeSize;
        private System.Windows.Forms.Button buttonPermimeter;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Label labelName;
    }
}

