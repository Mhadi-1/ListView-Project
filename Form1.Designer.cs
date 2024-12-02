namespace Tree_List_Vieow_ParProgracesApp
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode(" Details");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode(" Small Icon");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode(" Tile");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode(" Large Icon");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode(" List");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode(" Views", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.btnExitApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.bntResetListView = new System.Windows.Forms.Button();
            this.lblloding = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tble_Pageq = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFillList = new System.Windows.Forms.Button();
            this.bntRemovefromList = new System.Windows.Forms.Button();
            this.btnAddtoList = new System.Windows.Forms.Button();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TblePage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chboxMale = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Tble_Pageq.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TblePage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Red;
            this.btnExitApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Location = new System.Drawing.Point(870, 0);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(45, 39);
            this.btnExitApp.TabIndex = 1;
            this.btnExitApp.TabStop = false;
            this.btnExitApp.Text = "X";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btn_ExiteFromApp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(250)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.btnExitApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 39);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treeView1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold);
            this.treeView1.ForeColor = System.Drawing.Color.Snow;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(13, 227);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NdDetails";
            treeNode1.Text = " Details";
            treeNode2.Name = "NdSmallIcone";
            treeNode2.Text = " Small Icon";
            treeNode3.Name = "ndTile";
            treeNode3.Text = " Tile";
            treeNode4.Name = "NdLargeIcon";
            treeNode4.Text = " Large Icon";
            treeNode5.Name = "NdList";
            treeNode5.Text = " List";
            treeNode6.Name = "NdView";
            treeNode6.NodeFont = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold);
            treeNode6.Text = " Views";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(202, 196);
            this.treeView1.TabIndex = 1;
            this.treeView1.TabStop = false;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.pnlProgress);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 677);
            this.panel2.TabIndex = 2;
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.bntResetListView);
            this.pnlProgress.Controls.Add(this.lblloding);
            this.pnlProgress.Controls.Add(this.progressBar1);
            this.pnlProgress.Location = new System.Drawing.Point(0, 464);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(229, 144);
            this.pnlProgress.TabIndex = 5;
            // 
            // bntResetListView
            // 
            this.bntResetListView.BackColor = System.Drawing.Color.White;
            this.bntResetListView.FlatAppearance.BorderSize = 0;
            this.bntResetListView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.bntResetListView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntResetListView.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.bntResetListView.ForeColor = System.Drawing.Color.Black;
            this.bntResetListView.Location = new System.Drawing.Point(18, 91);
            this.bntResetListView.Name = "bntResetListView";
            this.bntResetListView.Size = new System.Drawing.Size(101, 33);
            this.bntResetListView.TabIndex = 8;
            this.bntResetListView.Text = "Reset List";
            this.bntResetListView.UseVisualStyleBackColor = false;
            this.bntResetListView.Visible = false;
            this.bntResetListView.Click += new System.EventHandler(this.bntResetListView_Click);
            // 
            // lblloding
            // 
            this.lblloding.BackColor = System.Drawing.Color.White;
            this.lblloding.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.lblloding.ForeColor = System.Drawing.Color.Black;
            this.lblloding.Location = new System.Drawing.Point(18, 57);
            this.lblloding.Name = "lblloding";
            this.lblloding.Size = new System.Drawing.Size(157, 31);
            this.lblloding.TabIndex = 10;
            this.lblloding.Text = "Loading..";
            this.lblloding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblloding.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(18, 18);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(197, 36);
            this.progressBar1.Step = 0;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(16, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "listed View";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Image = global::Tree_List_Vieow_ParProgracesApp.Properties.Resources.person_paper_;
            this.pictureBox1.Location = new System.Drawing.Point(65, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tble_Pageq);
            this.tabControl1.Controls.Add(this.TblePage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(232, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 229);
            this.tabControl1.TabIndex = 3;
            // 
            // Tble_Pageq
            // 
            this.Tble_Pageq.BackColor = System.Drawing.Color.White;
            this.Tble_Pageq.Controls.Add(this.panel3);
            this.Tble_Pageq.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.Tble_Pageq.Location = new System.Drawing.Point(4, 29);
            this.Tble_Pageq.Name = "Tble_Pageq";
            this.Tble_Pageq.Padding = new System.Windows.Forms.Padding(3);
            this.Tble_Pageq.Size = new System.Drawing.Size(907, 196);
            this.Tble_Pageq.TabIndex = 0;
            this.Tble_Pageq.Text = "Add Remove";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(142)))), ((int)(((byte)(126)))));
            this.panel3.Controls.Add(this.txtbxLastName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnFillList);
            this.panel3.Controls.Add(this.bntRemovefromList);
            this.panel3.Controls.Add(this.btnAddtoList);
            this.panel3.Controls.Add(this.txtbxName);
            this.panel3.Controls.Add(this.txtbxID);
            this.panel3.Controls.Add(this.lbl_ID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(28, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 157);
            this.panel3.TabIndex = 2;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxLastName.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLastName.ForeColor = System.Drawing.Color.Black;
            this.txtbxLastName.Location = new System.Drawing.Point(135, 104);
            this.txtbxLastName.MaxLength = 32;
            this.txtbxLastName.Multiline = true;
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(173, 30);
            this.txtbxLastName.TabIndex = 7;
            this.txtbxLastName.TabStop = false;
            this.txtbxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtbx_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.label2.Location = new System.Drawing.Point(10, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name ";
            // 
            // btnFillList
            // 
            this.btnFillList.BackColor = System.Drawing.Color.White;
            this.btnFillList.FlatAppearance.BorderSize = 0;
            this.btnFillList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnFillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillList.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.btnFillList.ForeColor = System.Drawing.Color.Black;
            this.btnFillList.Location = new System.Drawing.Point(630, 90);
            this.btnFillList.Name = "btnFillList";
            this.btnFillList.Size = new System.Drawing.Size(87, 33);
            this.btnFillList.TabIndex = 5;
            this.btnFillList.Text = "Fill ";
            this.btnFillList.UseVisualStyleBackColor = false;
            this.btnFillList.Click += new System.EventHandler(this.btnFillList_Click);
            
            // bntRemovefromList
            // 
            this.bntRemovefromList.BackColor = System.Drawing.Color.White;
            this.bntRemovefromList.FlatAppearance.BorderSize = 0;
            this.bntRemovefromList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.bntRemovefromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntRemovefromList.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.bntRemovefromList.ForeColor = System.Drawing.Color.Black;
            this.bntRemovefromList.Location = new System.Drawing.Point(503, 90);
            this.bntRemovefromList.Name = "bntRemovefromList";
            this.bntRemovefromList.Size = new System.Drawing.Size(87, 33);
            this.bntRemovefromList.TabIndex = 4;
            this.bntRemovefromList.Text = "Remove";
            this.bntRemovefromList.UseVisualStyleBackColor = false;
            this.bntRemovefromList.Click += new System.EventHandler(this.bntRemovefromList_Click);
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.BackColor = System.Drawing.Color.White;
            this.btnAddtoList.FlatAppearance.BorderSize = 0;
            this.btnAddtoList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddtoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoList.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.btnAddtoList.ForeColor = System.Drawing.Color.Black;
            this.btnAddtoList.Location = new System.Drawing.Point(399, 90);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(61, 33);
            this.btnAddtoList.TabIndex = 3;
            this.btnAddtoList.Text = "Add";
            this.btnAddtoList.UseVisualStyleBackColor = false;
            this.btnAddtoList.Click += new System.EventHandler(this.btnAddtoList_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbxName.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxName.ForeColor = System.Drawing.Color.Black;
            this.txtbxName.Location = new System.Drawing.Point(135, 56);
            this.txtbxName.MaxLength = 32;
            this.txtbxName.Multiline = true;
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(173, 30);
            this.txtbxName.TabIndex = 2;
            this.txtbxName.TabStop = false;
            this.txtbxName.Validating += new System.ComponentModel.CancelEventHandler(this.txtbx_Validating);
            // 
            // txtbxID
            // 
            this.txtbxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxID.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxID.Location = new System.Drawing.Point(135, 16);
            this.txtbxID.MaxLength = 2;
            this.txtbxID.Multiline = true;
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(35, 26);
            this.txtbxID.TabIndex = 1;
            this.txtbxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxID_KeyPress);
            this.txtbxID.Validating += new System.ComponentModel.CancelEventHandler(this.txtbx_Validating);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.lbl_ID.Location = new System.Drawing.Point(10, 16);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(45, 23);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name ";
            // 
            // TblePage2
            // 
            this.TblePage2.BackColor = System.Drawing.Color.White;
            this.TblePage2.Controls.Add(this.panel4);
            this.TblePage2.Location = new System.Drawing.Point(4, 29);
            this.TblePage2.Name = "TblePage2";
            this.TblePage2.Padding = new System.Windows.Forms.Padding(3);
            this.TblePage2.Size = new System.Drawing.Size(907, 196);
            this.TblePage2.TabIndex = 1;
            this.TblePage2.Text = "Gender";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(142)))), ((int)(((byte)(126)))));
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.chboxMale);
            this.panel4.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(28, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(817, 151);
            this.panel4.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.Location = new System.Drawing.Point(105, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 27);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Female";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chboxMale
            // 
            this.chboxMale.AutoSize = true;
            this.chboxMale.FlatAppearance.BorderSize = 0;
            this.chboxMale.Location = new System.Drawing.Point(105, 26);
            this.chboxMale.Name = "chboxMale";
            this.chboxMale.Size = new System.Drawing.Size(82, 27);
            this.chboxMale.TabIndex = 0;
            this.chboxMale.Text = "Male";
            this.chboxMale.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 73;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 104;
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "LastName";
            this.clmLastName.Width = 126;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmName,
            this.clmLastName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(238, 262);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(905, 415);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualListSize = 100;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 677);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Tble_Pageq.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TblePage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tble_Pageq;
        private System.Windows.Forms.TabPage TblePage2;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntRemovefromList;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.Button btnFillList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chboxMale;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblloding;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.Button bntResetListView;
    }
}

