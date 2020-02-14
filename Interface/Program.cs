using System;
using System.Collections.Generic;

namespace Interface {
    class Program {

        static void Main(string[] args) {
        

        var english = new HelloInEnglish();
        var spanish = new HelloInSpanish();

            var hello = new Hello(english);
            hello.Speak();

            var hello2 = new Hello(spanish);
            hello2.Speak();

            var hellofr = new Hello(new HelloInFrench());
            hellofr.Speak();

            (new Hello(new HelloInPirate())).Speak();







        }
    }
}



    



