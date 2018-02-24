#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("PL7u2DNPGL9Ewb86QFd2aBjR1BChIS7MJCKy4oWfm3UZoBJX+i53LrdzH53mKB5mQvLazNSXgDuvJltzwWXtXQRZYKW9qdzdI53gH9wo4mODa8QhfQFtUF6tRp4AZmq27cyJQFhxJNTmrL7YLuxIeeBFiveXOUR9HmxCna/gDOVVZRwJ7ErA43UePAaOhbssag9L589vwn50uRiEbwm7uo0/vJ+NsLu0lzv1O0qwvLy8uL2+yOOaDl4/oSaWiWxkucxkoHL4bFNHExk9etSyDJFlp73KV/8b5FbBl91Fap3ypWsbIssOkMew4Z28LkV9Ihl1hS5sRTZVmXiKZ3/GGX9n1js/vLK9jT+8t78/vLy9Ob6umuuGs6ky/McoFWBPZL++vL28");
        private static int[] order = new int[] { 8,2,4,9,5,10,7,9,8,13,11,13,12,13,14 };
        private static int key = 189;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
