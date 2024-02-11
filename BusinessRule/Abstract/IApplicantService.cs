using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRule.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Citizen citizen); // who applying for masks



         List<Citizen> GetList(); //people who buy masks.The type of our list is person

        bool CheckCitizen(Citizen citizen);
       
    }
}
