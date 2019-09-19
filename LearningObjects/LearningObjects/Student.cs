using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningObjects {
    class Student : Person {
        private int _StudentID;

        public int StudentID {
            get {
                return _StudentID;
            }
            set {
                if (value > 0) {
                    _StudentID = value;
                }
            }
        }

        public override string SayYourName() {
            return string.Format("Hi, I am {0}!!!",FirstName);
        }

        public override string ToString() {
            return "I am a Student, my name is " + this.FirstName;
        }

        public Student CloneMe() {
            return this;
        }

    }
}
