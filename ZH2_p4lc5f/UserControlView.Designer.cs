namespace ZH2_p4lc5f
{
    partial class UserControlView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lessonSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instruktorSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.timeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nagyosztalyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagyosztalyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(46, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 439);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(831, 86);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 439);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(831, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonSkDataGridViewTextBoxColumn,
            this.instruktorSkDataGridViewTextBoxColumn,
            this.dayFkDataGridViewTextBoxColumn,
            this.timeFkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nagyosztalyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(206, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(580, 480);
            this.dataGridView1.TabIndex = 4;
            // 
            // lessonSkDataGridViewTextBoxColumn
            // 
            this.lessonSkDataGridViewTextBoxColumn.DataPropertyName = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.HeaderText = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.Name = "lessonSkDataGridViewTextBoxColumn";
            // 
            // instruktorSkDataGridViewTextBoxColumn
            // 
            this.instruktorSkDataGridViewTextBoxColumn.DataPropertyName = "InstruktorSk";
            this.instruktorSkDataGridViewTextBoxColumn.DataSource = this.instructorBindingSource;
            this.instruktorSkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.instruktorSkDataGridViewTextBoxColumn.HeaderText = "InstruktorSk";
            this.instruktorSkDataGridViewTextBoxColumn.Name = "instruktorSkDataGridViewTextBoxColumn";
            this.instruktorSkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.instruktorSkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.instruktorSkDataGridViewTextBoxColumn.ValueMember = "InstructorSk";
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataSource = typeof(ZH2_p4lc5f.Models.Instructor);
            // 
            // dayFkDataGridViewTextBoxColumn
            // 
            this.dayFkDataGridViewTextBoxColumn.DataPropertyName = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.DataSource = this.dayBindingSource;
            this.dayFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.dayFkDataGridViewTextBoxColumn.HeaderText = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.Name = "dayFkDataGridViewTextBoxColumn";
            this.dayFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dayFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dayFkDataGridViewTextBoxColumn.ValueMember = "DayId";
            // 
            // dayBindingSource
            // 
            this.dayBindingSource.DataSource = typeof(ZH2_p4lc5f.Models.Day);
            // 
            // timeFkDataGridViewTextBoxColumn
            // 
            this.timeFkDataGridViewTextBoxColumn.DataPropertyName = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.DataSource = this.timeBindingSource;
            this.timeFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.timeFkDataGridViewTextBoxColumn.HeaderText = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.Name = "timeFkDataGridViewTextBoxColumn";
            this.timeFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.timeFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.timeFkDataGridViewTextBoxColumn.ValueMember = "TimeId";
            // 
            // timeBindingSource
            // 
            this.timeBindingSource.DataSource = typeof(ZH2_p4lc5f.Models.Time);
            // 
            // nagyosztalyBindingSource
            // 
            this.nagyosztalyBindingSource.DataSource = typeof(ZH2_p4lc5f.nagyosztaly);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // UserControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "UserControlView";
            this.Size = new System.Drawing.Size(1026, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nagyosztalyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private BindingSource nagyosztalyBindingSource;
        private DataGridViewTextBoxColumn lessonSkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn instruktorSkDataGridViewTextBoxColumn;
        private BindingSource instructorBindingSource;
        private DataGridViewComboBoxColumn dayFkDataGridViewTextBoxColumn;
        private BindingSource dayBindingSource;
        private DataGridViewComboBoxColumn timeFkDataGridViewTextBoxColumn;
        private BindingSource timeBindingSource;
    }
}
