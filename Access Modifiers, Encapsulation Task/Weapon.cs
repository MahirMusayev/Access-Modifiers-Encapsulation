using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Encapsulation_Task
{
    internal class Weapon
    {
        public int _bulletCapacity ; 
        public int _bulletNumber;
        private int _bulletTime;
        private bool _fireMood =true;
        public int BulletCapacity
        {
            get { return _bulletCapacity; }
            set { _bulletCapacity = value; }
        }
        public int BulletNumber
        {
            get { return _bulletNumber; }
            set { _bulletNumber = value; }
        }
        public int BulletTime
        {
            get { return _bulletTime; }
            set { _bulletTime = value; }
        }
        public Weapon( int BulletCapacity, int BulletNumber, int BulletTime )
        {
            _bulletCapacity = BulletCapacity;
            _bulletNumber = BulletNumber;
            _bulletTime = BulletTime;
        }
        public void Shoot()
        {
            if (BulletNumber>0)
            {
                Console.WriteLine("1 gulle atildi");
                BulletNumber--;
                Console.WriteLine(BulletNumber);
            }
           else if (BulletNumber == 0)
            {
                Console.WriteLine("gulle qutardi");

            }
        }
        public void Fire()
        {
            Console.WriteLine($"{BulletNumber} gulle atildi ve gulle qutardi");
            BulletNumber = 0;
            
        }
        public void GetRemainBulletCount()
        {
            int full = BulletCapacity - BulletNumber;
            Console.WriteLine("daraxin tam dolmasu ucun " + full + " gulle lazimdi");
        }
        public void Reload()
        {
            int full = BulletCapacity - BulletNumber;
            BulletNumber = BulletNumber + full;
            Console.WriteLine("darax yeniden dolduruldu");
        }
        public void ChangeFireMode()
        {
            if (_fireMood)
            {
                _fireMood = false;
                Console.WriteLine("Fire mode changed to Automatic.");
            }
            else
            {
                _fireMood = true;
                Console.WriteLine("Fire mode changed to Single.");
            }
        }
        public void ShowInformation()
    {
        Console.WriteLine($"Bullet Capacity: {_bulletCapacity}");
        Console.WriteLine($"Bullet Count: {_bulletNumber}");
        Console.WriteLine($"Fire Mode: {_fireMood}");
    }
    }

}
