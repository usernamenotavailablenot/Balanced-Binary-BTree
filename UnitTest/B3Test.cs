using B3Tree;

namespace UnitTest
{
    [TestClass]
    public class B3Test
    {
        [TestMethod]
        public void TestB3Trees()
        {
            for (int i = 1; i <= 128; ++i)
            {
                B3Tree<int, int> b3 = new B3Tree<int, int>(i);
                TestB3Tree(b3);
            }
        }
        private void TestB3Tree(B3Tree<int, int> b3)
        {

            int N = 100000;
            int[] arr = new int[N];
            for (int i = 0; i < N; ++i)
            {
                arr[i] = i;
            }
            Shuffle(arr);
            for (int i = 0; i < N; ++i)
            {
                int k = arr[i];
                b3.Add(k, k);
                bool b = b3.HasKey(k);
                Assert.IsTrue(b);
            }
            Shuffle(arr);
            for (int i = 0; i < N; ++i)
            {
                int k = arr[i];
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
