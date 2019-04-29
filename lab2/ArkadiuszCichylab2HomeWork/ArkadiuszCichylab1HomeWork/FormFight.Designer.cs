namespace ArkadiuszCichyLab2Homework
{
    partial class FormFight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBattlefield = new System.Windows.Forms.DataGridView();
            this.textBoxBattleLog = new System.Windows.Forms.TextBox();
            this.toolTipUnitInfo = new System.Windows.Forms.ToolTip(this.components);
            this.labelUnitInfo = new System.Windows.Forms.Label();
            this.buttonStopPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBattlefield)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBattlefield
            // 
            this.dataGridViewBattlefield.AllowUserToAddRows = false;
            this.dataGridViewBattlefield.AllowUserToDeleteRows = false;
            this.dataGridViewBattlefield.AllowUserToResizeColumns = false;
            this.dataGridViewBattlefield.AllowUserToResizeRows = false;
            this.dataGridViewBattlefield.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBattlefield.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBattlefield.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBattlefield.ColumnHeadersVisible = false;
            this.dataGridViewBattlefield.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBattlefield.MultiSelect = false;
            this.dataGridViewBattlefield.Name = "dataGridViewBattlefield";
            this.dataGridViewBattlefield.RowHeadersVisible = false;
            this.dataGridViewBattlefield.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBattlefield.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewBattlefield.Size = new System.Drawing.Size(768, 393);
            this.dataGridViewBattlefield.TabIndex = 0;
            this.dataGridViewBattlefield.SelectionChanged += new System.EventHandler(this.dataGridViewBattlefield_SelectionChanged);
            // 
            // textBoxBattleLog
            // 
            this.textBoxBattleLog.Location = new System.Drawing.Point(13, 399);
            this.textBoxBattleLog.Multiline = true;
            this.textBoxBattleLog.Name = "textBoxBattleLog";
            this.textBoxBattleLog.ReadOnly = true;
            this.textBoxBattleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBattleLog.Size = new System.Drawing.Size(276, 151);
            this.textBoxBattleLog.TabIndex = 1;
            this.textBoxBattleLog.TextChanged += new System.EventHandler(this.textBoxBattleLog_TextChanged);
            // 
            // toolTipUnitInfo
            // 
            this.toolTipUnitInfo.ShowAlways = true;
            // 
            // labelUnitInfo
            // 
            this.labelUnitInfo.AutoSize = true;
            this.labelUnitInfo.Location = new System.Drawing.Point(295, 402);
            this.labelUnitInfo.Name = "labelUnitInfo";
            this.labelUnitInfo.Size = new System.Drawing.Size(108, 13);
            this.labelUnitInfo.TabIndex = 2;
            this.labelUnitInfo.Text = "Nie wybrano jednoski";
            // 
            // buttonStopPlay
            // 
            this.buttonStopPlay.Location = new System.Drawing.Point(662, 527);
            this.buttonStopPlay.Name = "buttonStopPlay";
            this.buttonStopPlay.Size = new System.Drawing.Size(94, 23);
            this.buttonStopPlay.TabIndex = 3;
            this.buttonStopPlay.Text = "Stop soundtrack";
            this.buttonStopPlay.UseVisualStyleBackColor = true;
            this.buttonStopPlay.Click += new System.EventHandler(this.buttonStopPlay_Click);
            // 
            // FormFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 562);
            this.ControlBox = false;
            this.Controls.Add(this.buttonStopPlay);
            this.Controls.Add(this.labelUnitInfo);
            this.Controls.Add(this.textBoxBattleLog);
            this.Controls.Add(this.dataGridViewBattlefield);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFight";
            this.Text = "FormFight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBattlefield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBattlefield;
        private System.Windows.Forms.TextBox textBoxBattleLog;
        private System.Windows.Forms.ToolTip toolTipUnitInfo;
        private System.Windows.Forms.Label labelUnitInfo;
        private System.Windows.Forms.Button buttonStopPlay;
    }
}