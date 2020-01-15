namespace WindowsFormsTrolleybus
{
    partial class FormBusStation
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
            this.pictureBoxStation = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxTake = new System.Windows.Forms.GroupBox();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.pictureBoxTakeBus = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelTake = new System.Windows.Forms.Label();

            this.labelLevel = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonSetBus = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStation)).BeginInit();
            this.maskedTextBoxTake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStation
            // 
            this.pictureBoxStation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxStation.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStation.Name = "pictureBoxStation";
            this.pictureBoxStation.Size = new System.Drawing.Size(1143, 615);
            this.pictureBoxStation.TabIndex = 0;
            this.pictureBoxStation.TabStop = false;
            // 
            // maskedTextBoxTake
            // 
            this.maskedTextBoxTake.Controls.Add(this.buttonTakeBus);
            this.maskedTextBoxTake.Controls.Add(this.pictureBoxTakeBus);
            this.maskedTextBoxTake.Controls.Add(this.maskedTextBoxPlace);
            this.maskedTextBoxTake.Controls.Add(this.labelPlace);
            this.maskedTextBoxTake.Controls.Add(this.labelTake);
            this.maskedTextBoxTake.Location = new System.Drawing.Point(1149, 353);
            this.maskedTextBoxTake.Name = "maskedTextBoxTake";
            this.maskedTextBoxTake.Size = new System.Drawing.Size(171, 233);
            this.maskedTextBoxTake.TabIndex = 3;
            this.maskedTextBoxTake.TabStop = false;
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(33, 86);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(96, 32);
            this.buttonTakeBus.TabIndex = 7;
            this.buttonTakeBus.Text = "Забрать";
            this.buttonTakeBus.UseVisualStyleBackColor = true;
            this.buttonTakeBus.Click += new System.EventHandler(this.buttonTakeBus_Click);
            // 
            // pictureBoxTakeBus
            // 
            this.pictureBoxTakeBus.Location = new System.Drawing.Point(0, 143);
            this.pictureBoxTakeBus.Name = "pictureBoxTakeBus";
            this.pictureBoxTakeBus.Size = new System.Drawing.Size(169, 90);
            this.pictureBoxTakeBus.TabIndex = 0;
            this.pictureBoxTakeBus.TabStop = false;
            // 
            // maskedTextBoxPlace

            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(74, 48);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(55, 22);
            this.maskedTextBoxPlace.TabIndex = 5;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(15, 51);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 6;
            this.labelPlace.Text = "Место:";
            // 
            // labelTake
            // 
            this.labelTake.AutoSize = true;
            this.labelTake.Location = new System.Drawing.Point(24, 18);
            this.labelTake.Name = "labelTake";
            this.labelTake.Size = new System.Drawing.Size(119, 17);
            this.labelTake.TabIndex = 4;
            this.labelTake.Text = "Забрать автобус";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(1201, 9);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(56, 17);
            this.labelLevel.TabIndex = 4;
            this.labelLevel.Text = "Уровни";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(1161, 35);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(156, 116);
            this.listBoxLevels.TabIndex = 5;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);

            // 
            // buttonSetBus
            // 
            this.buttonSetBus.Location = new System.Drawing.Point(1169, 208);
            this.buttonSetBus.Name = "buttonSetBus";
            this.buttonSetBus.Size = new System.Drawing.Size(148, 40);
            this.buttonSetBus.TabIndex = 6;
            this.buttonSetBus.Text = "Заказать автобус";
            this.buttonSetBus.UseVisualStyleBackColor = true;
            this.buttonSetBus.Click += new System.EventHandler(this.buttonSetBus_Click_1);
            // 
            // FormBusStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 615);
            this.Controls.Add(this.buttonSetBus);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.maskedTextBoxTake);
            this.Controls.Add(this.pictureBoxStation);
            this.Name = "FormBusStation";
            this.Text = "Автовокзал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStation)).EndInit();
            this.maskedTextBoxTake.ResumeLayout(false);
            this.maskedTextBoxTake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStation;
        private System.Windows.Forms.GroupBox maskedTextBoxTake;
        private System.Windows.Forms.Label labelTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.PictureBox pictureBoxTakeBus;
        private System.Windows.Forms.Button buttonTakeBus;

        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonSetBus;

    }
}
