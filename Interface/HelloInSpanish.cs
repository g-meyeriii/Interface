using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class HelloInSpanish : HelloInLanguages {

        protected override void InitDictionary() {
            this.messages.Add(0,"Listo");
            this.messages.Add(1, "Hola");
            this.messages.Add(2, "Via con Dios");
            this.messages[7777] = "No Bueno";
        }

        public HelloInSpanish() : base() {

        }
    }
    
}
