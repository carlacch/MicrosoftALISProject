﻿namespace WindowsFormsApp1
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
            this.userControlStandard = new WindowsFormsApp1.UserControlStandard();
            this.userControlLibrary = new WindowsFormsApp1.UserControlLibrary();
            this.userControlLocation = new WindowsFormsApp1.UserControlLibrary();
            this.userControlAction = new WindowsFormsApp1.UserControlAction();
            this.userControlUrgency = new WindowsFormsApp1.UserControlUrgency();
            this.userControlContact = new WindowsFormsApp1.UserControlContact();
            this.userControlReact = new WindowsFormsApp1.UserControlReact();
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
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLibrary
            // 
            resources.ApplyResources(this.btnLibrary, "btnLibrary");
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnActions
            // 
            resources.ApplyResources(this.btnActions, "btnActions");
            this.btnActions.Name = "btnActions";
            this.btnActions.UseVisualStyleBackColor = true;
            this.btnActions.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // btnLocation
            // 
            resources.ApplyResources(this.btnLocation, "btnLocation");
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnContact
            // 
            resources.ApplyResources(this.btnContact, "btnContact");
            this.btnContact.Name = "btnContact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnEmergency
            // 
            resources.ApplyResources(this.btnEmergency, "btnEmergency");
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
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
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // finalSentence
            // 
            resources.ApplyResources(this.finalSentence, "finalSentence");
            this.finalSentence.Name = "finalSentence";
            this.finalSentence.TextChanged += new System.EventHandler(this.finalSentence_TextChanged);
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
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSpeak, "btnSpeak");
            this.btnSpeak.FlatAppearance.BorderSize = 0;
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // userControlStandard
            // 
            resources.ApplyResources(this.userControlStandard, "userControlStandard");
            this.userControlStandard.Name = "userControlStandard";
            this.userControlStandard.Load += new System.EventHandler(this.userControlStandard_Load);
            // 
            // userControlLibrary
            // 
            resources.ApplyResources(this.userControlLibrary, "userControlLibrary");
            this.userControlLibrary.Name = "userControlLibrary";
            this.userControlLibrary.Load += new System.EventHandler(this.userControlLibrary_Load);
            // 
            // userControlLocation
            // 
            resources.ApplyResources(this.userControlLocation, "userControlLocation");
            this.userControlLocation.Name = "userControlLocation";
            this.userControlLocation.Load += new System.EventHandler(this.userControlLocation_Load);
            // 
            // userControlAction
            // 
            resources.ApplyResources(this.userControlAction, "userControlAction");
            this.userControlAction.Name = "userControlAction";
            this.userControlAction.Load += new System.EventHandler(this.userControlAction_Load);
            // 
            // userControlUrgency
            // 
            resources.ApplyResources(this.userControlUrgency, "userControlUrgency");
            this.userControlUrgency.Name = "userControlUrgency";
            this.userControlUrgency.Load += new System.EventHandler(this.userControlUrgency_Load);
            // 
            // userControlContact
            // 
            resources.ApplyResources(this.userControlContact, "userControlContact");
            this.userControlContact.Name = "userControlContact";
            // 
            // userControlReact
            // 
            resources.ApplyResources(this.userControlReact, "userControlReact");
            this.userControlReact.Name = "userControlReact";
            this.userControlReact.Load += new System.EventHandler(this.userControlReact_Load);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlReact);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.userControlLocation);
            this.Controls.Add(this.userControlContact);
            this.Controls.Add(this.userControlUrgency);
            this.Controls.Add(this.userControlAction);
            this.Controls.Add(this.userControlLibrary);
            this.Controls.Add(this.userControlStandard);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnWand;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSpeak;
        private UserControlStandard userControlStandard;
        private UserControlLibrary userControlLibrary;
        private UserControlLibrary userControlLocation;
        private UserControlAction userControlAction;
        private UserControlUrgency userControlUrgency;
        private UserControlContact userControlContact;
        internal UserControlReact userControlReact;        
        internal System.Windows.Forms.RichTextBox finalSentence;
    }
}

