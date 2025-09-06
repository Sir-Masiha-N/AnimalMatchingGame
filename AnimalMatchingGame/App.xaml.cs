namespace AnimalMatchingGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new Window(new AppShell());
            const int newWidth = 500;
            const int newHeight = 700;
            window.X = 500;
            window.Y = 80;
            window.Width = newWidth;
            window.Height = newHeight;
            return window;
        }
    }
}