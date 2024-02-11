using BusinessRule.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRule.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService; //field
        public PttManager(IApplicantService applicantService) //Constructor works when making new pttmanager class. First starts constructor.
        {
            _applicantService = applicantService; //from sets constructtor
        }
        public void GiveMask(Citizen citizen) //In order to give the mask, we need to control the man, so we need a citizen manager.
        {
            
            if(_applicantService.CheckCitizen(citizen)) // ==true but default can approved being true
            {
                Console.WriteLine(citizen.Name + "için maske verildi");
            }
        }
    }
}
