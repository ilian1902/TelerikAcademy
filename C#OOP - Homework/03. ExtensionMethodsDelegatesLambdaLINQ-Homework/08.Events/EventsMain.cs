namespace Events
{
    using System;

    class EventsMain
    {
        static void Main()
        {
            Publish eventPublisher = new Publish();
            new Subscriber("Pesho", eventPublisher); //create subscribers for the event
            new Subscriber("Gosho", eventPublisher);
            eventPublisher.RaiseSampleEvent();
        }
    }
}
