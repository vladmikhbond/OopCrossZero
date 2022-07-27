namespace WinFormsLibrary.Forms
{
   partial class MainForm
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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.clearButton = new System.Windows.Forms.Button();
         this.idBox = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.yearBox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.authorBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.titleBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.findButton = new System.Windows.Forms.Button();
         this.booksGridView = new System.Windows.Forms.DataGridView();
         this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.readersToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 28);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
         this.openToolStripMenuItem.Text = "Open";
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
         this.exitToolStripMenuItem.Text = "Exit";
         // 
         // booksToolStripMenuItem
         // 
         this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem});
         this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
         this.booksToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
         this.booksToolStripMenuItem.Text = "Books";
         // 
         // newToolStripMenuItem
         // 
         this.newToolStripMenuItem.Name = "newToolStripMenuItem";
         this.newToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
         this.newToolStripMenuItem.Text = "New...";
         this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
         // 
         // readersToolStripMenuItem
         // 
         this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
         this.readersToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
         this.readersToolStripMenuItem.Text = "Readers";
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
         this.helpToolStripMenuItem.Text = "Help";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.clearButton);
         this.groupBox1.Controls.Add(this.idBox);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.yearBox);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.authorBox);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.titleBox);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.findButton);
         this.groupBox1.Location = new System.Drawing.Point(12, 37);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(776, 140);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Search";
         // 
         // clearButton
         // 
         this.clearButton.Location = new System.Drawing.Point(664, 95);
         this.clearButton.Name = "clearButton";
         this.clearButton.Size = new System.Drawing.Size(92, 34);
         this.clearButton.TabIndex = 9;
         this.clearButton.Text = "Clear";
         this.clearButton.UseVisualStyleBackColor = true;
         this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
         // 
         // idBox
         // 
         this.idBox.Location = new System.Drawing.Point(334, 98);
         this.idBox.Name = "idBox";
         this.idBox.Size = new System.Drawing.Size(211, 27);
         this.idBox.TabIndex = 8;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(306, 101);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(22, 20);
         this.label4.TabIndex = 7;
         this.label4.Text = "Id";
         // 
         // yearBox
         // 
         this.yearBox.Location = new System.Drawing.Point(79, 98);
         this.yearBox.Name = "yearBox";
         this.yearBox.Size = new System.Drawing.Size(206, 27);
         this.yearBox.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(22, 101);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(37, 20);
         this.label3.TabIndex = 5;
         this.label3.Text = "Year";
         // 
         // authorBox
         // 
         this.authorBox.Location = new System.Drawing.Point(79, 62);
         this.authorBox.Name = "authorBox";
         this.authorBox.Size = new System.Drawing.Size(677, 27);
         this.authorBox.TabIndex = 4;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(22, 65);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 20);
         this.label2.TabIndex = 3;
         this.label2.Text = "Author";
         // 
         // titleBox
         // 
         this.titleBox.Location = new System.Drawing.Point(79, 29);
         this.titleBox.Name = "titleBox";
         this.titleBox.Size = new System.Drawing.Size(677, 27);
         this.titleBox.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(22, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 20);
         this.label1.TabIndex = 1;
         this.label1.Text = "Title";
         // 
         // findButton
         // 
         this.findButton.Location = new System.Drawing.Point(566, 95);
         this.findButton.Name = "findButton";
         this.findButton.Size = new System.Drawing.Size(92, 34);
         this.findButton.TabIndex = 0;
         this.findButton.Text = "Find";
         this.findButton.UseVisualStyleBackColor = true;
         this.findButton.Click += new System.EventHandler(this.findButton_Click);
         // 
         // booksGridView
         // 
         this.booksGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.booksGridView.AutoGenerateColumns = false;
         this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
         this.booksGridView.DataSource = this.bookBindingSource;
         this.booksGridView.Location = new System.Drawing.Point(12, 183);
         this.booksGridView.Name = "booksGridView";
         this.booksGridView.RowHeadersWidth = 51;
         this.booksGridView.RowTemplate.Height = 29;
         this.booksGridView.Size = new System.Drawing.Size(776, 255);
         this.booksGridView.TabIndex = 2;
         // 
         // idDataGridViewTextBoxColumn
         // 
         this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
         this.idDataGridViewTextBoxColumn.HeaderText = "Id";
         this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
         this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
         this.idDataGridViewTextBoxColumn.Width = 60;
         // 
         // titleDataGridViewTextBoxColumn
         // 
         this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
         this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
         this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
         this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
         // 
         // authorDataGridViewTextBoxColumn
         // 
         this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
         this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
         this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
         this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
         this.authorDataGridViewTextBoxColumn.Width = 250;
         // 
         // yearDataGridViewTextBoxColumn
         // 
         this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
         this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
         this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
         this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
         this.yearDataGridViewTextBoxColumn.Width = 60;
         // 
         // bookBindingSource
         // 
         this.bookBindingSource.DataSource = typeof(WinFormsLibrary.Models.Book);
         // 
         // editToolStripMenuItem
         // 
         this.editToolStripMenuItem.Name = "editToolStripMenuItem";
         this.editToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
         this.editToolStripMenuItem.Text = "Edit...";
         this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.booksGridView);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainForm";
         this.Text = "MainForm";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem readersToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox titleBox;
        private Label label1;
        private Button findButton;
        private TextBox idBox;
        private Label label4;
        private TextBox yearBox;
        private Label label3;
        private TextBox authorBox;
        private Label label2;
        private Button clearButton;
      private DataGridView booksGridView;
      private BindingSource bookBindingSource;
      private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
      private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
      private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
      private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}