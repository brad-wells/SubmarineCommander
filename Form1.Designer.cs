namespace Asg1SubFleetCommander
{
    partial class SubCommander
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
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StatusRTextBox = new System.Windows.Forms.RichTextBox();
            this.FeaturePanel = new System.Windows.Forms.Panel();
            this.PowerDisplayLabel = new System.Windows.Forms.Label();
            this.powerLabel = new System.Windows.Forms.Label();
            this.FireMissileButton = new System.Windows.Forms.Button();
            this.MissileLabel = new System.Windows.Forms.Label();
            this.FireTorpedoButton = new System.Windows.Forms.Button();
            this.TorpedoLabel = new System.Windows.Forms.Label();
            this.WeaponLabel = new System.Windows.Forms.Label();
            this.DepthDown = new System.Windows.Forms.Button();
            this.DepthUp = new System.Windows.Forms.Button();
            this.DepthDisplay = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.SpeedDownButton = new System.Windows.Forms.Button();
            this.SpeedUpButton = new System.Windows.Forms.Button();
            this.SpeedDisplay = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.SWButton = new System.Windows.Forms.Button();
            this.SEButton = new System.Windows.Forms.Button();
            this.WButton = new System.Windows.Forms.Button();
            this.SButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.NWButton = new System.Windows.Forms.Button();
            this.NEButton = new System.Windows.Forms.Button();
            this.NButton = new System.Windows.Forms.Button();
            this.CourseDisplay = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.PowerDownButton = new System.Windows.Forms.Button();
            this.PowerUpButton = new System.Windows.Forms.Button();
            this.HullNumTextBox = new System.Windows.Forms.TextBox();
            this.HullNumLabel = new System.Windows.Forms.Label();
            this.SubNameTextBox = new System.Windows.Forms.TextBox();
            this.SubNameLabel = new System.Windows.Forms.Label();
            this.MainControlPanel = new System.Windows.Forms.Panel();
            this.DeleteSub = new System.Windows.Forms.Button();
            this.EditSub = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubListBox = new System.Windows.Forms.ListBox();
            this.TitlePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.FeaturePanel.SuspendLayout();
            this.MainControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.titleLabel);
            this.TitlePanel.Location = new System.Drawing.Point(-1, -3);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(802, 85);
            this.TitlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Lime;
            this.titleLabel.Location = new System.Drawing.Point(181, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(439, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Submarine Commander";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.UpdateButton);
            this.MainPanel.Controls.Add(this.StatusRTextBox);
            this.MainPanel.Controls.Add(this.FeaturePanel);
            this.MainPanel.Controls.Add(this.HullNumTextBox);
            this.MainPanel.Controls.Add(this.HullNumLabel);
            this.MainPanel.Controls.Add(this.SubNameTextBox);
            this.MainPanel.Controls.Add(this.SubNameLabel);
            this.MainPanel.Controls.Add(this.MainControlPanel);
            this.MainPanel.Controls.Add(this.SubListBox);
            this.MainPanel.Location = new System.Drawing.Point(4, 94);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(787, 497);
            this.MainPanel.TabIndex = 1;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.Lime;
            this.UpdateButton.Location = new System.Drawing.Point(315, 325);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(73, 32);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusRTextBox
            // 
            this.StatusRTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusRTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.StatusRTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusRTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.StatusRTextBox.Location = new System.Drawing.Point(15, 365);
            this.StatusRTextBox.Name = "StatusRTextBox";
            this.StatusRTextBox.Size = new System.Drawing.Size(501, 103);
            this.StatusRTextBox.TabIndex = 7;
            this.StatusRTextBox.Text = "";
            this.StatusRTextBox.TextChanged += new System.EventHandler(this.StatusRTextBox_TextChanged);
            // 
            // FeaturePanel
            // 
            this.FeaturePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FeaturePanel.Controls.Add(this.PowerDisplayLabel);
            this.FeaturePanel.Controls.Add(this.powerLabel);
            this.FeaturePanel.Controls.Add(this.FireMissileButton);
            this.FeaturePanel.Controls.Add(this.MissileLabel);
            this.FeaturePanel.Controls.Add(this.FireTorpedoButton);
            this.FeaturePanel.Controls.Add(this.TorpedoLabel);
            this.FeaturePanel.Controls.Add(this.WeaponLabel);
            this.FeaturePanel.Controls.Add(this.DepthDown);
            this.FeaturePanel.Controls.Add(this.DepthUp);
            this.FeaturePanel.Controls.Add(this.DepthDisplay);
            this.FeaturePanel.Controls.Add(this.DepthLabel);
            this.FeaturePanel.Controls.Add(this.SpeedDownButton);
            this.FeaturePanel.Controls.Add(this.SpeedUpButton);
            this.FeaturePanel.Controls.Add(this.SpeedDisplay);
            this.FeaturePanel.Controls.Add(this.SpeedLabel);
            this.FeaturePanel.Controls.Add(this.SWButton);
            this.FeaturePanel.Controls.Add(this.SEButton);
            this.FeaturePanel.Controls.Add(this.WButton);
            this.FeaturePanel.Controls.Add(this.SButton);
            this.FeaturePanel.Controls.Add(this.EButton);
            this.FeaturePanel.Controls.Add(this.NWButton);
            this.FeaturePanel.Controls.Add(this.NEButton);
            this.FeaturePanel.Controls.Add(this.NButton);
            this.FeaturePanel.Controls.Add(this.CourseDisplay);
            this.FeaturePanel.Controls.Add(this.CourseLabel);
            this.FeaturePanel.Controls.Add(this.PowerDownButton);
            this.FeaturePanel.Controls.Add(this.PowerUpButton);
            this.FeaturePanel.Location = new System.Drawing.Point(536, 9);
            this.FeaturePanel.Name = "FeaturePanel";
            this.FeaturePanel.Size = new System.Drawing.Size(238, 469);
            this.FeaturePanel.TabIndex = 6;
            // 
            // PowerDisplayLabel
            // 
            this.PowerDisplayLabel.AutoSize = true;
            this.PowerDisplayLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerDisplayLabel.ForeColor = System.Drawing.Color.Indigo;
            this.PowerDisplayLabel.Location = new System.Drawing.Point(136, 75);
            this.PowerDisplayLabel.Name = "PowerDisplayLabel";
            this.PowerDisplayLabel.Size = new System.Drawing.Size(35, 21);
            this.PowerDisplayLabel.TabIndex = 29;
            this.PowerDisplayLabel.Text = "OFF";
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.ForeColor = System.Drawing.Color.Lime;
            this.powerLabel.Location = new System.Drawing.Point(15, 75);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(99, 21);
            this.powerLabel.TabIndex = 28;
            this.powerLabel.Text = "Power Status:";
            // 
            // FireMissileButton
            // 
            this.FireMissileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FireMissileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FireMissileButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireMissileButton.ForeColor = System.Drawing.Color.Lime;
            this.FireMissileButton.Location = new System.Drawing.Point(103, 399);
            this.FireMissileButton.Name = "FireMissileButton";
            this.FireMissileButton.Size = new System.Drawing.Size(51, 32);
            this.FireMissileButton.TabIndex = 27;
            this.FireMissileButton.Text = "Fire";
            this.FireMissileButton.UseVisualStyleBackColor = true;
            this.FireMissileButton.Click += new System.EventHandler(this.FireMissileButton_Click);
            // 
            // MissileLabel
            // 
            this.MissileLabel.AutoSize = true;
            this.MissileLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissileLabel.ForeColor = System.Drawing.Color.Indigo;
            this.MissileLabel.Location = new System.Drawing.Point(103, 375);
            this.MissileLabel.Name = "MissileLabel";
            this.MissileLabel.Size = new System.Drawing.Size(55, 21);
            this.MissileLabel.TabIndex = 26;
            this.MissileLabel.Text = "Missile";
            // 
            // FireTorpedoButton
            // 
            this.FireTorpedoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FireTorpedoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FireTorpedoButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireTorpedoButton.ForeColor = System.Drawing.Color.Lime;
            this.FireTorpedoButton.Location = new System.Drawing.Point(19, 399);
            this.FireTorpedoButton.Name = "FireTorpedoButton";
            this.FireTorpedoButton.Size = new System.Drawing.Size(52, 32);
            this.FireTorpedoButton.TabIndex = 25;
            this.FireTorpedoButton.Text = "Fire";
            this.FireTorpedoButton.UseVisualStyleBackColor = true;
            this.FireTorpedoButton.Click += new System.EventHandler(this.FireTorpedoButton_Click);
            // 
            // TorpedoLabel
            // 
            this.TorpedoLabel.AutoSize = true;
            this.TorpedoLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TorpedoLabel.ForeColor = System.Drawing.Color.Indigo;
            this.TorpedoLabel.Location = new System.Drawing.Point(15, 375);
            this.TorpedoLabel.Name = "TorpedoLabel";
            this.TorpedoLabel.Size = new System.Drawing.Size(62, 21);
            this.TorpedoLabel.TabIndex = 24;
            this.TorpedoLabel.Text = "Torpedo";
            // 
            // WeaponLabel
            // 
            this.WeaponLabel.AutoSize = true;
            this.WeaponLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponLabel.ForeColor = System.Drawing.Color.Lime;
            this.WeaponLabel.Location = new System.Drawing.Point(15, 354);
            this.WeaponLabel.Name = "WeaponLabel";
            this.WeaponLabel.Size = new System.Drawing.Size(71, 21);
            this.WeaponLabel.TabIndex = 23;
            this.WeaponLabel.Text = "Weapons:";
            // 
            // DepthDown
            // 
            this.DepthDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepthDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepthDown.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthDown.ForeColor = System.Drawing.Color.Lime;
            this.DepthDown.Location = new System.Drawing.Point(160, 302);
            this.DepthDown.Name = "DepthDown";
            this.DepthDown.Size = new System.Drawing.Size(25, 33);
            this.DepthDown.TabIndex = 22;
            this.DepthDown.Text = "-";
            this.DepthDown.UseVisualStyleBackColor = true;
            this.DepthDown.Click += new System.EventHandler(this.DepthDown_Click);
            // 
            // DepthUp
            // 
            this.DepthUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepthUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepthUp.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthUp.ForeColor = System.Drawing.Color.Lime;
            this.DepthUp.Location = new System.Drawing.Point(129, 302);
            this.DepthUp.Name = "DepthUp";
            this.DepthUp.Size = new System.Drawing.Size(25, 33);
            this.DepthUp.TabIndex = 21;
            this.DepthUp.Text = "+";
            this.DepthUp.UseVisualStyleBackColor = true;
            this.DepthUp.Click += new System.EventHandler(this.DepthUp_Click);
            // 
            // DepthDisplay
            // 
            this.DepthDisplay.AutoSize = true;
            this.DepthDisplay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthDisplay.ForeColor = System.Drawing.Color.Indigo;
            this.DepthDisplay.Location = new System.Drawing.Point(72, 309);
            this.DepthDisplay.Name = "DepthDisplay";
            this.DepthDisplay.Size = new System.Drawing.Size(39, 21);
            this.DepthDisplay.TabIndex = 20;
            this.DepthDisplay.Text = "1000";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthLabel.ForeColor = System.Drawing.Color.Lime;
            this.DepthLabel.Location = new System.Drawing.Point(15, 309);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(51, 21);
            this.DepthLabel.TabIndex = 19;
            this.DepthLabel.Text = "Depth:";
            // 
            // SpeedDownButton
            // 
            this.SpeedDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeedDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedDownButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedDownButton.ForeColor = System.Drawing.Color.Lime;
            this.SpeedDownButton.Location = new System.Drawing.Point(160, 263);
            this.SpeedDownButton.Name = "SpeedDownButton";
            this.SpeedDownButton.Size = new System.Drawing.Size(25, 33);
            this.SpeedDownButton.TabIndex = 18;
            this.SpeedDownButton.Text = "-";
            this.SpeedDownButton.UseVisualStyleBackColor = true;
            this.SpeedDownButton.Click += new System.EventHandler(this.SpeedDownButton_Click);
            // 
            // SpeedUpButton
            // 
            this.SpeedUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeedUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedUpButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedUpButton.ForeColor = System.Drawing.Color.Lime;
            this.SpeedUpButton.Location = new System.Drawing.Point(129, 263);
            this.SpeedUpButton.Name = "SpeedUpButton";
            this.SpeedUpButton.Size = new System.Drawing.Size(25, 33);
            this.SpeedUpButton.TabIndex = 17;
            this.SpeedUpButton.Text = "+";
            this.SpeedUpButton.UseVisualStyleBackColor = true;
            this.SpeedUpButton.Click += new System.EventHandler(this.SpeedUpButton_Click);
            // 
            // SpeedDisplay
            // 
            this.SpeedDisplay.AutoSize = true;
            this.SpeedDisplay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedDisplay.ForeColor = System.Drawing.Color.Indigo;
            this.SpeedDisplay.Location = new System.Drawing.Point(75, 270);
            this.SpeedDisplay.Name = "SpeedDisplay";
            this.SpeedDisplay.Size = new System.Drawing.Size(26, 21);
            this.SpeedDisplay.TabIndex = 16;
            this.SpeedDisplay.Text = "25";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.ForeColor = System.Drawing.Color.Lime;
            this.SpeedLabel.Location = new System.Drawing.Point(15, 270);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(54, 21);
            this.SpeedLabel.TabIndex = 15;
            this.SpeedLabel.Text = "Speed:";
            // 
            // SWButton
            // 
            this.SWButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SWButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWButton.ForeColor = System.Drawing.Color.Lime;
            this.SWButton.Location = new System.Drawing.Point(113, 207);
            this.SWButton.Name = "SWButton";
            this.SWButton.Size = new System.Drawing.Size(41, 32);
            this.SWButton.TabIndex = 14;
            this.SWButton.Text = "SW";
            this.SWButton.UseVisualStyleBackColor = true;
            this.SWButton.Click += new System.EventHandler(this.SWButton_Click);
            // 
            // SEButton
            // 
            this.SEButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEButton.ForeColor = System.Drawing.Color.Lime;
            this.SEButton.Location = new System.Drawing.Point(66, 207);
            this.SEButton.Name = "SEButton";
            this.SEButton.Size = new System.Drawing.Size(41, 32);
            this.SEButton.TabIndex = 13;
            this.SEButton.Text = "SE";
            this.SEButton.UseVisualStyleBackColor = true;
            this.SEButton.Click += new System.EventHandler(this.SEButton_Click);
            // 
            // WButton
            // 
            this.WButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WButton.ForeColor = System.Drawing.Color.Lime;
            this.WButton.Location = new System.Drawing.Point(66, 169);
            this.WButton.Name = "WButton";
            this.WButton.Size = new System.Drawing.Size(41, 32);
            this.WButton.TabIndex = 12;
            this.WButton.Text = "W";
            this.WButton.UseVisualStyleBackColor = true;
            this.WButton.Click += new System.EventHandler(this.WButton_Click);
            // 
            // SButton
            // 
            this.SButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SButton.ForeColor = System.Drawing.Color.Lime;
            this.SButton.Location = new System.Drawing.Point(19, 207);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(41, 32);
            this.SButton.TabIndex = 11;
            this.SButton.Text = "S";
            this.SButton.UseVisualStyleBackColor = true;
            this.SButton.Click += new System.EventHandler(this.SButton_Click);
            // 
            // EButton
            // 
            this.EButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton.ForeColor = System.Drawing.Color.Lime;
            this.EButton.Location = new System.Drawing.Point(19, 169);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(41, 32);
            this.EButton.TabIndex = 10;
            this.EButton.Text = "E";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // NWButton
            // 
            this.NWButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NWButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NWButton.ForeColor = System.Drawing.Color.Lime;
            this.NWButton.Location = new System.Drawing.Point(113, 131);
            this.NWButton.Name = "NWButton";
            this.NWButton.Size = new System.Drawing.Size(45, 32);
            this.NWButton.TabIndex = 9;
            this.NWButton.Text = "NW";
            this.NWButton.UseVisualStyleBackColor = true;
            this.NWButton.Click += new System.EventHandler(this.NWButton_Click);
            // 
            // NEButton
            // 
            this.NEButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NEButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEButton.ForeColor = System.Drawing.Color.Lime;
            this.NEButton.Location = new System.Drawing.Point(66, 131);
            this.NEButton.Name = "NEButton";
            this.NEButton.Size = new System.Drawing.Size(41, 32);
            this.NEButton.TabIndex = 8;
            this.NEButton.Text = "NE";
            this.NEButton.UseVisualStyleBackColor = true;
            this.NEButton.Click += new System.EventHandler(this.NEButton_Click);
            // 
            // NButton
            // 
            this.NButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NButton.ForeColor = System.Drawing.Color.Lime;
            this.NButton.Location = new System.Drawing.Point(19, 131);
            this.NButton.Name = "NButton";
            this.NButton.Size = new System.Drawing.Size(41, 32);
            this.NButton.TabIndex = 7;
            this.NButton.Text = "N";
            this.NButton.UseVisualStyleBackColor = true;
            this.NButton.Click += new System.EventHandler(this.NButton_Click);
            // 
            // CourseDisplay
            // 
            this.CourseDisplay.AutoSize = true;
            this.CourseDisplay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDisplay.ForeColor = System.Drawing.Color.Indigo;
            this.CourseDisplay.Location = new System.Drawing.Point(136, 109);
            this.CourseDisplay.Name = "CourseDisplay";
            this.CourseDisplay.Size = new System.Drawing.Size(32, 21);
            this.CourseDisplay.TabIndex = 6;
            this.CourseDisplay.Text = "NW";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.ForeColor = System.Drawing.Color.Lime;
            this.CourseLabel.Location = new System.Drawing.Point(15, 109);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(115, 21);
            this.CourseLabel.TabIndex = 5;
            this.CourseLabel.Text = "Course Heading:";
            // 
            // PowerDownButton
            // 
            this.PowerDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerDownButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerDownButton.ForeColor = System.Drawing.Color.Lime;
            this.PowerDownButton.Location = new System.Drawing.Point(126, 13);
            this.PowerDownButton.Name = "PowerDownButton";
            this.PowerDownButton.Size = new System.Drawing.Size(91, 49);
            this.PowerDownButton.TabIndex = 4;
            this.PowerDownButton.Text = "Shut Down";
            this.PowerDownButton.UseVisualStyleBackColor = true;
            this.PowerDownButton.Click += new System.EventHandler(this.PowerDownButton_Click);
            // 
            // PowerUpButton
            // 
            this.PowerUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerUpButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerUpButton.ForeColor = System.Drawing.Color.Lime;
            this.PowerUpButton.Location = new System.Drawing.Point(16, 13);
            this.PowerUpButton.Name = "PowerUpButton";
            this.PowerUpButton.Size = new System.Drawing.Size(91, 49);
            this.PowerUpButton.TabIndex = 3;
            this.PowerUpButton.Text = "Power Up";
            this.PowerUpButton.UseVisualStyleBackColor = true;
            this.PowerUpButton.Click += new System.EventHandler(this.PowerUpButton_Click);
            // 
            // HullNumTextBox
            // 
            this.HullNumTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HullNumTextBox.Location = new System.Drawing.Point(122, 291);
            this.HullNumTextBox.Name = "HullNumTextBox";
            this.HullNumTextBox.Size = new System.Drawing.Size(266, 28);
            this.HullNumTextBox.TabIndex = 5;
            // 
            // HullNumLabel
            // 
            this.HullNumLabel.AutoSize = true;
            this.HullNumLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HullNumLabel.ForeColor = System.Drawing.Color.Lime;
            this.HullNumLabel.Location = new System.Drawing.Point(14, 296);
            this.HullNumLabel.Name = "HullNumLabel";
            this.HullNumLabel.Size = new System.Drawing.Size(53, 21);
            this.HullNumLabel.TabIndex = 4;
            this.HullNumLabel.Text = "Hull # :";
            // 
            // SubNameTextBox
            // 
            this.SubNameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubNameTextBox.Location = new System.Drawing.Point(122, 257);
            this.SubNameTextBox.Name = "SubNameTextBox";
            this.SubNameTextBox.Size = new System.Drawing.Size(266, 28);
            this.SubNameTextBox.TabIndex = 3;
            // 
            // SubNameLabel
            // 
            this.SubNameLabel.AutoSize = true;
            this.SubNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubNameLabel.ForeColor = System.Drawing.Color.Lime;
            this.SubNameLabel.Location = new System.Drawing.Point(14, 260);
            this.SubNameLabel.Name = "SubNameLabel";
            this.SubNameLabel.Size = new System.Drawing.Size(80, 21);
            this.SubNameLabel.TabIndex = 2;
            this.SubNameLabel.Text = "Sub Name:";
            // 
            // MainControlPanel
            // 
            this.MainControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainControlPanel.Controls.Add(this.DeleteSub);
            this.MainControlPanel.Controls.Add(this.EditSub);
            this.MainControlPanel.Controls.Add(this.AddButton);
            this.MainControlPanel.Location = new System.Drawing.Point(404, 9);
            this.MainControlPanel.Name = "MainControlPanel";
            this.MainControlPanel.Size = new System.Drawing.Size(113, 315);
            this.MainControlPanel.TabIndex = 1;
            // 
            // DeleteSub
            // 
            this.DeleteSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSub.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSub.ForeColor = System.Drawing.Color.Lime;
            this.DeleteSub.Location = new System.Drawing.Point(9, 223);
            this.DeleteSub.Name = "DeleteSub";
            this.DeleteSub.Size = new System.Drawing.Size(91, 49);
            this.DeleteSub.TabIndex = 2;
            this.DeleteSub.Text = "Delete Sub";
            this.DeleteSub.UseVisualStyleBackColor = true;
            this.DeleteSub.Click += new System.EventHandler(this.DeleteSub_Click);
            // 
            // EditSub
            // 
            this.EditSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSub.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSub.ForeColor = System.Drawing.Color.Lime;
            this.EditSub.Location = new System.Drawing.Point(9, 123);
            this.EditSub.Name = "EditSub";
            this.EditSub.Size = new System.Drawing.Size(91, 49);
            this.EditSub.TabIndex = 1;
            this.EditSub.Text = "Edit Sub";
            this.EditSub.UseVisualStyleBackColor = true;
            this.EditSub.Click += new System.EventHandler(this.EditSub_Click);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Lime;
            this.AddButton.Location = new System.Drawing.Point(9, 26);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 49);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Sub";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubListBox
            // 
            this.SubListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubListBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubListBox.ForeColor = System.Drawing.Color.Indigo;
            this.SubListBox.FormattingEnabled = true;
            this.SubListBox.ItemHeight = 24;
            this.SubListBox.Items.AddRange(new object[] {
            "Name-Hull-Power-Speed-Depth"});
            this.SubListBox.Location = new System.Drawing.Point(11, 9);
            this.SubListBox.Name = "SubListBox";
            this.SubListBox.Size = new System.Drawing.Size(377, 220);
            this.SubListBox.TabIndex = 0;
            this.SubListBox.SelectedIndexChanged += new System.EventHandler(this.SubListBox_SelectedIndexChanged);
            // 
            // SubCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(798, 603);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SubCommander";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submarine Commander";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.FeaturePanel.ResumeLayout(false);
            this.FeaturePanel.PerformLayout();
            this.MainControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ListBox SubListBox;
        private System.Windows.Forms.Panel FeaturePanel;
        private System.Windows.Forms.Button PowerDownButton;
        private System.Windows.Forms.Button PowerUpButton;
        private System.Windows.Forms.TextBox HullNumTextBox;
        private System.Windows.Forms.Label HullNumLabel;
        private System.Windows.Forms.TextBox SubNameTextBox;
        private System.Windows.Forms.Label SubNameLabel;
        private System.Windows.Forms.Panel MainControlPanel;
        private System.Windows.Forms.Button DeleteSub;
        private System.Windows.Forms.Button EditSub;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DepthDown;
        private System.Windows.Forms.Button DepthUp;
        private System.Windows.Forms.Label DepthDisplay;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Button SpeedDownButton;
        private System.Windows.Forms.Button SpeedUpButton;
        private System.Windows.Forms.Label SpeedDisplay;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Button SWButton;
        private System.Windows.Forms.Button SEButton;
        private System.Windows.Forms.Button WButton;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button NWButton;
        private System.Windows.Forms.Button NEButton;
        private System.Windows.Forms.Button NButton;
        private System.Windows.Forms.Label CourseDisplay;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Button FireMissileButton;
        private System.Windows.Forms.Label MissileLabel;
        private System.Windows.Forms.Button FireTorpedoButton;
        private System.Windows.Forms.Label TorpedoLabel;
        private System.Windows.Forms.Label WeaponLabel;
        private System.Windows.Forms.RichTextBox StatusRTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label PowerDisplayLabel;
        private System.Windows.Forms.Label powerLabel;
    }
}

