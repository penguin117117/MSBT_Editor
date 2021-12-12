namespace MSBT_Editor.MSBX
{
    public interface IMSBX_Data
    {
        short Endian { get; set; }
        int File_Size { get; set; }
        string Magic { get; set; }
        short Unknown1 { get; set; }
        short Unknown2 { get; set; }
        short Unknown3 { get; set; }
        short Unknown4 { get; set; }
        short Unknown5 { get; set; }
        short Unknown6 { get; set; }
        short Unknown7 { get; set; }
        short Unknown8 { get; set; }
        short Unknown9 { get; set; }
    }
}