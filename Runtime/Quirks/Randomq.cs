
namespace Quirks
{
    public static class Randomq
    {
        static System.Random randomGen = new System.Random();


        /// <summary>Returns a Random int between the min and max(inclusive)</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        public static int GetRandom(int min = 0, int max = 100)
        {
            return randomGen.Next(min, max + 1);
        }

        /// <summary>Returns a Random float between the min and max</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        public static float GetRandom(float min = 0f, float max = 1f)
        {
            return (float)(randomGen.NextDouble() * (max - min) + min);
        }

        /// <summary>Returns a Random double between the min and max</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        public static double GetRandom(double min = 0.0, double max = 1.0)
        {
            return randomGen.NextDouble() * (max - min) + min;
        }

        /// <summary>Returns True if the number is less than the threshold</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        public static bool GetRandomThreshold(int min = 0, int max = 100, int threshold = 50)
        {
            int rnd = GetRandom(min, max);

            return rnd < threshold ? true : false;
        }

        /// <summary>Returns True if the number is less than the threshold</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        public static bool GetRandomThreshold(float min = 0f, float max = 1f, float threshold = 0.5f)
        {
            float rnd = GetRandom(min, max);

            return rnd < threshold ? true : false;
        }

        /// <summary>Returns True if the number is less than the threshold</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        public static bool GetRandomThreshold(double min = 0.0, double max = 1.0, double threshold = 0.5)
        {
            double rnd = GetRandom(min, max);

            return rnd < threshold ? true : false;
        }
    }
}
