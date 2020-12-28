namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_urgence = new System.Windows.Forms.Button();
            this.button_biblio = new System.Windows.Forms.Button();
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_home = new WindowsFormsApp1.RoundButton();
            this.groupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_urgence
            // 
            this.button_urgence.Location = new System.Drawing.Point(73, 21);
            this.button_urgence.Name = "button_urgence";
            this.button_urgence.Size = new System.Drawing.Size(125, 43);
            this.button_urgence.TabIndex = 0;
            this.button_urgence.Text = "Urgences";
            this.button_urgence.UseVisualStyleBackColor = true;
            this.button_urgence.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_biblio
            // 
            this.button_biblio.Location = new System.Drawing.Point(204, 21);
            this.button_biblio.Name = "button_biblio";
            this.button_biblio.Size = new System.Drawing.Size(101, 43);
            this.button_biblio.TabIndex = 1;
            this.button_biblio.Text = "Bibliotèque";
            this.button_biblio.UseVisualStyleBackColor = true;
            this.button_biblio.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupMenu
            // 
            this.groupMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupMenu.Controls.Add(this.button_home);
            this.groupMenu.Controls.Add(this.button_urgence);
            this.groupMenu.Controls.Add(this.button_biblio);
            this.groupMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupMenu.Location = new System.Drawing.Point(35, 29);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(753, 279);
            this.groupMenu.TabIndex = 2;
            this.groupMenu.TabStop = false;
            this.groupMenu.Text = "groupMenu";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Home.png");
            // 
            // button_home
            // 
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ImageIndex = 0;
            this.button_home.ImageList = this.imageList1;
            this.button_home.Location = new System.Drawing.Point(14, 21);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(50, 43);
            this.button_home.TabIndex = 3;
            this.button_home.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_urgence;
        private System.Windows.Forms.Button button_biblio;
        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.ImageList imageList1;
        private RoundButton button_home;
    }
}

