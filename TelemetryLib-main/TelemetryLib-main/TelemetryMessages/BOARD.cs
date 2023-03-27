using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelemetryLibrary.TelemetryStructure
{
    public class Board
    {
        private static long objectCounter = 0;
        private long uniqueId;
        public long UniqueId
        {
            get { return uniqueId; }
        }
        private BOARDS type = BOARDS.EMPTY;
        private ushort version = 0;
        public BOARDS Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                }
            }
        }

        public ushort Version
        {
            get { return version; }
            set
            {
                if (version != value)
                {
                    version = value;
                }
            }
        }

        private void UpdateEvent(VARIABLES var, List<byte> data)
        {
            UpdateBoardEventArgs args = new UpdateBoardEventArgs();
            args.board = this;
            args.variable = var;
            args.data = data;
            OnUpdateAvailableEventArgs(args);
        }

        public Dictionary<VARIABLES, List<byte>> Variables { get; private set; }
        private string serialNumber;
        public string SerialNumber { get { return serialNumber; } }




        public Board(string serialNumber, EventHandler<UpdateBoardEventArgs> updateBoardEventMethod)
        {
            Variables = new Dictionary<VARIABLES, List<byte>>();
            this.serialNumber = serialNumber;
            BoardToUpdate += updateBoardEventMethod;
            uniqueId = objectCounter;
            objectCounter++;
            BoardToUpdate += updateBoardEventMethod;
        }


        /*public void AddValueToVariable(VARIABLES variable, List<byte> data)
        {

            if (Variables.ContainsKey(variable))
            {
                Variables[variable] = data;
            }
            else
            {
                Variables.Add(variable, data);
            }

        }*/

        public List<byte> ReadVariable(VARIABLES var)
        {
            if (!Variables.ContainsKey(var))
            {
                return null;
            }
            else
            {
                return Variables[var];
            }
        }

        public void UpdateVariable(VARIABLES var, List<byte> value)
        {
            if (!Variables.ContainsKey(var))
            {
                Variables.Add(var, value);
                UpdateEvent(var, value);
            }
            else
            {
                if (!Variables[var].SequenceEqual(value))
                {
                    //value.Reverse();
                    Variables[var] = value;
                    UpdateEvent(var, value);
                }
            }
        }

        public void DecodeMessage(byte[] message)
        {
            if (message.Length > 7)
            {
                try
                {
                    List<byte> myBytes = new List<byte>(message);
                    MessageModel mm = MessageController.Instance.DecodeMessage(myBytes);
                    Type = (BOARDS)mm.id;
                    Version = mm.version;
                    if (mm.sizeOfData > 0)
                    {
                        foreach (VARIABLES variable in mm.message.Keys)
                        {
                            UpdateVariable(variable, mm.message[variable]);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        protected virtual void OnUpdateAvailableEventArgs(UpdateBoardEventArgs e)
        {
            EventHandler<UpdateBoardEventArgs> handler = BoardToUpdate;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void Clear()
        {
            Variables.Clear();
        }


        public event EventHandler<UpdateBoardEventArgs> BoardToUpdate;
    }

    public class UpdateBoardEventArgs : EventArgs
    {
        public Board board { get; set; }
        public VARIABLES variable { get; set; }
        public List<byte> data { get; set; }
    }

    public enum BOARDS
    {
        CPU,
        ETH,
        EB,
        AC,
        AU,
        SB,
        EMPTY = 254
    }

}
