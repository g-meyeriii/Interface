using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    abstract class HelloInLanguages : ISpeakable {


        protected Dictionary<int, string> messages = new Dictionary<int, string>{ [7777] = "Message number not found"
        };
        protected abstract void InitDictionary();

        public virtual string GetMessage(int MessageNumber) {
            if (!messages.ContainsKey(MessageNumber)) {
                return messages[7777];
            }
            return messages[MessageNumber];
        }

        public HelloInLanguages() {
            InitDictionary();
        }
    }
}

