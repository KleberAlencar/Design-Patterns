using ObserverPattern._01_Approach;

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


