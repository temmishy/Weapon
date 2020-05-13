using System;

namespace ConsoleApp1
{
    class Weapon
    {
        private string _model;
        private int _ammo;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Ammo
        {
            get { return _ammo; }
            set { _ammo = value; }
        }

        public void weapon()
        {
            Console.WriteLine("Модель:" + Model);
            Console.WriteLine("Боезопас:" + Ammo);

        }
    }

    class Rifle : Weapon
    {
        private float _weight;
        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public void rifle()
        {
            weapon();
            Console.WriteLine("Вес:" + Weight);
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
            Console.WriteLine("Дальность:" + Range);
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
            Console.WriteLine("Длина:" + Length);
        }

    }

    public class Base
    {
        public static void Main(string[] args)
        {
            Weapon w = new Weapon { Model = "AWP" , Ammo = 7};
            w.weapon();
            Rifle r = new Rifle { Model = "m4a4", Ammo = 30, Weight = 4.7f };
            r.rifle();
            Grenade g = new Grenade { Model = "Javelin", Ammo = 1, Weight = 100.32f, Range = 40.3f };
            g.grenade();
            Knife k = new Knife { Model = "Sablya", Ammo = 00, Length = 45.5f };
            k.knife();
            Console.Read();
        }
    }
}

