namespace proiect1_3
{
    partial class SelectedImage
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
            this.rmv_btn = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.photoName = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_feature = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rmv_btn
            // 
            this.rmv_btn.Location = new System.Drawing.Point(221, 362);
            this.rmv_btn.Name = "rmv_btn";
            this.rmv_btn.Size = new System.Drawing.Size(99, 49);
            this.rmv_btn.TabIndex = 0;
            this.rmv_btn.Text = "Delete";
            this.rmv_btn.UseVisualStyleBackColor = true;
            this.rmv_btn.Click += new System.EventHandler(this.rmv_btn_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(73, 362);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(104, 50);
            this.open.TabIndex = 1;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(650, 373);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(130, 49);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 202);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // photoName
            // 
            this.photoName.AutoSize = true;
            this.photoName.Location = new System.Drawing.Point(69, 293);
            this.photoName.Name = "photoName";
            this.photoName.Size = new System.Drawing.Size(51, 20);
            this.photoName.TabIndex = 4;
            this.photoName.Text = "label1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(535, 63);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Date";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(535, 103);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(51, 20);
            this.date.TabIndex = 6;
            this.date.Text = "label2";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(535, 143);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(70, 20);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Location";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(535, 181);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(51, 20);
            this.location.TabIndex = 8;
            this.location.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Persons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Features";
            // 
            // add_feature
            // 
            this.add_feature.Location = new System.Drawing.Point(356, 362);
            this.add_feature.Name = "add_feature";
            this.add_feature.Size = new System.Drawing.Size(110, 50);
            this.add_feature.TabIndex = 11;
            this.add_feature.Text = "Add Feature";
            this.add_feature.UseVisualStyleBackColor = true;
            this.add_feature.Click += new System.EventHandler(this.add_feature_Click);
            // 
            // SelectedImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_feature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.photoName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.open);
            this.Controls.Add(this.rmv_btn);
            this.Name = "SelectedImage";
            this.Text = "SelectedImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rmv_btn;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label photoName;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_feature;
    }
}