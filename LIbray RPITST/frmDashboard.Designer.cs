namespace LIbray_RPITST
{
    partial class frmDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnabout = new FontAwesome.Sharp.IconButton();
            this.btnborrow = new FontAwesome.Sharp.IconButton();
            this.btnaddbook = new FontAwesome.Sharp.IconButton();
            this.btnadministrator = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnWindowMinimize = new FontAwesome.Sharp.IconButton();
            this.btnWindowMaximize = new FontAwesome.Sharp.IconButton();
            this.btnWindowRestore = new FontAwesome.Sharp.IconButton();
            this.btnclose = new FontAwesome.Sharp.IconButton();
            this.btnissue = new FontAwesome.Sharp.IconButton();
            this.btnreturn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnWindowMinimize);
            this.panel1.Controls.Add(this.btnWindowMaximize);
            this.panel1.Controls.Add(this.btnWindowRestore);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1682, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.btnreturn);
            this.panel2.Controls.Add(this.btnissue);
            this.panel2.Controls.Add(this.btnabout);
            this.panel2.Controls.Add(this.btnborrow);
            this.panel2.Controls.Add(this.btnaddbook);
            this.panel2.Controls.Add(this.btnadministrator);
            this.panel2.Controls.Add(this.btndashboard);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 823);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "LIBRARY RPITST";
            // 
            // panelmenu
            // 
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmenu.Location = new System.Drawing.Point(346, 40);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(1336, 823);
            this.panelmenu.TabIndex = 2;
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.MistyRose;
            this.btnabout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabout.ForeColor = System.Drawing.Color.Black;
            this.btnabout.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.btnabout.IconColor = System.Drawing.Color.Black;
            this.btnabout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnabout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnabout.Location = new System.Drawing.Point(3, 609);
            this.btnabout.Name = "btnabout";
            this.btnabout.Size = new System.Drawing.Size(340, 50);
            this.btnabout.TabIndex = 14;
            this.btnabout.Text = "About";
            this.btnabout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnabout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnabout.UseVisualStyleBackColor = false;
            // 
            // btnborrow
            // 
            this.btnborrow.BackColor = System.Drawing.Color.MistyRose;
            this.btnborrow.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrow.ForeColor = System.Drawing.Color.Black;
            this.btnborrow.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.btnborrow.IconColor = System.Drawing.Color.Black;
            this.btnborrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrow.Location = new System.Drawing.Point(3, 412);
            this.btnborrow.Name = "btnborrow";
            this.btnborrow.Size = new System.Drawing.Size(340, 50);
            this.btnborrow.TabIndex = 13;
            this.btnborrow.Text = "Borrow";
            this.btnborrow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrow.UseVisualStyleBackColor = false;
            // 
            // btnaddbook
            // 
            this.btnaddbook.BackColor = System.Drawing.Color.MistyRose;
            this.btnaddbook.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbook.ForeColor = System.Drawing.Color.Black;
            this.btnaddbook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnaddbook.IconColor = System.Drawing.Color.Black;
            this.btnaddbook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnaddbook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddbook.Location = new System.Drawing.Point(3, 349);
            this.btnaddbook.Name = "btnaddbook";
            this.btnaddbook.Size = new System.Drawing.Size(340, 50);
            this.btnaddbook.TabIndex = 12;
            this.btnaddbook.Text = "Add Book";
            this.btnaddbook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaddbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddbook.UseVisualStyleBackColor = false;
            // 
            // btnadministrator
            // 
            this.btnadministrator.BackColor = System.Drawing.Color.MistyRose;
            this.btnadministrator.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadministrator.ForeColor = System.Drawing.Color.Black;
            this.btnadministrator.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnadministrator.IconColor = System.Drawing.Color.Black;
            this.btnadministrator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnadministrator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadministrator.Location = new System.Drawing.Point(3, 287);
            this.btnadministrator.Name = "btnadministrator";
            this.btnadministrator.Size = new System.Drawing.Size(340, 50);
            this.btnadministrator.TabIndex = 11;
            this.btnadministrator.Text = "Administrator";
            this.btnadministrator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadministrator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadministrator.UseVisualStyleBackColor = false;
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.MistyRose;
            this.btndashboard.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.Black;
            this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.btndashboard.IconColor = System.Drawing.Color.Black;
            this.btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(3, 223);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(340, 50);
            this.btndashboard.TabIndex = 10;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = global::LIbray_RPITST.Properties.Resources.logo;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar._500Px;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 100;
            this.iconPictureBox1.Location = new System.Drawing.Point(122, 23);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnWindowMinimize
            // 
            this.btnWindowMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnWindowMinimize.FlatAppearance.BorderSize = 0;
            this.btnWindowMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMinimize.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnWindowMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnWindowMinimize.IconColor = System.Drawing.Color.White;
            this.btnWindowMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowMinimize.IconSize = 33;
            this.btnWindowMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindowMinimize.Location = new System.Drawing.Point(1508, 0);
            this.btnWindowMinimize.Name = "btnWindowMinimize";
            this.btnWindowMinimize.Size = new System.Drawing.Size(46, 34);
            this.btnWindowMinimize.TabIndex = 18;
            this.btnWindowMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWindowMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWindowMinimize.UseVisualStyleBackColor = false;
            this.btnWindowMinimize.Click += new System.EventHandler(this.btnWindowMinimize_Click);
            // 
            // btnWindowMaximize
            // 
            this.btnWindowMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnWindowMaximize.FlatAppearance.BorderSize = 0;
            this.btnWindowMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMaximize.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnWindowMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnWindowMaximize.IconColor = System.Drawing.Color.White;
            this.btnWindowMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowMaximize.IconSize = 33;
            this.btnWindowMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindowMaximize.Location = new System.Drawing.Point(1563, 6);
            this.btnWindowMaximize.Name = "btnWindowMaximize";
            this.btnWindowMaximize.Size = new System.Drawing.Size(46, 34);
            this.btnWindowMaximize.TabIndex = 17;
            this.btnWindowMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWindowMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWindowMaximize.UseVisualStyleBackColor = false;
            this.btnWindowMaximize.Click += new System.EventHandler(this.btnWindowMaximize_Click);
            // 
            // btnWindowRestore
            // 
            this.btnWindowRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnWindowRestore.FlatAppearance.BorderSize = 0;
            this.btnWindowRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowRestore.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindowRestore.ForeColor = System.Drawing.Color.Black;
            this.btnWindowRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnWindowRestore.IconColor = System.Drawing.Color.White;
            this.btnWindowRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowRestore.IconSize = 33;
            this.btnWindowRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindowRestore.Location = new System.Drawing.Point(1572, 6);
            this.btnWindowRestore.Name = "btnWindowRestore";
            this.btnWindowRestore.Size = new System.Drawing.Size(46, 34);
            this.btnWindowRestore.TabIndex = 16;
            this.btnWindowRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWindowRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWindowRestore.UseVisualStyleBackColor = false;
            this.btnWindowRestore.Click += new System.EventHandler(this.btnWindowRestore_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnclose.IconColor = System.Drawing.Color.White;
            this.btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclose.IconSize = 33;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(1624, 6);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(46, 34);
            this.btnclose.TabIndex = 15;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnissue
            // 
            this.btnissue.BackColor = System.Drawing.Color.MistyRose;
            this.btnissue.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnissue.ForeColor = System.Drawing.Color.Black;
            this.btnissue.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnissue.IconColor = System.Drawing.Color.Black;
            this.btnissue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnissue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnissue.Location = new System.Drawing.Point(3, 478);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(340, 50);
            this.btnissue.TabIndex = 15;
            this.btnissue.Text = "Issue";
            this.btnissue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnissue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnissue.UseVisualStyleBackColor = false;
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.MistyRose;
            this.btnreturn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.Color.Black;
            this.btnreturn.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btnreturn.IconColor = System.Drawing.Color.Black;
            this.btnreturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnreturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreturn.Location = new System.Drawing.Point(3, 543);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(340, 50);
            this.btnreturn.TabIndex = 16;
            this.btnreturn.Text = "Return";
            this.btnreturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreturn.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 863);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnabout;
        private FontAwesome.Sharp.IconButton btnborrow;
        private FontAwesome.Sharp.IconButton btnaddbook;
        private FontAwesome.Sharp.IconButton btnadministrator;
        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton btndashboard;
        private FontAwesome.Sharp.IconButton btnclose;
        private FontAwesome.Sharp.IconButton btnWindowMinimize;
        private FontAwesome.Sharp.IconButton btnWindowMaximize;
        private FontAwesome.Sharp.IconButton btnWindowRestore;
        private FontAwesome.Sharp.IconButton btnreturn;
        private FontAwesome.Sharp.IconButton btnissue;
    }
}