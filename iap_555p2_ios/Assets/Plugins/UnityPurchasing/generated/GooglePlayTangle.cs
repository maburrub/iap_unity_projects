#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("fLjUVi3j1a2JOREHH1xL8GTtkLhIoA/qtsqmm5VmjVXLraF9JgdCi4zY0vaxH3nHWq5sdgGcNNAvnQpcCq4mls+Sq252YhcW6FYr1BfjKahG9HdURntwf1zwPvCBe3d3d3N2dQMoUcWV9GrtXUKnr3IHr2u5M6eY1aeJVmQrxy6ertfCJ4ELKL7V983p0r5O5aeO/Z5Ss0GstA3StKwd8Grq5Qfv6XkpTlRQvtJr2Zwx5bzlRU5w56HEgCwEpAm1v3LTT6TCcHGTuu8fLWd1E+Ung7IrjkE8XPKPtvR3eXZG9Hd8dPR3d3bydWVRIE1493UlE/iE03SPCnTxi5y9o9MaH9sWjqFWOW6g0OkAxVsMeypWd+WOtmL5Nwzj3quEr3R1d3Z3");
        private static int[] order = new int[] { 4,5,11,9,4,13,7,12,11,9,10,13,13,13,14 };
        private static int key = 118;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
