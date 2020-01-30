using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClasses {
    class Program {
        static void Main (string [] args) {
            ArrayList myAL = new ArrayList ();
            string o = "Ein String";
            Person p = new Person () { Name = "Sebastian" };

            Person p2 = new Person ();

            //myAL.Add (o);
            //myAL.Add ( "Hello");
            //myAL.Add ( p );

            //Console.WriteLine (myAL.Count);
            ////myAL.RemoveAt (2);

            //Console.WriteLine ( ((Person) myAL[2]).Name );

            //foreach ( var item in myAL ) {
            //    if ( item is string ) {
            //        Console.WriteLine (item);
            //    }
            //    else if ( item is Person ) {
            //        //Console.WriteLine   (  (( Person ) item ).Name  );
            //        Person temp = ( Person ) item;
            //        Console.WriteLine (temp.Name);                    
            //    }

            //    else {
            //        Console.WriteLine ("me not");
            //    }
            //}

            //  ****************  Stack ****************

            // Lösung Aufgabe 1

            Stack stack = new Stack ();  // neues Stack-Objekt

            stack.Push ("Sieben");
            stack.Push ( "Acht" );
            stack.Push ( "Neun" );
            stack.Push ( "Zehn" );
            stack.Push ( "Bauer" );
            stack.Push ( "Dame" );
            stack.Push ( "König" );
            stack.Push ( "As" );

            //string karte = stack.Pop ().ToString();
            string karte =  (string)  stack.Pop () ;

            Console.WriteLine (karte);

            // ******** Beispiel mit Kartonobjekten *******
            
            Stack stack2 = new Stack ();
            stack2.Push (new Karte () { BezeichnungKarte="sieben"} );
            stack2.Push ( new Karte () { BezeichnungKarte = "acht" } );
            stack2.Push ( new Karte () { BezeichnungKarte = "neun" } );
            stack2.Push ( new Karte () { BezeichnungKarte = "zehn" } );
            stack2.Push ( new Karte () { BezeichnungKarte = "Bauer" } );
            stack2.Push ( new Karte () { BezeichnungKarte = "Dame" } );
            stack2.Push ( new Karte () { BezeichnungKarte = "König" } );
            stack2.Push ( new Karte () { BezeichnungKarte = "As" } );

            Karte eineKarte = (Karte) stack2.Pop ();
            Console.WriteLine (eineKarte.BezeichnungKarte);

            // **************** Queue ******************

            Queue wartezimmerWarteschlange = new Queue();

            wartezimmerWarteschlange.Enqueue (new Patient () {Name="Marco" } );
            wartezimmerWarteschlange.Enqueue ( new Patient () { Name = "Chris" } );
            wartezimmerWarteschlange.Enqueue ( new Patient () { Name = "Pascal" } );

            Patient derNächstePatient = (Patient) wartezimmerWarteschlange.Dequeue ();
            Console.WriteLine (derNächstePatient.Name);

            Console.ReadLine ();
        }
    }

    class Person {
        public string Name { get; set; } = "Hannah";
        public int Alter { get; set; } = 29;
    }

    class Karte {
        public string BezeichnungKarte { get; set; }
    }

    class Patient {
        public string Name { get; set; }
    }

}
