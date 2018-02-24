#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("ghCA1/BCZfwOois5C+ERN/FZANq4OVHlUw07hWG6hhTXbHr2bldstXllbClKbHt9YG9gamh9YGZnKUh8OYsNsjmLCqqpCgsICwsICzkEDwDAEHv8VAfcdlaS+ywKs1yGRFQE+COPQY/+BAgIDAwJOWs4AjkADwpcZWwpQGdqJzgvOS0PClwNAhoUSHkmOYjKDwEiDwgMDA4LCzmIvxOIuntoan1gamwpen1ofWxkbGd9eic5W2xlYGhnamwpZmcpfWFgeilqbHsEDwAjj0GP/gQICAwMCQqLCAgJVQ7ldDCKglop2jHNuLaTRgNi9iL1vhK0mkstGyPOBhS/RJVXasFCiR4MCQqLCAYJOYsIAwuLCAgJ7ZigAD+QRSRxvuSFktX6fpL7f9t+OUbIiR0i2WBOnX8A9/1ihCdJr/5ORHaLCAkPACOPQY/+am0MCDmI+zkjDydJr/5ORHYBVzkWDwpcFCoNETkfcCloenp8ZGx6KWhqamx5fWhnamzQP3bIjlzQrpCwO0vy0dx4l3eoW2tlbCl6fWhnbWh7bSl9bHtkeiloeWVsKVtmZn0pSkg5Fx4EOT85PTsPOQYPClwUGggI9g0MOQoICPY5FEDRf5Y6HWyofp3AJAsKCAkIqosIDwpcFAcNHw0dItlgTp1/APf9YoSGeohpzxJSACabu/FNQflpMZcc/B85HQ8KXA0KGgRIeXllbClbZmZ9NC9uKYM6Y/4Ei8bX4qom8FpjUm0BVzmLCBgPClwUKQ2LCAE5iwgNORaY0hdOWeIM5FdwjSTiP6teRVzlKUpIOYsIKzkEDwAjj0GP/gQICAhgb2BqaH1gZmcpSHx9YWZ7YH1wODo/UzlrOAI5AA8KXA0PGgtcWjgaORgPClwNAxoDSHl5ZWwpQGdqJzhQrgwAdR5JXxgXfdq+gioyTqrcZn5+J2h5eWVsJ2pmZCZoeXllbGpooqp4m05aXMimJki68fLqecTvqkW3/XqS59ttBsJwRj3RqzfwcfZiwRaMiowSkDROPvugkkmHJd24mRvRTHcWRWJZn0iAzX1rAhmKSI46g4gpaGdtKWpse31gb2BqaH1gZmcpebwzpP0GBwmbArgoHyd93DUE0msffWBvYGpofWwpa3ApaGdwKXloe308Ozg9OTo/Ux4EOjw5OzkwOzg9OW6GAb0p/sKlJSlmeb82CDmFvkrGczmLCH85Bw8KXBQGCAj2DQ0KCwjJajp+/jMOJV/i0wYoB9OzehBGvHZIoZHw2MNvlS1iGNmqsu0SI8oWKWZvKX1hbCl9YWxnKWh5eWVgamgBIg8IDAwOCwgfF2F9fXl6MyYmfgaUNPoiQCETwffHvLAH0FcV38I0Z20pamZnbWB9YGZneilmbyl8emwlKWpse31gb2BqaH1sKXlmZWBqcC3r4ti+edYGTOguw/hkceTuvB4enJdzBa1OglLdHz46ws0GRMcdYNgvOS0PClwNAhoUSHl5ZWwpSmx7fX1hZntgfXA4HzkdDwpcDQoaBEh5odV3KzzDLNzQBt9i3astKhj+qKVtPCocQhxQFLqd/v+Vl8ZZs8hRWQ0PGgtcWjgaORgPClwNAxoDSHl5WaOD3NPt9dkADj65fHwo");
        private static int[] order = new int[] { 16,26,4,16,19,26,16,37,46,38,47,51,59,14,48,32,34,31,40,58,42,34,29,27,30,55,59,56,33,32,48,51,46,38,52,36,48,50,49,55,45,56,55,50,52,49,57,51,56,56,57,57,52,53,56,57,59,59,59,59,60 };
        private static int key = 9;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
