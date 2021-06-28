using System.ComponentModel;

namespace Proyecto_POO_DB
{
    partial class FrmVaccine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateQueue = new System.Windows.Forms.Label();
            this.lblDateVaccine = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblEffect = new System.Windows.Forms.Label();
            this.lblMinuteEff = new System.Windows.Forms.Label();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnVaccine = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtEffect = new System.Windows.Forms.TextBox();
            this.cmbMinuteEffect = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.lblDateQueue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDateVaccine, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuestion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEffect, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMinuteEff, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnQueue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVaccine, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFinish, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtEffect, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbMinuteEffect, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 539);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDateQueue
            // 
            this.lblDateQueue.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateQueue.BackColor = System.Drawing.SystemColors.Window;
            this.lblDateQueue.Location = new System.Drawing.Point(214, 53);
            this.lblDateQueue.Name = "lblDateQueue";
            this.lblDateQueue.Size = new System.Drawing.Size(182, 70);
            this.lblDateQueue.TabIndex = 0;
            this.lblDateQueue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateVaccine
            // 
            this.lblDateVaccine.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateVaccine.BackColor = System.Drawing.SystemColors.Window;
            this.lblDateVaccine.Location = new System.Drawing.Point(214, 123);
            this.lblDateVaccine.Name = "lblDateVaccine";
            this.lblDateVaccine.Size = new System.Drawing.Size(182, 70);
            this.lblDateVaccine.TabIndex = 1;
            this.lblDateVaccine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lblQuestion, 2);
            this.lblQuestion.Location = new System.Drawing.Point(50, 193);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(346, 70);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Mostro algun efecto secundario?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblEffect
            // 
            this.lblEffect.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEffect.Location = new System.Drawing.Point(50, 263);
            this.lblEffect.Name = "lblEffect";
            this.lblEffect.Size = new System.Drawing.Size(158, 70);
            this.lblEffect.TabIndex = 5;
            this.lblEffect.Text = "Efecto secundario:";
            this.lblEffect.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMinuteEff
            // 
            this.lblMinuteEff.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinuteEff.Location = new System.Drawing.Point(50, 333);
            this.lblMinuteEff.Name = "lblMinuteEff";
            this.lblMinuteEff.Size = new System.Drawing.Size(158, 70);
            this.lblMinuteEff.TabIndex = 6;
            this.lblMinuteEff.Text = "Minutos que tardo en mostrarlo:";
            this.lblMinuteEff.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnQueue
            // 
            this.btnQueue.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueue.Location = new System.Drawing.Point(50, 56);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(158, 64);
            this.btnQueue.TabIndex = 7;
            this.btnQueue.Text = "Tomar hora de llegada";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnVaccine
            // 
            this.btnVaccine.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaccine.Location = new System.Drawing.Point(50, 126);
            this.btnVaccine.Name = "btnVaccine";
            this.btnVaccine.Size = new System.Drawing.Size(158, 64);
            this.btnVaccine.TabIndex = 8;
            this.btnVaccine.Text = "Tomar hora de vacuna";
            this.btnVaccine.UseVisualStyleBackColor = true;
            this.btnVaccine.Click += new System.EventHandler(this.btnVaccine_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnFinish, 2);
            this.btnFinish.Location = new System.Drawing.Point(50, 406);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(346, 74);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Procesar datos";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtEffect
            // 
            this.txtEffect.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEffect.Location = new System.Drawing.Point(214, 266);
            this.txtEffect.Name = "txtEffect";
            this.txtEffect.Size = new System.Drawing.Size(182, 27);
            this.txtEffect.TabIndex = 10;
            // 
            // cmbMinuteEffect
            // 
            this.cmbMinuteEffect.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMinuteEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinuteEffect.FormattingEnabled = true;
            this.cmbMinuteEffect.Items.AddRange(new object[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"});
            this.cmbMinuteEffect.Location = new System.Drawing.Point(214, 336);
            this.cmbMinuteEffect.Name = "cmbMinuteEffect";
            this.cmbMinuteEffect.Size = new System.Drawing.Size(182, 30);
            this.cmbMinuteEffect.TabIndex = 11;
            // 
            // FrmVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(494, 565);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de vacunacion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cmbMinuteEffect;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox txtEffect;

        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnVaccine;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label lblMinuteEff;
        private System.Windows.Forms.Label lblEffect;

        private System.Windows.Forms.Label lblQuestion;

        private System.Windows.Forms.Label lblDateVaccine;

        private System.Windows.Forms.Label lblDateQueue;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSecondEff;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}