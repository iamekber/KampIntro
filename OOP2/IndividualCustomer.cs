using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer:Customer
    {
       
        public string IdentificationNo { get; set; }           //nesnede değeri kullanmak zorunda değilsen orada soyutlama hatası yapıyorsundur.
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
