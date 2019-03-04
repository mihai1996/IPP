using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class LaptopBuilder
    {
        public abstract void setModel();
        public abstract void setGraphicsCard();
        public abstract void setProcessor();
        public abstract void setRam();
        public abstract void setHdd();
        public abstract void setSsd();
        public abstract Laptop getResult();
    }
}
