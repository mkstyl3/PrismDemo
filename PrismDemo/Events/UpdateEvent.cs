using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  This define the Event. Change type string for other if you need.
 *  We can define more events, only change the name of the class to
 *  smth more generic like Events.cs or so
 */ 
namespace PrismDemo.Events
{	
    class UpdateEvent: PubSubEvent<string>
    {
    }

    //class SaveEvent : PubSubEvent<Person>
    //{
    //}
}
