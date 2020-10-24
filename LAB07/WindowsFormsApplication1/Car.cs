using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Car
    {
        // Field declaration
        private string _Zagvar;
        private string _AralDugaar;
        private string _Ungu;
        private int _On;
        private char _Angilal;
        private string _UlsDugaar;

        // Property declaration
        public string Zagvar 
        {
            get { return _Zagvar; }
            set { _Zagvar = value; }
        }
        public string AralDugaar
        {
            get { return _AralDugaar; }
            set { _AralDugaar = value; }
        }
        public string Ungu
        {
            get { return _Ungu; }
            set { _Ungu = value; }
        }
        public int On
        {
            get { return _On; }
            set { _On = value; }
        }
        public char Angilal
        {
            get { return _Angilal; }
            set { _Angilal = value; }
        }
        public string UlsDugaar
        {
            get { return _UlsDugaar; }
            set { _UlsDugaar = value; }
        }

        // Constructor declaration
        public Car(string Zagvar, string AralDugaar, string Ungu, int On, char Angilal, string UlsDugaar)
        {
            this.Zagvar = Zagvar;
            this.AralDugaar = AralDugaar;
            this.Ungu = Ungu;
            this.On = On;
            this.Angilal = Angilal;
            this.UlsDugaar = UlsDugaar;
        }
        // Function declaration
        public string Mashinii_medeelel_avah()
        {
            return "Модел: " + this.Zagvar + "\nАрлын дугаар: " + this.AralDugaar + "\nӨнгө: " + this.Ungu + "\nҮйлдвэрлэсэн он: " + this.On + "\nАнгилал: " + this.Angilal + "\nУлсын дугаар: " + this.UlsDugaar;
        }
        
    }
}
