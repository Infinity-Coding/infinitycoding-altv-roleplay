using System;
using AltV.Net;

namespace Backend
{
    public class Main : Resource
    {
        public override void OnStart()
        {
            Alt.Log("Started");
        }

        public override void OnStop()
        {
            Alt.Log("Stopped");
        }
    }
}