namespace hw_25._05__Running_button_
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
            button1.MouseMove += new MouseEventHandler(OnMouseMoveButton);
        }

        protected override void OnMouseMove(MouseEventArgs arguments)
        {
            Text = String.Format("X = {0} Y = {1}", arguments.X, arguments.Y);
        }

        private void OnMouseMoveButton(Object sender, MouseEventArgs arguments)
        {

            var button = sender as Button;
            Point currentPos = button.Location;
            currentPos.X = ran.Next(Width - button.Width*2);
            currentPos.Y = ran.Next(Height - button.Height*2);
            button.Location = currentPos;
        }
    }
}