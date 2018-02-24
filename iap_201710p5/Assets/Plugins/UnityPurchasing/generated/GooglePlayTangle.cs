#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("ed1V5bzh2B0FEWRlmyVYp2SQWtuaoc09ltT9ju0hwDLfx36hx99ugzY9A5TSt/Nfd9d6xswBoDzXsQMCD8unJV6Qpt76SmJ0bC84gxee48s1hwQnNQgDDC+DTYPyCAQEBAAFBuDJnGxeFAZgllTwwVj9Mk8vgfzFcFsituaHGZ4uMdTcAXTcGMpA1OsZmZZ0nJoKWj0nI82hGKrvQpbPljvTfJnFudXo5hX+Jrje0g5VdDH4hwQKBTWHBA8HhwQEBYEGFiJTPguEBlZgi/egB/x5B4L4787QoGlsqGX90iVKHdOjmnO2KH8IWSUElv3F/6uhhcJsCrQp3R8Fcu9Ho1zueS+m1PolF1i0Xe3dpLFU8nhbzaaEvhGKRH+Qrdj33AcGBAUE");
        private static int[] order = new int[] { 9,12,3,4,9,10,13,9,10,12,10,13,13,13,14 };
        private static int key = 5;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
