namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnActions = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.finalSentence = new System.Windows.Forms.RichTextBox();
            this.btnWand = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.ThemeView = new System.Windows.Forms.ListView();
            this.userControlStandard = new WindowsFormsApp1.UserControlStandard();
            this.userControlReact = new WindowsFormsApp1.UserControlReact();
            this.userControlUrgency = new WindowsFormsApp1.UserControlUrgency();
            this.userControlLibrary = new WindowsFormsApp1.UserControlLibrary();
            this.userControlLocation = new WindowsFormsApp1.UserControlLibrary();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnLibrary
            // 
            resources.ApplyResources(this.btnLibrary, "btnLibrary");
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActions
            // 
            resources.ApplyResources(this.btnActions, "btnActions");
            this.btnActions.Name = "btnActions";
            this.btnActions.UseVisualStyleBackColor = true;
            // 
            // btnLocation
            // 
            resources.ApplyResources(this.btnLocation, "btnLocation");
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnContact
            // 
            resources.ApplyResources(this.btnContact, "btnContact");
            this.btnContact.Name = "btnContact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEmergency
            // 
            resources.ApplyResources(this.btnEmergency, "btnEmergency");
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnOptions, "btnOptions");
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.button8_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.btnMenu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOptions, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEmergency, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLibrary, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLocation, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnContact, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActions, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.Controls.Add(this.btnCopy, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnKeyboard, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.finalSentence, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnWand, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReturn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSpeak, 2, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = false;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnKeyboard, "btnKeyboard");
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.UseVisualStyleBackColor = false;
            // 
            // finalSentence
            // 
            resources.ApplyResources(this.finalSentence, "finalSentence");
            this.finalSentence.Name = "finalSentence";
            // 
            // btnWand
            // 
            this.btnWand.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnWand, "btnWand");
            this.btnWand.FlatAppearance.BorderSize = 0;
            this.btnWand.Name = "btnWand";
            this.btnWand.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnReturn, "btnReturn");
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSpeak, "btnSpeak");
            this.btnSpeak.FlatAppearance.BorderSize = 0;
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.UseVisualStyleBackColor = false;
            // 
            // ThemeView
            // 
            resources.ApplyResources(this.ThemeView, "ThemeView");
            this.ThemeView.HideSelection = false;
            this.ThemeView.Name = "ThemeView";
            this.ThemeView.UseCompatibleStateImageBehavior = false;
            // 
            // userControlStandard
            // 
            resources.ApplyResources(this.userControlStandard, "userControlStandard");
            this.userControlStandard.Name = "userControlStandard";
            // 
            // userControlReact
            // 
            resources.ApplyResources(this.userControlReact, "userControlReact");
            this.userControlReact.Name = "userControlReact";
            // 
            // userControlUrgency
            // 
            resources.ApplyResources(this.userControlUrgency, "userControlUrgency");
            this.userControlUrgency.Name = "userControlUrgency";
            // 
            // userControlLibrary
            // 
            resources.ApplyResources(this.userControlLibrary, "userControlLibrary");
            this.userControlLibrary.Name = "userControlLibrary";
            this.userControlLibrary.Load += new System.EventHandler(this.userControlLibrary1_Load);
            // 
            // userControlLocation
            // 
            resources.ApplyResources(this.userControlLocation, "userControlLocation");
            this.userControlLocation.Name = "userControlLocation";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlLibrary);
            this.Controls.Add(this.userControlStandard);
            this.Controls.Add(this.ThemeView);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.userControlUrgency);
            this.Controls.Add(this.userControlReact);
            this.Controls.Add(this.userControlLocation);
            this.Name = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnActions;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.RichTextBox finalSentence;
        private System.Windows.Forms.Button btnWand;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.ListView ThemeView;
        private UserControlStandard userControlStandard;
        private UserControlReact userControlReact;
        private UserControlUrgency userControlUrgency;
        private UserControlLibrary userControlLibrary;
        private UserControlLibrary userControlLocation;
    }
}

