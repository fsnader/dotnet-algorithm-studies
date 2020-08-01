using System;

namespace AlgorithmsPractice.Codility.CountingElements
{
    /// <summary>
    /// Detected time complexity: O(N + M)
    /// </summary>
    public class CountingOperations
    {
        public void Solution()
        {
            // Example case
            Console.WriteLine(ProcessCounters(5, new[] {3, 4, 4, 6, 1, 4, 4}));

            //Single counter
            Console.WriteLine(ProcessCounters(1, new[] {1}));
        }

        private int[] ProcessCounters(int counterSize, int[] operations)
        {
            var counter = new Counter(counterSize);

            foreach (var operation in operations)
            {
                counter.ProcessOperation(operation);
            }

            return counter.GetCounters();
        }
    }

    public class Counter
    {
        private readonly int _counterSize;
        private int _maxValue;

        private int _lastMaxOperation;
        private readonly int[] _counters;

        public Counter(int size)
        {
            _counterSize = size;
            _counters = new int[size];
        }

        private void Increase(int counter)
        {
            if (counter > _counterSize)
                return;

            if (_counters[counter - 1] < _lastMaxOperation)
                _counters[counter - 1] = _lastMaxOperation + 1;
            else
                _counters[counter - 1]++;
            
            if (_counters[counter - 1] > _maxValue)
                _maxValue = _counters[counter - 1];
        }

        private void MaxCounter()
        {
            _lastMaxOperation = _maxValue;
        }

        public void ProcessOperation(int value)
        {
            if (value >= 0 && value <= _counterSize)
                Increase(value);

            if (value >= 0 && value > _counterSize)
                MaxCounter();
        }

        public int[] GetCounters()
        {
            for (var i = 0; i < _counterSize; i++)
            {
                if (_counters[i] < _lastMaxOperation)
                    _counters[i] = _lastMaxOperation;
            }

            return _counters;
        }
    }
}