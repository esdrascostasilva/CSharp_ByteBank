using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_ByteBank_Constructors;

namespace _07_ByteBank_Constructors
{
    public class Client
    {
        public string Name { get; set; }

        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                //i write my logic to validation CPF
            }
        }
        public string Profission { get; set; }

    }
}
