using System.Security.AccessControl;

namespace E_Voting_System
{
    public partial class Form1 : Form
    {
        private int maxSizeIncrease = 20;
        private int step = 5;

        private Size originalSizeS, originalSizeA;
        private Point originalLocationS, originalLocationA;

        private Button activeButton = null;
        public Form1()
        {
            InitializeComponent();

            originalSizeS = btnStudent.Size;
            originalLocationS = btnStudent.Location;

            originalSizeA = btnAdmin.Size;
            originalLocationA = btnAdmin.Location;

            btnStudent.MouseEnter += Button_MouseEnter;
            btnStudent.MouseLeave += Button_MouseLeave;
            btnAdmin.MouseEnter += Button_MouseEnter;
            btnAdmin.MouseLeave += Button_MouseLeave;

            Timer.Tick += Timer_Tick;

            Timer.Interval = 10;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            activeButton = sender as Button;
            Timer.Start();
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            activeButton = sender as Button;
            Timer.Start();
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (activeButton == null)
                return;

                Size originalSize = (activeButton == btnStudent) ? originalSizeS : originalSizeA;
                Point originalLocation = (activeButton == btnStudent) ? originalLocationS : originalLocationA;

            if (activeButton.Bounds.Contains(activeButton.Parent.PointToClient(Cursor.Position)))
            {
                if (activeButton.Width < originalSize.Width + maxSizeIncrease)
                {
                    activeButton.Size = new Size(activeButton.Width + step, activeButton.Height + step);
                    activeButton.Location = new Point(activeButton.Location.X - step / 2, activeButton.Location.Y - step / 2);
                }
                else
                {
                    Timer.Stop();
                }
            }

            else
            {
                if (activeButton.Width > originalSize.Width)
                {
                    activeButton.Size = new Size(activeButton.Width - step, activeButton.Height - step);
                    activeButton.Location = new Point(activeButton.Location.X + step / 2, activeButton.Location.Y + step / 2);
                }
                else
                {
                    activeButton.Size = originalSize;
                    activeButton.Location = originalLocation;
                    Timer.Stop();
                }
            }
        }
    }
}
