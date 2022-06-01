using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBattlerSharp.GUI.CustomControls
{
    /// <summary>
    /// This makes sure the Click event gets unsubscribed before Disposing
    /// </summary>
    internal class SafeButton : Button
    {
        private EventHandler clickHandler;
        public SafeButton(EventHandler eventHandler)
        {
            this.clickHandler = eventHandler;
            this.Click += clickHandler;
        }

        protected override void Dispose(bool disposing)
        {
            this.Click -= clickHandler;
            base.Dispose(disposing);
        }
    }
}
