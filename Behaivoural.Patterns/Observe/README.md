# Observe Pattern

used when there is one-to-many relationship between objects such as if one object is modified, its depenedent objects are to be notified automatically. Observer pattern falls under behavioral pattern category.[1](https://www.tutorialspoint.com/design_pattern/observer_pattern.htm)

. Increase flexibility in carrying out this communication

## Responabilities
Responsabilities between objexts. pattern of communication between objects.

## Participants

The classes and objects participating in this pattern are:

**Subject  (Stock)**
- knows its observers. Any number of Observer objects may observe a subject
- provides an interface for attaching and detaching 

**Observer objects.**
- ConcreteSubject  (IBM)
- stores state of interest to ConcreteObserver
sends a notification to its observers when its state - changes

**Observer  (IInvestor)**

- Defines an updating interface for objects that should be notified of changes in a subject.

**ConcreteObserver  (Investor)**
- Maintains a reference to a ConcreteSubject object
- Stores state that should stay consistent with the subject's
- Implements the Observer updating interface to keep its state consistent with the subject's

[Source Code](https://www.dofactory.com/net/observer-design-pattern)



  

[1. Design Patterns - Observer Pattern - tutorialspoint](https://www.tutorialspoint.com/design_pattern/observer_pattern.htm)
