#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("abnSVf2udd//O1KFoxr1L+39rVHUyM/SydTZkbaQtKaj9aSjs63h0JY57I3YF00sO3xT1ztS1nLXkO9hqIumoaWlp6Khtr7I1NTQ05qPj9eEQktxF9B/r+VBh2pRzdhNRxW3t+Xev+zL8DbhKWTUwquwI+Enkyoh2pAiodaQrqaj9b2voaFfpKSjoqGAwc7EgMPF0tTJxsnDwdTJz86A0BWaDVSvrqAyqxGBto7UdZyte8K2tpC0pqP1pKOzreHQ0MzFgPLPz9TJxsnDwdTJz86A4dXUyM/SydTZkS/TIcBmu/upjzISWOToUMCYPrVVzsSAw8/OxMnUyc/O04DPxoDV08W/JSMluzmd55dSCTvgLox0ETCyeB5U0ztOcsSva9nvlHgCnlnYX8toK7kpflnrzFWnC4KQoki4nljwqXOVkpGUkJOW+retk5WQkpCZkpGUkJCxpqP1pKqzquHQ0MzFgOnOw46RkCKkG5AiowMAo6KhoqKhopCtpqnQzMWA8s/P1IDj4ZC+t62QlpCUkt/hCDhZcWrGPITLsXADG0S7imO/IqGgpqmKJugmV8PEpaGQIVKQiqYgtItwyec01qleVMstjuAGV+ft36WgoyKhr6CQIqGqoiKhoaBEMQmpjIDDxdLUycbJw8HUxYDQz8zJw9mvPZ1Ti+mIumhebhUZrnn+vHZrnel41j+TtMUB1zRpjaKjoaChAyKhpKazovXzkbOQsaaj9aSqs6rh0NCA4+GQIqGCkK2mqYom6CZXraGhoYaQhKaj9aSrs73h0NDMxYDjxdLU+Qelqdy34PaxvtRzFyuDm+cDdc+mkK+mo/W9s6GhX6SlkKOhoV+QvdfXjsHQ0MzFjsPPzY/B0NDMxcPBxJWDteu1+b0TNFdWPD5v8Bph+PDCzMWA09TBzsTB0sSA1MXSzdOAwccvqBSAV2sMjIDP0BafoZAsF+NvraapiiboJletoaGlpaCjIqGhoPzSwcPUycPFgNPUwdTFzcXO1NOOkKdM3ZkjK/OAc5hkER8676rLX4tcF7sdM+KEsopnr70W7Tz+w2jrILfZgMHT09XNxdOAwcPDxdDUwc7DxczFgOnOw46RhpCEpqP1pKuzveHQEZD4TPqkkizIEy+9fsXTX8f+xRyPkCFjpqiLpqGlpaeiopAhFrohE5OW+pDCkauQqaaj9aSms6L185GzqP6QIqGxpqP1vYCkIqGokCKhpJDyxczJwc7DxYDPzoDUyMnTgMPF0r8xe77n8EulTf7ZJI1LlgL37PVMeZbfYSf1eQc5GZLiW3h10T7eAfKAz8aA1MjFgNTIxc6AwdDQzMnDwZ2Gx4Aqk8pXrSJvfksDj1nzyvvEjuAGV+ft36j+kL+mo/W9g6S4kLZgw5PXV5qnjPZLeq+Brnoa07nvFQsD0TLn8/VhD4/hE1hbQ9BtRgPs1MnGycPB1MWAwtmAwc7ZgNDB0tSmo/W9rqS2pLSLcMnnNNapXlTLLQh83oKVaoV1ea92y3QChIOxVwEMNT7arATnK/t0tpeTa2Sv7W60yXGKJugmV62hoaWloJDCkauQqaaj9dDMxYDjxdLUycbJw8HUyc/OgOHV8AoqdXpEXHCpp5cQ1dWB");
        private static int[] order = new int[] { 19,5,48,35,53,25,28,45,23,12,11,55,43,49,50,16,45,43,19,28,43,34,32,50,44,32,27,48,49,55,52,55,36,43,42,42,47,46,51,59,40,42,48,46,50,46,51,51,58,58,56,55,57,56,59,57,59,58,58,59,60 };
        private static int key = 160;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
