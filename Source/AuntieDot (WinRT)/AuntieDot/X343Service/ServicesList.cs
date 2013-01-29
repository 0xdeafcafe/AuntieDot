using System.Collections.Generic;

namespace AuntieDot.X343Service
{
    public class ServicesList
    {
        public const string ServicesListUrl = "https://settings.svc.halowaypoint.com/RegisterClientService.svc/register/webapp/AE5D20DCFA0347B1BCE0A5253D116752";

        public Dictionary<string, string> ServiceList { get; set; }
        public Dictionary<string, string> Settings { get; set; }
    }
}
