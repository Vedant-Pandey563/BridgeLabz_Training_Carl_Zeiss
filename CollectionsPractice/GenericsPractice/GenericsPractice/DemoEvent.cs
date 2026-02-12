using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    class ButtonEventArgs : EventArgs
    {
        public string Message { get; set; } //holds details abt button clicked
    }

    class Button //publisher or event raiser
    {
        public event EventHandler<ButtonEventArgs> Clicked; //event declared , uses 

        public void Press()
        {
            Console.WriteLine("Button Pressed");
           
            
            // create event data
            var args = new ButtonEventArgs() // call event args creates anew button event args object
            {
                Message = "Clicked at " + DateTime.Now
            };
            //raise the event
            Clicked?.Invoke(this, args); 
            // multicast delegate  ? check for subs , Invoke calls sub handlers, this sender, args event data
        }
    }

    internal class DemoEvent
    {
        //event handler
        static void HandleClick(object sender, ButtonEventArgs e) //event handler , sub method
        {
            Console.WriteLine("Received :" + e.Message);
        }
        
        static void Main()
        {
            Button b = new Button();

            //sub to event
            b.Clicked += HandleClick; // sub to evnet

            //trigger event
            b.Press();
        }
    }
}
