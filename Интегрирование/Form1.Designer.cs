
namespace Интегрирование
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Functions = new System.Windows.Forms.ComboBox();
            this.FunctionIMG = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.FunctionImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FunctionIMG)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Functions
            // 
            this.Functions.FormattingEnabled = true;
            this.Functions.Items.AddRange(new object[] {
            "Функция №1",
            "Функция №2",
            "Функция №3",
            "Функция №4",
            "Функция №5"});
            this.Functions.Location = new System.Drawing.Point(105, 40);
            this.Functions.Name = "Functions";
            this.Functions.Size = new System.Drawing.Size(153, 21);
            this.Functions.TabIndex = 0;
            this.Functions.SelectedIndexChanged += new System.EventHandler(this.Functions_SelectedIndexChanged);
            // 
            // FunctionIMG
            // 
            this.FunctionIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FunctionIMG.InitialImage = null;
            this.FunctionIMG.Location = new System.Drawing.Point(105, 67);
            this.FunctionIMG.Name = "FunctionIMG";
            this.FunctionIMG.Size = new System.Drawing.Size(153, 35);
            this.FunctionIMG.TabIndex = 1;
            this.FunctionIMG.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите функцию:";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(105, 37);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(153, 20);
            this.Result.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.Functions);
            this.panel1.Controls.Add(this.FunctionIMG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(360, 166);
            this.panel1.TabIndex = 4;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(105, 108);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(153, 47);
            this.Info.TabIndex = 3;
            this.Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(132, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(118, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Погрешность:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Error);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Result);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 184);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(360, 133);
            this.panel2.TabIndex = 5;
            // 
            // Error
            // 
            this.Error.Location = new System.Drawing.Point(105, 95);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(153, 20);
            this.Error.TabIndex = 6;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 323);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(360, 36);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // FunctionImages
            // 
            this.FunctionImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FunctionImages.ImageStream")));
            this.FunctionImages.TransparentColor = System.Drawing.Color.Transparent;
            this.FunctionImages.Images.SetKeyName(0, "Function 1.PNG");
            this.FunctionImages.Images.SetKeyName(1, "Function 2.PNG");
            this.FunctionImages.Images.SetKeyName(2, "Function 3.PNG");
            this.FunctionImages.Images.SetKeyName(3, "Function 4.PNG");
            this.FunctionImages.Images.SetKeyName(4, "Function 5.PNG");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 369);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Интегрирование";
            ((System.ComponentModel.ISupportInitialize)(this.FunctionIMG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Functions;
        private System.Windows.Forms.PictureBox FunctionIMG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Error;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ImageList FunctionImages;
    }
}

