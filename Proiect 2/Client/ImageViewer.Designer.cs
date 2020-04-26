namespace proiect1_3
{
    partial class ImageViewer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.refresh = new System.Windows.Forms.Button();
            this.browse_btn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(54, 401);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(143, 37);
            this.refresh.TabIndex = 0;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(619, 401);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(130, 37);
            this.browse_btn.TabIndex = 1;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(695, 345);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(233, 401);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(149, 37);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.refresh);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button search_btn;
    }
}