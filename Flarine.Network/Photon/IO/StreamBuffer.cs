using System;
using System.IO;

namespace Flarine.Network.Photon.IO
{
    public class StreamBuffer : Stream
    {
        public StreamBuffer(int size = 0)
        {
            this.buf = new byte[size];
        }

        public StreamBuffer(byte[] buf)
        {
            this.buf = buf;
            this.len = buf.Length;
        }

        public byte[] ToArray()
        {
            byte[] array = new byte[this.len];
            Buffer.BlockCopy(this.buf, 0, array, 0, this.len);
            return array;
        }

        public byte[] GetBuffer()
        {
            return this.buf;
        }

        public byte[] GetBufferAndAdvance(int length, out int offset)
        {
            offset = (int)this.Position;
            this.Position += (long)length;
            return this.buf;
        }

        public override bool CanRead
        {
            get
            {
                return true;
            }
        }

        public override bool CanSeek
        {
            get
            {
                return true;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        public override long Length
        {
            get
            {
                return (long)this.len;
            }
        }

        public override long Position
        {
            get
            {
                return (long)this.pos;
            }
            set
            {
                this.pos = (int)value;
                bool flag = this.len < this.pos;
                if (flag)
                {
                    this.len = this.pos;
                    this.CheckSize(this.len);
                }
            }
        }

        public override void Flush()
        {
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            int num;
            switch (origin)
            {
                case SeekOrigin.Begin:
                    num = (int)offset;
                    break;
                case SeekOrigin.Current:
                    num = this.pos + (int)offset;
                    break;
                case SeekOrigin.End:
                    num = this.len + (int)offset;
                    break;
                default:
                    throw new ArgumentException("Invalid seek origin");
            }
            bool flag = num < 0;
            if (flag)
            {
                throw new ArgumentException("Seek before begin");
            }
            bool flag2 = num >= this.len;
            if (flag2)
            {
                throw new ArgumentException("Seek after end");
            }
            this.pos = num;
            return (long)this.pos;
        }

        public override void SetLength(long value)
        {
            this.len = (int)value;
            this.CheckSize(this.len);
            bool flag = this.pos < this.len;
            if (flag)
            {
                this.pos = this.len;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int num = this.len - this.pos;
            bool flag = num <= 0;
            int result;
            if (flag)
            {
                result = 0;
            }
            else
            {
                bool flag2 = count > num;
                if (flag2)
                {
                    count = num;
                }
                Buffer.BlockCopy(this.buf, this.pos, buffer, offset, count);
                this.pos += count;
                result = count;
            }
            return result;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            int num = this.pos + count;
            this.CheckSize(num);
            bool flag = num > this.len;
            if (flag)
            {
                this.len = num;
            }
            Buffer.BlockCopy(buffer, offset, this.buf, this.pos, count);
            this.pos = num;
        }

        public override int ReadByte()
        {
            bool flag = this.pos >= this.len;
            int result;
            if (flag)
            {
                result = -1;
            }
            else
            {
                byte[] array = this.buf;
                int num = this.pos;
                this.pos = num + 1;
                result = array[num];
            }
            return result;
        }

        public override void WriteByte(byte value)
        {
            bool flag = this.pos >= this.len;
            if (flag)
            {
                this.len = this.pos + 1;
                this.CheckSize(this.len);
            }
            byte[] array = this.buf;
            int num = this.pos;
            this.pos = num + 1;
            array[num] = value;
        }

        public void WriteBytes(byte v0, byte v1)
        {
            int num = this.pos + 2;
            bool flag = this.len < num;
            if (flag)
            {
                this.len = num;
                this.CheckSize(this.len);
            }
            byte[] array = this.buf;
            int num2 = this.pos;
            this.pos = num2 + 1;
            array[num2] = v0;
            byte[] array2 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array2[num2] = v1;
        }

        public void WriteBytes(byte v0, byte v1, byte v2)
        {
            int num = this.pos + 3;
            bool flag = this.len < num;
            if (flag)
            {
                this.len = num;
                this.CheckSize(this.len);
            }
            byte[] array = this.buf;
            int num2 = this.pos;
            this.pos = num2 + 1;
            array[num2] = v0;
            byte[] array2 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array2[num2] = v1;
            byte[] array3 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array3[num2] = v2;
        }

        public void WriteBytes(byte v0, byte v1, byte v2, byte v3)
        {
            int num = this.pos + 4;
            bool flag = this.len < num;
            if (flag)
            {
                this.len = num;
                this.CheckSize(this.len);
            }
            byte[] array = this.buf;
            int num2 = this.pos;
            this.pos = num2 + 1;
            array[num2] = v0;
            byte[] array2 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array2[num2] = v1;
            byte[] array3 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array3[num2] = v2;
            byte[] array4 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array4[num2] = v3;
        }

        public void WriteBytes(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7)
        {
            int num = this.pos + 8;
            bool flag = this.len < num;
            if (flag)
            {
                this.len = num;
                this.CheckSize(this.len);
            }
            byte[] array = this.buf;
            int num2 = this.pos;
            this.pos = num2 + 1;
            array[num2] = v0;
            byte[] array2 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array2[num2] = v1;
            byte[] array3 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array3[num2] = v2;
            byte[] array4 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array4[num2] = v3;
            byte[] array5 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array5[num2] = v4;
            byte[] array6 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array6[num2] = v5;
            byte[] array7 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array7[num2] = v6;
            byte[] array8 = this.buf;
            num2 = this.pos;
            this.pos = num2 + 1;
            array8[num2] = v7;
        }

        private bool CheckSize(int size)
        {
            bool flag = size <= this.buf.Length;
            bool result;
            if (flag)
            {
                result = false;
            }
            else
            {
                int num = this.buf.Length;
                bool flag2 = num == 0;
                if (flag2)
                {
                    num = 1;
                }
                while (size > num)
                {
                    num *= 2;
                }
                byte[] dst = new byte[num];
                Buffer.BlockCopy(this.buf, 0, dst, 0, this.buf.Length);
                this.buf = dst;
                result = true;
            }
            return result;
        }

        private const int DefaultInitialSize = 0;

        private int pos;

        private int len;

        private byte[] buf;
    }
}