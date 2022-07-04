namespace Tischreservierung
{
    partial class Tischreservierung
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowReservation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxNumberOfPersons = new System.Windows.Forms.TextBox();
            this.buttonReserveTable = new System.Windows.Forms.Button();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumberOfPersons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSecondName);
            this.groupBox2.Location = new System.Drawing.Point(329, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nachname:";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(6, 51);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(206, 23);
            this.textBoxSecondName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tisch reservieren:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Location = new System.Drawing.Point(7, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vorname:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(6, 51);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(206, 23);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerDate);
            this.groupBox3.Location = new System.Drawing.Point(7, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 86);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datum der Reservierung";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(6, 51);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(225, 23);
            this.dateTimePickerDate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxTable);
            this.groupBox4.Location = new System.Drawing.Point(329, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 86);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tisch auswählen";
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Items.AddRange(new object[] {
            "Tisch 1 (Innenbereich)",
            "Tisch 2 (Innenbereich)",
            "Tisch 3 (Innenbereich)",
            "Tisch 4 (Innenbereich)",
            "Tisch 5 (Innenbereich)",
            "Tisch 6 (Innenbereich)",
            "Tisch 7 (Außenbereich)",
            "Tisch 8 (Außenbereich)",
            "Tisch 9 (Außenbereich)",
            "Tisch 10 (Außenbereich)",
            "Tisch 11 (Außenbereich)"});
            this.comboBoxTable.Location = new System.Drawing.Point(6, 51);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(206, 23);
            this.comboBoxTable.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 396);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonShowReservation);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 368);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Reservierung anzeigen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFirstName,
            this.ColumnSecondName,
            this.ColumnDate,
            this.ColumnTable,
            this.ColumnNumberOfPersons,
            this.ColumnPhoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(25, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(644, 265);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonShowReservation
            // 
            this.buttonShowReservation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShowReservation.Location = new System.Drawing.Point(557, 302);
            this.buttonShowReservation.Name = "buttonShowReservation";
            this.buttonShowReservation.Size = new System.Drawing.Size(131, 57);
            this.buttonShowReservation.TabIndex = 6;
            this.buttonShowReservation.Text = "Reservierungen anzeigen";
            this.buttonShowReservation.UseVisualStyleBackColor = true;
            this.buttonShowReservation.Click += new System.EventHandler(this.ShowReservation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tischreservierungen anzeigen lassen:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.buttonReserveTable);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 368);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = " Tisch reservieren";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxPhoneNumber);
            this.groupBox6.Location = new System.Drawing.Point(329, 226);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(310, 86);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Telefonnummer:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(6, 57);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(206, 23);
            this.textBoxPhoneNumber.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxNumberOfPersons);
            this.groupBox5.Location = new System.Drawing.Point(7, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 86);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Personenanzahl:";
            // 
            // textBoxNumberOfPersons
            // 
            this.textBoxNumberOfPersons.Location = new System.Drawing.Point(6, 57);
            this.textBoxNumberOfPersons.Name = "textBoxNumberOfPersons";
            this.textBoxNumberOfPersons.Size = new System.Drawing.Size(206, 23);
            this.textBoxNumberOfPersons.TabIndex = 0;
            // 
            // buttonReserveTable
            // 
            this.buttonReserveTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReserveTable.Location = new System.Drawing.Point(508, 331);
            this.buttonReserveTable.Name = "buttonReserveTable";
            this.buttonReserveTable.Size = new System.Drawing.Size(131, 28);
            this.buttonReserveTable.TabIndex = 8;
            this.buttonReserveTable.Text = "Tisch reservieren";
            this.buttonReserveTable.UseVisualStyleBackColor = true;
            this.buttonReserveTable.Click += new System.EventHandler(this.ReserveTable_Click);
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.HeaderText = "Vorname";
            this.ColumnFirstName.Name = "ColumnFirstName";
            // 
            // ColumnSecondName
            // 
            this.ColumnSecondName.HeaderText = "Nachname";
            this.ColumnSecondName.Name = "ColumnSecondName";
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Datum";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnTable
            // 
            this.ColumnTable.HeaderText = "Tisch";
            this.ColumnTable.Name = "ColumnTable";
            // 
            // ColumnNumberOfPersons
            // 
            this.ColumnNumberOfPersons.HeaderText = "Anzahl Personen";
            this.ColumnNumberOfPersons.Name = "ColumnNumberOfPersons";
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.HeaderText = "Telefonnummer";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            // 
            // Tischreservierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tischreservierung";
            this.Text = "Tischverwaltung";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dateTimePickerDate;
        private GroupBox groupBox2;
        private TextBox textBoxSecondName;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxFirstName;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox comboBoxTable;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private GroupBox groupBox5;
        private TextBox textBoxNumberOfPersons;
        private Button buttonReserveTable;
        private GroupBox groupBox6;
        private TextBox textBoxPhoneNumber;
        private Button buttonShowReservation;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnFirstName;
        private DataGridViewTextBoxColumn ColumnSecondName;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnTable;
        private DataGridViewTextBoxColumn ColumnNumberOfPersons;
        private DataGridViewTextBoxColumn ColumnPhoneNumber;
    }
}