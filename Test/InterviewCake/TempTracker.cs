using System;
using System.Collections.Generic;

namespace Test.InterviewCake
{
    public class TempTracker
    {
        private int _max;
        private int _min;
        private int _count;
        private int _sum;
        private int[] _arr;
        private Tuple<int, int> _modeTemp;

        public TempTracker()
        {
            _arr = new int[111];
            _min = 110;
            _max = 0;
            _count = 0;
            _sum = 0;
            _modeTemp = new Tuple<int, int>(-1, -1);
        }

        public void Insert(int data)
        {
            _count++;
            _sum += data;
            _min =_min > data ? data : _min;
            _max = _max < data ? data: _max;
            _arr[data]++;

            if (_modeTemp.Item2 > -1 || _arr[data] >= _modeTemp.Item2)
            {
                _modeTemp = new Tuple<int, int>(data, _arr[data]);
            }
        }

        public int GetMax()
        {
            return _max;
        }

        public int GetMin()
        {
            return _min;
        }

        public int GetMean()
        {
            return _sum /_count;
        }

        public int GetMode()
        {
            return  _modeTemp.Item1;
        }
    }
}
