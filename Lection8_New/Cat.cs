using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lection8_New
{
    public partial class Cat : IAnimal, IEnumerable<string>
    {
        private string _kittenAName;
        private string _kittenBName;
        private string _kittenCName;

        public Cat()
        {
        }

        public void AddKittenName(string kittenName)
        {
            if (string.IsNullOrEmpty(_kittenAName))
            {
                _kittenAName = kittenName;
            }
            else if (string.IsNullOrEmpty(_kittenBName))
            {
                _kittenBName = kittenName;
            }
            else if(string.IsNullOrEmpty(_kittenCName))
            {
                _kittenCName = kittenName;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            if (!string.IsNullOrEmpty(_kittenAName))
            {
                yield return _kittenAName;
            }
            if (!string.IsNullOrEmpty(_kittenBName))
            {
                yield return _kittenBName;
            }
            if (!string.IsNullOrEmpty(_kittenCName))
            {
                yield return _kittenCName;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new Exception();
        }

        public string SaySound()
        {
            return "Meow";
        }


    }
}
