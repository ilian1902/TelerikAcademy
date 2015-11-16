namespace StringConcat
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlTypes;
    using System.IO;
    using Microsoft.SqlServer.Server;

    [Serializable]
    [SqlUserDefinedAggregate(
       Format.UserDefined,
       IsInvariantToDuplicates = false,
       IsInvariantToNulls = false,
       IsInvariantToOrder = true,
       IsNullIfEmpty = true,
       MaxByteSize = -1,
       Name = "StrConcat"
    )]


    public struct StringConcat : IBinarySerialize
    {
        private List<string> list;
        public void Init()
        {
            this.list = new List<string>();
        }
        public void Accumulate(SqlString value)
        {
            if (!string.IsNullOrEmpty(value.Value))
            {
                this.list.Add(value.Value);
            }
        }
        public void Merge(StringConcat group)
        {
            this.list.AddRange(group.list);
        }

        public SqlString Terminate()
        {
            if (this.list.Count > 0)
            {
                string returnString = string.Join(", ", this.list);
                return new SqlString(returnString);
            }
            return null;
        }

        public void Read(BinaryReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentException("Reader is null");
            }
            this.list = new List<string>() { reader.ReadString() };
        }

        public void Write(BinaryWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentException("Writer is null");
            }
            writer.Write(string.Join(", ", this.list));
        }
    }
}
