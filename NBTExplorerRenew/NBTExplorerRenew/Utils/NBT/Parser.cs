

using System.Collections.Generic;

namespace NBTExplorerRenew.Utils.NBT
{
    internal class Parser
    {
        private readonly byte[] Data;
        private int i = 0;

        public Parser(byte[] data)
        {
            Data = data;
        }

        public Tag[] Parse()
        {
            List<Tag> tags = [];

            for (i = 0; i < Data.Length; i++)
            {
                Tag currentTag = new((TagTypes)Data[i]);

                switch (currentTag.Type)
                {
                    case (TagTypes.TAG_End):
                        break;
                    case (TagTypes.TAG_Byte):
                        currentTag.Payload = this.ParseInt(1);
                        break;
                    case (TagTypes.TAG_Short):
                        currentTag.Payload = this.ParseInt(2);
                        break;
                    case (TagTypes.TAG_Int):
                        currentTag.Payload = this.ParseInt(4);
                        break;
                    case (TagTypes.TAG_Long):
                        currentTag.Payload = this.ParseInt(8);
                        break;
                    case (TagTypes.TAG_Float):
                        break;
                    case (TagTypes.TAG_Double):
                        break;
                    case (TagTypes.TAG_ByteArray):
                        break;
                    case (TagTypes.TAG_String):
                        break;
                    case (TagTypes.TAG_List):
                        break;
                    case (TagTypes.TAG_Compound):
                        break;
                    case (TagTypes.TAG_IntArray):
                        break;
                    case (TagTypes.TAG_LongArray):
                        break;
                }

                tags.Add(currentTag);
            }

            return [.. tags];
        }

        private object ParseInt(int size)
        {
            long parsedInt = 0;

            for (int j = 0; j < size; j++)
            {
                parsedInt += Data[j] << j * 8;
                i++;
            }

            return parsedInt;
        }
    }
}
