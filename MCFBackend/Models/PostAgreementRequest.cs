using System;

namespace MCFBackend.Models
{
    public class PostAgreementRequest
    {
        public string AgreementNumber { get; set; }
        public string BranchId { get; set; }
        public string BPKBNo { get; set; }
        public DateTime TanggalBPKBIn { get; set; }
        public DateTime TanggalBPKB { get; set; }
        public string FakturNo { get; set; }
        public DateTime TanggalFaktur { get; set; }
        public string PoliceNo { get; set; }
        public string LocationId { get; set; }
    }
}