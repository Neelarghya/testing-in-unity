using UnityEngine;

namespace Generators
{
    public class PinGenerator
    {
        public static int NewFourDigitPin()
        {
            return Random.Range(1000, 10000);
        }
    }
}