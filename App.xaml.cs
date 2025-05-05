using jcevallos_T1A.Views;

namespace jcevallos_T1A
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new vPrincipal());
        }
    }
}