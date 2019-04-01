namespace Genetic_Travelling_salesman_problem
{
    partial class Genetic_Travelling_Salesman_problem
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
            this.tourDiagram = new System.Windows.Forms.PictureBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.mutationRateTextBox = new System.Windows.Forms.TextBox();
            this.maxPopulationTextBox = new System.Windows.Forms.TextBox();
            this.truckSizePopulationTextBox = new System.Windows.Forms.TextBox();
            this.nearCityTextBox = new System.Windows.Forms.TextBox();
            this.XMLFilePathTextBox = new System.Windows.Forms.TextBox();
            this.populationLabel = new System.Windows.Forms.Label();
            this.truckSizePopulationLabel = new System.Windows.Forms.Label();
            this.nearCityLabel = new System.Windows.Forms.Label();
            this.maxGenerationsLabel = new System.Windows.Forms.Label();
            this.mutationRateLabel = new System.Windows.Forms.Label();
            this.XMLFilePathLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pushLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.cityDrawButton = new System.Windows.Forms.Button();
            this.cityCountDescriptionLabel = new System.Windows.Forms.Label();
            this.cityCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // tourDiagram
            // 
            this.tourDiagram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tourDiagram.Location = new System.Drawing.Point(12, 12);
            this.tourDiagram.Name = "tourDiagram";
            this.tourDiagram.Size = new System.Drawing.Size(536, 328);
            this.tourDiagram.TabIndex = 0;
            this.tourDiagram.TabStop = false;
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(12, 403);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(100, 20);
            this.populationTextBox.TabIndex = 1;
            // 
            // mutationRateTextBox
            // 
            this.mutationRateTextBox.Location = new System.Drawing.Point(12, 480);
            this.mutationRateTextBox.Name = "mutationRateTextBox";
            this.mutationRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.mutationRateTextBox.TabIndex = 2;
            // 
            // maxPopulationTextBox
            // 
            this.maxPopulationTextBox.Location = new System.Drawing.Point(132, 480);
            this.maxPopulationTextBox.Name = "maxPopulationTextBox";
            this.maxPopulationTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxPopulationTextBox.TabIndex = 3;
            // 
            // truckSizePopulationTextBox
            // 
            this.truckSizePopulationTextBox.Location = new System.Drawing.Point(132, 403);
            this.truckSizePopulationTextBox.Name = "truckSizePopulationTextBox";
            this.truckSizePopulationTextBox.Size = new System.Drawing.Size(100, 20);
            this.truckSizePopulationTextBox.TabIndex = 4;
            // 
            // nearCityTextBox
            // 
            this.nearCityTextBox.Location = new System.Drawing.Point(252, 403);
            this.nearCityTextBox.Name = "nearCityTextBox";
            this.nearCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.nearCityTextBox.TabIndex = 5;
            // 
            // XMLFilePathTextBox
            // 
            this.XMLFilePathTextBox.Location = new System.Drawing.Point(375, 403);
            this.XMLFilePathTextBox.Name = "XMLFilePathTextBox";
            this.XMLFilePathTextBox.Size = new System.Drawing.Size(173, 20);
            this.XMLFilePathTextBox.TabIndex = 6;
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(16, 384);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(62, 13);
            this.populationLabel.TabIndex = 9;
            this.populationLabel.Text = "Популяция";
            // 
            // truckSizePopulationLabel
            // 
            this.truckSizePopulationLabel.Location = new System.Drawing.Point(136, 369);
            this.truckSizePopulationLabel.Name = "truckSizePopulationLabel";
            this.truckSizePopulationLabel.Size = new System.Drawing.Size(100, 31);
            this.truckSizePopulationLabel.TabIndex = 10;
            this.truckSizePopulationLabel.Text = "Число особей в популяции";
            // 
            // nearCityLabel
            // 
            this.nearCityLabel.Location = new System.Drawing.Point(252, 369);
            this.nearCityLabel.Name = "nearCityLabel";
            this.nearCityLabel.Size = new System.Drawing.Size(100, 31);
            this.nearCityLabel.TabIndex = 11;
            this.nearCityLabel.Text = "Число городов-соседей";
            // 
            // maxGenerationsLabel
            // 
            this.maxGenerationsLabel.Location = new System.Drawing.Point(136, 443);
            this.maxGenerationsLabel.Name = "maxGenerationsLabel";
            this.maxGenerationsLabel.Size = new System.Drawing.Size(100, 34);
            this.maxGenerationsLabel.TabIndex = 12;
            this.maxGenerationsLabel.Text = "Максимальное число популяций";
            // 
            // mutationRateLabel
            // 
            this.mutationRateLabel.Location = new System.Drawing.Point(12, 443);
            this.mutationRateLabel.Name = "mutationRateLabel";
            this.mutationRateLabel.Size = new System.Drawing.Size(100, 34);
            this.mutationRateLabel.TabIndex = 13;
            this.mutationRateLabel.Text = "Вероятность мутации";
            // 
            // XMLFilePathLabel
            // 
            this.XMLFilePathLabel.AutoSize = true;
            this.XMLFilePathLabel.Location = new System.Drawing.Point(375, 384);
            this.XMLFilePathLabel.Name = "XMLFilePathLabel";
            this.XMLFilePathLabel.Size = new System.Drawing.Size(173, 13);
            this.XMLFilePathLabel.TabIndex = 14;
            this.XMLFilePathLabel.Text = "Путь для XML файла с городами";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 480);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // pushLabel
            // 
            this.pushLabel.Location = new System.Drawing.Point(252, 436);
            this.pushLabel.Name = "pushLabel";
            this.pushLabel.Size = new System.Drawing.Size(100, 41);
            this.pushLabel.TabIndex = 16;
            this.pushLabel.Text = "Точка начала генерации первой популяции";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(375, 431);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(173, 36);
            this.browseButton.TabIndex = 17;
            this.browseButton.Text = "Открыть файл с координатами городов";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // cityDrawButton
            // 
            this.cityDrawButton.Location = new System.Drawing.Point(375, 480);
            this.cityDrawButton.Name = "cityDrawButton";
            this.cityDrawButton.Size = new System.Drawing.Size(173, 23);
            this.cityDrawButton.TabIndex = 18;
            this.cityDrawButton.Text = "Нарисовать карту городов";
            this.cityDrawButton.UseVisualStyleBackColor = true;
            // 
            // cityCountDescriptionLabel
            // 
            this.cityCountDescriptionLabel.Location = new System.Drawing.Point(554, 12);
            this.cityCountDescriptionLabel.Name = "cityCountDescriptionLabel";
            this.cityCountDescriptionLabel.Size = new System.Drawing.Size(100, 23);
            this.cityCountDescriptionLabel.TabIndex = 19;
            this.cityCountDescriptionLabel.Text = "Число городов :";
            // 
            // cityCountLabel
            // 
            this.cityCountLabel.AutoSize = true;
            this.cityCountLabel.Location = new System.Drawing.Point(660, 12);
            this.cityCountLabel.Name = "cityCountLabel";
            this.cityCountLabel.Size = new System.Drawing.Size(0, 13);
            this.cityCountLabel.TabIndex = 20;
            // 
            // Genetic_Travelling_Salesman_problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.cityCountLabel);
            this.Controls.Add(this.cityCountDescriptionLabel);
            this.Controls.Add(this.cityDrawButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pushLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.XMLFilePathLabel);
            this.Controls.Add(this.mutationRateLabel);
            this.Controls.Add(this.maxGenerationsLabel);
            this.Controls.Add(this.nearCityLabel);
            this.Controls.Add(this.truckSizePopulationLabel);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.XMLFilePathTextBox);
            this.Controls.Add(this.nearCityTextBox);
            this.Controls.Add(this.truckSizePopulationTextBox);
            this.Controls.Add(this.maxPopulationTextBox);
            this.Controls.Add(this.mutationRateTextBox);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.tourDiagram);
            this.Name = "Genetic_Travelling_Salesman_problem";
            this.Text = "Genetic SalesMan Problem@Roma";
            ((System.ComponentModel.ISupportInitialize)(this.tourDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tourDiagram;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox mutationRateTextBox;
        private System.Windows.Forms.TextBox maxPopulationTextBox;
        private System.Windows.Forms.TextBox truckSizePopulationTextBox;
        private System.Windows.Forms.TextBox nearCityTextBox;
        private System.Windows.Forms.TextBox XMLFilePathTextBox;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label truckSizePopulationLabel;
        private System.Windows.Forms.Label nearCityLabel;
        private System.Windows.Forms.Label maxGenerationsLabel;
        private System.Windows.Forms.Label mutationRateLabel;
        private System.Windows.Forms.Label XMLFilePathLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pushLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button cityDrawButton;
        private System.Windows.Forms.Label cityCountDescriptionLabel;
        private System.Windows.Forms.Label cityCountLabel;
    }
}

