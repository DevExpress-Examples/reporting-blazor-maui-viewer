namespace DxReportViewerMauiApp.CachedDocumentSourceReport {
    class DeterministicRandom {
        const int randomCount = 10000;
        static readonly int[] deterministicRandomNumbers;
        static readonly DateTime time;
        int rnd;
        int Next {
            get {
                rnd = deterministicRandomNumbers[rnd % randomCount];
                return rnd;
            }
        }
        public char RandomChar {
            get {
                return (char)((int)'A' + Random(0, 26));
            }
        }
        public int[] RandomList(int count, int to) {
            int[] res = new int[count];
            for(int i = 0; i < Math.Min(count, to); i++)
                res[i] = i;
            for(int i = to; i < count; i++)
                res[i] = Random(to);

            for(int i = 0; i < count; i++) {
                int ind = Random(count);
                int temp = res[ind];
                res[ind] = res[i];
                res[i] = temp;
            }
            return res;
        }
        public int Random(int to) {
            return Random(0, to);
        }
        public int Random(int from, int to) {
            return Next % Math.Max(1, to - from) + from;
        }
        public T GetRandomItem<T>(IList<T> list) {
            return list[Next % list.Count];
        }
        public DateTime RandomTime() {
            return RandomTime(time, 0, 30 * 24);
        }
        public DateTime RandomTime(DateTime from, int fromHours, int toHours) {
            return from.AddHours(Next % (toHours - fromHours) + fromHours);
        }

        static DeterministicRandom() {
            time = DateTime.Now.AddDays(-62);
            time = DevExpress.XtraPrinting.Native.DateTimeHelper.Now.AddDays(-62);//DEMO_REMOVE
            Random currentRandom = new Random(randomCount);
            deterministicRandomNumbers = new int[randomCount];
            for(int i = 0; i < randomCount; i++)
                deterministicRandomNumbers[i] = currentRandom.Next(randomCount);
        }
        public DeterministicRandom(int i) {
            this.rnd = i + (i >> 10) + (i >> 20);
        }
    }
}
