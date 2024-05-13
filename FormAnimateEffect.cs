using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtorizacia
{
    public partial class FormAnimateEffect : Component
    {
        public FormAnimateEffect()
        {
            InitializeComponent();
        }

        public FormAnimateEffect(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
