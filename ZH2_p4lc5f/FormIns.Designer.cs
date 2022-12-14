namespace ZH2_p4lc5f
{
    partial class FormIns
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.instructorSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salutationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employementFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employementFkNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFkNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(24, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.CausesValidation = false;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(164, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mégsem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(24, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 244);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(164, 80);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(112, 244);
            this.listBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            this.textBox2.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instructorSkDataGridViewTextBoxColumn,
            this.salutationDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusFkDataGridViewTextBoxColumn,
            this.employementFkDataGridViewTextBoxColumn,
            this.employementFkNavigationDataGridViewTextBoxColumn,
            this.lessonsDataGridViewTextBoxColumn,
            this.statusFkNavigationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instructorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(298, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(462, 391);
            this.dataGridView1.TabIndex = 6;
            // 
            // instructorSkDataGridViewTextBoxColumn
            // 
            this.instructorSkDataGridViewTextBoxColumn.DataPropertyName = "InstructorSk";
            this.instructorSkDataGridViewTextBoxColumn.HeaderText = "InstructorSk";
            this.instructorSkDataGridViewTextBoxColumn.Name = "instructorSkDataGridViewTextBoxColumn";
            // 
            // salutationDataGridViewTextBoxColumn
            // 
            this.salutationDataGridViewTextBoxColumn.DataPropertyName = "Salutation";
            this.salutationDataGridViewTextBoxColumn.HeaderText = "Salutation";
            this.salutationDataGridViewTextBoxColumn.Name = "salutationDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // statusFkDataGridViewTextBoxColumn
            // 
            this.statusFkDataGridViewTextBoxColumn.DataPropertyName = "StatusFk";
            this.statusFkDataGridViewTextBoxColumn.HeaderText = "StatusFk";
            this.statusFkDataGridViewTextBoxColumn.Name = "statusFkDataGridViewTextBoxColumn";
            // 
            // employementFkDataGridViewTextBoxColumn
            // 
            this.employementFkDataGridViewTextBoxColumn.DataPropertyName = "EmployementFk";
            this.employementFkDataGridViewTextBoxColumn.HeaderText = "EmployementFk";
            this.employementFkDataGridViewTextBoxColumn.Name = "employementFkDataGridViewTextBoxColumn";
            // 
            // employementFkNavigationDataGridViewTextBoxColumn
            // 
            this.employementFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "EmployementFkNavigation";
            this.employementFkNavigationDataGridViewTextBoxColumn.HeaderText = "EmployementFkNavigation";
            this.employementFkNavigationDataGridViewTextBoxColumn.Name = "employementFkNavigationDataGridViewTextBoxColumn";
            // 
            // lessonsDataGridViewTextBoxColumn
            // 
            this.lessonsDataGridViewTextBoxColumn.DataPropertyName = "Lessons";
            this.lessonsDataGridViewTextBoxColumn.HeaderText = "Lessons";
            this.lessonsDataGridViewTextBoxColumn.Name = "lessonsDataGridViewTextBoxColumn";
            this.lessonsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusFkNavigationDataGridViewTextBoxColumn
            // 
            this.statusFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "StatusFkNavigation";
            this.statusFkNavigationDataGridViewTextBoxColumn.HeaderText = "StatusFkNavigation";
            this.statusFkNavigationDataGridViewTextBoxColumn.Name = "statusFkNavigationDataGridViewTextBoxColumn";
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataSource = typeof(ZH2_p4lc5f.Models.Instructor);
            // 
            // FormIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormIns";
            this.Text = "FormIns";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorProvider errorProvider1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ListBox listBox2;
        private ListBox listBox1;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn instructorSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salutationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employementFkNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusFkNavigationDataGridViewTextBoxColumn;
        private BindingSource instructorBindingSource;
    }
}