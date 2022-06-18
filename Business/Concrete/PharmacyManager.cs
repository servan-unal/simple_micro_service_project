using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PharmacyManager : ISupplierSurvice
    {
        private IApplicantService _applicantService;
        //burada constructo rmetot kullanılıyo çünlü diyorumki her ptt manager yenilendiğinde benim 
        //interface den oluşturduğum değşkenimi set et. 
        public PharmacyManager(IApplicantService applicantService) //constuctor metod ile set ediyorum.
        {
            _applicantService = applicantService;
        }
        //if diyorum burada metotda Person dan nesne ürettim, sonra diyorumki bu person I içindeki person sa 
        //maske ver diyorum.
        public void GiveMask(Person person)
        {

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "İçin maske verildi");
            }
        }
    }
}        
    
