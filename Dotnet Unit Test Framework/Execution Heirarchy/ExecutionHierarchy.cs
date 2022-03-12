#region Initializations and Cleanups

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            MessageBox.Show("Assembly Initialization");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            MessageBox.Show("Assembly CleanUp");
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            MessageBox.Show("Class Initialization");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            MessageBox.Show("Class CleanUp");
        }


        [TestInitialize]
        public void TestInit()
        {
            MessageBox.Show("Test Initialization");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            MessageBox.Show("Test CleanUp");
        }

        #endregion