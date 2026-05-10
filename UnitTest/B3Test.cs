using B3Tree;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class B3Test
    {
        [TestMethod]
        public void TestB3Trees()
        {
            int N = 100000;
            int[] insert = new int[N];
            int[] delete = new int[N];
            for (int i = 0; i < N; ++i)
            {
                insert[i] = i;
                delete[i] = i;
            }
            Shuffle(insert);
            Shuffle(delete);
            for (int i = 1; i <= 128; ++i)
            {
                B3Tree<int, int> b3 = new B3Tree<int, int>(i);
                Stopwatch sw = Stopwatch.StartNew();
                TestB3Tree(b3, insert, delete, N);
                sw.Stop();
                Console.WriteLine($"min = '{i}', time spent '{sw.ElapsedMilliseconds}' Milliseconds.");
            }
        }
        private void TestB3Tree(B3Tree<int, int> b3, int[] insert, int[] delete, int N)
        {
            for (int i = 0; i < N; ++i)
            {
                int k = insert[i];
                b3.Add(k, k);
                bool b = b3.HasKey(k);
                Assert.IsTrue(b);
            }
            for (int i = 0; i < N; ++i)
            {
                int k = delete[i];
                b3.Remove(k);
                bool b = b3.HasKey(k);
                Assert.IsFalse(b);
            }
        }
        private static void Shuffle<T>(T[] arr)
        {
            Random r = new Random();
            for (int i = arr.Length - 1; i >= 0; --i)
            {
                int j = r.Next(i + 1);
                T tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
    }
}
