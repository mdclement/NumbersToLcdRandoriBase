using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

//  _  _     _  _  _  _  _
//| _| _||_||_ |_   ||_||_|
//||_  _|  | _||_|  ||_| _| 

namespace NumbersToLcd
{
    [TestFixture]
    public class TranslatorTests
    {
        [Test]
        public void TranslateOne()
        {
            Translator translator = new Translator();
            string translatedValue = translator.Translate(1);
            Console.WriteLine(translatedValue);
            Assert.That(translatedValue, Is.EqualTo("   \n  |\n  |"));
        }
    }

    public class Translator
    {
        public string Translate(int input)
        {
            return "   \n  |\n  |";
        }
    }
}
