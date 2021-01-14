
namespace WindowsFormsApp1
{
    partial class UserControlReact
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Les phrases détectées seront affichées ici"}, -1, System.Drawing.SystemColors.WindowFrame, System.Drawing.Color.Empty, null);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.wordCloudlistView = new System.Windows.Forms.ListView();
            this.SentenceslistView = new System.Windows.Forms.ListView();
            this.ThemeView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSmiley = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOui = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.wordCloudlistView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SentenceslistView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ThemeView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // wordCloudlistView
            // 
            this.wordCloudlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordCloudlistView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordCloudlistView.HideSelection = false;
            this.wordCloudlistView.Location = new System.Drawing.Point(3, 134);
            this.wordCloudlistView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.wordCloudlistView.Name = "wordCloudlistView";
            this.wordCloudlistView.Size = new System.Drawing.Size(898, 480);
            this.wordCloudlistView.TabIndex = 15;
            this.wordCloudlistView.TileSize = new System.Drawing.Size(200, 60);
            this.wordCloudlistView.UseCompatibleStateImageBehavior = false;
            this.wordCloudlistView.View = System.Windows.Forms.View.Tile;
            // 
            // SentenceslistView
            // 
            this.SentenceslistView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SentenceslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SentenceslistView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SentenceslistView.HideSelection = false;
            this.SentenceslistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.SentenceslistView.Location = new System.Drawing.Point(3, 3);
            this.SentenceslistView.Name = "SentenceslistView";
            this.SentenceslistView.Size = new System.Drawing.Size(898, 125);
            this.SentenceslistView.TabIndex = 0;
            this.SentenceslistView.TileSize = new System.Drawing.Size(870, 44);
            this.SentenceslistView.UseCompatibleStateImageBehavior = false;
            this.SentenceslistView.View = System.Windows.Forms.View.Tile;
            // 
            // ThemeView
            // 
            this.ThemeView.CheckBoxes = true;
            this.ThemeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThemeView.HideSelection = false;
            this.ThemeView.Location = new System.Drawing.Point(907, 134);
            this.ThemeView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.ThemeView.Name = "ThemeView";
            this.ThemeView.Size = new System.Drawing.Size(154, 480);
            this.ThemeView.TabIndex = 1;
            this.ThemeView.UseCompatibleStateImageBehavior = false;
            this.ThemeView.View = System.Windows.Forms.View.List;
            this.ThemeView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.wordCloudlistView_ItemCheck);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.64968F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.35032F));
            this.tableLayoutPanel2.Controls.Add(this.btnSmiley, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(904, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(160, 129);
            this.tableLayoutPanel2.TabIndex = 16;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnSmiley
            // 
            this.btnSmiley.BackColor = System.Drawing.Color.Gold;
            this.btnSmiley.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSmiley.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSmiley.Location = new System.Drawing.Point(84, 3);
            this.btnSmiley.Name = "btnSmiley";
            this.btnSmiley.Size = new System.Drawing.Size(73, 123);
            this.btnSmiley.TabIndex = 9;
            this.btnSmiley.Text = "GIF";
            this.btnSmiley.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnOui, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnNon, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(81, 129);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnOui
            // 
            this.btnOui.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOui.Location = new System.Drawing.Point(3, 3);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(75, 58);
            this.btnOui.TabIndex = 0;
            this.btnOui.Text = "OUI";
            this.btnOui.UseVisualStyleBackColor = false;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // btnNon
            // 
            this.btnNon.BackColor = System.Drawing.Color.LightCoral;
            this.btnNon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNon.Location = new System.Drawing.Point(3, 67);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(75, 59);
            this.btnNon.TabIndex = 1;
            this.btnNon.Text = "NON";
            this.btnNon.UseVisualStyleBackColor = false;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlReact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlReact";
            this.Size = new System.Drawing.Size(1064, 618);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView SentenceslistView;
        private System.Windows.Forms.ListView ThemeView;
        private System.Windows.Forms.ListView wordCloudlistView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSmiley;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.Button btnNon;
    }
}
