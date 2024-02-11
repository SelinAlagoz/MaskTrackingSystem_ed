using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRule.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace BusinessRule.Concrete
{
    //Don't leave a naked class!!!
    public class CitizenManager : IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public bool CheckCitizen(Citizen citizen)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(123,"Hehe","Naber",1997)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Citizen> GetList()
        {
            return null;
        }
    }
}
