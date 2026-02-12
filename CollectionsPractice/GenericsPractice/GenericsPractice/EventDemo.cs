/*using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsPractice
{
    class Button //publisher
    {
        public event Action Clicked; //event based on built in delegate action

        public void Press()
        {
            Console.WriteLine("Button was Pressed");

            Clicked?.Invoke();//raise event safely only if subscribers present
        }
    }

    class ButtonEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    internal class EventDemo
    {
       static void OnButtonClicked()
       {
         Console.WriteLine("Event Recieved by Subscriber");
       }
       static void Main()
       {
          Button b = new Button();

          b.Clicked += OnButtonClicked;

          b.Press();
       }

       }
    }
*/
