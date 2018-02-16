﻿using System.Collections.Generic;
using Flarine.Network.Photon.IO.Protocol;

namespace Flarine.Network.Photon.IO
{
    public abstract class ProtocolBase
    {
        internal abstract string protocolType { get; }

        internal abstract byte[] VersionBytes { get; }

        public abstract void Serialize(StreamBuffer dout, object serObject, bool setType);

        public abstract void SerializeShort(StreamBuffer dout, short serObject, bool setType);

        public abstract void SerializeString(StreamBuffer dout, string serObject, bool setType);

        public abstract void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType);

        public abstract void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType);

        public abstract void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType);

        public abstract object Deserialize(StreamBuffer din, byte type);

        public abstract short DeserializeShort(StreamBuffer din);

        public abstract byte DeserializeByte(StreamBuffer din);

        public abstract EventData DeserializeEventData(StreamBuffer din);

        public abstract OperationRequest DeserializeOperationRequest(StreamBuffer din);

        public abstract OperationResponse DeserializeOperationResponse(StreamBuffer stream);

        public byte[] Serialize(object obj)
        {
            StreamBuffer streamBuffer = new StreamBuffer(64);
            this.Serialize(streamBuffer, obj, true);
            return streamBuffer.ToArray();
        }

        public object Deserialize(byte[] serializedData)
        {
            StreamBuffer streamBuffer = new StreamBuffer(serializedData);
            return this.Deserialize(streamBuffer, (byte)streamBuffer.ReadByte());
        }

        public object DeserializeMessage(StreamBuffer stream)
        {
            return this.Deserialize(stream, (byte)stream.ReadByte());
        }

        internal byte[] DeserializeRawMessage(StreamBuffer stream)
        {
            return (byte[])this.Deserialize(stream, (byte)stream.ReadByte());
        }

        internal void SerializeMessage(StreamBuffer ms, object msg)
        {
            this.Serialize(ms, msg, true);
        }

        protected ProtocolBase()
        {
        }
    }
}