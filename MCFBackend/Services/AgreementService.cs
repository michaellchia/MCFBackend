using MCFBackend.Models;
using System;
using System.Threading.Tasks;

namespace MCFBackend.Services
{
    public class AgreementService
    {
        public async Task<ResultStatus> Create(PostAgreementRequest request)
        {
            ResultStatus rs = new ResultStatus();
            try
            {
                var context = new MCFDbContext();
                var agreement = new tr_bpkb()
                {
                    agreement_number = request.AgreementNumber,
                    bpkb_date = request.TanggalBPKB,
                    bpkb_date_in = request.TanggalBPKBIn,
                    bpkb_no = request.BPKBNo,
                    branch_id = request.BranchId,
                    faktur_date = request.TanggalFaktur,
                    faktur_no = request.FakturNo,
                    location_id = request.LocationId,
                    police_no = request.PoliceNo
                };

                context.tr_bpkb.Add(agreement);
                context.SaveChanges();

                rs.SetSuccessStatus("Agrrement Successfully Created");
            }
            catch(Exception ex)
            {
                rs.SetErrorStatus(ex.Message);
            }

            return rs;
        }
    }
}