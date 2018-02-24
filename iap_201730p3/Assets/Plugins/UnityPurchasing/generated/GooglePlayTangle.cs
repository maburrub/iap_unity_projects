#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("0YWPq+xCJJoH8zErXMFpjXLAVwGI+tQLOXaac8Pzip963FZ144iqkBupKgkbJi0iAa1jrdwmKioqLisozueyQnA6KE64et7vdtMcYQGv0uuqKHhOpdmOKdJXKazWweD+jkdChhgTLbr8md1xWflU6OIvjhL5ny0sIeWJC3C+iPDUZExaQgEWrTmwzeUV/VK365f7xsg70AiW8Pwge1of1qkqJCsbqSohKakqKiuvKDgMfRAlS9P8C2Qz/Y20XZgGUSZ3Cyq40+s3t7hasrQkdBMJDeOPNoTBbLjhuFfze8uSz/YzKz9KS7ULdolKvnT1tI/jE7j606DDD+4c8elQj+nxQK1edQyYyKk3sAAf+vIvWvI25G76xT+kalG+g/bZ8ikoKisq");
        private static int[] order = new int[] { 11,7,11,10,8,10,8,10,10,10,11,11,12,13,14 };
        private static int key = 43;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
