#What is OOP?
+ An Object is a 'thing'
+ Objects have properties and methods
+ Properties are bits of data
+ Methods effect or manipulate the data
+ Objects have or implement certain characteristics
	+ Encapsulation
	+ Polymorphism
	+ Inheritance

##Encapsulation
+ Ensures an object groups all necessary properties and methods for a particular object. E.g. Customer might have Name and Address properties - and these would be define within the Customer object itself
+ Objects can contain other objects - for example a Customer might contain an Address object that has Street, Town and post code properties.
	+ Customer would be known as a root object
	+ Address would be known as a leaf object

##Polymorphism
+ Two objects may have the same properties and methods but implement them differently
+ Use of **interfaces** to define the properties and methods - the signature
+ Any objects that 'implement' the interface can be freely swapped in and out for each other without breaking the code.

##Inheritance
+ Objects can 'extend' other objects
+ A Person object might define common properties and methods - a Customer may inherit that Person object and add new properties and methods
+ Resultant Object contains all properties and methods of both the 'base' object and the new object.
