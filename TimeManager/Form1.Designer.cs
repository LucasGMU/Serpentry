namespace TimeManager
{
    partial class Serpentry
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            listBox1 = new ListBox();
            addPriority = new Button();
            decreasePriority = new Button();
            chosenItem = new Label();
            button2 = new Button();
            chosen = new Label();
            notifyButton = new Button();
            minuteLabel = new Label();
            textBoxMinutes = new TextBox();
            toastNotif = new System.Windows.Forms.Timer(components);
            textBoxTask = new TextBox();
            taskQuestion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 29);
            label1.Name = "label1";
            label1.Size = new Size(509, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Serpentry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 576);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "2024 Lucas Parter";
            label2.Click += label2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 291);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 219);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 3;
            label3.Text = "Enter in your tasks:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(405, 347);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "Generate!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 404);
            label4.Name = "label4";
            label4.Size = new Size(210, 20);
            label4.TabIndex = 5;
            label4.Text = "Hit generate once you're done";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(14, 121);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 364);
            listBox1.TabIndex = 6;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // addPriority
            // 
            addPriority.Location = new Point(312, 201);
            addPriority.Margin = new Padding(3, 4, 3, 4);
            addPriority.Name = "addPriority";
            addPriority.Size = new Size(86, 81);
            addPriority.TabIndex = 7;
            addPriority.Text = "^";
            addPriority.UseVisualStyleBackColor = true;
            addPriority.Visible = false;
            addPriority.Click += button2_Click;
            // 
            // decreasePriority
            // 
            decreasePriority.Location = new Point(312, 347);
            decreasePriority.Margin = new Padding(3, 4, 3, 4);
            decreasePriority.Name = "decreasePriority";
            decreasePriority.Size = new Size(86, 81);
            decreasePriority.TabIndex = 8;
            decreasePriority.Text = "v";
            decreasePriority.UseVisualStyleBackColor = true;
            decreasePriority.Visible = false;
            decreasePriority.Click += decreasePriority_Click;
            // 
            // chosenItem
            // 
            chosenItem.AutoSize = true;
            chosenItem.Location = new Point(442, 277);
            chosenItem.Name = "chosenItem";
            chosenItem.Size = new Size(0, 20);
            chosenItem.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(704, 291);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 10;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // chosen
            // 
            chosen.AutoSize = true;
            chosen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            chosen.Location = new Point(425, 222);
            chosen.Name = "chosen";
            chosen.Size = new Size(79, 31);
            chosen.TabIndex = 11;
            chosen.Text = "label5";
            chosen.Visible = false;
            chosen.Click += label5_Click;
            // 
            // notifyButton
            // 
            notifyButton.Location = new Point(593, 395);
            notifyButton.Name = "notifyButton";
            notifyButton.Size = new Size(94, 29);
            notifyButton.TabIndex = 12;
            notifyButton.Text = "Notify me!";
            notifyButton.UseVisualStyleBackColor = true;
            notifyButton.Visible = false;
            notifyButton.Click += notifyButton_Click;
            // 
            // minuteLabel
            // 
            minuteLabel.AutoSize = true;
            minuteLabel.Location = new Point(442, 322);
            minuteLabel.Name = "minuteLabel";
            minuteLabel.Size = new Size(450, 20);
            minuteLabel.TabIndex = 13;
            minuteLabel.Text = "In how many minutes do you want to be reminded to do this task? ";
            minuteLabel.Visible = false;
            // 
            // textBoxMinutes
            // 
            textBoxMinutes.Location = new Point(573, 349);
            textBoxMinutes.Name = "textBoxMinutes";
            textBoxMinutes.Size = new Size(125, 27);
            textBoxMinutes.TabIndex = 14;
            textBoxMinutes.Visible = false;
            textBoxMinutes.TextChanged += textBoxMinutes_TextChanged;
            textBoxMinutes.KeyDown += textBoxMinutes_KeyDown;
            // 
            // toastNotif
            // 
            toastNotif.Tick += toastNotif_Tick;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(573, 293);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(125, 27);
            textBoxTask.TabIndex = 15;
            textBoxTask.Visible = false;
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            textBoxTask.KeyDown += textBoxTask_KeyDown;
            // 
            // taskQuestion
            // 
            taskQuestion.AutoSize = true;
            taskQuestion.Location = new Point(523, 262);
            taskQuestion.Name = "taskQuestion";
            taskQuestion.Size = new Size(247, 20);
            taskQuestion.TabIndex = 16;
            taskQuestion.Text = "Would you like to add another task?";
            taskQuestion.Visible = false;
            taskQuestion.Click += taskQuestion_Click;
            // 
            // Serpentry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 600);
            Controls.Add(taskQuestion);
            Controls.Add(textBoxTask);
            Controls.Add(textBoxMinutes);
            Controls.Add(minuteLabel);
            Controls.Add(notifyButton);
            Controls.Add(chosen);
            Controls.Add(button2);
            Controls.Add(chosenItem);
            Controls.Add(decreasePriority);
            Controls.Add(addPriority);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Serpentry";
            Text = "Serpentry";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Label label4;
        private ListBox listBox1;
        private Button addPriority;
        private Button decreasePriority;
        private Label chosenItem;
        private Button button2;
        private Label chosen;
        private Button notifyButton;
        private Label minuteLabel;
        private TextBox textBoxMinutes;
        private System.Windows.Forms.Timer toastNotif;
        private TextBox textBoxTask;
        private Label taskQuestion;
    }
}