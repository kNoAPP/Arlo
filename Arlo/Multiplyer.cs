using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace Arlo {
    public class Multiplyer {

        private static readonly int THREADS = Environment.ProcessorCount > 1 ? Environment.ProcessorCount - 1 : 1;
        private readonly Arlo view;
        private string _log;

        private static Object next = new object();
        private static Object largest = new object();
        private static Object log = new object();

        public Multiplyer(Arlo a) {
            this.view = a;
            this.IsRunning = false;
            this.Quick = false;
            this._log = "";
            this.LargestPass = new Tuple<int, BigInteger>(0, 0);
            this.NextEval = 0;
            this.Delay = (int) Math.Pow(2, 5);
        }

        public bool IsRunning { private set; get; }
        public bool Quick { set; get; }
        public int Delay { set; get; }
        public BigInteger NextEval { private set; get; }
        public string Log {
            get {
                string ret = (string) _log.Clone();
                lock(log)
                    _log = "";
                return ret;
            }
        }

        public Tuple<int, BigInteger> LargestPass { private set; get; }

        private void RunThread() {
            BigInteger assigned = 0;
            while(IsRunning) {
                lock(next) {
                    Thread.Sleep(Delay);
                    assigned = NextEval;
                    if(Quick) {
                        char[] ca = NextEval.ToString().ToCharArray();
                        if(ca[0] < '4')
                            ca[0]++;
                        else {
                            ca[0] = '2';

                            int index = ca.Length - 1;
                            while(true) {
                                if(index == 0) {
                                    ca = new char[ca.Length + 1];
                                    ca[0] = '2';
                                    for(int i = 1; i < ca.Length; i++)
                                        ca[i] = '7';
                                    break;
                                } else {
                                    if(ca[index] < '9') {
                                        char transform = ++ca[index];
                                        for(int i = index; i < ca.Length; i++)
                                            ca[i] = transform;
                                        break;
                                    } else index--;
                                }
                            }
                        }
                        NextEval = BigInteger.Parse(new string(ca));
                    } else NextEval++;
                }   

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
                    sb.Append("  * ");
                    sb.Append(newNum);
                    sb.Append(Environment.NewLine);

                    split = SplitInts(newNum);
                }

                lock(largest) {
                    if(passes > LargestPass.Item1 || (passes == LargestPass.Item1 && assigned < LargestPass.Item2))
                        LargestPass = new Tuple<int, BigInteger>(passes, assigned);
                }

                sb.Append("Passes: ");
                sb.Append(passes);
                sb.Append(Environment.NewLine + Environment.NewLine);
                lock(log)
                    _log += sb.ToString();
            }
        }

        private List<int> SplitInts(BigInteger num) {
            List<int> split = new List<int>();
            foreach(char c in num.ToString().ToCharArray())
                split.Add(int.Parse(c.ToString()));
            return split;
        }

        public void Start(BigInteger from) {
            NextEval = from > 0 ? from : 0;
            IsRunning = true;
            for(int i = 0; i < THREADS; i++)
                Task.Run(() => RunThread());
        }

        public void Stop() {
            IsRunning = false;
        }

        public void Reset() {
            Stop();
            this.Quick = false;
            _log = "";
            LargestPass = new Tuple<int, BigInteger>(0, 0);
            NextEval = 0;
            Delay = (int) Math.Pow(2, 5);
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
