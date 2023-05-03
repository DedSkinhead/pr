namespace Factory
{
    partial class FactoryWorker
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.Возраст = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.WorkerTable = new System.Windows.Forms.DataGridView();
            this.Zplabel = new System.Windows.Forms.Label();
            this.Dol = new System.Windows.Forms.Label();
            this.Dollabel = new System.Windows.Forms.Label();
            this.ZP = new System.Windows.Forms.Label();
            this.Doc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(141, 22);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(41, 13);
            this.FIOLabel.TabIndex = 1;
            this.FIOLabel.Text = "ФИО:";
            // 
            // Возраст
            // 
            this.Возраст.AutoSize = true;
            this.Возраст.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Возраст.Location = new System.Drawing.Point(141, 47);
            this.Возраст.Name = "Возраст";
            this.Возраст.Size = new System.Drawing.Size(60, 13);
            this.Возраст.TabIndex = 2;
            this.Возраст.Text = "Возраст:";
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(190, 22);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(0, 13);
            this.FIO.TabIndex = 4;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(207, 47);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(0, 13);
            this.Age.TabIndex = 5;
            // 
            // WorkerTable
            // 
            this.WorkerTable.AllowUserToResizeColumns = false;
            this.WorkerTable.AllowUserToResizeRows = false;
            this.WorkerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerTable.Location = new System.Drawing.Point(12, 160);
            this.WorkerTable.Name = "WorkerTable";
            this.WorkerTable.Size = new System.Drawing.Size(776, 285);
            this.WorkerTable.TabIndex = 6;
            // 
            // Zplabel
            // 
            this.Zplabel.AutoSize = true;
            this.Zplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zplabel.Location = new System.Drawing.Point(141, 99);
            this.Zplabel.Name = "Zplabel";
            this.Zplabel.Size = new System.Drawing.Size(122, 13);
            this.Zplabel.TabIndex = 7;
            this.Zplabel.Text = "Зарплата за месяц";
            // 
            // Dol
            // 
            this.Dol.AutoSize = true;
            this.Dol.Location = new System.Drawing.Point(225, 72);
            this.Dol.Name = "Dol";
            this.Dol.Size = new System.Drawing.Size(0, 13);
            this.Dol.TabIndex = 9;
            // 
            // Dollabel
            // 
            this.Dollabel.AutoSize = true;
            this.Dollabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dollabel.Location = new System.Drawing.Point(141, 72);
            this.Dollabel.Name = "Dollabel";
            this.Dollabel.Size = new System.Drawing.Size(78, 13);
            this.Dollabel.TabIndex = 10;
            this.Dollabel.Text = "Должность:";
            // 
            // ZP
            // 
            this.ZP.AutoSize = true;
            this.ZP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZP.Location = new System.Drawing.Point(269, 99);
            this.ZP.Name = "ZP";
            this.ZP.Size = new System.Drawing.Size(0, 13);
            this.ZP.TabIndex = 11;
            // 
            // Doc
            // 
            this.Doc.Location = new System.Drawing.Point(662, 131);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(126, 23);
            this.Doc.TabIndex = 12;
            this.Doc.Text = "Загрузить документ";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // FactoryWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.ZP);
            this.Controls.Add(this.Dollabel);
            this.Controls.Add(this.Dol);
            this.Controls.Add(this.Zplabel);
            this.Controls.Add(this.WorkerTable);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Возраст);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FactoryWorker";
            this.Text = "FactoryWorker";
            this.Load += new System.EventHandler(this.FactoryWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label Возраст;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.DataGridView WorkerTable;
        private System.Windows.Forms.Label Zplabel;
        private System.Windows.Forms.Label Dol;
        private System.Windows.Forms.Label Dollabel;
        private System.Windows.Forms.Label ZP;
        private System.Windows.Forms.Button Doc;
    }
}