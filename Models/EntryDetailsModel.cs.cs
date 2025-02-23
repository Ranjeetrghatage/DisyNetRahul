namespace DisynetSoftware.Models
{
    public class DisynetDataModel
    {
        public int Id { get; set; }
        public string ObjectType { get; set; }
        public string ObjectName { get; set; }
        public string ErrorDescription { get; set; }
        public string SerialNumber { get; set; }
        public string ModelNo { get; set; }
        public string Capacity { get; set; }
        public string InputResistance { get; set; }
        public string OutputResistance { get; set; }
        public string ExcitationVoltage { get; set; }
        public string InitialUnbalance { get; set; }
        public string LoadingDevice { get; set; }
        public string Sensitivity { get; set; }
        public string IndicatorReference { get; set; }
        public string MaxNonlinearity { get; set; }
     
        public float? XiAvg { get; set; }
        public float? YiAvg { get; set; }
        public string RealError { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public string BlankNo { get; set; }
        public float? Tonnes { get; set; }
        public string SensorRange { get; set; }
        public string Remark { get; set; }
        public string JobOrder { get; set; }
        public string Customer { get; set; }
        public string VerifiedBy { get; set; }
        public string TestedBy { get; set; }
        public string Division { get; set; }
        public string TempDrift { get; set; }
        public float? E1 { get; set; }
        public float? E2 { get; set; }
        public float? E3 { get; set; }
        public float? E4 { get; set; }
        public float? E5 { get; set; }
        public float? E6 { get; set; }
        public float? E7 { get; set; }
        public float? E8 { get; set; }
        public float? E9 { get; set; }
        public float? E10 { get; set; }
        public float? E11 { get; set; }
        public float? X1 { get; set; }
        public float? X2 { get; set; }
        public float? X3 { get; set; }
        public float? X4 { get; set; }
        public float? X5 { get; set; }
        public float? X6 { get; set; }
        public float? X7 { get; set; }
        public float? X8 { get; set; }
        public float? X9 { get; set; }
        public float? X10 { get; set; }
        public float? X11 { get; set; }
        public float? Y1 { get; set; }
        public float? Y2 { get; set; }
        public float? Y3 { get; set; }
        public float? Y4 { get; set; }
        public float? Y5 { get; set; }
        public float? Y6 { get; set; }
        public float? Y7 { get; set; }
        public float? Y8 { get; set; }
        public float? Y9 { get; set; }
        public float? Y10 { get; set; }
        public float? Y11 { get; set; }
    }
}
