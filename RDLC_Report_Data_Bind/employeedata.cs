namespace RDLC_Report_Data_Bind
{
    
    public class employeedata
    {
        //[StringLength(30)]
        public string Name { get; set; }

        public int? age { get; set; }

        //[StringLength(20)]
        public string town { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
    }
}
