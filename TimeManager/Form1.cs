using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using Microsoft.Toolkit.Uwp.Notifications;

namespace TimeManager
{

    public partial class Serpentry : Form
    {
        int minutes;
        List<string> choice = new List<string>(); //the queue of items the user wants to be reminded of
        public Serpentry()
        {
            InitializeComponent();

            toastNotif.Interval = 60000; //60000 milliseconds equals one minute
            toastNotif.Tick += toastNotif_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //Switches the form style
        {

            button1.Hide();

            label3.Hide();

            label4.Hide();

            textBox1.Hide();

            listBox1.Show();
            addPriority.Show();
            decreasePriority.Show();
            minuteLabel.Show();
            textBoxMinutes.Show();
            notifyButton.Show();
            textBoxTask.Show();
            taskQuestion.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosen.Show();
            chosen.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e) //Increases item's position in the list
        {
            ChangePriority(-1);
        }

        public void ChangePriority(int num)
        {
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return;

            int newIndex = listBox1.SelectedIndex + num;

            if (newIndex < 0 || newIndex >= listBox1.Items.Count)
                return;

            object selected = listBox1.SelectedItem;

            listBox1.Items.Remove(selected);

            listBox1.Items.Insert(newIndex, selected);

            listBox1.SetSelected(newIndex, true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick(); //a way to add using the enter key
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.AcceptButton = this.button2;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
                listBox1.Items.Add(textBox1.Text);

            else listBox1.Items.Add(textBoxTask.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void decreasePriority_Click(object sender, EventArgs e) //Decreases the items position in the list
        {
            ChangePriority(1);
        }



        public void notifyButton_Click(object sender, EventArgs e)
        {

            minutes = Int32.Parse(textBoxMinutes.Text);
            choice.Add(listBox1.GetItemText(listBox1.SelectedItem));

            toastNotif.Interval = minutes * 60000;
            toastNotif.Start();


        }

        private void textBoxMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                notifyButton.PerformClick();
            }
        }

        int ListIndex = 0;
        private void toastNotif_Tick(object sender, EventArgs e)
        {
            if (ListIndex < choice.Count)
            {
                // New simplified API - Just call Show
                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Reminder from Serpentry")
                    .AddText(choice[ListIndex])
                    .Show();
                //Shows toast notification on your computer!
                ListIndex++;
            }
            else
            {
                // Reset ListIndex when it exceeds the range of choice
                ListIndex = 0;
            }
        }

        private void taskQuestion_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }
    }
}

