using MediatorPattern;

IGroupMediator mediator = new ConcreteGroupMediator();

User oliver = new ConcreteUser(mediator, "Oliver");
User sophia = new ConcreteUser(mediator, "Sophia");
User james = new ConcreteUser(mediator, "James");
User emily = new ConcreteUser(mediator, "Emily");
User benjamin = new ConcreteUser(mediator, "Benjamin");

mediator.RegisterUser(oliver);
mediator.RegisterUser(sophia);
mediator.RegisterUser(james);
mediator.RegisterUser(emily);
mediator.RegisterUser(benjamin);

oliver.Send("The cat sat on the windowsill, watching the rain pour down.");
sophia.Send("She couldn't decide whether to take the scenic route or the shortcut.");
james.Send("The old bookstore smelled of leather-bound novels and fresh coffee.");
emily.Send("The cat ate the cake.");
benjamin.Send("He laughed so hard that his stomach started to ache.");