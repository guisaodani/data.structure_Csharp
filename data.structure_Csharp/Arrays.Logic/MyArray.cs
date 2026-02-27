using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Logic
{
    public class MyArray
    {
        private int _top; // tamaño logico del arreglo
        private int[] _array;

        public MyArray(int n)   //constructor
        {
            N = n;
            _array = new int[n];
            _top = 0;
        }

        public bool IsFull => _top == N;
        public bool IsEmpty => _top == 0;

        public int N { get; }  /// propiedad tamaño fisico del arreglo

        public void Add(int number)
        {
            if (IsFull)
            {
                throw new Exception("El arreglo ya esta lleno");
            }
            _array[_top] = number;
            _top++;
        }

        public void Insert(int number, int position)

        {
            if (IsFull)
            {
                throw new Exception("El arreglo ya esta lleno");
            }

            if (position < 0)
            {
                position = 0;
            }

            if (position > _top)
            {
                position = _top;
            }

            for (int i = _top; i > position; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[position] = number;
            _top++;
        }

        public void Remove(int position)
        {
            if (IsEmpty)
            {
                throw new Exception("El arreglo esta vacio");
            }

            if (position < 0)
            {
                position = 0;
            }

            if (position > _top)
            {
                position = _top;
            }

            for (int i = position; i < _top - 1; i++)
            {
                _array[position] = _array[i + 1];
            }
            _top--;
        }

        public void Fill()
        {
            Fill(1, 100);
        }

        public void Fill(int minimun, int maximun)
        {
            Random random = new();
            for (int i = 0; i < N; i++)
            {
                _array[i] = random.Next(minimun, maximun);
            }
            _top = N;
        }

        public MyArray GetPrimes()
        {
            int primescount = 0;
            for (int i = 0; i < _top; i++)
            {
                if (IsPrime(_array[i]))
                {
                    primescount++;
                }
            }

            var primesArray = new MyArray(primescount);
            for (int i = 0; i < _top; i++)
            {
                if (IsPrime(_array[i]))
                {
                    primesArray.Add(_array[i]);
                }
            }
            return primesArray;
        }

        public MyArray GetOdds()
        {
            var oddCount = 0;
            for (int i = 0; i < _top; i++)
            {
                if (_array[i] % 2 == 0)
                {
                    oddCount++;
                }
            }
            var oddArray = new MyArray(oddCount);
            for (int i = 0; i < _top; i++)
            {
                if (_array[i] % 2 == 0)
                {
                    oddArray.Add(_array[i]);
                }
            }
            return oddArray;
        }

        public MyArray GetNonRepeated()
        {
            int nonRepeatCount = 0;
            for (int i = 0; i < _top; i++)
            {
                bool isRepeted = false;
                for (int j = 0; j < _top; j++)
                {
                    if (i != j && _array[i] == _array[j])
                    {
                        isRepeted = true;
                        break;
                    }
                }
                if (!isRepeted)
                {
                    nonRepeatCount++;
                }
            }
            var nonRepeated = new MyArray(nonRepeatCount);
            for (int i = 0; i < _top; i++)
            {
                bool isRepeted = false;
                for (int j = 0; j < _top; j++)
                {
                    if (i != j && _array[i] == _array[j])
                    {
                        isRepeted = true;
                        break;
                    }
                }
                if (!isRepeted)
                {
                    nonRepeated.Add(_array[i]);
                }
            }

            return nonRepeated;
        }

        public MyArray GetMostRepeat()
        {
            int[,] matrixCount = new int[_top, 2];
            int topMatrix = FillMatrixCount(matrixCount);
            OrderMatrixCount(matrixCount, topMatrix);
            int repeatedCounter = GetRepeatedNumber(matrixCount, topMatrix);
            return FillMostRepeated(repeatedCounter, matrixCount);
        }

        private MyArray FillMostRepeated(int repeatedCounter, int[,] matrixCount)
        {
            var mostRepeated = new MyArray(repeatedCounter);
            for (int i = 0; i < repeatedCounter; i++)
            {
                mostRepeated.Add(matrixCount[i, 0]);
            }
            return mostRepeated;
        }

        private int GetRepeatedNumber(int[,] matrixCount, int topMatrix)
        {
            int repeatedCounter = 1;
            for (; repeatedCounter < topMatrix; repeatedCounter++)
            {
                if (matrixCount[0, 1] != matrixCount[repeatedCounter, 1])
                {
                    break;
                }
            }
            return repeatedCounter;
        }

        private void OrderMatrixCount(int[,] matrixCount, int topMatrix)
        {
            //order by counter
            for (int i = 0; i < topMatrix - 1; i++)
            {
                for (int j = i + 1; j < topMatrix; j++)
                {
                    if (matrixCount[i, 1] < matrixCount[j, 1])
                    {
                        Change(ref matrixCount[i, 0], ref matrixCount[j, 0]);
                        Change(ref matrixCount[i, 1], ref matrixCount[j, 1]);
                    }
                }
            }
        }

        private int FillMatrixCount(int[,] matrixCount)
        {
            int topMatrix = 0;

            for (int i = 0; i < _top; i++)
            {
                int j = 0;
                for (; j < topMatrix; j++)
                {
                    if (_array[i] == matrixCount[j, 0])
                    {
                        matrixCount[j, 1]++;
                        break;
                    }
                }
                if (j == topMatrix)
                {
                    matrixCount[topMatrix, 0] = _array[i];
                    matrixCount[topMatrix, 1] = 1;
                    topMatrix++;
                }
            }
            return topMatrix;
        }

        public override string ToString()
        {
            if (IsEmpty)
            {
                return "Array Vacio";
            }
            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                output += $"{_array[i]}\t";
                count++;
                if (count > 9)
                {
                    count = 0;
                    output += "\n";
                }
            }
            return output;
        }

        public void Sort()
        {
            Sort(descending: false);
        }

        public void Sort(bool descending)
        {
            for (int i = 0; i < _top - 1; i++)
            {
                for (int j = i + 1; j < _top; j++)
                {
                    if (descending)
                    {
                        if (_array[i] < _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                    else
                    {
                        if (_array[i] > _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                }
            }
        }

        private void Change(ref int a, ref int b)  //parametros por referencia, eso pasa con los tipo de datos primitivos. no con los objetos
        {
            int aux = a;
            a = b;
            b = aux;
        }

        private bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}