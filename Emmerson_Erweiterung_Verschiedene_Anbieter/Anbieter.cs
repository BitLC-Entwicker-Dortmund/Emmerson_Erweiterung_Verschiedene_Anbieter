using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_Erweiterung_Verschiedene_Anbieter {
    internal class Anbieter {
        private string name;

        public void setName(string name) {
            this.name = name;
        }
        public string getName() {
            return name;
        }
        public Anbieter(string name) {
            this.name=name;
        }
    }
}
