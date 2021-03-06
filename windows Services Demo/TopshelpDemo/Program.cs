﻿using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Topshelf;

namespace TopshelpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            //XmlConfigurator.ConfigureAndWatch(logCfg);

            //HostFactory.Run(x =>
            //{
            //    x.Service<TownCrier>(s =>
            //    {
            //        s.ConstructUsing(name => new TownCrier());
            //        s.WhenStarted(tc => tc.Start());
            //        s.WhenStopped(tc => tc.Stop());
            //    });
            //    x.RunAsLocalSystem();

            //    x.SetDescription("TopshelpDemo Description");
            //    x.SetDisplayName("TopshelpDemo DisplayName");
            //    x.SetServiceName("TopshelpDemo ServiceName");
            //});

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            HostFactory.Run(x =>
            {
                x.UseLog4Net();

                x.Service<ServiceRunner>();

                x.SetDescription("QuartzDemo Description");
                x.SetDisplayName("QuartzDemo DisplayName");
                x.SetServiceName("QuartzDemo ServiceName");

                //x.EnablePauseAndContinue();
            });
        }
    }

    public class TownCrier
    {
        private Timer _timer = null;
        readonly ILog _log = LogManager.GetLogger(typeof(Program));

        public TownCrier()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) => _log.Info(DateTime.Now);
        }
        public void Start() { _timer.Start(); }
        public void Stop() { _timer.Stop(); }
    }

}
