using Business.Abstract;
using Entities.Concrete;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateofBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
        //bu clasın içinde kullanıcıya maske verilebilen bir ortam sonucak.
        //burada Person clasından person nesnesi türetiyorum
        /*
        aynı şekilde
        public void ApplyForMask(string ad, string soyad, int yıl, long tcno)
        {

        }
        da diyebilirdim. ama yarın projede değişiklik yapıp yeni değişken eklemek istediğimde
        bunu kullandığım her yerde bu değişkeni eklemem gerekiyordu.

        classınım içi : 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateofBirthYear { get; set; }
        onun için bir class ta tanımlayıp metot içerisinde class tan nesne alıyorum.

        Buna da encapsulation deniyor
        */