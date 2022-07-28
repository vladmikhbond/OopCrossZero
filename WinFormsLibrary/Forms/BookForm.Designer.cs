namespace WinFormsLibrary.Forms
{
   partial class BookForm
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
         this.cancelButton = new System.Windows.Forms.Button();
         this.yearBox = new System.Windows.Forms.TextBox();
         this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.label3 = new System.Windows.Forms.Label();
         this.authorBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.titleBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.saveButton = new System.Windows.Forms.Button();
         this.titleStar = new System.Windows.Forms.Label();
         this.yearStar = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // cancelButton
         // 
         this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cancelButton.Location = new System.Drawing.Point(594, 80);
         this.cancelButton.Name = "cancelButton";
         this.cancelButton.Size = new System.Drawing.Size(92, 34);
         this.cancelButton.TabIndex = 5;
         this.cancelButton.Text = "Cancel";
         this.cancelButton.UseVisualStyleBackColor = true;
         // 
         // yearBox
         // 
         this.yearBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Year", true));
         this.yearBox.Location = new System.Drawing.Point(74, 83);
         this.yearBox.Name = "yearBox";
         this.yearBox.Size = new System.Drawing.Size(175, 27);
         this.yearBox.TabIndex = 3;
         this.yearBox.Validating += new System.ComponentModel.CancelEventHandler(this.yearBox_Validating);
         // 
         // bookBindingSource
         // 
         this.bookBindingSource.DataSource = typeof(WinFormsLibrary.Models.Book);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(17, 86);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(37, 20);
         this.label3.TabIndex = 15;
         this.label3.Text = "Year";
         // 
         // authorBox
         // 
         this.authorBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
         this.authorBox.Location = new System.Drawing.Point(74, 47);
         this.authorBox.Name = "authorBox";
         this.authorBox.Size = new System.Drawing.Size(614, 27);
         this.authorBox.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(17, 50);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(54, 20);
         this.label2.TabIndex = 13;
         this.label2.Text = "Author";
         // 
         // titleBox
         // 
         this.titleBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
         this.titleBox.Location = new System.Drawing.Point(74, 12);
         this.titleBox.Name = "titleBox";
         this.titleBox.Size = new System.Drawing.Size(612, 27);
         this.titleBox.TabIndex = 1;
         this.titleBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleBox_Validating);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(17, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 20);
         this.label1.TabIndex = 11;
         this.label1.Text = "Title";
         // 
         // saveButton
         // 
         this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.saveButton.Location = new System.Drawing.Point(496, 80);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(92, 34);
         this.saveButton.TabIndex = 4;
         this.saveButton.Text = "Save";
         this.saveButton.UseVisualStyleBackColor = true;
         // 
         // titleStar
         // 
         this.titleStar.AutoSize = true;
         this.titleStar.ForeColor = System.Drawing.Color.Red;
         this.titleStar.Location = new System.Drawing.Point(692, 12);
         this.titleStar.Name = "titleStar";
         this.titleStar.Size = new System.Drawing.Size(15, 20);
         this.titleStar.TabIndex = 16;
         this.titleStar.Text = "*";
         this.titleStar.Visible = false;
         // 
         // yearStar
         // 
         this.yearStar.AutoSize = true;
         this.yearStar.ForeColor = System.Drawing.Color.Red;
         this.yearStar.Location = new System.Drawing.Point(264, 87);
         this.yearStar.Name = "yearStar";
         this.yearStar.Size = new System.Drawing.Size(113, 20);
         this.yearStar.TabIndex = 17;
         this.yearStar.Text = "0 < year < 3000";
         this.yearStar.Visible = false;
         // 
         // BookForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(741, 129);
         this.Controls.Add(this.yearStar);
         this.Controls.Add(this.titleStar);
         this.Controls.Add(this.cancelButton);
         this.Controls.Add(this.yearBox);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.authorBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.titleBox);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.saveButton);
         this.Name = "BookForm";
         this.Text = "BookForm";
         ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private Button cancelButton;
        private TextBox yearBox;
        private Label label3;
        private TextBox authorBox;
        private Label label2;
        private TextBox titleBox;
        private Label label1;
        private Button saveButton;
      private BindingSource bookBindingSource;
        private Label titleStar;
        private Label yearStar;
    }
}