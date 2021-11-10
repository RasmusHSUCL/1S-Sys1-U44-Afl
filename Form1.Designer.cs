
namespace U44Afl
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundetlfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tekstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u44DBAflDataSet = new U44Afl.U44DBAflDataSet();
            this.ordreTableAdapter = new U44Afl.U44DBAflDataSetTableAdapters.OrdreTableAdapter();
            this.maskedOIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedKtlfTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTekstBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedPrisTextBox = new System.Windows.Forms.MaskedTextBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.readbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.OIDLabel = new System.Windows.Forms.Label();
            this.kundetlfLabel = new System.Windows.Forms.Label();
            this.tekstLabel = new System.Windows.Forms.Label();
            this.prisLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OpretLabel = new System.Windows.Forms.Label();
            this.IndlæsLabel = new System.Windows.Forms.Label();
            this.KundeTlfHelpLabel = new System.Windows.Forms.Label();
            this.TekstHelpLabel = new System.Windows.Forms.Label();
            this.PrisHelpLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u44DBAflDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordreIdDataGridViewTextBoxColumn,
            this.kundetlfDataGridViewTextBoxColumn,
            this.tekstDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(457, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordreIdDataGridViewTextBoxColumn
            // 
            this.ordreIdDataGridViewTextBoxColumn.DataPropertyName = "OrdreId";
            this.ordreIdDataGridViewTextBoxColumn.HeaderText = "OrdreId";
            this.ordreIdDataGridViewTextBoxColumn.Name = "ordreIdDataGridViewTextBoxColumn";
            // 
            // kundetlfDataGridViewTextBoxColumn
            // 
            this.kundetlfDataGridViewTextBoxColumn.DataPropertyName = "kundetlf";
            this.kundetlfDataGridViewTextBoxColumn.HeaderText = "kundetlf";
            this.kundetlfDataGridViewTextBoxColumn.Name = "kundetlfDataGridViewTextBoxColumn";
            // 
            // tekstDataGridViewTextBoxColumn
            // 
            this.tekstDataGridViewTextBoxColumn.DataPropertyName = "tekst";
            this.tekstDataGridViewTextBoxColumn.HeaderText = "tekst";
            this.tekstDataGridViewTextBoxColumn.Name = "tekstDataGridViewTextBoxColumn";
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            // 
            // ordreBindingSource
            // 
            this.ordreBindingSource.DataMember = "Ordre";
            this.ordreBindingSource.DataSource = this.u44DBAflDataSet;
            // 
            // u44DBAflDataSet
            // 
            this.u44DBAflDataSet.DataSetName = "U44DBAflDataSet";
            this.u44DBAflDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordreTableAdapter
            // 
            this.ordreTableAdapter.ClearBeforeFill = true;
            // 
            // maskedOIDTextBox
            // 
            this.maskedOIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedOIDTextBox.Location = new System.Drawing.Point(94, 120);
            this.maskedOIDTextBox.Name = "maskedOIDTextBox";
            this.maskedOIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.maskedOIDTextBox.TabIndex = 1;
            // 
            // maskedKtlfTextBox
            // 
            this.maskedKtlfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedKtlfTextBox.Location = new System.Drawing.Point(94, 251);
            this.maskedKtlfTextBox.Name = "maskedKtlfTextBox";
            this.maskedKtlfTextBox.Size = new System.Drawing.Size(171, 26);
            this.maskedKtlfTextBox.TabIndex = 2;
            // 
            // maskedTekstBox
            // 
            this.maskedTekstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTekstBox.Location = new System.Drawing.Point(94, 301);
            this.maskedTekstBox.Name = "maskedTekstBox";
            this.maskedTekstBox.Size = new System.Drawing.Size(270, 26);
            this.maskedTekstBox.TabIndex = 3;
            // 
            // maskedPrisTextBox
            // 
            this.maskedPrisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedPrisTextBox.Location = new System.Drawing.Point(94, 348);
            this.maskedPrisTextBox.Name = "maskedPrisTextBox";
            this.maskedPrisTextBox.Size = new System.Drawing.Size(171, 26);
            this.maskedPrisTextBox.TabIndex = 4;
            // 
            // createbutton
            // 
            this.createbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbutton.Location = new System.Drawing.Point(27, 401);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(130, 51);
            this.createbutton.TabIndex = 5;
            this.createbutton.Text = "Opret Ordre";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // readbutton
            // 
            this.readbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readbutton.Location = new System.Drawing.Point(200, 120);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(100, 26);
            this.readbutton.TabIndex = 6;
            this.readbutton.Text = "Auto-Indlæs";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.autofillbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(299, 401);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(130, 51);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "Slet Ordre";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Location = new System.Drawing.Point(163, 401);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(130, 51);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "Opdater Ordre";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // OIDLabel
            // 
            this.OIDLabel.AutoSize = true;
            this.OIDLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OIDLabel.Location = new System.Drawing.Point(8, 120);
            this.OIDLabel.Name = "OIDLabel";
            this.OIDLabel.Size = new System.Drawing.Size(67, 20);
            this.OIDLabel.TabIndex = 9;
            this.OIDLabel.Text = "Ordre Id";
            // 
            // kundetlfLabel
            // 
            this.kundetlfLabel.AutoSize = true;
            this.kundetlfLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kundetlfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kundetlfLabel.Location = new System.Drawing.Point(8, 251);
            this.kundetlfLabel.Name = "kundetlfLabel";
            this.kundetlfLabel.Size = new System.Drawing.Size(80, 20);
            this.kundetlfLabel.TabIndex = 10;
            this.kundetlfLabel.Text = "Kunde Tlf.";
            // 
            // tekstLabel
            // 
            this.tekstLabel.AutoSize = true;
            this.tekstLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tekstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekstLabel.Location = new System.Drawing.Point(8, 301);
            this.tekstLabel.Name = "tekstLabel";
            this.tekstLabel.Size = new System.Drawing.Size(48, 20);
            this.tekstLabel.TabIndex = 11;
            this.tekstLabel.Text = "Tekst";
            // 
            // prisLabel
            // 
            this.prisLabel.AutoSize = true;
            this.prisLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisLabel.Location = new System.Drawing.Point(8, 348);
            this.prisLabel.Name = "prisLabel";
            this.prisLabel.Size = new System.Drawing.Size(35, 20);
            this.prisLabel.TabIndex = 12;
            this.prisLabel.Text = "Pris";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 51);
            this.panel1.TabIndex = 13;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(356, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(216, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Ordre Håndtering";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-5, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 68);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.PrisHelpLabel);
            this.panel3.Controls.Add(this.TekstHelpLabel);
            this.panel3.Controls.Add(this.KundeTlfHelpLabel);
            this.panel3.Location = new System.Drawing.Point(-5, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 240);
            this.panel3.TabIndex = 15;
            // 
            // OpretLabel
            // 
            this.OpretLabel.AutoSize = true;
            this.OpretLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpretLabel.Location = new System.Drawing.Point(8, 204);
            this.OpretLabel.Name = "OpretLabel";
            this.OpretLabel.Size = new System.Drawing.Size(140, 24);
            this.OpretLabel.TabIndex = 16;
            this.OpretLabel.Text = "Ordre Formular";
            // 
            // IndlæsLabel
            // 
            this.IndlæsLabel.AutoSize = true;
            this.IndlæsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndlæsLabel.Location = new System.Drawing.Point(8, 71);
            this.IndlæsLabel.Name = "IndlæsLabel";
            this.IndlæsLabel.Size = new System.Drawing.Size(106, 24);
            this.IndlæsLabel.TabIndex = 17;
            this.IndlæsLabel.Text = "Indlæs data";
            // 
            // KundeTlfHelpLabel
            // 
            this.KundeTlfHelpLabel.AutoSize = true;
            this.KundeTlfHelpLabel.Location = new System.Drawing.Point(276, 20);
            this.KundeTlfHelpLabel.Name = "KundeTlfHelpLabel";
            this.KundeTlfHelpLabel.Size = new System.Drawing.Size(127, 13);
            this.KundeTlfHelpLabel.TabIndex = 0;
            this.KundeTlfHelpLabel.Text = "(Maks 11 cifre og kun tal)";
            // 
            // TekstHelpLabel
            // 
            this.TekstHelpLabel.AutoSize = true;
            this.TekstHelpLabel.Location = new System.Drawing.Point(375, 70);
            this.TekstHelpLabel.Name = "TekstHelpLabel";
            this.TekstHelpLabel.Size = new System.Drawing.Size(78, 13);
            this.TekstHelpLabel.TabIndex = 1;
            this.TekstHelpLabel.Text = "(Maks 50 tegn)";
            // 
            // PrisHelpLabel
            // 
            this.PrisHelpLabel.AutoSize = true;
            this.PrisHelpLabel.Location = new System.Drawing.Point(276, 117);
            this.PrisHelpLabel.Name = "PrisHelpLabel";
            this.PrisHelpLabel.Size = new System.Drawing.Size(177, 13);
            this.PrisHelpLabel.TabIndex = 2;
            this.PrisHelpLabel.Text = "(Maks 50 cifre og maks 2 decimaler)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "(Udfyld kun Ordre Id)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "(Udfyld alle felter)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "(Udfyld Ordre formular)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 545);
            this.Controls.Add(this.IndlæsLabel);
            this.Controls.Add(this.OpretLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prisLabel);
            this.Controls.Add(this.tekstLabel);
            this.Controls.Add(this.kundetlfLabel);
            this.Controls.Add(this.OIDLabel);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.maskedPrisTextBox);
            this.Controls.Add(this.maskedTekstBox);
            this.Controls.Add(this.maskedKtlfTextBox);
            this.Controls.Add(this.maskedOIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u44DBAflDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private U44DBAflDataSet u44DBAflDataSet;
        private System.Windows.Forms.BindingSource ordreBindingSource;
        private U44DBAflDataSetTableAdapters.OrdreTableAdapter ordreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundetlfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedOIDTextBox;
        private System.Windows.Forms.MaskedTextBox maskedKtlfTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTekstBox;
        private System.Windows.Forms.MaskedTextBox maskedPrisTextBox;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label OIDLabel;
        private System.Windows.Forms.Label kundetlfLabel;
        private System.Windows.Forms.Label tekstLabel;
        private System.Windows.Forms.Label prisLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label OpretLabel;
        private System.Windows.Forms.Label IndlæsLabel;
        private System.Windows.Forms.Label PrisHelpLabel;
        private System.Windows.Forms.Label TekstHelpLabel;
        private System.Windows.Forms.Label KundeTlfHelpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

