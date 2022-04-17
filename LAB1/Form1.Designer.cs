namespace LAB1
{
    partial class Form1
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
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.axisList = new System.Windows.Forms.ListBox();
            this.axisLabel = new System.Windows.Forms.Label();
            this.angleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(-4, -3);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(661, 453);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.initDraw);
            // 
            // axisList
            // 
            this.axisList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.axisList.FormattingEnabled = true;
            this.axisList.ItemHeight = 24;
            this.axisList.Items.AddRange(new object[] {
            "Ось Х",
            "Ось Y",
            "Ось Z"});
            this.axisList.Location = new System.Drawing.Point(697, 81);
            this.axisList.Name = "axisList";
            this.axisList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.axisList.Size = new System.Drawing.Size(66, 76);
            this.axisList.TabIndex = 1;
            // 
            // axisLabel
            // 
            this.axisLabel.AutoSize = true;
            this.axisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.axisLabel.Location = new System.Drawing.Point(663, 54);
            this.axisLabel.Name = "axisLabel";
            this.axisLabel.Size = new System.Drawing.Size(137, 24);
            this.axisLabel.TabIndex = 2;
            this.axisLabel.Text = "Выберите ось";
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleLabel.Location = new System.Drawing.Point(663, 174);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(131, 24);
            this.angleLabel.TabIndex = 3;
            this.angleLabel.Text = "Укажите угол";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(663, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Повернуть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rotateBtn);
            // 
            // angleTextBox
            // 
            this.angleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleTextBox.Location = new System.Drawing.Point(667, 201);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(125, 29);
            this.angleTextBox.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(667, 386);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(125, 52);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.angleTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.axisLabel);
            this.Controls.Add(this.axisList);
            this.Controls.Add(this.openGLControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.ListBox axisList;
        private System.Windows.Forms.Label axisLabel;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Button resetButton;
    }
}

