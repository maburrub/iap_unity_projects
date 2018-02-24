#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("ujk3OAi6OTI6ujk5OLw7Kx9uAzYy9poYY62b48d3X0lREgW+KqPe9qec8ACr6cCz0Bz9D+L6Q5z64lO+CLo5Ggg1PjESvnC+zzU5OTk9ODu5O2tdtsqdOsFEOr/F0vPtnVRRld30oVFjKTtdq2nN/GXAD3ISvMH4CwA+qe+KzmJK6kf78TydAeqMPj9NZh+L27okoxMM6eE8SeEl933p1ljA7xh3IO6ep06LFUI1ZBg5q8D4JKSrSaGnN2cAGh7wnCWX0n+r8qtE4GjYgdzlIDgsWVimGGWaWa1n5sKWnLj/UTeJFOAiOE/Sep5h00QSm+nHGCpliWDQ4JmMac9FZvCbuYMG7kGk+ITo1dsowxuF4+8zaEkMxSy3eUKtkOXK4To7OTg5");
        private static int[] order = new int[] { 1,4,12,4,8,10,8,13,8,12,12,11,13,13,14 };
        private static int key = 56;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
