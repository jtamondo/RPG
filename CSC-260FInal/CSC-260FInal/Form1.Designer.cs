namespace CSC_260FInal
{
    partial class Form1
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
            this.HP = new System.Windows.Forms.TextBox();
            this.Quest = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.Battle = new System.Windows.Forms.Button();
            this.drone = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.EnemyHP = new System.Windows.Forms.TextBox();
            this.BattleText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HP
            // 
            this.HP.Location = new System.Drawing.Point(12, 37);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(100, 22);
            this.HP.TabIndex = 0;
            this.HP.Text = "HP:";
            this.HP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Quest
            // 
            this.Quest.Location = new System.Drawing.Point(12, 95);
            this.Quest.Name = "Quest";
            this.Quest.Size = new System.Drawing.Size(696, 22);
            this.Quest.TabIndex = 1;
            this.Quest.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(231, 186);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(293, 109);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Battle
            // 
            this.Battle.Location = new System.Drawing.Point(561, 137);
            this.Battle.Name = "Battle";
            this.Battle.Size = new System.Drawing.Size(204, 88);
            this.Battle.TabIndex = 3;
            this.Battle.Text = "Battle";
            this.Battle.UseVisualStyleBackColor = true;
            this.Battle.Click += new System.EventHandler(this.button1_Click);
            // 
            // drone
            // 
            this.drone.Location = new System.Drawing.Point(23, 143);
            this.drone.Name = "drone";
            this.drone.Size = new System.Drawing.Size(172, 81);
            this.drone.TabIndex = 4;
            this.drone.Text = "Drone";
            this.drone.UseVisualStyleBackColor = true;
            this.drone.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(611, 364);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(163, 49);
            this.Return.TabIndex = 5;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // EnemyHP
            // 
            this.EnemyHP.Location = new System.Drawing.Point(631, 37);
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(100, 22);
            this.EnemyHP.TabIndex = 6;
            this.EnemyHP.Text = "EnemyHP:";
            this.EnemyHP.TextChanged += new System.EventHandler(this.EnemyHP_TextChanged);
            // 
            // BattleText
            // 
            this.BattleText.Location = new System.Drawing.Point(93, 314);
            this.BattleText.Name = "BattleText";
            this.BattleText.Size = new System.Drawing.Size(530, 22);
            this.BattleText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BattleText);
            this.Controls.Add(this.EnemyHP);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.drone);
            this.Controls.Add(this.Battle);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Quest);
            this.Controls.Add(this.HP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HP;
        private System.Windows.Forms.TextBox Quest;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Battle;
        private System.Windows.Forms.Button drone;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox EnemyHP;
        private System.Windows.Forms.TextBox BattleText;
    }
}

