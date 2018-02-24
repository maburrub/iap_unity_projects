#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("KgF47LzdQ8R0a46GWy6GQpAajrG6k8Y2BE5cOswOqpsCp2gVddumn2/dXn1vUllWddkX2ahSXl5eWl9cpfH735g2UO5zh0VfKLUd+Qa0I3VDw8wuxsBQAGd9eZf7QvC1GMyVzGGJJsOf44+yvE+kfOKEiFQPLmuiI4cPv+a7gkdfSz4/wX8C/T7KAIFsZ1nOiO2pBS2NIJyWW/pmjetZWD+niH8QR4n5wCnsciVSA39ezKef3V5QX2/dXlVd3V5eX9tcTHgJZFH8jqB/TQLuB7eH/usOqCIBl/ze5N5cDDrRrfpdpiNd2KK1lIr6MzbyVZH9fwTK/ISgEDguNnVi2U3EuZHA+5dnzI6n1Ld7mmiFnST7nYU02UvQHiXK94Kthl1cXl9e");
        private static int[] order = new int[] { 13,10,13,11,13,5,9,11,9,10,11,11,13,13,14 };
        private static int key = 95;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
