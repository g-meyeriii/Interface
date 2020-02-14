using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
        class HelloInPirate : HelloInLanguages {

        protected override void InitDictionary() {
            this.messages.Add(0,"Onward");
            this.messages.Add(1, "Arr");
            this.messages.Add(2, "Walk the plank");
            this.messages[7777] = "No Booty";
        }

        public HelloInPirate() : base() {

        }

    }
        
}



