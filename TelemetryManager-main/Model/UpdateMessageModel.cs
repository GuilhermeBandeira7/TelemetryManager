using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelemetryManager.Model
{
    internal class UpdateMessageModel
    {
        public string SerialNumber { get; set; }
        public string Slot { get; set; }
        public string Var { get; set; }
        public List<string> VarList { get; set; } = new List<string>();
        public List<string> TypeList { get; set; } = new List<string> { };
        public List<string> InfoList { get; set; } = new List<string> { };
        public string Type { get; set; }
        public string Info { get; set; }


        public UpdateMessageModel(string serialNumber, string slot)
        {
            SerialNumber = serialNumber;
            Slot = slot;
        }

        public UpdateMessageModel(string serialNumber, string slot, string var, string type, string info)
        {
            SerialNumber = serialNumber;
            Slot = slot;
            Var = var;
            Type = type;
            Info = info;
            VarList.Add(var);
            TypeList.Add(type);
            InfoList.Add(info);
        }
    }
}
