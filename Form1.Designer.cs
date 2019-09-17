namespace PPE_GSB1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantiteCommande = new System.Windows.Forms.TextBox();
            this.ajoutMedoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.selecOfficine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ajoutQuantite = new System.Windows.Forms.TextBox();
            this.supprimeStock = new System.Windows.Forms.Button();
            this.ajoutStock = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Commande = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DS_test = new System.Data.DataSet();
            this.DGV_test = new System.Windows.Forms.DataGridView();
//            this.button2 = new System.Windows.Forms.Button();
  //          this.button3 = new System.Windows.Forms.Button();
   //         this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
      //      this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
       //     this.comboBox2 = new System.Windows.Forms.ComboBox();
      //      this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Commande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_test)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Commande);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stockage";
            // 
            // panel2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.selecMedoc);
            this.panel1.Controls.Add(this.selecOfficine);
            this.panel1.Controls.Add(this.quantiteCommande);
            this.panel1.Controls.Add(this.supprimeStock);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(530, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 563);
            this.panel1.TabIndex = 12;
            this.Commande.BackColor = System.Drawing.Color.Gray;
            this.Commande.Controls.Add(this.button4);
            this.Commande.Controls.Add(this.label7);
            this.Commande.Controls.Add(this.dataGridView2);
            this.Commande.Location = new System.Drawing.Point(4, 22);
            this.Commande.Name = "Commande";
            this.Commande.Padding = new System.Windows.Forms.Padding(3);
            this.Commande.Size = new System.Drawing.Size(1023, 575);
            this.Commande.TabIndex = 2;
            this.Commande.Text = "Commande";
            // 
            // quantiteCommande
            // 
            this.quantiteCommande.Location = new System.Drawing.Point(373, 262);
            this.quantiteCommande.Name = "quantiteCommande";
            this.quantiteCommande.Size = new System.Drawing.Size(100, 20);
            this.quantiteCommande.TabIndex = 11;
            // 
            // ajoutMedoc
            // 
            this.ajoutMedoc.FormattingEnabled = true;
            this.ajoutMedoc.Location = new System.Drawing.Point(16, 134);
            this.ajoutMedoc.Name = "ajoutMedoc";
            this.ajoutMedoc.Size = new System.Drawing.Size(214, 21);
            this.ajoutMedoc.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sélectionner le Médicaments:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Saisir l\'officine de destination: ";
            // 
            // selecOfficine
            // 
            this.selecOfficine.FormattingEnabled = true;
            this.selecOfficine.Location = new System.Drawing.Point(34, 144);
            this.selecOfficine.Name = "selecOfficine";
            this.selecOfficine.Size = new System.Drawing.Size(217, 21);
            this.selecOfficine.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Saisir la Quantitée à Ajouter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Saisir le Nom et la Quantitée du Médicament:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ajouter des Médicaments dans les Stocks: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Envoyer des Médicaments à une Officine: ";
            // 
            // ajoutQuantite
            // 
            this.ajoutQuantite.Location = new System.Drawing.Point(16, 261);
            this.ajoutQuantite.Name = "ajoutQuantite";
            this.ajoutQuantite.Size = new System.Drawing.Size(100, 20);
            this.ajoutQuantite.TabIndex = 2;
            // 
            // supprimeStock
            // 
            this.supprimeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimeStock.Location = new System.Drawing.Point(3, 329);
            this.supprimeStock.Name = "supprimeStock";
            this.supprimeStock.Size = new System.Drawing.Size(477, 80);
            this.supprimeStock.TabIndex = 1;
            this.supprimeStock.Text = "ENVOYER";
            this.supprimeStock.UseVisualStyleBackColor = true;
            // 
            // ajoutStock
            // 
            this.ajoutStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutStock.Location = new System.Drawing.Point(16, 329);
            this.ajoutStock.Name = "ajoutStock";
            this.ajoutStock.Size = new System.Drawing.Size(472, 80);
            this.ajoutStock.TabIndex = 0;
            this.ajoutStock.Text = "AJOUTER";
            this.ajoutStock.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Commande
            // 
            this.Commande.Controls.Add(this.label7);
            this.Commande.Controls.Add(this.dataGridView2);
            this.Commande.Location = new System.Drawing.Point(4, 22);
            this.Commande.Name = "Commande";
            this.Commande.Padding = new System.Windows.Forms.Padding(3);
            this.Commande.Size = new System.Drawing.Size(1023, 575);
            this.Commande.TabIndex = 2;
            this.Commande.Text = "Commande";
            this.Commande.UseVisualStyleBackColor = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(972, 453);
            this.dataGridView2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "Historique des commandes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(966, 490);
            this.dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1011, 563);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // DS_test
            // 
            this.DS_test.DataSetName = "DS_test";
            // 
            // DGV_test
            // 
            this.DGV_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_test.Location = new System.Drawing.Point(80, 57);
            this.DGV_test.Name = "DGV_test";
            this.DGV_test.Size = new System.Drawing.Size(240, 150);
            this.DGV_test.TabIndex = 1;
            // 
            // selecMedoc
            // 
            this.selecMedoc.FormattingEnabled = true;
            this.selecMedoc.Location = new System.Drawing.Point(34, 261);
            this.selecMedoc.Name = "selecMedoc";
            this.selecMedoc.Size = new System.Drawing.Size(323, 21);
            this.selecMedoc.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 27);
            this.button4.TabIndex = 2;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Commande.ResumeLayout(false);
            this.Commande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Commande;
        private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet DS_test;
        private System.Windows.Forms.DataGridView DGV_test;
        private System.Windows.Forms.ComboBox selecOfficine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ajoutQuantite;
        private System.Windows.Forms.Button supprimeStock;
        private System.Windows.Forms.Button ajoutStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox quantiteCommande;
        private System.Windows.Forms.ComboBox ajoutMedoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selecMedoc;
        private System.Windows.Forms.Button button4;
    }
}

