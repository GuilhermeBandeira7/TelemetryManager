using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TelemetryLibrary.TelemetryStructure
{
    public class TelemetryDevice
    {
        protected string serialNumber;
        protected EventHandler<UpdateBoardEventArgs> updateBoardEventMethod;

        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
        }
        public Dictionary<ushort, Board> dictOfBoards = new Dictionary<ushort, Board>();

        protected TelemetryDevice()
        {

        }
        public TelemetryDevice(string serialNumber, EventHandler<UpdateBoardEventArgs> updateBoardEventMethod)
        {
            this.serialNumber = serialNumber;
            this.updateBoardEventMethod = updateBoardEventMethod;
        }

        public void MessageTriage(string topic, byte[] message)
        {
            if (ushort.TryParse(topic.Split('/')[1], out ushort id))
            {
                if (!dictOfBoards.ContainsKey(id))
                {
                    Board board = new Board(serialNumber, updateBoardEventMethod);
                    dictOfBoards.Add(id, board);

                }
                dictOfBoards[id].DecodeMessage(message);
            }
        }
        public void Clear()
        {
            foreach(Board board in dictOfBoards.Values)
            {
                board.Clear();

            }
            dictOfBoards.Clear();
        }
    }
}
