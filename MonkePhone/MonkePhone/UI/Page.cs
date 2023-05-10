using System;
using System.Collections.Generic;
using System.Text;

namespace MonkePhone.UI
{
    internal abstract class Page
    {
        /// <summary>
        /// Executes when the page is opened
        /// </summary>
        public virtual void OnPageEnter()
        {
        }

        public void SetItems(List<App> items)
        {

        }
    }
}
