using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MSBT_Editor.Formsys;
using MSBT_Editor.Sectionsys;
namespace MSBT_Editor.MSBTsys
{


    public class MSBT_Data:objects
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

        

        public static List<string> Txt2_Text_List;
        public static List<string> atr_nulldata;

        //public struct Item
        //{
        //    public byte unknown1;
        //    public byte unknown2;
        //    public byte Dialog_Type;
        //    public byte unknown3;
        //    public short unknown4;
        //    public byte unknown5;
        //    public byte unknown6;
        //    public int null_offset;
        //    public Item(byte arg1, byte arg2, byte arg3, byte arg4, short arg5, byte arg6, byte arg7, int arg8)
        //    {
        //        this.unknown1 = arg1;
        //        this.unknown2 = arg2;
        //        this.Dialog_Type = arg3;
        //        this.unknown3 = arg4;
        //        this.unknown4 = arg5;
        //        this.unknown5 = arg6;
        //        this.unknown6 = arg7;
        //        this.null_offset = arg8;
        //    }
        //}

        public struct Data_List {
            public List<string> Text;
            public List<ATR1.Item> Item;
            public Data_List(List<string> list1, List<ATR1.Item> list2) {
                this.Text = new List<string>();
                this.Item = new List<ATR1.Item>();
                this.Text = list1;
                this.Item = list2;
            }
        }

        public static Data_List MSBT_All_Data;
        //LBL1
        //private static string lbl1;
        //private static int lblsectionsize;
        //private static int lblunknown1;
        //private static int lblunknown2;
        //private static int lblentries;

        public string Magic
        {
            set => magic = value;
            get => magic;
        }
        public Int16 Endian
        {
            set => endian = value;
            get => endian;
        }
        public Int16 Unknown1
        {
            set => unknown1 = value;
            get => unknown1;
        }
        public Int16 Unknown2
        {
            set => unknown2 = value;
            get => unknown2;
        }
        public Int16 Unknown3
        {
            set => unknown3 = value;
            get => unknown3;
        }
        public Int16 Unknown4
        {
            set => unknown4 = value;
            get => unknown4;
        }
        public Int16 Unknown5
        {
            set => unknown5 = value;
            get => unknown5;
        }
        public Int16 Unknown6
        {
            set => unknown6 = value;
            get => unknown6;
        }
        public Int16 Unknown7
        {
            set => unknown7 = value;
            get => unknown7;
        }
        public Int16 Unknown8
        {
            set => unknown8 = value;
            get => unknown8;
        }
        public Int16 Unknown9
        {
            set => unknown9 = value;
            get => unknown9;
        }
        public int File_Size
        {
            set => filesize = value;
            get => filesize;
        }
    }
}
