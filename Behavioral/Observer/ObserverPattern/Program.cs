using ObserverPattern._01_Approach;
using ObserverPattern._02_Approach;
using NewsAgency = ObserverPattern._01_Approach.NewsAgency;

// First approach
User user01 = new ("User 01");
User user02 = new ("User 02");
School school01 = new ("School 01");
School school02 = new ("School 02");

NewsAgency newsAgency = new ();
newsAgency.Register(user01);
newsAgency.Register(user02);
newsAgency.Register(school01);
newsAgency.Register(school02);
newsAgency.Notify("01. News about something...");

newsAgency.Unregister(user01);
newsAgency.Unregister(school01);
newsAgency.Notify("02. News about something...");

Console.WriteLine("============================================");

// Second approach
var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA, "Observer A");

var observerB = new ConcreteObserverB();
subject.Attach(observerB, "Observer B");

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.Detach(observerB, "Observer B");

subject.SomeBusinessLogic();