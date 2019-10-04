namespace N_Queens_Problem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDrawBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericNumberOfQueens = new System.Windows.Forms.NumericUpDown();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.buttonHeuristic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfQueens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnDrawBoard
            // 
            this.btnDrawBoard.Location = new System.Drawing.Point(10, 494);
            this.btnDrawBoard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrawBoard.Name = "btnDrawBoard";
            this.btnDrawBoard.Size = new System.Drawing.Size(82, 33);
            this.btnDrawBoard.TabIndex = 1;
            this.btnDrawBoard.Text = "Blind";
            this.btnDrawBoard.UseVisualStyleBackColor = true;
            this.btnDrawBoard.Click += new System.EventHandler(this.btnDrawBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of queens";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericNumberOfQueens
            // 
            this.numericNumberOfQueens.Location = new System.Drawing.Point(114, 13);
            this.numericNumberOfQueens.Name = "numericNumberOfQueens";
            this.numericNumberOfQueens.Size = new System.Drawing.Size(69, 20);
            this.numericNumberOfQueens.TabIndex = 3;
            this.numericNumberOfQueens.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericNumberOfQueens.ValueChanged += new System.EventHandler(this.numericNumberOfQueens_ValueChanged);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(180, 494);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(35, 33);
            this.buttonFirst.TabIndex = 4;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(217, 494);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(35, 33);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(424, 494);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(35, 33);
            this.buttonLast.TabIndex = 7;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(387, 494);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(35, 33);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelResults
            // 
            this.labelResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResults.Location = new System.Drawing.Point(257, 494);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(124, 33);
            this.labelResults.TabIndex = 8;
            this.labelResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCost
            // 
            this.labelCost.Location = new System.Drawing.Point(217, 13);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(242, 23);
            this.labelCost.TabIndex = 9;
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonHeuristic
            // 
            this.buttonHeuristic.Location = new System.Drawing.Point(93, 494);
            this.buttonHeuristic.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHeuristic.Name = "buttonHeuristic";
            this.buttonHeuristic.Size = new System.Drawing.Size(82, 33);
            this.buttonHeuristic.TabIndex = 10;
            this.buttonHeuristic.Text = "Heuristic";
            this.buttonHeuristic.UseVisualStyleBackColor = true;
            this.buttonHeuristic.Click += new System.EventHandler(this.buttonHeuristic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 535);
            this.Controls.Add(this.buttonHeuristic);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.numericNumberOfQueens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDrawBoard);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "N-Queens-Problem";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfQueens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDrawBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericNumberOfQueens;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Button buttonHeuristic;
    }
}

