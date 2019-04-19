using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EasyToLearn.Partten.C0.Guidline.DIP
{
    /// <summary>
    /// 只依赖抽象
    /// 3.依赖倒转原则（Dependence Inversion Principle）
    /// </summary>
    [TestClass]
    public class Client
    {
        [TestMethod]
        public void Case1()
        {
            var soldier = new BadSample.Soldier();
            soldier.Fire(new BadSample.M4A1());

            var gsoldier = new GoodSample.Soldier();
            gsoldier.Fire(new GoodSample.M4A1());
            gsoldier.Fire(new GoodSample.AK47());
        }
    }


    public class BadSample
    {
        public class Soldier
        {
            public void Fire(M4A1 gun)
            {
                gun.Fire();
            }
        }

        public class M4A1
        {
            public void Fire()
            {
                Console.WriteLine("BadSample:士兵使用M4A1开枪了");
            }
        }
    }
   

    public class GoodSample
    {
        public class Soldier
        {
            public void Fire(IWeaponAction gun)
            {
                gun.Fire();
            }
        }

        public interface IWeaponAction
        {
            void Fire();
        }

        public class M4A1 : IWeaponAction
        {
            public void Fire()
            {
                Console.WriteLine("GoodSample:士兵使用M4A1开火了");
            }
        }

        public class AK47 : IWeaponAction
        {
            public void Fire()
            {
                Console.WriteLine("GoodSample:士兵使用AK47开火了");
            }
        }

    }
   
}