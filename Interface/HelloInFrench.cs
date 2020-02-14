using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class HelloInFrench : HelloInLanguages {

        protected override void InitDictionary() {
            this.messages.Add(0,"Pret") ;
            this.messages.Add(1, "Bonjour");
            this.messages.Add(2, "Auvoir");
            this.messages[7777] = "Mal";
        }
        public HelloInFrench() : base() {

        }
    }
    
}
