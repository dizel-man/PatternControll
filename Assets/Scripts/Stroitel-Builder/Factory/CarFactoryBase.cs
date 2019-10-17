using UnityEngine;

namespace stroitel
{

    abstract class CarFactoryBase
    {

        protected readonly CarBuilderBase CarBuilder;

        protected CarFactoryBase (CarBuilderBase builder)
        {
            CarBuilder = builder;
        }

        //здесь будем возвращать Car
        public abstract Car Construct();
    }

}
