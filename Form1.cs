using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private bool stopLoop = false;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)//Start Button
        {
            stopLoop = false;
            cpsLabel.Text = 0.ToString();

            iterationsLabel.Text = 0.ToString();
            await Task.Delay(5000);//wait 5 seconds before clicking
            int speedSec = int.Parse(secondsBox.Text);
            int speedMil = int.Parse(millisecondsBox.Text);
            if (speedSec == 0 && speedMil == 0)
            { }
            else
            {
                if (rightCheck.Checked == true)
                {
                    if (infinityIt.Checked == true)
                    {
                        for (int i = 0; i != -1 && !stopLoop; i++)
                        {
                            iterationsLabel.Text = i.ToString();
                            if (Control.ModifierKeys == Keys.Alt)//it should stop now
                                break;
                            DoRightMouseClick();
                            await Task.Delay((speedSec * 1000) + speedMil);
                        }
                        return;
                    }
                    for (int i = 0; i != int.Parse(iterations.Text) && !stopLoop; i++)
                    {
                        iterationsLabel.Text = i.ToString();
                        if (Control.ModifierKeys == Keys.Alt)//it should stop now
                            break;
                        DoRightMouseClick();
                        await Task.Delay((speedSec * 1000) + speedMil);

                    }
                }
                if (leftCheck.Checked == true)
                {
                    if (infinityIt.Checked == true)
                    {
                        for (int i = 0; i != -1 && !stopLoop; i++)
                        {
                            iterationsLabel.Text = i.ToString();
                            if (Control.ModifierKeys == Keys.Alt)//it should stop now
                                break;
                            DoLeftMouseClick();
                            await Task.Delay((speedSec * 1000) + speedMil);
                        }
                        return;
                    }
                    for (int i = 0; i != int.Parse(iterations.Text) && !stopLoop; i++)
                    {
                        iterationsLabel.Text = i.ToString();
                        if (Control.ModifierKeys == Keys.Alt)//it should stop now
                            break;
                        DoLeftMouseClick();
                        await Task.Delay((speedSec * 1000) + speedMil);
                    }
                }
            }
            cpsLabel.Text = 0.ToString();
        }

        public void DoLeftMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        public void DoRightMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)//Clicks per second Button
        {
            int x = int.Parse(cpsLabel.Text);
            x++;
            cpsLabel.Text = x.ToString();
        }

        private void leftCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (leftCheck.Checked == true)
                rightCheck.Checked = false;
        }

        private void rightCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rightCheck.Checked == true)
                leftCheck.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopLoop = true;
        }

        private void iterations_TextChanged(object sender, EventArgs e)
        {
            resetToZero(iterations);
        }
        private void secondsBox_TextChanged(object sender, EventArgs e)
        {
            resetToZero(secondsBox);
        }
        private void millisecondsBox_TextChanged(object sender, EventArgs e)
        {
            resetToZero(millisecondsBox);
        }

        private void resetToZero(TextBox x)
        {
            if (x.Text == "")
            {
                x.Text = "0";
            }
        }
    }    
}
