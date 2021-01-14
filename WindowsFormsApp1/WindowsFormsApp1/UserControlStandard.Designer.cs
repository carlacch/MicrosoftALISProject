
namespace WindowsFormsApp1
{
    partial class UserControlStandard
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
            this.wordCloudlistView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ThemeView = new System.Windows.Forms.ListView();
            this.btnInterpellate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.wordCloudlistView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 615F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 615);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // wordCloudlistView
            // 
            this.wordCloudlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordCloudlistView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordCloudlistView.HideSelection = false;
            this.wordCloudlistView.Location = new System.Drawing.Point(3, 4);
            this.wordCloudlistView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wordCloudlistView.Name = "wordCloudlistView";
            this.wordCloudlistView.Size = new System.Drawing.Size(895, 607);
            this.wordCloudlistView.TabIndex = 0;
            this.wordCloudlistView.TileSize = new System.Drawing.Size(200, 60);
            this.wordCloudlistView.UseCompatibleStateImageBehavior = false;
            this.wordCloudlistView.View = System.Windows.Forms.View.Tile;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ThemeView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnInterpellate, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(901, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67323F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.32677F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(159, 613);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ThemeView
            // 
            this.ThemeView.CheckBoxes = true;
            this.ThemeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThemeView.HideSelection = false;
            this.ThemeView.Location = new System.Drawing.Point(3, 68);
            this.ThemeView.Name = "ThemeView";
            this.ThemeView.Size = new System.Drawing.Size(153, 542);
            this.ThemeView.TabIndex = 21;
            this.ThemeView.UseCompatibleStateImageBehavior = false;
            this.ThemeView.View = System.Windows.Forms.View.List;
            this.ThemeView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ThemeView_ItemCheck);
            // 
            // btnInterpellate
            // 
            this.btnInterpellate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInterpellate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInterpellate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInterpellate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnInterpellate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInterpellate.Location = new System.Drawing.Point(3, 3);
            this.btnInterpellate.Name = "btnInterpellate";
            this.btnInterpellate.Size = new System.Drawing.Size(153, 59);
            this.btnInterpellate.TabIndex = 14;
            this.btnInterpellate.Text = "Interpeller";
            this.btnInterpellate.UseVisualStyleBackColor = false;
            // 
            // UserControlStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlStandard";
            this.Size = new System.Drawing.Size(1060, 615);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView wordCloudlistView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnInterpellate;
        private System.Windows.Forms.ListView ThemeView;
    }
}
