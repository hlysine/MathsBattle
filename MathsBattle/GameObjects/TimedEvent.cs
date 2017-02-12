using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsBattle.GameObjects
{
    public class TimedEvent
    {
        private int _loopNo = 0;
        private Timer T;

        public string Name { get; set; }
        public int LoopCount { get; set; }
        public int Interval { get; set; }
        public int LoopNo
        {
            get
            {
                return _loopNo;
            }
        }

        public event OnTickEventHandler OnTick;
        public delegate void OnTickEventHandler(object sender);

        public event OnFinishedEventHandler OnFinished;
        public delegate void OnFinishedEventHandler(object sender);

        public TimedEvent(string _Name, int _LoopCount, int _Interval)
        {
            Name = _Name;
            LoopCount = _LoopCount;
            Interval = _Interval;

            T = new Timer() { Interval = Interval };
            T.Tick += T_Tick;
        }

        public void Start()
        {
            T.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            _loopNo++;
            OnTick?.Invoke(this);
            if (_loopNo >= LoopCount)
            {
                T.Stop();
                OnFinished?.Invoke(this);
            }
        }

        ~TimedEvent()
        {
            T.Dispose();
            OnFinished = null;
            OnTick = null;
        }
    }
}
