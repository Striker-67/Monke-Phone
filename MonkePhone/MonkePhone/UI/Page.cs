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

        public void SetText(StringBuilder stringBuilder)
        {
        }
        public void DrawPage(List<App> items)
        {

        }
    }
}
