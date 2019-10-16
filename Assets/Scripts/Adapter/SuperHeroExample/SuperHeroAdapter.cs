using UnityEngine;

// заменяем - адаптируем
namespace adapter
{
    class SuperHeroAdapter : ISuperhero
    {
        private IFly _fly;
        private IShoot _shoot;
        private IGo _go;

        public SuperHeroAdapter(IFly fly, IShoot shoot, IGo go)
        {
            _fly = fly;
            _shoot = shoot;
            _go = go;
        }

        // и теперь преобразовываем

        public void Fly()
        {
            _fly.Fly();
        }

        public void Go()
        {
            _go.Go();
        }

        public void Shoot()
        {
            _shoot.Shoot();
        }
    }

}
