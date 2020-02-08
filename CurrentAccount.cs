
//am using the class that are here
using _07_ByteBank_Constructors;

namespace _07_ByteBank_Constructors
{
    public class CurrentAccount
    {
        //public _05_ByteBank_NameSpace.Client holder;

        //when don't exist logic we can do thus
        public Client Holder { get; set; }

        private int _agency;
        // public int ag;
        public int Agency
        {
            get
            {
                return _agency;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agency = value;
            }
        }
        //when i do this, automaticaly the compilator attributes the _name
        //public int number;
        public int Number { get; set; }
       
        
        private double _balance = 100;

        //convention the name : _nome is atribute private

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _balance = value; 
            }
        }

        //statics members
        public static int TotalCountCreated { get; private set; }


        //constructors
        public CurrentAccount (int agency, int number)
        {
            Agency = agency;
            Number = number;

            TotalCountCreated++;
        }


        public bool CashOut(double value)
        {
            if (_balance < value)
            {
                return false;
            }
            else
            {
                _balance -= value;
                return true;
            }
        }//when return anything: call funtion

        public void Deposit(double value)
        {
            if (value > 0)
                this._balance += value;

        }//when return nathing: call method

        public bool Transfer(double value, CurrentAccount destinationAccount)
        {
            if (this._balance < value)
            {
                return false;
            }
            else
            {
                this._balance -= value;
                destinationAccount.Deposit(value);
                return true;
            }
        }

    }
}