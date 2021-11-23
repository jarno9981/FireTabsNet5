using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireTabsNet5;

namespace testtabs
{
    public partial class Container : FireTitle
    {
        public Container()
        {
            InitializeComponent();
            TabRenderer = new FireTabRenderer(this);
        }

        public override FireTitleTab CreateTab()
        {
            return new FireTitleTab(this)
            {
                Content = new Browser
                {
                    Text = "Fire Browser"
                }
            };
        }
    }
}
