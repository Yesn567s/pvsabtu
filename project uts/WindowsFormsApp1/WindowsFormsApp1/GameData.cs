using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class GameData
    {
        public static Generator clay1 = new Generator(1, 1);
        public static Generator clay2 = new Generator(2, 1);
        public static Generator clay3 = new Generator(3, 1);
        public static Generator clay4 = new Generator(4, 1);

        public static Generator iron1 = new Generator(1, 2);
        public static Generator iron2 = new Generator(2, 2);
        public static Generator iron3 = new Generator(3, 2);
        public static Generator iron4 = new Generator(4, 2);

        public static Generator wood1 = new Generator(1, 3);
        public static Generator wood2 = new Generator(2, 3);
        public static Generator wood3 = new Generator(3, 3);
        public static Generator wood4 = new Generator(4, 3);

        public static Generator crop1 = new Generator(1, 4);
        public static Generator crop2 = new Generator(2, 4);
        public static Generator crop3 = new Generator(3, 4);
        public static Generator crop4 = new Generator(4, 4);
        public static Generator crop5 = new Generator(5, 4);
        public static Generator crop6 = new Generator(6, 4);

        public static double res_clay = 0;
        public static double res_iron = 0;
        public static double res_wood = 0;
        public static double res_crop = 0;

        public static double produce_clay_sum = 0;
        public static double produce_iron_sum = 0;
        public static double produce_wood_sum = 0;
        public static double produce_crop_sum = 0;

        public static double clayProductionMultiplier = 1.0;
        public static double ironProductionMultiplier = 1.0;
        public static double woodProductionMultiplier = 1.0;
        public static double cropProductionMultiplier = 1.0;
        private static int _animationSpeedMultiplier = 1000;
        public static int animationSpeedMultiplier
        {
            get { return _animationSpeedMultiplier; }
            private set { _animationSpeedMultiplier = value; }
        }
        public static event Action AnimationSpeedChanged;

        public static void SetAnimationSpeedMultiplier(int value)
        {
            if (_animationSpeedMultiplier != value)
            {
                _animationSpeedMultiplier = value;
                AnimationSpeedChanged?.Invoke();
            }
        }

        public static void updateProduction()
        {
            produce_clay_sum = (int)((clay1.production_rate + clay2.production_rate + clay3.production_rate + clay4.production_rate + 32) * clayProductionMultiplier);
            produce_iron_sum = (int)((iron1.production_rate + iron2.production_rate + iron3.production_rate + iron4.production_rate + 32) * ironProductionMultiplier);
            produce_wood_sum = (int)((wood1.production_rate + wood2.production_rate + wood3.production_rate + wood4.production_rate + 32) * woodProductionMultiplier);
            produce_crop_sum = (int)((crop1.production_rate + crop2.production_rate + crop3.production_rate + crop4.production_rate + crop5.production_rate + crop6.production_rate + 48) * cropProductionMultiplier);
        }
    }


}
