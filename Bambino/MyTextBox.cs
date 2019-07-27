using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bambino
{
    public class MyTextBox : TextBox
    {
        private Timer _Timer = new Timer();

        public event EventHandler TextChangedDelayed;

        public MyTextBox()
        {
            _Timer.Interval = 500; // 0.5 seconds
            _Timer.Tick += new EventHandler(_Timer_Tick);
        }

        private void _Timer_Tick(object sender, EventArgs e)
        {
            _Timer.Stop();
            OnTextChangedDelayed();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            _Timer.Stop();
            _Timer.Start();
        }

        protected virtual void OnTextChangedDelayed()
        {
            if (TextChangedDelayed != null)
                TextChangedDelayed(this, EventArgs.Empty);
        }

        public int TextChangedDelayedInterval
        {
            get { return _Timer.Interval; }
            set { _Timer.Interval = value; }
        }

    }
}
