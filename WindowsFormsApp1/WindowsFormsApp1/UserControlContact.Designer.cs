
namespace WindowsFormsApp1
{
    partial class UserControlContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlContact));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewFavoriteContact = new System.Windows.Forms.ListView();
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnMsg = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.wordCloudlistView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.69792F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.30209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.wordCloudlistView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 618);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.listViewFavoriteContact, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.listViewContacts, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.24837F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.75163F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(227, 616);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // listViewFavoriteContact
            // 
            this.listViewFavoriteContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFavoriteContact.HideSelection = false;
            this.listViewFavoriteContact.Location = new System.Drawing.Point(3, 3);
            this.listViewFavoriteContact.Name = "listViewFavoriteContact";
            this.listViewFavoriteContact.Size = new System.Drawing.Size(221, 174);
            this.listViewFavoriteContact.TabIndex = 0;
            this.listViewFavoriteContact.UseCompatibleStateImageBehavior = false;
            // 
            // listViewContacts
            // 
            this.listViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContacts.HideSelection = false;
            this.listViewContacts.Location = new System.Drawing.Point(3, 183);
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(221, 430);
            this.listViewContacts.TabIndex = 1;
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnAddContact, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnWrite, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnMsg, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnCall, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(964, 192);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(97, 233);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.Transparent;
            this.btnAddContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddContact.FlatAppearance.BorderSize = 0;
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContact.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContact.Image")));
            this.btnAddContact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddContact.Location = new System.Drawing.Point(3, 178);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(91, 51);
            this.btnAddContact.TabIndex = 16;
            this.btnAddContact.UseVisualStyleBackColor = false;
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.Transparent;
            this.btnWrite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Image = ((System.Drawing.Image)(resources.GetObject("btnWrite.Image")));
            this.btnWrite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnWrite.Location = new System.Drawing.Point(3, 120);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(91, 50);
            this.btnWrite.TabIndex = 15;
            this.btnWrite.UseVisualStyleBackColor = false;
            // 
            // btnMsg
            // 
            this.btnMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMsg.FlatAppearance.BorderSize = 0;
            this.btnMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMsg.Image = ((System.Drawing.Image)(resources.GetObject("btnMsg.Image")));
            this.btnMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMsg.Location = new System.Drawing.Point(3, 62);
            this.btnMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(91, 50);
            this.btnMsg.TabIndex = 14;
            this.btnMsg.UseVisualStyleBackColor = false;
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCall.FlatAppearance.BorderSize = 0;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.Image = ((System.Drawing.Image)(resources.GetObject("btnCall.Image")));
            this.btnCall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCall.Location = new System.Drawing.Point(3, 4);
            this.btnCall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(91, 50);
            this.btnCall.TabIndex = 13;
            this.btnCall.UseVisualStyleBackColor = false;
            // 
            // wordCloudlistView
            // 
            this.wordCloudlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordCloudlistView.HideSelection = false;
            this.wordCloudlistView.Location = new System.Drawing.Point(230, 4);
            this.wordCloudlistView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wordCloudlistView.Name = "wordCloudlistView";
            this.wordCloudlistView.Size = new System.Drawing.Size(728, 610);
            this.wordCloudlistView.TabIndex = 1;
            this.wordCloudlistView.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlContact";
            this.Size = new System.Drawing.Size(1064, 618);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListView listViewFavoriteContact;
        private System.Windows.Forms.ListView listViewContacts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.ListView wordCloudlistView;
    }
}
