using System;
using System.Collections.Generic;
using TelemetryLibrary;
using TelemetryLibrary.TelemetryStructure;

namespace NewTelemetryManager
{
    public sealed class TelemetryController
    {
        static private TelemetryController? instance = null;
        public bool isAdmin;
        public bool isMaintenance;

        internal TelemetryLib telemetryLib;
        TelemetryController()
        {
            telemetryLib = new TelemetryLib();
        }

        public static TelemetryController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelemetryController();
                }
                return instance;
            }
        }

        /// <summary>
        /// Connects to the Telemetry Library
        /// </summary>
        /// <returns></returns>
        internal bool IsConnected()
        {
            return telemetryLib.IsConnected;
        }
        internal void DisconnectMqtt()
        {
            telemetryLib.DisconnectMqtt();
        }

        internal bool ConnectMqtt(string serverAddress)
        {
            return telemetryLib.ConnectMqtt(serverAddress, MqttClient_ConnectionClosed, BoardToUpdate);
        }

        private void MqttClient_ConnectionClosed(object sender, EventArgs e)
        {
            /*TelemetryManager.Instance.statusDelegate.Invoke(telemetryLib.IsConnected);

            if (telemetryLib.IsConnected)
            {
                telemetryLib.DisconnectMqtt();
            }*/
        }

        private void BoardToUpdate(object sender, UpdateBoardEventArgs e)
        {
            try
            {
                if(TelemetryManager.Instance.DevicesForm != null)
                {
                    TelemetryManager.Instance.DevicesForm.BeginInvoke(TelemetryManager.Instance.DevicesForm.BoardUpdateDelegate, new object[] { e });
                }       
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal bool SubscribeToTopic(string topic)
        {
            return telemetryLib.SubscribeTopic(topic);
        }

        internal Dictionary<string, TelemetryDevice> GetDevices()
        {
            return telemetryLib.telemetryDevices;
        }

        public ushort Query(string serialNumber, ushort board, List<VARIABLES> variables)
        {
            Dictionary<VARIABLES, List<byte>> values = new Dictionary<VARIABLES, List<byte>>();
            foreach (VARIABLES var in variables)
            {
                values.Add(var, new List<byte>(new byte[MessageController.Instance.GetVarSize(var)]));
            }

            return telemetryLib.Publish
               (String.Format("{0}/{1}/update", serialNumber, board),
                   MessageController.Instance.EncodeMessage
                   (MessageController.Instance.CreateMessage
                   (values, telemetryLib.telemetryDevices[serialNumber].dictOfBoards[board].Type, MESSAGE_TYPE.QUERY)));
        }

        public ushort Update(string serialNumber, ushort board, VARIABLES variable, List<byte> data)
        {

            Dictionary<VARIABLES, List<byte>> values = new Dictionary<VARIABLES, List<byte>>
            {
                [variable] = data
            };

            return telemetryLib.Publish
                (String.Format("{0}/{1}/update", serialNumber, board),
                    MessageController.Instance.EncodeMessage
                    (MessageController.Instance.CreateMessage
                    (values, telemetryLib.telemetryDevices[serialNumber].dictOfBoards[board].Type, MESSAGE_TYPE.UPDATE)));
        }

        public ushort Update(string serialNumber, ushort board, Dictionary<VARIABLES, List<byte>> valores)
        {

            return telemetryLib.Publish
                (String.Format("{0}/{1}/update", serialNumber, board),
                    MessageController.Instance.EncodeMessage
                    (MessageController.Instance.CreateMessage
                    (valores, telemetryLib.telemetryDevices[serialNumber].dictOfBoards[board].Type, MESSAGE_TYPE.UPDATE)));
        }

        public void Clear()
        {
            telemetryLib.Clear();
        }

        public enum State
        {
            Desconectado,
            Conectando,
            Conectado,
            ST_OK,
            SN_CHECK,
            Comunicando,
            Desconectando,
        }
    }
}
