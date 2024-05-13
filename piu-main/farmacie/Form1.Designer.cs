namespace PMS2
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
            this.flowLayoutPanelMedicamente = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtProducator = new System.Windows.Forms.TextBox();
            this.nudPret = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.flowLayoutPanelRezultate = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDisponibilitate = new System.Windows.Forms.CheckBox();
            this.radioButtonCuCard = new System.Windows.Forms.RadioButton();
            this.radioButtonFaraCard = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMedicamente
            // 
            this.flowLayoutPanelMedicamente.BackColor = System.Drawing.Color.IndianRed;
            this.flowLayoutPanelMedicamente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelMedicamente.Location = new System.Drawing.Point(66, 110);
            this.flowLayoutPanelMedicamente.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelMedicamente.Name = "flowLayoutPanelMedicamente";
            this.flowLayoutPanelMedicamente.Size = new System.Drawing.Size(482, 84);
            this.flowLayoutPanelMedicamente.TabIndex = 0;
            this.flowLayoutPanelMedicamente.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMedicamente_Paint);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(66, 30);
            this.txtNume.Margin = new System.Windows.Forms.Padding(2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(76, 20);
            this.txtNume.TabIndex = 2;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtProducator
            // 
            this.txtProducator.Location = new System.Drawing.Point(242, 32);
            this.txtProducator.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.Size = new System.Drawing.Size(76, 20);
            this.txtProducator.TabIndex = 3;
            this.txtProducator.TextChanged += new System.EventHandler(this.txtProducator_TextChanged);
            // 
            // nudPret
            // 
            this.nudPret.Location = new System.Drawing.Point(545, 35);
            this.nudPret.Margin = new System.Windows.Forms.Padding(2);
            this.nudPret.Name = "nudPret";
            this.nudPret.Size = new System.Drawing.Size(90, 20);
            this.nudPret.TabIndex = 4;
            this.nudPret.ValueChanged += new System.EventHandler(this.nudPret_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(260, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(409, 35);
            this.txtCantitate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(76, 20);
            this.txtCantitate.TabIndex = 6;
            this.txtCantitate.TextChanged += new System.EventHandler(this.txtCantitate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADAUGARE MEDICAMENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "TIP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRODUCATOR:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CANTITATE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRET:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(66, 222);
            this.txtCautare.Margin = new System.Windows.Forms.Padding(2);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(76, 20);
            this.txtCautare.TabIndex = 12;
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.IndianRed;
            this.btnCauta.Location = new System.Drawing.Point(260, 221);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(56, 19);
            this.btnCauta.TabIndex = 13;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click_1);
            // 
            // flowLayoutPanelRezultate
            // 
            this.flowLayoutPanelRezultate.BackColor = System.Drawing.Color.IndianRed;
            this.flowLayoutPanelRezultate.Location = new System.Drawing.Point(66, 277);
            this.flowLayoutPanelRezultate.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelRezultate.Name = "flowLayoutPanelRezultate";
            this.flowLayoutPanelRezultate.Size = new System.Drawing.Size(482, 86);
            this.flowLayoutPanelRezultate.TabIndex = 14;
            // 
            // checkBoxDisponibilitate
            // 
            this.checkBoxDisponibilitate.AutoSize = true;
            this.checkBoxDisponibilitate.Location = new System.Drawing.Point(346, 221);
            this.checkBoxDisponibilitate.Name = "checkBoxDisponibilitate";
            this.checkBoxDisponibilitate.Size = new System.Drawing.Size(91, 17);
            this.checkBoxDisponibilitate.TabIndex = 15;
            this.checkBoxDisponibilitate.Text = "Disponibilitate";
            this.checkBoxDisponibilitate.UseVisualStyleBackColor = true;
            // 
            // radioButtonCuCard
            // 
            this.radioButtonCuCard.AutoSize = true;
            this.radioButtonCuCard.Location = new System.Drawing.Point(66, 77);
            this.radioButtonCuCard.Name = "radioButtonCuCard";
            this.radioButtonCuCard.Size = new System.Drawing.Size(47, 17);
            this.radioButtonCuCard.TabIndex = 16;
            this.radioButtonCuCard.TabStop = true;
            this.radioButtonCuCard.Text = "Card";
            this.radioButtonCuCard.UseVisualStyleBackColor = true;
            // 
            // radioButtonFaraCard
            // 
            this.radioButtonFaraCard.AutoSize = true;
            this.radioButtonFaraCard.Location = new System.Drawing.Point(161, 77);
            this.radioButtonFaraCard.Name = "radioButtonFaraCard";
            this.radioButtonFaraCard.Size = new System.Drawing.Size(70, 17);
            this.radioButtonFaraCard.TabIndex = 17;
            this.radioButtonFaraCard.TabStop = true;
            this.radioButtonFaraCard.Text = "Fara card";
            this.radioButtonFaraCard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(695, 446);
            this.Controls.Add(this.radioButtonFaraCard);
            this.Controls.Add(this.radioButtonCuCard);
            this.Controls.Add(this.checkBoxDisponibilitate);
            this.Controls.Add(this.flowLayoutPanelRezultate);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudPret);
            this.Controls.Add(this.txtProducator);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.flowLayoutPanelMedicamente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMedicamente;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtProducator;
        private System.Windows.Forms.NumericUpDown nudPret;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRezultate;
        private System.Windows.Forms.CheckBox checkBoxDisponibilitate;
        private System.Windows.Forms.RadioButton radioButtonCuCard;
        private System.Windows.Forms.RadioButton radioButtonFaraCard;
    }
}

