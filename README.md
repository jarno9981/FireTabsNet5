# FireTabsNet5
FireTabs Based On .Net5


#Program.cs

using firetabs;

static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container container = new Container();

            // Add the initial Tab
            container.Tabs.Add(
                // Our First Tab created by default in the Application will have as content the Form1
                new FireTitleTab(container)
                {
                    Content = new Browser
                    {
                        Text = "Fire Browser"
                    }
                }
            );

            // Set initial tab the first one
            container.SelectedTabIndex = 0;

            // Create tabs and start application
            FireTitleApplicationContext applicationContext = new FireTitleApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
        
#first form

using firetabs;

 public partial class Container : FireTitle
    {
        public Container()
        {
            InitializeComponent();
            TabRenderer = new FireTabRenderer(this);
        }

        public override FireTitleTab CreateTab()
        {
            return new FireTitleTab(this)
            {
                Content = new Browser
                {
                    Text = "Fire Browser"
                }
            };
        }
    }
    
#second form

using firetabs;

 public Browser()
        {
            InitializeComponent();
        }

        protected FireTitle ParentTabs
        {
            get
            {
                return (ParentForm as FireTitle);
            }
        }
