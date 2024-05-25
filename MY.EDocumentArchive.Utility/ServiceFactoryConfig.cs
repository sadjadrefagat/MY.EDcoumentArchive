namespace MY
{
    sealed public class ServiceFactoryConfig
    {
        readonly private ApplicationConfig applicationConfig;

        public ServiceFactoryConfig(ApplicationConfig appConfig)
        {
            applicationConfig = appConfig;
        }

        public ApplicationConfig ApplicationConfig
        {
            get { return applicationConfig; }
        }

        public bool AutoCommitTransactions { get; set; } = false;
    }
}
