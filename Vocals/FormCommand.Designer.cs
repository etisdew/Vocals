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
            this.label1 = new System.Windows.Forms.Label();
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
            this.textBox_CommandWord.BackColor = System.Drawing.Color.Black;
            this.textBox_CommandWord.ForeColor = System.Drawing.Color.White;
            this.textBox_CommandWord.Location = new System.Drawing.Point(68, 35);
            this.textBox_CommandWord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_CommandWord.Name = "textBox_CommandWord";
            this.textBox_CommandWord.Size = new System.Drawing.Size(158, 21);
            this.textBox_CommandWord.TabIndex = 0;
            this.textBox_CommandWord.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox_MacroList
            // 
            this.listBox_MacroList.BackColor = System.Drawing.Color.Black;
            this.listBox_MacroList.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_MacroList.ForeColor = System.Drawing.Color.White;
            this.listBox_MacroList.FormattingEnabled = true;
            this.listBox_MacroList.ItemHeight = 15;
            this.listBox_MacroList.Location = new System.Drawing.Point(4, 13);
            this.listBox_MacroList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox_MacroList.Name = "listBox_MacroList";
            this.listBox_MacroList.Size = new System.Drawing.Size(170, 244);
            this.listBox_MacroList.TabIndex = 2;
            this.listBox_MacroList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Teal;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(178, 20);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(47, 31);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add action";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Crimson;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Location = new System.Drawing.Point(178, 94);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(47, 31);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "Delete action";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_ConfirmNewCommand
            // 
            this.button_ConfirmNewCommand.BackColor = System.Drawing.Color.Teal;
            this.button_ConfirmNewCommand.FlatAppearance.BorderSize = 0;
            this.button_ConfirmNewCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ConfirmNewCommand.ForeColor = System.Drawing.Color.White;
            this.button_ConfirmNewCommand.Location = new System.Drawing.Point(241, 349);
            this.button_ConfirmNewCommand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_ConfirmNewCommand.Name = "button_ConfirmNewCommand";
            this.button_ConfirmNewCommand.Size = new System.Drawing.Size(240, 27);
            this.button_ConfirmNewCommand.TabIndex = 13;
            this.button_ConfirmNewCommand.Text = "Confirm";
            this.button_ConfirmNewCommand.UseVisualStyleBackColor = false;
            this.button_ConfirmNewCommand.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_CancelNewCommand
            // 
            this.button_CancelNewCommand.BackColor = System.Drawing.Color.Crimson;
            this.button_CancelNewCommand.FlatAppearance.BorderSize = 0;
            this.button_CancelNewCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CancelNewCommand.ForeColor = System.Drawing.Color.White;
            this.button_CancelNewCommand.Location = new System.Drawing.Point(3, 349);
            this.button_CancelNewCommand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_CancelNewCommand.Name = "button_CancelNewCommand";
            this.button_CancelNewCommand.Size = new System.Drawing.Size(233, 27);
            this.button_CancelNewCommand.TabIndex = 12;
            this.button_CancelNewCommand.Text = "Cancel";
            this.button_CancelNewCommand.UseVisualStyleBackColor = false;
            this.button_CancelNewCommand.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_CommandWord);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(233, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.button_MoveDown);
            this.groupBox2.Controls.Add(this.button_MoveUp);
            this.groupBox2.Controls.Add(this.button_Edit);
            this.groupBox2.Controls.Add(this.listBox_MacroList);
            this.groupBox2.Controls.Add(this.button_Add);
            this.groupBox2.Controls.Add(this.button_Delete);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(233, 263);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_MoveDown
            // 
            this.button_MoveDown.BackColor = System.Drawing.Color.Purple;
            this.button_MoveDown.FlatAppearance.BorderSize = 0;
            this.button_MoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MoveDown.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MoveDown.Location = new System.Drawing.Point(178, 224);
            this.button_MoveDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_MoveDown.Name = "button_MoveDown";
            this.button_MoveDown.Size = new System.Drawing.Size(47, 31);
            this.button_MoveDown.TabIndex = 6;
            this.button_MoveDown.Text = "Down";
            this.button_MoveDown.UseVisualStyleBackColor = false;
            this.button_MoveDown.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_MoveUp
            // 
            this.button_MoveUp.BackColor = System.Drawing.Color.Purple;
            this.button_MoveUp.FlatAppearance.BorderSize = 0;
            this.button_MoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MoveUp.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MoveUp.Location = new System.Drawing.Point(178, 187);
            this.button_MoveUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_MoveUp.Name = "button_MoveUp";
            this.button_MoveUp.Size = new System.Drawing.Size(47, 31);
            this.button_MoveUp.TabIndex = 5;
            this.button_MoveUp.Text = "Up";
            this.button_MoveUp.UseVisualStyleBackColor = false;
            this.button_MoveUp.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.Gold;
            this.button_Edit.FlatAppearance.BorderSize = 0;
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.Location = new System.Drawing.Point(178, 57);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(47, 31);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox_UseVoiceSythesis
            // 
            this.checkBox_UseVoiceSythesis.AutoSize = true;
            this.checkBox_UseVoiceSythesis.Location = new System.Drawing.Point(11, 63);
            this.checkBox_UseVoiceSythesis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox_UseVoiceSythesis.Name = "checkBox_UseVoiceSythesis";
            this.checkBox_UseVoiceSythesis.Size = new System.Drawing.Size(124, 19);
            this.checkBox_UseVoiceSythesis.TabIndex = 9;
            this.checkBox_UseVoiceSythesis.Text = "Use voice synthetizer";
            this.checkBox_UseVoiceSythesis.UseVisualStyleBackColor = true;
            this.checkBox_UseVoiceSythesis.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox_VoiceSythesisString
            // 
            this.richTextBox_VoiceSythesisString.BackColor = System.Drawing.Color.Black;
            this.richTextBox_VoiceSythesisString.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_VoiceSythesisString.ForeColor = System.Drawing.Color.White;
            this.richTextBox_VoiceSythesisString.Location = new System.Drawing.Point(6, 89);
            this.richTextBox_VoiceSythesisString.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBox_VoiceSythesisString.Name = "richTextBox_VoiceSythesisString";
            this.richTextBox_VoiceSythesisString.Size = new System.Drawing.Size(230, 249);
            this.richTextBox_VoiceSythesisString.TabIndex = 11;
            this.richTextBox_VoiceSythesisString.Text = "";
            this.richTextBox_VoiceSythesisString.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox_UseVoiceSythesis);
            this.groupBox4.Controls.Add(this.richTextBox_VoiceSythesisString);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(241, -2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(240, 344);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(74, 35);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Teal;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(11, 31);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 27);
            this.button9.TabIndex = 7;
            this.button9.Text = "Select File";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(139, 63);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 19);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Use sound file";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FormCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 383);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_CancelNewCommand);
            this.Controls.Add(this.button_ConfirmNewCommand);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Label label1;
    }
}