using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
     class HelloInEnglish : HelloInLanguages {
        
        

        protected override void InitDictionary() {
            this.messages.Add(0,"Ready");
            this.messages.Add(1, "Hello");
            this.messages.Add(2, "Good Bye");
            this.messages[7777] = "Error";
        }
        public HelloInEnglish() : base() {

        }
     }

}

