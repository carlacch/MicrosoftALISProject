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
            this.Menu = new System.Windows.Forms.Button();
            this.Library = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Button();
            this.Emergency = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Copy = new System.Windows.Forms.Button();
            this.Keyboard = new System.Windows.Forms.Button();
            this.finalSentence = new System.Windows.Forms.RichTextBox();
            this.Wand = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Speak = new System.Windows.Forms.Button();
            this.Interpellate = new System.Windows.Forms.Button();
            this.ThemeView = new System.Windows.Forms.ListView();
            this.userControlStandard1 = new WindowsFormsApp1.UserControlStandard();
            this.userControlReact1 = new WindowsFormsApp1.UserControlReact();
            this.userControlUrgency1 = new WindowsFormsApp1.UserControlUrgency();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.Name = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            // 
            // Library
            // 
            resources.ApplyResources(this.Library, "Library");
            this.Library.Name = "Library";
            this.Library.UseVisualStyleBackColor = true;
            this.Library.Click += new System.EventHandler(this.button2_Click);
            // 
            // Actions
            // 
            resources.ApplyResources(this.Actions, "Actions");
            this.Actions.Name = "Actions";
            this.Actions.UseVisualStyleBackColor = true;
            // 
            // btnLocation
            // 
            resources.ApplyResources(this.btnLocation, "btnLocation");
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.button4_Click);
            // 
            // Contact
            // 
            resources.ApplyResources(this.Contact, "Contact");
            this.Contact.Name = "Contact";
            this.Contact.UseVisualStyleBackColor = true;
            this.Contact.Click += new System.EventHandler(this.button6_Click);
            // 
            // Emergency
            // 
            resources.ApplyResources(this.Emergency, "Emergency");
            this.Emergency.Name = "Emergency";
            this.Emergency.UseVisualStyleBackColor = true;
            this.Emergency.Click += new System.EventHandler(this.button5_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Back, "Back");
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.Name = "Back";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Options, "Options");
            this.Options.FlatAppearance.BorderSize = 0;
            this.Options.Name = "Options";
            this.Options.UseVisualStyleBackColor = false;
            this.Options.Click += new System.EventHandler(this.button8_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.Menu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Options, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.Emergency, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Back, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.Library, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLocation, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.Contact, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Actions, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.Controls.Add(this.Copy, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.Keyboard, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.finalSentence, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Wand, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.Return, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Speak, 2, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Copy, "Copy");
            this.Copy.FlatAppearance.BorderSize = 0;
            this.Copy.Name = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            // 
            // Keyboard
            // 
            this.Keyboard.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Keyboard, "Keyboard");
            this.Keyboard.FlatAppearance.BorderSize = 0;
            this.Keyboard.Name = "Keyboard";
            this.Keyboard.UseVisualStyleBackColor = false;
            // 
            // finalSentence
            // 
            resources.ApplyResources(this.finalSentence, "finalSentence");
            this.finalSentence.Name = "finalSentence";
            // 
            // Wand
            // 
            this.Wand.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Wand, "Wand");
            this.Wand.FlatAppearance.BorderSize = 0;
            this.Wand.Name = "Wand";
            this.Wand.UseVisualStyleBackColor = false;
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Return, "Return");
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.Name = "Return";
            this.Return.UseVisualStyleBackColor = false;
            // 
            // Speak
            // 
            this.Speak.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Speak, "Speak");
            this.Speak.FlatAppearance.BorderSize = 0;
            this.Speak.Name = "Speak";
            this.Speak.UseVisualStyleBackColor = false;
            // 
            // Interpellate
            // 
            resources.ApplyResources(this.Interpellate, "Interpellate");
            this.Interpellate.Name = "Interpellate";
            this.Interpellate.UseVisualStyleBackColor = true;
            // 
            // ThemeView
            // 
            resources.ApplyResources(this.ThemeView, "ThemeView");
            this.ThemeView.HideSelection = false;
            this.ThemeView.Name = "ThemeView";
            this.ThemeView.UseCompatibleStateImageBehavior = false;
            // 
            // userControlStandard1
            // 
            resources.ApplyResources(this.userControlStandard1, "userControlStandard1");
            this.userControlStandard1.Name = "userControlStandard1";
            // 
            // userControlReact1
            // 
            resources.ApplyResources(this.userControlReact1, "userControlReact1");
            this.userControlReact1.Name = "userControlReact1";
            // 
            // userControlUrgency1
            // 
            resources.ApplyResources(this.userControlUrgency1, "userControlUrgency1");
            this.userControlUrgency1.Name = "userControlUrgency1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlStandard1);
            this.Controls.Add(this.ThemeView);
            this.Controls.Add(this.Interpellate);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.userControlUrgency1);
            this.Controls.Add(this.userControlReact1);
            this.Name = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Library;
        private System.Windows.Forms.Button Actions;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button Emergency;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Keyboard;
        private System.Windows.Forms.RichTextBox finalSentence;
        private System.Windows.Forms.Button Wand;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.Button Interpellate;
        private System.Windows.Forms.ListView ThemeView;
        private UserControlStandard userControlStandard1;
        private UserControlReact userControlReact1;
        private UserControlUrgency userControlUrgency1;
    }
}

