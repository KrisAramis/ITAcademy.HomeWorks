using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;

namespace Core.Logger
{
    public class Logger
    {
        public static readonly Logger Instance = new Logger();
        private readonly ILog _log;

        private Logger()
        {
            var log4NetConfig = new XmlDocument();
            log4NetConfig.Load(File.OpenRead("log4net.config"));
            var repo = LogManager.CreateRepository(typeof(Logger).Assembly, typeof(Hierarchy));
            XmlConfigurator.Configure(repo, log4NetConfig["log4net"]);
            _log = LogManager.GetLogger(GetType());
        }
    }   
}