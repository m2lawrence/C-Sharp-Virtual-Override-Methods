# C-Sharp-Virtual-Override-Methods
C Sharp Virtual Methods that override the base class.

Caution!
Although each of the variables in Lines 70–72 (Brad, me, and worker) is assigned an object of a different types, only the data 
members and methods within its declared type, Person, are available.

In Lines 74–76, you see the results of using virtual and overridden methods. Although all three of the variables calling displayFullName 
are Person types, each is calling the overridden method associated with the actual data that was assigned. 

They don’t all call the displayFullName method of the Person class. This is almost always the result that you will want.

Kind regards,
Mike.
