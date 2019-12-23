namespace WindowsFormsTrolleybus
{
    partial class FormTrolleybus
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTrolleybus = new System.Windows.Forms.PictureBox();
            this.buttonCreateBus = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCreateTrolleybus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrolleybus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTrolleybus
            // 
            this.pictureBoxTrolleybus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTrolleybus.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrolleybus.Name = "pictureBoxTrolleybus";
            this.pictureBoxTrolleybus.Size = new System.Drawing.Size(882, 453);
            this.pictureBoxTrolleybus.TabIndex = 0;
            this.pictureBoxTrolleybus.TabStop = false;
            // 
            // buttonCreateBus
            // 
            this.buttonCreateBus.Location = new System.Drawing.Point(13, 13);
            this.buttonCreateBus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateBus.Name = "buttonCreateBus";

            this.buttonCreateBus.Size = new System.Drawing.Size(204, 28);

            this.buttonCreateBus.TabIndex = 3;
            this.buttonCreateBus.Text = "Создать автобус";
            this.buttonCreateBus.UseVisualStyleBackColor = true;
            this.buttonCreateBus.Click += new System.EventHandler(this.buttonCreateBus_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsTrolleybus.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(755, 357);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 37);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsTrolleybus.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(803, 386);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 37);
            this.buttonRight.TabIndex = 8;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsTrolleybus.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(755, 402);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 37);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsTrolleybus.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(707, 386);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 37);
            this.buttonLeft.TabIndex = 10;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.UseWaitCursor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateTrolleybus
            // 

            this.buttonCreateTrolleybus.Location = new System.Drawing.Point(271, 13);
            this.buttonCreateTrolleybus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateTrolleybus.Name = "buttonCreateTrolleybus";
            this.buttonCreateTrolleybus.Size = new System.Drawing.Size(204, 28);

            this.buttonCreateTrolleybus.TabIndex = 11;
            this.buttonCreateTrolleybus.Text = "Создать троллейбус";
            this.buttonCreateTrolleybus.UseVisualStyleBackColor = true;
            this.buttonCreateTrolleybus.Click += new System.EventHandler(this.buttonCreateTrolleybus_Click);
            // 
            // FormTrolleybus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.buttonCreateTrolleybus);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateBus);
            this.Controls.Add(this.pictureBoxTrolleybus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTrolleybus";
            this.Text = "Троллейбус";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrolleybus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrolleybus;
        private System.Windows.Forms.Button buttonCreateBus;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCreateTrolleybus;
    }
}

