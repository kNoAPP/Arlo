using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Arlo {
    public class Multiplyer {

        private static readonly int THREADS = Environment.ProcessorCount > 1 ? Environment.ProcessorCount - 1 : 1;
        private Arlo view;
        private string _log;

        public Multiplyer(Arlo a) {
            this.view = a;
            this.IsRunning = false;
            this._log = "";
            this.LargestPass = new Tuple<int, BigInteger>(1, 0);
            this.NextEval = 0;
        }

        public bool IsRunning { private set; get; }
        public BigInteger NextEval { private set; get; }
        public string Log {
            get {
                string ret = (string) _log.Clone();
                lock(this) {
                    _log = "";
                }
                return ret;
            }
        }

        public Tuple<int, BigInteger> LargestPass { private set; get; }

        private static Object large = new object();
        private void RunThread(BigInteger assigned) {
            while(IsRunning) {
                StringBuilder sb = new StringBuilder();
                sb.Append(assigned);
                sb.Append(Environment.NewLine);

                int passes = 0;
                List<int> split = SplitInts(assigned);
                while(split.Count > 1) {
                    passes++;
                    BigInteger newNum = 1;
                    foreach(int i in split)
                        newNum *= i;
                    sb.Append("  - ");
                    sb.Append(newNum);
                    sb.Append(Environment.NewLine);

                    split = SplitInts(newNum);
                }

                lock(large) {
                    if(passes > LargestPass.Item1 || (passes == LargestPass.Item1 && assigned < LargestPass.Item2))
                        LargestPass = new Tuple<int, BigInteger>(passes, assigned);
                }

                sb.Append("Passes: ");
                sb.Append(passes);
                sb.Append(Environment.NewLine + Environment.NewLine);
                assigned = SubmitNumber(sb.ToString());
            }
        }

        private List<int> SplitInts(BigInteger num) {
            List<int> split = new List<int>();
            foreach(char c in num.ToString().ToCharArray())
                split.Add(int.Parse(c.ToString()));
            return split;
        }

        public void Start(BigInteger from) {
            if(from < 0)
                from = 0;

            IsRunning = true;
            NextEval = from + 0;
            for(int i = 0; i < THREADS; i++)
                Task.Run(() => RunThread(from + i));
        }

        public void Stop() {
            IsRunning = false;
        }

        private BigInteger SubmitNumber(String toLog) {
            lock(this) {
                _log += toLog;
                NextEval++;
                return NextEval - 1;
            }
        }
    }
}
