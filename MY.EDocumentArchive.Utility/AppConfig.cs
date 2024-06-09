using System;

namespace MY
{
    static public class AppConfig
    {
        static public ServiceFactoryConfig ServiceFactoryConfig { get; set; }

        static public Action<string> ShowErrorMessage;
    }
}
