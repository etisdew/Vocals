namespace Vocals
{
    partial class FormCommand
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
            this.textBox_CommandWord = new System.Windows.Forms.TextBox();
            this.listBox_MacroList = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_ConfirmNewCommand = new System.Windows.Forms.Button();
            this.button_CancelNewCommand = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_MoveDown = new System.Windows.Forms.Button();
            this.button_MoveUp = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.checkBox_UseVoiceSythesis = new System.Windows.Forms.CheckBox();
            this.richTextBox_VoiceSythesisString = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_CommandWord
            // 
            this.textBox_CommandWord.Location = new System.Drawing.Point(6, 30);
            this.textBox_CommandWord.Name = "textBox_CommandWord";
            this.textBox_CommandWord.Size = new System.Drawing.Size(267, 20);
            this.textBox_CommandWord.TabIndex = 0;
            this.textBox_CommandWord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox_MacroList
            // 
            this.listBox_MacroList.FormattingEnabled = true;
            this.listBox_MacroList.Location = new System.Drawing.Point(15, 74);
            this.listBox_MacroList.Name = "listBox_MacroList";
            this.listBox_MacroList.Size = new System.Drawing.Size(195, 134);
            this.listBox_MacroList.TabIndex = 4;
            this.listBox_MacroList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(15, 34);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(60, 23);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Add action";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(150, 34);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(60, 23);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Delete action";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_ConfirmNewCommand
            // 
            this.button_ConfirmNewCommand.Location = new System.Drawing.Point(511, 316);
            this.button_ConfirmNewCommand.Name = "button_ConfirmNewCommand";
            this.button_ConfirmNewCommand.Size = new System.Drawing.Size(75, 23);
            this.button_ConfirmNewCommand.TabIndex = 8;
            this.button_ConfirmNewCommand.Text = "Confirm";
            this.button_ConfirmNewCommand.UseVisualStyleBackColor = true;
            this.button_ConfirmNewCommand.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_CancelNewCommand
            // 
            this.button_CancelNewCommand.Location = new System.Drawing.Point(12, 316);
            this.button_CancelNewCommand.Name = "button_CancelNewCommand";
            this.button_CancelNewCommand.Size = new System.Drawing.Size(75, 23);
            this.button_CancelNewCommand.TabIndex = 9;
            this.button_CancelNewCommand.Text = "Cancel";
            this.button_CancelNewCommand.UseVisualStyleBackColor = true;
            this.button_CancelNewCommand.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_CommandWord);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_MoveDown);
            this.groupBox2.Controls.Add(this.button_MoveUp);
            this.groupBox2.Controls.Add(this.button_Edit);
            this.groupBox2.Controls.Add(this.listBox_MacroList);
            this.groupBox2.Controls.Add(this.button_Add);
            this.groupBox2.Controls.Add(this.button_Delete);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 221);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_MoveDown
            // 
            this.button_MoveDown.Location = new System.Drawing.Point(216, 140);
            this.button_MoveDown.Name = "button_MoveDown";
            this.button_MoveDown.Size = new System.Drawing.Size(57, 23);
            this.button_MoveDown.TabIndex = 10;
            this.button_MoveDown.Text = "Down";
            this.button_MoveDown.UseVisualStyleBackColor = true;
            this.button_MoveDown.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_MoveUp
            // 
            this.button_MoveUp.Location = new System.Drawing.Point(216, 111);
            this.button_MoveUp.Name = "button_MoveUp";
            this.button_MoveUp.Size = new System.Drawing.Size(57, 23);
            this.button_MoveUp.TabIndex = 9;
            this.button_MoveUp.Text = "Up";
            this.button_MoveUp.UseVisualStyleBackColor = true;
            this.button_MoveUp.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(84, 34);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(60, 23);
            this.button_Edit.TabIndex = 8;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox_UseVoiceSythesis
            // 
            this.checkBox_UseVoiceSythesis.AutoSize = true;
            this.checkBox_UseVoiceSythesis.Location = new System.Drawing.Point(7, 97);
            this.checkBox_UseVoiceSythesis.Name = "checkBox_UseVoiceSythesis";
            this.checkBox_UseVoiceSythesis.Size = new System.Drawing.Size(127, 17);
            this.checkBox_UseVoiceSythesis.TabIndex = 12;
            this.checkBox_UseVoiceSythesis.Text = "Use voice synthetizer";
            this.checkBox_UseVoiceSythesis.UseVisualStyleBackColor = true;
            this.checkBox_UseVoiceSythesis.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox_VoiceSythesisString
            // 
            this.richTextBox_VoiceSythesisString.Location = new System.Drawing.Point(7, 120);
            this.richTextBox_VoiceSythesisString.Name = "richTextBox_VoiceSythesisString";
            this.richTextBox_VoiceSythesisString.Size = new System.Drawing.Size(276, 165);
            this.richTextBox_VoiceSythesisString.TabIndex = 13;
            this.richTextBox_VoiceSythesisString.Text = "";
            this.richTextBox_VoiceSythesisString.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox_UseVoiceSythesis);
            this.groupBox4.Controls.Add(this.richTextBox_VoiceSythesisString);
            this.groupBox4.Location = new System.Drawing.Point(298, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 298);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Command answering";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 20);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(7, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Select File";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Use sound file (wav)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FormCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 349);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_CancelNewCommand);
            this.Controls.Add(this.button_ConfirmNewCommand);
            this.Name = "FormCommand";
            this.Text = "New Command";
            this.Load += new System.EventHandler(this.FormPopup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CommandWord;
        private System.Windows.Forms.ListBox listBox_MacroList;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_ConfirmNewCommand;
        private System.Windows.Forms.Button button_CancelNewCommand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_MoveDown;
        private System.Windows.Forms.Button button_MoveUp;
        private System.Windows.Forms.CheckBox checkBox_UseVoiceSythesis;
        private System.Windows.Forms.RichTextBox richTextBox_VoiceSythesisString;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
    }
}