using TelemetryLibrary.TelemetryStructure;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static uPLibrary.Networking.M2Mqtt.MqttClient;

namespace TelemetryLibrary
{
    public class TelemetryLib
    {
        MqttClient mqttClient;
        public Dictionary<string, TelemetryDevice> telemetryDevices = new Dictionary<string, TelemetryDevice>();
        private EventHandler<UpdateBoardEventArgs> updateBoardEventMethod;

        public bool IsConnected
        {
            get
            {
                if (mqttClient != null)
                {
                    return mqttClient.IsConnected;
                }
                else
                {
                    return false;
                }
            }
        }

        public TelemetryLib()
        {

        }

        public void DisconnectMqtt()
        {
            try
            {
                if (mqttClient != null)
                {
                    if (mqttClient.IsConnected)
                    {
                        mqttClient.Disconnect();
                    }
                }
            }
            catch { }
        }



        public bool ConnectMqtt(string serverAddress, ConnectionClosedEventHandler connectionClosedEventHandler, EventHandler<UpdateBoardEventArgs> updateBoardEventMethod)
        {
            this.updateBoardEventMethod = updateBoardEventMethod;
            bool status = ConnectMqtt(serverAddress);
            mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            return status;
        }

        public bool ConnectMqtt(string serverAddress, ConnectionClosedEventHandler connectionClosedEventHandler, EventHandler<UpdateBoardEventArgs> updateBoardEventMethod, MqttMsgPublishEventHandler mqttMessageReceived)
        {
            this.updateBoardEventMethod = updateBoardEventMethod;
            bool status = ConnectMqtt(serverAddress);
            mqttClient.MqttMsgPublishReceived += mqttMessageReceived;
            return status;
        }

        public bool ConnectMqtt(string serverAddress)
        {
            mqttClient = new MqttClient(serverAddress);
            mqttClient.Connect(Guid.NewGuid().ToString());
            if (mqttClient.IsConnected)
            {
                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                return true;
            }
            return false;
        }



        public bool SubscribeTopic(string topic)
        {
            if (mqttClient != null)
            {
                if (mqttClient.IsConnected)
                {
                    mqttClient.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                    return true;
                }
            }
            return false;
        }



        public void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                if (!e.Topic.Contains("/update"))
                {
                    string sn = e.Topic.Substring(0, 7);
                    if (!telemetryDevices.ContainsKey(sn))
                    {
                        telemetryDevices.Add(sn, new TelemetryDevice(sn, updateBoardEventMethod));
                    }
                    telemetryDevices[sn].MessageTriage(e.Topic, e.Message);
                }
            }
            catch
            {

            }
        }

        public ushort Publish(string topic, byte[] message)
        {
            if (mqttClient != null)
            {
                if (mqttClient.IsConnected)
                {
                    return mqttClient.Publish(topic, message);
                }
            }
            return 0;
        }

        public void Clear()
        {
            foreach (TelemetryDevice telemetryDevice in telemetryDevices.Values)
            {
                telemetryDevice.Clear();
            }
            telemetryDevices.Clear();
        }

    }
}