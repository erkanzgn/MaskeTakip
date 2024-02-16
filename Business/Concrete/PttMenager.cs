using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttMenager:ISupplierService
    {
        
        private IApplicantService _applicantservice;

        public PttMenager(IApplicantService applicantService)// Constructor new yapıldığında çalışır
        {
            _applicantservice = applicantService;
        }
            

        public void GiveMask(Person person)
        {
            
            if(_applicantservice.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName +" için maske VERİLEMEDİ");
            }
        }
    }
}
