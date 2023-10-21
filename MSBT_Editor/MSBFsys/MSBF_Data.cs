using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSBT_Editor.Formsys;

namespace MSBT_Editor.MSBFsys
{
    public class MSBF_Data : Objects
    {
        //MSBTヘッダー
        private static string magic;
        private static Int16 endian;
        private static Int16 unknown1;
        private static Int16 unknown2;
        private static Int16 unknown3;
        private static Int16 unknown4;
        private static int filesize;
        private static Int16 unknown5;
        private static Int16 unknown6;
        private static Int16 unknown7;
        private static Int16 unknown8;
        private static Int16 unknown9;

        public string Magic
        {
            set
            {
                if (value == "MsgFlwBn")
                {
                    magic = value;
                }
                else
                {
                    magic = value;
                }
            }
            get { return magic; }
        }

        public Int16 Endian
        {
            set { endian = value; }
            get { return endian; }
        }

        public Int16 Unknown1
        {
            set { unknown1 = value; }
            get { return unknown1; }
        }

        public Int16 Unknown2
        {
            set { unknown2 = value; }
            get { return unknown2; }
        }

        public Int16 Unknown3
        {
            set { unknown3 = value; }
            get { return unknown3; }
        }

        public Int16 Unknown4
        {
            set { unknown4 = value; }
            get { return unknown4; }
        }

        public Int16 Unknown5
        {
            set { unknown5 = value; }
            get { return unknown5; }
        }

        public Int16 Unknown6
        {
            set { unknown6 = value; }
            get { return unknown6; }
        }

        public Int16 Unknown7
        {
            set { unknown7 = value; }
            get { return unknown7; }
        }

        public Int16 Unknown8
        {
            set { unknown8 = value; }
            get { return unknown8; }
        }

        public Int16 Unknown9
        {
            set { unknown9 = value; }
            get { return unknown9; }
        }

        public int File_Size
        {
            set { filesize = value; }
            get { return filesize; }
        }
    }
}
