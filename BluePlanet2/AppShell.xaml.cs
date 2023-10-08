namespace BluePlanet2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();

        }
        void RegisterRoutes()
        {
            Routing.RegisterRoute("giantclam", typeof(view.giantclam));
            Routing.RegisterRoute("fire", typeof(view.fire));
            Routing.RegisterRoute("braincoral", typeof(view.braincoral));
            Routing.RegisterRoute("staghorncora", typeof(view.staghorncora));
            Routing.RegisterRoute("elkhorncoral", typeof(view.elkhorncoral));
            Routing.RegisterRoute("whaleshark", typeof(view.whaleshark));
            Routing.RegisterRoute("giantmantaray", typeof(view.giantmantaray));
            Routing.RegisterRoute("Napoleon", typeof(view.Napoleon));
            Routing.RegisterRoute("dugong", typeof(view.dugong));
            Routing.RegisterRoute("leatherbackseaturtle", typeof(view.leatherbackseaturtle));
            Routing.RegisterRoute("hawksbillseaturtle", typeof(view.hawksbillseaturtle));
            Routing.RegisterRoute("MainPage", typeof(view.emamainpage));

        }

    }
}