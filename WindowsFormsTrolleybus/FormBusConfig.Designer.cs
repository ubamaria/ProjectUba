namespace WindowsFormsTrolleybus
{
    partial class FormBusConfig
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
            this.pictureBoxBus = new System.Windows.Forms.PictureBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelTrolleybus = new System.Windows.Forms.Label();
            this.labelBus = new System.Windows.Forms.Label();
            this.panelBus = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelorange = new System.Windows.Forms.Panel();
            this.panelgray = new System.Windows.Forms.Panel();
            this.panelyellow = new System.Windows.Forms.Panel();
            this.panelred = new System.Windows.Forms.Panel();
            this.panelblue = new System.Windows.Forms.Panel();
            this.panelgreen = new System.Windows.Forms.Panel();
            this.panelwhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelBus.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBus
            // 
            this.pictureBoxBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBus.Location = new System.Drawing.Point(23, 19);
            this.pictureBoxBus.Name = "pictureBoxBus";
            this.pictureBoxBus.Size = new System.Drawing.Size(166, 98);
            this.pictureBoxBus.TabIndex = 0;
            this.pictureBoxBus.TabStop = false;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelTrolleybus);
            this.groupBoxType.Controls.Add(this.labelBus);
            this.groupBoxType.Location = new System.Drawing.Point(24, 36);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(168, 171);
            this.groupBoxType.TabIndex = 1;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип кузова";
            // 
            // labelTrolleybus
            // 
            this.labelTrolleybus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrolleybus.Location = new System.Drawing.Point(14, 107);
            this.labelTrolleybus.Name = "labelTrolleybus";
            this.labelTrolleybus.Size = new System.Drawing.Size(135, 41);
            this.labelTrolleybus.TabIndex = 1;
            this.labelTrolleybus.Text = "Троллейбус";
            this.labelTrolleybus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrolleybus_MouseDown);
            // 
            // labelBus
            // 
            this.labelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBus.Location = new System.Drawing.Point(14, 50);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(135, 42);
            this.labelBus.TabIndex = 0;
            this.labelBus.Text = "Обычный автобус";
            this.labelBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBus_MouseDown);
            // 
            // panelBus
            // 
            this.panelBus.AllowDrop = true;
            this.panelBus.Controls.Add(this.labelDopColor);
            this.panelBus.Controls.Add(this.labelMainColor);
            this.panelBus.Controls.Add(this.pictureBoxBus);
            this.panelBus.Location = new System.Drawing.Point(208, 36);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(202, 286);
            this.panelBus.TabIndex = 2;
            this.panelBus.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBus_DragDrop);
            this.panelBus.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBus_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(26, 209);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(163, 39);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(26, 152);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(163, 47);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelorange);
            this.groupBoxColor.Controls.Add(this.panelgray);
            this.groupBoxColor.Controls.Add(this.panelyellow);
            this.groupBoxColor.Controls.Add(this.panelred);
            this.groupBoxColor.Controls.Add(this.panelblue);
            this.groupBoxColor.Controls.Add(this.panelgreen);
            this.groupBoxColor.Controls.Add(this.panelwhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(450, 36);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(158, 286);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelorange
            // 
            this.panelorange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelorange.Location = new System.Drawing.Point(88, 209);
            this.panelorange.Name = "panelorange";
            this.panelorange.Size = new System.Drawing.Size(40, 39);
            this.panelorange.TabIndex = 1;
            // 
            // panelgray
            // 
            this.panelgray.BackColor = System.Drawing.Color.Silver;
            this.panelgray.Location = new System.Drawing.Point(19, 209);
            this.panelgray.Name = "panelgray";
            this.panelgray.Size = new System.Drawing.Size(40, 39);
            this.panelgray.TabIndex = 1;
            // 
            // panelyellow
            // 
            this.panelyellow.BackColor = System.Drawing.Color.Yellow;
            this.panelyellow.Location = new System.Drawing.Point(88, 149);
            this.panelyellow.Name = "panelyellow";
            this.panelyellow.Size = new System.Drawing.Size(40, 39);
            this.panelyellow.TabIndex = 1;
            // 
            // panelred
            // 
            this.panelred.BackColor = System.Drawing.Color.Red;
            this.panelred.Location = new System.Drawing.Point(19, 149);
            this.panelred.Name = "panelred";
            this.panelred.Size = new System.Drawing.Size(40, 39);
            this.panelred.TabIndex = 1;
            // 
            // panelblue
            // 
            this.panelblue.BackColor = System.Drawing.Color.Blue;
            this.panelblue.Location = new System.Drawing.Point(88, 92);
            this.panelblue.Name = "panelblue";
            this.panelblue.Size = new System.Drawing.Size(40, 39);
            this.panelblue.TabIndex = 1;
            // 
            // panelgreen
            // 
            this.panelgreen.BackColor = System.Drawing.Color.Green;
            this.panelgreen.Location = new System.Drawing.Point(19, 92);
            this.panelgreen.Name = "panelgreen";
            this.panelgreen.Size = new System.Drawing.Size(40, 39);
            this.panelgreen.TabIndex = 1;
            // 
            // panelwhite
            // 
            this.panelwhite.BackColor = System.Drawing.Color.White;
            this.panelwhite.Location = new System.Drawing.Point(88, 36);
            this.panelwhite.Name = "panelwhite";
            this.panelwhite.Size = new System.Drawing.Size(40, 39);
            this.panelwhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(19, 36);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 39);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 222);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(43, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 41);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 334);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelBus);
            this.Controls.Add(this.groupBoxType);
            this.Name = "FormBusConfig";
            this.Text = "FormBusConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelBus.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBus;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Label labelTrolleybus;
        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelorange;
        private System.Windows.Forms.Panel panelgray;
        private System.Windows.Forms.Panel panelyellow;
        private System.Windows.Forms.Panel panelred;
        private System.Windows.Forms.Panel panelblue;
        private System.Windows.Forms.Panel panelgreen;
        private System.Windows.Forms.Panel panelwhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}