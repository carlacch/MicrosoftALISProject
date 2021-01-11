
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ThemeView = new System.Windows.Forms.ListView();
            this.SentenceslistView = new System.Windows.Forms.ListView();
            this.wordCloudlistView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSmiley = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.btnOui = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.Controls.Add(this.ThemeView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SentenceslistView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.wordCloudlistView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 481F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 618);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ThemeView
            // 
            this.ThemeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThemeView.HideSelection = false;
            this.ThemeView.Location = new System.Drawing.Point(3, 140);
            this.ThemeView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.ThemeView.Name = "ThemeView";
            this.ThemeView.Size = new System.Drawing.Size(900, 474);
            this.ThemeView.TabIndex = 15;
            this.ThemeView.UseCompatibleStateImageBehavior = false;
            // 
            // SentenceslistView
            // 
            this.SentenceslistView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.SentenceslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SentenceslistView.HideSelection = false;
            this.SentenceslistView.Location = new System.Drawing.Point(3, 3);
            this.SentenceslistView.Name = "SentenceslistView";
            this.SentenceslistView.Size = new System.Drawing.Size(900, 131);
            this.SentenceslistView.TabIndex = 0;
            this.SentenceslistView.UseCompatibleStateImageBehavior = false;
            // 
            // wordCloudlistView
            // 
            this.wordCloudlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordCloudlistView.HideSelection = false;
            this.wordCloudlistView.Location = new System.Drawing.Point(909, 140);
            this.wordCloudlistView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.wordCloudlistView.Name = "wordCloudlistView";
            this.wordCloudlistView.Size = new System.Drawing.Size(152, 474);
            this.wordCloudlistView.TabIndex = 1;
            this.wordCloudlistView.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSmiley);
            this.panel1.Controls.Add(this.btnNon);
            this.panel1.Controls.Add(this.btnOui);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(906, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 137);
            this.panel1.TabIndex = 16;
            // 
            // btnSmiley
            // 
            this.btnSmiley.BackColor = System.Drawing.Color.Gold;
            this.btnSmiley.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSmiley.Location = new System.Drawing.Point(104, 3);
            this.btnSmiley.Name = "btnSmiley";
            this.btnSmiley.Size = new System.Drawing.Size(51, 131);
            this.btnSmiley.TabIndex = 2;
            this.btnSmiley.Text = "GIF";
            this.btnSmiley.UseVisualStyleBackColor = false;
            // 
            // btnNon
            // 
            this.btnNon.BackColor = System.Drawing.Color.LightCoral;
            this.btnNon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNon.Location = new System.Drawing.Point(4, 73);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(94, 61);
            this.btnNon.TabIndex = 1;
            this.btnNon.Text = "NON";
            this.btnNon.UseVisualStyleBackColor = false;
            // 
            // btnOui
            // 
            this.btnOui.BackColor = System.Drawing.Color.YellowGreen;
            this.btnOui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOui.Location = new System.Drawing.Point(4, 3);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(94, 67);
            this.btnOui.TabIndex = 0;
            this.btnOui.Text = "OUI";
            this.btnOui.UseVisualStyleBackColor = false;
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView SentenceslistView;
        private System.Windows.Forms.ListView wordCloudlistView;
        private System.Windows.Forms.ListView ThemeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSmiley;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.Button btnOui;
    }
}
