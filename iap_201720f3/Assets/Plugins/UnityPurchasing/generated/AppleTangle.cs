#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("3TWyDppNcRaWmtXKDIW7ijYN+XWa+fuKOLuYire8s5A88jxNt7u7u5A88jxNt7u7v7+6itiLsYqzvLnvMaMzZEPx1k+9EZiKuFKihELqs2mlPzk/oSOH/Y1IEyH6NJZuCyqoYprV3JrO0t+aztLf1JrbysrW09nbvIq1vLnvp6m7u0W+v4q5u7tFiqfjHb+zxq367KukzmkNMZmB/Rlv1REZyyj96e97FZX7CUJBWcp3XBn2iqu8ue++sKmw+8rK1t+a89TZlIuU+hxN/ffFsuSKpby576eZvqKKrL1Wx4M5MemaaYJ+CwUg9bDRRZFGspG8u7+/vbi7rKTSzs7KyYCVlc2WmtnfyM7T3NPZ287fmsrV1tPZw83NlNvKytbflNnV15XbysrW39nbiYzgitiLsYqzvLnvvrypuO/pi6mMI/aXwg1XNiFmSc0hSMxozYr1e3rZic1NgL2W7FFgtZu0YADJo/UP6N/W09vU2d+a1dSaztLTyZrZ38i1J4dJkfOSoHJEdA8DtGPkpmxxh4ec3ZowidBNtzh1ZFEZlUPp0OHeDaEHKfieqJB9tacM9ybk2XLxOq2y5Io4u6u8ue+nmr44u7KKOLu+isOa28nJz9ffyZrb2dnfys7b1NnfC4riVuC+iDbSCTWnZN/JRd3k3wZzo8hP57RvxeUhSJ+5AO819+e3S87S1cjTzsOLrIquvLnvvrmpt/vK1N6a2dXU3tPO09XUyZrV3JrPyd8vJMC2Hv0x4W6sjYlxfrX3dK7Ta/NizCWJrt8bzS5zl7i5u7q7GTi7vLnvp7S+rL6ukWrT/S7Ms0RO0TfO09zT2dvO35rYw5rb1MOaytvIzpWKO3m8spG8u7+/vbi4ijsMoDsJt7yzkDzyPE23u7u/v7q5OLu7uuaa29TemtnfyM7T3NPZ287T1dSayoo4vgGKOLkZGrm4u7i4u7iKt7yz09zT2dvO09XUmvvPztLVyNPOw4u/urk4u7W6iji7sLg4u7u6XisTs9bfmvPU2ZSLnIqevLnvvrGpp/vKBE7JIVRo3rVxw/WOYhiEQ8JF0XJjjMV7Pe9jHSMDiPhBYm/LJMQb6BJmxJiPcJ9vY7Vs0W4YnpmrTRsWnlhRaw3KZbX/W51wS9fCV10Pra2+vKm47+mLqYqrvLnvvrCpsPvKysrW35ro1dXOmvn7iqStt4qMio6IwIo4u8yKtLy576e1u7tFvr65uLs4u7q8s5A88jxN2d6/u4o7SIqQvDqukWrT/S7Ms0RO0TeU+hxN/ffFD4AXTrW0uiixC5uslM5vhrdh2KylK2Gk/epRv1fkwz6XUYwY7fbvVtjW35rJztvU3tvI3prO38jXyZrbj4iLjoqJjOCtt4mPioiKg4iLjorK1t+a+d/IztPc09nbztPV1Jr7z6yKrry57765qbf7ysrW35ro1dXOyNvZztPZ35rJztvO39ff1M7JlIo1yTvafKHhs5UoCEL+8kragiSvT96Pma/xr+OnCS5NTCYkdeoAe+Lq/8Sl9tHqLPszfs7Ysao5+z2JMDucip68ue++samn+8rK1t+a+d/IzsX7EiJDa3DcJp7Rq2oZAV6hkHml6hAwb2BeRmqzvY0Kz8+b");
        private static int[] order = new int[] { 21,13,13,16,49,41,29,52,24,9,31,51,35,44,36,24,48,57,38,22,56,59,33,40,26,33,41,43,38,43,30,39,37,47,45,59,51,51,48,50,58,54,53,44,44,48,48,51,58,54,53,52,54,59,58,55,56,58,59,59,60 };
        private static int key = 186;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
