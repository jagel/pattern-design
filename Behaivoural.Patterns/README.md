
Behavioral design patterns are concerned with algorithms and the assignment of responsibilities between objects.[1]


[1] Source:https://refactoring.guru/design-patterns/behavioral-patterns


  https://www.dofactory.com/net/observer-design-pattern
     Participants

    The classes and objects participating in this pattern are:

    Subject  (Stock)
    knows its observers. Any number of Observer objects may observe a subject
    provides an interface for attaching and detaching Observer objects.
    ConcreteSubject  (IBM)
    stores state of interest to ConcreteObserver
    sends a notification to its observers when its state changes
    Observer  (IInvestor)
    defines an updating interface for objects that should be notified of changes in a subject.
    ConcreteObserver  (Investor)
    maintains a reference to a ConcreteSubject object
    stores state that should stay consistent with the subject's
    implements the Observer updating interface to keep its state consistent with the subject's
