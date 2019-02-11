using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class MeineListe : IEnumerable
    {
        private int[] _zahlen;
        private int _größe = 0;

        public void Add(int neueZahl)
        {
            int[] neuesArray = new int[_größe + 1];
            if (_größe > 0)
            {
                Array.Copy(_zahlen, neuesArray, _größe);
            }
            neuesArray[_größe] = neueZahl;
            _zahlen = neuesArray;
            _größe++;
        }

        public IEnumerator GetEnumerator()
        {
            yield return _größe;
            foreach (var item in _zahlen)
            {
                yield return item;
            }
           
            //return _zahlen.GetEnumerator();
        }
    }
}
