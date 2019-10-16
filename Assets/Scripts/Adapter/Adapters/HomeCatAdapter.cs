
// адаптируем IHomeCat под IWildCat
namespace adapter
{
    //класс при создании публичного выдает ошибку
    class HomeCatAdapter : IHomeCat
    {

        private IWildCat _wildCat;

        public HomeCatAdapter(IWildCat wildCat)
        {
            _wildCat = wildCat;
        }

       

        public void Meow()
        {
            _wildCat.Glowl();//вместо мяукания будет рычание
        }

        public void Scratch()
        {
            _wildCat.Scratch();//они и там и там одинаковые
        }

        //назватия и get set разные
        public string Name
        { get { return _wildCat.Breed; }

            set { } }
    }

}

