using System;

namespace ConsoleApp1
{
    class Weapon
    {
        private string _model;
        private float _weight;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }


        public void weapon()
        {
            Console.WriteLine("Модель:" + Model);
            Console.WriteLine("Вес:" + Weight + "кг");
        }
    }

    class Rifle : Weapon
    {
        private int _ammo;

        public int Ammo
        {
            get { return _ammo; }
            set { _ammo = value; }
        }

        public void rifle()
        {
            weapon();
            Console.WriteLine("Боезопас:" + Ammo);
        }
    }

    class Grenade : Rifle
    {
        private float _range;
        public float Range
        {
            get { return _range; }
            set { _range = value; }
        }

        public void grenade()
        {
            
            rifle();
            Console.WriteLine("Дальность:" + Range + "км");
        }
    }

    class Knife : Weapon
    {
        private float _length;
        public float Length
        {
            get { return _length; }
            set { _length = value; }
        }
        
        public void knife()
        {
            weapon();
            Console.WriteLine("Длина:" + Length + "м");
        }

    }

    public class Base
    {
        public static void Main(string[] args)
        {
            Weapon w = new Weapon { Model = "AWP" , Weight = 40.4f};
            w.weapon();
            Rifle r = new Rifle { Model = "m4a4", Weight = 4.7f, Ammo = 30 };
            r.rifle();
            Grenade g = new Grenade { Model = "Javelin", Weight = 100.32f, Ammo = 1, Range = 40.3f };
            g.grenade();
            Knife k = new Knife { Model = "Sablya", Weight = 2.4f, Length = 45.5f };
            k.knife();
            Console.Read();
        }
    }
}

