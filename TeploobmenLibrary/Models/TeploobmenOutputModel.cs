namespace TeploobmenLibrary.Models
{
    public class TeploobmenOutputModel
    {
        public List<TableRowModel> RowModels { get; set; } = new List<TableRowModel>();
        public double m { get; set; }
        public double Y0 { get; set; }
        public double Y1 { get; set; }
        public double Y1_DOP { get; set; }
    }
}
