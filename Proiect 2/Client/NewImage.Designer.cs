namespace proiect1_3
{
    partial class NewImage
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
            this.photoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Date_Label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.select_location = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.people_add = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.person_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Location = new System.Drawing.Point(46, 32);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(51, 20);
            this.photoLabel.TabIndex = 0;
            this.photoLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 158);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(467, 146);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(93, 20);
            this.Date_Label.TabIndex = 2;
            this.Date_Label.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(464, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // select_location
            // 
            this.select_location.AutoSize = true;
            this.select_location.Location = new System.Drawing.Point(460, 57);
            this.select_location.Name = "select_location";
            this.select_location.Size = new System.Drawing.Size(119, 20);
            this.select_location.TabIndex = 4;
            this.select_location.Text = "Select Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 26);
            this.textBox1.TabIndex = 5;
            // 
            // people_add
            // 
            this.people_add.Location = new System.Drawing.Point(54, 385);
            this.people_add.Name = "people_add";
            this.people_add.Size = new System.Drawing.Size(133, 46);
            this.people_add.TabIndex = 6;
            this.people_add.Text = "Add People";
            this.people_add.UseVisualStyleBackColor = true;
            this.people_add.Click += new System.EventHandler(this.people_add_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(630, 385);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(136, 46);
            this.submit.TabIndex = 7;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // person_label
            // 
            this.person_label.AutoSize = true;
            this.person_label.Location = new System.Drawing.Point(467, 231);
            this.person_label.Name = "person_label";
            this.person_label.Size = new System.Drawing.Size(67, 20);
            this.person_label.TabIndex = 9;
            this.person_label.Text = "Persons";
            // 
            // NewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.person_label);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.people_add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.select_location);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.photoLabel);
            this.Name = "NewImage";
            this.Text = "NewImagePrompt";
            this.Load += new System.EventHandler(this.NewImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label select_location;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button people_add;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label person_label;
    }
}