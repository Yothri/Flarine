using System;
using Ether.Network;
using Ether.Network.Interfaces;
using Ether.Network.Packets;
using Flarine.Core.Util;
using Flarine.Network.Photon.IO;
using Flarine.Network.Photon.IO.Protocol;

namespace Flarine.Network.Photon.Common
{
    public class PhotonConnection : NetUser
    {
        public PhotonConnection()
        {
            SerializationProtocol = new Protocol16();
        }

        public override void HandleMessage(INetPacketStream packet)
        {
            base.HandleMessage(packet);

            var packetIdentifier = packet.Read<byte>();
            if(packetIdentifier == 240)
            {
                // Read Ping
                var ping = packet.Read<int>();

                // Send Pong
                var data = new byte[] { 240, 0, 0, 0, 0, 0, 0, 0, 0 };
                int num = 1;
                Protocol.Serialize(Environment.TickCount, data, ref num);
                Protocol.Serialize(ping, data, ref num);

                using (var pongPacket = new PhotonPacket())
                {
                    pongPacket.Write(data, 0, data.Length);
                    Send(pongPacket);
                }
            }
            else
            {
                var len = packet.Read<int>();
                var channelId = packet.Read<byte>();
                var reliable = packet.Read<byte>();
                var bla = packet.Read<byte>(); // wtf indicates this? that its a TCP packet?
                var bla2 = packet.Read<byte>();
                var msgType = (byte)(bla2 & 127);
                var encrypted = (byte)(bla2 & 128);

                switch(msgType)
                {
                    case 0:
                        using (var initPacket = new PhotonPacket())
                        {
                            var buffer = "fb0000000a0001f30100".ToBytes();
                            initPacket.Write(buffer, 0, buffer.Length);
                            Send(initPacket);
                        }
                        break;
                    case 2:
                        var requestBytes = packet.Read<byte>(packet.Size - (int)packet.Position);
                        using (var streamBuffer = new StreamBuffer(requestBytes))
                        {
                            HandleOperationRequest(SerializationProtocol.DeserializeOperationRequest(streamBuffer));
                        }
                        break;
                    case 6:
                        using (var initPacket = new PhotonPacket())
                        {
                            var buffer = "fb000000750001f3070000002a0001017800000060be04230f95512e8334df9c0ad529ea32090cd99a91e0fd151a0fb1cf2bb450c5b7d78015bddae1dd89eb3f7fd9cdd5366a6e34467f910ac5de6c4a8a9fa8683ff74e463383b2dfb4e833efce367062a50c946d1fa9e88cad3d4ea094daf833c3".ToBytes();
                            initPacket.Write(buffer, 0, buffer.Length);
                            Send(initPacket);
                        }
                        break;
                }
            }
        }

        protected virtual void HandleOperationRequest(OperationRequest request) { }

        protected ProtocolBase SerializationProtocol { get; private set; }
    }
}