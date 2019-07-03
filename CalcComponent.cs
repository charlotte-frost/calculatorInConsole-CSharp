using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public partial class CalcComponent : Component
    {
        public CalcComponent()
        {
            InitializeComponent();
        }

        public CalcComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
