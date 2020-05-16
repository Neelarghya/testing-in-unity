using Generators;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class PinGeneratorTest
    {
        private int _lastPin;
        
        [Test, Repeat(5)]
        public void PinShouldBeOf4Digits()
        {
            int pin = PinGenerator.NewFourDigitPin();
            bool is4Digits = pin >= 1000 && pin <= 9999;
            
            Debug.Log("Pin: " + pin);
            
            Assert.IsTrue(is4Digits);
            Assert.AreNotEqual(_lastPin, pin);

            _lastPin = pin;
        }
    }
}