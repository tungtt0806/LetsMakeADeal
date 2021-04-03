namespace FinalProject
{
    partial class makeDealForm
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
            this.door1 = new System.Windows.Forms.Button();
            this.door2 = new System.Windows.Forms.Button();
            this.door3 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choiceButton = new System.Windows.Forms.Button();
            this.rewardLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // door1
            // 
            this.door1.BackColor = System.Drawing.Color.Peru;
            this.door1.BackgroundImage = global::FinalProject.Properties.Resources.door;
            this.door1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door1.ForeColor = System.Drawing.Color.Black;
            this.door1.Location = new System.Drawing.Point(44, 114);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(145, 208);
            this.door1.TabIndex = 0;
            this.door1.Text = "Door 1";
            this.door1.UseVisualStyleBackColor = false;
            this.door1.Click += new System.EventHandler(this.Door1_Click);
            // 
            // door2
            // 
            this.door2.BackColor = System.Drawing.Color.Peru;
            this.door2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door2.ForeColor = System.Drawing.Color.Black;
            this.door2.Image = global::FinalProject.Properties.Resources.door;
            this.door2.Location = new System.Drawing.Point(276, 114);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(145, 208);
            this.door2.TabIndex = 1;
            this.door2.Text = "Door 2";
            this.door2.UseVisualStyleBackColor = false;
            this.door2.Click += new System.EventHandler(this.Door2_Click);
            // 
            // door3
            // 
            this.door3.BackColor = System.Drawing.Color.Peru;
            this.door3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.door3.ForeColor = System.Drawing.Color.Black;
            this.door3.Image = global::FinalProject.Properties.Resources.door;
            this.door3.Location = new System.Drawing.Point(505, 114);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(145, 208);
            this.door3.TabIndex = 2;
            this.door3.Text = "Door 3";
            this.door3.UseVisualStyleBackColor = false;
            this.door3.Click += new System.EventHandler(this.Door3_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(183, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(331, 31);
            this.title.TabIndex = 3;
            this.title.Text = "Let\'s Make a Deal Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(202, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click on a Door to get your reward";
            // 
            // choiceButton
            // 
            this.choiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceButton.ForeColor = System.Drawing.Color.Black;
            this.choiceButton.Location = new System.Drawing.Point(265, 358);
            this.choiceButton.Name = "choiceButton";
            this.choiceButton.Size = new System.Drawing.Size(167, 38);
            this.choiceButton.TabIndex = 6;
            this.choiceButton.Text = "Trade Prize";
            this.choiceButton.UseVisualStyleBackColor = true;
            this.choiceButton.Click += new System.EventHandler(this.ChoiceButton_Click);
            // 
            // rewardLabel
            // 
            this.rewardLabel.AutoSize = true;
            this.rewardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardLabel.Location = new System.Drawing.Point(105, 412);
            this.rewardLabel.Name = "rewardLabel";
            this.rewardLabel.Size = new System.Drawing.Size(0, 24);
            this.rewardLabel.TabIndex = 7;
            this.rewardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.Black;
            this.restartButton.Location = new System.Drawing.Point(265, 471);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(167, 38);
            this.restartButton.TabIndex = 8;
            this.restartButton.Text = "Restart game";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // makeDealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.sea;
            this.ClientSize = new System.Drawing.Size(707, 579);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.rewardLabel);
            this.Controls.Add(this.choiceButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.door3);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.door1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "makeDealForm";
            this.Text = "That Tung Ton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button door1;
        private System.Windows.Forms.Button door2;
        private System.Windows.Forms.Button door3;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choiceButton;
        private System.Windows.Forms.Label rewardLabel;
        private System.Windows.Forms.Button restartButton;
    }
}

